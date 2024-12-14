Public Class calcul1
    Dim op As Char



    Private Sub button_plus_Click(sender As Object, e As EventArgs) Handles button_plus.Click
        op = "+"

    End Sub

    Private Sub Button_egale_Click(sender As Object, e As EventArgs) Handles Button_egale.Click
        If IsNumeric(Textbox_a.Text) And IsNumeric(TextBox_b.Text) Then
            Dim a = Integer.Parse(Textbox_a.Text)
            Dim b = Integer.Parse(TextBox_b.Text)
            Dim reset As Double
            Dim test = True
            If op = "+" Then
                reset = a + b
            ElseIf op = "-" Then
                reset = a - b
            ElseIf op = "*" Then
                reset = a * b
            ElseIf op = "/" Then
                reset = a / b
                test = False
            Else
                MessageBox.Show("veuillez verifiez si  b!=0 et que vous avez choisit l'operation ")


            End If
            If test Then
                Label_resultat.Text = a.ToString + " " + op + " " + b.ToString + "=" + reset.ToString
            End If

        Else

            MessageBox.Show("a et b doivent etre des entiers")
        End If
    End Sub

    Private Sub Button_moins_Click(sender As Object, e As EventArgs) Handles Button_moins.Click
        op = "-"
    End Sub

    Private Sub Button_fois_Click(sender As Object, e As EventArgs) Handles Button_fois.Click
        op = "*"
    End Sub

    Private Sub Button_sur_Click(sender As Object, e As EventArgs) Handles Button_sur.Click
        op = "/"
    End Sub

    Private Sub Label_resultat_Click(sender As Object, e As EventArgs) Handles Label_resultat.Click

    End Sub
End Class
