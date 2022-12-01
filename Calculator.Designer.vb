<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.Num2TxtBox = New System.Windows.Forms.TextBox()
        Me.Num3TxtBox = New System.Windows.Forms.TextBox()
        Me.Num1Textbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.SubtractBtn = New System.Windows.Forms.Button()
        Me.DivideBtn = New System.Windows.Forms.Button()
        Me.ProductBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Num2TxtBox
        '
        Me.Num2TxtBox.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2TxtBox.Location = New System.Drawing.Point(234, 93)
        Me.Num2TxtBox.Name = "Num2TxtBox"
        Me.Num2TxtBox.Size = New System.Drawing.Size(160, 34)
        Me.Num2TxtBox.TabIndex = 0
        '
        'Num3TxtBox
        '
        Me.Num3TxtBox.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num3TxtBox.Location = New System.Drawing.Point(457, 93)
        Me.Num3TxtBox.Name = "Num3TxtBox"
        Me.Num3TxtBox.Size = New System.Drawing.Size(160, 34)
        Me.Num3TxtBox.TabIndex = 1
        '
        'Num1Textbox
        '
        Me.Num1Textbox.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1Textbox.Location = New System.Drawing.Point(9, 88)
        Me.Num1Textbox.Name = "Num1Textbox"
        Me.Num1Textbox.Size = New System.Drawing.Size(157, 34)
        Me.Num1Textbox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(637, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(687, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Answer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(409, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "."
        '
        'AddBtn
        '
        Me.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(614, 189)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(170, 55)
        Me.AddBtn.TabIndex = 7
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'SubtractBtn
        '
        Me.SubtractBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubtractBtn.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtractBtn.Location = New System.Drawing.Point(211, 189)
        Me.SubtractBtn.Name = "SubtractBtn"
        Me.SubtractBtn.Size = New System.Drawing.Size(170, 55)
        Me.SubtractBtn.TabIndex = 8
        Me.SubtractBtn.Text = "Subtract"
        Me.SubtractBtn.UseVisualStyleBackColor = True
        '
        'DivideBtn
        '
        Me.DivideBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DivideBtn.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivideBtn.Location = New System.Drawing.Point(414, 189)
        Me.DivideBtn.Name = "DivideBtn"
        Me.DivideBtn.Size = New System.Drawing.Size(170, 55)
        Me.DivideBtn.TabIndex = 9
        Me.DivideBtn.Text = "Divide"
        Me.DivideBtn.UseVisualStyleBackColor = True
        '
        'ProductBtn
        '
        Me.ProductBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductBtn.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductBtn.Location = New System.Drawing.Point(12, 189)
        Me.ProductBtn.Name = "ProductBtn"
        Me.ProductBtn.Size = New System.Drawing.Size(170, 55)
        Me.ProductBtn.TabIndex = 10
        Me.ProductBtn.Text = "Product"
        Me.ProductBtn.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 287)
        Me.Controls.Add(Me.ProductBtn)
        Me.Controls.Add(Me.DivideBtn)
        Me.Controls.Add(Me.SubtractBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Num1Textbox)
        Me.Controls.Add(Me.Num3TxtBox)
        Me.Controls.Add(Me.Num2TxtBox)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Num2TxtBox As TextBox
    Friend WithEvents Num3TxtBox As TextBox
    Friend WithEvents Num1Textbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AddBtn As Button
    Friend WithEvents SubtractBtn As Button
    Friend WithEvents DivideBtn As Button
    Friend WithEvents ProductBtn As Button
End Class
