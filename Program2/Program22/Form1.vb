Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If no1.Text > no2.Text Then
            MessageBox.Show(no1.Text & " Is Maximum Value")
        ElseIf no2.Text > no3.Text Then
            MessageBox.Show(no2.Text & " Is Maximum Value")
        ElseIf no3.Text > no1.Text Then
            MessageBox.Show(no3.Text & " Is Maximum Value")
        End If
    End Sub
End Class
