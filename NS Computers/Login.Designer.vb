<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Button1 = New Button()
        Panel1 = New Panel()
        CheckBox1 = New CheckBox()
        Button2 = New Button()
        LinkLabel1 = New LinkLabel()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.OrangeRed
        Button1.Font = New Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(132, 484)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 45)
        Button1.TabIndex = 0
        Button1.Text = "SIGN IN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(212, 213)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(432, 639)
        Panel1.TabIndex = 1
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.ForeColor = SystemColors.ButtonFace
        CheckBox1.Location = New Point(73, 432)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(161, 29)
        CheckBox1.TabIndex = 9
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(393, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(39, 37)
        Button2.TabIndex = 8
        Button2.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.RoyalBlue
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.Aqua
        LinkLabel1.Location = New Point(53, 558)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(331, 30)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Are you a new user? Register Here"' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(53, 383)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(326, 43)
        TextBox2.TabIndex = 6
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(53, 271)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(326, 43)
        TextBox1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(53, 343)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 37)
        Label4.TabIndex = 4
        Label4.Text = "Password"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(53, 231)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 37)
        Label3.TabIndex = 3
        Label3.Text = "Username"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.OrangeRed
        Label2.Location = New Point(73, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(275, 30)
        Label2.TabIndex = 2
        Label2.Text = "Get Your Dream Technology"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(53, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(335, 65)
        Label1.TabIndex = 1
        Label1.Text = "NS Computers"' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 1061)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ControlLightLight
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterParent
        Text = "Login"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
