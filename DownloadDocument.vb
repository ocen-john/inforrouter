Option Explicit On
Option Strict On

Module module_DownloadDocument
    Sub DownloadDocument(ByVal ServiceURL As String, ByVal AuthenticationTicket As String)

        'Input Variables
        Const IRDocPath As String = "/TestDomain/samples/SummerPlan.doc"
        Const DownloadPath As String = "c:\temp\"

        Dim IR_OBJ As InfoRouter.srv
        Try

            'Update the reference
            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = ServiceURL

            Dim FileName As String = System.IO.Path.GetFileName(IRDocPath)
            'call downloaddocument method to get bytearray
            Dim buffer As Byte() = IR_OBJ.DownloadDocument(AuthenticationTicket, IRDocPath)
            If IsArray(buffer) Then
                Dim fs As System.IO.FileStream = New System.IO.FileStream(DownloadPath & FileName, System.IO.FileMode.Create, IO.FileAccess.Write)
                Dim bw As System.IO.BinaryWriter = New System.IO.BinaryWriter(fs)
                'write bytearray to the local path
                bw.Write(buffer)
                bw.Close()
                fs.Close()
                bw = Nothing
                fs = Nothing
                Console.WriteLine("The document has been downloaded")
            Else
                Dim xml_response As System.Xml.XmlNode = IR_OBJ.GetDownloadInfo(AuthenticationTicket, IRDocPath)
                If Not (xml_response.Attributes("success").Value.ToUpperInvariant() = "TRUE") Then
                    Console.WriteLine("Server Response :" & xml_response.Attributes("error").Value)
                End If
                xml_response = Nothing
            End If

        Catch EX As Exception
            Console.WriteLine("error:" & EX.Message)
        Finally
            IR_OBJ = Nothing
        End Try
    End Sub
End Module
