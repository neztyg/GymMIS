Public Class frmLogin

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        If txtUser.TextLength = 0 Or txtPass.TextLength = 0 Then
            MessageBox.Show("Please enter username and password to continue!", "Invalid entry!")
            Exit Sub
        End If

        SQLstr = String.Format("SELECT EmpID, Name " + _
                               "FROM viewEmpAccount WHERE CAST(Username AS CHAR) = CAST('{0}' AS CHAR) AND CAST(Password AS CHAR) = CAST('{1}' AS CHAR) AND AccountType = 0", CChar(txtUser.Text), CChar(txtPass.Text))

        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            MessageBox.Show(String.Format("Hi, {0}!" + vbCr + "You can now use the system.", rdDB!Name))
            frmMain.lblUser.Text = rdDB!Name.ToString.ToUpper
            closeDBAll()
            frmMain.Show()
            Me.Hide()
        Else
            MessageBox.Show("The username and password is not recognized!" + vbCr + "Please try again!")
        End If
        closeDBAll()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Dim msg = MsgBox("Are you sure to exit the program?", MsgBoxStyle.YesNo, "EXIT PROGRAM")
        If msg = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class