<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitoringList
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalCheckins = New System.Windows.Forms.Label()
        Me.lblTotalMembers = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lvMonthlyMonitor = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextStripMonthly = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextStripYearly = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewClientDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterRFIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateFingerprintIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterAsMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenewMembershipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRegistrationFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpSelector = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvCheckedinClients = New System.Windows.Forms.ListView()
        Me.cl1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextStripCheckins = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddLockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvMembers = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkShowAllClients = New System.Windows.Forms.CheckBox()
        Me.chkNeedsRenew = New System.Windows.Forms.CheckBox()
        Me.chkShowExpired = New System.Windows.Forms.CheckBox()
        Me.txtSearchClient = New System.Windows.Forms.TextBox()
        Me.btnPrintSubsforRenew = New System.Windows.Forms.Button()
        Me.txtSearchMonthly = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextStripMonthly.SuspendLayout()
        Me.ContextStripYearly.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextStripCheckins.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblTotalCheckins)
        Me.Panel2.Controls.Add(Me.lblTotalMembers)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 590)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1117, 25)
        Me.Panel2.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkViolet
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(697, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "NO PICTURE AND FINGERPRINT"
        Me.Label6.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(135, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "EXPIRED MEMBERSHIP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Firebrick
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(578, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "NO FINGERPRINT"
        Me.Label4.Visible = False
        '
        'lblTotalCheckins
        '
        Me.lblTotalCheckins.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCheckins.ForeColor = System.Drawing.Color.Black
        Me.lblTotalCheckins.Location = New System.Drawing.Point(289, 2)
        Me.lblTotalCheckins.Name = "lblTotalCheckins"
        Me.lblTotalCheckins.Size = New System.Drawing.Size(196, 19)
        Me.lblTotalCheckins.TabIndex = 0
        Me.lblTotalCheckins.Text = "TOTAL CHECK-INS:"
        Me.lblTotalCheckins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalMembers
        '
        Me.lblTotalMembers.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMembers.ForeColor = System.Drawing.Color.Black
        Me.lblTotalMembers.Location = New System.Drawing.Point(878, 4)
        Me.lblTotalMembers.Name = "lblTotalMembers"
        Me.lblTotalMembers.Size = New System.Drawing.Size(184, 19)
        Me.lblTotalMembers.TabIndex = 0
        Me.lblTotalMembers.Text = "TOTAL MEMBERS:"
        Me.lblTotalMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "EXPIRED MONTHLY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gold
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(491, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "NO PICTURE"
        Me.Label2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1117, 50)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CLIENT MONITORING"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gym_IS.My.Resources.Resources.icons8_female_leader
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lvMonthlyMonitor
        '
        Me.lvMonthlyMonitor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvMonthlyMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvMonthlyMonitor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvMonthlyMonitor.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMonthlyMonitor.FullRowSelect = True
        Me.lvMonthlyMonitor.GridLines = True
        Me.lvMonthlyMonitor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvMonthlyMonitor.Location = New System.Drawing.Point(505, 94)
        Me.lvMonthlyMonitor.MultiSelect = False
        Me.lvMonthlyMonitor.Name = "lvMonthlyMonitor"
        Me.lvMonthlyMonitor.Size = New System.Drawing.Size(599, 238)
        Me.lvMonthlyMonitor.TabIndex = 9
        Me.lvMonthlyMonitor.UseCompatibleStateImageBehavior = False
        Me.lvMonthlyMonitor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Transaction ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Client Name"
        Me.ColumnHeader2.Width = 240
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Active Package"
        Me.ColumnHeader3.Width = 129
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Expiration"
        Me.ColumnHeader4.Width = 126
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Days Remain"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 91
        '
        'ContextStripMonthly
        '
        Me.ContextStripMonthly.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenewToolStripMenuItem})
        Me.ContextStripMonthly.Name = "ContextMenuStrip2"
        Me.ContextStripMonthly.Size = New System.Drawing.Size(158, 26)
        '
        'RenewToolStripMenuItem
        '
        Me.RenewToolStripMenuItem.Name = "RenewToolStripMenuItem"
        Me.RenewToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.RenewToolStripMenuItem.Text = "Renew Monthly"
        '
        'ContextStripYearly
        '
        Me.ContextStripYearly.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewClientDetailsToolStripMenuItem, Me.RegisterRFIDToolStripMenuItem, Me.UpdateFingerprintIDToolStripMenuItem, Me.RegisterAsMemberToolStripMenuItem, Me.RenewMembershipToolStripMenuItem, Me.PrintRegistrationFormToolStripMenuItem, Me.DeleteClientToolStripMenuItem})
        Me.ContextStripYearly.Name = "ContextMenuStrip1"
        Me.ContextStripYearly.Size = New System.Drawing.Size(197, 180)
        '
        'ViewClientDetailsToolStripMenuItem
        '
        Me.ViewClientDetailsToolStripMenuItem.Name = "ViewClientDetailsToolStripMenuItem"
        Me.ViewClientDetailsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ViewClientDetailsToolStripMenuItem.Text = "View Client Details"
        '
        'RegisterRFIDToolStripMenuItem
        '
        Me.RegisterRFIDToolStripMenuItem.Name = "RegisterRFIDToolStripMenuItem"
        Me.RegisterRFIDToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.RegisterRFIDToolStripMenuItem.Text = "Update RFID"
        '
        'UpdateFingerprintIDToolStripMenuItem
        '
        Me.UpdateFingerprintIDToolStripMenuItem.Name = "UpdateFingerprintIDToolStripMenuItem"
        Me.UpdateFingerprintIDToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.UpdateFingerprintIDToolStripMenuItem.Text = "Update Fingerprint ID"
        '
        'RegisterAsMemberToolStripMenuItem
        '
        Me.RegisterAsMemberToolStripMenuItem.Name = "RegisterAsMemberToolStripMenuItem"
        Me.RegisterAsMemberToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.RegisterAsMemberToolStripMenuItem.Text = "Register as Member"
        Me.RegisterAsMemberToolStripMenuItem.Visible = False
        '
        'RenewMembershipToolStripMenuItem
        '
        Me.RenewMembershipToolStripMenuItem.Name = "RenewMembershipToolStripMenuItem"
        Me.RenewMembershipToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.RenewMembershipToolStripMenuItem.Text = "Renew Membership"
        Me.RenewMembershipToolStripMenuItem.Visible = False
        '
        'PrintRegistrationFormToolStripMenuItem
        '
        Me.PrintRegistrationFormToolStripMenuItem.Name = "PrintRegistrationFormToolStripMenuItem"
        Me.PrintRegistrationFormToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.PrintRegistrationFormToolStripMenuItem.Text = "Print Registration Form"
        Me.PrintRegistrationFormToolStripMenuItem.Visible = False
        '
        'DeleteClientToolStripMenuItem
        '
        Me.DeleteClientToolStripMenuItem.Name = "DeleteClientToolStripMenuItem"
        Me.DeleteClientToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DeleteClientToolStripMenuItem.Text = "Delete Client"
        Me.DeleteClientToolStripMenuItem.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Controls.Add(Me.dtpSelector)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(495, 540)
        Me.Panel3.TabIndex = 12
        '
        'dtpSelector
        '
        Me.dtpSelector.Location = New System.Drawing.Point(13, 10)
        Me.dtpSelector.Name = "dtpSelector"
        Me.dtpSelector.Size = New System.Drawing.Size(244, 24)
        Me.dtpSelector.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lvCheckedinClients)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 490)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CHECKED-IN CLIENTS"
        '
        'lvCheckedinClients
        '
        Me.lvCheckedinClients.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cl1, Me.cl7, Me.cl2, Me.cl3, Me.cl4, Me.cl5, Me.cl6})
        Me.lvCheckedinClients.ContextMenuStrip = Me.ContextStripCheckins
        Me.lvCheckedinClients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvCheckedinClients.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCheckedinClients.FullRowSelect = True
        Me.lvCheckedinClients.GridLines = True
        Me.lvCheckedinClients.Location = New System.Drawing.Point(3, 20)
        Me.lvCheckedinClients.MultiSelect = False
        Me.lvCheckedinClients.Name = "lvCheckedinClients"
        Me.lvCheckedinClients.Size = New System.Drawing.Size(489, 467)
        Me.lvCheckedinClients.TabIndex = 4
        Me.lvCheckedinClients.UseCompatibleStateImageBehavior = False
        Me.lvCheckedinClients.View = System.Windows.Forms.View.Details
        '
        'cl1
        '
        Me.cl1.Text = "ID"
        Me.cl1.Width = 0
        '
        'cl7
        '
        Me.cl7.Text = ""
        Me.cl7.Width = 27
        '
        'cl2
        '
        Me.cl2.Text = "Client Name"
        Me.cl2.Width = 191
        '
        'cl3
        '
        Me.cl3.Text = "Locker"
        Me.cl3.Width = 50
        '
        'cl4
        '
        Me.cl4.Text = "Member"
        Me.cl4.Width = 65
        '
        'cl5
        '
        Me.cl5.Text = "Time-in"
        Me.cl5.Width = 69
        '
        'cl6
        '
        Me.cl6.Text = "Time-out"
        Me.cl6.Width = 66
        '
        'ContextStripCheckins
        '
        Me.ContextStripCheckins.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckoutToolStripMenuItem, Me.AddLockerToolStripMenuItem})
        Me.ContextStripCheckins.Name = "ContextStripCheckins"
        Me.ContextStripCheckins.Size = New System.Drawing.Size(148, 48)
        '
        'CheckoutToolStripMenuItem
        '
        Me.CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        Me.CheckoutToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CheckoutToolStripMenuItem.Text = "Checkout"
        '
        'AddLockerToolStripMenuItem
        '
        Me.AddLockerToolStripMenuItem.Name = "AddLockerToolStripMenuItem"
        Me.AddLockerToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AddLockerToolStripMenuItem.Text = "Assign Locker"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.LightGray
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.Gym_IS.My.Resources.Resources.icons8_print_xsm
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(263, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(170, 40)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "PRINT ATTENDANCE"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(501, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "MONTHLY MONITOR"
        '
        'lvMembers
        '
        Me.lvMembers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader17, Me.ColumnHeader13, Me.ColumnHeader15, Me.ColumnHeader14, Me.ColumnHeader16})
        Me.lvMembers.ContextMenuStrip = Me.ContextStripYearly
        Me.lvMembers.FullRowSelect = True
        Me.lvMembers.GridLines = True
        Me.lvMembers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvMembers.Location = New System.Drawing.Point(505, 364)
        Me.lvMembers.MultiSelect = False
        Me.lvMembers.Name = "lvMembers"
        Me.lvMembers.Size = New System.Drawing.Size(599, 220)
        Me.lvMembers.TabIndex = 9
        Me.lvMembers.UseCompatibleStateImageBehavior = False
        Me.lvMembers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Client ID"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = ""
        Me.ColumnHeader17.Width = 37
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Client Name"
        Me.ColumnHeader13.Width = 222
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Member Since"
        Me.ColumnHeader15.Width = 114
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Member Until"
        Me.ColumnHeader14.Width = 111
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Days Remain"
        Me.ColumnHeader16.Width = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(501, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "MEMBERSHIP MONITOR"
        '
        'chkShowAllClients
        '
        Me.chkShowAllClients.AutoSize = True
        Me.chkShowAllClients.Location = New System.Drawing.Point(851, 341)
        Me.chkShowAllClients.Name = "chkShowAllClients"
        Me.chkShowAllClients.Size = New System.Drawing.Size(124, 22)
        Me.chkShowAllClients.TabIndex = 13
        Me.chkShowAllClients.Text = "Show All Clients"
        Me.chkShowAllClients.UseVisualStyleBackColor = True
        '
        'chkNeedsRenew
        '
        Me.chkNeedsRenew.AutoSize = True
        Me.chkNeedsRenew.Location = New System.Drawing.Point(972, 341)
        Me.chkNeedsRenew.Name = "chkNeedsRenew"
        Me.chkNeedsRenew.Size = New System.Drawing.Size(108, 22)
        Me.chkNeedsRenew.TabIndex = 13
        Me.chkNeedsRenew.Text = "Show Expired"
        Me.chkNeedsRenew.UseVisualStyleBackColor = True
        '
        'chkShowExpired
        '
        Me.chkShowExpired.AutoSize = True
        Me.chkShowExpired.Location = New System.Drawing.Point(505, 72)
        Me.chkShowExpired.Name = "chkShowExpired"
        Me.chkShowExpired.Size = New System.Drawing.Size(108, 22)
        Me.chkShowExpired.TabIndex = 17
        Me.chkShowExpired.Text = "Show Expired"
        Me.chkShowExpired.UseVisualStyleBackColor = True
        '
        'txtSearchClient
        '
        Me.txtSearchClient.Location = New System.Drawing.Point(689, 337)
        Me.txtSearchClient.Name = "txtSearchClient"
        Me.txtSearchClient.Size = New System.Drawing.Size(156, 24)
        Me.txtSearchClient.TabIndex = 18
        '
        'btnPrintSubsforRenew
        '
        Me.btnPrintSubsforRenew.BackColor = System.Drawing.Color.LightGray
        Me.btnPrintSubsforRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintSubsforRenew.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintSubsforRenew.Image = Global.Gym_IS.My.Resources.Resources.icons8_print_xsm
        Me.btnPrintSubsforRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintSubsforRenew.Location = New System.Drawing.Point(893, 58)
        Me.btnPrintSubsforRenew.Name = "btnPrintSubsforRenew"
        Me.btnPrintSubsforRenew.Size = New System.Drawing.Size(180, 32)
        Me.btnPrintSubsforRenew.TabIndex = 16
        Me.btnPrintSubsforRenew.Text = "PACKAGES FOR RENEW"
        Me.btnPrintSubsforRenew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrintSubsforRenew.UseVisualStyleBackColor = False
        Me.btnPrintSubsforRenew.Visible = False
        '
        'txtSearchMonthly
        '
        Me.txtSearchMonthly.Location = New System.Drawing.Point(666, 65)
        Me.txtSearchMonthly.Name = "txtSearchMonthly"
        Me.txtSearchMonthly.Size = New System.Drawing.Size(221, 24)
        Me.txtSearchMonthly.TabIndex = 19
        '
        'frmMonitoringList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1117, 615)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSearchMonthly)
        Me.Controls.Add(Me.txtSearchClient)
        Me.Controls.Add(Me.chkShowExpired)
        Me.Controls.Add(Me.btnPrintSubsforRenew)
        Me.Controls.Add(Me.chkNeedsRenew)
        Me.Controls.Add(Me.chkShowAllClients)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvMembers)
        Me.Controls.Add(Me.lvMonthlyMonitor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMonitoringList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "MONITOR"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextStripMonthly.ResumeLayout(False)
        Me.ContextStripYearly.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ContextStripCheckins.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvMonthlyMonitor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextStripYearly As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PrintRegistrationFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewClientDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RegisterAsMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvCheckedinClients As System.Windows.Forms.ListView
    Friend WithEvents cl1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cl2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cl3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cl4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpSelector As System.Windows.Forms.DateTimePicker
    Friend WithEvents cl5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cl6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvMembers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkShowAllClients As System.Windows.Forms.CheckBox
    Friend WithEvents chkNeedsRenew As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotalMembers As System.Windows.Forms.Label
    Friend WithEvents UpdateFingerprintIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrintSubsforRenew As System.Windows.Forms.Button
    Friend WithEvents chkShowExpired As System.Windows.Forms.CheckBox
    Friend WithEvents ContextStripMonthly As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RenewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSearchClient As System.Windows.Forms.TextBox
    Friend WithEvents ContextStripCheckins As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CheckoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenewMembershipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cl7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalCheckins As System.Windows.Forms.Label
    Friend WithEvents DeleteClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearchMonthly As System.Windows.Forms.TextBox
    Friend WithEvents RegisterRFIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddLockerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
