Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.Items.Add("1")
        Me.ComboBox1.Items.Add("2")
        Me.ComboBox1.Items.Add("3")
        Me.ComboBox1.Items.Add("4")
    End Sub

    Private Sub Nextbtn_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        If Me.ComboBox1.SelectedIndex = 0 Then
            MessageBox.Show("Wrong!")
        ElseIf Me.ComboBox1.SelectedIndex = 2 Then
            MessageBox.Show("Nope!")
        ElseIf Me.ComboBox1.SelectedIndex = 3 Then
            MessageBox.Show("Wrong!")
        ElseIf Me.ComboBox1.SelectedIndex = 1 Then
            MessageBox.Show("Correct! Good Job!")
            points = points + 1
        End If
        Me.Hide()
        Form7.Show()
    End Sub
End Class