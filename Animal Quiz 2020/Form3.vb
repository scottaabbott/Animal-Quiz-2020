Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        If optGlare.Checked Then
            MessageBox.Show("Correct! Good Job!")
            points = points + 1
        ElseIf optCorral.Checked Then
            MessageBox.Show("Wrong! God you wish you could corral them XD!")
        ElseIf optFeral.Checked Then
            MessageBox.Show("Nope! Not the name of the group but yes those buggers really are feral!")
        ElseIf optClump.Checked Then
            MessageBox.Show("Wrong!......um..are you ok?")
        End If
        Me.Hide()
        Form4.Show()
    End Sub
End Class