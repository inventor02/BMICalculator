Public Class MainForm
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim height, weight As Double

        If Not Double.TryParse(HeightTextBox.Text, height) Then
            ShowInvalidInputDialog("height")
            Return
        End If

        If Not Double.TryParse(WeightTextBox.Text, weight) Then
            ShowInvalidInputDialog("weight")
            Return
        End If

        BMITextBox.Text = Math.Round((weight / height) / height, 1)
    End Sub

    Private Sub ShowInvalidInputDialog(inputName As String)
        MessageBox.Show("Your input for " & inputName & " is invalid.")
    End Sub

    Private Sub AttributionLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AttributionLinkLabel.LinkClicked
        Process.Start("https://georgepeppard.me/")
    End Sub
End Class
