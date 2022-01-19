Public Class calculator
    Dim n As Double
    Dim op As Char

    Private Sub b0_Click(sender As Object, e As EventArgs) Handles b0.Click
        textbox.Text &= sender.text
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        textbox.Text &= sender.text
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        textbox.Text &= sender.text
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        textbox.Text &= sender.text
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        textbox.Text &= sender.text
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        textbox.Text &= sender.text
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        textbox.Text &= sender.text
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        textbox.Text &= sender.text
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        textbox.Text &= sender.text
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        textbox.Text &= sender.text
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        op = sender.text
        n = textbox.Text
        textbox.Clear()
        textbox.Focus()
    End Sub

    Private Sub multiplication_Click(sender As Object, e As EventArgs) Handles multiplication.Click
        op = sender.text
        n = textbox.Text
        textbox.Clear()
        textbox.Focus()
    End Sub

    Private Sub addition_Click(sender As Object, e As EventArgs) Handles addition.Click
        op = sender.text
        n = textbox.Text
        textbox.Clear()
        textbox.Focus()
    End Sub

    Private Sub subtraction_Click(sender As Object, e As EventArgs) Handles subtraction.Click
        op = sender.text
        n = textbox.Text
        textbox.Clear()
        textbox.Focus()
    End Sub


    Private Sub b00_Click(sender As Object, e As EventArgs) Handles b00.Click
        Select Case op
            Case "+"
                textbox.Text = n + textbox.Text
            Case "-"
                textbox.Text = n - textbox.Text
            Case "X"
                textbox.Text = n * textbox.Text
            Case "/"
                textbox.Text = n / textbox.Text
        End Select

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        textbox.Clear()
        n = 0
        op = " "
    End Sub


End Class
