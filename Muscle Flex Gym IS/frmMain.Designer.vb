<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picGSMstatus = New System.Windows.Forms.PictureBox()
        Me.btnPlayReminder = New System.Windows.Forms.PictureBox()
        Me.ContextMenuSound = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PlayEvery1HourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecifyPlayTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tscbTimer = New System.Windows.Forms.ToolStripComboBox()
        Me.SetPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopPlayingSoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlSubs = New System.Windows.Forms.Panel()
        Me.btnConvertMember = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvPackages = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubscriptionStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddTrainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddPack = New System.Windows.Forms.Button()
        Me.txtRFIDnum = New System.Windows.Forms.TextBox()
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.picClient = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewNonMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gsmSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.picGSMstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlayReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuSound.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnlSubs.SuspendLayout()
        Me.SubscriptionStrip.SuspendLayout()
        CType(Me.picClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.picGSMstatus)
        Me.Panel1.Controls.Add(Me.btnPlayReminder)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 98)
        Me.Panel1.TabIndex = 0
        '
        'picGSMstatus
        '
        Me.picGSMstatus.Location = New System.Drawing.Point(1276, 12)
        Me.picGSMstatus.Name = "picGSMstatus"
        Me.picGSMstatus.Size = New System.Drawing.Size(28, 28)
        Me.picGSMstatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGSMstatus.TabIndex = 4
        Me.picGSMstatus.TabStop = False
        Me.picGSMstatus.Visible = False
        '
        'btnPlayReminder
        '
        Me.btnPlayReminder.ContextMenuStrip = Me.ContextMenuSound
        Me.btnPlayReminder.Image = Global.Gym_IS.My.Resources.Resources.icons8_notification
        Me.btnPlayReminder.Location = New System.Drawing.Point(1238, 12)
        Me.btnPlayReminder.Name = "btnPlayReminder"
        Me.btnPlayReminder.Size = New System.Drawing.Size(32, 28)
        Me.btnPlayReminder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnPlayReminder.TabIndex = 3
        Me.btnPlayReminder.TabStop = False
        Me.btnPlayReminder.Visible = False
        '
        'ContextMenuSound
        '
        Me.ContextMenuSound.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayEvery1HourToolStripMenuItem, Me.SpecifyPlayTimeToolStripMenuItem, Me.StopPlayingSoundToolStripMenuItem})
        Me.ContextMenuSound.Name = "ContextMenuSound"
        Me.ContextMenuSound.Size = New System.Drawing.Size(210, 70)
        '
        'PlayEvery1HourToolStripMenuItem
        '
        Me.PlayEvery1HourToolStripMenuItem.Name = "PlayEvery1HourToolStripMenuItem"
        Me.PlayEvery1HourToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.PlayEvery1HourToolStripMenuItem.Text = "Play every Hour"
        '
        'SpecifyPlayTimeToolStripMenuItem
        '
        Me.SpecifyPlayTimeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscbTimer, Me.SetPlayToolStripMenuItem})
        Me.SpecifyPlayTimeToolStripMenuItem.Name = "SpecifyPlayTimeToolStripMenuItem"
        Me.SpecifyPlayTimeToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SpecifyPlayTimeToolStripMenuItem.Text = "Specify Play Time (Hours)"
        '
        'tscbTimer
        '
        Me.tscbTimer.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.tscbTimer.Name = "tscbTimer"
        Me.tscbTimer.Size = New System.Drawing.Size(75, 23)
        '
        'SetPlayToolStripMenuItem
        '
        Me.SetPlayToolStripMenuItem.Name = "SetPlayToolStripMenuItem"
        Me.SetPlayToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SetPlayToolStripMenuItem.Text = "Set && Play"
        '
        'StopPlayingSoundToolStripMenuItem
        '
        Me.StopPlayingSoundToolStripMenuItem.Name = "StopPlayingSoundToolStripMenuItem"
        Me.StopPlayingSoundToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.StopPlayingSoundToolStripMenuItem.Text = "Stop"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Tai Le", 25.0!)
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTime.Location = New System.Drawing.Point(123, 53)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(333, 42)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "TIME"
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUser.Location = New System.Drawing.Point(1027, 74)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(333, 21)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "User Name"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDate.Location = New System.Drawing.Point(127, 27)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(333, 21)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Gym_IS.My.Resources.Resources.icons8_x_mark
        Me.btnClose.Location = New System.Drawing.Point(1310, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 50)
        Me.btnClose.TabIndex = 1
        Me.btnClose.TabStop = False
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.Gym_IS.My.Resources.Resources.GGM
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 737)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 12)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Controls.Add(Me.pnlSubs)
        Me.Panel3.Controls.Add(Me.txtRFIDnum)
        Me.Panel3.Controls.Add(Me.lblClientID)
        Me.Panel3.Controls.Add(Me.lblClientName)
        Me.Panel3.Controls.Add(Me.picClient)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(285, 639)
        Me.Panel3.TabIndex = 2
        '
        'pnlSubs
        '
        Me.pnlSubs.Controls.Add(Me.btnConvertMember)
        Me.pnlSubs.Controls.Add(Me.Label1)
        Me.pnlSubs.Controls.Add(Me.lvPackages)
        Me.pnlSubs.Controls.Add(Me.btnAddPack)
        Me.pnlSubs.Location = New System.Drawing.Point(0, 401)
        Me.pnlSubs.Name = "pnlSubs"
        Me.pnlSubs.Size = New System.Drawing.Size(283, 194)
        Me.pnlSubs.TabIndex = 13
        Me.pnlSubs.Visible = False
        '
        'btnConvertMember
        '
        Me.btnConvertMember.Location = New System.Drawing.Point(30, 158)
        Me.btnConvertMember.Name = "btnConvertMember"
        Me.btnConvertMember.Size = New System.Drawing.Size(148, 29)
        Me.btnConvertMember.TabIndex = 5
        Me.btnConvertMember.Text = "Convert to member"
        Me.btnConvertMember.UseVisualStyleBackColor = True
        Me.btnConvertMember.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Active Subscriptions"
        '
        'lvPackages
        '
        Me.lvPackages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.lvPackages.ContextMenuStrip = Me.SubscriptionStrip
        Me.lvPackages.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPackages.FullRowSelect = True
        Me.lvPackages.GridLines = True
        Me.lvPackages.Location = New System.Drawing.Point(4, 27)
        Me.lvPackages.Name = "lvPackages"
        Me.lvPackages.Size = New System.Drawing.Size(276, 125)
        Me.lvPackages.TabIndex = 12
        Me.lvPackages.UseCompatibleStateImageBehavior = False
        Me.lvPackages.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Subscription"
        Me.ColumnHeader2.Width = 174
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Expiry Date"
        Me.ColumnHeader4.Width = 94
        '
        'SubscriptionStrip
        '
        Me.SubscriptionStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTrainerToolStripMenuItem})
        Me.SubscriptionStrip.Name = "SubscriptionStrip"
        Me.SubscriptionStrip.Size = New System.Drawing.Size(148, 26)
        '
        'AddTrainerToolStripMenuItem
        '
        Me.AddTrainerToolStripMenuItem.Name = "AddTrainerToolStripMenuItem"
        Me.AddTrainerToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AddTrainerToolStripMenuItem.Text = "Assign Trainer"
        '
        'btnAddPack
        '
        Me.btnAddPack.Location = New System.Drawing.Point(184, 158)
        Me.btnAddPack.Name = "btnAddPack"
        Me.btnAddPack.Size = New System.Drawing.Size(96, 29)
        Me.btnAddPack.TabIndex = 5
        Me.btnAddPack.Text = "Add..."
        Me.btnAddPack.UseVisualStyleBackColor = True
        '
        'txtRFIDnum
        '
        Me.txtRFIDnum.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtRFIDnum.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFIDnum.Location = New System.Drawing.Point(0, 0)
        Me.txtRFIDnum.Name = "txtRFIDnum"
        Me.txtRFIDnum.Size = New System.Drawing.Size(285, 41)
        Me.txtRFIDnum.TabIndex = 5
        '
        'lblClientID
        '
        Me.lblClientID.AutoSize = True
        Me.lblClientID.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!)
        Me.lblClientID.ForeColor = System.Drawing.Color.Black
        Me.lblClientID.Location = New System.Drawing.Point(9, 362)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(0, 25)
        Me.lblClientID.TabIndex = 9
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!)
        Me.lblClientName.ForeColor = System.Drawing.Color.Black
        Me.lblClientName.Location = New System.Drawing.Point(9, 330)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(0, 25)
        Me.lblClientName.TabIndex = 9
        '
        'picClient
        '
        Me.picClient.Location = New System.Drawing.Point(30, 56)
        Me.picClient.Name = "picClient"
        Me.picClient.Size = New System.Drawing.Size(233, 263)
        Me.picClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClient.TabIndex = 8
        Me.picClient.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonitoringToolStripMenuItem, Me.ClientsToolStripMenuItem, Me.PackagesToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LockerToolStripMenuItem, Me.TrainerToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(285, 98)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1081, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MonitoringToolStripMenuItem
        '
        Me.MonitoringToolStripMenuItem.Name = "MonitoringToolStripMenuItem"
        Me.MonitoringToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.MonitoringToolStripMenuItem.Text = "Monitoring"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMemberToolStripMenuItem, Me.NewNonMemberToolStripMenuItem})
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.ClientsToolStripMenuItem.Text = "Clients"
        '
        'NewMemberToolStripMenuItem
        '
        Me.NewMemberToolStripMenuItem.Name = "NewMemberToolStripMenuItem"
        Me.NewMemberToolStripMenuItem.Size = New System.Drawing.Size(202, 24)
        Me.NewMemberToolStripMenuItem.Text = "New Member"
        '
        'NewNonMemberToolStripMenuItem
        '
        Me.NewNonMemberToolStripMenuItem.Name = "NewNonMemberToolStripMenuItem"
        Me.NewNonMemberToolStripMenuItem.Size = New System.Drawing.Size(202, 24)
        Me.NewNonMemberToolStripMenuItem.Text = "New Non-Member"
        '
        'PackagesToolStripMenuItem
        '
        Me.PackagesToolStripMenuItem.Name = "PackagesToolStripMenuItem"
        Me.PackagesToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.PackagesToolStripMenuItem.Text = "Packages"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'LockerToolStripMenuItem
        '
        Me.LockerToolStripMenuItem.Name = "LockerToolStripMenuItem"
        Me.LockerToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.LockerToolStripMenuItem.Text = "Locker"
        Me.LockerToolStripMenuItem.Visible = False
        '
        'TrainerToolStripMenuItem
        '
        Me.TrainerToolStripMenuItem.Name = "TrainerToolStripMenuItem"
        Me.TrainerToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.TrainerToolStripMenuItem.Text = "Trainer"
        Me.TrainerToolStripMenuItem.Visible = False
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutApplicationToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutApplicationToolStripMenuItem
        '
        Me.AboutApplicationToolStripMenuItem.Name = "AboutApplicationToolStripMenuItem"
        Me.AboutApplicationToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.AboutApplicationToolStripMenuItem.Text = "About Application"
        '
        'gsmSerialPort
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "METRO MUSCLES GYM"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picGSMstatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlayReminder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuSound.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlSubs.ResumeLayout(False)
        Me.pnlSubs.PerformLayout()
        Me.SubscriptionStrip.ResumeLayout(False)
        CType(Me.picClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PackagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblClientID As System.Windows.Forms.Label
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents picClient As System.Windows.Forms.PictureBox
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gsmSerialPort As System.IO.Ports.SerialPort
    Friend WithEvents TrainerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuSound As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PlayEvery1HourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpecifyPlayTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tscbTimer As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents StopPlayingSoundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetPlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewNonMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtRFIDnum As System.Windows.Forms.TextBox
    Friend WithEvents picGSMstatus As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlayReminder As System.Windows.Forms.PictureBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents btnAddPack As System.Windows.Forms.Button
    Friend WithEvents lvPackages As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlSubs As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SubscriptionStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddTrainerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnConvertMember As System.Windows.Forms.Button

End Class
