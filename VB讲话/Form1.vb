Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine
        Dim subkey As Microsoft.Win32.RegistryKey
        Dim yes
        subkey = key.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run")
        yes = subkey.GetValue("终端子键")
        If yes Is Nothing Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("regedit.exe")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("cmd.exe")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("taskmgr.exe")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("shutdown /s /t 0", 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("shutdown /r /t 0", 0)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("cmd.exe /c services.msc", 0)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Shell("cmd.exe /c gpedit.msc", 0)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Shell("cmd.exe /c lusrmgr.msc", 0)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Shell("cleanmgr.exe")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Shell("cmd.exe /c compmgmt.msc", 0)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Shell("charmap.exe")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Shell("cmd.exe /c diskmgmt.msc", 0)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Shell("cmd.exe /c devmgmt.msc", 0)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Shell("cmd.exe /c perfmon.msc", 0)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Shell("cmd.exe /c systeminfo >计算机信息.txt", 0)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Shell("cmd.exe /c taskkill /im wininit.exe /f", 0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Hour(Now) & ": " & Minute(Now) & ": " & Second(Now)
        Label4.text = Environment.GetEnvironmentVariable("username")
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        Dim key As Microsoft.Win32.RegistryKey
        key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        If CheckBox1.Checked = True Then
            key.SetValue("终端子键", Application.ExecutablePath)
        Else
            key.DeleteValue("终端子键")
        End If
        key.Close()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Form2.Show()
    End Sub
End Class
