<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Register))
        Label1 = New Label()
        Panel1 = New Panel()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Button2 = New Button()
        LinkLabel1 = New LinkLabel()
        TextBox8 = New TextBox()
        Label10 = New Label()
        TextBox7 = New TextBox()
        Label9 = New Label()
        Button1 = New Button()
        TextBox6 = New TextBox()
        Label8 = New Label()
        TextBox5 = New TextBox()
        Label7 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(73, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(386, 84)
        Label1.TabIndex = 0
        Label1.Text = "NS Computers"' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(TextBox8)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(73, 199)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(612, 593)
        Panel1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Lucida Sans Unicode", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(57, 495)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(246, 40)
        TextBox2.TabIndex = 21
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.OrangeRed
        Label4.Location = New Point(57, 464)
        Label4.Name = "Label4"
        Label4.Size = New Size(205, 28)
        Label4.TabIndex = 20
        Label4.Text = "*Confirm Password"' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(575, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(37, 37)
        Button2.TabIndex = 19
        Button2.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.Aqua
        LinkLabel1.Location = New Point(43, 548)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(271, 24)
        LinkLabel1.TabIndex = 18
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Already a User? Login Here"' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Lucida Sans Unicode", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox8.Location = New Point(57, 415)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(246, 40)
        TextBox8.TabIndex = 17
        TextBox8.UseSystemPasswordChar = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.OrangeRed
        Label10.Location = New Point(57, 384)
        Label10.Name = "Label10"
        Label10.Size = New Size(190, 28)
        Label10.TabIndex = 16
        Label10.Text = "*Create Password"' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Lucida Sans Unicode", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox7.Location = New Point(57, 341)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(246, 40)
        TextBox7.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.OrangeRed
        Label9.Location = New Point(57, 314)
        Label9.Name = "Label9"
        Label9.Size = New Size(125, 28)
        Label9.TabIndex = 14
        Label9.Text = "*Username"' 
        ' Button1
        ' 
        Button1.BackColor = Color.OrangeRed
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(386, 416)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 36)
        Button1.TabIndex = 13
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox6.Location = New Point(57, 174)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(487, 35)
        TextBox6.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.OrangeRed
        Label8.Location = New Point(57, 143)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 28)
        Label8.TabIndex = 11
        Label8.Text = "*Email"' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.Location = New Point(57, 261)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(487, 35)
        TextBox5.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.OrangeRed
        Label7.Location = New Point(57, 230)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 28)
        Label7.TabIndex = 9
        Label7.Text = "*Address"' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(320, 94)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(224, 35)
        TextBox4.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.OrangeRed
        Label6.Location = New Point(320, 63)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 28)
        Label6.TabIndex = 7
        Label6.Text = "*Last Name"' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(57, 94)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(246, 35)
        TextBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.OrangeRed
        Label3.Location = New Point(57, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 28)
        Label3.TabIndex = 1
        Label3.Text = "*First Name"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(19, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 37)
        Label2.TabIndex = 0
        Label2.Text = "User Registration"' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1924, 1061)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "Register"
        StartPosition = FormStartPosition.CenterParent
        Text = "Register"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
End Class
