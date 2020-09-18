Public Class frmReportsView


    Public loadYears As Action =
        Sub()
            SQLstr = String.Format("SELECT DISTINCT DATEPART(year, TransacDate) AS yr FROM Transactions")
            sqlQueryCMD(SQLstr)

            Do While rdDB.Read
                cbYr.Items.Add(rdDB!yr)
            Loop
            cbYr.SelectedText = Now.Year
            cbMonth.SelectedIndex = Now.Month - 1
        End Sub


    Private Sub loadDailyTransac(ByVal dtArg As Date)
        SQLstr = String.Format("SELECT Player.PlayerID, Player.Lname + ', ' + Player.Fname + ' ' + Player.MI AS ClientName, Transactions.TransacDate, Package.Package, Package.PayMode, Package.PackagePrice " + _
                               "FROM Player INNER JOIN Transactions ON Player.PlayerID = Transactions.PlayerID INNER JOIN Package ON Transactions.PackageID = Package.PackageID " + _
                               "WHERE Transactions.TransacDate = CONVERT(date,'{0}')", dtArg)
        sqlQueryCMD(SQLstr)

        lvTransacs.Items.Clear()
        Dim itemx As New ListViewItem

        Do While rdDB.Read
            itemx = lvTransacs.Items.Add(rdDB!PlayerID)
            itemx.SubItems.Add(rdDB!ClientName)
            itemx.SubItems.Add(rdDB!Package)
            itemx.SubItems.Add(rdDB!PackagePrice)
        Loop
        closeDBAll()
        SQLstr = String.Format("SELECT SUM(Package.PackagePrice) AS totalSales FROM Transactions " + _
                                    "INNER JOIN Package ON Transactions.PackageID = Package.PackageID " + _
                                  " WHERE TransacDate = '{0}'", dtArg)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            If Not IsDBNull(rdDB!totalSales) Then
                lblTotalSales.Text = String.Format("TOTAL SALES: Php  {0:n}", CDec(rdDB!totalSales))
            Else
                lblTotalSales.Text = String.Empty
            End If
        End If

    End Sub


    Private Sub loadMonthlyTransac(ByVal monthArg As Integer, ByVal yrArg As Integer)
        SQLstr = String.Format("SELECT Player.PlayerID, Player.PlayerID, Player.Lname + ', ' + Player.Fname + ' ' + Player.MI AS ClientName, Transactions.TransacDate, Package.Package, Package.PayMode, Package.PackagePrice " + _
           "FROM Player INNER JOIN Transactions ON Player.PlayerID = Transactions.PlayerID INNER JOIN Package ON Transactions.PackageID = Package.PackageID " + _
           "WHERE DATEPART(Month,Transactions.TransacDate) = '{0}' AND DATEPART(Year,Transactions.TransacDate) = '{1}'", monthArg, yrArg)
        sqlQueryCMD(SQLstr)

        lvTransacs.Items.Clear()
        Dim itemx As New ListViewItem

        Do While rdDB.Read
            itemx = lvTransacs.Items.Add(rdDB!PlayerID)
            itemx.SubItems.Add(rdDB!ClientName)
            itemx.SubItems.Add(rdDB!Package)
            itemx.SubItems.Add(rdDB!PackagePrice)
        Loop

        Dim totalSales As Decimal = 0.0
        If lvTransacs.Items.Count > 0 Then
            For x As Integer = 0 To lvTransacs.Items.Count - 1
                totalSales += lvTransacs.Items(x).SubItems(3).Text
            Next
            lblTotalSales.Text = String.Format("TOTAL SALES: Php  {0:n}", totalSales)
        Else
            lblTotalSales.Text = String.Empty
        End If
    End Sub

    Private Sub loadAnnualTransac(ByVal yrArg As Integer)
        SQLstr = String.Format("SELECT Player.PlayerID, Player.PlayerID, Player.Lname + ', ' + Player.Fname + ' ' + Player.MI AS ClientName, Transactions.TransacDate, Package.Package, Package.PayMode, Package.PackagePrice " + _
           "FROM Player INNER JOIN Transactions ON Player.PlayerID = Transactions.PlayerID INNER JOIN Package ON Transactions.PackageID = Package.PackageID " + _
           "WHERE DATEPART(Year,Transactions.TransacDate) = {0}", yrArg)
        sqlQueryCMD(SQLstr)

        lvTransacs.Items.Clear()
        Dim itemx As New ListViewItem

        Do While rdDB.Read
            itemx = lvTransacs.Items.Add(rdDB!PlayerID)
            itemx.SubItems.Add(rdDB!ClientName)
            itemx.SubItems.Add(rdDB!Package)
            itemx.SubItems.Add(rdDB!PackagePrice)
        Loop

    End Sub

    Private Sub frmPrintOpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cbYearReport.Text = Now.Year
        Call loadYears()
        cbReportType.SelectedIndex = 0
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cbYearReport.Text = "" Then
        '    MessageBox.Show("Please select year to continue!", "No year selected.")
        '    Exit Sub
        'Else
        '    Me.Close()
        '    Dim printRpt As New clsPrintReport
        '    printRpt.printAnnualAttendance(Container, cbYearReport.Text)
        'End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cbReportType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbReportType.SelectedIndexChanged
        If cbReportType.SelectedIndex = 0 Then
            pnlMonth.Visible = False
            pnlDtp.Visible = True
            ''
            dtpTransacDate_ValueChanged(sender, e)
        ElseIf cbReportType.SelectedIndex = 1 Then
            pnlMonth.Visible = True
            cbMonth.Enabled = True
            pnlDtp.Visible = False
            ''
            cbYr_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub dtpTransacDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTransacDate.ValueChanged
        loadDailyTransac(dtpTransacDate.Value.ToShortDateString)
    End Sub

    Private Sub cbYr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMonth.SelectedIndexChanged, cbYr.SelectedIndexChanged
        If cbYr.Text.Length > 0 Or cbMonth.Text.Length > 0 Then
            loadMonthlyTransac(cbMonth.SelectedIndex + 1, cbYr.Text)
        End If
    End Sub
End Class