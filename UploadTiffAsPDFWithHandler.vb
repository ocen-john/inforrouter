Option Explicit On
Option Strict On
Imports System.Windows.Forms

Module Module_UploadTiffAsPDFWithHandler

    Public Sub UploadTiffAsPDFWithHandler(ByVal ServiceURL As String, ByVal AuthenticationTicket As String)

        Const SourceFilePath As String = "c:\ScannedImages\1234-1234-AB.TIFF"
        Const TargetIRPath As String = "/Accounting/ScannedInvoices/1234-1234-AB.PDF"
        Dim IR_OBJ As InfoRouter.srv
        Dim crcx As CRC
        Dim xml_response As System.Xml.XmlNode
        Try

            If Not System.IO.File.Exists(SourceFilePath) Then
                MessageBox.Show("ERROR: Local file not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Return
            End If

            'Dim FileName As String = System.IO.Path.GetFileName(SourceFilePath)
            Dim buffer() As Byte
            Dim uplHandler As String = ""
            Dim ChunkSize As Integer = 10000

            IR_OBJ = New InfoRouter.srv

            xml_response = IR_OBJ.CreateUploadHandler(AuthenticationTicket, ChunkSize)

            'check response xml if any error occured.
            If Not xml_response.Attributes("success").Value = "true" Then
                MessageBox.Show("ERROR:" + xml_response.Attributes("error").Value, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Return
            End If

            uplHandler = xml_response.Attributes("UploadHandler").Value
            'server might set different chunksize
            ChunkSize = Integer.Parse(xml_response.Attributes("ChunkSize").Value)


            'Open a Binary reader for chunk upload
            Dim fs As System.IO.FileStream = New System.IO.FileStream(SourceFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
            Dim br As System.IO.BinaryReader = New System.IO.BinaryReader(fs) ' create a BinaryReader
            Dim fileoffset As Integer = 0
            Dim filelength As Long = fs.Length
            Dim filecrc As Long = 0
            Dim returnedFileCRC As Integer = 0
            Dim intcrc As Integer = 0

            crcx = New CRC
            filecrc = crcx.GetCrc32(CType(fs, System.IO.Stream))
            fs.Seek(0, IO.SeekOrigin.Begin)


            'start chunk upload loop
            Do
                buffer = br.ReadBytes(ChunkSize)
                If buffer.Length > 0 Then
                    intcrc = crcx.GetCrc32(buffer)
                    fileoffset += ChunkSize
tryagain:
                    Dim booltry As Boolean = False
                    Dim errmessage As String = ""
                    Dim lastChunk As Boolean = ((buffer.Length < ChunkSize) Or (filelength = fileoffset))
                    'upload a chunk
                    If Not uplchunk(IR_OBJ, AuthenticationTicket, uplHandler, buffer, booltry, errmessage, lastChunk, intcrc, returnedFileCRC) Then
                        If booltry Then
                            If MessageBox.Show(errmessage, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.Retry Then
                                GoTo tryagain
                            Else
                                Return
                            End If
                        Else
                            MessageBox.Show(errmessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Return
                        End If
                    End If

                    If lastChunk Then
                        If returnedFileCRC <> filecrc Then
                            MessageBox.Show("Ooops! Server returned checksum is different than local file checksum.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Return
                        End If
                    End If
                End If
            Loop Until buffer.Length = 0
            br.Close()
            fs.Close()
            crcx = Nothing
            br = Nothing
            fs = Nothing

            'All chunks successfully uploaded to the server
            'Now uploaded blob reference is uplHandler

            'Call the UploadTifffAsPDFwithHandler function 
            xml_response = IR_OBJ.UploadTiffAsPDFWithHandler(AuthenticationTicket, TargetIRPath, uplHandler)
            If xml_response.Attributes("success").Value = "true" Then
                MessageBox.Show("The Document has been successfully uploaded", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                'garbage collection for the server. this is optional. Server is automatically releases the handlers in the certain time of inactivitiy
                IR_OBJ.DeleteUploadHandler(AuthenticationTicket, uplHandler)

            Else
                MessageBox.Show("ERROR:" + xml_response.Attributes("error").Value, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If

            'call upload method
            xml_response = Nothing
        Catch ex As Exception
            MessageBox.Show("EXCEPTION:" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Finally
            xml_response = Nothing
            IR_OBJ = Nothing
        End Try

    End Sub

    Private Function uplchunk(ByRef ir_obj As InfoRouter.srv, _
                      ByVal AuthenticationTicket As String, _
                      ByVal uplhandler As String, _
                      ByRef buffer() As Byte, _
                      ByRef tryagain As Boolean, _
                      ByRef errmessage As String, _
                      ByVal lastchunk As Boolean, _
                      ByRef intcrc As Integer, _
                      ByRef ReturnedFileCRC As Integer) As Boolean


        Dim xml_response As System.Xml.XmlNode = Nothing
        Try
            tryagain = False

            xml_response = ir_obj.UploadFileChunk(AuthenticationTicket, uplhandler, buffer, Hex(intcrc).ToString, lastchunk)

            If xml_response.Attributes("success").Value = "true" Then
                If lastchunk Then
                    ReturnedFileCRC = Integer.Parse(xml_response.Attributes("filehexcrc").Value, System.Globalization.NumberStyles.HexNumber)
                End If

                Return True
            Else
                If xml_response.Attributes("tryagain").Value = "true" Then
                    tryagain = True
                Else
                    errmessage = xml_response.Attributes("error").Value
                End If
            End If

        Catch ex As Exception
            errmessage = ex.Message
        Finally
            xml_response = Nothing
        End Try
    End Function
End Module


'CHECK SUM CALCULATION CLASS
Public Class CRC
    ' originated by CRC32 algorithm provided by Paul ' (wpsjr1@succeed.net) 

    Private crc32Table() As Integer
    Private Const BUFFER_SIZE As Integer = 1024

    Private tdeskey() As Byte = {117, 116, 107, 117, 38, 98, 97, 104, 97, 114, 64, 116, 111, 112, 114, 97, 107, 38, 110, 101, 104, 105, 114, 35}
    Private tdesIV() As Byte = {49, 57, 55, 50, 49, 49, 48, 50}

    Public Function GetCrc32(ByRef stream As System.IO.Stream) As Integer

        Dim crc32Result As Integer
        crc32Result = &HFFFFFFFF

        Dim buffer(BUFFER_SIZE) As Byte
        Dim readSize As Integer = BUFFER_SIZE

        Dim count As Integer = stream.Read(buffer, 0, readSize)
        Dim i As Integer
        Dim iLookup As Integer
        Dim tot As Integer = 0
        Do While (count > 0)
            For i = 0 To count - 1
                iLookup = (crc32Result And &HFF) Xor buffer(i)
                crc32Result = ((crc32Result And &HFFFFFF00) \ &H100) And &HFFFFFF   ' nasty shr 8 with vb :/
                crc32Result = crc32Result Xor crc32Table(iLookup)
            Next i
            count = stream.Read(buffer, 0, readSize)
        Loop

        GetCrc32 = Not (crc32Result)
    End Function

    Public Function GetCrc32(ByRef BufferX() As Byte) As Integer

        Dim crc32Result As Integer
        crc32Result = &HFFFFFFFF

        Dim count As Integer = BufferX.Length
        Dim i As Integer
        Dim iLookup As Integer
        Dim tot As Integer = 0
        For i = 0 To count - 1
            iLookup = (crc32Result And &HFF) Xor BufferX(i)
            crc32Result = ((crc32Result And &HFFFFFF00) \ &H100) And &HFFFFFF   ' nasty shr 8 with vb :/
            crc32Result = crc32Result Xor crc32Table(iLookup)
        Next i

        GetCrc32 = Not (crc32Result)

    End Function

    Public Sub New()
        ' This is the official polynomial used by CRC32 in PKZip.
        ' Often the polynomial is shown reversed (04C11DB7).
        Dim dwPolynomial As Integer = &HEDB88320
        Dim i As Integer
        Dim j As Integer

        ReDim crc32Table(256)
        Dim dwCrc As Integer

        For i = 0 To 255
            dwCrc = i
            For j = 8 To 1 Step -1
                If CBool(dwCrc And 1) Then
                    dwCrc = CInt(((dwCrc And &HFFFFFFFE) \ 2&) And &H7FFFFFFF)

                    dwCrc = dwCrc Xor dwPolynomial
                Else
                    dwCrc = CInt(((dwCrc And &HFFFFFFFE) \ 2&) And &H7FFFFFFF)
                End If
            Next j
            crc32Table(i) = dwCrc
        Next i
    End Sub

End Class
