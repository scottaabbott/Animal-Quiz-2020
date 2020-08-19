Public Class Form11
    Private Sub Nextbtn_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        If optScurry.Checked Then
            MessageBox.Show("Correct! Good Job!")
            points = points + 1
        ElseIf optPack.Checked Then
            MessageBox.Show("Wrong! Sensable...")
        ElseIf optNutter.Checked Then
            MessageBox.Show("Nope! But they are nuts arent they...")
        ElseIf optFlight.Checked Then
            MessageBox.Show("Wrong! ha! not all of them fly.")
        End If
        Me.Hide()
        Form10.Show()
    End Sub
End Class