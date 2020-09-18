<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientInfo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContactNum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBdate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGuardianName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtGuardianContact = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbTrainer = New System.Windows.Forms.ComboBox()
        Me.cbLockers = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.rbExpired = New System.Windows.Forms.RadioButton()
        Me.rbActive = New System.Windows.Forms.RadioButton()
        Me.lvPackages = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUpdateLocker = New System.Windows.Forms.Button()
        Me.btnMeasurement = New System.Windows.Forms.Button()
        Me.btnNewPackage = New System.Windows.Forms.Button()
        Me.btnEditFingerID = New System.Windows.Forms.Button()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtMedIssues = New System.Windows.Forms.TextBox()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtMoreInfo = New System.Windows.Forms.TextBox()
        Me.picClient = New System.Windows.Forms.PictureBox()
        Me.btnUpdateTrainer = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.picClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 590)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1062, 25)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 50)
        Me.Panel1.TabIndex = 2
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(58, 8)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(236, 29)
        Me.lblHeader.TabIndex = 5
        Me.lblHeader.Text = "CLIENT INFORMATION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gym_IS.My.Resources.Resources.icons8_fingerprint_scan
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Gym_IS.My.Resources.Resources.icons8_minimize_window_sm
        Me.btnClose.Location = New System.Drawing.Point(1012, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(44, 43)
        Me.btnClose.TabIndex = 1
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtClientID
        '
        Me.txtClientID.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtClientID.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!)
        Me.txtClientID.Location = New System.Drawing.Point(35, 264)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.ReadOnly = True
        Me.txtClientID.Size = New System.Drawing.Size(261, 41)
        Me.txtClientID.TabIndex = 5
        Me.txtClientID.Text = "1904563"
        Me.txtClientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtClientName
        '
        Me.txtClientName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientName.Location = New System.Drawing.Point(406, 22)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.ReadOnly = True
        Me.txtClientName.Size = New System.Drawing.Size(453, 27)
        Me.txtClientName.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(309, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CLIENT NAME"
        '
        'txtContactNum
        '
        Me.txtContactNum.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtContactNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNum.Location = New System.Drawing.Point(406, 56)
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.ReadOnly = True
        Me.txtContactNum.Size = New System.Drawing.Size(153, 27)
        Me.txtContactNum.TabIndex = 5
        Me.txtContactNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(309, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "MOBILE NO."
        '
        'txtBdate
        '
        Me.txtBdate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBdate.Location = New System.Drawing.Point(657, 56)
        Me.txtBdate.Name = "txtBdate"
        Me.txtBdate.ReadOnly = True
        Me.txtBdate.Size = New System.Drawing.Size(202, 27)
        Me.txtBdate.TabIndex = 5
        Me.txtBdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(573, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "BIRTHDATE"
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(406, 91)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(84, 27)
        Me.txtGender.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(309, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "GENDER"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(406, 127)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(453, 24)
        Me.txtAddress.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(309, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "ADDRESS"
        '
        'txtGuardianName
        '
        Me.txtGuardianName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianName.Location = New System.Drawing.Point(404, 182)
        Me.txtGuardianName.Name = "txtGuardianName"
        Me.txtGuardianName.ReadOnly = True
        Me.txtGuardianName.Size = New System.Drawing.Size(294, 27)
        Me.txtGuardianName.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(307, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "EMERGENCY CONTACT"
        '
        'txtGuardianContact
        '
        Me.txtGuardianContact.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtGuardianContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianContact.Location = New System.Drawing.Point(704, 182)
        Me.txtGuardianContact.Name = "txtGuardianContact"
        Me.txtGuardianContact.ReadOnly = True
        Me.txtGuardianContact.Size = New System.Drawing.Size(153, 27)
        Me.txtGuardianContact.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(701, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "CONTACT NUMBER"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.Controls.Add(Me.cbTrainer)
        Me.Panel3.Controls.Add(Me.cbLockers)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.btnUpdateLocker)
        Me.Panel3.Controls.Add(Me.btnMeasurement)
        Me.Panel3.Controls.Add(Me.btnNewPackage)
        Me.Panel3.Controls.Add(Me.btnEditFingerID)
        Me.Panel3.Controls.Add(Me.btnPrintReceipt)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtGuardianContact)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtGuardianName)
        Me.Panel3.Controls.Add(Me.txtWeight)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtMedIssues)
        Me.Panel3.Controls.Add(Me.txtBMI)
        Me.Panel3.Controls.Add(Me.txtHeight)
        Me.Panel3.Controls.Add(Me.txtMoreInfo)
        Me.Panel3.Controls.Add(Me.txtAddress)
        Me.Panel3.Controls.Add(Me.txtGender)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtBdate)
        Me.Panel3.Controls.Add(Me.txtContactNum)
        Me.Panel3.Controls.Add(Me.txtClientName)
        Me.Panel3.Controls.Add(Me.picClient)
        Me.Panel3.Controls.Add(Me.txtClientID)
        Me.Panel3.Controls.Add(Me.btnUpdateTrainer)
        Me.Panel3.Location = New System.Drawing.Point(78, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(895, 528)
        Me.Panel3.TabIndex = 9
        '
        'cbTrainer
        '
        Me.cbTrainer.DropDownHeight = 150
        Me.cbTrainer.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTrainer.FormattingEnabled = True
        Me.cbTrainer.IntegralHeight = False
        Me.cbTrainer.Location = New System.Drawing.Point(404, 259)
        Me.cbTrainer.Name = "cbTrainer"
        Me.cbTrainer.Size = New System.Drawing.Size(231, 29)
        Me.cbTrainer.TabIndex = 14
        '
        'cbLockers
        '
        Me.cbLockers.DropDownHeight = 150
        Me.cbLockers.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLockers.FormattingEnabled = True
        Me.cbLockers.IntegralHeight = False
        Me.cbLockers.Location = New System.Drawing.Point(738, 259)
        Me.cbLockers.Name = "cbLockers"
        Me.cbLockers.Size = New System.Drawing.Size(83, 29)
        Me.cbLockers.TabIndex = 13
        Me.cbLockers.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAll)
        Me.GroupBox1.Controls.Add(Me.rbExpired)
        Me.GroupBox1.Controls.Add(Me.rbActive)
        Me.GroupBox1.Controls.Add(Me.lvPackages)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(209, 306)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 219)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PACKAGES"
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAll.Location = New System.Drawing.Point(239, 9)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(78, 22)
        Me.rbAll.TabIndex = 12
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "Show All"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rbExpired
        '
        Me.rbExpired.AutoSize = True
        Me.rbExpired.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExpired.Location = New System.Drawing.Point(165, 9)
        Me.rbExpired.Name = "rbExpired"
        Me.rbExpired.Size = New System.Drawing.Size(70, 22)
        Me.rbExpired.TabIndex = 11
        Me.rbExpired.Text = "Expired"
        Me.rbExpired.UseVisualStyleBackColor = True
        '
        'rbActive
        '
        Me.rbActive.AutoSize = True
        Me.rbActive.Checked = True
        Me.rbActive.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbActive.Location = New System.Drawing.Point(96, 9)
        Me.rbActive.Name = "rbActive"
        Me.rbActive.Size = New System.Drawing.Size(63, 22)
        Me.rbActive.TabIndex = 11
        Me.rbActive.TabStop = True
        Me.rbActive.Text = "Active"
        Me.rbActive.UseVisualStyleBackColor = True
        '
        'lvPackages
        '
        Me.lvPackages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvPackages.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvPackages.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPackages.FullRowSelect = True
        Me.lvPackages.GridLines = True
        Me.lvPackages.Location = New System.Drawing.Point(7, 34)
        Me.lvPackages.Name = "lvPackages"
        Me.lvPackages.Size = New System.Drawing.Size(643, 179)
        Me.lvPackages.TabIndex = 10
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
        Me.ColumnHeader2.Text = "Package"
        Me.ColumnHeader2.Width = 205
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Start Date"
        Me.ColumnHeader3.Width = 153
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Expiry Date"
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Price"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'btnUpdateLocker
        '
        Me.btnUpdateLocker.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateLocker.Image = Global.Gym_IS.My.Resources.Resources.icons8_reset_xsm
        Me.btnUpdateLocker.Location = New System.Drawing.Point(820, 258)
        Me.btnUpdateLocker.Name = "btnUpdateLocker"
        Me.btnUpdateLocker.Size = New System.Drawing.Size(39, 31)
        Me.btnUpdateLocker.TabIndex = 9
        Me.btnUpdateLocker.UseVisualStyleBackColor = True
        Me.btnUpdateLocker.Visible = False
        '
        'btnMeasurement
        '
        Me.btnMeasurement.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMeasurement.Location = New System.Drawing.Point(35, 471)
        Me.btnMeasurement.Name = "btnMeasurement"
        Me.btnMeasurement.Size = New System.Drawing.Size(168, 47)
        Me.btnMeasurement.TabIndex = 9
        Me.btnMeasurement.Text = "MEASUREMENT"
        Me.btnMeasurement.UseVisualStyleBackColor = True
        '
        'btnNewPackage
        '
        Me.btnNewPackage.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewPackage.Location = New System.Drawing.Point(35, 365)
        Me.btnNewPackage.Name = "btnNewPackage"
        Me.btnNewPackage.Size = New System.Drawing.Size(168, 47)
        Me.btnNewPackage.TabIndex = 9
        Me.btnNewPackage.Text = "ADD SUBSCRIPTION"
        Me.btnNewPackage.UseVisualStyleBackColor = True
        '
        'btnEditFingerID
        '
        Me.btnEditFingerID.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditFingerID.Location = New System.Drawing.Point(35, 312)
        Me.btnEditFingerID.Name = "btnEditFingerID"
        Me.btnEditFingerID.Size = New System.Drawing.Size(168, 47)
        Me.btnEditFingerID.TabIndex = 9
        Me.btnEditFingerID.Text = "UPDATE INFORMATION"
        Me.btnEditFingerID.UseVisualStyleBackColor = True
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Enabled = False
        Me.btnPrintReceipt.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReceipt.Location = New System.Drawing.Point(35, 418)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(168, 47)
        Me.btnPrintReceipt.TabIndex = 9
        Me.btnPrintReceipt.Text = "PRINT RECEIPT"
        Me.btnPrintReceipt.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(739, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 18)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "WEIGHT"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(618, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 18)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "BMI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(496, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "HEIGHT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(677, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 18)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "LOCKER"
        Me.Label13.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(593, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "MED. ISSUES"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(309, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 18)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "TRAINER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ADD. INFO."
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(802, 91)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(57, 27)
        Me.txtWeight.TabIndex = 5
        '
        'txtMedIssues
        '
        Me.txtMedIssues.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtMedIssues.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedIssues.Location = New System.Drawing.Point(686, 222)
        Me.txtMedIssues.Name = "txtMedIssues"
        Me.txtMedIssues.ReadOnly = True
        Me.txtMedIssues.Size = New System.Drawing.Size(173, 27)
        Me.txtMedIssues.TabIndex = 5
        '
        'txtBMI
        '
        Me.txtBMI.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBMI.Location = New System.Drawing.Point(657, 91)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.ReadOnly = True
        Me.txtBMI.Size = New System.Drawing.Size(80, 27)
        Me.txtBMI.TabIndex = 5
        '
        'txtHeight
        '
        Me.txtHeight.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(552, 91)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = True
        Me.txtHeight.Size = New System.Drawing.Size(56, 27)
        Me.txtHeight.TabIndex = 5
        '
        'txtMoreInfo
        '
        Me.txtMoreInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtMoreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoreInfo.Location = New System.Drawing.Point(404, 222)
        Me.txtMoreInfo.Name = "txtMoreInfo"
        Me.txtMoreInfo.ReadOnly = True
        Me.txtMoreInfo.Size = New System.Drawing.Size(181, 27)
        Me.txtMoreInfo.TabIndex = 5
        '
        'picClient
        '
        Me.picClient.Image = Global.Gym_IS.My.Resources.Resources.LogoNoPic
        Me.picClient.Location = New System.Drawing.Point(35, 22)
        Me.picClient.Name = "picClient"
        Me.picClient.Size = New System.Drawing.Size(261, 242)
        Me.picClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClient.TabIndex = 6
        Me.picClient.TabStop = False
        '
        'btnUpdateTrainer
        '
        Me.btnUpdateTrainer.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateTrainer.Image = Global.Gym_IS.My.Resources.Resources.icons8_reset_xsm
        Me.btnUpdateTrainer.Location = New System.Drawing.Point(633, 258)
        Me.btnUpdateTrainer.Name = "btnUpdateTrainer"
        Me.btnUpdateTrainer.Size = New System.Drawing.Size(39, 31)
        Me.btnUpdateTrainer.TabIndex = 9
        Me.btnUpdateTrainer.UseVisualStyleBackColor = True
        '
        'frmClientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1062, 615)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientInfo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.picClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents picClient As System.Windows.Forms.PictureBox
    Friend WithEvents txtClientID As System.Windows.Forms.TextBox
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtContactNum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBdate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtGuardianName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtGuardianContact As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents btnMeasurement As System.Windows.Forms.Button
    Friend WithEvents btnEditFingerID As System.Windows.Forms.Button
    Friend WithEvents btnPrintReceipt As System.Windows.Forms.Button
    Friend WithEvents btnNewPackage As System.Windows.Forms.Button
    Friend WithEvents lvPackages As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbExpired As System.Windows.Forms.RadioButton
    Friend WithEvents rbActive As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMoreInfo As System.Windows.Forms.TextBox
    Friend WithEvents cbLockers As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdateLocker As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMedIssues As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateTrainer As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBMI As System.Windows.Forms.TextBox
    Friend WithEvents cbTrainer As System.Windows.Forms.ComboBox
End Class
