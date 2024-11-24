<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.imgDashboard = New System.Windows.Forms.PictureBox()
        Me.imgAccount = New System.Windows.Forms.PictureBox()
        Me.imgNotification = New System.Windows.Forms.PictureBox()
        Me.imgPrivacy = New System.Windows.Forms.PictureBox()
        Me.imgProtection = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.imgHelp = New System.Windows.Forms.PictureBox()
        Me.BtnMinimize = New System.Windows.Forms.PictureBox()
        Me.imgPref = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.MyButton2 = New Antivirusdemo.MyButton()
        Me.btnDashboard = New Antivirusdemo.MyButton()
        Me.btnNotification = New Antivirusdemo.MyButton()
        Me.btnprivacy = New Antivirusdemo.MyButton()
        Me.btnProtection = New Antivirusdemo.MyButton()
        Me.btnAccount = New Antivirusdemo.MyButton()
        Me.CtlDashboard1 = New Antivirusdemo.ctlDashboard()
        Me.CtlScanCenter1 = New Antivirusdemo.ctlScanCenter()
        Me.CtlPrivacy1 = New Antivirusdemo.ctlPrivacy()
        Me.CtlSystemPerformance1 = New Antivirusdemo.ctlSystemPerformance()
        Me.CtlAccount1 = New Antivirusdemo.ctlAccount()
        Me.Ctlpremium1 = New Antivirusdemo.ctlpremium()
        Me.CtlSubscription1 = New Antivirusdemo.ctlSubscription()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.imgDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNotification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPrivacy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgProtection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.imgHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnNotification)
        Me.Panel1.Controls.Add(Me.btnprivacy)
        Me.Panel1.Controls.Add(Me.btnProtection)
        Me.Panel1.Controls.Add(Me.btnAccount)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 689)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.imgDashboard)
        Me.Panel2.Controls.Add(Me.imgAccount)
        Me.Panel2.Controls.Add(Me.imgNotification)
        Me.Panel2.Controls.Add(Me.imgPrivacy)
        Me.Panel2.Controls.Add(Me.imgProtection)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(45, 691)
        Me.Panel2.TabIndex = 8
        '
        'imgDashboard
        '
        Me.imgDashboard.BackColor = System.Drawing.Color.Magenta
        Me.imgDashboard.Image = Global.Antivirusdemo.My.Resources.Resources.Dashboard1
        Me.imgDashboard.Location = New System.Drawing.Point(3, 212)
        Me.imgDashboard.Name = "imgDashboard"
        Me.imgDashboard.Size = New System.Drawing.Size(36, 39)
        Me.imgDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDashboard.TabIndex = 2
        Me.imgDashboard.TabStop = False
        '
        'imgAccount
        '
        Me.imgAccount.Image = Global.Antivirusdemo.My.Resources.Resources.Account
        Me.imgAccount.Location = New System.Drawing.Point(2, 647)
        Me.imgAccount.Name = "imgAccount"
        Me.imgAccount.Size = New System.Drawing.Size(42, 39)
        Me.imgAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgAccount.TabIndex = 5
        Me.imgAccount.TabStop = False
        '
        'imgNotification
        '
        Me.imgNotification.Image = Global.Antivirusdemo.My.Resources.Resources.Notification
        Me.imgNotification.Location = New System.Drawing.Point(3, 332)
        Me.imgNotification.Name = "imgNotification"
        Me.imgNotification.Size = New System.Drawing.Size(36, 39)
        Me.imgNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgNotification.TabIndex = 7
        Me.imgNotification.TabStop = False
        '
        'imgPrivacy
        '
        Me.imgPrivacy.Image = Global.Antivirusdemo.My.Resources.Resources.Privacy
        Me.imgPrivacy.Location = New System.Drawing.Point(3, 291)
        Me.imgPrivacy.Name = "imgPrivacy"
        Me.imgPrivacy.Size = New System.Drawing.Size(36, 39)
        Me.imgPrivacy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPrivacy.TabIndex = 6
        Me.imgPrivacy.TabStop = False
        '
        'imgProtection
        '
        Me.imgProtection.Image = Global.Antivirusdemo.My.Resources.Resources.Scansenter
        Me.imgProtection.Location = New System.Drawing.Point(3, 252)
        Me.imgProtection.Name = "imgProtection"
        Me.imgProtection.Size = New System.Drawing.Size(36, 39)
        Me.imgProtection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgProtection.TabIndex = 4
        Me.imgProtection.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Antivirusdemo.My.Resources.Resources.icon_2024_09_21_235543
        Me.PictureBox2.Location = New System.Drawing.Point(61, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(158, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.Purple
        Me.HeaderPanel.Controls.Add(Me.MyButton2)
        Me.HeaderPanel.Controls.Add(Me.imgHelp)
        Me.HeaderPanel.Controls.Add(Me.BtnMinimize)
        Me.HeaderPanel.Controls.Add(Me.imgPref)
        Me.HeaderPanel.Controls.Add(Me.BtnClose)
        Me.HeaderPanel.Controls.Add(Me.LblTitle)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(236, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(959, 42)
        Me.HeaderPanel.TabIndex = 1
        '
        'imgHelp
        '
        Me.imgHelp.Image = Global.Antivirusdemo.My.Resources.Resources.Help
        Me.imgHelp.Location = New System.Drawing.Point(838, 0)
        Me.imgHelp.Name = "imgHelp"
        Me.imgHelp.Size = New System.Drawing.Size(36, 39)
        Me.imgHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHelp.TabIndex = 7
        Me.imgHelp.TabStop = False
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Image = Global.Antivirusdemo.My.Resources.Resources.minimize
        Me.BtnMinimize.Location = New System.Drawing.Point(880, 0)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(36, 39)
        Me.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimize.TabIndex = 3
        Me.BtnMinimize.TabStop = False
        '
        'imgPref
        '
        Me.imgPref.Image = Global.Antivirusdemo.My.Resources.Resources.preference
        Me.imgPref.Location = New System.Drawing.Point(797, 0)
        Me.imgPref.Name = "imgPref"
        Me.imgPref.Size = New System.Drawing.Size(36, 39)
        Me.imgPref.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPref.TabIndex = 6
        Me.imgPref.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Image = Global.Antivirusdemo.My.Resources.Resources.Close
        Me.BtnClose.Location = New System.Drawing.Point(918, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(36, 39)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.TabStop = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.LblTitle.Location = New System.Drawing.Point(18, 4)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(249, 29)
        Me.LblTitle.TabIndex = 3
        Me.LblTitle.Text = "PC protector - demo"
        '
        'MainPanel
        '
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.HeaderPanel)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Controls.Add(Me.CtlDashboard1)
        Me.MainPanel.Controls.Add(Me.CtlScanCenter1)
        Me.MainPanel.Controls.Add(Me.CtlPrivacy1)
        Me.MainPanel.Controls.Add(Me.CtlSystemPerformance1)
        Me.MainPanel.Controls.Add(Me.CtlAccount1)
        Me.MainPanel.Controls.Add(Me.Ctlpremium1)
        Me.MainPanel.Controls.Add(Me.CtlSubscription1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1197, 691)
        Me.MainPanel.TabIndex = 2
        '
        'MyButton2
        '
        Me.MyButton2.BackColor = System.Drawing.Color.Purple
        Me.MyButton2.BottomColor = System.Drawing.Color.Magenta
        Me.MyButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MyButton2.Location = New System.Drawing.Point(626, 3)
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(165, 36)
        Me.MyButton2.TabIndex = 4
        Me.MyButton2.Text = "Go Premium"
        Me.MyButton2.TopColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MyButton2.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Purple
        Me.btnDashboard.BottomColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDashboard.Location = New System.Drawing.Point(45, 213)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(187, 39)
        Me.btnDashboard.TabIndex = 3
        Me.btnDashboard.Text = "DashBoard"
        Me.btnDashboard.TopColor = System.Drawing.Color.Magenta
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnNotification
        '
        Me.btnNotification.BackColor = System.Drawing.Color.Purple
        Me.btnNotification.BottomColor = System.Drawing.Color.Magenta
        Me.btnNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotification.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNotification.Location = New System.Drawing.Point(45, 334)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.Size = New System.Drawing.Size(191, 39)
        Me.btnNotification.TabIndex = 8
        Me.btnNotification.Text = "System Performance"
        Me.btnNotification.TopColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNotification.UseVisualStyleBackColor = False
        '
        'btnprivacy
        '
        Me.btnprivacy.BackColor = System.Drawing.Color.Purple
        Me.btnprivacy.BottomColor = System.Drawing.Color.Magenta
        Me.btnprivacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprivacy.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnprivacy.Location = New System.Drawing.Point(45, 294)
        Me.btnprivacy.Name = "btnprivacy"
        Me.btnprivacy.Size = New System.Drawing.Size(188, 39)
        Me.btnprivacy.TabIndex = 9
        Me.btnprivacy.Text = "Privacy"
        Me.btnprivacy.TopColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnprivacy.UseVisualStyleBackColor = False
        '
        'btnProtection
        '
        Me.btnProtection.BackColor = System.Drawing.Color.Purple
        Me.btnProtection.BottomColor = System.Drawing.Color.Magenta
        Me.btnProtection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProtection.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProtection.Location = New System.Drawing.Point(45, 253)
        Me.btnProtection.Name = "btnProtection"
        Me.btnProtection.Size = New System.Drawing.Size(188, 39)
        Me.btnProtection.TabIndex = 10
        Me.btnProtection.Text = "Scan Center"
        Me.btnProtection.TopColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProtection.UseVisualStyleBackColor = False
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.Color.Purple
        Me.btnAccount.BottomColor = System.Drawing.Color.Magenta
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAccount.Location = New System.Drawing.Point(45, 647)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(188, 39)
        Me.btnAccount.TabIndex = 7
        Me.btnAccount.Text = "My Account"
        Me.btnAccount.TopColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'CtlDashboard1
        '
        Me.CtlDashboard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CtlDashboard1.Location = New System.Drawing.Point(232, 42)
        Me.CtlDashboard1.Name = "CtlDashboard1"
        Me.CtlDashboard1.Size = New System.Drawing.Size(962, 652)
        Me.CtlDashboard1.TabIndex = 2
        '
        'CtlScanCenter1
        '
        Me.CtlScanCenter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CtlScanCenter1.Location = New System.Drawing.Point(236, 38)
        Me.CtlScanCenter1.Name = "CtlScanCenter1"
        Me.CtlScanCenter1.Size = New System.Drawing.Size(962, 652)
        Me.CtlScanCenter1.TabIndex = 3
        '
        'CtlPrivacy1
        '
        Me.CtlPrivacy1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CtlPrivacy1.Location = New System.Drawing.Point(236, 41)
        Me.CtlPrivacy1.Name = "CtlPrivacy1"
        Me.CtlPrivacy1.Size = New System.Drawing.Size(962, 652)
        Me.CtlPrivacy1.TabIndex = 4
        '
        'CtlSystemPerformance1
        '
        Me.CtlSystemPerformance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CtlSystemPerformance1.Location = New System.Drawing.Point(236, 39)
        Me.CtlSystemPerformance1.Name = "CtlSystemPerformance1"
        Me.CtlSystemPerformance1.Size = New System.Drawing.Size(962, 652)
        Me.CtlSystemPerformance1.TabIndex = 5
        '
        'CtlAccount1
        '
        Me.CtlAccount1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CtlAccount1.Location = New System.Drawing.Point(234, 40)
        Me.CtlAccount1.Name = "CtlAccount1"
        Me.CtlAccount1.Size = New System.Drawing.Size(962, 652)
        Me.CtlAccount1.TabIndex = 6
        '
        'Ctlpremium1
        '
        Me.Ctlpremium1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ctlpremium1.Location = New System.Drawing.Point(235, 40)
        Me.Ctlpremium1.Name = "Ctlpremium1"
        Me.Ctlpremium1.Size = New System.Drawing.Size(962, 652)
        Me.Ctlpremium1.TabIndex = 7
        '
        'CtlSubscription1
        '
        Me.CtlSubscription1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CtlSubscription1.Location = New System.Drawing.Point(-1, -1)
        Me.CtlSubscription1.Name = "CtlSubscription1"
        Me.CtlSubscription1.Size = New System.Drawing.Size(1197, 691)
        Me.CtlSubscription1.TabIndex = 8
        Me.CtlSubscription1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1197, 691)
        Me.Controls.Add(Me.MainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "PC Protecter"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.imgDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNotification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPrivacy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgProtection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.imgHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents imgAccount As PictureBox
    Friend WithEvents imgPref As PictureBox
    Friend WithEvents imgHelp As PictureBox
    Friend WithEvents imgDashboard As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnMinimize As PictureBox
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDashboard As MyButton
    Friend WithEvents MainPanel As Panel
    Friend WithEvents imgPrivacy As PictureBox
    Friend WithEvents imgProtection As PictureBox
    Friend WithEvents imgNotification As PictureBox
    Friend WithEvents btnNotification As MyButton
    Friend WithEvents btnprivacy As MyButton
    Friend WithEvents btnProtection As MyButton
    Friend WithEvents btnAccount As MyButton
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents CtlDashboard1 As ctlDashboard
    Friend WithEvents CtlScanCenter1 As ctlScanCenter
    Friend WithEvents CtlPrivacy1 As ctlPrivacy
    Friend WithEvents CtlSystemPerformance1 As ctlSystemPerformance
    Friend WithEvents CtlAccount1 As ctlAccount
    Friend WithEvents Ctlpremium1 As ctlpremium
    Friend WithEvents CtlSubscription1 As ctlSubscription
End Class
