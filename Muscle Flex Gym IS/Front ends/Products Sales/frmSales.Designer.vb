<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lvProductSold = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picResetDate = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dtpTransacDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblTodaySold = New System.Windows.Forms.Label()
        Me.lblOverall = New System.Windows.Forms.Label()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.Lable2 = New System.Windows.Forms.Label()
        Me.Lable4 = New System.Windows.Forms.Label()
        Me.Lable3 = New System.Windows.Forms.Label()
        Me.pnlCheckout = New System.Windows.Forms.Panel()
        Me.txtTenderAmount = New System.Windows.Forms.TextBox()
        Me.nudQty = New System.Windows.Forms.NumericUpDown()
        Me.btnCkeckout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProdDesc = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.cbProdCode = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picAddStock = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnModProduct = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.picResetDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnlCheckout.SuspendLayout()
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAddStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 544)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1053, 25)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1053, 50)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(58, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SALES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gym_IS.My.Resources.Resources.icons8_paid
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
        Me.btnClose.Location = New System.Drawing.Point(1003, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(44, 43)
        Me.btnClose.TabIndex = 1
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lvProductSold
        '
        Me.lvProductSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvProductSold.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvProductSold.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvProductSold.FullRowSelect = True
        Me.lvProductSold.GridLines = True
        Me.lvProductSold.Location = New System.Drawing.Point(0, 55)
        Me.lvProductSold.Name = "lvProductSold"
        Me.lvProductSold.Size = New System.Drawing.Size(580, 367)
        Me.lvProductSold.TabIndex = 4
        Me.lvProductSold.UseCompatibleStateImageBehavior = False
        Me.lvProductSold.View = System.Windows.Forms.View.Details
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
        Me.ColumnHeader3.Width = 326
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unit Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 88
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Qty Sold"
        Me.ColumnHeader5.Width = 68
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Controls.Add(Me.picResetDate)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Controls.Add(Me.dtpTransacDate)
        Me.Panel3.Controls.Add(Me.lvProductSold)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(473, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(580, 494)
        Me.Panel3.TabIndex = 5
        '
        'picResetDate
        '
        Me.picResetDate.Image = Global.Gym_IS.My.Resources.Resources.icons8_replace
        Me.picResetDate.Location = New System.Drawing.Point(424, 15)
        Me.picResetDate.Name = "picResetDate"
        Me.picResetDate.Size = New System.Drawing.Size(40, 28)
        Me.picResetDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picResetDate.TabIndex = 10
        Me.picResetDate.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!, System.Drawing.FontStyle.Italic)
        Me.Label5.Location = New System.Drawing.Point(-4, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PRODUCT LIST"
        '
        'btnPrint
        '
        Me.btnPrint.Image = Global.Gym_IS.My.Resources.Resources.icons8_print_xsm
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(475, 9)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(102, 40)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        Me.btnPrint.Visible = False
        '
        'dtpTransacDate
        '
        Me.dtpTransacDate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.dtpTransacDate.Location = New System.Drawing.Point(129, 15)
        Me.dtpTransacDate.Name = "dtpTransacDate"
        Me.dtpTransacDate.Size = New System.Drawing.Size(294, 28)
        Me.dtpTransacDate.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblTodaySold)
        Me.Panel4.Controls.Add(Me.lblOverall)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 422)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(580, 72)
        Me.Panel4.TabIndex = 5
        '
        'lblTodaySold
        '
        Me.lblTodaySold.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodaySold.Location = New System.Drawing.Point(165, 3)
        Me.lblTodaySold.Name = "lblTodaySold"
        Me.lblTodaySold.Size = New System.Drawing.Size(412, 31)
        Me.lblTodaySold.TabIndex = 0
        Me.lblTodaySold.Text = "TODAY SOLD: {0}"
        Me.lblTodaySold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOverall
        '
        Me.lblOverall.AutoSize = True
        Me.lblOverall.Location = New System.Drawing.Point(3, 48)
        Me.lblOverall.Name = "lblOverall"
        Me.lblOverall.Size = New System.Drawing.Size(350, 18)
        Me.lblOverall.TabIndex = 0
        Me.lblOverall.Text = "OVERALL PRODUCT SOLD FOR THE MONTH OF {0}: {1}"
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!)
        Me.Lable1.Location = New System.Drawing.Point(17, 88)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(123, 23)
        Me.Lable1.TabIndex = 7
        Me.Lable1.Text = "Product Code:"
        '
        'Lable2
        '
        Me.Lable2.AutoSize = True
        Me.Lable2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.Lable2.Location = New System.Drawing.Point(17, 127)
        Me.Lable2.Name = "Lable2"
        Me.Lable2.Size = New System.Drawing.Size(117, 21)
        Me.Lable2.TabIndex = 7
        Me.Lable2.Text = "Product Name: "
        '
        'Lable4
        '
        Me.Lable4.AutoSize = True
        Me.Lable4.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!)
        Me.Lable4.Location = New System.Drawing.Point(17, 209)
        Me.Lable4.Name = "Lable4"
        Me.Lable4.Size = New System.Drawing.Size(147, 23)
        Me.Lable4.TabIndex = 7
        Me.Lable4.Text = "Remaining Stock:"
        '
        'Lable3
        '
        Me.Lable3.AutoSize = True
        Me.Lable3.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!)
        Me.Lable3.Location = New System.Drawing.Point(17, 170)
        Me.Lable3.Name = "Lable3"
        Me.Lable3.Size = New System.Drawing.Size(88, 23)
        Me.Lable3.TabIndex = 7
        Me.Lable3.Text = "Unit Price:"
        '
        'pnlCheckout
        '
        Me.pnlCheckout.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlCheckout.Controls.Add(Me.txtTenderAmount)
        Me.pnlCheckout.Controls.Add(Me.nudQty)
        Me.pnlCheckout.Controls.Add(Me.btnCkeckout)
        Me.pnlCheckout.Controls.Add(Me.Label2)
        Me.pnlCheckout.Controls.Add(Me.Label11)
        Me.pnlCheckout.Controls.Add(Me.Label10)
        Me.pnlCheckout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlCheckout.Location = New System.Drawing.Point(0, 317)
        Me.pnlCheckout.Name = "pnlCheckout"
        Me.pnlCheckout.Size = New System.Drawing.Size(473, 227)
        Me.pnlCheckout.TabIndex = 6
        '
        'txtTenderAmount
        '
        Me.txtTenderAmount.Font = New System.Drawing.Font("Microsoft Tai Le", 25.0!)
        Me.txtTenderAmount.Location = New System.Drawing.Point(266, 51)
        Me.txtTenderAmount.Name = "txtTenderAmount"
        Me.txtTenderAmount.ReadOnly = True
        Me.txtTenderAmount.Size = New System.Drawing.Size(185, 50)
        Me.txtTenderAmount.TabIndex = 9
        '
        'nudQty
        '
        Me.nudQty.Font = New System.Drawing.Font("Microsoft Tai Le", 25.0!)
        Me.nudQty.Location = New System.Drawing.Point(81, 51)
        Me.nudQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQty.Name = "nudQty"
        Me.nudQty.Size = New System.Drawing.Size(106, 50)
        Me.nudQty.TabIndex = 6
        Me.nudQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnCkeckout
        '
        Me.btnCkeckout.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!)
        Me.btnCkeckout.Image = Global.Gym_IS.My.Resources.Resources.icons8_cash_in_hand_sm
        Me.btnCkeckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCkeckout.Location = New System.Drawing.Point(266, 126)
        Me.btnCkeckout.Name = "btnCkeckout"
        Me.btnCkeckout.Size = New System.Drawing.Size(185, 63)
        Me.btnCkeckout.TabIndex = 7
        Me.btnCkeckout.Text = "CHECK OUT"
        Me.btnCkeckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCkeckout.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(200, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 34)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Php"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Italic)
        Me.Label11.Location = New System.Drawing.Point(201, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 25)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "TOTAL AMOUNT:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Italic)
        Me.Label10.Location = New System.Drawing.Point(16, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 25)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "QUANTITY:"
        '
        'txtProdDesc
        '
        Me.txtProdDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtProdDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtProdDesc.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!)
        Me.txtProdDesc.Location = New System.Drawing.Point(146, 125)
        Me.txtProdDesc.Name = "txtProdDesc"
        Me.txtProdDesc.Size = New System.Drawing.Size(306, 26)
        Me.txtProdDesc.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!)
        Me.txtPrice.Location = New System.Drawing.Point(189, 163)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(263, 30)
        Me.txtPrice.TabIndex = 2
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!)
        Me.txtStock.Location = New System.Drawing.Point(189, 206)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(228, 30)
        Me.txtStock.TabIndex = 3
        '
        'cbProdCode
        '
        Me.cbProdCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbProdCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProdCode.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!)
        Me.cbProdCode.FormattingEnabled = True
        Me.cbProdCode.Location = New System.Drawing.Point(146, 82)
        Me.cbProdCode.Name = "cbProdCode"
        Me.cbProdCode.Size = New System.Drawing.Size(306, 34)
        Me.cbProdCode.TabIndex = 8
        '
        'picAddStock
        '
        Me.picAddStock.Image = Global.Gym_IS.My.Resources.Resources.icons8_reset
        Me.picAddStock.Location = New System.Drawing.Point(417, 207)
        Me.picAddStock.Name = "picAddStock"
        Me.picAddStock.Size = New System.Drawing.Size(34, 29)
        Me.picAddStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAddStock.TabIndex = 9
        Me.picAddStock.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picAddStock, "Add product stock.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!)
        Me.Label3.Location = New System.Drawing.Point(142, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Php"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Image = Global.Gym_IS.My.Resources.Resources.icons8_plus_xsm
        Me.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAddProduct.Location = New System.Drawing.Point(160, 252)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(141, 46)
        Me.btnAddProduct.TabIndex = 4
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnModProduct
        '
        Me.btnModProduct.Image = Global.Gym_IS.My.Resources.Resources.icons8_edit_row_xsm
        Me.btnModProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModProduct.Location = New System.Drawing.Point(311, 252)
        Me.btnModProduct.Name = "btnModProduct"
        Me.btnModProduct.Size = New System.Drawing.Size(141, 46)
        Me.btnModProduct.TabIndex = 5
        Me.btnModProduct.Text = "Edit Product"
        Me.btnModProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModProduct.UseVisualStyleBackColor = True
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1053, 569)
        Me.ControlBox = False
        Me.Controls.Add(Me.picAddStock)
        Me.Controls.Add(Me.cbProdCode)
        Me.Controls.Add(Me.txtProdDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.btnModProduct)
        Me.Controls.Add(Me.pnlCheckout)
        Me.Controls.Add(Me.Lable3)
        Me.Controls.Add(Me.Lable4)
        Me.Controls.Add(Me.Lable2)
        Me.Controls.Add(Me.Lable1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSales"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " & _
            "                                "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.picResetDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlCheckout.ResumeLayout(False)
        Me.pnlCheckout.PerformLayout()
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAddStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvProductSold As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtpTransacDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblTodaySold As System.Windows.Forms.Label
    Friend WithEvents lblOverall As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCkeckout As System.Windows.Forms.Button
    Friend WithEvents Lable1 As System.Windows.Forms.Label
    Friend WithEvents Lable2 As System.Windows.Forms.Label
    Friend WithEvents Lable4 As System.Windows.Forms.Label
    Friend WithEvents Lable3 As System.Windows.Forms.Label
    Friend WithEvents pnlCheckout As System.Windows.Forms.Panel
    Friend WithEvents nudQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnModProduct As System.Windows.Forms.Button
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Friend WithEvents txtTenderAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picResetDate As System.Windows.Forms.PictureBox
    Friend WithEvents txtProdDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents cbProdCode As System.Windows.Forms.ComboBox
    Friend WithEvents picAddStock As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
