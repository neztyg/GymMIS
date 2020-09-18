Public Class clsWindowMods


    '#Region "Moving window events"
    '    Dim drag As Boolean
    '    Dim mousex As Integer
    '    Dim mousey As Integer

    '    Private Sub Header_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
    '        drag = True
    '        mousex = Windows.Forms.Cursor.Position.X - Me.Left
    '        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    '    End Sub

    '    Private Sub Header_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
    '        If drag Then
    '            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
    '            Me.Left = Windows.Forms.Cursor.Position.X - mousex
    '        End If
    '    End Sub

    '    Private Sub Header_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
    '        drag = False
    '    End Sub
    '#End Region


#Region "MDI WRAPPER"
    'Code for creating a child form inside the parent form which is the main form
    Public Sub mdiGetter(ByVal parent As Windows.Forms.Form, ByVal child As Windows.Forms.Form) 'Loads a child form to the parent form
        'this code is seen in the Main form, on New application menu, shown like this 
        'mdiGetter(Me, frmBurialApplication) Me => the Main form, frmBurialApplication => child



        For i = parent.MdiChildren.Length - 1 To 0 Step -1 'checks if there are opened child forms then closes them all
            parent.MdiChildren(i).Close()
        Next

        'Child Form Properties
        child.MdiParent = parent 'assigning the parent to the child form

        child.Show()
        child.WindowState = FormWindowState.Maximized

        'child.Location = New Point(0, 0)
    End Sub

#End Region

End Class
