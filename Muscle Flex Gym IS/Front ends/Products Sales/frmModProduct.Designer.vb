<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModProduct
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProdCode = New System.Windows.Forms.TextBox()
        Me.txtProdDesc = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.nudStock = New System.Windows.Forms.NumericUpDown()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvProdList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsProducts = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProducts.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 357)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(867, 25)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 50)
        Me.Panel1.TabIndex = 2
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!)
        Me.lblHeader.Location = New System.Drawing.Point(58, 8)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(123, 29)
        Me.lblHeader.TabIndex = 5
        Me.lblHeader.Text = "PRODUCTS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gym_IS.My.Resources.Resources.icons8_product_code
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
        Me.btnClose.Image = Global.Gym_IS.My.Resources.Resources.icons8_x_mark
        Me.btnClose.Location = New System.Drawing.Point(817, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(44, 43)
        Me.btnClose.TabIndex = 1
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Product Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Unit Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(26, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock"
        '
        'txtProdCode
        '
        Me.txtProdCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdCode.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.txtProdCode.Location = New System.Drawing.Point(150, 78)
        Me.txtProdCode.Name = "txtProdCode"
        Me.txtProdCode.Size = New System.Drawing.Size(254, 28)
        Me.txtProdCode.TabIndex = 0
        '
        'txtProdDesc
        '
        Me.txtProdDesc.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.txtProdDesc.Location = New System.Drawing.Point(150, 114)
        Me.txtProdDesc.Multiline = True
        Me.txtProdDesc.Name = "txtProdDesc"
        Me.txtProdDesc.Size = New System.Drawing.Size(254, 78)
        Me.txtProdDesc.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.txtPrice.Location = New System.Drawing.Point(188, 198)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(216, 28)
        Me.txtPrice.TabIndex = 2
        '
        'nudStock
        '
        Me.nudStock.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!)
        Me.nudStock.Location = New System.Drawing.Point(150, 234)
        Me.nudStock.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudStock.Name = "nudStock"
        Me.nudStock.Size = New System.Drawing.Size(103, 33)
        Me.nudStock.TabIndex = 3
        Me.nudStock.Tag = ""
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Image = Global.Gym_IS.My.Resources.Resources.icons8_save_button_xsm
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirm.Location = New System.Drawing.Point(240, 290)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(164, 47)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "SAVE"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(146, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Php"
        '
        'lvProdList
        '
        Me.lvProdList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvProdList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.lvProdList.ContextMenuStrip = Me.cmsProducts
        Me.lvProdList.Dock = System.Windows.Forms.DockStyle.Right
        Me.lvProdList.FullRowSelect = True
        Me.lvProdList.GridLines = True
        Me.lvProdList.Location = New System.Drawing.Point(410, 50)
        Me.lvProdList.Name = "lvProdList"
        Me.lvProdList.Size = New System.Drawing.Size(457, 307)
        Me.lvProdList.TabIndex = 6
        Me.lvProdList.UseCompatibleStateImageBehavior = False
        Me.lvProdList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Code"
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Product Name"
        Me.ColumnHeader3.Width = 226
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unit Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 71
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Stock"
        '
        'cmsProducts
        '
        Me.cmsProducts.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmsProducts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditDetailsToolStripMenuItem})
        Me.cmsProducts.Name = "cmsProducts"
        Me.cmsProducts.Size = New System.Drawing.Size(147, 28)
        '
        'EditDetailsToolStripMenuItem
        '
        Me.EditDetailsToolStripMenuItem.Name = "EditDetailsToolStripMenuItem"
        Me.EditDetailsToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.EditDetailsToolStripMenuItem.Text = "Edit Details"
        '
        'frmModProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(867, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.lvProdList)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.nudStock)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProdDesc)
        Me.Controls.Add(Me.txtProdCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModProduct"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProducts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProdCode As System.Windows.Forms.TextBox
    Friend WithEvents txtProdDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents nudStock As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvProdList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsProducts As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
