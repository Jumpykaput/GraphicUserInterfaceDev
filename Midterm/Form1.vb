Public Class frmMeasurementConverter
    ' Converts input measurement based on selected RadioButton
    Private Sub ConvertMeasurement()
        ' Validate input
        Dim inputValue As Double
        If Not Double.TryParse(txtInput.Text, inputValue) Then
            MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInput.Clear()
            txtInput.Focus()
            Return
        End If

        ' Ensure the value is positive
        If inputValue < 0 Then
            MessageBox.Show("Please enter a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInput.Clear()
            txtInput.Focus()
            Return
        End If

        ' Perform conversion based on selected radio button
        Dim result As Double
        Dim resultText As String

        If rdoInchesToMeters.Checked Then
            result = inputValue * 0.0254
            resultText = $"{inputValue} inches is {Math.Round(result, 3)} meters"
        ElseIf rdoMetersToInches.Checked Then
            result = inputValue / 0.0254
            resultText = $"{inputValue} meters is {Math.Round(result, 3)} inches"
        Else
            MessageBox.Show("Please select a conversion type.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Display the result
        lblResult.Text = resultText
    End Sub

    ' Button Click Event for "Convert"
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ConvertMeasurement()
    End Sub

    ' Button Click Event for "Clear"
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        lblResult.Text = ""
        rdoInchesToMeters.Checked = True ' Default selection
        txtInput.Focus()
    End Sub

    ' Button Click Event for "Exit"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMeasurementConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
