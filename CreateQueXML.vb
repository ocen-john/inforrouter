Imports System.Xml.Linq
Imports System.Linq
Imports System.Data.Linq

Module CreateQueXML
    Function CreateTopLevel(ByVal info As XElement) As XElement

        Dim doc As XElement
        doc = New XElement("Batches")
        doc.Add(info)
        Return doc
    End Function

    Function CreateBatchInfo(ByVal Id As String, ByVal Path As String, ByVal docCont As XElement, ByVal ProcName As String) As XElement
        'Info is the Root Element
        ''DocCont is the Document Element
        Dim Info As XElement
        Info = New XElement("Batch", New XAttribute("name", ProcName),
                              New XAttribute("Id", Id),
                              New XAttribute("Path", Path), docCont)

        Return Info
    End Function

    Function CreateDocInfo(ByVal Info As XElement, ByVal DocName As String, ByVal Path As String) As XElement
        Info.Add(New XElement("Doc", New XAttribute("name", DocName), New XAttribute("path", Path)))
        Return Info
    End Function

    Function saveXML(ByVal info As XElement, ByVal filepath As String) As Boolean
        Try
            info.Save(filepath)
        Catch ex As Exception
            MsgBox("-Save LOG XML Error- " + ex.Message)
        End Try
        Return True
    End Function

    Function DeleteQueFileElements(ByVal ElementName As String) As Boolean
        Try

        Catch ex As Exception

        End Try
    End Function

End Module
