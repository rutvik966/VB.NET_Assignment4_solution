Public Class Form1
    Private Sub urllink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles urllink.LinkClicked
        System.Diagnostics.Process.Start(url1.Text)
    End Sub
End Class
