Public Class MainForm
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim height, weight, bmi As Double

        If Not Double.TryParse(HeightTextBox.Text, height) Then
            ShowInvalidInputDialog("height")
            Return
        End If

        If Not Double.TryParse(WeightTextBox.Text, weight) Then
            ShowInvalidInputDialog("weight")
            Return
        End If

        bmi = Math.Round((weight / height) / height, 1)

        BMITextBox.Text = bmi

        If MaleRadioButton.Checked Then
            ' Male

            If bmi < 15 Then
                ' Underweight
                BMITextBox.BackColor = Color.FromArgb(255, 224, 192)
            ElseIf bmi <= 25 Then
                ' Normal
                BMITextBox.BackColor = Color.FromArgb(192, 255, 192)
            ElseIf bmi > 25 And bmi <= 30 Then
                ' Overweight
                BMITextBox.BackColor = Color.FromArgb(255, 224, 192)
            Else
                ' Obese
                BMITextBox.BackColor = Color.FromArgb(255, 192, 192)
            End If
        Else
            ' Female

            If bmi < 15 Then
                ' Underweight
                BMITextBox.BackColor = Color.FromArgb(255, 192, 128)
            ElseIf bmi <= 25 Then
                ' Normal
                BMITextBox.BackColor = Color.FromArgb(192, 255, 192)
            ElseIf bmi > 25 And bmi <= 30 Then
                ' Overweight
                BMITextBox.BackColor = Color.FromArgb(255, 224, 192)
            Else
                ' Obese
                BMITextBox.BackColor = Color.FromArgb(255, 192, 192)
            End If
        End If
    End Sub

    Private Sub ShowInvalidInputDialog(inputName As String)
        MessageBox.Show("Your input for " & inputName & " is invalid.")
    End Sub

    Private Sub AttributionLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AttributionLinkLabel.LinkClicked
        Process.Start("https://georgepeppard.me/")
    End Sub
End Class
