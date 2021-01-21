Public Class Form1
    Dim intMax As Integer = 6
    Dim intMin As Integer = 1

    Private Sub btnMix_Click(sender As Object, e As EventArgs) Handles btnMix.Click
        Randomize()
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intNum3 As Integer
        Dim intTries As Integer = 0

        Do
            intNum1 = Int(Rnd() * intMax) + 1
            intNum2 = Int(Rnd() * intMax) + 1
            intNum3 = Int(Rnd() * intMax) + 1
            intTries = intTries + 1
        Loop While (intNum1 = intNum2 Or intNum1 = intNum3 Or intNum2 = intNum1 Or intNum2 = intNum3 Or intNum3 = intNum1 Or intNum3 = intNum2)
        'MessageBox.Show("Tries: " & intTries)

        lblNum1.Text = intNum1
        lblNum2.Text = intNum2
        lblNum3.Text = intNum3

    End Sub

    Private Sub btnRange_Click(sender As Object, e As EventArgs) Handles btnRange.Click
        Const LIMIT As Integer = 100

        Do
            intMax = InputBox("Enter The Max")
            If (intMax > LIMIT) Then
                MessageBox.Show("ERROR! Enter a number 100 or less")
            End If
        Loop While (intMax > LIMIT)

        lblRandom.Text = "Random From 1 To " & intMax
    End Sub
End Class
