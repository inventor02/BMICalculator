﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TitlePictureBox = New System.Windows.Forms.PictureBox()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.BMITextBox = New System.Windows.Forms.TextBox()
        Me.BMILabel = New System.Windows.Forms.Label()
        Me.AttributionLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.GenderPanel = New System.Windows.Forms.Panel()
        CType(Me.TitlePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitlePictureBox
        '
        Me.TitlePictureBox.Image = Global.BMICalculator.My.Resources.Resources.Text
        Me.TitlePictureBox.Location = New System.Drawing.Point(12, 6)
        Me.TitlePictureBox.Name = "TitlePictureBox"
        Me.TitlePictureBox.Size = New System.Drawing.Size(260, 44)
        Me.TitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TitlePictureBox.TabIndex = 0
        Me.TitlePictureBox.TabStop = False
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(12, 71)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(55, 13)
        Me.HeightLabel.TabIndex = 1
        Me.HeightLabel.Text = "Height (m)"
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Location = New System.Drawing.Point(172, 68)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HeightTextBox.TabIndex = 2
        '
        'WeightTextBox
        '
        Me.WeightTextBox.Location = New System.Drawing.Point(172, 92)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WeightTextBox.TabIndex = 4
        '
        'WeightLabel
        '
        Me.WeightLabel.AutoSize = True
        Me.WeightLabel.Location = New System.Drawing.Point(12, 95)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(62, 13)
        Me.WeightLabel.TabIndex = 3
        Me.WeightLabel.Text = "Weight (kg)"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(85, 155)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(115, 23)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "Calculate BMI"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'BMITextBox
        '
        Me.BMITextBox.BackColor = System.Drawing.SystemColors.Window
        Me.BMITextBox.Enabled = False
        Me.BMITextBox.Location = New System.Drawing.Point(172, 192)
        Me.BMITextBox.Name = "BMITextBox"
        Me.BMITextBox.Size = New System.Drawing.Size(100, 20)
        Me.BMITextBox.TabIndex = 7
        '
        'BMILabel
        '
        Me.BMILabel.AutoSize = True
        Me.BMILabel.Location = New System.Drawing.Point(11, 195)
        Me.BMILabel.Name = "BMILabel"
        Me.BMILabel.Size = New System.Drawing.Size(88, 13)
        Me.BMILabel.TabIndex = 6
        Me.BMILabel.Text = "Body Mass Index"
        '
        'AttributionLinkLabel
        '
        Me.AttributionLinkLabel.AutoSize = True
        Me.AttributionLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AttributionLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.AttributionLinkLabel.Location = New System.Drawing.Point(183, 224)
        Me.AttributionLinkLabel.Name = "AttributionLinkLabel"
        Me.AttributionLinkLabel.Size = New System.Drawing.Size(99, 13)
        Me.AttributionLinkLabel.TabIndex = 8
        Me.AttributionLinkLabel.TabStop = True
        Me.AttributionLinkLabel.Text = "by George Peppard"
        Me.AttributionLinkLabel.VisitedLinkColor = System.Drawing.Color.Black
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Checked = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(172, 118)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.MaleRadioButton.TabIndex = 9
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.FemaleRadioButton.Location = New System.Drawing.Point(219, 118)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.FemaleRadioButton.TabIndex = 10
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.Location = New System.Drawing.Point(13, 119)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(42, 13)
        Me.GenderLabel.TabIndex = 11
        Me.GenderLabel.Text = "Gender"
        '
        'GenderPanel
        '
        Me.GenderPanel.Location = New System.Drawing.Point(165, 115)
        Me.GenderPanel.Name = "GenderPanel"
        Me.GenderPanel.Size = New System.Drawing.Size(115, 23)
        Me.GenderPanel.TabIndex = 12
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 240)
        Me.Controls.Add(Me.GenderLabel)
        Me.Controls.Add(Me.FemaleRadioButton)
        Me.Controls.Add(Me.MaleRadioButton)
        Me.Controls.Add(Me.AttributionLinkLabel)
        Me.Controls.Add(Me.BMITextBox)
        Me.Controls.Add(Me.BMILabel)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.WeightTextBox)
        Me.Controls.Add(Me.WeightLabel)
        Me.Controls.Add(Me.HeightTextBox)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.TitlePictureBox)
        Me.Controls.Add(Me.GenderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "BMI Calculator"
        CType(Me.TitlePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitlePictureBox As PictureBox
    Friend WithEvents HeightLabel As Label
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents WeightLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents BMITextBox As TextBox
    Friend WithEvents BMILabel As Label
    Friend WithEvents AttributionLinkLabel As LinkLabel
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents GenderLabel As Label
    Friend WithEvents GenderPanel As Panel
End Class
