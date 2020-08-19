Public Class Form8
    Private Sub Nextbtn_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        If optTower.Checked Then
            MessageBox.Show("Correct! Good Job!")
            points = points + 1
        ElseIf optHerd.Checked Then
            MessageBox.Show("Wrong! Sensable...")
        ElseIf optSpire.Checked Then
            MessageBox.Show("Nope! close tho")
        ElseIf optTrample.Checked Then
            MessageBox.Show("Wrong! dont get in thier path or you will be")
        End If
        Me.Hide()
        Form9.Show()
    End Sub
End Class