Public Class Form1
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If uname.Text = "ssccs" And upass.Text = "ssccs" Then
            MessageBox.Show("Login Success", "Login Success")
        Else
            MessageBox.Show("Login Fail", "Login Faill")
        End If

    End Sub

    Private Sub uclose_Click(sender As Object, e As EventArgs) Handles uclose.Click
        uname.Clear()
        upass.Clear()
        Me.Close()
    End Sub
End Class