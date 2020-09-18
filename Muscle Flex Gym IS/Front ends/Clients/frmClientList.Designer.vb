<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientList
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lvTransacs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextStripClient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewClientDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterRFIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateFingerprintIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterAsMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenewMembershipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRegistrationFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignTrainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvCheckedinClients = New System.Windows.Forms.ListView()
        Me.cl1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.dtpSelector = New System.Windows.Forms.DateTimePicker()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextStripClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1117, 50)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Gym_IS.My.Resources.Resources.icons8_female_leader
        Me.PictureBox2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(58, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MONITORING"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(594, 57)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(441, 30)
        Me.txtSearch.TabIndex = 6
        Me.txtSearch.Text = "Search here (Last name, First name)"
        '
        'lvTransacs
        '
        Me.lvTransacs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvTransacs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvTransacs.ContextMenuStrip = Me.ContextStripClient
        Me.lvTransacs.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!)
        Me.lvTransacs.FullRowSelect = True
        Me.lvTransacs.GridLines = True
        Me.lvTransacs.Location = New System.Drawing.Point(405, 91)
        Me.lvTransacs.MultiSelect = False
        Me.lvTransacs.Name = "lvTransacs"
        Me.lvTransacs.Size = New System.Drawing.Size(700, 418)
        Me.lvTransacs.TabIndex = 0
        Me.lvTransacs.UseCompatibleStateImageBehavior = False
        Me.lvTransacs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Client Name"
        Me.ColumnHeader2.Width = 301
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Subscription"
        Me.ColumnHeader3.Width = 138
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 91
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Trainer"
        Me.ColumnHeader5.Width = 154
        '
        'ContextStripClient
        '
        Me.ContextStripClient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewClientDetailsToolStripMenuItem, Me.RegisterRFIDToolStripMenuItem, Me.UpdateFingerprintIDToolStripMenuItem, Me.RegisterAsMemberToolStripMenuItem, Me.RenewMembershipToolStripMenuItem, Me.PrintRegistrationFormToolStripMenuItem, Me.DeleteClientToolStripMenuItem, Me.UpdateCardToolStripMenuItem, Me.AssignTrainerToolStripMenuItem})
        Me.ContextStripClient.Name = "ContextMenuStrip1"
        Me.ContextStripClient.Size = New System.Drawing.Size(197, 202)
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
        Me.UpdateFingerprintIDToolStripMenuItem.Visible = False
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
        'UpdateCardToolStripMenuItem
        '
        Me.UpdateCardToolStripMenuItem.Name = "UpdateCardToolStripMenuItem"
        Me.UpdateCardToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.UpdateCardToolStripMenuItem.Text = "Update Card"
        '
        'AssignTrainerToolStripMenuItem
        '
        Me.AssignTrainerToolStripMenuItem.Name = "AssignTrainerToolStripMenuItem"
        Me.AssignTrainerToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AssignTrainerToolStripMenuItem.Text = "Assign Trainer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(400, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TRANSACTION LIST"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!)
        Me.Label3.Location = New System.Drawing.Point(10, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ATTENDANCE"
        '
        'lvCheckedinClients
        '
        Me.lvCheckedinClients.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvCheckedinClients.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cl1, Me.cl2, Me.cl5})
        Me.lvCheckedinClients.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCheckedinClients.FullRowSelect = True
        Me.lvCheckedinClients.GridLines = True
        Me.lvCheckedinClients.Location = New System.Drawing.Point(14, 91)
        Me.lvCheckedinClients.MultiSelect = False
        Me.lvCheckedinClients.Name = "lvCheckedinClients"
        Me.lvCheckedinClients.Size = New System.Drawing.Size(372, 455)
        Me.lvCheckedinClients.TabIndex = 8
        Me.lvCheckedinClients.UseCompatibleStateImageBehavior = False
        Me.lvCheckedinClients.View = System.Windows.Forms.View.Details
        '
        'cl1
        '
        Me.cl1.Text = "ID"
        Me.cl1.Width = 0
        '
        'cl2
        '
        Me.cl2.Text = "Client Name"
        Me.cl2.Width = 259
        '
        'cl5
        '
        Me.cl5.Text = "Time-in"
        Me.cl5.Width = 84
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 552)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1117, 19)
        Me.Panel2.TabIndex = 9
        '
        'lblTotalSales
        '
        Me.lblTotalSales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalSales.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!)
        Me.lblTotalSales.Location = New System.Drawing.Point(527, 512)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(412, 34)
        Me.lblTotalSales.TabIndex = 10
        Me.lblTotalSales.Text = "TOTAL SALES:"
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.Location = New System.Drawing.Point(962, 512)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(131, 18)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Show Trainers Share"
        Me.LinkLabel1.Visible = False
        '
        'dtpSelector
        '
        Me.dtpSelector.Location = New System.Drawing.Point(142, 58)
        Me.dtpSelector.Name = "dtpSelector"
        Me.dtpSelector.Size = New System.Drawing.Size(244, 24)
        Me.dtpSelector.TabIndex = 16
        '
        'btnClearSearch
        '
        Me.btnClearSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearSearch.Location = New System.Drawing.Point(1041, 56)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(64, 31)
        Me.btnClearSearch.TabIndex = 17
        Me.btnClearSearch.Text = "CLEAR"
        Me.btnClearSearch.UseVisualStyleBackColor = True
        '
        'frmClientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1117, 571)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClearSearch)
        Me.Controls.Add(Me.dtpSelector)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lvCheckedinClients)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lvTransacs)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextStripClient.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvTransacs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvCheckedinClients As System.Windows.Forms.ListView
    Friend WithEvents cl1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cl2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cl5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalSales As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents dtpSelector As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextStripClient As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewClientDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterRFIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateFingerprintIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterAsMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenewMembershipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintRegistrationFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateCardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssignTrainerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClearSearch As System.Windows.Forms.Button
End Class
