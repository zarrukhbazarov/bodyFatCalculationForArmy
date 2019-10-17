'Author: Zarrukh Bazarov
'Date: 10/16/2019
Option Strict On
Public Class Form1

    Dim age As Int32
    Dim waist As Double
    Dim neck As Double
    Dim height As Double
    Dim hip As Double

    Dim malesCalc As Double
    Dim femalesCalc As Double

    Private Function IsNotEmpty(textBox As TextBox, name As String) As Boolean
        If textBox.Text = "" Then
            MessageBox.Show(name & " cannot be empty. Please input " & name & " and try again.", "Entry Error")
            textBox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    Private Function isInteger(textBox As TextBox, name As String) As Boolean
        Dim number As Int32 = 0
        If Int32.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(name & " must be an integer. Please input integer for " & name & ".", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function


    Private Function IsDecimal(textBox As TextBox, name As String) As Boolean
        Dim number As Decimal = 0
        If Decimal.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(name & " must be a decimal value. Please input decimal for " & name & ".", "Entry Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function


    Private Function isWithinRange(textBox As TextBox, name As String, min As Decimal, max As Decimal) As Boolean
        Dim number As Decimal = Convert.ToDecimal(textBox.Text)
        If number < min OrElse number > max Then
            MessageBox.Show(name & " must be between " & min & " and " & max & ".", "Entry Error ")
            textBox.Select()
            textBox.SelectAll()
            Return False
        Else
            Return True
        End If
    End Function

    Private Function isValidDataMale() As Boolean
        Return _
        IsNotEmpty(ageTextBox, "Age") AndAlso
        isInteger(ageTextBox, "Age") AndAlso
        isWithinRange(ageTextBox, "Age", 17, 80) AndAlso
        IsNotEmpty(waistTextBox, "Waist") AndAlso
        IsDecimal(waistTextBox, "Waist") AndAlso
        isWithinRange(waistTextBox, "Waist", 0, 40) AndAlso
        IsNotEmpty(neckTextBox, "Neck") AndAlso
        IsDecimal(neckTextBox, "Neck") AndAlso
        isWithinRange(neckTextBox, "Neck", 0, 20) AndAlso
        IsNotEmpty(heightTextBox, "Height") AndAlso
        IsDecimal(heightTextBox, "Height") AndAlso
        isWithinRange(heightTextBox, "Height", 0, 119)
    End Function

    Private Function isValidDataFemale() As Boolean
        Return _
        IsNotEmpty(ageTextBox, "Age") AndAlso
        isInteger(ageTextBox, "Age") AndAlso
        isWithinRange(ageTextBox, "Age", 17, 80) AndAlso
        IsNotEmpty(waistTextBox, "Waist") AndAlso
        IsDecimal(waistTextBox, "Waist") AndAlso
        isWithinRange(waistTextBox, "Waist", 0, 40) AndAlso
        IsNotEmpty(neckTextBox, "Neck") AndAlso
        IsDecimal(neckTextBox, "Neck") AndAlso
        isWithinRange(neckTextBox, "Neck", 0, 20) AndAlso
        IsNotEmpty(heightTextBox, "Height") AndAlso
        IsDecimal(heightTextBox, "Height") AndAlso
        isWithinRange(heightTextBox, "Height", 0, 119) AndAlso
        IsNotEmpty(hipTextBox, "Hip") AndAlso
        IsDecimal(hipTextBox, "Hip") AndAlso
        isWithinRange(hipTextBox, "Hip", 0, 80)
    End Function

    Private Sub FemaleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles femaleRadioButton.CheckedChanged
        hipLabel.Visible = True
        hipTextBox.Visible = True

    End Sub

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Try
            If isValidDataFemale() Then
                age = Convert.ToInt32(ageTextBox.Text)
                waist = Convert.ToDouble(waistTextBox.Text)
                neck = Convert.ToDouble(neckTextBox.Text)
                height = Convert.ToDouble(heightTextBox.Text)


                If maleRadioButton.Checked = True Then
                    Try
                        If isValidDataMale() Then

                            malesCalc = 86.01 * Math.Log10(waist - neck) - 70.041 * Math.Log10(height) + 36.76
                            bodyPercTextBox.Text() = FormatNumber(malesCalc, 1) + "%"
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Check if all blanks have been filled correctly.", "Entry Error")
                    End Try


                ElseIf femaleRadioButton.Checked = True Then
                    Try
                        If isValidDataFemale() Then
                            hip = Convert.ToDouble(hipTextBox.Text)
                            femalesCalc = 163.205 * Math.Log10(waist + hip + neck) - 97.684 * Math.Log10(height) - 78.387
                            bodyPercTextBox.Text() = FormatNumber(femalesCalc, 1) + "%"
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Check if all blanks have been filled correctly.", "Entry Error")
                    End Try

                End If


                If newbieRadioButton.Checked = True AndAlso maleRadioButton.Checked = True Then
                    If age >= 17 And age <= 20 Then
                        If Math.Round(malesCalc) <= 24 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 21 And age <= 27 Then
                        If Math.Round(malesCalc) <= 26 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 28 And age <= 39 Then
                        If Math.Round(malesCalc) <= 28 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 40 Then
                        If Math.Round(malesCalc) <= 30 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                ElseIf newbieRadioButton.Checked = True AndAlso femaleRadioButton.Checked = True Then
                    If age >= 17 And age <= 20 Then
                        If Math.Round(femalesCalc) <= 30 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 21 And age <= 27 Then
                        If Math.Round(femalesCalc) <= 32 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 28 And age <= 39 Then
                        If Math.Round(femalesCalc) <= 34 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 40 Then
                        If Math.Round(femalesCalc) <= 36 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If


                ElseIf notNewbieRadioButton.Checked = True AndAlso maleRadioButton.Checked = True Then
                    If age >= 17 And age <= 20 Then
                        If Math.Round(malesCalc) <= 20 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 21 And age <= 27 Then
                        If Math.Round(malesCalc) <= 22 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 28 And age <= 39 Then
                        If Math.Round(malesCalc) <= 24 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 40 Then
                        If Math.Round(malesCalc) <= 26 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                ElseIf notNewbieRadioButton.Checked = True AndAlso femaleRadioButton.Checked = True Then
                    If age >= 17 And age <= 20 Then
                        If Math.Round(femalesCalc) <= 28 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 21 And age <= 27 Then
                        If Math.Round(femalesCalc) <= 30 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 28 And age <= 39 Then
                        If Math.Round(femalesCalc) <= 32 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If

                    If age >= 40 Then
                        If Math.Round(femalesCalc) <= 34 Then
                            testTextBox.Text() = "Passed!"
                        Else
                            testTextBox.Text() = "Failed..."
                        End If
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Check if all blanks have been filled correctly.", "Entry Error")
        End Try




    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        maleRadioButton.Checked = False
        femaleRadioButton.Checked = False
        newbieRadioButton.Checked = False
        notNewbieRadioButton.Checked = False
        ageTextBox.Clear()
        waistTextBox.Clear()
        neckTextBox.Clear()
        heightTextBox.Clear()
        hipTextBox.Clear()
        bodyPercTextBox.Clear()
        testTextBox.Clear()

    End Sub



End Class
