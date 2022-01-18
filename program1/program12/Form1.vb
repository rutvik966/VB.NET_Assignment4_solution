Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If no1.Text < no2.Text Then
            MessageBox.Show(no1.Text & " Is Minimum Value")
        ElseIf no2.Text < no3.Text Then
            MessageBox.Show(no2.Text & " Is Minimum Value")
        ElseIf no3.Text > no1.Text Then
            MessageBox.Show(no3.Text & " Is Minimum Value")
        End If
    End Sub
End Class
