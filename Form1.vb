Option Strict On

Public Class Form1
    '       Program: Payroll Calculator
    '     Developer: Timmy Bell
    ' Creation Date: 02/25/2023
    '         Class: INFO 1800
    '       Purpose: This program is to estimate the net pay after athe user enters their gross pay amount.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGrossPay.Select()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the program
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all result labels, textBox entries, and set focus to calculate
        lblGrossPayResult.Text = ""
        lblFICATaxResult.Text = ""
        lblFederalTaxResult.Text = ""
        lblStateTaxResult.Text = ""
        lblNetPayResult.Text = ""
        txtGrossPay.Clear()
        txtGrossPay.Focus()


    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim dblGrossPay As Double
        Dim decFICATaxRate As Decimal
        Dim dblFICATax As Double
        Dim decFederalTaxRate As Decimal
        Dim dblFederalTax As Double
        Dim decStateTaxRate As Decimal
        Dim dblStateTax As Double
        Dim dblNetPay As Double

        ' Get user input and assign to variables
        dblGrossPay = Convert.ToDecimal(txtGrossPay.Text)

        ' Calculate FICA Tax
        decFICATaxRate = CDec(0.0765)
        dblFICATax = dblGrossPay * decFICATaxRate

        ' Calculate Federal Tax
        decFederalTaxRate = CDec(0.22)
        dblFederalTax = dblGrossPay * decFederalTaxRate

        ' Calculate State Tax
        decStateTaxRate = CDec(0.04)
        dblStateTax = dblGrossPay * decStateTaxRate

        'Calculate Net pay 
        dblNetPay = dblGrossPay - (dblFederalTax + dblFICATax + dblStateTax)

        ' Display results
        lblGrossPayResult.Text = "$" + txtGrossPay.Text
        lblFICATaxResult.Text = "-" + dblFICATax.ToString("c")
        lblFederalTaxResult.Text = "-" + dblFederalTax.ToString("c")
        lblStateTaxResult.Text = "-" + dblStateTax.ToString("c")
        lblNetPayResult.Text = dblNetPay.ToString("c")

        ' Set focus to Clear
        btnClear.Focus()


    End Sub
End Class
