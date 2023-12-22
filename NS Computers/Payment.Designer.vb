<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Payment))
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Label4 = New Label()
        TextBox5 = New TextBox()
        DataGridView2 = New DataGridView()
        Panel2 = New Panel()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        TextBox6 = New TextBox()
        TextBox4 = New TextBox()
        Label3 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Button2 = New Button()
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Button3 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Button4 = New Button()
        LinkLabel1 = New LinkLabel()
        Button5 = New Button()
        Label7 = New Label()
        Button6 = New Button()
        TextBox7 = New TextBox()
        Button7 = New Button()
        Panel3 = New Panel()
        Button8 = New Button()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.MidnightBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(98, 157)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(600, 599)
        DataGridView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.PowderBlue
        Button1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(544, 775)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 45)
        Button1.TabIndex = 1
        Button1.Text = "Remove Item"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(544, 711)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(136, 29)
        TextBox1.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.GhostWhite
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(DataGridView2)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(942, 157)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(826, 599)
        Panel1.TabIndex = 3
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans Unicode", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.ForestGreen
        Label11.Location = New Point(592, 542)
        Label11.Name = "Label11"
        Label11.Size = New Size(197, 42)
        Label11.TabIndex = 17
        Label11.Text = "Bill Invoice"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Sans Unicode", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(422, 38)
        Label10.Name = "Label10"
        Label10.Size = New Size(222, 42)
        Label10.TabIndex = 16
        Label10.Text = "Your Orders"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(503, 497)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 30)
        Label4.TabIndex = 10
        Label4.Text = "Total Price"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(633, 497)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(156, 29)
        TextBox5.TabIndex = 4
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(408, 102)
        DataGridView2.MultiSelect = False
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(381, 377)
        DataGridView2.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Lavender
        Panel2.Controls.Add(RadioButton2)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Location = New Point(12, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(381, 495)
        Panel2.TabIndex = 15
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.FlatStyle = FlatStyle.Popup
        RadioButton2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton2.Location = New Point(31, 445)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(171, 29)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.Text = "Cash on delivery"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.FlatStyle = FlatStyle.Popup
        RadioButton1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton1.Location = New Point(236, 445)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(121, 29)
        RadioButton1.TabIndex = 15
        RadioButton1.TabStop = True
        RadioButton1.Text = "Debit Card"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox6.Location = New Point(194, 140)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(184, 35)
        TextBox6.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(11, 299)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(366, 125)
        TextBox4.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(11, 266)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 30)
        Label3.TabIndex = 9
        Label3.Text = "Shipping Address"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(185, 107)
        Label8.Name = "Label8"
        Label8.Size = New Size(166, 30)
        Label8.TabIndex = 12
        Label8.Text = "Reciptent Name"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Unicode", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(9, 43)
        Label9.Name = "Label9"
        Label9.Size = New Size(293, 42)
        Label9.TabIndex = 14
        Label9.Text = "Shipping Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(9, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 30)
        Label2.TabIndex = 7
        Label2.Text = "E-Mail"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(9, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 30)
        Label1.TabIndex = 5
        Label1.Text = "Enter Username"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(9, 211)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(366, 35)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(15, 140)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(176, 35)
        TextBox2.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Chartreuse
        Button2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(1262, 773)
        Button2.Name = "Button2"
        Button2.Size = New Size(174, 46)
        Button2.TabIndex = 4
        Button2.Text = "Save And Print"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.MediumTurquoise
        Button3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(994, 773)
        Button3.Name = "Button3"
        Button3.Size = New Size(154, 45)
        Button3.TabIndex = 5
        Button3.Text = "Place Order"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Lucida Sans Unicode", 48F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(77, 31)
        Label5.Name = "Label5"
        Label5.Size = New Size(327, 78)
        Label5.TabIndex = 7
        Label5.Text = "Your Cart"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Lucida Sans Unicode", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(931, 66)
        Label6.Name = "Label6"
        Label6.Size = New Size(655, 59)
        Label6.TabIndex = 8
        Label6.Text = "Order and Shipping Deatils"
        ' 
        ' Button4
        ' 
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Location = New Point(1857, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(55, 54)
        Button4.TabIndex = 9
        Button4.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.OrangeRed
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Lucida Sans Unicode", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.ForeColor = Color.OrangeRed
        LinkLabel1.LinkColor = Color.OrangeRed
        LinkLabel1.Location = New Point(1429, 998)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(483, 42)
        LinkLabel1.TabIndex = 10
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Shop More Items Click Here"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LightCoral
        Button5.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(1557, 775)
        Button5.Name = "Button5"
        Button5.Size = New Size(174, 46)
        Button5.TabIndex = 11
        Button5.Text = "Exit"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MidnightBlue
        Label7.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(426, 710)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 30)
        Label7.TabIndex = 12
        Label7.Text = "Total Price"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.CadetBlue
        Button6.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(98, 776)
        Button6.Name = "Button6"
        Button6.Size = New Size(182, 45)
        Button6.TabIndex = 13
        Button6.Text = "User Guidelines"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox7.Location = New Point(98, 827)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(420, 163)
        TextBox7.TabIndex = 14
        ' 
        ' Button7
        ' 
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.FlatStyle = FlatStyle.Popup
        Button7.Location = New Point(491, 827)
        Button7.Name = "Button7"
        Button7.Size = New Size(27, 27)
        Button7.TabIndex = 15
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button8)
        Panel3.Controls.Add(TextBox9)
        Panel3.Controls.Add(TextBox8)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label12)
        Panel3.Location = New Point(994, 773)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(442, 222)
        Panel3.TabIndex = 16
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.MediumTurquoise
        Button8.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.Location = New Point(216, 154)
        Button8.Name = "Button8"
        Button8.Size = New Size(154, 45)
        Button8.TabIndex = 6
        Button8.Text = "Place Order"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox9.Location = New Point(45, 166)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(82, 33)
        TextBox9.TabIndex = 3
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox8.Location = New Point(45, 62)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(325, 33)
        TextBox8.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(45, 119)
        Label13.Name = "Label13"
        Label13.Size = New Size(98, 30)
        Label13.TabIndex = 1
        Label13.Text = "CVC/CVV"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(45, 23)
        Label12.Name = "Label12"
        Label12.Size = New Size(138, 30)
        Label12.TabIndex = 0
        Label12.Text = "Card Number"
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 1061)
        Controls.Add(Panel3)
        Controls.Add(Button7)
        Controls.Add(TextBox7)
        Controls.Add(Button6)
        Controls.Add(Label7)
        Controls.Add(Button5)
        Controls.Add(LinkLabel1)
        Controls.Add(Button4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Payment"
        StartPosition = FormStartPosition.CenterParent
        Text = "Payment"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button8 As Button
End Class
