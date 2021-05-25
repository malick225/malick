Public Class Form1

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        form2.show
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If user.Text = "" Or mp.Text = "" Then
            MsgBox("Renseignez les champs")

        ElseIf user.Text = "malick" And mp.Text = "Malick123" Then
            Form2.Show()
            Me.Hide()
            Exit Sub
        Else
            MsgBox("Ce compte n'existe pas")
            Exit Sub
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        form3.show
        Me.Hide()

    End Sub
End Class
