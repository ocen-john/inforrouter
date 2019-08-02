Imports System.Xml.Linq
Imports System.Linq
Imports System.Data.Linq

Module CreateQueFile
    Sub MoveContentToProcessing(ByVal source As String, ByVal destination As String)
        Dim rootElement As XElement
        Dim cachepath As String = destination & "\" & "Cache"
        Try
            rootElement = WriteRootElement()
            For Each folder As String In My.Computer.FileSystem.GetDirectories(source)
                Dim cmpts As Integer = folder.Split("\").Length
                Dim folderpath As String = folder.Split("\").GetValue(cmpts - 1)
                My.Computer.FileSystem.MoveDirectory(folder, cachepath + "\" + folderpath)

                'Update the Que file with File Details'

            Next
        Catch ex As Exception
            MsgBox("Moving to Processing Directory Error " + ex.Message)
        End Try
    End Sub
    Function WriteRootElement() As XElement
        Dim RootElement As XElement
        RootElement = New XElement("Batches")
        Return RootElement
    End Function
    Function WriteBatchLog(ByVal Doc As XElement, ByVal folderName As String, ByVal Logfile As String) As Boolean
        Dim Writeerror As Boolean = False
        Dim batchLog As XElement
        batchLog = New XElement("Batch")
        Return Writeerror
    End Function
    Function CreateDocElement(ByVal folderName As String, ByVal source As String, ByVal QueFilePath As String) As XElement

        Dim DocContainer As XElement
        DocContainer = New XElement("Documents")
        Dim docfoldercntr As Integer
        Try

            For Each document As String In My.Computer.FileSystem.GetFiles(folderName)
                'Create XML for Document
                DocContainer.Add(New XElement("Doc", New XElement("Path", document)))
                docfoldercntr = docfoldercntr + 1
            Next
        Catch ex As Exception
            MsgBox("Create Doc Element Error" & ex.Message)
        End Try

        Return DocContainer

    End Function

    Sub CreateDocumentQueFile()
        Try

        Catch ex As Exception

        End Try

    End Sub

End Module
