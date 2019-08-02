Module CreateDirectories
    'Module responsible for creation of the application Directories
    Sub CreateTempDir(ByVal Location As String)
        Try
            Dim errorpath As String = Location & "\" & "Error"
            Dim cachepath As String = Location & "\" & "Cache"
            Dim CompletedPath As String = Location & "\" & "Completed"
            Dim tempdir As String = Location & "\" & "Temp"
            If (My.Computer.FileSystem.DirectoryExists(errorpath)) Then
            Else
                MkDir(Location & "\" & "Error")
            End If
            If (My.Computer.FileSystem.DirectoryExists(errorpath)) Then
            Else
                MkDir(Location & "\" & "Cache")
            End If
            If (My.Computer.FileSystem.DirectoryExists(tempdir)) Then
            Else
                MkDir(Location & "\" & "Temp")
            End If
            If (My.Computer.FileSystem.DirectoryExists(errorpath)) Then
            Else
                MkDir(Location & "\" & "Completed")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Module
