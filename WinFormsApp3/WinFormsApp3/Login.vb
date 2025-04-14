Public Class Login


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "patient" And PasswordTextBox.Text = "123" Then
            Patient.Show()
        ElseIf UsernameTextBox.Text = "doctor" And PasswordTextBox.Text = "123" Then
            Doctor.Show()
        Else
            MsgBox("incorrect")
        End If
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
