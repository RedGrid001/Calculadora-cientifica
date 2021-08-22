Public Class FrmCALCULADORA
    Dim INGRESO1 As Double
    Dim INGRESO2 As Double
    Dim PROCESO As String

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles menosButton.Click
        INGRESO1 = Val(TxtResultado.Text)
        PROCESO = "-"
        TxtResultado2.Text = TxtResultado.Text & "-"
        TxtResultado.Clear()
        BtnPunto.Enabled = True
    End Sub

    Private Sub sinButton_Click(sender As Object, e As EventArgs) Handles sinButton.Click
        TxtResultado.Text = Math.Sin(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "   Valor numerico del Seno"
    End Sub

    Private Sub cosButton_Click(sender As Object, e As EventArgs) Handles cosButton.Click
        TxtResultado.Text = Math.Cos(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "   Valor Numerico del Coseno"
    End Sub

    Private Sub tanButton_Click(sender As Object, e As EventArgs) Handles tanButton.Click
        TxtResultado.Text = Math.Tan(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "   Valor Numerico de la tangente"
    End Sub

    Private Sub piButton_Click(sender As Object, e As EventArgs) Handles piButton.Click
        TxtResultado.Text = Math.PI
        TxtResultado2.Text = TxtResultado.Text & "   Valor Numerico de PI"
    End Sub

    Private Sub expButton_Click(sender As Object, e As EventArgs) Handles expButton.Click
        TxtResultado.Text = Math.Exp(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "  Valor Base de €"
    End Sub

    Private Sub cButton_Click(sender As Object, e As EventArgs) Handles cButton.Click
        cButton.Enabled = True
        cButton.Enabled = True
        TxtResultado.Clear()
    End Sub

    Private Sub sumaButton_Click(sender As Object, e As EventArgs) Handles sumaButton.Click
        INGRESO1 = Val(TxtResultado.Text)
        PROCESO = "+"
        TxtResultado2.Text = TxtResultado.Text & "+"
        TxtResultado.Clear()
        BtnPunto.Enabled = True
    End Sub

    Private Sub igualButton_Click(sender As Object, e As EventArgs) Handles igualButton.Click
        BtnPunto.Enabled = True

        INGRESO2 = TxtResultado.Text
        If PROCESO = "+" Then
            TxtResultado.Text = INGRESO1 + INGRESO2
            TxtResultado2.Text = TxtResultado.Text & "   Resultado Numerico"
        Else

            If PROCESO = "-" Then
                TxtResultado.Text = INGRESO1 - INGRESO2
                TxtResultado2.Text = TxtResultado.Text & "   Resultado Numerico"
            Else

                If PROCESO = "*" Then
                    TxtResultado.Text = INGRESO1 * INGRESO2
                    TxtResultado2.Text = TxtResultado.Text & "   Resultado Numerico"
                Else

                    If PROCESO = "/" Then
                        TxtResultado.Text = INGRESO1 / INGRESO2
                        TxtResultado2.Text = TxtResultado.Text & "   Resultado Numerico"
                    Else

                        If PROCESO = "%" Then
                            TxtResultado.Text = INGRESO1 * (INGRESO2 / 100)
                            TxtResultado2.Text = TxtResultado.Text & "   Resultado Numerico"

                        Else
                            If PROCESO = "^" Then
                                TxtResultado.Text = INGRESO1 ^ INGRESO2
                                TxtResultado2.Text = TxtResultado.Text & "   Resultado Numerico"
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        TxtResultado.Text = TxtResultado.Text & 7
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        TxtResultado.Text = TxtResultado.Text & 1
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        TxtResultado.Text = TxtResultado.Text & 2
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        TxtResultado.Text = TxtResultado.Text & 3
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        TxtResultado.Text = TxtResultado.Text & 4
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        TxtResultado.Text = TxtResultado.Text & 5
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        TxtResultado.Text = TxtResultado.Text & 6
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        TxtResultado.Text = TxtResultado.Text & 8
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        TxtResultado.Text = TxtResultado.Text & 9
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        TxtResultado.Text = TxtResultado.Text & 0
    End Sub

    Private Sub BtnPunto_Click(sender As Object, e As EventArgs) Handles BtnPunto.Click
        Me.TxtResultado.Text = TxtResultado.Text & "."
        BtnPunto.Enabled = False
    End Sub

    Private Sub logButton_Click(sender As Object, e As EventArgs) Handles lnButton.Click
        TxtResultado.Text = Math.Log(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "   Valor Numerico de su Logaritmo Natural"
    End Sub

    Private Sub logButton_Click_1(sender As Object, e As EventArgs) Handles logButton.Click
        TxtResultado.Text = Math.Log10(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "   Valor Numerico de su Logaritmo Base 10"
    End Sub

    Private Sub Point()
        Throw New NotImplementedException
    End Sub

    Private Sub porButton_Click(sender As Object, e As EventArgs) Handles porButton.Click
        INGRESO1 = Val(TxtResultado.Text)
        PROCESO = "*"
        TxtResultado.Clear()
        BtnPunto.Enabled = True
    End Sub

    Private Sub entreButton_Click(sender As Object, e As EventArgs) Handles entreButton.Click
        INGRESO1 = Val(TxtResultado.Text)
        PROCESO = "/"
        TxtResultado2.Text = TxtResultado.Text & "/"
        TxtResultado.Clear()
        BtnPunto.Enabled = True
    End Sub

    Private Sub SENINVButton_Click(sender As Object, e As EventArgs) Handles SENINVButton.Click
        TxtResultado.Text = Math.Sinh(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "   SU NUEVO SENO"
    End Sub

    Private Sub CEButton_Click(sender As Object, e As EventArgs) Handles CEButton.Click
        TxtResultado.Clear()
        TxtResultado2.Clear()
        INGRESO1 = 0.0
        INGRESO2 = 0.0
        PROCESO = String.Empty
    End Sub

    Private Sub sqrtButton_Click(sender As Object, e As EventArgs) Handles sqrtButton.Click
        TxtResultado.Text = Math.Sqrt(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "    ES LA NUEVA √"
    End Sub

    Private Sub COSINVButton_Click(sender As Object, e As EventArgs) Handles COSINVButton.Click
        TxtResultado.Text = Math.Cosh(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "   SU NUEVO COSENO"
    End Sub

    Private Sub TANINVButton_Click(sender As Object, e As EventArgs) Handles TANINVButton.Click
        TxtResultado.Text = Math.Tanh(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "   SU NUEVA TANGENTE"
    End Sub


    Private Sub cientoButton_Click_1(sender As Object, e As EventArgs) Handles cientoButton.Click
        INGRESO1 = Val(TxtResultado.Text)
        PROCESO = "%"
        TxtResultado2.Text = TxtResultado.Text & "%"
        TxtResultado.Clear()
        BtnPunto.Enabled = True
    End Sub


    Private Sub EleButton_Click(sender As Object, e As EventArgs) Handles EleButton.Click
        INGRESO1 = Val(TxtResultado.Text)
        PROCESO = "^"
        TxtResultado2.Text = TxtResultado.Text & "^"
        TxtResultado.Clear()
        BtnPunto.Enabled = True
    End Sub

    Private Sub UnixButton_Click(sender As Object, e As EventArgs) Handles UnixButton.Click
        TxtResultado.Text = TxtResultado.Text * (-1)
    End Sub

    Private Sub TxtResultado2_TextChanged(sender As Object, e As EventArgs) Handles TxtResultado2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CuadradoButton_Click(sender As Object, e As EventArgs) Handles CuadradoButton.Click
        TxtResultado.Text = Val(TxtResultado.Text) * Val(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "   SU CUADRADO"
    End Sub

    Private Sub CuboButton_Click(sender As Object, e As EventArgs) Handles CuboButton.Click
        TxtResultado.Text = Val(TxtResultado.Text) * Val(TxtResultado.Text) * Val(TxtResultado.Text)
        TxtResultado2.Text = TxtResultado.Text & "   SU CUBO"
    End Sub

    Private Sub ALADIButton_Click(sender As Object, e As EventArgs)
        TxtResultado.Text = Val(TxtResultado.Text) * 10
        TxtResultado2.Text = TxtResultado.Text & "   SU POTENCIA 10"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DiButton.Click
        TxtResultado.Text = Val(TxtResultado.Text) * 10
        TxtResultado2.Text = TxtResultado.Text & "   SU POTENCIA 10"
    End Sub
End Class
