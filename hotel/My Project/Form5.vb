Public Class Form5
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        Panel2.Size = New Size(151, 122)
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.Size = New Size(148, 119)
    End Sub

    Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles Panel4.MouseHover
        Panel4.Size = New Size(151, 103)
    End Sub

    Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs) Handles Panel4.MouseLeave
        Panel4.Size = New Size(148, 100)
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Form3.Show()

    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Form4.Show()

    End Sub
End Class