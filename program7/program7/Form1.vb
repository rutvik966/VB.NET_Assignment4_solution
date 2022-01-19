Public Class Form1
    Private Sub applycolor_Click(sender As Object, e As EventArgs) Handles applycolor.Click
        Me.BackColor = Color.FromArgb(red.Text, green.Text, blue.Text)
    End Sub

    Private Sub exist_Click(sender As Object, e As EventArgs) Handles exist.Click
        red.Clear()
        green.Clear()
        blue.Clear()
        Me.Close()
    End Sub

    Private Sub normal_Click(sender As Object, e As EventArgs) Handles normal.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximize.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
