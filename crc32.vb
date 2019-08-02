Imports System.IO
'Imports System.text
Imports System.Security.Cryptography

Public Class CRC32

    ' This is v2 of the VB CRC32 algorithm provided by Paul
    ' (wpsjr1@succeed.net) - much quicker than the nasty
    ' original version I posted.  Excellent work!

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
        Dim i As Integer, j As Integer

        ReDim crc32Table(256)
        Dim dwCrc As Integer

        For i = 0 To 255
            dwCrc = i
            For j = 8 To 1 Step -1
                If (dwCrc And 1) Then
                    dwCrc = ((dwCrc And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                    dwCrc = dwCrc Xor dwPolynomial
                Else
                    dwCrc = ((dwCrc And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                End If
            Next j
            crc32Table(i) = dwCrc
        Next i


    End Sub

    Public Function TripleDESFile(ByVal inName As String, _
                                  ByVal outName As String, _
                                  ByVal Encrypt As Boolean, _
                                  ByRef ResponseStr As String) As Boolean
        Dim fin As FileStream
        Dim fout As FileStream
        Dim encStream As CryptoStream
        Dim InFileOpened As Boolean
        Dim OutFileOpened As Boolean
        Try

            Try
                fin = New FileStream(inName, FileMode.Open, FileAccess.Read)
                InFileOpened = True

            Catch ex As Exception
                ResponseStr = "[00100]Input file cannot be opened." & ex.Message
            End Try

            If InFileOpened Then
                Try
                    fout = New FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write)
                    OutFileOpened = True

                Catch ex As Exception
                    ResponseStr = "[00100]Output file cannot be created or opened." & ex.Message
                End Try

                If OutFileOpened Then
                    fout.SetLength(0)

                    'Create variables to help with read and write.
                    Dim bin(1024) As Byte 'This is intermediate storage for the encryption.
                    Dim rdlen As Long = 0 'This is the total number of bytes written.
                    Dim totlen As Long = fin.Length 'This is the total length of the input file.
                    Dim len As Integer 'This is the number of bytes to be written at a time.
                    Dim tdes As New TripleDESCryptoServiceProvider
                    If Encrypt Then
                        encStream = New CryptoStream(fout, tdes.CreateEncryptor(tdeskey, tdesIV), CryptoStreamMode.Write)
                    Else
                        encStream = New CryptoStream(fout, tdes.CreateDecryptor(tdeskey, tdesIV), CryptoStreamMode.Write)
                    End If
                    'Read from the input file, then encrypt and write to the output file.
                    While rdlen < totlen
                        len = fin.Read(bin, 0, 1024)
                        encStream.Write(bin, 0, len)
                        rdlen = rdlen + len
                        'Console.WriteLine("{0} bytes processed", rdlen)
                    End While
                    encStream.Close()
                    encStream = Nothing

                    fout.Close()
                    fout = Nothing
                    TripleDESFile = True
                End If

                fin.Close()
                fin = Nothing
            End If

        Catch ex As Exception
            ResponseStr = "[00100]TripleDESFile(), " & ex.Message
        Finally
            encStream = Nothing
            fout = Nothing
            fin = Nothing
        End Try
    End Function

End Class
