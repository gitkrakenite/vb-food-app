Imports MySql.Data.MySqlClient
Public Class Form1

    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim del_id As String
    Dim del_name As String
    Dim category As String
    Dim type As String
    Dim price As Integer
    Dim quantity As String
    Dim instructions As String


    Dim Myconnection As String = "server=localhost;uid=root;pwd=;database=food_order"
    Dim da As New MySqlDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim cmd As MySqlCommand
    Dim sql As String


    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Connect()
        Call Populate_ListView()
    End Sub




    Public Sub Populate_ListView()

        Dim sql As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim n As Integer
        Dim i As Integer
        Dim calls As Integer


        sql = "SELECT `del_id`, `del_name`, `category`, `type`, `price`, `discount` FROM `delicacy`"


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

        DelIdTxt.Text = ""
        DelNameTxt.Text = ""
        PriceTxtBox.Text = ""
        QuantityCombobox.Text = ""
        InfoTxtBox.Text = ""

    End Sub



    Private Sub QuantityCombobox_TextChanged(sender As Object, e As EventArgs) Handles QuantityCombobox.TextChanged
        Dim Items As ListView.SelectedListViewItemCollection = Me.ListView1.SelectedItems
        Dim item As ListViewItem


        For Each item In Items
            DelIdTxt.Text = item.SubItems(1).Text
            DelNameTxt.Text = item.SubItems(2).Text
            PriceTxtBox.Text = item.SubItems(5).Text


        Next item


        Dim initial As Integer
        Dim current As Integer
        Dim total As Integer

        initial = PriceTxtBox.Text
        current = QuantityCombobox.Text

        total = initial * current

        totalPrice.Text = total

        'Conv to String
        Dim convToString As String

        convToString = total.ToString()

        TextBox1.Text = convToString + "mr"

        Console.WriteLine(convToString.GetType())



    End Sub


    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim sql As String
        Dim cmd As MySqlCommand





        If (QuantityCombobox.Text = "" Or InfoTxtBox.Text = "") Then
            MsgBox("Some Information is missing. Kindly check. Thank You")

        Else


            sql = "INSERT INTO cart (del_name, price, quantity, instructions) VALUES (@del_name, @price, @quantity, @instructions)"

            'Call Populating()


            cmd = New MySqlCommand(sql, con)
            ''cmd.Parameters.AddWithValue("studentnumber", studentnumber)
            cmd.Parameters.AddWithValue("@del_name", DelNameTxt.Text)
            cmd.Parameters.AddWithValue("@price", TextBox1.Text)
            cmd.Parameters.AddWithValue("@quantity", QuantityCombobox.Text)
            cmd.Parameters.AddWithValue("@instructions", InfoTxtBox.Text)


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Added to cart Succesfully ", vbInformation)
                Call Reset()
                Call Populate_ListView()



            Catch ex As Exception
                'MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub




    Private Sub Populating()

        del_id = DelIdTxt.Text
        del_name = DelNameTxt.Text
        'price = totalPrice.Text
        quantity = QuantityCombobox.Text
        instructions = InfoTxtBox.Text

    End Sub




    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

        sql = "SELECT * FROM delicacy WHERE del_id=" & Val(DelIdTxt.Text)


        cmd = New MySqlCommand(sql, con)

        Dim arrImage() As Byte
        Dim publictable As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(publictable)



            arrImage = publictable.Rows(0).Item(6)

            Dim mstream As New System.IO.MemoryStream(arrImage)

            PictureBox5.Image = Image.FromStream(mstream)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()



        End Try
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim Items As ListView.SelectedListViewItemCollection = Me.ListView1.SelectedItems
        Dim item As ListViewItem


        For Each item In Items
            DelIdTxt.Text = item.SubItems(1).Text
            DelNameTxt.Text = item.SubItems(2).Text
            PriceTxtBox.Text = item.SubItems(5).Text


        Next item
        Call Populate_ListView()


    End Sub



    Private Sub DelIdTxt_TextChanged(sender As Object, e As EventArgs) Handles DelIdTxt.TextChanged
        Dim sql As String

        sql = "SELECT * FROM delicacy WHERE del_id=" & del_id

        Try

            Dim reader As MySqlDataReader
            del_id = DelIdTxt.Text




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





    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Cart.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        About.ShowDialog()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MsgBox("Phone: +254 067 9875, Email: chilltons@gmail.com", vbOKOnly, "Contact Us")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Calculator.ShowDialog()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Help.ShowDialog()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Call Reset()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Call Populate_ListView()
    End Sub

    Private Sub SearchNameTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchNameTxt.TextChanged

        Dim sql As String
        Dim SearchValue As String

        SearchValue = SearchNameTxt.Text



        sql = "SELECT `del_id`, `del_name`, `category`, `type`, `price` FROM `delicacy` WHERE `del_name` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchTypeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchTypeCombo.SelectedIndexChanged
        Dim sql As String
        Dim SearchValue As String

        SearchValue = SearchTypeCombo.Text



        sql = "SELECT `del_id`, `del_name`, `category`, `type`, `price` FROM `delicacy` WHERE `type` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SeacrchCategoryCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SeacrchCategoryCombo.SelectedIndexChanged
        Dim sql As String
        Dim SearchValue As String

        SearchValue = SeacrchCategoryCombo.Text



        sql = "SELECT `del_id`, `del_name`, `category`, `type`, `price` FROM `delicacy` WHERE `category` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
