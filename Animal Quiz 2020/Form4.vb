Public Class Form4
    Private Sub Nextbtn_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        If optCongregation.Checked Then
            MessageBox.Show("Correct! Good Job!")
            points = points + 1
        ElseIf optPack.Checked Then
            MessageBox.Show("Wrong! Generic...")
        ElseIf optSnap.Checked Then
            MessageBox.Show("Nope! Not the name of the group but the sound they make when they eat you alive!")
        ElseIf optSwarm.Checked Then
            MessageBox.Show("Wrong!if they had stingers maybe. Imagine that. *shudders*")
        End If
        Me.Hide()
        Form5.Show()
    End Sub
End Class