Imports System.IO

Public Class Form1

    Const filenameSave As String = "history.txt"
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim intermediary As Double
        Dim strFrom As String
        Dim strTo As String

        If RadioButtonInputTonnes.Checked Then
            intermediary = Convert.ToDouble(TextBoxInput.Text) * 1000 * 1000
            strFrom = "Tonnes"
        End If
        If RadioButtonInputKilos.Checked Then
            intermediary = Convert.ToDouble(TextBoxInput.Text) * 1000
            strFrom = "Kilograms"
        End If
        If RadioButtonInputGrams.Checked Then
            intermediary = Convert.ToDouble(TextBoxInput.Text)
            strFrom = "Grams"
        End If
        If RadioButtonInputPounds.Checked Then
            intermediary = Convert.ToDouble(TextBoxInput.Text) * 453.5924
            strFrom = "Pounds"
        End If
        If RadioButtonInputOunces.Checked Then
            intermediary = Convert.ToDouble(TextBoxInput.Text) * 16
            strFrom = "Ounces"
        End If
        If RadioButtonInputCarats.Checked Then
            intermediary = Convert.ToDouble(TextBoxInput.Text) * 2267.962
            strFrom = "Carats"
        End If



        If RadioButtonOutputTonnes.Checked Then
            TextBoxOutputs.Text = intermediary / 1000 / 1000
            strTo = "Tonnes"
        End If
        If RadioButtonOutputKilos.Checked Then
            TextBoxOutputs.Text = intermediary / 1000
            strTo = "Kilograms"
        End If
        If RadioButtonOutputGrams.Checked Then
            TextBoxOutputs.Text = intermediary
            strTo = "Grams"
        End If
        If RadioButtonOutputPounds.Checked Then
            TextBoxOutputs.Text = intermediary / 453.5924
            strTo = "Pounds"
        End If
        If RadioButtonOutputOunces.Checked Then
            TextBoxOutputs.Text = intermediary / 16
            strTo = "Ounces"
        End If
        If RadioButtonOutputCarats.Checked Then
            TextBoxOutputs.Text = intermediary / 2267.962
            strTo = "Carats"
        End If

        File.AppendAllText(filenameSave, "From " + TextBoxInput.Text + " " + strFrom + " to " + TextBoxOutputs.Text + " " + strTo + vbNewLine)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
