Imports MySql.Data.MySqlClient


Public Class Cart
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim del_id As String
    Dim del_name As String
    Dim category As String
    Dim info As String
    Dim cust_name As String
    Dim table_no As String
    Dim contact As String
    Dim payment As String
    Dim quantity As String


    Dim Myconnection As String = "server=localhost;uid=root;pwd=;database=food_order"
    Dim da As New MySqlDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim cmd As MySqlCommand
    Dim sql As String


    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Connect()
        Call Populate_ListView()

        'Call Total()

    End Sub


    Public Sub Total()

        Dim sql As String
        Dim cmd As MySqlCommand

        sql = "INSERT INTO newOrder SELECT * FROM cart"

        cmd = New MySqlCommand(sql, con)

        Try
            cmd.ExecuteNonQuery()
            'MsgBox("Added to Orders Succesfully ", vbInformation)
            Call Reset()
            Call Populate_ListView()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Public Sub Populate_ListView()

        Dim sql As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim n As Integer
        Dim i As Integer
        Dim calls As Integer


        sql = "SELECT `del_id`, `del_name`, `price`, `quantity`, `instructions` FROM `cart`"


        cmd = New MySqlCommand(sql, con)
        reader = cmd.ExecuteReader
        ListView1.Clear()
        n = 0
        calls = reader.FieldCount
        Do While reader.Read
            ListView1.Items.Add(n)
            For i = 0 To calls - 1
                ListView1.Items(n).SubItems.Add(reader(i))

            Next



            n += 1
        Loop
        ' We have set listview properties
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        'set column headers
        ListView1.Columns.Add("SN")



        For i = 0 To calls - 1
            ListView1.Columns.Add(reader.GetName(i))
        Next

        reader.Close()

    End Sub


    Public Sub Connect()
        Dim ConString As String
        ConString = "server=localhost;uid=root;pwd=;database=food_order"

        Try
            con.ConnectionString = ConString
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim total As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        total = num1 + num2

        Label6.Text = "+"

        TotalPriceLabel.Text = total
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim total As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        total = num1 - num2

        Label6.Text = "--"

        TotalPriceLabel.Text = total
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim total As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        total = num1 * num2

        Label6.Text = "X"

        TotalPriceLabel.Text = total
    End Sub


    Private Sub Reset()

        NameTxt.Text = ""
        ContactTxt.Text = ""
        TableCombo.Text = ""
        PaymentCombo.Text = ""


    End Sub



    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click


        Dim sql As String
        Dim cmd As MySqlCommand


        If (NameTxt.Text = "" Or ContactTxt.Text = "" Or TableCombo.Text = "" Or PaymentCombo.Text = "") Then
            MsgBox("Some Information is missing. Kindly check. Thank You")

        Else


            sql = "INSERT INTO orders (del_name, price, quantity, instructions, cust_name, contact, table_no, payment ) VALUES (@del_name, @price, @quantity, @instructions, @cust_name, @contact, @table_no, @payment)"


            cmd = New MySqlCommand(sql, con)
            ''cmd.Parameters.AddWithValue("studentnumber", studentnumber)
            cmd.Parameters.AddWithValue("@del_name", delNameTxt.Text)
            cmd.Parameters.AddWithValue("@price", PriceTxt.Text)
            cmd.Parameters.AddWithValue("@quantity", QuantityTxt.Text)
            cmd.Parameters.AddWithValue("@instructions", instructionsTxt.Text)
            cmd.Parameters.AddWithValue("@cust_name", NameTxt.Text)
            cmd.Parameters.AddWithValue("@contact", ContactTxt.Text)
            cmd.Parameters.AddWithValue("@table_no", TableCombo.Text)
            cmd.Parameters.AddWithValue("@payment", PaymentCombo.Text)




            Try
                cmd.ExecuteNonQuery()
                MsgBox("Order Succesfull", vbInformation)
                Call Reset()
                Me.Close()


                'Call Populate_ListView()



            Catch ex As Exception
                'MessageBox.Show(ex.Message)
            End Try

        End If



    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim Items As ListView.SelectedListViewItemCollection = Me.ListView1.SelectedItems
        Dim item As ListViewItem


        For Each item In Items
            del_idTxt.Text = item.SubItems(1).Text
            delNameTxt.Text = item.SubItems(2).Text
            PriceTxt.Text = item.SubItems(3).Text
            QuantityTxt.Text = item.SubItems(4).Text
            instructionsTxt.Text = item.SubItems(5).Text


        Next item
        Call Populate_ListView()
    End Sub

    Private Sub del_idTxt_TextChanged(sender As Object, e As EventArgs) Handles del_idTxt.TextChanged

        Dim sql As String

        sql = "SELECT * FROM cart WHERE del_id=" & del_id

        Try

            Dim reader As MySqlDataReader
            del_id = del_idTxt.Text




            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()

                'StNoTextBox.Text = reader("student_id")


            Else

            End If
            reader.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click

        Dim sql As String
        Dim cmd As MySqlCommand



        ListView1.Clear()

        Me.Close()





        cmd = New MySqlCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("It's Okay, Take your time", vbInformation)
            Call Populate_ListView()
            Call Reset()



        Catch ex As Exception

            MessageBox.Show("Order not created")

        End Try
    End Sub

    Private Sub Cart_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        con.Close()
    End Sub
End Class