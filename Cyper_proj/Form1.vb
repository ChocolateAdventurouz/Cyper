'Cyper - Settings Menu by SecurityRaven'
Imports System.Environment
Imports System.Drawing

Public Class Config

    Function LightTheme()
        Me.BackColor = Color.White
        Label1.ForeColor = Color.Black
        MainWindow.BackColor = Color.White
        MainWindow.SectionA.ForeColor = Color.Black
        MainWindow.SectionB.ForeColor = Color.Black
        MainWindow.SectionC.ForeColor = Color.Black
        MainWindow.SectionD.ForeColor = Color.Black
        MainWindow.CDiskLabel.ForeColor = Color.Black
        MainWindow.FreshLabel.ForeColor = Color.Black
        MainWindow.SBootLabel.ForeColor = Color.Black
        MainWindow.TempCleanLabel.ForeColor = Color.Black
        MainWindow.Label4.ForeColor = Color.Black
        MainWindow.Label5.ForeColor = Color.Black
        About.BackColor = Color.White
        About.LabelCompanyName.ForeColor = Color.Black
        About.LabelCopyright.ForeColor = Color.Black
        About.LabelProductName.ForeColor = Color.Black
        About.LabelVersion.ForeColor = Color.Black
        MainWindow.Label1.ForeColor = Color.Black
        MainWindow.Label3.ForeColor = Color.Black
        MainWindow.Label6.ForeColor = Color.Black
        Return 0
    End Function

    Function DarkTheme()
        Me.BackColor = Color.Black
        Label1.ForeColor = Color.White
        CheckBox1.ForeColor = Color.White
        MainWindow.BackColor = Color.Black
        MainWindow.SectionA.ForeColor = Color.White
        MainWindow.SectionB.ForeColor = Color.White
        MainWindow.SectionC.ForeColor = Color.White
        MainWindow.SectionD.ForeColor = Color.White
        MainWindow.CDiskLabel.ForeColor = Color.White
        MainWindow.FreshLabel.ForeColor = Color.White
        MainWindow.SBootLabel.ForeColor = Color.White
        MainWindow.TempCleanLabel.ForeColor = Color.White
        MainWindow.Label4.ForeColor = Color.White
        MainWindow.Label5.ForeColor = Color.White
        About.BackColor = Color.Black
        About.LabelCompanyName.ForeColor = Color.White
        About.LabelCopyright.ForeColor = Color.White
        About.LabelProductName.ForeColor = Color.White
        About.LabelVersion.ForeColor = Color.White
        About.OKButton.ForeColor = Color.White
        About.LogoPictureBox.BackColor = Color.Transparent
        MainWindow.ActLabel.ForeColor = Color.White
        MainWindow.Label1.ForeColor = Color.White
        MainWindow.Label3.ForeColor = Color.White
        MainWindow.Label6.ForeColor = Color.White
        Return 0
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "Dark Theme" Then
            DarkTheme()
            Process.Start("themes.exe", "Dark")
        End If
        If ListBox1.SelectedItem = "Light Theme" Then
            LightTheme()
            Process.Start("themes.exe", "Light")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
        If CheckBox1.Checked Then
            Dim SFPath As String = appData & "\Microsoft\Windows\Start Menu\Programs\Startup"
            Dim SF As String = "CyperAutoClean.exe"
            Dim fi As New IO.FileInfo(SF)
            fi.CopyTo(SFPath, True)
            MsgBox("If you want to remove it, you have to do it manually by going to: C:\Users\%username%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup and deleting CyperAutoClean.exe")
        End If
    End Sub
End Class