Imports System.IO
Imports System
Public Class MainWindow
    Private obj As Object

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ScannerFDialog.ShowDialog()
        Path.GetFileName(ScannerFDialog.FileName)

        Dim fileName As String = Path.GetFileName(ScannerFDialog.FileName)
        TextBox1.Clear()
        TextBox1.Text = fileName
        If TextBox1.Text = "" Then
            TextBox1.Text = "_-_File Scanner + _-_"
        End If
        Dim NewProcess As New System.Diagnostics.Process()
        With NewProcess.StartInfo
            .FileName = "Scanner.exe"
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .RedirectStandardInput = True
            .UseShellExecute = False
            .WindowStyle = ProcessWindowStyle.Normal
            .CreateNoWindow = False
        End With

        NewProcess.Start()

        System.Threading.Thread.Sleep(3000)
        TextBox1.Text = NewProcess.StandardOutput.ReadToEnd
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainWindow_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub MainWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            About.Show()
        End If
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutCyperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutCyperToolStripMenuItem.Click
        About.Show()
    End Sub
End Class

