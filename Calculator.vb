Public Class Calculator
    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Num3TxtBox.Text = "1"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ProductBtn.Click

        Dim num1, num2, num3, total As Integer


        num1 = Num1Textbox.Text
        num2 = Num2TxtBox.Text
        num3 = Num3TxtBox.Text

        Label3.Text = "x"
        Label4.Text = "x"

        total = num1 * num2 * num3

        Label2.Text = total


    End Sub

    Private Sub SubtractBtn_Click(sender As Object, e As EventArgs) Handles SubtractBtn.Click

        Dim num1, num2, num3, total As Integer

        Num3TxtBox.Text = "0"



        num1 = Num1Textbox.Text
        num2 = Num2TxtBox.Text
        num3 = Num3TxtBox.Text

        Label3.Text = "-"
        Label4.Text = "-"

        total = num1 - num2 - num3

        Label2.Text = total
    End Sub

    Private Sub DivideBtn_Click(sender As Object, e As EventArgs) Handles DivideBtn.Click


        Dim num1, num2, num3, total As Integer

        Num3TxtBox.Text = "1"

        num1 = Num1Textbox.Text
        num2 = Num2TxtBox.Text
        num3 = Num3TxtBox.Text

        Label3.Text = "/"
        Label4.Text = "/"

        total = num1 / num2 / num3

        Label2.Text = total
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim num1, num2, num3, total As Integer

        Num3TxtBox.Text = "0"


        num1 = Num1Textbox.Text
        num2 = Num2TxtBox.Text
        num3 = Num3TxtBox.Text

        Label3.Text = "+"
        Label4.Text = "+"

        total = num1 + num2 + num3

        Label2.Text = total

    End Sub
End Class