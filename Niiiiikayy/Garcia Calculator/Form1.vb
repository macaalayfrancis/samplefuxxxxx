Public Class Form1
    Dim fOpe, sOpe, result As Double
    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        input()
        result = fOpe - sOpe
        txtResult.Text = result
        txtOperator.Text = btnSub.Text
    End Sub

    Private Sub btnInt_Click(sender As Object, e As EventArgs) Handles btnInt.Click
        input()
        If sOpe = 0 Then
            txtResult.Text = "Div by Zero"
        Else
            result = fOpe \ sOpe
            txtResult.Text = result
            txtOperator.Text = btnInt.Text
        End If
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        input()
        If sOpe = 0 Then
            txtResult.Text = "Div by Zero"
        Else
            result = fOpe / sOpe
            txtResult.Text = result
            txtOperator.Text = btnDiv.Text
        End If
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        input()
        result = fOpe + sOpe
        txtResult.Text = result
        txtOperator.Text = btnAdd.Text
    End Sub

    Sub input()
        fOpe = Val(txtFirstOperand.Text)
        sOpe = Val(txtSecondOperand.Text)
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        input()
        result = fOpe ^ sOpe
        txtResult.Text = result
        txtOperator.Text = btnExp.Text
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        input()
        result = fOpe Mod sOpe
        txtResult.Text = result
        txtOperator.Text = btnMod.Text
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        input()
        result = fOpe * sOpe
        txtResult.Text = result
        txtOperator.Text = btnMul.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.AppStat = "Trial Version" Then

            If My.Settings.LoadCount < 0 Then
                Form2.ShowDialog()
            End If

            Me.Text = My.Settings.AppStat & " : Counter =>" & My.Settings.LoadCount
            My.Settings.LoadCount -= 1
            My.Settings.Save()
        Else
            Me.Text = My.Settings.AppStat
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstOperand.Clear()
        txtSecondOperand.Clear()
        txtOperator.Clear()
        txtResult.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
