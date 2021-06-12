Public Class Form1

    Dim numero As Integer = 0
    Dim CantNumPos As Integer = 0
    Dim CantNumNeg As Integer = 0
    Dim CantCeros As Integer = 0
    Dim SumNumPos As Integer = 0
    Dim SumaNumNeg As Integer = 0
    Dim CantPares As Integer
    Dim CantImpares As Integer
    Dim resultado As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For i = 1 To 100
            If (Rnd() * 50 > i) Then
                ListBox1.Items.Add(Str(Math.Round(Rnd() * 100, 0)))
            Else
                ListBox1.Items.Add(Str(-Math.Round(Rnd() * 100, 0)))
            End If
        Next i
    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For i As Integer = 0 To 99

            numero = ListBox1.Items(i).ToString()
            If (numero > 0) Then

                CantNumPos += 1
                SumNumPos = SumNumPos + numero
            End If

            If (numero < 0) Then
                CantNumNeg += 1
                SumaNumNeg = SumaNumNeg + numero
            End If

            If (numero = 0) Then
                CantCeros += 1
            End If


            resultado = ListBox1.Items(i).ToString() Mod 2
            If resultado = 0 Then
                CantPares = CantPares + 1
            Else
                CantImpares = CantImpares + 1

            End If

        Next
        txtPos.Text = CantNumPos
        txtNeg.Text = CantNumNeg
        txtCeros.Text = CantCeros
        txtSumaPos.Text = SumNumPos
        txtSumNeg.Text = SumaNumNeg
        txtCantPares.Text = CantPares
        txtCantImp.Text = CantImpares

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtCeros.Text = ""
        txtPos.Text = ""
        txtNeg.Text = ""
        txtSumaPos.Text = ""
        txtSumNeg.Text = ""
        txtCantPares.Text = ""
        txtCantImp.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class
