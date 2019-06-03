Public Class login
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Size = New Size(366, 57)
        PictureBox1.BackgroundImage = My.Resources.ACEPTAR2
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New Size(363, 54)
        PictureBox1.BackgroundImage = My.Resources.ACEPTAR
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (TextBox1.Text = "Pedro") And TextBox2.Text = "12345" Then
            MsgBox("Bienvenido")
            Form5.Show()
        Else
            MsgBox("ERROR el usuario o contraseña son incorrectas")
        End If





    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class