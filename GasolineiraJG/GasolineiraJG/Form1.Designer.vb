<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGasolineira
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGasolineira))
        Me.RadioButtonGas95 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGas98 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGas = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.TextBoxAbastecimento = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelAbastecimento = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButtonGas95
        '
        Me.RadioButtonGas95.AutoSize = True
        Me.RadioButtonGas95.Location = New System.Drawing.Point(6, 28)
        Me.RadioButtonGas95.Name = "RadioButtonGas95"
        Me.RadioButtonGas95.Size = New System.Drawing.Size(81, 17)
        Me.RadioButtonGas95.TabIndex = 0
        Me.RadioButtonGas95.TabStop = True
        Me.RadioButtonGas95.Text = "Gasolina 95"
        Me.RadioButtonGas95.UseVisualStyleBackColor = True
        '
        'RadioButtonGas98
        '
        Me.RadioButtonGas98.AutoSize = True
        Me.RadioButtonGas98.Location = New System.Drawing.Point(6, 54)
        Me.RadioButtonGas98.Name = "RadioButtonGas98"
        Me.RadioButtonGas98.Size = New System.Drawing.Size(81, 17)
        Me.RadioButtonGas98.TabIndex = 1
        Me.RadioButtonGas98.TabStop = True
        Me.RadioButtonGas98.Text = "Gasolina 98"
        Me.RadioButtonGas98.UseVisualStyleBackColor = True
        '
        'RadioButtonGas
        '
        Me.RadioButtonGas.AutoSize = True
        Me.RadioButtonGas.Location = New System.Drawing.Point(6, 74)
        Me.RadioButtonGas.Name = "RadioButtonGas"
        Me.RadioButtonGas.Size = New System.Drawing.Size(64, 17)
        Me.RadioButtonGas.TabIndex = 2
        Me.RadioButtonGas.TabStop = True
        Me.RadioButtonGas.Text = "Gasóleo"
        Me.RadioButtonGas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonGas98)
        Me.GroupBox1.Controls.Add(Me.RadioButtonGas)
        Me.GroupBox1.Controls.Add(Me.RadioButtonGas95)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 109)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Combustível"
        '
        'ButtonSair
        '
        Me.ButtonSair.Location = New System.Drawing.Point(41, 216)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSair.TabIndex = 4
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = True
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(230, 143)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 5
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'TextBoxAbastecimento
        '
        Me.TextBoxAbastecimento.Location = New System.Drawing.Point(227, 117)
        Me.TextBoxAbastecimento.Name = "TextBoxAbastecimento"
        Me.TextBoxAbastecimento.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAbastecimento.TabIndex = 6
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(227, 195)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotal.TabIndex = 7
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(227, 179)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(70, 13)
        Me.LabelTotal.TabIndex = 8
        Me.LabelTotal.Text = "Total a pagar"
        '
        'LabelAbastecimento
        '
        Me.LabelAbastecimento.AutoSize = True
        Me.LabelAbastecimento.Location = New System.Drawing.Point(227, 98)
        Me.LabelAbastecimento.Name = "LabelAbastecimento"
        Me.LabelAbastecimento.Size = New System.Drawing.Size(80, 13)
        Me.LabelAbastecimento.TabIndex = 9
        Me.LabelAbastecimento.Text = "Abastecimento:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 28)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Gasolineira JG"
        '
        'FormGasolineira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 285)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelAbastecimento)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.TextBoxAbastecimento)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.ButtonSair)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormGasolineira"
        Me.Text = "Gasolineira JG"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButtonGas95 As RadioButton
    Friend WithEvents RadioButtonGas98 As RadioButton
    Friend WithEvents RadioButtonGas As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonSair As Button
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents TextBoxAbastecimento As TextBox
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelAbastecimento As Label
    Friend WithEvents Label3 As Label
End Class
