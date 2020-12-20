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
        Me.TextBoxNewFileName = New System.Windows.Forms.TextBox()
        Me.TextBoxNewPath = New System.Windows.Forms.TextBox()
        Me.TextBoxFileNamePrefix = New System.Windows.Forms.TextBox()
        Me.TextBoxFileNameSuffix = New System.Windows.Forms.TextBox()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.LabelNewFileName = New System.Windows.Forms.Label()
        Me.LabelNewPath = New System.Windows.Forms.Label()
        Me.LabelFileNamePrefix = New System.Windows.Forms.Label()
        Me.LabelFileNameSuffix = New System.Windows.Forms.Label()
        Me.CheckBoxFileNamePrefix = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFileNameSuffix = New System.Windows.Forms.CheckBox()
        Me.ListBoxFileName = New System.Windows.Forms.ListBox()
        Me.ButtonOpenFolder = New System.Windows.Forms.Button()
        Me.ButtonOpenFile = New System.Windows.Forms.Button()
        Me.ButtonRemoveListPic = New System.Windows.Forms.Button()
        Me.OpenFileDialogForList = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialogForList = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonApplyAll = New System.Windows.Forms.Button()
        Me.LabelOldFileName = New System.Windows.Forms.Label()
        Me.ButtonSelectNewPath = New System.Windows.Forms.Button()
        Me.MenuStripSettings = New System.Windows.Forms.MenuStrip()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecificStringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelToDeleteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassToSkipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFromListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyButNotDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBoxProcessing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBoxProcessing
        '
        Me.PictureBoxProcessing.Location = New System.Drawing.Point(336, 29)
        Me.PictureBoxProcessing.Name = "PictureBoxProcessing"
        Me.PictureBoxProcessing.Size = New System.Drawing.Size(285, 245)
        Me.PictureBoxProcessing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProcessing.TabIndex = 0
        Me.PictureBoxProcessing.TabStop = False
        '
        'TextBoxNewFileName
        '
        Me.TextBoxNewFileName.Location = New System.Drawing.Point(418, 310)
        Me.TextBoxNewFileName.Name = "TextBoxNewFileName"
        Me.TextBoxNewFileName.Size = New System.Drawing.Size(97, 21)
        Me.TextBoxNewFileName.TabIndex = 1
        '
        'TextBoxNewPath
        '
        Me.TextBoxNewPath.Location = New System.Drawing.Point(389, 337)
        Me.TextBoxNewPath.Name = "TextBoxNewPath"
        Me.TextBoxNewPath.Size = New System.Drawing.Size(202, 21)
        Me.TextBoxNewPath.TabIndex = 2
        '
        'TextBoxFileNamePrefix
        '
        Me.TextBoxFileNamePrefix.Location = New System.Drawing.Point(440, 364)
        Me.TextBoxFileNamePrefix.Name = "TextBoxFileNamePrefix"
        Me.TextBoxFileNamePrefix.Size = New System.Drawing.Size(105, 21)
        Me.TextBoxFileNamePrefix.TabIndex = 3
        '
        'TextBoxFileNameSuffix
        '
        Me.TextBoxFileNameSuffix.Location = New System.Drawing.Point(440, 391)
        Me.TextBoxFileNameSuffix.Name = "TextBoxFileNameSuffix"
        Me.TextBoxFileNameSuffix.Size = New System.Drawing.Size(105, 21)
        Me.TextBoxFileNameSuffix.TabIndex = 4
        '
        'ButtonNext
        '
        Me.ButtonNext.Enabled = False
        Me.ButtonNext.Location = New System.Drawing.Point(521, 308)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(100, 23)
        Me.ButtonNext.TabIndex = 5
        Me.ButtonNext.Text = "Next"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'LabelNewFileName
        '
        Me.LabelNewFileName.Location = New System.Drawing.Point(334, 310)
        Me.LabelNewFileName.Name = "LabelNewFileName"
        Me.LabelNewFileName.Size = New System.Drawing.Size(78, 21)
        Me.LabelNewFileName.TabIndex = 6
        Me.LabelNewFileName.Text = "New FileName"
        '
        'LabelNewPath
        '
        Me.LabelNewPath.Location = New System.Drawing.Point(334, 337)
        Me.LabelNewPath.Name = "LabelNewPath"
        Me.LabelNewPath.Size = New System.Drawing.Size(49, 21)
        Me.LabelNewPath.TabIndex = 7
        Me.LabelNewPath.Text = "NewPath"
        '
        'LabelFileNamePrefix
        '
        Me.LabelFileNamePrefix.Location = New System.Drawing.Point(334, 364)
        Me.LabelFileNamePrefix.Name = "LabelFileNamePrefix"
        Me.LabelFileNamePrefix.Size = New System.Drawing.Size(100, 21)
        Me.LabelFileNamePrefix.TabIndex = 8
        Me.LabelFileNamePrefix.Text = "FileName Prefix"
        '
        'LabelFileNameSuffix
        '
        Me.LabelFileNameSuffix.Location = New System.Drawing.Point(334, 391)
        Me.LabelFileNameSuffix.Name = "LabelFileNameSuffix"
        Me.LabelFileNameSuffix.Size = New System.Drawing.Size(100, 21)
        Me.LabelFileNameSuffix.TabIndex = 9
        Me.LabelFileNameSuffix.Text = "FileName Suffix"
        '
        'CheckBoxFileNamePrefix
        '
        Me.CheckBoxFileNamePrefix.Location = New System.Drawing.Point(551, 364)
        Me.CheckBoxFileNamePrefix.Name = "CheckBoxFileNamePrefix"
        Me.CheckBoxFileNamePrefix.Size = New System.Drawing.Size(70, 21)
        Me.CheckBoxFileNamePrefix.TabIndex = 10
        Me.CheckBoxFileNamePrefix.Text = "Enable"
        Me.CheckBoxFileNamePrefix.UseVisualStyleBackColor = True
        '
        'CheckBoxFileNameSuffix
        '
        Me.CheckBoxFileNameSuffix.Location = New System.Drawing.Point(551, 391)
        Me.CheckBoxFileNameSuffix.Name = "CheckBoxFileNameSuffix"
        Me.CheckBoxFileNameSuffix.Size = New System.Drawing.Size(70, 21)
        Me.CheckBoxFileNameSuffix.TabIndex = 11
        Me.CheckBoxFileNameSuffix.Text = "Enable"
        Me.CheckBoxFileNameSuffix.UseVisualStyleBackColor = True
        '
        'ListBoxFileName
        '
        Me.ListBoxFileName.FormattingEnabled = True
        Me.ListBoxFileName.ItemHeight = 12
        Me.ListBoxFileName.Location = New System.Drawing.Point(12, 29)
        Me.ListBoxFileName.Name = "ListBoxFileName"
        Me.ListBoxFileName.Size = New System.Drawing.Size(305, 376)
        Me.ListBoxFileName.TabIndex = 12
        '
        'ButtonOpenFolder
        '
        Me.ButtonOpenFolder.Location = New System.Drawing.Point(12, 416)
        Me.ButtonOpenFolder.Name = "ButtonOpenFolder"
        Me.ButtonOpenFolder.Size = New System.Drawing.Size(97, 29)
        Me.ButtonOpenFolder.TabIndex = 13
        Me.ButtonOpenFolder.Text = "Open folder"
        Me.ButtonOpenFolder.UseVisualStyleBackColor = True
        '
        'ButtonOpenFile
        '
        Me.ButtonOpenFile.Location = New System.Drawing.Point(116, 416)
        Me.ButtonOpenFile.Name = "ButtonOpenFile"
        Me.ButtonOpenFile.Size = New System.Drawing.Size(97, 29)
        Me.ButtonOpenFile.TabIndex = 13
        Me.ButtonOpenFile.Text = "Open file"
        Me.ButtonOpenFile.UseVisualStyleBackColor = True
        '
        'ButtonRemoveListPic
        '
        Me.ButtonRemoveListPic.Location = New System.Drawing.Point(220, 416)
        Me.ButtonRemoveListPic.Name = "ButtonRemoveListPic"
        Me.ButtonRemoveListPic.Size = New System.Drawing.Size(97, 29)
        Me.ButtonRemoveListPic.TabIndex = 13
        Me.ButtonRemoveListPic.Text = "Remove all"
        Me.ButtonRemoveListPic.UseVisualStyleBackColor = True
        '
        'ButtonApplyAll
        '
        Me.ButtonApplyAll.Location = New System.Drawing.Point(336, 416)
        Me.ButtonApplyAll.Name = "ButtonApplyAll"
        Me.ButtonApplyAll.Size = New System.Drawing.Size(285, 29)
        Me.ButtonApplyAll.TabIndex = 14
        Me.ButtonApplyAll.Text = "ApplyAll"
        Me.ButtonApplyAll.UseVisualStyleBackColor = True
        '
        'LabelOldFileName
        '
        Me.LabelOldFileName.Location = New System.Drawing.Point(334, 277)
        Me.LabelOldFileName.Name = "LabelOldFileName"
        Me.LabelOldFileName.Size = New System.Drawing.Size(287, 28)
        Me.LabelOldFileName.TabIndex = 15
        '
        'ButtonSelectNewPath
        '
        Me.ButtonSelectNewPath.Font = New System.Drawing.Font("宋体", 5.0!)
        Me.ButtonSelectNewPath.Location = New System.Drawing.Point(597, 337)
        Me.ButtonSelectNewPath.Name = "ButtonSelectNewPath"
        Me.ButtonSelectNewPath.Size = New System.Drawing.Size(24, 21)
        Me.ButtonSelectNewPath.TabIndex = 16
        Me.ButtonSelectNewPath.Text = "..."
        Me.ButtonSelectNewPath.UseVisualStyleBackColor = True
        '
        'MenuStripSettings
        '
        Me.MenuStripSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.MenuStripSettings.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripSettings.Name = "MenuStripSettings"
        Me.MenuStripSettings.Size = New System.Drawing.Size(642, 25)
        Me.MenuStripSettings.TabIndex = 19
        Me.MenuStripSettings.Text = "MenuStripSettings"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpecificStringToolStripMenuItem})
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(88, 21)
        Me.PreferencesToolStripMenuItem.Text = "&Preferences"
        '
        'SpecificStringToolStripMenuItem
        '
        Me.SpecificStringToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelToDeleteFileToolStripMenuItem, Me.PassToSkipToolStripMenuItem, Me.CopyButNotDeleteToolStripMenuItem})
        Me.SpecificStringToolStripMenuItem.Name = "SpecificStringToolStripMenuItem"
        Me.SpecificStringToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SpecificStringToolStripMenuItem.Text = "Specific String"
        '
        'DelToDeleteFileToolStripMenuItem
        '
        Me.DelToDeleteFileToolStripMenuItem.Checked = True
        Me.DelToDeleteFileToolStripMenuItem.CheckOnClick = True
        Me.DelToDeleteFileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DelToDeleteFileToolStripMenuItem.Name = "DelToDeleteFileToolStripMenuItem"
        Me.DelToDeleteFileToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.DelToDeleteFileToolStripMenuItem.Text = """/del"" to delete file"
        '
        'PassToSkipToolStripMenuItem
        '
        Me.PassToSkipToolStripMenuItem.Checked = True
        Me.PassToSkipToolStripMenuItem.CheckOnClick = True
        Me.PassToSkipToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PassToSkipToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveFromListToolStripMenuItem})
        Me.PassToSkipToolStripMenuItem.Name = "PassToSkipToolStripMenuItem"
        Me.PassToSkipToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.PassToSkipToolStripMenuItem.Text = """/pass"" to skip to the next one"
        '
        'RemoveFromListToolStripMenuItem
        '
        Me.RemoveFromListToolStripMenuItem.CheckOnClick = True
        Me.RemoveFromListToolStripMenuItem.Name = "RemoveFromListToolStripMenuItem"
        Me.RemoveFromListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RemoveFromListToolStripMenuItem.Text = "Remove from list"
        '
        'CopyButNotDeleteToolStripMenuItem
        '
        Me.CopyButNotDeleteToolStripMenuItem.CheckOnClick = True
        Me.CopyButNotDeleteToolStripMenuItem.Name = "CopyButNotDeleteToolStripMenuItem"
        Me.CopyButNotDeleteToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.CopyButNotDeleteToolStripMenuItem.Text = """&&"" as Prefix to copy but not delete"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 457)
        Me.Controls.Add(Me.MenuStripSettings)
        Me.Controls.Add(Me.ButtonSelectNewPath)
        Me.Controls.Add(Me.LabelOldFileName)
        Me.Controls.Add(Me.ButtonApplyAll)
        Me.Controls.Add(Me.ButtonRemoveListPic)
        Me.Controls.Add(Me.ButtonOpenFile)
        Me.Controls.Add(Me.ButtonOpenFolder)
        Me.Controls.Add(Me.ListBoxFileName)
        Me.Controls.Add(Me.CheckBoxFileNameSuffix)
        Me.Controls.Add(Me.CheckBoxFileNamePrefix)
        Me.Controls.Add(Me.LabelFileNameSuffix)
        Me.Controls.Add(Me.LabelFileNamePrefix)
        Me.Controls.Add(Me.LabelNewPath)
        Me.Controls.Add(Me.LabelNewFileName)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.TextBoxFileNameSuffix)
        Me.Controls.Add(Me.TextBoxFileNamePrefix)
        Me.Controls.Add(Me.TextBoxNewPath)
        Me.Controls.Add(Me.TextBoxNewFileName)
        Me.Controls.Add(Me.PictureBoxProcessing)
        Me.KeyPreview = True
        Me.Name = "FormMain"
        Me.Text = "Manual-Picture-Classifying-Assistant"
        CType(Me.PictureBoxProcessing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripSettings.ResumeLayout(False)
        Me.MenuStripSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxProcessing As PictureBox
    Friend WithEvents TextBoxNewFileName As TextBox
    Friend WithEvents TextBoxNewPath As TextBox
    Friend WithEvents TextBoxFileNamePrefix As TextBox
    Friend WithEvents TextBoxFileNameSuffix As TextBox
    Friend WithEvents ButtonNext As Button
    Friend WithEvents LabelNewFileName As Label
    Friend WithEvents LabelNewPath As Label
    Friend WithEvents LabelFileNamePrefix As Label
    Friend WithEvents LabelFileNameSuffix As Label
    Friend WithEvents CheckBoxFileNamePrefix As CheckBox
    Friend WithEvents CheckBoxFileNameSuffix As CheckBox
    Friend WithEvents ListBoxFileName As ListBox
    Friend WithEvents ButtonOpenFolder As Button
    Friend WithEvents ButtonOpenFile As Button
    Friend WithEvents ButtonRemoveListPic As Button
    Friend WithEvents OpenFileDialogForList As OpenFileDialog
    Friend WithEvents FolderBrowserDialogForList As FolderBrowserDialog
    Friend WithEvents ButtonApplyAll As Button
    Friend WithEvents LabelOldFileName As Label
    Friend WithEvents ButtonSelectNewPath As Button
    Friend WithEvents MenuStripSettings As MenuStrip
    Friend WithEvents PreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpecificStringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DelToDeleteFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PassToSkipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyButNotDeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveFromListToolStripMenuItem As ToolStripMenuItem
End Class
