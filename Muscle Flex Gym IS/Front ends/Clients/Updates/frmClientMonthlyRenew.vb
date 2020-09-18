Public Class frmClientMonthlyRenew


#Region "Properties"

    Private tranID As Integer
    Private Property TransactionID As Integer
        Get
            Return tranID
        End Get
        Set(ByVal value As Integer)
            tranID = value
        End Set
    End Property
#End Region

#Region "Functions"


#End Region

#Region "Subs"

    Protected Friend Sub loadClientPackage(ByVal transacID As Integer)
        Dim packID, playerID As Integer
        TransactionID = transacID

        SQLstr = String.Format("SELECT * FROM Transactions WHERE TransacID = {0}", transacID)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            packID = rdDB!PackageID
            playerID = rdDB!PlayerID
            txtExpiryDate.Text = CDate(rdDB!PackExpireDate).ToLongDateString
        End If
        closeDBAll()
        loadPackage(packID)
        loadPlayer(playerID)
    End Sub

    Private Sub loadPackage(ByVal packID As Integer)
        SQLstr = String.Format("SELECT Package FROM Package WHERE PackageID = {0}", packID)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            txtPackage.Text = rdDB!Package
        End If
        closeDBAll()
    End Sub

    Private Sub loadPlayer(ByVal playerID)
        SQLstr = String.Format("SELECT PlayerID, Lname, Fname, MI FROM Player WHERE PlayerID = {0}", playerID)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            txtClientID.Text = rdDB!PlayerID
            txtClientName.Text = String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI)
        End If
        closeDBAll()
    End Sub

    Private Sub updateTransaction()
        SQLstr = String.Format("UPDATE Transactions SET PackStartDate = '{0}', PackExpireDate = '{1}', Status = 'True' WHERE TransacID = {2}", _
                                    dateValue(dtpStartDate.Value), dateValue(dtpExpireDate.Value), TransactionID)
        sqlNonQueryCMD(SQLstr)
    End Sub


#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If frmMain.Visible = True Then
            frmMain.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        updateTransaction()
        MessageBox.Show("Package has been successfully updated!", "Update success!")
        frmMonitoringList.loadMonitoringLists()
        btnClose_Click(sender, e)
        'MessageBox.Show(Len(msgMonthlyRenewInfo(txtClientName.Text,
        'CDate(dtpStartDate.Value.ToShortDateString).ToString("MMM dd, yyy"),
        'CDate(dtpExpireDate.Value.ToShortDateString).ToString("MMM dd, yyy"),
        'txtPackage.Text)))
        'Dim msgAll As String = msgMonthlyRenewInfo(txtClientName.Text,
        '                                          CDate(dtpStartDate.Value.ToShortDateString).ToString("MMM dd, yyyy"),
        '                                          CDate(dtpExpireDate.Value.ToShortDateString).ToString("MMM dd, yyyy"),
        '                                          txtPackage.Text)
        'Dim msg1 As String
        'Dim msg2 As String


        'If msgAll.Length > 160 Then
        '    msg1 = msgAll.Substring(0, 156)
        '    msg2 = msgAll.Substring(msg1.Length, msgAll.Length - msg1.Length)
        '    sendNoticeSMS(getPlayerMobile(txtClientID.Text), msg1 + vbCr + "1/2")
        '    sendNoticeSMS(getPlayerMobile(txtClientID.Text), msg2 + vbCr + "2/2")
        '    MessageBox.Show("Message Sent!")
        'Else
        '    sendNoticeSMS(getPlayerMobile(txtClientID.Text), msgAll)
        '    MessageBox.Show("Message Sent!")
        'End If
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        dtpExpireDate.Value = dtpStartDate.Value.AddMonths(nudNumofMonth.Value)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudNumofMonth.ValueChanged
        dtpExpireDate.Value = dtpStartDate.Value.AddMonths(nudNumofMonth.Value)
    End Sub

End Class