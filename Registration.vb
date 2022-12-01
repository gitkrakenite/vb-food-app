Imports MySql.Data.MySqlClient

Public Class Registration

    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim del_id As String
    Dim del_name As String
    Dim category As String
    Dim type As String
    Dim price As String
    Dim discount As String


    Dim Myconnection As String = "server=localhost;uid=root;pwd=;database=food_order"
    Dim da As New MySqlDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim cmd As MySqlCommand
    Dim sql As String

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call Populate_ListView()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call Populate_ListView()
    End Sub


    Public Sub Populate_ListView()

        Dim sql As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim n As Integer
        Dim i As Integer
        Dim calls As Integer


        sql = "SELECT `del_id`, `del_name`, `category`, `type`, `price`, `discount`, `date_added` FROM `delicacy`"


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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PictureBox1.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub


    Private Sub Reset()

        StNoTextBox.Text = ""
        DelNameTxtBox.Text = ""
        CategoryComboBox.Text = ""
        DelTypeComboBox.Text = ""
        PricetxtBox.Text = ""
        DiscountTxtbox.Text = ""

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        Dim sql As String
        Dim cmd As MySqlCommand



        Dim mstream As New System.IO.MemoryStream()

        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

        arrImage = mstream.GetBuffer()

        Dim FileSize As UInt32

        FileSize = mstream.Length

        mstream.Close()


        If (DelNameTxtBox.Text = "" Or CategoryComboBox.Text = "" Or DelTypeComboBox.Text = "" Or PricetxtBox.Text = "" Or DiscountTxtbox.Text = "") Then
            MsgBox("All fields should be filled")

        Else



            sql = "INSERT INTO delicacy(del_name, category, type, price, discount, picture) VALUES (@del_name, @category, @type, @price, @discount, @picture)"

            Call Populating()


            cmd = New MySqlCommand(sql, con)
            ''cmd.Parameters.AddWithValue("studentnumber", studentnumber)
            cmd.Parameters.AddWithValue("@del_name", del_name)
            cmd.Parameters.AddWithValue("@category", category)
            cmd.Parameters.AddWithValue("@type", type)
            cmd.Parameters.AddWithValue("@price", price)
            cmd.Parameters.AddWithValue("@discount", discount)
            cmd.Parameters.AddWithValue("@picture", arrImage)



            Try
                cmd.ExecuteNonQuery()
                MsgBox("Added Succesfully ", vbInformation)
                Call Reset()
                Call Populate_ListView()

                UpdateBtn.Enabled = True



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If


    End Sub


    Private Sub Populating()

        del_id = StNoTextBox.Text
        del_name = DelNameTxtBox.Text
        category = CategoryComboBox.Text
        type = DelTypeComboBox.Text
        price = PricetxtBox.Text
        discount = DiscountTxtbox.Text

    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim sql As String
        Dim cmd As MySqlCommand

        del_id = StNoTextBox.Text


        'sql = "UPDATE gatedetails SET studentnumber=@studentnumber, AdmissionNo=@AdmissionNo, Name=@Name, Destination=@Destination, Device=@Device, Model=@Model, SerialNumber=@SerialNumber, SignIn=@SignIn, TimeOut=@TimeOut, SignOut=@SignOut where studentnumber=@studentnumber"


        sql = "UPDATE delicacy SET del_id=@del_id, del_name=@del_name, category=@category, type=@type, price=@price, discount=@discount, picture=@picture WHERE del_id=@del_id"


        Call Populating()

        cmd = New MySqlCommand(sql, con)


        cmd.Parameters.AddWithValue("del_id", del_id)
        cmd.Parameters.AddWithValue("@del_name", del_name)
        cmd.Parameters.AddWithValue("@category", category)
        cmd.Parameters.AddWithValue("@type", type)
        cmd.Parameters.AddWithValue("@price", price)
        cmd.Parameters.AddWithValue("@discount", discount)
        cmd.Parameters.AddWithValue("@picture", arrImage)

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
        del_id = StNoTextBox.Text

        sql = "DELETE FROM delicacy WHERE del_id=" & del_id





        cmd = New MySqlCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Removed Succesfully", vbInformation)
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
            StNoTextBox.Text = item.SubItems(1).Text
            DelNameTxtBox.Text = item.SubItems(2).Text
            CategoryComboBox.Text = item.SubItems(3).Text
            DelTypeComboBox.Text = item.SubItems(4).Text
            PricetxtBox.Text = item.SubItems(5).Text
            DiscountTxtbox.Text = item.SubItems(6).Text
        Next item
        Call Populate_ListView()
    End Sub

    Private Sub StNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles StNoTextBox.TextChanged
        Dim sql As String

        sql = "SELECT * FROM delicacy WHERE del_id=" & del_id

        Try

            Dim reader As MySqlDataReader
            del_id = StNoTextBox.Text




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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sql = "SELECT * FROM delicacy WHERE del_id=" & Val(StNoTextBox.Text)


        cmd = New MySqlCommand(sql, con)

        Dim arrImage() As Byte
        Dim publictable As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(publictable)

            StNoTextBox.Text = publictable.Rows(0).Item(0)
            DelNameTxtBox.Text = publictable.Rows(0).Item(1)
            CategoryComboBox.Text = publictable.Rows(0).Item(2)
            DelTypeComboBox.Text = publictable.Rows(0).Item(3)
            PricetxtBox.Text = publictable.Rows(0).Item(4)
            DiscountTxtbox.Text = publictable.Rows(0).Item(5)


            arrImage = publictable.Rows(0).Item(6)

            Dim mstream As New System.IO.MemoryStream(arrImage)

            PictureBox1.Image = Image.FromStream(mstream)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()



        End Try
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub SearchADMNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchNameTextBox.TextChanged
        Dim sql As String
        Dim SearchValue As String

        SearchValue = SearchNameTextBox.Text



        sql = "SELECT `del_id`, `del_name`, `category`, `type`, `price`, `discount`, `date_added` FROM `delicacy` WHERE `del_name` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim sql As String
        Dim SearchValue As String

        SearchValue = ComboBox1.Text



        sql = "SELECT `del_id`, `del_name`, `category`, `type`, `price`, `discount`, `date_added` FROM `delicacy` WHERE `category` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Registration_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        con.Close()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Call Reset()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Employee.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Orders.ShowDialog()
    End Sub

    Private Sub Registration_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        con.Close()
    End Sub

    Private Sub ExitBtn_MouseEnter(sender As Object, e As EventArgs) Handles ExitBtn.MouseEnter
        ExitBtn.BackColor = Color.Black
        ExitBtn.ForeColor = Color.Red
    End Sub

    Private Sub ExitBtn_MouseLeave(sender As Object, e As EventArgs) Handles ExitBtn.MouseLeave
        ExitBtn.BackColor = Color.DarkSlateGray
        ExitBtn.ForeColor = Color.White
    End Sub

    Private Sub DeleteBtn_MouseEnter(sender As Object, e As EventArgs) Handles DeleteBtn.MouseEnter
        DeleteBtn.BackColor = Color.Black
        DeleteBtn.ForeColor = Color.Red
    End Sub

    Private Sub DeleteBtn_MouseLeave(sender As Object, e As EventArgs) Handles DeleteBtn.MouseLeave
        DeleteBtn.BackColor = Color.Teal
        DeleteBtn.ForeColor = Color.White
    End Sub
End Class