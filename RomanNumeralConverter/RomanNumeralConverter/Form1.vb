Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim number = TextBox1.Text
        Dim romanNumeral = TextBox2.Text

        If number < 1 Then
            romanNumeral = "Value is either out of bound or a non-integer"
        ElseIf number = 1 Then
            romanNumeral = "I"
        ElseIf number = 2 Then
            romanNumeral = "II"
        ElseIf number = 3 Then
            romanNumeral = "III"
        ElseIf number = 4 Then
            romanNumeral = "IV"
        ElseIf number = 5 Then
            romanNumeral = "V"
        ElseIf number = 6 Then
            romanNumeral = "VI"
        ElseIf number = 7 Then
            romanNumeral = "VII"
        ElseIf number = 8 Then
            romanNumeral = "VIII"
        ElseIf number = 9 Then
            romanNumeral = "IX"
        ElseIf number = 10 Then
            romanNumeral = "X"
        ElseIf number > 10 Then
            romanNumeral = "Value is either out of bound or a non-integer"
        End If

        MessageBox.Show(romanNumeral)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button3_click(sender As Object, e As EventArgs) Handles Button3.Click

        Application.Exit()

    End Sub

End Class
