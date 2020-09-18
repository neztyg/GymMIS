<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientCheckins
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalCheckins = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpSelector = New System.Windows.Forms.DateTimePicker()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextStripMonthly = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextStripYearly = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewClientDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateFingerprintIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterAsMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenewMembershipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRegistrationFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvCheckedinClients = New System.Windows.Forms.ListView()
        Me.cl1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextStripCheckins = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignRFIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextStripMonthly.SuspendLayout()
        Me.ContextStripYearly.SuspendLayout()
        Me.ContextStripCheckins.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblTotalCheckins)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 521)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(962, 25)
        Me.Panel2.TabIndex = 3
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
        'lblTotalCheckins
        '
        Me.lblTotalCheckins.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCheckins.ForeColor = System.Drawing.Color.Black
        Me.lblTotalCheckins.Location = New System.Drawing.Point(402, 3)
        Me.lblTotalCheckins.Name = "lblTotalCheckins"
        Me.lblTotalCheckins.Size = New System.Drawing.Size(160, 19)
        Me.lblTotalCheckins.TabIndex = 0
        Me.lblTotalCheckins.Text = "TOTAL CHECK-INS:"
        Me.lblTotalCheckins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpSelector)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 50)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CLIENTS ATTENDANCE"
        '
        'dtpSelector
        '
        Me.dtpSelector.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSelector.Location = New System.Drawing.Point(360, 12)
        Me.dtpSelector.Name = "dtpSelector"
        Me.dtpSelector.Size = New System.Drawing.Size(288, 26)
        Me.dtpSelector.TabIndex = 15
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.LightGray
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.Gym_IS.My.Resources.Resources.icons8_print_xsm
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(654, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(170, 40)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "PRINT ATTENDANCE"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gym_IS.My.Resources.Resources.icons8_female_leader
        Me.PictureBox1.Location = New System.Drawing.Point(4, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
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
        Me.ContextStripYearly.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewClientDetailsToolStripMenuItem, Me.UpdateFingerprintIDToolStripMenuItem, Me.RegisterAsMemberToolStripMenuItem, Me.RenewMembershipToolStripMenuItem, Me.PrintRegistrationFormToolStripMenuItem, Me.DeleteClientToolStripMenuItem})
        Me.ContextStripYearly.Name = "ContextMenuStrip1"
        Me.ContextStripYearly.Size = New System.Drawing.Size(197, 136)
        '
        'ViewClientDetailsToolStripMenuItem
        '
        Me.ViewClientDetailsToolStripMenuItem.Name = "ViewClientDetailsToolStripMenuItem"
        Me.ViewClientDetailsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ViewClientDetailsToolStripMenuItem.Text = "View Client Details"
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
        '
        'RenewMembershipToolStripMenuItem
        '
        Me.RenewMembershipToolStripMenuItem.Name = "RenewMembershipToolStripMenuItem"
        Me.RenewMembershipToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.RenewMembershipToolStripMenuItem.Text = "Renew Membership"
        '
        'PrintRegistrationFormToolStripMenuItem
        '
        Me.PrintRegistrationFormToolStripMenuItem.Name = "PrintRegistrationFormToolStripMenuItem"
        Me.PrintRegistrationFormToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.PrintRegistrationFormToolStripMenuItem.Text = "Print Registration Form"
        '
        'DeleteClientToolStripMenuItem
        '
        Me.DeleteClientToolStripMenuItem.Name = "DeleteClientToolStripMenuItem"
        Me.DeleteClientToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DeleteClientToolStripMenuItem.Text = "Delete Client"
        '
        'lvCheckedinClients
        '
        Me.lvCheckedinClients.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cl1, Me.xx, Me.cl2, Me.cl3, Me.cl4, Me.cl5, Me.cl6})
        Me.lvCheckedinClients.ContextMenuStrip = Me.ContextStripCheckins
        Me.lvCheckedinClients.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCheckedinClients.FullRowSelect = True
        Me.lvCheckedinClients.GridLines = True
        Me.lvCheckedinClients.Location = New System.Drawing.Point(12, 83)
        Me.lvCheckedinClients.MultiSelect = False
        Me.lvCheckedinClients.Name = "lvCheckedinClients"
        Me.lvCheckedinClients.Size = New System.Drawing.Size(938, 424)
        Me.lvCheckedinClients.TabIndex = 4
        Me.lvCheckedinClients.UseCompatibleStateImageBehavior = False
        Me.lvCheckedinClients.View = System.Windows.Forms.View.Details
        '
        'cl1
        '
        Me.cl1.Text = "ID"
        Me.cl1.Width = 0
        '
        'xx
        '
        Me.xx.Text = ""
        Me.xx.Width = 27
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
        Me.cl4.Width = 63
        '
        'cl5
        '
        Me.cl5.Text = "Time-in"
        Me.cl5.Width = 69
        '
        'cl6
        '
        Me.cl6.Text = "Time-out"
        Me.cl6.Width = 65
        '
        'ContextStripCheckins
        '
        Me.ContextStripCheckins.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckoutToolStripMenuItem, Me.AssignRFIDToolStripMenuItem})
        Me.ContextStripCheckins.Name = "ContextStripCheckins"
        Me.ContextStripCheckins.Size = New System.Drawing.Size(137, 48)
        '
        'CheckoutToolStripMenuItem
        '
        Me.CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        Me.CheckoutToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.CheckoutToolStripMenuItem.Text = "Checkout"
        '
        'AssignRFIDToolStripMenuItem
        '
        Me.AssignRFIDToolStripMenuItem.Name = "AssignRFIDToolStripMenuItem"
        Me.AssignRFIDToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AssignRFIDToolStripMenuItem.Text = "Assign RFID"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(63, 56)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(418, 24)
        Me.txtSearch.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search"
        '
        'frmClientCheckins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(962, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lvCheckedinClients)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientCheckins"
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
        Me.ContextStripCheckins.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextStripYearly As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PrintRegistrationFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewClientDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterAsMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvCheckedinClients As System.Windows.Forms.ListView
    Friend WithEvents cl1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cl2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cl3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cl4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpSelector As System.Windows.Forms.DateTimePicker
    Friend WithEvents cl5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cl6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents UpdateFingerprintIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextStripMonthly As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RenewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextStripCheckins As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CheckoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenewMembershipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents xx As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalCheckins As System.Windows.Forms.Label
    Friend WithEvents DeleteClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AssignRFIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
