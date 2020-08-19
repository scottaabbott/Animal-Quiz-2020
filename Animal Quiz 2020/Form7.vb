Public Class Form7
    Private Sub Nextbtn_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        If optPod.Checked Then
            MessageBox.Show("Correct! Good Job!")
            points = points + 1
        ElseIf optBottle.Checked Then
            MessageBox.Show("Wrong! They do die from them tho")
        ElseIf optFlipper.Checked Then
            MessageBox.Show("Nope!....just nope")
        ElseIf optSchool.Checked Then
            MessageBox.Show("Wrong!They do swim tho")
        End If
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub optWeb_CheckedChanged(sender As Object, e As EventArgs) Handles optFlipper.CheckedChanged

    End Sub

    Private Sub optCauldron_CheckedChanged(sender As Object, e As EventArgs) Handles optSchool.CheckedChanged

    End Sub

    Private Sub optCloud_CheckedChanged(sender As Object, e As EventArgs) Handles optPod.CheckedChanged

    End Sub

    Private Sub optSwarm_CheckedChanged(sender As Object, e As EventArgs) Handles optBottle.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class