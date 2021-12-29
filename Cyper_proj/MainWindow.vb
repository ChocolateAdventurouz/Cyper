Imports System.IO


Public Class MainWindow

    Private Sub SBootBtn_Click(sender As Object, e As EventArgs) Handles SBootBtn.Click
        UseWaitCursor = 1
        Process.Start("cmd", "bcdedit /set {default} bootmenupolicy legacy & taskkill /im cmd.exe & exit")
        ActivityBar.Value = 100
        MsgBox("The command has been executed. Please reboot your computer.")
        ActivityBar.Value = 0
        UseWaitCursor = 0
    End Sub


    Private Sub CDiskBtn_Click(sender As Object, e As EventArgs) Handles CDiskBtn.Click
        UseWaitCursor = 1
        Process.Start("cmd", "/k cleanmgr/ sagerun: 1 & taskkill /im cmd.exe")
        ActivityBar.Value = 100
        MsgBox("The command has been executed.")
        ActivityBar.Value = 0
        UseWaitCursor = 0
    End Sub

    Private Sub FreshBtn_Click(sender As Object, e As EventArgs) Handles FreshBtn.Click
        UseWaitCursor = 1
        Process.Start("cmd", "/k sfc /scannow & DISM /Online /Cleanup-Image /CheckHealth & DISM /Online /Cleanup-Image /ScanHealth & DISM /Online /Cleanup-Image /RestoreHealth /Source:repairSource\install.wim & taskkill /im cmd.exe")
        ActivityBar.Value = 100
        MsgBox("The command has been executed.")
        ActivityBar.Value = 0
        UseWaitCursor = 0
    End Sub

    Private Sub TempCleanBtn_Click(sender As Object, e As EventArgs) Handles TempCleanBtn.Click
        UseWaitCursor = 1
        Process.Start("cmd", "/k rd %temp% /s /q & md %temp% & cd C:\Windows\Temp & del *.* /Q & del C:\Windows\prefetch\*.*/s/q & taskkill /im cmd.exe")
        ActivityBar.Value = 100
        MsgBox("The command has been executed.")
        ActivityBar.Value = 0
        UseWaitCursor = 0
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ScanBtn.Click
        UseWaitCursor = 1
        ScannerFDialog.ShowDialog()
        Path.GetFullPath(ScannerFDialog.FileName)
        Path.GetFileName(ScannerFDialog.FileName)
        ActivityBar.Value = 50
        Dim fileName As String = Path.GetFileName(ScannerFDialog.FileName)
        Dim fpath As String = Path.GetFullPath(ScannerFDialog.FileName)
        If fileName = "" Then
            MsgBox("File selection returned NULL. Please select a file.")
            Exit Sub
        End If
        ScanLog.Clear()
        ScanLog.Text = fileName
        If ScanLog.Text = "" Then
            ScanLog.Text = "_-_File Scanner + _-_"
        End If
        Process.Start("scanner.exe", "" & fpath & "")
        ActivityBar.Value = 100
        ActivityBar.Value = 0
        UseWaitCursor = 0
    End Sub

    Private Sub MainWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            About.Show()
        End If
    End Sub

    Private Sub AboutCyperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutCyperToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Config.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("cmd", "REG ADD HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer /V ClearRecentDocsOnExit /T REG_DWORD /D 00000001")
        MsgBox("The command has been executed.")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("cmd", "REG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management /V ClearPageFileAtShutdown /T REG_DWORD /D 00000001")
        MsgBox("The command has been executed.")
    End Sub


    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        SplashScreen1.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("cmd", "powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61")
        MsgBox("The Power Plan has been unlocked & set. In case the plan has not been setted, please enable it, manually. ")
    End Sub

    Private Sub RepairInstallationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepairInstallationToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class

