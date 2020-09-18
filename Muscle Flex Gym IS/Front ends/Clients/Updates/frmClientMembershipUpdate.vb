Public Class frmClientMembershipUpdate

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

    Protected Friend Sub loadPlayer(ByVal playerID)
        SQLstr = String.Format("SELECT PlayerID, Lname, Fname, MI, MemshipEnd FROM Player WHERE PlayerID = {0}", playerID)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            txtClientID.Text = rdDB!PlayerID
            txtClientName.Text = String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI)
            If Not IsDBNull(rdDB!MemshipEnd) Then
                txtExpiryDate.Text = CDate(rdDB!MemshipEnd)
                'dtpStartDate.Value = CDate(rdDB!MemshipEnd)
            End If
        End If
        closeDBAll()
    End Sub

    Private Sub updateMembership(ByVal PlayerID)
        SQLstr = String.Format("UPDATE Player SET MemshipStart = '{0}', MemshipEnd = '{1}', isMember = 'True' WHERE PlayerID = {2}", dateValue(dtpStartDate.Value), dateValue(dtpExpireDate.Value), PlayerID)
        sqlNonQueryCMD(SQLstr)

        'saveTransacRecord(PlayerID)
        Dim msgAll As String = msgRegistrationRenew(txtClientName.Text,
                                                               CDate(dtpStartDate.Value.ToShortDateString).ToString("MMM dd, yyyy"),
                                                               CDate(dtpExpireDate.Value.ToShortDateString).ToString("MMM dd, yyyy"))
        Dim msg1 As String
        Dim msg2 As String


        If msgAll.Length > 160 Then
            msg1 = msgAll.Substring(0, 156)
            msg2 = msgAll.Substring(msg1.Length, msgAll.Length - msg1.Length)
            sendNoticeSMS(getPlayerMobile(txtClientID.Text), msg1 + vbCr + "1/2")
            sendNoticeSMS(getPlayerMobile(txtClientID.Text), msg2 + vbCr + "2/2")
            MessageBox.Show("Message Sent!")
        Else
            sendNoticeSMS(getPlayerMobile(txtClientID.Text), msgAll)
            MessageBox.Show("Message Sent!")
        End If
    End Sub

    'Private Sub saveTransacRecord(ByVal PlayerID)
    '    SQLstr = String.Format("SELECT PackageID FROM Package WHERE Package = '{0}'", txtPackageName.Text)
    '    sqlQueryCMD(SQLstr)
    '    If rdDB.HasRows Then
    '        SQLstr = String.Format("INSERT INTO TransacRecords(PackageID, PlayerID, AmountPaid, DateRecorded) " & _
    '                                    "VALUES('{0}', '{1}', {2}, '{3}')", _
    '                                    rdDB.Item(0), frmClientInfo.txtClientID.Text,
    '                                    txtSubsPrice.Text, dateValue(Now.Date))
    '    End If
    '    closeDBAll()
    '    sqlNonQueryCMD(SQLstr)
    'End Sub
#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If frmMain.Enabled = False Then
            frmMain.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        updateMembership(txtClientID.Text)
        MessageBox.Show("Membership has been successfully updated!", "Update success!")
        frmMonitoringList.loadMonitoringLists()
        btnClose_Click(sender, e)
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        dtpExpireDate.Value = dtpStartDate.Value.AddYears(nudNumofMonth.Value)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudNumofMonth.ValueChanged
        dtpExpireDate.Value = dtpStartDate.Value.AddYears(nudNumofMonth.Value)
    End Sub
End Class