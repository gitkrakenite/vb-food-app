<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PaymentCombo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalPriceLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.ContactTxt = New System.Windows.Forms.TextBox()
        Me.CreateBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.TableCombo = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.del_idTxt = New System.Windows.Forms.TextBox()
        Me.QuantityTxt = New System.Windows.Forms.TextBox()
        Me.delNameTxt = New System.Windows.Forms.TextBox()
        Me.PriceTxt = New System.Windows.Forms.TextBox()
        Me.instructionsTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListView1.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.LabelEdit = True
        Me.ListView1.Location = New System.Drawing.Point(12, 73)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(557, 373)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'PaymentCombo
        '
        Me.PaymentCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentCombo.FormattingEnabled = True
        Me.PaymentCombo.Items.AddRange(New Object() {"Cash", "M-Pesa"})
        Me.PaymentCombo.Location = New System.Drawing.Point(1278, 329)
        Me.PaymentCombo.Name = "PaymentCombo"
        Me.PaymentCombo.Size = New System.Drawing.Size(160, 33)
        Me.PaymentCombo.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1109, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total Price"
        '
        'TotalPriceLabel
        '
        Me.TotalPriceLabel.AutoSize = True
        Me.TotalPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceLabel.Location = New System.Drawing.Point(1389, 269)
        Me.TotalPriceLabel.Name = "TotalPriceLabel"
        Me.TotalPriceLabel.Size = New System.Drawing.Size(23, 25)
        Me.TotalPriceLabel.TabIndex = 7
        Me.TotalPriceLabel.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1101, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Payment Option"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(209, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Your Delicacy Choices"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1278, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Ksh."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(596, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 25)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Shipping Details"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(575, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 25)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Full Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(576, 182)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(168, 25)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Contact Number"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(575, 260)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 25)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Table Number"
        '
        'NameTxt
        '
        Me.NameTxt.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.Location = New System.Drawing.Point(791, 112)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(259, 31)
        Me.NameTxt.TabIndex = 18
        '
        'ContactTxt
        '
        Me.ContactTxt.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTxt.Location = New System.Drawing.Point(791, 180)
        Me.ContactTxt.Name = "ContactTxt"
        Me.ContactTxt.Size = New System.Drawing.Size(259, 31)
        Me.ContactTxt.TabIndex = 19
        '
        'CreateBtn
        '
        Me.CreateBtn.BackColor = System.Drawing.Color.Teal
        Me.CreateBtn.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateBtn.Location = New System.Drawing.Point(1059, 389)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(178, 48)
        Me.CreateBtn.TabIndex = 21
        Me.CreateBtn.Text = "Create Order"
        Me.CreateBtn.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.Teal
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(1283, 389)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(178, 48)
        Me.CancelBtn.TabIndex = 22
        Me.CancelBtn.Text = "Cancel Order"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'TableCombo
        '
        Me.TableCombo.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableCombo.FormattingEnabled = True
        Me.TableCombo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.TableCombo.Location = New System.Drawing.Point(791, 259)
        Me.TableCombo.Name = "TableCombo"
        Me.TableCombo.Size = New System.Drawing.Size(259, 35)
        Me.TableCombo.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1116, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 30)
        Me.TextBox1.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1237, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(74, 30)
        Me.TextBox2.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(998, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Here you can add the prices"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1195, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 27)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Subtract"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1340, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 27)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Product"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1101, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 27)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Add"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1202, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 25)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "."
        '
        'del_idTxt
        '
        Me.del_idTxt.BackColor = System.Drawing.Color.White
        Me.del_idTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.del_idTxt.Enabled = False
        Me.del_idTxt.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del_idTxt.Location = New System.Drawing.Point(599, 344)
        Me.del_idTxt.Name = "del_idTxt"
        Me.del_idTxt.ReadOnly = True
        Me.del_idTxt.Size = New System.Drawing.Size(91, 24)
        Me.del_idTxt.TabIndex = 31
        '
        'QuantityTxt
        '
        Me.QuantityTxt.BackColor = System.Drawing.Color.White
        Me.QuantityTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QuantityTxt.Enabled = False
        Me.QuantityTxt.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTxt.Location = New System.Drawing.Point(938, 345)
        Me.QuantityTxt.Name = "QuantityTxt"
        Me.QuantityTxt.ReadOnly = True
        Me.QuantityTxt.Size = New System.Drawing.Size(93, 24)
        Me.QuantityTxt.TabIndex = 32
        '
        'delNameTxt
        '
        Me.delNameTxt.BackColor = System.Drawing.Color.White
        Me.delNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.delNameTxt.Enabled = False
        Me.delNameTxt.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delNameTxt.Location = New System.Drawing.Point(697, 322)
        Me.delNameTxt.Multiline = True
        Me.delNameTxt.Name = "delNameTxt"
        Me.delNameTxt.ReadOnly = True
        Me.delNameTxt.Size = New System.Drawing.Size(127, 47)
        Me.delNameTxt.TabIndex = 33
        '
        'PriceTxt
        '
        Me.PriceTxt.BackColor = System.Drawing.Color.White
        Me.PriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PriceTxt.Enabled = False
        Me.PriceTxt.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTxt.Location = New System.Drawing.Point(830, 344)
        Me.PriceTxt.Name = "PriceTxt"
        Me.PriceTxt.ReadOnly = True
        Me.PriceTxt.Size = New System.Drawing.Size(90, 24)
        Me.PriceTxt.TabIndex = 34
        '
        'instructionsTxt
        '
        Me.instructionsTxt.BackColor = System.Drawing.Color.White
        Me.instructionsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.instructionsTxt.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionsTxt.Location = New System.Drawing.Point(702, 391)
        Me.instructionsTxt.Multiline = True
        Me.instructionsTxt.Name = "instructionsTxt"
        Me.instructionsTxt.Size = New System.Drawing.Size(277, 48)
        Me.instructionsTxt.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(593, 404)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 25)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Edit Info"
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1473, 458)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.instructionsTxt)
        Me.Controls.Add(Me.PriceTxt)
        Me.Controls.Add(Me.delNameTxt)
        Me.Controls.Add(Me.QuantityTxt)
        Me.Controls.Add(Me.del_idTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TableCombo)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.CreateBtn)
        Me.Controls.Add(Me.ContactTxt)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TotalPriceLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PaymentCombo)
        Me.Controls.Add(Me.ListView1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Cart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents PaymentCombo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents ContactTxt As TextBox
    Friend WithEvents CreateBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents TableCombo As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents del_idTxt As TextBox
    Friend WithEvents QuantityTxt As TextBox
    Friend WithEvents delNameTxt As TextBox
    Friend WithEvents PriceTxt As TextBox
    Friend WithEvents instructionsTxt As TextBox
    Friend WithEvents Label9 As Label
End Class
