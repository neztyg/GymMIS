Public Class frmLockerRemarks


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnModProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Try
            SQLstr = String.Format("UPDATE Locker SET Remarks = '{1}' WHERE LockerID = {0}", lblLocker.Text, rtxtRemarks.Text)
            sqlNonQueryCMD(SQLstr)
            MessageBox.Show("Locker has new remarks", "Save Success")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class