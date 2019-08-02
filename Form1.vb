Imports System.Xml.Linq
Imports System.Linq
Imports System.Data.Linq

Public Class frmInfoRouterSample
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TT As System.Windows.Forms.ToolTip
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtWarnings As System.Windows.Forms.TextBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSrvUrl As System.Windows.Forms.TextBox
    Friend WithEvents txtUID As System.Windows.Forms.TextBox
    Friend WithEvents txtPWD As System.Windows.Forms.TextBox
    Friend WithEvents cmdAuthenticate As System.Windows.Forms.Button
    Friend WithEvents TabFunctions As System.Windows.Forms.TabControl
    Friend WithEvents tabdocs As System.Windows.Forms.TabPage
    Friend WithEvents tabUsers As System.Windows.Forms.TabPage
    Friend WithEvents tabInstructions As System.Windows.Forms.TabPage
    Friend WithEvents lblauthenticationWarning As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSourceDir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFinYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDestField As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChunkSize As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessDir As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfoRouterSample))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWarnings = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblauthenticationWarning = New System.Windows.Forms.Label()
        Me.cmdAuthenticate = New System.Windows.Forms.Button()
        Me.txtPWD = New System.Windows.Forms.TextBox()
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.txtSrvUrl = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabFunctions = New System.Windows.Forms.TabControl()
        Me.tabInstructions = New System.Windows.Forms.TabPage()
        Me.tabUsers = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSourceDir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProcessDir = New System.Windows.Forms.TextBox()
        Me.tabdocs = New System.Windows.Forms.TabPage()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFinYear = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDestField = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtChunkSize = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.TabFunctions.SuspendLayout()
        Me.tabInstructions.SuspendLayout()
        Me.tabUsers.SuspendLayout()
        Me.tabdocs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 48)
        Me.Panel2.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.OrangeRed
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(8, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Before You Run"
        '
        'txtWarnings
        '
        Me.txtWarnings.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtWarnings.ForeColor = System.Drawing.Color.Red
        Me.txtWarnings.Location = New System.Drawing.Point(8, 32)
        Me.txtWarnings.Multiline = True
        Me.txtWarnings.Name = "txtWarnings"
        Me.txtWarnings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWarnings.Size = New System.Drawing.Size(512, 208)
        Me.txtWarnings.TabIndex = 18
        Me.txtWarnings.TabStop = False
        Me.txtWarnings.Text = resources.GetString("txtWarnings.Text")
        '
        'txtOutput
        '
        Me.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtOutput.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(0, 341)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(792, 232)
        Me.txtOutput.TabIndex = 53
        Me.txtOutput.WordWrap = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblauthenticationWarning)
        Me.Panel3.Controls.Add(Me.cmdAuthenticate)
        Me.Panel3.Controls.Add(Me.txtPWD)
        Me.Panel3.Controls.Add(Me.txtUID)
        Me.Panel3.Controls.Add(Me.txtSrvUrl)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(8, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(232, 272)
        Me.Panel3.TabIndex = 54
        '
        'lblauthenticationWarning
        '
        Me.lblauthenticationWarning.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblauthenticationWarning.ForeColor = System.Drawing.Color.Coral
        Me.lblauthenticationWarning.Location = New System.Drawing.Point(8, 216)
        Me.lblauthenticationWarning.Name = "lblauthenticationWarning"
        Me.lblauthenticationWarning.Size = New System.Drawing.Size(208, 40)
        Me.lblauthenticationWarning.TabIndex = 62
        Me.lblauthenticationWarning.Text = "All function uses this server and authentication information"
        '
        'cmdAuthenticate
        '
        Me.cmdAuthenticate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAuthenticate.Location = New System.Drawing.Point(58, 171)
        Me.cmdAuthenticate.Name = "cmdAuthenticate"
        Me.cmdAuthenticate.Size = New System.Drawing.Size(129, 24)
        Me.cmdAuthenticate.TabIndex = 61
        Me.cmdAuthenticate.Text = "Login"
        Me.cmdAuthenticate.UseVisualStyleBackColor = False
        '
        'txtPWD
        '
        Me.txtPWD.Location = New System.Drawing.Point(32, 144)
        Me.txtPWD.Name = "txtPWD"
        Me.txtPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPWD.Size = New System.Drawing.Size(192, 21)
        Me.txtPWD.TabIndex = 60
        Me.txtPWD.Text = "coseke"
        '
        'txtUID
        '
        Me.txtUID.Location = New System.Drawing.Point(32, 88)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(192, 21)
        Me.txtUID.TabIndex = 59
        Me.txtUID.Text = "coseke"
        '
        'txtSrvUrl
        '
        Me.txtSrvUrl.Location = New System.Drawing.Point(24, 40)
        Me.txtSrvUrl.Name = "txtSrvUrl"
        Me.txtSrvUrl.Size = New System.Drawing.Size(200, 21)
        Me.txtSrvUrl.TabIndex = 58
        Me.txtSrvUrl.Text = "http://edms.unra.go.ug/InfoRouter/"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Server URL : "
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Purple
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(232, 16)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Server && Login Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Password : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "User Name : "
        '
        'TabFunctions
        '
        Me.TabFunctions.Controls.Add(Me.tabInstructions)
        Me.TabFunctions.Controls.Add(Me.tabUsers)
        Me.TabFunctions.Controls.Add(Me.tabdocs)
        Me.TabFunctions.Controls.Add(Me.TabPage1)
        Me.TabFunctions.Location = New System.Drawing.Point(247, 56)
        Me.TabFunctions.Name = "TabFunctions"
        Me.TabFunctions.SelectedIndex = 0
        Me.TabFunctions.Size = New System.Drawing.Size(536, 272)
        Me.TabFunctions.TabIndex = 55
        '
        'tabInstructions
        '
        Me.tabInstructions.Controls.Add(Me.txtWarnings)
        Me.tabInstructions.Controls.Add(Me.Label10)
        Me.tabInstructions.Location = New System.Drawing.Point(4, 22)
        Me.tabInstructions.Name = "tabInstructions"
        Me.tabInstructions.Size = New System.Drawing.Size(528, 246)
        Me.tabInstructions.TabIndex = 4
        Me.tabInstructions.Text = "Read Me"
        '
        'tabUsers
        '
        Me.tabUsers.Controls.Add(Me.Button4)
        Me.tabUsers.Controls.Add(Me.Button3)
        Me.tabUsers.Controls.Add(Me.Button1)
        Me.tabUsers.Controls.Add(Me.txtSourceDir)
        Me.tabUsers.Controls.Add(Me.Label3)
        Me.tabUsers.Controls.Add(Me.Label2)
        Me.tabUsers.Controls.Add(Me.txtProcessDir)
        Me.tabUsers.Location = New System.Drawing.Point(4, 22)
        Me.tabUsers.Name = "tabUsers"
        Me.tabUsers.Size = New System.Drawing.Size(528, 246)
        Me.tabUsers.TabIndex = 2
        Me.tabUsers.Text = "Directories"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(457, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Browse"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(454, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Location = New System.Drawing.Point(253, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Process"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtSourceDir
        '
        Me.txtSourceDir.Location = New System.Drawing.Point(152, 67)
        Me.txtSourceDir.Name = "txtSourceDir"
        Me.txtSourceDir.Size = New System.Drawing.Size(296, 21)
        Me.txtSourceDir.TabIndex = 3
        Me.txtSourceDir.Text = "D:\UNRA\Test"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Source Directory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Processing Directory"
        '
        'txtProcessDir
        '
        Me.txtProcessDir.Location = New System.Drawing.Point(152, 34)
        Me.txtProcessDir.Name = "txtProcessDir"
        Me.txtProcessDir.Size = New System.Drawing.Size(296, 21)
        Me.txtProcessDir.TabIndex = 0
        Me.txtProcessDir.Text = "C:\CUImport\"
        '
        'tabdocs
        '
        Me.tabdocs.Controls.Add(Me.txtCategory)
        Me.tabdocs.Controls.Add(Me.Label11)
        Me.tabdocs.Controls.Add(Me.txtFinYear)
        Me.tabdocs.Controls.Add(Me.Label5)
        Me.tabdocs.Controls.Add(Me.txtDestField)
        Me.tabdocs.Controls.Add(Me.Label4)
        Me.tabdocs.Controls.Add(Me.Button2)
        Me.tabdocs.Location = New System.Drawing.Point(4, 22)
        Me.tabdocs.Name = "tabdocs"
        Me.tabdocs.Size = New System.Drawing.Size(528, 246)
        Me.tabdocs.TabIndex = 0
        Me.tabdocs.Text = "Documents And Folders"
        '
        'txtCategory
        '
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Items.AddRange(New Object() {"Supplies", "Services", "Works"})
        Me.txtCategory.Location = New System.Drawing.Point(164, 73)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(218, 21)
        Me.txtCategory.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Category"
        '
        'txtFinYear
        '
        Me.txtFinYear.FormattingEnabled = True
        Me.txtFinYear.Items.AddRange(New Object() {"Financial Year 2007 - 2008", "Financial Year 2008 - 2009", "Financial Year 2009 - 2010", "Financial Year 2010 - 2011", "Financial Year 2011 - 2012"})
        Me.txtFinYear.Location = New System.Drawing.Point(164, 46)
        Me.txtFinYear.Name = "txtFinYear"
        Me.txtFinYear.Size = New System.Drawing.Size(218, 21)
        Me.txtFinYear.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Financial Year"
        '
        'txtDestField
        '
        Me.txtDestField.Location = New System.Drawing.Point(164, 19)
        Me.txtDestField.Name = "txtDestField"
        Me.txtDestField.Size = New System.Drawing.Size(348, 21)
        Me.txtDestField.TabIndex = 2
        Me.txtDestField.Text = "\Procurement and Disposal Unit\"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Destination Directory"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(232, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Upload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtChunkSize)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(528, 246)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Network Optimisation"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtChunkSize
        '
        Me.txtChunkSize.Location = New System.Drawing.Point(138, 17)
        Me.txtChunkSize.Name = "txtChunkSize"
        Me.txtChunkSize.Size = New System.Drawing.Size(193, 21)
        Me.txtChunkSize.TabIndex = 1
        Me.txtChunkSize.Text = "1000000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chunk Size"
        '
        'frmInfoRouterSample
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.TabFunctions)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmInfoRouterSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Document Upload Tool"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabFunctions.ResumeLayout(False)
        Me.tabInstructions.ResumeLayout(False)
        Me.tabInstructions.PerformLayout()
        Me.tabUsers.ResumeLayout(False)
        Me.tabUsers.PerformLayout()
        Me.tabdocs.ResumeLayout(False)
        Me.tabdocs.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public AuthenticationTicket As String = ""
    Public QueFileName As String = "\Cache\Batchlog.xml"
    Private Sub lnkDownloadDocument_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        DownloadDocument(txtSrvUrl.Text & "/srv.asmx", AuthenticationTicket)
    End Sub

    Private Sub lnkUploadDocument_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        'Define Input values
        Const uploadpath As String = "/TestDomain/sample/s.doc"
        Const LocalFilePath As String = "c:\temp\SummerPlan.doc"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Try
            ClearOutputWindow()
            WriteOutputLine("[UploadDocument]")
            WriteOutputLine("IRServerPath  = " & uploadpath)
            WriteOutputLine("LocalFilePath = " & LocalFilePath)
            WriteOutputLine("----------------------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            If System.IO.File.Exists(LocalFilePath) Then
                Dim FileName As String = System.IO.Path.GetFileName(LocalFilePath)
                Dim buffer() As Byte
                IR_OBJ = New InfoRouter.srv
                IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

                'create byte array to upload
                Dim fs As System.IO.FileStream = New System.IO.FileStream(LocalFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                Dim br As System.IO.BinaryReader = New System.IO.BinaryReader(fs) ' create a BinaryReader
                buffer = br.ReadBytes(fs.Length)
                br.Close()
                fs.Close()
                br = Nothing
                fs = Nothing

                'call upload method
                Dim xml_response As System.Xml.XmlElement
                xml_response = IR_OBJ.UploadDocument(AuthenticationTicket, uploadpath, buffer)
                'check response xml if any error occured.
                If xml_response.GetAttribute("success") = "true" Then
                    WriteOutputLine("The Document has been uploaded successfully.")
                Else
                    WriteOutputLine("The Document cannot be uploaded.")
                    WriteOutputLine("ERROR:" & xml_response.GetAttribute("error"))
                End If
                xml_response = Nothing
            Else
                WriteOutputLine("Local file not found.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkCoWorkers_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement

        Try
            ClearOutputWindow()
            WriteOutputLine("[CoWorkers]")
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            'Create InfoRouter Object

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.GetCoWorkers(AuthenticationTicket)
            If xmlResponse.GetAttribute("success") = "true" Then
                'get co-workers elem
                Dim xmlcoworkers As System.Xml.XmlElement = xmlResponse.FirstChild

                WriteOutputLine("[Co-workers]")
                WriteOutputLine("----------------------------------")
                'loop trough users
                Dim xmlUserElem As System.Xml.XmlElement
                For Each xmlUserElem In xmlcoworkers
                    WriteOutputLine(xmlUserElem.GetAttribute("DomainName") & vbTab & _
                                      xmlUserElem.GetAttribute("UserName") & vbTab & _
                                      xmlUserElem.GetAttribute("FirstName") & vbTab & _
                                      xmlUserElem.GetAttribute("LastName") & vbTab & _
                                      xmlUserElem.GetAttribute("Email"))
                Next
                WriteOutputLine("----------------------------------")
            Else
                WriteOutputLine("The Co-workers cannot be retrived.")
                WriteOutputLine("Server Response : " & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub lnkDeleteUser_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const UserNameToTeDeleted As String = "TestUser"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[DeleteUser]")
            WriteOutputLine("User Name = " & UserNameToTeDeleted)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            'Create InfoRouter Object
            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.DeleteUser(AuthenticationTicket, UserNameToTeDeleted)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The User has been successfully deleted.")
            Else
                WriteOutputLine("The User cannot be deleted.")
                WriteOutputLine("Server Response :" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing
        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub FolderExists_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_FolderPath As String = "/TestDomain/samples"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[FolderExists]")
            WriteOutputLine("FolderPath  = " & IR_FolderPath)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.FolderExists(AuthenticationTicket, IR_FolderPath)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The Folder exists")
            Else
                WriteOutputLine("The Folder cannot be found.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub lnkUserExists_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_UserToBeTested As String = "TestUser"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[UserExists]")
            WriteOutputLine("UserName = " & IR_UserToBeTested)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.UserExists(AuthenticationTicket, IR_UserToBeTested)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The user exists")
            Else
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub lnkCreateUser_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_DomainName As String = "TestDomain" 'Set empty string if the user will be a global user.
        Const IR_UserName As String = "TestJaneC"
        Const IR_FirstName As String = "Jane"
        Const IR_LastName As String = "Crane"
        Const IR_EmailAddress As String = "TestJaneC@acme.com"
        Const IR_Password As String = "jane123"
        Const IR_ReadOnlyUser As Boolean = False
        Const NTLMAuthentication As Boolean = False

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[CreateUser]")
            WriteOutputLine("Domain Name        = " & IR_DomainName)
            WriteOutputLine("User Name          = " & IR_UserName)
            WriteOutputLine("First Name         = " & IR_FirstName)
            WriteOutputLine("Last Name          = " & IR_LastName)
            WriteOutputLine("Email              = " & IR_EmailAddress)
            WriteOutputLine("Password           = " & IR_Password)
            WriteOutputLine("ReadOnlyUser       = " & IR_ReadOnlyUser)
            WriteOutputLine("NTLMAuthentication = " & NTLMAuthentication)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor


            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")


            xmlResponse = IR_OBJ.CreateUser(AuthenticationTicket, _
                                            IR_DomainName, _
                                            IR_UserName, _
                                            IR_FirstName, _
                                            IR_LastName, _
                                            IR_EmailAddress, _
                                            IR_Password, _
                                            IR_ReadOnlyUser, _
                                            NTLMAuthentication)

            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The user has been successfully created.")
            Else
                WriteOutputLine("The User cannot be created.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkMove_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_SourcePath As String = "/TestDomain/samples/SummerPlan.doc"
        Const IR_DestinationPath As String = "/TestDomain/documents/"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[Move]")
            WriteOutputLine("SourcePath      = " & IR_SourcePath)
            WriteOutputLine("DestinationPath = " & IR_DestinationPath)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor


            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.Move(AuthenticationTicket, _
                                      IR_SourcePath, _
                                      IR_DestinationPath)

            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The document has been successfully moved.")
            Else
                WriteOutputLine("The document cannot be moved.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkGetUserGroupMembers_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        'leave it empty string if the usergroup is a global usergroup
        Const IR_DomainName As String = "TestDomain"
        Const IR_UserGroupName As String = "TestAuthors"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[GetUserGroupMembers]")
            WriteOutputLine("DomainName= " & IR_DomainName)
            WriteOutputLine("UserGroup= " & IR_UserGroupName)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.GetUserGroupMembers(AuthenticationTicket, _
                                                     IR_DomainName, _
                                                     IR_UserGroupName)

            If xmlResponse.GetAttribute("success") = "true" Then
                Dim xmlusersElem As System.Xml.XmlElement
                xmlusersElem = xmlResponse.FirstChild

                Dim xmlelem As System.Xml.XmlElement
                For Each xmlelem In xmlusersElem.ChildNodes
                    WriteOutputLine(xmlelem.GetAttribute("UserName"))
                Next
                xmlusersElem = Nothing

            Else
                WriteOutputLine("Group members cannot be reached.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub lnkGetDomainMembers_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_DomainName As String = "TestDomain"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[GetDomainMembers]")
            WriteOutputLine("DomainName = " & IR_DomainName)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.GetDomainMembers(AuthenticationTicket, _
                                                  IR_DomainName)

            If xmlResponse.GetAttribute("success") = "true" Then
                Dim xmlelem As System.Xml.XmlElement
                'list users
                WriteOutputLine("------- [Member Users] ----------")

                Dim xmlusersElem As System.Xml.XmlElement
                xmlusersElem = xmlResponse.ChildNodes(0)
                For Each xmlelem In xmlusersElem.ChildNodes
                    WriteOutputLine(xmlelem.GetAttribute("UserName"))
                Next
                xmlusersElem = Nothing

                'list usergroups
                WriteOutputLine("------- [Member Groups] ---------")

                Dim xmlusergroupsElem As System.Xml.XmlElement
                xmlusergroupsElem = xmlResponse.ChildNodes(0)
                For Each xmlelem In xmlusergroupsElem.ChildNodes
                    WriteOutputLine(xmlelem.GetAttribute("GroupName"))
                Next
                xmlusergroupsElem = Nothing

            Else
                WriteOutputLine("Domain members cannot be reached.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub lnkAddUserAsDomainMember_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_DomainName As String = "TestDomain"
        Const IR_UserName As String = "testJaneC"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[AddUserAsDomainMember]")
            WriteOutputLine("DomainName = " & IR_DomainName)
            WriteOutputLine("UserName   = " & IR_UserName)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.AddUserAsDomainMember(AuthenticationTicket, _
                                                       IR_DomainName, _
                                                       IR_UserName)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The user successfully added to the domain members")
            Else
                WriteOutputLine("The User cannot be added to the domain members.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub lnkRemoveUserFromDomainMembership_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_DomainName As String = "TestDomain"
        Const IR_UserNametobeRemoved As String = "TestJaneC"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[RemoveUserFromDomainMembership]")
            WriteOutputLine("DomainName = " & IR_DomainName)
            WriteOutputLine("UserName   = " & IR_UserNametobeRemoved)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor


            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.RemoveUserFromDomainMembership(AuthenticationTicket, _
                                                                IR_DomainName, _
                                                                IR_UserNametobeRemoved)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The user removed from the domain memberships")
            Else
                WriteOutputLine("The User cannot be removed from the domain memberships.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkAddUsergroupMember_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_DomainName As String = ""
        Const IR_UserGroup As String = "Authors_GlbTest"
        Const IR_UserNametobeAdded As String = "TestJaneC"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[AddUsergroupMember]")
            WriteOutputLine("DomainName= " & IR_DomainName)
            WriteOutputLine("UserGroup= " & IR_UserGroup)
            WriteOutputLine("UserName= " & IR_UserNametobeAdded)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.AddUsergroupMember(AuthenticationTicket, _
                                                    IR_DomainName, _
                                                    IR_UserGroup, _
                                                    IR_UserNametobeAdded)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The user added to the user group")
            Else
                WriteOutputLine("The User cannot be added to the group.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkRemoveUsergroupMember_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_DomainName As String = ""
        Const IR_UserGroup As String = "Authors_GlbTest"
        Const IR_UserName As String = "TestJaneC"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[RemoveUsergroupMember]")
            WriteOutputLine("DomainName= " & IR_DomainName)
            WriteOutputLine("UserGroup= " & IR_UserGroup)
            WriteOutputLine("UserName= " & IR_UserName)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.RemoveUsergroupMember(AuthenticationTicket, _
                                                       IR_DomainName, _
                                                       IR_UserGroup, _
                                                       IR_UserName)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The user removed from the user group")
            Else
                WriteOutputLine("The User cannot be removed from the group.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkCreateUserGroup_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_DomainName As String = "TestDomain"
        Const IR_UserGroup As String = "Authors_local"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[CreateUserGroup]")
            WriteOutputLine("DomainName= " & IR_DomainName)
            WriteOutputLine("UserGroup= " & IR_UserGroup)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.CreateUserGroup(AuthenticationTicket, _
                                                 IR_DomainName, _
                                                 IR_UserGroup)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The usergroup created successfully.")
            Else
                WriteOutputLine("The usergroup cannot be created.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkDeleteUserGroup_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_DomainName As String = "TestDomain"
        Const IR_UserGroup As String = "Authors_local"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[DeleteUserGroup]")
            WriteOutputLine("DomainName= " & IR_DomainName)
            WriteOutputLine("UserGroup= " & IR_UserGroup)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.DeleteUsergroup(AuthenticationTicket, _
                                                 IR_DomainName, _
                                                 IR_UserGroup)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The usergroup deleted successfully.")
            Else
                WriteOutputLine("The usergroup cannot be deleted.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkRemoveUserGroupFromDomainMembership_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_DomainName As String = "TestDomain"
        Const IR_UserGroupName As String = "Authors_GlbTest"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[RemoveUserGroupFromDomainMembership]")
            WriteOutputLine("DomainName = " & IR_DomainName)
            WriteOutputLine("GroupName  = " & IR_UserGroupName)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.RemoveUserGroupFromDomainMembership(AuthenticationTicket, _
                                                                     IR_DomainName, _
                                                                     IR_UserGroupName)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The user group removed from the domain memberships")
            Else
                WriteOutputLine("The User group cannot be removed from the domain memberships.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkAddUserGroupAsDomainMember_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_DomainName As String = "TestDomain"
        Const IR_UserGroupName As String = "Authors_GlbTest"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[AddUserGroupAsDomainMember]")
            WriteOutputLine("DomainName = " & IR_DomainName)
            WriteOutputLine("GroupName  = " & IR_UserGroupName)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.AddUserGroupAsDomainMember(AuthenticationTicket, _
                                                            IR_DomainName, _
                                                            IR_UserGroupName)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The user group added to the domain member")
            Else
                WriteOutputLine("The User group cannot be added to the domain members.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkGetFolderRules_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_FolderPath As String = "/TestDomain/Samples"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Try
            ClearOutputWindow()
            WriteOutputLine("[GetFolderRules]")
            WriteOutputLine("FolderPath  = " & IR_FolderPath)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            Dim xmlResponse As System.Xml.XmlElement
            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.GetFolderRules(AuthenticationTicket, IR_FolderPath)
            If xmlResponse.GetAttribute("success") = "true" Then
                'Get <Rules> xml element
                Dim xmlRules As System.Xml.XmlElement = xmlResponse.FirstChild
                WriteOutputLine("---[Folder Rules]----")
                'loop trough the rules
                Dim xmlrule As System.Xml.XmlElement
                For Each xmlrule In xmlRules
                    WriteOutputLine(xmlrule.GetAttribute("Name") & ":" & _
                                      xmlrule.GetAttribute("Value"))
                Next
                xmlRules = Nothing
            Else
                WriteOutputLine("The folder Rules cannot be reached:" & _
                                   xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub lnkSetAccessList_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_Path As String = "/TestDomain/Samples"


        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Dim xmldoc As System.Xml.XmlDocument

        Try
            ClearOutputWindow()
            WriteOutputLine("[SetAccessList]")
            WriteOutputLine("DocPath = " & IR_Path)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            xmldoc = New System.Xml.XmlDocument
            xmldoc.LoadXml("<AccessList/>")

            Dim xmlSecElem As System.Xml.XmlElement

            'Set DomainMembers Access
            xmlSecElem = xmldoc.CreateElement("DomainMembers")
            xmlSecElem.SetAttribute("Right", "4") 'Add and Read
            xmldoc.DocumentElement.AppendChild(xmlSecElem)

            'Set Change right to the usergroup (Authors_glbTest@TestDomain) 
            xmlSecElem = xmldoc.CreateElement("UserGroup")
            xmlSecElem.SetAttribute("DomainName", "TestDomain")
            xmlSecElem.SetAttribute("GroupName", "Authors_glbTest")
            xmlSecElem.SetAttribute("Right", "5") 'Change
            xmldoc.DocumentElement.AppendChild(xmlSecElem)

            'Set Full Control Right to the User (TestJaneC)
            xmlSecElem = xmldoc.CreateElement("User")
            xmlSecElem.SetAttribute("DomainName", "")
            xmlSecElem.SetAttribute("UserName", "TestJaneC")
            xmlSecElem.SetAttribute("Right", "6") 'Full Control
            xmldoc.DocumentElement.AppendChild(xmlSecElem)

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.SetAccessList(AuthenticationTicket, IR_Path, xmldoc.DocumentElement.OuterXml, False)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The AccesList has been applied successfully.")
            Else
                WriteOutputLine("The AccesList cannot be applied:" & _
                                               xmlResponse.GetAttribute("error"))
            End If

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            xmlResponse = Nothing
            xmldoc = Nothing
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub lnkGetAccessList_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_DocPath As String = "/TestDomain/Samples"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement

        Try
            ClearOutputWindow()
            WriteOutputLine("[GetAccessList]")
            WriteOutputLine("DocPath = " & IR_DocPath)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            'Create InfoRouter Object
            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.GetAccessList(AuthenticationTicket, IR_DocPath)
            If xmlResponse.GetAttribute("success") = "true" Then

                'get accesslist element
                Dim xmlaccesslist As System.Xml.XmlElement = xmlResponse.FirstChild

                'check inheritance
                If xmlaccesslist.GetAttribute("InheritedSecurity") = "true" Then
                    WriteOutputLine("Parent folder permissions are inherited.")
                Else
                    WriteOutputLine("Local permissions are in effect.")
                End If

                'loop trough access list item 
                Dim xmlSecElem As System.Xml.XmlElement
                For Each xmlSecElem In xmlaccesslist
                    If xmlSecElem.Name = "Anonymous" Then
                        WriteOutputLine("Anonymous Access : " & xmlSecElem.GetAttribute("Description"))
                    End If
                    If xmlSecElem.Name = "DomainMembers" Then
                        WriteOutputLine("Domain Members : " & xmlSecElem.GetAttribute("Description"))
                    End If
                    If xmlSecElem.Name = "UserGroup" Then
                        WriteOutputLine("User Group : " & xmlSecElem.GetAttribute("DomainName") & "," & xmlSecElem.GetAttribute("GroupName") & "-" & xmlSecElem.GetAttribute("Description"))
                    End If
                    If xmlSecElem.Name = "User" Then
                        WriteOutputLine("User : " & xmlSecElem.GetAttribute("DomainName") & "," & xmlSecElem.GetAttribute("UserName") & "-" & xmlSecElem.GetAttribute("Description"))
                    End If
                Next

            Else
                WriteOutputLine(xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub lnkCopy_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_SourcePath As String = "TestDomain/Samples/SummerPlan.doc"
        Const IR_DestinationPath As String = "/TestDomain/Documents/"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[Copy]")
            WriteOutputLine("SourcePath      = " & IR_SourcePath)
            WriteOutputLine("DestinationPath = " & IR_DestinationPath)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.Copy(AuthenticationTicket, _
                                      IR_SourcePath, _
                                      IR_DestinationPath)

            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The document has been successfully Copied.")
            Else
                WriteOutputLine("The document cannot be copied.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub lnkCreateFolder_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_NewPath As String = "/TestDomain/samples/Misc/VB/Vol1"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[CreateFolder]")
            WriteOutputLine("Path = " & IR_NewPath)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.CreateFolder(AuthenticationTicket, _
                                                     IR_NewPath)

            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The Folder Path has been created successfully.")
            Else
                WriteOutputLine("The Folder cannot be created.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkGetLocalGroups_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_DomainName As String = "TestDomain"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[GetLocalGroups]")
            WriteOutputLine("DomainName = " & IR_DomainName)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.GetLocalGroups(AuthenticationTicket, _
                                                IR_DomainName)

            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("-- [Local groups] --")
                Dim xmlGroups As System.Xml.XmlElement = xmlResponse.FirstChild
                Dim xmlgroup As System.Xml.XmlElement
                For Each xmlgroup In xmlGroups.ChildNodes
                    WriteOutputLine(xmlgroup.GetAttribute("GroupName"))
                Next
                WriteOutputLine("-----------")
                xmlGroups = Nothing
            Else
                WriteOutputLine("The local groups of the domain cannot be retrived.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkGetLocalUsers_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_DomainName As String = "TestDomain"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[GetLocalUsers]")
            WriteOutputLine("DomainName = " & IR_DomainName)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.GetLocalUsers(AuthenticationTicket, _
                                                IR_DomainName)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("-- [Local Users] --")
                Dim xmlUsers As System.Xml.XmlElement = xmlResponse.FirstChild
                Dim xmlUser As System.Xml.XmlElement
                For Each xmlUser In xmlUsers.ChildNodes
                    WriteOutputLine(xmlUser.GetAttribute("UserName") & vbTab & xmlUser.GetAttribute("FirstName") & vbTab & xmlUser.GetAttribute("LastName"))
                Next
                WriteOutputLine("-----------")
                xmlUsers = Nothing
            Else
                WriteOutputLine("The Local Users cannot be listed.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub lnkUnlock_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_DocumentPath As String = "TestDomain/Samples/SummerPlan.doc"
        Const IR_ForceUnlock As Boolean = False 'Set to True if the document locked by someone else.

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[Unlock]")
            WriteOutputLine("DocumentPath  = " & IR_DocumentPath)
            WriteOutputLine("ForceUnlock   = " & IR_ForceUnlock)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.UnLock(AuthenticationTicket, _
                                        IR_DocumentPath, _
                                        IR_ForceUnlock)

            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The document has been unlocked.")
            Else
                WriteOutputLine("The document cannot be unlocked.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkLock_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_DocumentPath As String = "TestDomain/Samples/SummerPlan.doc"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[Lock]")
            WriteOutputLine("DocumentPath      = " & IR_DocumentPath)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.Lock(AuthenticationTicket, _
                                        IR_DocumentPath)

            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The document has been Locked.")
            Else
                WriteOutputLine("The document cannot be Locked.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkGetDomains_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[GetDomains]")
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.GetDomains(AuthenticationTicket)

            If xmlResponse.GetAttribute("success") = "true" Then
                Dim xmlelem As System.Xml.XmlElement
                'list users
                WriteOutputLine("------- [domains] ----------")

                Dim xmlusersElem As System.Xml.XmlElement
                xmlusersElem = xmlResponse.ChildNodes(0)
                For Each xmlelem In xmlusersElem.ChildNodes
                    WriteOutputLine(xmlelem.GetAttribute("DomainName"))
                Next
                xmlusersElem = Nothing

            Else
                WriteOutputLine("Domains cannot be retrived.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkSetRules_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Const IR_FolderPath As String = "/TestDomain/documents"
        Const IRFolderRule_AllowableFileTypes As String = "doc,xls,txt,htm" '"*" for all type of documents
        Const IRFolderRule_AllowCheckIns As Boolean = True
        Const IRFolderRule_AllowCheckouts As Boolean = False
        Const IRFolderRule_AllowDocumentDeletes As Boolean = False
        Const IRFolderRule_AllowFolderDeletes As Boolean = False
        Const IRFolderRule_AllowNewDocuments As Boolean = False
        Const IRFolderRule_AllowNewFolders As Boolean = False
        Const IRFolderRule_AllowClassifiedDocuments As Boolean = True
        Const ApplytoTree As Boolean = False 'apply to sub folders or not

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmldoc As System.Xml.XmlDocument

        Try
            ClearOutputWindow()
            WriteOutputLine("[SetFolderRules]")
            WriteOutputLine("FolderPath               = " & IR_FolderPath)
            WriteOutputLine("AllowableFileTypes       = " & IRFolderRule_AllowableFileTypes)
            WriteOutputLine("AllowCheckIns            = " & IRFolderRule_AllowCheckIns)
            WriteOutputLine("AllowCheckouts           = " & IRFolderRule_AllowCheckouts)
            WriteOutputLine("AllowDocumentDeletes     = " & IRFolderRule_AllowDocumentDeletes)
            WriteOutputLine("AllowFolderDeletes       = " & IRFolderRule_AllowFolderDeletes)
            WriteOutputLine("AllowNewDocuments        = " & IRFolderRule_AllowNewDocuments)
            WriteOutputLine("AllowNewFolders          = " & IRFolderRule_AllowNewFolders)
            WriteOutputLine("AllowClassifiedDocuments = " & IRFolderRule_AllowClassifiedDocuments)
            WriteOutputLine("ApplytoTree              = " & ApplytoTree)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            xmldoc = New System.Xml.XmlDocument
            xmldoc.LoadXml("<Rules/>")

            Dim xmlelem As System.Xml.XmlElement

            'Allowable file extensions 
            xmlelem = xmldoc.CreateElement("Rule")
            xmlelem.SetAttribute("Name", "AllowableFileTypes")
            xmlelem.SetAttribute("Value", IRFolderRule_AllowableFileTypes)
            xmldoc.DocumentElement.AppendChild(xmlelem)

            'CheckIns - allows, disallows
            xmlelem = xmldoc.CreateElement("Rule")
            xmlelem.SetAttribute("Name", "Checkins")
            xmlelem.SetAttribute("Value", IIf(IRFolderRule_AllowCheckIns, "allows", "disallows"))
            xmldoc.DocumentElement.AppendChild(xmlelem)

            'Checkouts - allows, disallows
            xmlelem = xmldoc.CreateElement("Rule")
            xmlelem.SetAttribute("Name", "Checkouts")
            xmlelem.SetAttribute("Value", IIf(IRFolderRule_AllowCheckouts, "allows", "disallows"))
            xmldoc.DocumentElement.AppendChild(xmlelem)

            'DocumentDeletes - allows, disallows
            xmlelem = xmldoc.CreateElement("Rule")
            xmlelem.SetAttribute("Name", "DocumentDeletes")
            xmlelem.SetAttribute("Value", IIf(IRFolderRule_AllowDocumentDeletes, "allows", "disallows"))
            xmldoc.DocumentElement.AppendChild(xmlelem)

            'FolderDeletes - allows, disallows
            xmlelem = xmldoc.CreateElement("Rule")
            xmlelem.SetAttribute("Name", "FolderDeletes")
            xmlelem.SetAttribute("Value", IIf(IRFolderRule_AllowFolderDeletes, "allows", "disallows"))
            xmldoc.DocumentElement.AppendChild(xmlelem)

            'NewDocuments - allows, disallows
            xmlelem = xmldoc.CreateElement("Rule")
            xmlelem.SetAttribute("Name", "NewDocuments")
            xmlelem.SetAttribute("Value", IIf(IRFolderRule_AllowNewDocuments, "allows", "disallows"))
            xmldoc.DocumentElement.AppendChild(xmlelem)

            'NewFolders - allows, disallows
            xmlelem = xmldoc.CreateElement("Rule")
            xmlelem.SetAttribute("Name", "NewFolders")
            xmlelem.SetAttribute("Value", IIf(IRFolderRule_AllowNewFolders, "allows", "disallows"))
            xmldoc.DocumentElement.AppendChild(xmlelem)

            'ClassifiedDocuments - allows, disallows
            xmlelem = xmldoc.CreateElement("Rule")
            xmlelem.SetAttribute("Name", "ClassifiedDocuments")
            xmlelem.SetAttribute("Value", IIf(IRFolderRule_AllowClassifiedDocuments, "allows", "disallows"))
            xmldoc.DocumentElement.AppendChild(xmlelem)

            Dim xmlResponse As System.Xml.XmlElement

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.SetFolderRules(AuthenticationTicket, IR_FolderPath, xmldoc.DocumentElement, ApplytoTree)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("Rules applied successfully")
            Else
                WriteOutputLine("Rules cannot be applied :" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            xmldoc = Nothing
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lnkDocumentation_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.inforouter.com/webservices/")
    End Sub

    Public Sub ClearOutputWindow()
        txtOutput.Clear()
    End Sub

    Public Sub WriteOutputLine(ByVal valStr As String)
        txtOutput.Text &= IIf(Len(txtOutput.Text) > 0, vbCrLf, "") & valStr
    End Sub

    Private Sub cmdAuthenticate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAuthenticate.Click



        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            Form.ActiveForm.Cursor = Cursors.WaitCursor
            ClearOutputWindow()

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.AuthenticateUser(txtUID.Text, _
                                                  txtPWD.Text)
            If xmlResponse.GetAttribute("success") = "true" Then
                AuthenticationTicket = xmlResponse.GetAttribute("ticket")
                WriteOutputLine("The User Authenticated successfully.")
            Else
                AuthenticationTicket = ""
                WriteOutputLine("The User cannot be authenticated.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("Error Occured while connecting web service.")
            WriteOutputLine("Please Check the URL. Make sure infoRouter running on this url.")
            WriteOutputLine("Error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub lnkChangeUserStatus_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_UserAccountTobeDisabled As String = "TestUser"
        Const IR_StatusCode As Integer = 0 '0-disable, 1-enabled, 2-readonly


        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[ChangeUserStatus]")
            WriteOutputLine("UserName   = " & IR_UserAccountTobeDisabled)
            WriteOutputLine("StatusCode = " & IR_StatusCode)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.ChangeUserStatus(AuthenticationTicket, IR_UserAccountTobeDisabled, IR_StatusCode)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The User status has been changed.")
            Else
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub lnkChangeUserPassword_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        'Const IRAuthenticationUser as String="sid-xxxxxxxxxxxxxxxxxxxx"
        Const IR_UserName As String = "TestUser"
        Const IR_NewEmailAddress As String = "testUser@abccorp.com"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[UpdateUserEmail]")
            WriteOutputLine("UserName   = " & IR_UserName)
            WriteOutputLine("Email Address= " & IR_NewEmailAddress)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.UpdateUserEmail(AuthenticationTicket, IR_UserName, IR_NewEmailAddress)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("The User email address has been updated.")
            Else
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub folderlist_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Const IR_FolderPath As String = "/Training Center"

        '**** END OF INPUT CONSTANTS ****


        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            WriteOutputLine("[FolderList]")
            WriteOutputLine("FolderPath  = " & IR_FolderPath)
            WriteOutputLine("---------------------------")
            Application.DoEvents()
            Me.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.GetFolders(AuthenticationTicket, IR_FolderPath, False, False, False, False)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine("Sub Folders are retrived")
                WriteOutputLine(xmlResponse.OuterXml)
            Else
                WriteOutputLine("The Folder cannot be found.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    

    Private Sub btnNextPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim IR_OBJ As InfoRouter.srv
        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.GetNextSearchPage(AuthenticationTicket, _
                                                   False, False, False, False, False)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine(xmlResponse.OuterXml)
            Else
                WriteOutputLine("The next page cannot be received.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub btnPrevPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim IR_OBJ As InfoRouter.srv
        Dim xmlResponse As System.Xml.XmlElement
        Try
            ClearOutputWindow()
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            xmlResponse = IR_OBJ.GetPreviousSearchPage(AuthenticationTicket, _
                                                   False, False, False, False, False)
            If xmlResponse.GetAttribute("success") = "true" Then
                WriteOutputLine(xmlResponse.OuterXml)
            Else
                WriteOutputLine("The previous page cannot be received.")
                WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
            End If
            xmlResponse = Nothing

        Catch ex As Exception
            WriteOutputLine("error:" & ex.Message)
        Finally
            IR_OBJ = Nothing
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub lnkCreateDocumentUsingTemplate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        CreateDocumentUsingTemplate(txtSrvUrl.Text & "/srv.asmx", AuthenticationTicket)
    End Sub

    Private Sub UploadDocumetwithChunks(ByVal IR_OBJ As InfoRouter.srv, ByVal Uploadpath As String, ByVal LocalFilePath As String)
        'Define Input values
        ''Const uploadpath As String = "/Procurement and Disposal Unit/Test/TestingFolder/22428.177.59.1.ISO_2859_1_1999_2.pdf"
        ''Const LocalFilePath As String = "C:\Users\User\Documents\22428.177.59.1.ISO_2859_1_1999_2.pdf"

        '**** END OF INPUT CONSTANTS ****
        If (txtChunkSize.Text = "") Then
            MsgBox("Please Define the Chunk Size", MsgBoxStyle.Critical, "error")
        End If
        Dim crcx As CRC32
        Try
            ClearOutputWindow()
            WriteOutputLine("Uploading Documents....Please Wait")
            WriteOutputLine("----------------------------------------")
            'Application.DoEvents()
            ''Form.ActiveForm.Cursor = Cursors.WaitCursor

            If System.IO.File.Exists(LocalFilePath) Then
                Dim FileName As String = System.IO.Path.GetFileName(LocalFilePath)
                Dim buffer() As Byte
                Dim uplHandler As String = ""
                Dim ChunkSize As Integer
                ChunkSize = 1000000
                IR_OBJ = New InfoRouter.srv
                IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

                Dim xml_response As System.Xml.XmlElement
                xml_response = IR_OBJ.CreateUploadHandler(AuthenticationTicket, ChunkSize)
                'check response xml if any error occured.
                If xml_response.GetAttribute("success") = "true" Then
                    uplHandler = xml_response.GetAttribute("UploadHandler")
                    'server might set different chunksize
                    ChunkSize = Integer.Parse(xml_response.GetAttribute("ChunkSize"))

                    'create byte array to upload
                    Dim fs As System.IO.FileStream = New System.IO.FileStream(LocalFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                    Dim br As System.IO.BinaryReader = New System.IO.BinaryReader(fs) ' create a BinaryReader
                    Dim fileoffset As Integer = 0
                    Dim filelength As Integer = fs.Length
                    Dim filecrc As Long = 0
                    Dim returnedFileCRC As Long = 0
                    Dim intcrc As Integer = 0
                    crcx = New CRC32
                    filecrc = crcx.GetCrc32(fs)
                    fs.Seek(0, IO.SeekOrigin.Begin)
                    Do
                        buffer = br.ReadBytes(ChunkSize)
                        If buffer.Length > 0 Then
                            intcrc = crcx.GetCrc32(buffer)
                            fileoffset += ChunkSize
tryagain:
                            Dim booltry As Boolean = False
                            Dim errmessage As String = ""
                            Dim lastChunk As Boolean = ((buffer.Length < ChunkSize) Or (filelength = fileoffset))

                            If Not uplchunk(IR_OBJ, uplHandler, buffer, booltry, errmessage, lastChunk, intcrc, returnedFileCRC) Then
                                If booltry Then
                                    If MsgBox(errmessage, MsgBoxStyle.RetryCancel + MsgBoxStyle.Critical, "error") = MsgBoxResult.Retry Then
                                        GoTo tryagain
                                    Else
                                        Exit Do
                                    End If
                                Else
                                    MsgBox(errmessage, MsgBoxStyle.Critical, "error")
                                    Exit Do
                                End If
                            End If
                            If lastChunk Then
                                If returnedFileCRC <> filecrc Then
                                    If MsgBox("Ooops! Server returned checksum is different than local file checksum.", MsgBoxStyle.Critical, "error") Then
                                        Exit Do
                                    End If
                                End If
                            End If
                        End If
                    Loop Until buffer.Length = 0
                    br.Close()
                    fs.Close()
                    crcx = Nothing
                    br = Nothing
                    fs = Nothing

                    'call upload method
                    'Call the UploadTifffAsPDFwithHandler function 
                    xml_response = IR_OBJ.UploadDocumentWithHandler(AuthenticationTicket, Uploadpath, uplHandler)
                    If xml_response.Attributes("success").Value = "true" Then
                        WriteOutputLine(LocalFilePath & " has been successfully uploaded")
                        'garbage collection for the server. this is optional. Server is automatically releases the handlers in the certain time of inactivitiy
                        IR_OBJ.DeleteUploadHandler(AuthenticationTicket, uplHandler)

                    Else
                        MessageBox.Show("ERROR:" + xml_response.Attributes("error").Value, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        WriteOutputLine(LocalFilePath & " has not been uploaded")
                    End If
                Else
                    WriteOutputLine("ERROR:" & xml_response.GetAttribute("error"))
                End If
                xml_response = Nothing
            Else
                WriteOutputLine("Local file not found.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            crcx = Nothing
            IR_OBJ = Nothing
            ''Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Function uplchunk(ByRef ir_obj As InfoRouter.srv, _
                      ByVal uplhandler As String, _
                      ByRef buffer() As Byte, _
                      ByRef tryagain As Boolean, _
                      ByRef errmessage As String, _
                      ByVal lastchunk As Boolean, _
                      ByRef intcrc As Integer, _
                      ByRef ReturnedFileCRC As Integer) As Boolean


        Dim xml_response As System.Xml.XmlElement = Nothing
        Try
            tryagain = False

            xml_response = ir_obj.UploadFileChunk(AuthenticationTicket, uplhandler, buffer, Hex(intcrc).ToString, lastchunk)

            If xml_response.GetAttribute("success") = "true" Then
                If lastchunk Then
                    ReturnedFileCRC = Integer.Parse(xml_response.GetAttribute("filehexcrc"), System.Globalization.NumberStyles.HexNumber)
                End If

                Return True
            Else
                If xml_response.GetAttribute("tryagain") = "true" Then
                    tryagain = True
                Else
                    errmessage = xml_response.GetAttribute("error")
                End If
            End If

        Catch ex As Exception
            errmessage = ex.Message
        Finally
            xml_response = Nothing
        End Try
    End Function

    Private Sub lnkUploadTiffAsPDFWithHandler_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        UploadTiffAsPDFWithHandler((txtSrvUrl.Text & "/srv.asmx"), AuthenticationTicket)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim errmessage As String = ""
        Dim UploadDirectory As String = txtDestField.Text & "\" & txtFinYear.SelectedItem & "\" & txtCategory.SelectedItem
        Dim QueFilePath As String = txtProcessDir.Text & QueFileName
        Dim BartchList As IEnumerable = ProcessFiles.GetUploadPaths(QueFilePath)

        Dim batchName As String = ""
        Dim DocName As String = ""
        Dim documents As XElement

        Dim Uploadpath As String = ""
        Dim LocalFilepath As String = ""

        Dim IR_OBJ As InfoRouter.srv

        Dim xmlResponse As System.Xml.XmlElement

        Try
            Dim DocList As IEnumerable
            ClearOutputWindow()
            WriteOutputLine("Creating Folders and Directories.....Please Wait")
            WriteOutputLine("---------------------------")

            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            IR_OBJ = New InfoRouter.srv
            IR_OBJ.Url = (txtSrvUrl.Text & "/srv.asmx")

            For Each batch As XElement In BartchList
                batchName = batch.FirstAttribute.Value
                DocList = From item In batch...<Documents>...<Doc>
                          Select item
                ''DocList = ProcessFiles.GetDocumentList(QueFilePath, batchName)
                xmlResponse = IR_OBJ.CreateFolder(AuthenticationTicket, UploadDirectory & "\" & batchName)

                If xmlResponse.GetAttribute("success") = "true" Then
                    WriteOutputLine(batchName & " has been created successfully.")
                Else
                    WriteOutputLine(batchName & " cannot be created.")
                    WriteOutputLine("server response:" & xmlResponse.GetAttribute("error"))
                End If

                xmlResponse = Nothing

                For Each Doc As XElement In DocList

                    DocName = Doc.FirstAttribute.Value
                    LocalFilepath = Doc.LastAttribute.Value
                    Uploadpath = UploadDirectory & "\" & batchName & "\" & DocName

                    UploadDocumetwithChunks(IR_OBJ, Uploadpath, LocalFilepath)

                Next

            Next
        Catch ex As Exception
            errmessage = ex.Message
            WriteOutputLine("error:" & ex.Message)
        Finally
            Form.ActiveForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ''Process Directories to Generate  the XML File for the Batch
        Dim QueFilePath As String = txtProcessDir.Text & "Cache\Batchlog.xml"
        Dim SourceDir As String = txtSourceDir.Text
        Dim DestinationDir As String = txtProcessDir.Text
        Try
            Application.DoEvents()
            Form.ActiveForm.Cursor = Cursors.WaitCursor

            CreateDirectories.CreateTempDir(txtProcessDir.Text)

            ProcessFiles.MoveContentToProcessing(QueFilePath, SourceDir, DestinationDir)

            WriteOutputLine("Files Moved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Form.ActiveForm.Cursor = Cursors.Default
        End Try

    End Sub
End Class
