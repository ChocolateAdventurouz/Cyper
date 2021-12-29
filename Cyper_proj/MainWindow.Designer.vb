<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.FreshLabel = New System.Windows.Forms.Label()
        Me.SBootLabel = New System.Windows.Forms.Label()
        Me.CDiskLabel = New System.Windows.Forms.Label()
        Me.ActivityBar = New System.Windows.Forms.ProgressBar()
        Me.ActLabel = New System.Windows.Forms.Label()
        Me.SectionA = New System.Windows.Forms.Label()
        Me.SectionB = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ScannerFDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ScanLog = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SectionC = New System.Windows.Forms.Label()
        Me.SectionD = New System.Windows.Forms.Label()
        Me.MainStrip = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCyperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepairInstallationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TempCleanLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ScanBtn = New System.Windows.Forms.PictureBox()
        Me.FreshBtn = New System.Windows.Forms.PictureBox()
        Me.SBootBtn = New System.Windows.Forms.PictureBox()
        Me.CDiskBtn = New System.Windows.Forms.PictureBox()
        Me.TempCleanBtn = New System.Windows.Forms.PictureBox()
        Me.MainStrip.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScanBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FreshBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBootBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDiskBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempCleanBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FreshLabel
        '
        Me.FreshLabel.AutoSize = True
        Me.FreshLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreshLabel.ForeColor = System.Drawing.Color.Black
        Me.FreshLabel.Location = New System.Drawing.Point(165, 700)
        Me.FreshLabel.Name = "FreshLabel"
        Me.FreshLabel.Size = New System.Drawing.Size(148, 15)
        Me.FreshLabel.TabIndex = 2
        Me.FreshLabel.Text = "Re-apply Windows Image"
        '
        'SBootLabel
        '
        Me.SBootLabel.AutoSize = True
        Me.SBootLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SBootLabel.ForeColor = System.Drawing.Color.Black
        Me.SBootLabel.Location = New System.Drawing.Point(320, 361)
        Me.SBootLabel.Name = "SBootLabel"
        Me.SBootLabel.Size = New System.Drawing.Size(106, 15)
        Me.SBootLabel.TabIndex = 3
        Me.SBootLabel.Text = "Enable F8 Booting"
        '
        'CDiskLabel
        '
        Me.CDiskLabel.AutoSize = True
        Me.CDiskLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDiskLabel.ForeColor = System.Drawing.Color.Black
        Me.CDiskLabel.Location = New System.Drawing.Point(290, 181)
        Me.CDiskLabel.Name = "CDiskLabel"
        Me.CDiskLabel.Size = New System.Drawing.Size(64, 15)
        Me.CDiskLabel.TabIndex = 4
        Me.CDiskLabel.Text = "Clean Disk"
        '
        'ActivityBar
        '
        Me.ActivityBar.Location = New System.Drawing.Point(496, 719)
        Me.ActivityBar.Name = "ActivityBar"
        Me.ActivityBar.Size = New System.Drawing.Size(100, 23)
        Me.ActivityBar.TabIndex = 9
        Me.ActivityBar.UseWaitCursor = True
        '
        'ActLabel
        '
        Me.ActLabel.AutoSize = True
        Me.ActLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActLabel.ForeColor = System.Drawing.Color.Black
        Me.ActLabel.Location = New System.Drawing.Point(437, 723)
        Me.ActLabel.Name = "ActLabel"
        Me.ActLabel.Size = New System.Drawing.Size(53, 15)
        Me.ActLabel.TabIndex = 10
        Me.ActLabel.Text = "Activity:"
        '
        'SectionA
        '
        Me.SectionA.AutoSize = True
        Me.SectionA.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionA.ForeColor = System.Drawing.Color.Black
        Me.SectionA.Location = New System.Drawing.Point(163, 24)
        Me.SectionA.Name = "SectionA"
        Me.SectionA.Size = New System.Drawing.Size(178, 30)
        Me.SectionA.TabIndex = 11
        Me.SectionA.Text = "Cleaning Section"
        '
        'SectionB
        '
        Me.SectionB.AutoSize = True
        Me.SectionB.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionB.ForeColor = System.Drawing.Color.Black
        Me.SectionB.Location = New System.Drawing.Point(172, 222)
        Me.SectionB.Name = "SectionB"
        Me.SectionB.Size = New System.Drawing.Size(186, 30)
        Me.SectionB.TabIndex = 12
        Me.SectionB.Text = "Tweaking Section"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(166, 534)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Scan a file"
        '
        'ScanLog
        '
        Me.ScanLog.Location = New System.Drawing.Point(289, 486)
        Me.ScanLog.Name = "ScanLog"
        Me.ScanLog.ReadOnly = True
        Me.ScanLog.Size = New System.Drawing.Size(117, 20)
        Me.ScanLog.TabIndex = 15
        Me.ScanLog.Text = "_-_File Scanner + _-_"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(286, 468)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Log"
        '
        'SectionC
        '
        Me.SectionC.AutoSize = True
        Me.SectionC.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionC.ForeColor = System.Drawing.Color.Black
        Me.SectionC.Location = New System.Drawing.Point(189, 398)
        Me.SectionC.Name = "SectionC"
        Me.SectionC.Size = New System.Drawing.Size(171, 30)
        Me.SectionC.TabIndex = 17
        Me.SectionC.Text = "Security Section"
        '
        'SectionD
        '
        Me.SectionD.AutoSize = True
        Me.SectionD.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionD.ForeColor = System.Drawing.Color.Black
        Me.SectionD.Location = New System.Drawing.Point(162, 569)
        Me.SectionD.Name = "SectionD"
        Me.SectionD.Size = New System.Drawing.Size(157, 30)
        Me.SectionD.TabIndex = 19
        Me.SectionD.Text = "Health Section"
        '
        'MainStrip
        '
        Me.MainStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MainStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainStrip.Name = "MainStrip"
        Me.MainStrip.Size = New System.Drawing.Size(604, 24)
        Me.MainStrip.TabIndex = 24
        Me.MainStrip.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutCyperToolStripMenuItem, Me.RepairInstallationToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutCyperToolStripMenuItem
        '
        Me.AboutCyperToolStripMenuItem.Name = "AboutCyperToolStripMenuItem"
        Me.AboutCyperToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutCyperToolStripMenuItem.Text = "About Cyper..."
        '
        'RepairInstallationToolStripMenuItem
        '
        Me.RepairInstallationToolStripMenuItem.Name = "RepairInstallationToolStripMenuItem"
        Me.RepairInstallationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RepairInstallationToolStripMenuItem.Text = "Repair Installation"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'TempCleanLabel
        '
        Me.TempCleanLabel.AutoSize = True
        Me.TempCleanLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempCleanLabel.ForeColor = System.Drawing.Color.Black
        Me.TempCleanLabel.Location = New System.Drawing.Point(128, 181)
        Me.TempCleanLabel.Name = "TempCleanLabel"
        Me.TempCleanLabel.Size = New System.Drawing.Size(98, 15)
        Me.TempCleanLabel.TabIndex = 1
        Me.TempCleanLabel.Text = "Clean Temp Files"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(181, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Disable 'Recent Files'"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Clear Paging file at Shutdown"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(432, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 15)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Hidden Ultra Configuration"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Cyper_proj.My.Resources.Resources.ultra
        Me.PictureBox4.Location = New System.Drawing.Point(480, 279)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(69, 68)
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Cyper_proj.My.Resources.Resources.paging
        Me.PictureBox3.Location = New System.Drawing.Point(48, 279)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(69, 68)
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cyper_proj.My.Resources.Resources.recent
        Me.PictureBox1.Location = New System.Drawing.Point(202, 279)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 68)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'ScanBtn
        '
        Me.ScanBtn.Image = Global.Cyper_proj.My.Resources.Resources.scanner
        Me.ScanBtn.Location = New System.Drawing.Point(166, 449)
        Me.ScanBtn.Name = "ScanBtn"
        Me.ScanBtn.Size = New System.Drawing.Size(69, 68)
        Me.ScanBtn.TabIndex = 14
        Me.ScanBtn.TabStop = False
        '
        'FreshBtn
        '
        Me.FreshBtn.Image = Global.Cyper_proj.My.Resources.Resources.fresh
        Me.FreshBtn.Location = New System.Drawing.Point(202, 618)
        Me.FreshBtn.Name = "FreshBtn"
        Me.FreshBtn.Size = New System.Drawing.Size(69, 68)
        Me.FreshBtn.TabIndex = 7
        Me.FreshBtn.TabStop = False
        '
        'SBootBtn
        '
        Me.SBootBtn.Image = Global.Cyper_proj.My.Resources.Resources.boot
        Me.SBootBtn.Location = New System.Drawing.Point(341, 279)
        Me.SBootBtn.Name = "SBootBtn"
        Me.SBootBtn.Size = New System.Drawing.Size(69, 68)
        Me.SBootBtn.TabIndex = 6
        Me.SBootBtn.TabStop = False
        '
        'CDiskBtn
        '
        Me.CDiskBtn.Image = Global.Cyper_proj.My.Resources.Resources.disk
        Me.CDiskBtn.Location = New System.Drawing.Point(289, 99)
        Me.CDiskBtn.Name = "CDiskBtn"
        Me.CDiskBtn.Size = New System.Drawing.Size(69, 68)
        Me.CDiskBtn.TabIndex = 5
        Me.CDiskBtn.TabStop = False
        '
        'TempCleanBtn
        '
        Me.TempCleanBtn.Image = Global.Cyper_proj.My.Resources.Resources.temp
        Me.TempCleanBtn.Location = New System.Drawing.Point(146, 99)
        Me.TempCleanBtn.Name = "TempCleanBtn"
        Me.TempCleanBtn.Size = New System.Drawing.Size(69, 68)
        Me.TempCleanBtn.TabIndex = 0
        Me.TempCleanBtn.TabStop = False
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(604, 765)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SectionD)
        Me.Controls.Add(Me.SectionC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ScanLog)
        Me.Controls.Add(Me.ScanBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SectionB)
        Me.Controls.Add(Me.SectionA)
        Me.Controls.Add(Me.ActLabel)
        Me.Controls.Add(Me.ActivityBar)
        Me.Controls.Add(Me.FreshBtn)
        Me.Controls.Add(Me.SBootBtn)
        Me.Controls.Add(Me.CDiskBtn)
        Me.Controls.Add(Me.CDiskLabel)
        Me.Controls.Add(Me.SBootLabel)
        Me.Controls.Add(Me.FreshLabel)
        Me.Controls.Add(Me.TempCleanLabel)
        Me.Controls.Add(Me.TempCleanBtn)
        Me.Controls.Add(Me.MainStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.Text = "Cyper"
        Me.MainStrip.ResumeLayout(False)
        Me.MainStrip.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScanBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FreshBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBootBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDiskBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempCleanBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TempCleanBtn As PictureBox
    Friend WithEvents TempCleanLabel As Label
    Friend WithEvents FreshLabel As Label
    Friend WithEvents SBootLabel As Label
    Friend WithEvents CDiskLabel As Label
    Friend WithEvents CDiskBtn As PictureBox
    Friend WithEvents SBootBtn As PictureBox
    Friend WithEvents FreshBtn As PictureBox
    Friend WithEvents ActivityBar As ProgressBar
    Friend WithEvents ActLabel As Label
    Friend WithEvents SectionA As Label
    Friend WithEvents SectionB As Label
    Friend WithEvents ScanBtn As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ScannerFDialog As OpenFileDialog
    Friend WithEvents ScanLog As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SectionC As Label
    Friend WithEvents SectionD As Label
    Friend WithEvents MainStrip As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutCyperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RepairInstallationToolStripMenuItem As ToolStripMenuItem
End Class
