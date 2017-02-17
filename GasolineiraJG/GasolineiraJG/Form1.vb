Public Class FormGasolineira

    Dim Gas, Gas95, Gas98, preco, valor As Double


    Private Sub FormGasolineira_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Gas95 = IsNumeric(InputBox("Qual o preço da Gasolina 95?"))
        Gas98 = IsNumeric(InputBox("Qual o preço da Gasolina 98?"))
        Gas = IsNumeric(InputBox("Qual o preço do Gasóleo?"))

        RadioButtonGas95.Checked = True


        TextBoxAbastecimento.Text = "0 L"





    End Sub

    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click

        Sair()



    End Sub



    Private Sub TextBoxAbastecimento_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxAbastecimento.KeyDown
        If e.KeyCode = Keys.Enter Then

            ButtonCalcular.PerformClick()

        End If
    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click


        If (RadioButtonGas95.Checked = True) Then
            preco = Gas95

            Calcular()

        ElseIf (RadioButtonGas98.Checked = True) Then
            preco = Gas98

            Calcular()

        ElseIf (RadioButtonGas.Checked = True) Then
            preco = Gas

            Calcular()

        End If


    End Sub


    Private Sub Calcular()

        valor = preco * TextBoxAbastecimento.Text


        TextBoxTotal.Text = valor

        TextBoxAbastecimento.Focus()


    End Sub


    Public Sub Sair()

        If MsgBox("Quer mesmo sair?", vbYesNo + vbQuestion, "Atenção!") = vbYes Then
            End
        End If



    End Sub





End Class
