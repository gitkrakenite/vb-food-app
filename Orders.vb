Imports MySql.Data.MySqlClient
Public Class Orders

    Dim con As New MySql.Data.MySqlClient.MySqlConnection

    Dim del_id As String
    Dim del_name As String
    Dim price As String
    Dim quantity As String
    Dim instructions As String
    Dim cust_name As String
    Dim contact As String
    Dim payment As String
    Dim table_no As String
    Dim status As String


    Dim cmd As MySqlCommand
    Dim sql As String

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call Populate_ListView()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Populate_ListView()
    End Sub

    Public Sub Populate_ListView()

        Dim sql As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim n As Integer
        Dim i As Integer
        Dim calls As Integer


        sql = "SELECT `del_id`, `del_name`, `price`, `quantity`, `instructions`, `cust_name`, `contact`, `table_no`, `payment`, `status`, `date_ordered` FROM `orders`"


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

    Private Sub Reset()

        OrderNoTextBox.Text = ""
        DelNameTxtBox.Text = ""
        PriceTxt.Text = ""
        QuantityTxtBox.Text = ""
        InfoTxt.Text = ""
        CustNametxtBox.Text = ""
        ContaxtTxt.Text = ""
        TableCombo.Text = ""
        PaymentTxt.Text = ""
        statusCombobox.Text = ""


    End Sub

    Private Sub Populating()

        del_id = OrderNoTextBox.Text
        del_name = DelNameTxtBox.Text
        price = PriceTxt.Text
        quantity = QuantityTxtBox.Text
        instructions = InfoTxt.Text
        cust_name = CustNametxtBox.Text
        contact = ContaxtTxt.Text
        table_no = TableCombo.Text
        payment = PaymentTxt.Text
        status = statusCombobox.Text

    End Sub


    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Call Reset()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click

        Dim sql As String
        Dim cmd As MySqlCommand

        del_id = OrderNoTextBox.Text




        sql = "UPDATE orders SET del_id=@del_id, del_name=@del_name, price=@price, quantity=@quantity, instructions=@instructions, cust_name=@cust_name, contact=@contact, table_no=@table_no, payment=@payment, status=@status WHERE del_id=@del_id"


        Call Populating()

        cmd = New MySqlCommand(sql, con)

        cmd.Parameters.AddWithValue("del_id", del_id)
        cmd.Parameters.AddWithValue("@del_name", del_name)
        cmd.Parameters.AddWithValue("@price", price)
        cmd.Parameters.AddWithValue("@quantity", quantity)
        cmd.Parameters.AddWithValue("@instructions", instructions)
        cmd.Parameters.AddWithValue("@cust_name", cust_name)
        cmd.Parameters.AddWithValue("@contact", contact)
        cmd.Parameters.AddWithValue("@table_no", table_no)
        cmd.Parameters.AddWithValue("@payment", payment)
        cmd.Parameters.AddWithValue("@status", status)


        Try
            cmd.ExecuteNonQuery()
            MsgBox("Succesfully updated", vbInformation)
            Call Reset()
            Call Populate_ListView()

        Catch ex As Exception
            MsgBox("Kindly Click again to confirm alteration")
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        Dim sql As String
        Dim cmd As MySqlCommand

        del_id = OrderNoTextBox.Text

        sql = "DELETE FROM orders WHERE del_id=" & del_id





        cmd = New MySqlCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Removed Succesfully", vbInformation)
            Call Populate_ListView()
            Call Reset()



        Catch ex As Exception

            MessageBox.Show("Make sure to select what to delete")

        End Try
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click

        Dim AnswerYes As String
        Dim AnswerNo As String

        AnswerYes = MsgBox("Are you sure ? This will just clear but not delete orders", vbQuestion + vbYesNo, "User Response")




        If (AnswerYes = vbYes) Then

            ListView1.Clear()
            MsgBox("All cleared")
        Else
            MsgBox("Aborted successfully")
        End If



    End Sub

    Private Sub DeleteAllBtn_Click(sender As Object, e As EventArgs) Handles DeleteAllBtn.Click
        Dim sql As String
        Dim cmd As MySqlCommand

        del_id = OrderNoTextBox.Text

        sql = "DELETE * FROM orders "





        cmd = New MySqlCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Deleted All Succesfully", vbInformation)
            Call Populate_ListView()
            Call Reset()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim Items As ListView.SelectedListViewItemCollection = Me.ListView1.SelectedItems
        Dim item As ListViewItem


        For Each item In Items
            OrderNoTextBox.Text = item.SubItems(1).Text
            DelNameTxtBox.Text = item.SubItems(2).Text
            PriceTxt.Text = item.SubItems(3).Text
            QuantityTxtBox.Text = item.SubItems(4).Text
            InfoTxt.Text = item.SubItems(5).Text
            CustNametxtBox.Text = item.SubItems(6).Text
            ContaxtTxt.Text = item.SubItems(7).Text
            TableCombo.Text = item.SubItems(8).Text
            PaymentTxt.Text = item.SubItems(9).Text
            statusCombobox.Text = item.SubItems(10).Text



        Next item

        Call Populate_ListView()

    End Sub

    Private Sub OrderNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles OrderNoTextBox.TextChanged

        Dim sql As String

        sql = "SELECT FROM * orders WHERE del_id=" & del_id


        Try

            Dim reader As MySqlDataReader

            del_id = OrderNoTextBox.Text




            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader

            If reader.HasRows Then
                reader.Read()


            Else

            End If

            reader.Close()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub SearchCustName_TextChanged(sender As Object, e As EventArgs) Handles SearchCustName.TextChanged
        Dim sql As String

        Dim SearchValue As String

        SearchValue = SearchCustName.Text

        sql = "SELECT * FROM `orders` WHERE `cust_name` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchTableNumber_TextChanged(sender As Object, e As EventArgs) Handles SearchTableNumber.TextChanged
        Dim sql As String

        Dim SearchValue As String

        SearchValue = SearchTableNumber.Text

        sql = "SELECT * FROM `orders` WHERE `table_no` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchAction.SelectedIndexChanged

        Dim sql As String

        Dim SearchValue As String

        SearchValue = searchAction.Text

        sql = "SELECT * FROM `orders` WHERE `status` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Orders_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        con.Close()
    End Sub


End Class