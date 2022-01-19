Public Class Form1
    Private Sub no_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles no.KeyPress
        If Asc(e.KeyChar) <= 47 Or Asc(e.KeyChar) >= 58 Then
            e.Handled = True
        End If
    End Sub

    Private Sub capital_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles capital.KeyPress
        If Asc(e.KeyChar) <= 65 Or Asc(e.KeyChar) >= 90 Then
            e.Handled = True
        End If
    End Sub

    Private Sub small_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles small.KeyPress
        If Asc(e.KeyChar) <= 97 Or Asc(e.KeyChar) >= 122 Then
            e.Handled = True
        End If
    End Sub
End Class
