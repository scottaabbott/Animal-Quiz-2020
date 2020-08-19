Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Checkbtn_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        If optMurder.Checked Then
            MessageBox.Show("Correct! Good Job!")
            points = points + 1
        ElseIf optFlock.Checked Then
            MessageBox.Show("Wrong! Generic. Try thinking outside the box!")
        ElseIf optHoard.Checked Then
            MessageBox.Show("Nope! Nice try!")
        ElseIf optSquable.Checked Then
            MessageBox.Show("Wrong! Wow ur REALLY thinking about this huh?")
        End If
        Me.Hide()
        Form3.Show()
    End Sub
End Class