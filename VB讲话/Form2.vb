Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        If TextBox2.Text <= 0 Then
            MsgBox("值无效，值应大于0",, "Warning")
            Exit Sub
        End If
        If RadioButton1.Checked = True Then
            a = 65500
        ElseIf RadioButton2.Checked = True Then
            a = 1024
        ElseIf RadioButton3.Checked = True Then
            a = 16
        Else
            MsgBox("对不起必须选择一个右边的数据包",, "Please choos one")
            Exit Sub
        End If
        For b = 1 To TextBox2.Text
            Shell("ping " + TextBox1.Text + " -t -l " & a, 0)
        Next
        Label3.Text = "程序正在运行"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("taskkill /im conhost.exe /f", 0)
        Shell("taskkill /im ping.exe /f", 0)
        Label3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class