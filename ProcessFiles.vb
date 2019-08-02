Imports System.Xml.Linq
Imports System.Linq
Imports System.Data.Linq

Module ProcessFiles
    Sub MoveContentToProcessing(ByVal QueFilePath As String, ByVal source As String, ByVal destination As String)
        Dim rootElement As XElement
        Dim fdCntr As Integer = 0
        Dim cachepath As String = destination & "\" & "Cache"
        Dim BatchInfo As XElement
        Dim DocContainer As XElement
        Dim cmpts As Integer
        Dim folderpath As String
        Dim DestinationPath As String
        Dim docfoldercntr As Integer
        Dim OldBatchLogFile As XElement

        Dim Doccmpts As String
        Dim DocpathObj As String
        Dim DocName As String
        Try
            For Each folder As String In My.Computer.FileSystem.GetDirectories(source)
                cmpts = folder.Split("\").Length
                folderpath = folder.Split("\").GetValue(cmpts - 1)
                DestinationPath = cachepath + "\" + folderpath
                My.Computer.FileSystem.MoveDirectory(folder, DestinationPath)
                DocContainer = New XElement("Documents")
                For Each document As String In My.Computer.FileSystem.GetFiles(DestinationPath)
                    DocName = My.Computer.FileSystem.GetName(document)
                    'Create XML for Document
                    DocContainer.Add(New XElement("Doc", New XAttribute("name", DocName), New XAttribute("Path", document)))

                    docfoldercntr = docfoldercntr + 1
                Next
                BatchInfo = CreateQueXML.CreateBatchInfo(fdCntr.ToString, folder, DocContainer, folderpath)

                If (fdCntr >= 1) Then
                    OldBatchLogFile = XElement.Load(QueFilePath)
                    OldBatchLogFile.LastNode.AddAfterSelf(BatchInfo)
                    OldBatchLogFile.Save(QueFilePath)
                Else
                    rootElement = CreateQueXML.CreateTopLevel(BatchInfo)
                    CreateQueXML.saveXML(rootElement, QueFilePath)
                End If
                ''CreateQueXML.saveXML(BatchInfo, QueFilePath)
                'Update the Que file with File Details'

                fdCntr = fdCntr + 1
            Next
        Catch ex As Exception
            MsgBox("Moving to Processing Directory Error " + ex.Message)
        End Try
    End Sub
    Sub MoveContentToError()
        Try

        Catch ex As Exception

        End Try
    End Sub
    Sub MoveContentToCompleted()
        Try

        Catch ex As Exception

        End Try
    End Sub

    Function GetUploadPath() As Boolean

    End Function

    Function GetDocumentList(ByVal QueFilePath As String, ByVal batchName As String) As IEnumerable
        Dim BatchLog As XElement
        Dim elList As IEnumerable
        elList = ""
        Dim i As Integer = 0
        Try
            BatchLog = XElement.Load(QueFilePath)

            elList = From el In BatchLog...<Batch>
                     Where el.@name = batchName
                        Select el
        Catch ex As Exception
            ''MsgBox(ex.Message)
        End Try

        Return elList
    End Function

    Function GetUploadPaths(ByVal QueFilePath As String) As IEnumerable
        ''Takes the Que file path as the string value and returns the Name of the Folder that is to be created
        Dim BatchLog As XElement
        Dim elList As IEnumerable
        elList = ""
        Dim i As Integer = 0
        Try
            BatchLog = XElement.Load(QueFilePath)
            elList = From el In BatchLog...<Batch>
                        Select el

        Catch ex As Exception
            ''MsgBox(ex.Message)
        End Try

        Return elList
    End Function
    Function CreateIRFolders(ByVal ServiceURL As String, ByVal AuthenticationTicket As String, _
                 ByVal Path As String) As Boolean
        Dim flag As Boolean = False
        Dim IR_OBJ As InfoRouter.srv
        IR_OBJ = New InfoRouter.srv
        IR_OBJ.Url = ServiceURL

        Dim xml_response As System.Xml.XmlElement = IR_OBJ.CreateFolder(AuthenticationTicket, Path)
        Try

                If xml_response.Attributes("success").Value.ToUpperInvariant() = "TRUE" Then
                    flag = True
                    Console.WriteLine("The Folder has been uploaded Created.")
                Else
                    Console.WriteLine("TheFolder cannot be Created.")
                    Console.WriteLine("ERROR:" & xml_response.Attributes("error").Value)
                End If
                xml_response = Nothing
        Catch ex As Exception

        End Try
        Return flag
    End Function
    Function IRUpload(ByVal IR_OBJ As InfoRouter.srv, ByVal ServiceURL As String, ByVal AuthenticationTicket As String, _
                 ByVal UploadPath As String, ByVal LocalFilePath As String) As Boolean
        Dim UploadFlag As Boolean = False

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
                Dim xml_response As System.Xml.XmlNode = IR_OBJ.UploadDocument(AuthenticationTicket, UploadPath, buffer)

                'check response xml if any error occured.
                If xml_response.Attributes("success").Value.ToUpperInvariant() = "TRUE" Then
                    UploadFlag = True
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
        Return UploadFlag
    End Function
    Function CheckDocumentExists(ByVal IR_OBJ As InfoRouter.srv, ByVal ServiceURL As String, ByVal AuthenticationTicket As String, _
                 ByVal UploadPath As String) As Boolean
        Dim uploadFlag As Boolean = True
        Dim xml_response As System.Xml.XmlNode
        Try

            xml_response = IR_OBJ.DocumentExists(AuthenticationTicket, UploadPath)
            If xml_response.Attributes("success").Value.ToUpperInvariant() = "TRUE" Then

            ElseIf (xml_response.Attributes("success").Value.ToUpperInvariant() = "FALSE") And (xml_response.Attributes("error").Value = "Document not found.") Then
                uploadFlag = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return uploadFlag
    End Function
    Function RenameDocument(ByVal localFilePath As String) As Boolean
        Dim uploadflag As Boolean
        Dim Cntr As Integer = 0
        While uploadflag = True

            Cntr += 1
        End While
    End Function

End Module
