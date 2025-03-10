Public Class frmMeasurementConverter

    ' Convert Button Click Event
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inputValue As Double
        Dim result As Double

        ' Validate input
        If Not Double.TryParse(txtInput.Text, inputValue) Then
            MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInput.Clear()
            txtInput.Focus()
            Return
        End If

        ' Check if value is positive
        If inputValue < 0 Then
            MessageBox.Show("Please enter a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInput.Clear()
            txtInput.Focus()
            Return
        End If

        ' Perform the conversion based on selected RadioButton
        If rdoInchesToMeters.Checked Then
            result = inputValue * 0.0254
        ElseIf rdoMetersToInches.Checked Then
            result = inputValue / 0.0254
        End If

        ' Display result rounded to 3 decimal places
        lblResult.Text = "Result: " & Math.Round(result, 3).ToString()
    End Sub

    ' Clear Button Click Event
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        lblResult.Text = "Result: "
        rdoInchesToMeters.Checked = True ' Reset to default selection
        txtInput.Focus()
    End Sub

    ' Exit Button Click Event
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes the application
    End Sub

    Private Sub frmMeasurementConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
