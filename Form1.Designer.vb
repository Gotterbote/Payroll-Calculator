<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblGrossPayResult = New System.Windows.Forms.Label()
        Me.lblFICATaxResult = New System.Windows.Forms.Label()
        Me.lblFederalTaxResult = New System.Windows.Forms.Label()
        Me.lblStateTaxResult = New System.Windows.Forms.Label()
        Me.lblNetPayResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(83, 231)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(360, 361)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(523, 361)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrompt.Location = New System.Drawing.Point(12, 157)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(248, 42)
        Me.lblPrompt.TabIndex = 3
        Me.lblPrompt.Text = "Please enter gross pay below."
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(70, 202)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 23)
        Me.txtGrossPay.TabIndex = 4
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGross.Location = New System.Drawing.Point(374, 37)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(74, 20)
        Me.lblGross.TabIndex = 5
        Me.lblGross.Text = "Gross Pay:"
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFICA.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblFICA.Location = New System.Drawing.Point(317, 85)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(149, 40)
        Me.lblFICA.TabIndex = 6
        Me.lblFICA.Text = "FICA Tax:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Calculated at 7.65%)"
        Me.lblFICA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFederalTax.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblFederalTax.Location = New System.Drawing.Point(326, 142)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(138, 40)
        Me.lblFederalTax.TabIndex = 7
        Me.lblFederalTax.Text = "Federal Tax: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Calculated at 22%)"
        Me.lblFederalTax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStateTax.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblStateTax.Location = New System.Drawing.Point(332, 210)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(130, 40)
        Me.lblStateTax.TabIndex = 8
        Me.lblStateTax.Text = "State Tax:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Calculated at 4%)"
        Me.lblStateTax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNetPay.Location = New System.Drawing.Point(384, 282)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(62, 20)
        Me.lblNetPay.TabIndex = 9
        Me.lblNetPay.Text = "Net Pay:"
        '
        'lblGrossPayResult
        '
        Me.lblGrossPayResult.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrossPayResult.Location = New System.Drawing.Point(549, 33)
        Me.lblGrossPayResult.Name = "lblGrossPayResult"
        Me.lblGrossPayResult.Size = New System.Drawing.Size(75, 28)
        Me.lblGrossPayResult.TabIndex = 10
        Me.lblGrossPayResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFICATaxResult
        '
        Me.lblFICATaxResult.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFICATaxResult.ForeColor = System.Drawing.Color.Red
        Me.lblFICATaxResult.Location = New System.Drawing.Point(549, 93)
        Me.lblFICATaxResult.Name = "lblFICATaxResult"
        Me.lblFICATaxResult.Size = New System.Drawing.Size(75, 24)
        Me.lblFICATaxResult.TabIndex = 11
        Me.lblFICATaxResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFederalTaxResult
        '
        Me.lblFederalTaxResult.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFederalTaxResult.ForeColor = System.Drawing.Color.Red
        Me.lblFederalTaxResult.Location = New System.Drawing.Point(549, 146)
        Me.lblFederalTaxResult.Name = "lblFederalTaxResult"
        Me.lblFederalTaxResult.Size = New System.Drawing.Size(75, 32)
        Me.lblFederalTaxResult.TabIndex = 12
        Me.lblFederalTaxResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStateTaxResult
        '
        Me.lblStateTaxResult.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStateTaxResult.ForeColor = System.Drawing.Color.Red
        Me.lblStateTaxResult.Location = New System.Drawing.Point(549, 214)
        Me.lblStateTaxResult.Name = "lblStateTaxResult"
        Me.lblStateTaxResult.Size = New System.Drawing.Size(75, 32)
        Me.lblStateTaxResult.TabIndex = 13
        Me.lblStateTaxResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNetPayResult
        '
        Me.lblNetPayResult.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNetPayResult.Location = New System.Drawing.Point(499, 270)
        Me.lblNetPayResult.Name = "lblNetPayResult"
        Me.lblNetPayResult.Size = New System.Drawing.Size(125, 44)
        Me.lblNetPayResult.TabIndex = 14
        Me.lblNetPayResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblNetPayResult)
        Me.Controls.Add(Me.lblStateTaxResult)
        Me.Controls.Add(Me.lblFederalTaxResult)
        Me.Controls.Add(Me.lblFICATaxResult)
        Me.Controls.Add(Me.lblGrossPayResult)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Payroll Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents lblGross As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents lblGrossPayResult As Label
    Friend WithEvents lblFICATaxResult As Label
    Friend WithEvents lblFederalTaxResult As Label
    Friend WithEvents lblStateTaxResult As Label
    Friend WithEvents lblNetPayResult As Label
End Class
