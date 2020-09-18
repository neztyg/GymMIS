Public Class frmModProduct
    Dim WithEvents ticker As New Timer

#Region "Properties"
    Private isUpdt As Boolean
    Private Property isUpdate As Boolean
        Get
            Return isUpdt
        End Get
        Set(value As Boolean)
            isUpdt = value
        End Set
    End Property

    Private prodID As Integer
    Private Property ProductID As Integer
        Get
            Return prodID
        End Get
        Set(value As Integer)
            prodID = value
        End Set
    End Property


#End Region

#Region "Functions"
    Private Function isDuplicate()
        Dim value As Boolean = False

        SQLstr = String.Format("SELECT ProductID FROM Product WHERE ProductCode = '{0}' OR Description = '{1}'", txtProdCode.Text, txtProdDesc.Text)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            value = True
        Else : value = False
        End If
        closeDBAll()
        Return value
    End Function

#End Region

#Region "Subs"

    Protected Friend Sub isForUpdate(ByVal val As Boolean)
        isUpdate = val
        If isUpdate() Then
            btnConfirm.Text = "UPDATE"
            btnConfirm.Image = My.Resources.icons8_edit_row_xsm
            loadProductDetails()
        Else
            btnConfirm.Text = "SAVE"
            btnConfirm.Image = My.Resources.icons8_save_button_xsm
        End If
    End Sub

    Private Sub saveProduct()
        If isDuplicate() Then
            MessageBox.Show("Product is already exist!", "Save abort!")
            Exit Sub
        End If

        SQLstr = String.Format("INSERT INTO Product(ProductCode, Description, Price, Stock) VALUES('{0}', '{1}', {2}, {3})", txtProdCode.Text, txtProdDesc.Text, txtPrice.Text, nudStock.Value)
        sqlNonQueryCMD(SQLstr)
        MessageBox.Show("New product record saved successfully!", "Save success!")
        loadProductList()
    End Sub

    Private Sub updateProduct()
        SQLstr = String.Format("UPDATE Product SET ProductCode = '{0}', Description = '{1}', Price = {2}, Stock = {3} WHERE ProductID = {4}", txtProdCode.Text, txtProdDesc.Text, txtPrice.Text, nudStock.Value, ProductID)
        sqlNonQueryCMD(SQLstr)
        MessageBox.Show("Product was updated successfully!", "Update complete!")
        isForUpdate(False)
        loadProductList()
        clearValues()
    End Sub

    Private Sub loadProductDetails()
        SQLstr = String.Format("SELECT ProductCode, Description, Price, Stock FROM Product WHERE ProductID = {0}", ProductID)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            txtProdCode.Text = rdDB!ProductCode
            txtProdDesc.Text = rdDB!Description
            txtPrice.Text = rdDB!Price
            nudStock.Value = rdDB!Stock
        End If
        closeDBAll()
    End Sub

    Private Sub loadProductList()
        SQLstr = String.Format("SELECT ProductID, ProductCode, Description, Price, Stock FROM Product ")
        sqlQueryCMD(SQLstr)

        Dim lstItem As New ListViewItem
        lvProdList.Items.Clear()

        Do While rdDB.Read
            lstItem = lvProdList.Items.Add(rdDB!ProductID)
            lstItem.SubItems.Add(rdDB!ProductCode)
            lstItem.SubItems.Add(rdDB!Description)
            lstItem.SubItems.Add(rdDB!Price)
            lstItem.SubItems.Add(rdDB!Stock)
        Loop
        closeDBAll()
    End Sub


    Public Sub setProductID(ByVal val As Integer)
        ProductID = val
    End Sub

    Private Sub clearValues()
        txtProdCode.Clear()
        txtProdDesc.Clear()
        txtPrice.Clear()
        nudStock.Value = nudStock.Minimum
    End Sub
#End Region

    Private Sub frmModProduct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ticker.Start()
        loadProductList()
    End Sub


    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        If isUpdate() Then
            updateProduct()
        Else
            saveProduct()
        End If
        loadProductList()
        clearValues()
        Dim msgBx = MsgBox("Do you want to add more products?", MsgBoxStyle.YesNo, "New Transaction")
        If MsgBoxResult.No Then
            Me.Close()
        End If
    End Sub


    Private Sub ticker_Tick() Handles ticker.Tick
        If txtProdCode.Text = "" Or txtProdDesc.Text = "" Then
            btnConfirm.Enabled = False
        Else
            btnConfirm.Enabled = True
        End If


    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        frmSales.frmSales_Load(sender, e)
        Me.Close()
    End Sub

    Private Sub txtPrice_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        NumericTypeOnly(sender, e)
    End Sub

    Private Sub EditDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditDetailsToolStripMenuItem.Click
        If lvProdList.SelectedItems.Count <> 1 Then
            MessageBox.Show("Select product to continue!", "Selection required!")
            Exit Sub
        Else
            ProductID = lvProdList.SelectedItems(0).SubItems(0).Text
            isForUpdate(True)
        End If
    End Sub
End Class