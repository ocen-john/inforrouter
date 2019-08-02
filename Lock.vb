Option Explicit On
Option Strict On

Module Module_Lock
    Sub Lock(ByVal ServiceURL As String, ByVal AuthenticationTicket As String)
        Const IR_DocumentPath As String = "TestDomain/Samples/SummerPlan.doc"
        Dim IR_OBJ As InfoRouter.srv

        Try
            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = ServiceURL

            Dim xmlResponse As System.Xml.XmlNode = IR_OBJ.Lock(AuthenticationTicket, IR_DocumentPath)

            If xmlResponse.Attributes("success").Value.ToUpperInvariant() = "TRUE" Then
                Console.WriteLine("The document has been Locked.")
            Else
                Console.WriteLine("The document cannot be Locked.")
                Console.WriteLine("server response:" & xmlResponse.Attributes("error").Value)
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            Console.WriteLine("Error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
        End Try
    End Sub

End Module
