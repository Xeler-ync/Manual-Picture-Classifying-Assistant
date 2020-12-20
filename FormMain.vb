Imports System.IO
Public Class FormMain
    Dim FileMovement(0 To 1, 0) As String '存储文件移动信息，第一维为0时是原路径,为1时是新路径
    Dim UsingEnter As Boolean
    Private Sub ButtonOpenFolder_Click(sender As Object, e As EventArgs) Handles ButtonOpenFolder.Click '打开文件夹
        Dim Path As String
        If FolderBrowserDialogForList.ShowDialog() = DialogResult.OK Then
            Path = FolderBrowserDialogForList.SelectedPath
            GetAllFile(Path)
        End If
    End Sub

    Private Sub GetAllFile(ByVal path As String) '遍历获取目录下文件
        Dim StrFile As String() = System.IO.Directory.GetFiles(path)
        If StrFile.Length > 0 Then
            IdentifyExtension(StrFile)
        End If
    End Sub

    Private Sub IdentifyExtension(ByVal StrFile() As String) '以文件扩展名识别图片并加入ListBoxFileName中
        Dim SupportExtension As String = " .png .jpg"
        For i = 0 To StrFile.Length - 1
            Dim Extension As String
            Extension = System.IO.Path.GetExtension(StrFile(i)) '获取扩展名
            If InStr(SupportExtension, Extension, vbTextCompare) > 0 And Extension <> "" Then
                ListBoxFileName.Items.Add(StrFile(i))
            End If
        Next
    End Sub

    Private Sub ButtonOpenFile_Click(sender As Object, e As EventArgs) Handles ButtonOpenFile.Click '打开文件
        Dim Path(0) As String
        If OpenFileDialogForList.ShowDialog() = DialogResult.OK Then
            Path(0) = OpenFileDialogForList.FileName
            IdentifyExtension(Path)
        End If
    End Sub

    Private Sub ListBoxFileName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFileName.SelectedIndexChanged '选择文件
        Dim Path As String
        Path = ListBoxFileName.SelectedItem
        If Path <> Nothing Then
            Try
                Dim Stream As New FileStream(Path, FileMode.Open) '以流打开
                Dim Picture As Image
                Picture = Image.FromStream(Stream)
                PictureBoxProcessing.Image = Picture
                Stream.Close()
                LabelOldFileName.Text = System.IO.Path.GetFileName(Path) '获取文件名
            Catch
                MsgBox("文件被占用")
                ButtonNextUseable()
                Exit Sub
            End Try
        End If
        ButtonNextUseable()
    End Sub

    Private Sub ButtonRemoveListPic_Click(sender As Object, e As EventArgs) Handles ButtonRemoveListPic.Click '清空列表
        ListBoxFileName.Items.Clear()
        If PictureBoxProcessing.ImageLocation <> Nothing Then
            PictureBoxProcessing.Image.Dispose()
            GC.Collect()
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        NextPic()
    End Sub

    Private Sub ButtonNextUseable() '确认条件能否允许按钮被使用
        If TextBoxNewPath.Text <> "" And Not (CheckBoxFileNamePrefix.CheckState = CheckState.Checked And TextBoxFileNamePrefix.Text = "") And Not (CheckBoxFileNameSuffix.CheckState = CheckState.Checked And TextBoxFileNameSuffix.Text = "") And ListBoxFileName.SelectedItem <> "" Then
            ButtonNext.Enabled = True
        Else
            ButtonNext.Enabled = False
        End If
    End Sub

    Private Sub TextBoxNewFileName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNewFileName.TextChanged
        ButtonNextUseable()
    End Sub

    Private Sub NextPic() '完成了这张图片，进入下一张
        If Not (PassToSkipToolStripMenuItem.Checked = True And TextBoxNewFileName.Text.Replace(" ", "") = "/pass") Then '如果用户不是要跳过
            If TextBoxNewPath.Text(Len(TextBoxNewPath.Text) - 1) <> "\" Then '先确保路径没有缺失反斜杠
                TextBoxNewPath.Text += "\"
            End If
            Dim NewListUBound As UInt16 = UBound(FileMovement, 2) + 1 '计算新上标
            ReDim Preserve FileMovement(0 To 1, 0 To NewListUBound) '扩展数组
            Dim OriginalPath As String = "" '原路径
            Dim NewPath As String = "" '新路径
            If CopyButNotDeleteToolStripMenuItem.Checked = True Then '如果不删除原文件在头则加上标识
                OriginalPath += "%DTDel%“
            End If
            OriginalPath += ListBoxFileName.SelectedItem
            FileMovement(0, NewListUBound) = OriginalPath '存储原路径
            NewPath = TextBoxNewPath.Text '文件夹
            If CheckBoxFileNamePrefix.Checked = True Then '前缀
                NewPath += TextBoxFileNamePrefix.Text
            End If
            If TextBoxNewFileName.Text <> "" Then
                    NewPath += TextBoxNewFileName.Text '文件名
                Else
                    NewPath += System.IO.Path.GetFileNameWithoutExtension(ListBoxFileName.SelectedItem)
                End If
                If CheckBoxFileNameSuffix.Checked = True Then '后缀
                    NewPath += TextBoxFileNameSuffix.Text
                End If
                NewPath += System.IO.Path.GetExtension(ListBoxFileName.SelectedItem)
                FileMovement(1, NewListUBound) = NewPath '存储新路径
            End If
            Dim PicListSelectedIndex As UInt16
        PicListSelectedIndex = ListBoxFileName.SelectedIndex
        Try
            ListBoxFileName.SelectedIndex = PicListSelectedIndex + 1
        Catch
        End Try
        If Not (PassToSkipToolStripMenuItem.Checked = True And RemoveFromListToolStripMenuItem.Checked = True And TextBoxNewFileName.Text.Replace(" ", "") = "/pass") Then '如果用户不是要(跳过且不从列表中删除该项)
            ListBoxFileName.Items.RemoveAt(PicListSelectedIndex)
        End If
        TextBoxNewFileName.Text = ""
        ButtonNextUseable()
    End Sub

    Private Sub TextBoxFileNamePrefix_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFileNamePrefix.TextChanged
        ButtonNextUseable()
    End Sub

    Private Sub TextBoxFileNameSuffix_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFileNameSuffix.TextChanged
        ButtonNextUseable()
    End Sub

    Private Sub CheckBoxFileNamePrefix_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFileNamePrefix.CheckedChanged
        ButtonNextUseable()
    End Sub

    Private Sub CheckBoxFileNameSuffix_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFileNameSuffix.CheckedChanged
        ButtonNextUseable()
    End Sub

    Private Sub ButtonApplyAll_Click(sender As Object, e As EventArgs) Handles ButtonApplyAll.Click
        For i = 1 To UBound(FileMovement, 2) '先复制文件
            Dim SuffixIndex As Byte = 0
            Dim SuffixIndexStr As String = ""
            Do '检查重复文件名，如果有则加上序号
                Try '组合文件路径
                    Dim Path As String
                    If FileMovement(0, i).Contains("%DTDel%") Then '如果存在标识则去除后再赋值
                        Path = FileMovement(0, i).Replace("%DTDel%", "")
                    Else
                        Path = FileMovement(0, i)
                    End If
                    File.Copy(FileMovement(0, i), System.IO.Path.GetFileNameWithoutExtension(FileMovement(1, i)) & SuffixIndexStr & System.IO.Path.GetExtension(FileMovement(1, i)), False)
                    SuffixIndex = 0 '如果正常则会进行到这，并清空缓存
                    SuffixIndexStr = ""
                    Exit Do '进行下一个文件
                Catch a As System.IO.IOException 'Catch重复的错误
                    SuffixIndex += 1 '如果添加序号依旧有重复则+1
                    SuffixIndexStr = " (" & SuffixIndex & ")"
                End Try
            Loop
        Next
        For i = 1 To UBound(FileMovement, 2) '复制完后删除原文件
            If Not FileMovement(0, i).Contains("%DTDel%") Then '如果存在标识则跳过
                File.Delete(FileMovement(0, i))
            End If
        Next
    End Sub

    Private Sub ButtonSelectNewPath_Click(sender As Object, e As EventArgs) Handles ButtonSelectNewPath.Click
        Dim Path As String
        If FolderBrowserDialogForList.ShowDialog() = DialogResult.OK Then
            Path = FolderBrowserDialogForList.SelectedPath
            TextBoxNewPath.Text = Path
        End If
    End Sub

    Private Sub FormMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If TextBoxNewPath.Text <> "" And Not (CheckBoxFileNamePrefix.CheckState = CheckState.Checked And TextBoxFileNamePrefix.Text = "") And Not (CheckBoxFileNameSuffix.CheckState = CheckState.Checked And TextBoxFileNameSuffix.Text = "") And ListBoxFileName.SelectedItem <> "" AndAlso e.KeyCode = 13 Then
            UsingEnter = True '给KeyPress用
            NextPic()
        End If
    End Sub

    Private Sub FormMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If UsingEnter = True Then
            e.Handled = True '使回车不吵
            UsingEnter = False
        End If
    End Sub
End Class