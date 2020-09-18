Public Class frmCardNumUpdate

    Dim WithEvents timerRFID As New System.Windows.Forms.Timer
    Dim RFIDAvail As Boolean = False

    Protected Friend Sub loadClientInfo(ByVal playerID As Integer)
        SQLstr = String.Format("SELECT PlayerID, LName, FName, MI, PlayerPic, CardNum FROM Player WHERE PlayerID = {0}", playerID)
        sqlQueryCMD(SQLstr)


        If rdDB.HasRows Then
            rdDB.Read()
            lblPlayerID.Text = rdDB!PlayerID
            lblName.Text = String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI)
            If Len(rdDB!CardNum.ToString) > 0 Then
                txtRFIDnum.Text = rdDB!CardNum
                txtRFIDnum.Enabled = False
                lblIDstatus.Text = ""
                picStatIndicator.Image = Nothing
                picStatIndicator.Refresh()
            Else
                txtRFIDnum.Enabled = True
                picStatIndicator.Image = Nothing
                picStatIndicator.Refresh()
            End If
            If Not IsDBNull(rdDB!PlayerPic) Then

                Dim data As Byte() = DirectCast(rdDB!PlayerPic, Byte())
                Dim ms As New IO.MemoryStream(data)

                picClient.Image = Image.FromStream(ms)
            Else
                picClient.Image = My.Resources.LogoNoPic
            End If
        End If
        closeDBAll()
    End Sub


    Private Function isRFIDAvail(ByVal cardNum As String) As Boolean
        SQLstr = String.Format("SELECT PlayerID, Fname, Lname FROM Player WHERE CardNum = '{0}'", cardNum)
        sqlQueryCMD(SQLstr)
        If Not rdDB.HasRows Then
            lblIDstatus.Text = "Card can now be assigned to the client"
            picStatIndicator.Image = My.Resources.icons8_green_check_mark_2
            isRFIDAvail = True
        Else
            rdDB.Read()
            lblIDstatus.Text = String.Format("Card already belong to {0} {1}", rdDB!Fname, rdDB!Lname)
            picStatIndicator.Image = My.Resources.icons8_stop_sign
            isRFIDAvail = False
        End If
        closeDBAll()
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmCardNumUpdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        NumericTypeOnly(sender, e)
    End Sub

    Private Sub frmRFIDUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRFIDnum.Focus()
        timerRFID.Interval = 1000
        timerRFID.Start()
    End Sub

    Private Sub timerRFID_Tick() Handles timerRFID.Tick
        txtRFIDnum.Focus()
    End Sub

    Private Sub txtRFIDnum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRFIDnum.KeyDown
        'If e.KeyCode = Keys.Enter And txtRFIDnum.Text.Length > 3 Then
        '    'txtRFIDnum.Enabled = False
        '    'RFIDAvail = isRFIDAvail(txtRFIDnum.Text)
        '    'If RFIDAvail = False Then
        '    '    Delay(2)
        '    '    lblIDstatus.Text = ""
        '    '    txtRFIDnum.Clear()
        '    '    txtRFIDnum.Enabled = True
        '    '    txtRFIDnum.Focus()
        '    '    picStatIndicator.Image = Nothing
        '    '    picStatIndicator.Refresh()
        '    '    'btnConfirm.Enabled = False
        '    'Else
        '    '    btnConfirm.Enabled = True
        '    'End If
        'End If
    End Sub

    Private Sub clearFields()
        txtRFIDnum.Clear()
        lblName.Text = ""
        lblPlayerID.Text = ""
        picClient.Image = Nothing
        picClient.Refresh()

    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        SQLstr = String.Format("UPDATE Player SET CardNum = '{0}' WHERE PlayerID = {1}", txtRFIDnum.Text, lblPlayerID.Text)
        Try
            sqlNonQueryCMD(SQLstr)
            MessageBox.Show("Client card is now updated!")
            clearFields()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnRenew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRenew.Click
        txtRFIDnum.Clear()
        txtRFIDnum.Enabled = True
        lblIDstatus.Text = Nothing
        picStatIndicator.Image = Nothing
        picStatIndicator.Refresh()
    End Sub
End Class