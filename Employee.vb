Imports MySql.Data.MySqlClient

Public Class Employee
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim emp_id As String
    Dim first_name As String
    Dim last_name As String
    Dim identity As String
    Dim address As String
    Dim category As String
    Dim contact As String
    Dim nhif As String
    Dim gender As String

    Dim conn As New MySqlConnection
    Dim Myconnection As String = "server=localhost;uid=root;pwd=;database=food_order"
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String


    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call Populate_ListView()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Call Populate_ListView()
    End Sub

    Public Sub Populate_ListView()

        Dim sql As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim n As Integer
        Dim i As Integer
        Dim calls As Integer


        sql = "SELECT `employee_id`, `first_name`, `last_name`, `identity`, `address`, `category`, `contact`, `nhif`, `gender`, `date_added` FROM `employee`"


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

        EmpNoTextBox.Text = ""
        FNameTxtBox.Text = ""
        LNameTextBox.Text = ""
        IdentitytxtBox.Text = ""
        AddressTextBox.Text = ""
        EmpCategoryComboBox.Text = ""
        ContactTxtbox.Text = ""
        NhifTextBox.Text = ""
        GenderComboBox.Text = ""


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


        If (FNameTxtBox.Text = "" Or LNameTextBox.Text = "" Or IdentitytxtBox.Text = "" Or AddressTextBox.Text = "" Or EmpCategoryComboBox.Text = "" Or ContactTxtbox.Text = "" Or NhifTextBox.Text = "" Or GenderComboBox.Text = "") Then
            MsgBox("All fields should be filled")

        Else




            sql = "INSERT INTO employee (first_name, last_name, identity, address, category, contact, nhif, gender, picture) VALUES (@first_name, @last_name, @identity, @address, @category, @contact, @nhif, @gender, @picture)"

            Call Populating()


            cmd = New MySqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@first_name", first_name)
            cmd.Parameters.AddWithValue("@last_name", last_name)
            cmd.Parameters.AddWithValue("@identity", identity)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@category", category)
            cmd.Parameters.AddWithValue("@contact", contact)
            cmd.Parameters.AddWithValue("@nhif", nhif)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@picture", arrImage)



            Try
                cmd.ExecuteNonQuery()
                MsgBox("Added Succesfully ", vbInformation)
                Call Reset()
                Call Populate_ListView()

                cmd.Parameters.Clear()
                'con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If


    End Sub

    Private Sub Populating()

        emp_id = EmpNoTextBox.Text
        first_name = FNameTxtBox.Text
        last_name = LNameTextBox.Text
        identity = IdentitytxtBox.Text
        address = AddressTextBox.Text
        category = EmpCategoryComboBox.Text
        contact = ContactTxtbox.Text
        nhif = NhifTextBox.Text
        gender = GenderComboBox.Text

    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click


        Dim sql As String
        Dim cmd As MySqlCommand

        emp_id = EmpNoTextBox.Text


        'sql = "UPDATE gatedetails SET studentnumber=@studentnumber, AdmissionNo=@AdmissionNo, Name=@Name, Destination=@Destination, Device=@Device, Model=@Model, SerialNumber=@SerialNumber, SignIn=@SignIn, TimeOut=@TimeOut, SignOut=@SignOut where studentnumber=@studentnumber"


        sql = "UPDATE employee SET employee_id=@employee_id, first_name=@first_name, last_name=@last_name, identity=@identity, address=@address, category=@category, contact=@contact, nhif=@nhif, gender=@gender, picture=@picture  WHERE employee_id=@employee_id"


        Call Populating()

        cmd = New MySqlCommand(sql, con)

        cmd.Parameters.AddWithValue("employee_id", emp_id)
        cmd.Parameters.AddWithValue("@first_name", first_name)
        cmd.Parameters.AddWithValue("@last_name", last_name)
        cmd.Parameters.AddWithValue("@identity", identity)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@category", category)
        cmd.Parameters.AddWithValue("@contact", contact)
        cmd.Parameters.AddWithValue("@nhif", nhif)
        cmd.Parameters.AddWithValue("@gender", gender)
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
        emp_id = EmpNoTextBox.Text

        sql = "DELETE FROM employee WHERE employee_id=" & emp_id





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


    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        Dim Items As ListView.SelectedListViewItemCollection = Me.ListView1.SelectedItems
        Dim item As ListViewItem


        For Each item In Items
            EmpNoTextBox.Text = item.SubItems(1).Text
            FNameTxtBox.Text = item.SubItems(2).Text
            LNameTextBox.Text = item.SubItems(3).Text
            IdentitytxtBox.Text = item.SubItems(4).Text
            AddressTextBox.Text = item.SubItems(5).Text
            EmpCategoryComboBox.Text = item.SubItems(6).Text
            ContactTxtbox.Text = item.SubItems(7).Text
            NhifTextBox.Text = item.SubItems(8).Text
            GenderComboBox.Text = item.SubItems(9).Text



        Next item

        Call Populate_ListView()
    End Sub



    Private Sub EmpNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmpNoTextBox.TextChanged

        Dim sql As String

        sql = "SELECT FROM employee WHERE employee_id=" & emp_id


        Try

            Dim reader As MySqlDataReader

            emp_id = EmpNoTextBox.Text




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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        'sql = "SELECT * FROM employee WHERE employee_id=" & Val(EmpNoTextBox.Text)

        sql = "SELECT `employee_id`, `first_name`, `last_name`, `identity`, `address`, `category`, `contact`, `nhif`, `gender`, `picture` FROM employee WHERE employee_id=" & Val(EmpNoTextBox.Text)



        cmd = New MySqlCommand(sql, con)

        Dim arrImage() As Byte
        Dim publictable As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(publictable)

            EmpNoTextBox.Text = publictable.Rows(0).Item(0)
            FNameTxtBox.Text = publictable.Rows(0).Item(1)
            LNameTextBox.Text = publictable.Rows(0).Item(2)
            IdentitytxtBox.Text = publictable.Rows(0).Item(3)
            AddressTextBox.Text = publictable.Rows(0).Item(4)
            EmpCategoryComboBox.Text = publictable.Rows(0).Item(5)
            ContactTxtbox.Text = publictable.Rows(0).Item(6)
            NhifTextBox.Text = publictable.Rows(0).Item(7)
            GenderComboBox.Text = publictable.Rows(0).Item(8)

            arrImage = publictable.Rows(0).Item(9)

            Dim mstream As New System.IO.MemoryStream(arrImage)

            PictureBox1.Image = Image.FromStream(mstream)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()



        End Try
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Call Reset()
    End Sub



    Private Sub SearchLastTxtbox_TextChanged(sender As Object, e As EventArgs) Handles SearchLastTxtbox.TextChanged

        Dim sql As String

        Dim SearchValue As String

        SearchValue = SearchLastTxtbox.Text

        sql = "SELECT `employee_id`, `first_name`, `last_name`, `identity`, `address`, `category`, `contact`, `nhif`, `gender`, `date_added` FROM `employee` WHERE `last_name` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub SearchIdentityTxtbox_TextChanged(sender As Object, e As EventArgs) Handles SearchIdentityTxtbox.TextChanged
        Dim sql As String

        Dim SearchValue As String

        SearchValue = SearchIdentityTxtbox.Text

        sql = "SELECT `employee_id`, `first_name`, `last_name`, `identity`, `address`, `category`, `contact`, `nhif`, `gender`, `date_added` FROM `employee` WHERE `identity` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchNhifTxtBox_TextChanged(sender As Object, e As EventArgs) Handles SearchNhifTxtBox.TextChanged
        Dim sql As String

        Dim SearchValue As String

        SearchValue = SearchNhifTxtBox.Text

        sql = "SELECT `employee_id`, `first_name`, `last_name`, `identity`, `address`, `category`, `contact`, `nhif`, `gender`, `date_added` FROM `employee` WHERE `nhif` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchCategoryTxtBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchCategoryTxtBox.SelectedIndexChanged
        Dim sql As String

        Dim SearchValue As String

        SearchValue = SearchCategoryTxtBox.Text

        sql = "SELECT `employee_id`, `first_name`, `last_name`, `identity`, `address`, `category`, `contact`, `nhif`, `gender`, `date_added` FROM `employee` WHERE `category` like '%" & SearchValue & "%'"

        Try
            Call PopulateListView(ListView1, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Employee_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        con.Close()
    End Sub

    Private Sub SaveBtn_MouseEnter(sender As Object, e As EventArgs) Handles SaveBtn.MouseEnter
        SaveBtn.BackColor = Color.Teal
    End Sub

    Private Sub SaveBtn_MouseLeave(sender As Object, e As EventArgs) Handles SaveBtn.MouseLeave
        SaveBtn.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub UpdateBtn_MouseEnter(sender As Object, e As EventArgs) Handles UpdateBtn.MouseEnter
        UpdateBtn.BackColor = Color.Teal
    End Sub

    Private Sub UpdateBtn_MouseLeave(sender As Object, e As EventArgs) Handles UpdateBtn.MouseLeave
        UpdateBtn.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub ResetBtn_MouseEnter(sender As Object, e As EventArgs) Handles ResetBtn.MouseEnter
        ResetBtn.BackColor = Color.Teal
    End Sub

    Private Sub ResetBtn_MouseLeave(sender As Object, e As EventArgs) Handles ResetBtn.MouseLeave
        ResetBtn.BackColor = Color.DarkSlateGray
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