Public Class frmSales
    Dim WithEvents ticker As New Timer

#Region "Properties"
    Private prodID As Integer
    Private Property productID As Integer
        Get
            Return prodID
        End Get
        Set(value As Integer)
            prodID = value
        End Set
    End Property
#End Region

#Region "Functions"

#End Region

#Region "Subs"
    Private Sub modProduct(ByVal val As Boolean)
        Dim modProd As New frmModProduct
        modProd.setProductID(productID)
        If val = True Then
            If productID <> 0 Then
                modProd.setProductID(productID)
                modProd.isForUpdate(True)
                modProd.ShowDialog()
            Else
                MessageBox.Show("No selected product!")
            End If
        Else
            modProd.isForUpdate(False)
            modProd.ShowDialog()
        End If

    End Sub


    Private Sub loadProductSalesList()
        SQLstr = String.Format("")
    End Sub


    Private Sub loadProductCodes()
        SQLstr = String.Format("SELECT ProductCode FROM Product")
        sqlQueryCMD(SQLstr)

        cbProdCode.Items.Clear()
        Do While rdDB.Read
            cbProdCode.Items.Add(rdDB!ProductCode)
        Loop
        closeDBAll()
    End Sub

    Private Sub loadProductDetails()
        SQLstr = String.Format("SELECT ProductID, Description, Price, Stock FROM Product WHERE ProductCode = '{0}'", cbProdCode.Text)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            productID = rdDB!ProductID
            txtProdDesc.Text = rdDB!Description
            txtPrice.Text = rdDB!Price
            txtStock.Text = rdDB!Stock
        End If
        closeDBAll()
    End Sub

    Private Sub loadSuggestedList(ByVal reValue As String, ByVal txtObj As TextBox)
        SQLstr = String.Format("SELECT DISTINCT({0}) AS txt FROM Product WHERE Description Like '{1}%'", reValue, txtObj.Text)
        sqlQueryCMD(SQLstr)

        Do While rdDB.Read()
            txtObj.AutoCompleteCustomSource.Add(rdDB!txt)
        Loop
        closeDBAll()
    End Sub

    Private Sub loadProductCustomSourceList()
        loadSuggestedList("Description", txtProdDesc)
    End Sub


    Private Sub loadSales()

        'ALL SALES
        SQLstr = String.Format("SELECT Sales.SaleID, Product.ProductID, Product.ProductCode, Product.Description, Product.Price, Sales.SoldDate, Sales.SoldTime, Sales.QtySold, Sales.AmountPaid, Product.Stock " & _
                               "FROM Sales INNER JOIN Product ON Sales.ProductID = Product.ProductID " & _
                               "WHERE Sales.SoldDate = '{0}' " & _
                               "ORDER BY Sales.SoldDate DESC", dateValue(dtpTransacDate.Value))



        sqlQueryCMD(SQLstr)

        lvProductSold.Items.Clear()
        Dim lstItem As New ListViewItem

        Do While rdDB.Read
            lstItem = lvProductSold.Items.Add(rdDB!SaleID)
            lstItem.SubItems.Add(rdDB!ProductCode)
            lstItem.SubItems.Add(rdDB!Description)
            lstItem.SubItems.Add(rdDB!Price)
            lstItem.SubItems.Add(rdDB!QtySold)
        Loop
        closeDBAll()


        'GET TOTAL SOLD per DATE
        SQLstr = String.Format("SELECT SUM(AmountPaid) AS todayTotal FROM SALES WHERE SoldDate = '{0}'", dateValue(dtpTransacDate.Value))
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            lblTodaySold.Text = String.Format("TODAY SOLD: {0}", rdDB!todayTotal)
        End If
        closeDBAll()

        'GET TOTAL SOLD per SELECTED MONTH
        SQLstr = String.Format("SELECT SUM(AmountPaid) AS monthTotal FROM SALES WHERE MONTH(SoldDate) = {0} AND YEAR(SoldDate) = {1}", Month(dtpTransacDate.Value), Year(dtpTransacDate.Value))
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            lblOverall.Text = String.Format("OVERALL PRODUCT SOLD FOR THE MONTH OF {0}: {1}", dtpTransacDate.Value.ToString("MMMM"), rdDB!monthTotal)
        End If
        closeDBAll()


    End Sub

    Private Sub checkProductStock()
        If nudQty.Value = 0 Then
            MessageBox.Show("Product stock is 0," & vbNewLine & "Add stock before continuing!", "No product stock")
            modProduct(True)
        ElseIf txtStock.Text <> "" Then
            If nudQty.Value > txtStock.Text Then
                MessageBox.Show("Product stock is lower than  quantity to be sold," & vbNewLine & "Add stock before continuing!", "Low product stock")
                modProduct(True)
            End If
        End If
    End Sub

    Private Sub CheckoutSale()
        checkProductStock()

        SQLstr = String.Format("UPDATE Product SET Stock = Stock - {0} WHERE ProductID = {1}", nudQty.Value, productID)
        sqlNonQueryCMD(SQLstr)

        SQLstr = String.Format("INSERT INTO Sales(ProductID, SoldDate, SoldTime, QtySold, AmountPaid) VALUES({0},'{1}','{2}', {3}, {4})", productID, dateValue(Now.Date), Now.ToShortTimeString, nudQty.Value, txtTenderAmount.Text)
        sqlNonQueryCMD(SQLstr)

        MessageBox.Show(String.Format("{0} of {1} was sold", nudQty.Value, txtProdDesc.Text), "Checkout success")
        loadSales()
        loadProductDetails()
    End Sub

