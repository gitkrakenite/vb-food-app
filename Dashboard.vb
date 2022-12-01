Imports MySql.Data.MySqlClient


Public Class Dashboard
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

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        DelIDTextBox.Text = ""
        DelNameTxt.Text = ""
        PriceTxtBox.Text = ""
        QuantityCombobox.Text = ""
        InfoTxtBox.Text = ""

    End Sub



    Private Sub QuantityCombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuantityCombobox.SelectedIndexChanged
        Dim Items As ListView.SelectedListViewItemCollection = Me.ListView1.SelectedItems
        Dim item As ListViewItem


        For Each item In Items
            DelIDTextBox.Text = item.SubItems(1).Text
            DelNameTxt.Text = item.SubItems(2).Text
            PriceTxtBox.Text = item.SubItems(5).Text


        Next item


        Dim initial As Integer
        Dim current As Integer
        Dim total As Integer

        initial = PriceTxtBox.Text
        current = QuantityCombobox.Text

        total = initial * current

        'totalPrice.Text = total

        'Conv to String
        Dim convToString As String

        convToString = total.ToString()

        TextBox1.Text = convToString

        Console.WriteLine(convToString.GetType())
    End Sub



    Private Sub SaveBtn_Click(sender As Object, e As EventArgs)
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
        sql = "SELECT * FROM delicacy WHERE del_id=" & Val(DelIDTextBox.Text)


        cmd = New MySqlCommand(sql, con)

        Dim arrImage() As Byte
        Dim publictable As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(publictable)



            arrImage = publictable.Rows(0).Item(6)

            Dim mstream As New System.IO.MemoryStream(arrImage)

            PictureBox1.Image = Image.FromStream(mstream)

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
            DelIDTextBox.Text = item.SubItems(1).Text
            DelNameTxt.Text = item.SubItems(2).Text
            PriceTxtBox.Text = item.SubItems(5).Text


        Next item
        Call Populate_ListView()
    End Sub

    Private Sub DelIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles DelIDTextBox.TextChanged
        Dim sql As String

        sql = "SELECT * FROM delicacy WHERE del_id=" & del_id

        Try

            Dim reader As MySqlDataReader
            del_id = DelIDTextBox.Text




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

    Private Sub AddToLabel_Click(sender As Object, e As EventArgs) Handles AddToLabel.Click
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

    Private Sub viewCartLabel_Click(sender As Object, e As EventArgs) Handles viewCartLabel.Click
        Cart.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Reset()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        About.ShowDialog()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        MsgBox("Phone: 0798556471 or Email: chillton@gmail.com")
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Login.Show()
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

    Private Sub SearchCategoryCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchCategoryCombo.SelectedIndexChanged
        Dim sql As String
        Dim SearchValue As String

        SearchValue = SearchCategoryCombo.Text



        sql = "SELECT `del_id`, `del_name`, `category`, `type`, `price` FROM `delicacy` WHERE `category` like '%" & SearchValue & "%'"

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

    Private Sub Dashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        con.Close()
    End Sub
End Class