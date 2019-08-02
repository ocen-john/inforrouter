Option Explicit On
Option Strict On

Module Module_UploadDocument3

    Sub UploadDocument3(ByVal ServiceURL As String, ByVal AuthenticationTicket As String)

        Const uploadpath As String = "/TestDomain/sample/s.doc"
        Const LocalFilePath As String = "c:\temp\SummerPlan.doc"
        Dim VersionComment As String = "Lorem dolor sit amet line 1....." + Environment.NewLine + _
                                       "Lorem dolor sit amet line 2....." + Environment.NewLine + _
                                       "Lorem dolor sit amet line 3....."
        Const CheckoutFlag As Boolean = True

        Dim IR_OBJ As InfoRouter.srv

        Try
            If System.IO.File.Exists(LocalFilePath) Then
                Dim FileName As String = System.IO.Path.GetFileName(LocalFilePath)
                Dim buffer() As Byte

                IR_OBJ = New InfoRouter.srv
                IR_OBJ.Url = ServiceURL

                'create byte array to upload
                Dim fs As System.IO.FileStream = New System.IO.FileStream(LocalFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                Dim br As System.IO.BinaryReader = New System.IO.BinaryReader(fs) ' create a BinaryReader
                buffer = br.ReadBytes(Convert.ToInt32(fs.Length))
                br.Close()
                fs.Close()
                br = Nothing
                fs = Nothing

                'call upload method
                Dim xml_response As System.Xml.XmlNode = IR_OBJ.UploadDocument3(AuthenticationTicket, uploadpath, buffer, VersionComment, CheckoutFlag)

                'check response xml if any error occured.
                If xml_response.Attributes("success").Value.ToUpperInvariant() = "TRUE" Then
                    Console.WriteLine("The Document has been uploaded successfully.")
                Else
                    Console.WriteLine("The Document cannot be uploaded.")
                    Console.WriteLine("ERROR:" & xml_response.Attributes("error").Value)
                End If
                xml_response = Nothing
            Else
                Console.WriteLine("ERROR:Local file not found.")
            End If
        Catch ex As Exception
            Console.WriteLine("ERROR:" + ex.Message)
        Finally
            IR_OBJ = Nothing
        End Try
    End Sub

End Module
