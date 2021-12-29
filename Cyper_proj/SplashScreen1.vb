Imports System.IO
Imports System.Drawing
Imports Microsoft.Win32.RegistryKey
Imports Microsoft.Win32.Registry
Imports Microsoft.Win32.RegistryValueOptions
Imports Microsoft.Win32
Imports System.Threading

Public NotInheritable Class SplashScreen1
    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thread.Sleep(3000)
        ProgressBar1.Value = 50
        Dim Dark = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Cyper", "Dark_Theme", Nothing)
        Dim Light = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Cyper", "Light_Theme", Nothing)
        If Dark = 1 Then
            Config.DarkTheme()
            Me.Close()
            MainWindow.Show()
            Console.WriteLine("Dark")
            ProgressBar1.Value = 100
        End If
        If Light = 1 Then
            Config.LightTheme()
            Console.WriteLine("Light")
            Me.Close()
            MainWindow.Show()
            ProgressBar1.Value = 100
        End If
    End Sub
End Class

