Public Class Login
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

        Dim password As String


        password = AdminPassTxt.Text

        If (password = "" Or password <> "admin123") Then
            MsgBox("Please Enter a valid Password", vbExclamation)
        Else
            Registration.Show()
            AdminPassTxt.Text = ""
            Me.Hide()
        End If




    End Sub


    Private Sub LoginCombo_TextChanged(sender As Object, e As EventArgs) Handles LoginCombo.TextChanged
        Dim choice As String
        choice = LoginCombo.Text

        If (choice = "Employee") Then
            Label2.Visible = True
            Label3.Visible = True
            AdminPassTxt.Visible = True

        ElseIf (choice = "Customer") Then
            Dashboard.Show()
            LoginCombo.Text = ""
            Me.Hide()

            'Me.Close()
            ' Me.Dispose()
        Else
            MsgBox("Not a valid choice", vbRetry)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Label3.Visible = False
        AdminPassTxt.Visible = False
    End Sub

    Private Sub Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Visible = False

    End Sub
End Class