Public Class frmUpdateLockerAssign

    Protected Friend Sub loadClientInfo(ByVal id As Integer)
        SQLstr = String.Format("SELECT Fname, Lname FROM Player WHERE PlayerID = {0}", id)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            lblClientID.Text = id
            lblClientName.Text = String.Format("{0} {1}", rdDB!Fname, rdDB!Lname)
        End If
        closeDBAll()
        SQLstr = String.Format("SELECT LockerNum From Attendance WHERE PlayerID = '{0}' AND LogDate = CONVERT(date, '{1}')", id, Now.ToShortDateString)
        sqlQueryCMD(SQLstr)
        If rdDB.HasRows Then
            rdDB.Read()
            If Not IsDBNull(rdDB!LockerNum) Then
                txtLockerNum.Text = rdDB!LockerNum
            End If
        End If
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        SQLstr = String.Format("SELECT LockerNum From Attendance WHERE CONVERT(date, LogDate) = CONVERT(date, '{0}') AND isLockerReturned = 0", Now.ToShortDateString)
        sqlQueryCMD(SQLstr)
        If rdDB.HasRows Then
            rdDB.Read()
            If rdDB!LockerNum = txtLockerNum.Text Then
                closeDBAll()
                frmConfirmPopper.SetPromptTexts("Warning", "Locker is already assigned!")
                Exit Sub
            End If
        End If
        closeDBAll()
        SQLstr = String.Format("UPDATE Attendance SET LockerNum = {0}, isLockerReturned = 'False' WHERE PlayerID = {1} AND LogDate = '{2}'", txtLockerNum.Text, lblClientID.Text, Now.ToShortDateString)
        sqlNonQueryCMD(SQLstr)
        MessageBox.Show("Locker is now assigned!", "Locker" + txtLockerNum.Text)
        Me.Close()
    End Sub

    Private Sub frmUpdateLockerAssign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class