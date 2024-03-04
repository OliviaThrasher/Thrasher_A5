'Olivia Thrasher
'Assignment A5
'GUI Development Class
Public Class Form1
    'decGroup is here so it can be a global variable
    Dim decGroup As Double
    'When the form loads, it clears everything
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextCost.Clear()
        TextGroupSize.Clear()
        Radio1Super.Select()
        TextGroupSize.Focus()
    End Sub
    '1 If statement for white space and 3 If statements for Less than 1 and more than 20 errors
    Private Sub TextGroupSize_TextChanged(sender As Object, e As EventArgs) Handles TextGroupSize.TextChanged
        Dim strGroup As String = TextGroupSize.Text
        If Not String.IsNullOrWhiteSpace(TextGroupSize.Text) Then
            If IsNumeric(strGroup) Then
                If Not strGroup < 1 Then
                    If Not strGroup > 20 Then
                        decGroup = Convert.ToDouble(strGroup)
                    Else
                        MsgBox("Enter a valid group number less than 20", MsgBoxStyle.DefaultButton2, "Group Number Error")
                        TextGroupSize.Clear()
                        TextGroupSize.Focus()
                    End If
                Else
                    MsgBox("Enter a positive number.", MsgBoxStyle.DefaultButton1, "Negative Number Error")
                    TextGroupSize.Clear()
                    TextGroupSize.Focus()
                End If
            Else
                MsgBox("Enter Valid Number.", MsgBoxStyle.DefaultButton1, "Valid Number Error")
                TextGroupSize.Clear()
                TextGroupSize.Focus()
            End If
        End If


    End Sub
    'This makes the caluclation based on which button is picked.
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim ConSuper As Double = 380
        Dim ConAuto As Double = 275
        Dim ConReg As Double = 209
        Dim numCost As Double

        If Radio1Super.Checked = True Then
            numCost = ConSuper * decGroup
            TextCost.Text = numCost.ToString("C2")

        ElseIf Radio2Auto.Checked = True Then
            numCost = ConAuto * decGroup
            TextCost.Text = numCost.ToString("C2")

        ElseIf Radio3Reg.Checked = True Then
            numCost = ConReg * decGroup
            TextCost.Text = numCost.ToString("C2")

        Else
            MsgBox("Please select a badge.", MsgBoxStyle.Information, "Badge Selection Error")

        End If

    End Sub
    'Clears Everything
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextCost.Clear()
        TextGroupSize.Clear()
        Radio1Super.Select()
        TextGroupSize.Focus()
    End Sub

End Class
