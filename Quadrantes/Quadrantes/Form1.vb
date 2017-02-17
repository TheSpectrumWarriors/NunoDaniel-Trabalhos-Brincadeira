Public Class FormQuadrantes

    Dim X, Y As Double

    Private Sub FormQuadrantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1Q.Visible = False
        Label2Q.Visible = False
        Label3Q.Visible = False
        Label4Q.Visible = False

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click

        Label1Q.Visible = False
        Label2Q.Visible = False
        Label3Q.Visible = False
        Label4Q.Visible = False

        TextBoxX.ReadOnly = False
        TextBoxY.ReadOnly = False

        TextBoxX.Text = ""
        TextBoxY.Text = ""
    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click

        X = IsNumeric(TextBoxX.Text)
        Y = IsNumeric(TextBoxY.Text)

        If ((X > 0) And (Y > 0)) Then '1Q

            Label1Q.Visible = True
            Label2Q.Visible = False
            Label3Q.Visible = False
            Label4Q.Visible = False

            TextBoxX.ReadOnly = True
            TextBoxY.ReadOnly = True

        ElseIf ((X < 0) And (Y > 0)) Then '2Q

            Label1Q.Visible = False
            Label2Q.Visible = True
            Label3Q.Visible = False
            Label4Q.Visible = False

            TextBoxX.ReadOnly = True
            TextBoxY.ReadOnly = True

        ElseIf ((X < 0) And (Y < 0)) Then '3Q

            Label1Q.Visible = False
            Label2Q.Visible = False
            Label3Q.Visible = True
            Label4Q.Visible = False

            TextBoxX.ReadOnly = True
            TextBoxY.ReadOnly = True

        ElseIf ((X > 0) And (Y < 0)) Then '4Q

            Label1Q.Visible = False
            Label2Q.Visible = False
            Label3Q.Visible = False
            Label4Q.Visible = True

            TextBoxX.ReadOnly = True
            TextBoxY.ReadOnly = True




            '------------------------------

        ElseIf ((X = 0) And (Y = 0)) Then ' 0,0


            Label1Q.Visible = True
            Label2Q.Visible = True
            Label3Q.Visible = True
            Label4Q.Visible = True

            TextBoxX.ReadOnly = True
            TextBoxY.ReadOnly = True



            '-------------------------

        ElseIf ((X = 0) And (Y > 0)) Then ' oY POSITIVO

            Label1Q.Visible = True
            Label2Q.Visible = True
            Label3Q.Visible = False
            Label4Q.Visible = False

            TextBoxX.ReadOnly = True
            TextBoxY.ReadOnly = True

        ElseIf ((X = 0) And (Y < 0)) Then ' oY NEGATIVO

            Label1Q.Visible = False
            Label2Q.Visible = False
            Label3Q.Visible = True
            Label4Q.Visible = True

            TextBoxX.ReadOnly = True
            TextBoxY.ReadOnly = True

        ElseIf ((Y = 0) And (X > 0)) Then ' oX POSITIVO

            Label1Q.Visible = True
            Label2Q.Visible = False
            Label3Q.Visible = False
            Label4Q.Visible = True

            TextBoxX.ReadOnly = True
            TextBoxY.ReadOnly = True

        ElseIf ((Y = 0) And (X < 0)) Then ' oX NEGATIVO

            Label1Q.Visible = False
            Label2Q.Visible = True
            Label3Q.Visible = True
            Label4Q.Visible = False

            TextBoxX.ReadOnly = True
            TextBoxY.ReadOnly = True

        End If

    End Sub


End Class
