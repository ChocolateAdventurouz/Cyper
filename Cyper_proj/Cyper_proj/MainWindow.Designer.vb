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
        Me.TempCleanLabel = New System.Windows.Forms.Label()
        Me.FreshLabel = New System.Windows.Forms.Label()
        Me.SBootLabel = New System.Windows.Forms.Label()
        Me.CDiskLabel = New System.Windows.Forms.Label()
        Me.ActivityBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ScannerFDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FreshBtn = New System.Windows.Forms.PictureBox()
        Me.SBootBtn = New System.Windows.Forms.PictureBox()
        Me.CDiskBtn = New System.Windows.Forms.PictureBox()
        Me.TempCleanBtn = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReinstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCyperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FreshBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBootBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDiskBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempCleanBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TempCleanLabel
        '
        Me.TempCleanLabel.AutoSize = True
        Me.TempCleanLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempCleanLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TempCleanLabel.Location = New System.Drawing.Point(37, 148)
        Me.TempCleanLabel.Name = "TempCleanLabel"
        Me.TempCleanLabel.Size = New System.Drawing.Size(98, 15)
        Me.TempCleanLabel.TabIndex = 1
        Me.TempCleanLabel.Text = "Clean Temp Files"
        '
        'FreshLabel
        '
        Me.FreshLabel.AutoSize = True
        Me.FreshLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreshLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FreshLabel.Location = New System.Drawing.Point(18, 598)
        Me.FreshLabel.Name = "FreshLabel"
        Me.FreshLabel.Size = New System.Drawing.Size(148, 15)
        Me.FreshLabel.TabIndex = 2
        Me.FreshLabel.Text = "Re-apply Windows Image"
        '
        'SBootLabel
        '
        Me.SBootLabel.AutoSize = True
        Me.SBootLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SBootLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SBootLabel.Location = New System.Drawing.Point(34, 312)
        Me.SBootLabel.Name = "SBootLabel"
        Me.SBootLabel.Size = New System.Drawing.Size(106, 15)
        Me.SBootLabel.TabIndex = 3
        Me.SBootLabel.Text = "Enable F8 Booting"
        '
        'CDiskLabel
        '
        Me.CDiskLabel.AutoSize = True
        Me.CDiskLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDiskLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CDiskLabel.Location = New System.Drawing.Point(227, 148)
        Me.CDiskLabel.Name = "CDiskLabel"
        Me.CDiskLabel.Size = New System.Drawing.Size(64, 15)
        Me.CDiskLabel.TabIndex = 4
        Me.CDiskLabel.Text = "Clean Disk"
        '
        'ActivityBar
        '
        Me.ActivityBar.Location = New System.Drawing.Point(567, 728)
        Me.ActivityBar.Name = "ActivityBar"
        Me.ActivityBar.Size = New System.Drawing.Size(100, 23)
        Me.ActivityBar.TabIndex = 9
        Me.ActivityBar.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(508, 732)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Activity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(426, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cleaning Section"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(426, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tweaking Section"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(55, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Scan a file"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(178, 419)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(117, 20)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "_-_File Scanner + _-_"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(175, 401)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Log"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(426, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Security Section"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(426, 559)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Health Section"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(169, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 22)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Fetch Database Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(222, 230)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 68)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cyper_proj.My.Resources.Resources.scanner
        Me.PictureBox1.Location = New System.Drawing.Point(55, 382)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 68)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'FreshBtn
        '
        Me.FreshBtn.Image = Global.Cyper_proj.My.Resources.Resources.fresh
        Me.FreshBtn.Location = New System.Drawing.Point(55, 516)
        Me.FreshBtn.Name = "FreshBtn"
        Me.FreshBtn.Size = New System.Drawing.Size(69, 68)
        Me.FreshBtn.TabIndex = 7
        Me.FreshBtn.TabStop = False
        '
        'SBootBtn
        '
        Me.SBootBtn.Image = Global.Cyper_proj.My.Resources.Resources.boot
        Me.SBootBtn.Location = New System.Drawing.Point(55, 230)
        Me.SBootBtn.Name = "SBootBtn"
        Me.SBootBtn.Size = New System.Drawing.Size(69, 68)
        Me.SBootBtn.TabIndex = 6
        Me.SBootBtn.TabStop = False
        '
        'CDiskBtn
        '
        Me.CDiskBtn.Image = Global.Cyper_proj.My.Resources.Resources.disk
        Me.CDiskBtn.Location = New System.Drawing.Point(226, 66)
        Me.CDiskBtn.Name = "CDiskBtn"
        Me.CDiskBtn.Size = New System.Drawing.Size(69, 68)
        Me.CDiskBtn.TabIndex = 5
        Me.CDiskBtn.TabStop = False
        '
        'TempCleanBtn
        '
        Me.TempCleanBtn.Image = Global.Cyper_proj.My.Resources.Resources._1click
        Me.TempCleanBtn.Location = New System.Drawing.Point(55, 66)
        Me.TempCleanBtn.Name = "TempCleanBtn"
        Me.TempCleanBtn.Size = New System.Drawing.Size(69, 68)
        Me.TempCleanBtn.TabIndex = 0
        Me.TempCleanBtn.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(205, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Disable Visual FX"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(668, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReinstallToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.AboutCyperToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ReinstallToolStripMenuItem
        '
        Me.ReinstallToolStripMenuItem.Name = "ReinstallToolStripMenuItem"
        Me.ReinstallToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReinstallToolStripMenuItem.Text = "Re-install "
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check For Updates"
        '
        'AboutCyperToolStripMenuItem
        '
        Me.AboutCyperToolStripMenuItem.Name = "AboutCyperToolStripMenuItem"
        Me.AboutCyperToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutCyperToolStripMenuItem.Text = "About Cyper..."
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(668, 765)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ActivityBar)
        Me.Controls.Add(Me.FreshBtn)
        Me.Controls.Add(Me.SBootBtn)
        Me.Controls.Add(Me.CDiskBtn)
        Me.Controls.Add(Me.CDiskLabel)
        Me.Controls.Add(Me.SBootLabel)
        Me.Controls.Add(Me.FreshLabel)
        Me.Controls.Add(Me.TempCleanLabel)
        Me.Controls.Add(Me.TempCleanBtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.Text = "Cyper"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FreshBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBootBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDiskBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempCleanBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ScannerFDialog As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReinstallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutCyperToolStripMenuItem As ToolStripMenuItem
End Class