#End Region

    Protected Friend Sub frmSales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadProductCodes()
        loadSales()
        loadProductCustomSourceList()
        ticker.Start()
    End Sub

    Private Sub ticker_tick() Handles ticker.Tick
        If productID = 0 Or txtPrice.Text = "" Then
            pnlCheckout.Enabled = False
        Else
            pnlCheckout.Enabled = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
        frmMain.MonitoringToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnModProduct_Click(sender As System.Object, e As System.EventArgs) Handles btnModProduct.Click
        modProduct(True)
    End Sub

    Private Sub btnAddStock_Click(sender As System.Object, e As System.EventArgs) Handles btnAddProduct.Click
        modProduct(False)
    End Sub

    Private Sub cbProdCode_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbProdCode.SelectedIndexChanged
        loadProductDetails()
        nudQty_ValueChanged()
    End Sub

    Private Sub nudQty_ValueChanged() Handles nudQty.ValueChanged
        If txtPrice.Text <> "" Then
            txtTenderAmount.Text = CStr(CDec(nudQty.Value) * CDec(txtPrice.Text))
        End If
    End Sub

    Private Sub btnCkeckout_Click(sender As System.Object, e As System.EventArgs) Handles btnCkeckout.Click
        CheckoutSale()
        loadSales()
    End Sub

    Private Sub txtStock_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStock.TextChanged
        closeDBAll()
        checkProductStock()
    End Sub

    Private Sub picAddStock_Click(sender As System.Object, e As System.EventArgs) Handles picAddStock.Click
        modProduct(True)
        loadProductDetails()
    End Sub

    Private Sub dtpTransacDate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpTransacDate.ValueChanged
        loadSales()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'Dim rptViewer As New frmReportViewer
        'Dim rptSource As New crSales_Monthly

        'rptSource.Refresh()

        'rptSource.SetParameterValue(0, dtpTransacDate.Value.Month)
        'rptViewer.CrystalReportViewer1.ReportSource = rptSource
        'rptViewer.ShowDialog()
    End Sub

    Private Sub picResetDate_Click(sender As System.Object, e As System.EventArgs) Handles picResetDate.Click
        dtpTransacDate.Value = Now
    End Sub
End Class