Module DocIndexing
    'This Module creates a property set file based on the attributes of the file Name 
    'It later indexes the file using the generated property set information
    Function GetDocType(ByVal docPath As String) As String
        'Function Retrieves the Document Type given the Document name
        Dim docName As String = ""
        Try
            Select Case docPath = ""
                Case docPath.Contains("Acceptance From The Successful Bidder")
                    docName = "Acceptance From The Successful Bidder"
                Case 6, 7, 8

                Case 9 To 10

                Case Else

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return docName
    End Function



End Module
