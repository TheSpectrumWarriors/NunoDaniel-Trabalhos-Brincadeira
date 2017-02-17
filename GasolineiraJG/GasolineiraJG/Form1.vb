Public Class FormGasolineira

    Dim Gas, Gas95, Gas98 As Double



    Private Sub FormGasolineira_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Gas95 = InputBox("Qual o preço da Gasolina 95?")
        Gas98 = InputBox("Qual o preço da Gasolina 98?")
        Gas = InputBox("Qual o preço do Gasóleo?")

        RadioButtonGas95.Checked = True

    End Sub




End Class
