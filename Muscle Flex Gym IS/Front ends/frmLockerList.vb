Public Class frmLockerList

#Region "Subs"
    Private Sub updateClientLocker()


        SQLstr = String.Format("UPDATE Locker SET (PlayerID = {0}) WHERE LockerID = {1}")
    End Sub

    Private Sub loadLockertoList()
        SQLstr = String.Format("SELECT COUNT(LockerID) as cntLocker FROM Locker")
        sqlQueryCMD(SQLstr)

        nudAddLocker.Value = 0
        If rdDB.HasRows Then
            rdDB.Read()
            lblTotalLockers.Text = rdDB!cntLocker
        End If
        closeDBAll()

        SQLstr = String.Format("SELECT Locker.LockerID, Locker.Remarks,Player.Lname, Player.Fname FROM Player RIGHT JOIN Locker ON Player.PlayerID = Locker.PlayerID ORDER BY Locker.LockerID")
        sqlQueryCMD(SQLstr)

        Dim itemx As New ListViewItem
        lvLockerList.Items.Clear()

        Do While rdDB.Read
            itemx = lvLockerList.Items.Add(rdDB!LockerID)
            If Not IsDBNull(rdDB!Lname) Or Not IsDBNull(rdDB!Fname) Then
                itemx.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))
            End If
            If Not IsDBNull(rdDB!Remarks) Then
                itemx.SubItems.Add(rdDB!Remarks)
            End If

        Loop
        closeDBAll()
    End Sub
#End Region

    Private Sub btnUpdateLocker_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateLocker.Click
        'MessageBox.Show("This function is not yet fixed", "Restricted button")
        'Exit Sub
        Dim newLockerVal As Integer = Val(lblTotalLockers.Text)
        For x As Integer = newLockerVal + 1 To newLockerVal + nudAddLocker.Value Step 1
            SQLstr = String.Format("INSERT INTO Locker(LockerID) VALUES({0})", x)
            sqlNonQueryCMD(SQLstr)
        Next
        MessageBox.Show("Locker count has been updated", "Save Success")
        loadLockertoList()
    End Sub

    Private Sub frmLockerList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadLockertoList()
        'nudTotalLocker.Value = My.Settings.maxLocker
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lvLockerList_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvLockerList.MouseDoubleClick
        If lvLockerList.SelectedItems.Count = 1 Then
            Dim frmRemark As New frmLockerRemarks
            frmRemark.lblLocker.Text = lvLockerList.SelectedItems(0).SubItems(0).Text
            frmRemark.ShowDialog()
        End If
    End Sub

    Private Sub lvLockerList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvLockerList.SelectedIndexChanged

    End Sub
End Class