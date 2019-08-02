Option Explicit On
Option Strict On

Module Modul_CreateDocumentUsingTemplate

    Public Sub CreateDocumentUsingTemplate(ByVal ServiceURL As String, ByVal AuthenticationTicket As String)

        Const IRNewDocumentPath As String = "/samplelib/memo-guirules.htm"
        Const TemplatePath As String = "/Form Templates/memo.htm"
        Dim IR_OBJ As InfoRouter.srv
        Try

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = ServiceURL

            Dim patientdata_xml As System.Xml.XmlDocument
            Dim DataElem As System.Xml.XmlElement
            patientdata_xml = New System.Xml.XmlDocument
            patientdata_xml.LoadXml("<FORMDATA/>")

            DataElem = patientdata_xml.CreateElement("Prompt")
            DataElem.SetAttribute("Prompt", "MemoDate")
            DataElem.InnerText = "2005-05-01"
            patientdata_xml.DocumentElement.AppendChild(DataElem)

            DataElem = patientdata_xml.CreateElement("Prompt")
            DataElem.SetAttribute("Name", "Author")
            DataElem.InnerText = "Ed Mahoney"
            patientdata_xml.DocumentElement.AppendChild(DataElem)

            DataElem = patientdata_xml.CreateElement("Prompt")
            DataElem.SetAttribute("Name", "Subject")
            DataElem.InnerText = "New GUI Rules"
            patientdata_xml.DocumentElement.AppendChild(DataElem)

            DataElem = patientdata_xml.CreateElement("Prompt")
            DataElem.SetAttribute("Name", "MemoBody")
            DataElem.InnerText = "Lorem dolor sit amet....."
            patientdata_xml.DocumentElement.AppendChild(DataElem)

            Dim xml_response As System.Xml.XmlNode
            xml_response = IR_OBJ.CreateDocumentUsingTemplate(AuthenticationTicket, IRNewDocumentPath, TemplatePath, patientdata_xml.OuterXml)
            'check response xml if any error occured.
            If xml_response.Attributes("success").Value.ToUpperInvariant() = "TRUE" Then
                Console.WriteLine("The Document has been created using template successfully")
            Else
                Console.WriteLine("The Document cannot be created.")
                Console.WriteLine("ERROR:" + xml_response.Attributes("error").Value)
            End If
            xml_response = Nothing
            DataElem = Nothing
            patientdata_xml = Nothing

        Catch ex As Exception
            Console.WriteLine("ERROR:" + ex.Message)
        Finally
            IR_OBJ = Nothing
        End Try
    End Sub
End Module
