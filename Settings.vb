Imports System.Xml.Linq

Module Settings
    Sub saveSettings(ByVal ProcessingDir As String)
        Dim settingsFile As XElement
        settingsFile = New XElement("Settings",
                                    New XElement("ProcessingDir", ProcessingDir))
        settingsFile.Save(ProcessingDir + "\settings.xml")

    End Sub

    Function showSettings(ByVal ProcessingDir As String) As String
        Dim doc As XmlDocument
        Dim processingPath As String = ""
        doc = New XmlDocument
        Try
            doc.Load(ProcessingDir + "\settings.xml")
            processingPath = doc.GetElementById("ProcessingDir").Value
        Catch ex As Exception
            MsgBox("Cannot Show Processing Path Error" + ex.Message)
        End Try

        Return processingPath
    End Function

End Module
