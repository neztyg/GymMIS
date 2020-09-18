Public Class frmTrainerUpdate


    Private Function checkDuplicate() As Boolean
        SQLstr = String.Format("SELECT TrainerID FROM Trainer WHERE Trainer = '{0}'", txtTrainer.Text)
        If rdDB.HasRows Then

        End If
    End Function

    Private Sub loadTrainers()
        SQLstr = String.Format("SELECT TrainerID, Trainer FROM Trainer WHERE LEN(Trainer) > 1")
        sqlQueryCMD(SQLstr)

        Dim itemx As New ListViewItem
        lvTrainers.Items.Clear()

        Do While rdDB.Read
            itemx = lvTrainers.Items.Add(rdDB!TrainerID)
            itemx.SubItems.Add(rdDB!Trainer)
        Loop
        closeDBAll()
    End Sub

    Private Sub loadforUpdate(id As Integer)
        SQLstr = String.Format("SELECT TrainerID, Trainer FROM Trainer WHERE TrainerID = {0}", id)
        sqlQueryCMD(SQLstr)
        If rdDB.HasRows Then
            rdDB.Read()
            txtTrainer.Text = rdDB!Trainer
            trainerID = id
        End If
        closeDBAll()
    End Sub

    Private Sub saveTrainer(ByVal trainer)
        SQLstr = String.Format("INSERT INTO Trainer(Trainer) VALUES('{0}')", trainer)
        sqlNonQueryCMD(SQLstr)
    End Sub

    Private trnID
    Private Property trainerID As Integer
        Get
            Return trnID
        End Get
        Set(value As Integer)
            trnID = value
        End Set
    End Property
    Private Sub updateTrainer(ByVal trainer)
        SQLstr = String.Format("UPDATE Trainer SET Trainer = '{0}' WHERE TrainerID = {1}", txtTrainer.Text, trainerID)
        sqlNonQueryCMD(SQLstr)
    End Sub

    Private Sub btnAddProduct_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        If txtTrainer.TextLength <= 2 Then
            MessageBox.Show("The information you have entered is invalid!", "Value not accepted")
            Exit Sub
        End If
        If btnConfirm.Text = "SAVE" Then
            saveTrainer(txtTrainer.Text)
            MessageBox.Show("New trainer is now available!", "Save Success")
        ElseIf btnConfirm.Text = "UPDATE" Then
            updateTrainer(txtTrainer.Text)
        End If
        loadTrainers()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmTrainerUpdate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadTrainers()
    End Sub

    Private Sub lvTrainers_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lvTrainers.MouseDoubleClick
        If lvTrainers.SelectedItems.Count = 1 Then
            btnConfirm.Text = "UPDATE"
            loadforUpdate(lvTrainers.SelectedItems(0).SubItems(0).Text)
        End If
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        btnConfirm.Text = "SAVE"
        txtTrainer.Clear()
        trainerID = Nothing
    End Sub
End Class