<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBoxProcessing = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ListBoxFileName = New System.Windows.Forms.ListBox()
        Me.ButtonOpenFolder = New System.Windows.Forms.Button()
        Me.ButtonOpenFile = New System.Windows.Forms.Button()
        Me.ButtonRemoveListPic = New System.Windows.Forms.Button()
        Me.OpenFileDialogForList = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialogForList = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.PictureBoxProcessing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxProcessing
        '
        Me.PictureBoxProcessing.Location = New System.Drawing.Point(342, 32)
        Me.PictureBoxProcessing.Name = "PictureBoxProcessing"
        Me.PictureBoxProcessing.Size = New System.Drawing.Size(285, 245)
        Me.PictureBoxProcessing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProcessing.TabIndex = 0
        Me.PictureBoxProcessing.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(424, 313)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(97, 21)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(395, 340)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(232, 21)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(446, 367)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(105, 21)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(446, 394)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(105, 21)
        Me.TextBox4.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(527, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(340, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "New FileName"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(340, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NewPath"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(340, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "FileName Prefix"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(340, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "FileName Suffix"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(557, 367)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Enable"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(557, 394)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "Enable"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ListBoxFileName
        '
        Me.ListBoxFileName.FormattingEnabled = True
        Me.ListBoxFileName.ItemHeight = 12
        Me.ListBoxFileName.Location = New System.Drawing.Point(12, 12)
        Me.ListBoxFileName.Name = "ListBoxFileName"
        Me.ListBoxFileName.Size = New System.Drawing.Size(305, 376)
        Me.ListBoxFileName.TabIndex = 12
        '
        'ButtonOpenFolder
        '
        Me.ButtonOpenFolder.Location = New System.Drawing.Point(12, 399)
        Me.ButtonOpenFolder.Name = "ButtonOpenFolder"
        Me.ButtonOpenFolder.Size = New System.Drawing.Size(97, 29)
        Me.ButtonOpenFolder.TabIndex = 13
        Me.ButtonOpenFolder.Text = "Open folder"
        Me.ButtonOpenFolder.UseVisualStyleBackColor = True
        '
        'ButtonOpenFile
        '
        Me.ButtonOpenFile.Location = New System.Drawing.Point(116, 399)
        Me.ButtonOpenFile.Name = "ButtonOpenFile"
        Me.ButtonOpenFile.Size = New System.Drawing.Size(97, 29)
        Me.ButtonOpenFile.TabIndex = 13
        Me.ButtonOpenFile.Text = "Open file"
        Me.ButtonOpenFile.UseVisualStyleBackColor = True
        '
        'ButtonRemoveListPic
        '
        Me.ButtonRemoveListPic.Location = New System.Drawing.Point(220, 399)
        Me.ButtonRemoveListPic.Name = "ButtonRemoveListPic"
        Me.ButtonRemoveListPic.Size = New System.Drawing.Size(97, 29)
        Me.ButtonRemoveListPic.TabIndex = 13
        Me.ButtonRemoveListPic.Text = "Remove all"
        Me.ButtonRemoveListPic.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 440)
        Me.Controls.Add(Me.ButtonRemoveListPic)
        Me.Controls.Add(Me.ButtonOpenFile)
        Me.Controls.Add(Me.ButtonOpenFolder)
        Me.Controls.Add(Me.ListBoxFileName)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBoxProcessing)
        Me.Name = "FormMain"
        Me.Text = "Manual-Picture-Classifying-Assistanter"
        CType(Me.PictureBoxProcessing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxProcessing As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents ListBoxFileName As ListBox
    Friend WithEvents ButtonOpenFolder As Button
    Friend WithEvents ButtonOpenFile As Button
    Friend WithEvents ButtonRemoveListPic As Button
    Friend WithEvents OpenFileDialogForList As OpenFileDialog
    Friend WithEvents FolderBrowserDialogForList As FolderBrowserDialog
End Class
