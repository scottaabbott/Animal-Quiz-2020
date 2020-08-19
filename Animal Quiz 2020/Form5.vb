Public Class Form5
    Private Sub Nextbtn_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        If optArmy.Checked Then
            MessageBox.Show("Correct! Good Job!")
            points = points + 1
        ElseIf optCroak.Checked Then
            MessageBox.Show("Wrong! Generic...")
        ElseIf optRibbit.Checked Then
            MessageBox.Show("Nope! Not the name of the group but the sound they make when they eat you alive!")
        ElseIf optArmada.Checked Then
            MessageBox.Show("Wrong!....um..they are preparing for war.")
        End If
        Me.Hide()
        Form6.Show()
    End Sub
End Class