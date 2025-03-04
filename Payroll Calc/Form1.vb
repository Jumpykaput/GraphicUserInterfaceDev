Public Class frmPayrollCalculator
    ' Constants for tax rates
    Private Const cdecFica As Decimal = 0.0765D
    Private Const cdecFed As Decimal = 0.22D
    Private Const cdecState As Decimal = 0.04D

    Private Sub frmPayrollCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear all labels and set focus to Gross Pay input
        ClearFields()
    End Sub

    ' Event handler for Compute Taxes button
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim strIncome As String = txtGrossPay.Text
        Dim decIncome As Decimal

        ' Input validation
        If Not Decimal.TryParse(strIncome, decIncome) OrElse decIncome < 0 Then
            MessageBox.Show("Please enter a valid positive number for Gross Pay.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGrossPay.Clear()
            txtGrossPay.Focus()
            Exit Sub
        End If

        ' Tax calculations
        Dim decFica As Decimal = decIncome * cdecFica
        Dim decFederal As Decimal = decIncome * cdecFed
        Dim decState As Decimal = decIncome * cdecState
        Dim decNet As Decimal = decIncome - (decFica + decFederal + decState)

        ' Display results formatted as currency
        lblFica.Text = decFica.ToString("C2")
        lblFederal.Text = decFederal.ToString("C2")
        lblState.Text = decState.ToString("C2")
        lblNetPay.Text = decNet.ToString("C2")
    End Sub

    ' Event handler for Clear button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' Event handler for Exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ' Method to clear all input/output fields
    Private Sub ClearFields()
        txtGrossPay.Clear()
        lblFica.Text = ""
        lblFederal.Text = ""
        lblState.Text = ""
        lblNetPay.Text = ""
        txtGrossPay.Focus()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblNetpay.Click

    End Sub
End Class
