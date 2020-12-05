Public Class FormMain
    Private Sub ButtonOpenFolder_Click(sender As Object, e As EventArgs) Handles ButtonOpenFolder.Click
        Dim Path As String
        If FolderBrowserDialogForList.ShowDialog() = DialogResult.OK Then
            Path = FolderBrowserDialogForList.SelectedPath
            GetAllFile(Path)
        End If
    End Sub

    Private Sub GetAllFile(ByVal path As String)
        Dim StrFile As String() = System.IO.Directory.GetFiles(path)
        If StrFile.Length > 0 Then
            IdentifyExtension(StrFile)
        End If
    End Sub

    Private Sub IdentifyExtension(ByVal StrFile() As String) '识别并加入ListBoxFileName中
        Dim SupportExtension As String = " .png .jpg"
        For i = 0 To StrFile.Length - 1
            Dim Extension As String
            Extension = System.IO.Path.GetExtension(StrFile(i)) '获取扩展名
            If InStr(SupportExtension, Extension, vbTextCompare) > 0 Then
                ListBoxFileName.Items.Add(StrFile(i))
            End If
        Next
    End Sub
    Private Sub ButtonOpenFile_Click(sender As Object, e As EventArgs) Handles ButtonOpenFile.Click
        Dim Path(0) As String
        If OpenFileDialogForList.ShowDialog() = DialogResult.OK Then
            Path(0) = OpenFileDialogForList.FileName
            IdentifyExtension(Path)
        End If
    End Sub
    Private Sub ListBoxFileName_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxFileName.DoubleClick
        Dim Path As String
        Path = ListBoxFileName.SelectedItem
        PictureBoxProcessing.Image = Image.FromFile(Path)
    End Sub
End Class
