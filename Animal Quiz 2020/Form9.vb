Public Class Form9
    Private Sub Nextbtn_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        If optSmack.Checked Then
            MessageBox.Show("Correct! Good Job!")
            points = points + 1
        ElseIf optBlob.Checked Then
            MessageBox.Show("Wrong! they do look like one don't they.")
        ElseIf optFloat.Checked Then
            MessageBox.Show("Nope! Idek with this one.")
        ElseIf optHerd.Checked Then
            MessageBox.Show("Wrong!...unless they can walk. I don't think so")
        End If
        Me.Hide()
        Form11.Show()
    End Sub
End Class