Public Class frmTrainers

    Private Sub loadTrainers()
        SQLstr = String.Format("SELECT Trainer, TrainerSpec FROM Trainer")
        sqlQueryCMD(SQLstr)

        lvTrainers.Items.Clear()
        Dim itemx As New ListViewItem

        Do While rdDB.Read
            itemx = lvTrainers.Items.Add(rdDB!Trainer)
            itemx.SubItems.Add(rdDB!TrainerSpec)
        Loop
    End Sub

    Private Sub txtTrainerName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTrainerName.GotFocus
        If txtTrainerName.Text = "Trainer Name" Then
            txtTrainerName.Text = String.Empty
            txtTrainerName.Focus()
        End If
    End Sub

    Private Sub txtTrainerSpec_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTrainerSpec.GotFocus
        If txtTrainerName.Text = "Specialization" Then
            txtTrainerName.Text = String.Empty
            txtTrainerName.Focus()
        End If
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        SQLstr = String.Format("INSERT INTO Trainer(Trainer, TrainerSpec) VALUES('{0}', '{1}')", txtTrainerName.Text, txtTrainerSpec.Text)
        Try
            sqlNonQueryCMD(SQLstr)
            MessageBox.Show("New Trainer has been saved successfully!")
            loadTrainers()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class