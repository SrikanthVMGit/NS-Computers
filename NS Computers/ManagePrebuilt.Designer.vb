<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagePrebuilt
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ManagePrebuilt))
        Label1 = New Label()
        Button7 = New Button()
        Panel1 = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(396, 186)
        Label1.Name = "Label1"
        Label1.Size = New Size(1070, 84)
        Label1.TabIndex = 9
        Label1.Text = "Manage PC Parts and Peripherals For Sale"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.WhiteSmoke
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.FlatStyle = FlatStyle.Popup
        Button7.Location = New Point(1857, 12)
        Button7.Name = "Button7"
        Button7.Size = New Size(55, 55)
        Button7.TabIndex = 8
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(1128, 305)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(248, 537)
        Panel1.TabIndex = 7
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Peru
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.ForeColor = Color.WhiteSmoke
        Button6.Location = New Point(23, 445)
        Button6.Name = "Button6"
        Button6.Size = New Size(205, 47)
        Button6.TabIndex = 6
        Button6.Text = "Logout"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Peru
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = Color.WhiteSmoke
        Button5.Location = New Point(23, 365)
        Button5.Name = "Button5"
        Button5.Size = New Size(205, 47)
        Button5.TabIndex = 5
        Button5.Text = "View Feedbacks"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Peru
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.WhiteSmoke
        Button4.Location = New Point(23, 284)
        Button4.Name = "Button4"
        Button4.Size = New Size(205, 47)
        Button4.TabIndex = 4
        Button4.Text = "View Orders"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Peru
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.WhiteSmoke
        Button3.Location = New Point(23, 202)
        Button3.Name = "Button3"
        Button3.Size = New Size(205, 47)
        Button3.TabIndex = 3
        Button3.Text = "Manage PreBuilt"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Peru
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Location = New Point(23, 39)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 47)
        Button1.TabIndex = 1
        Button1.Text = "Edit Products"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Peru
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.WhiteSmoke
        Button2.Location = New Point(23, 117)
        Button2.Name = "Button2"
        Button2.Size = New Size(205, 47)
        Button2.TabIndex = 2
        Button2.Text = "Update Products"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.Coral
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.ActiveCaptionText
        DataGridView1.Location = New Point(481, 305)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(641, 537)
        DataGridView1.TabIndex = 6
        ' 
        ' ManagePrebuilt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1940, 1100)
        Controls.Add(Label1)
        Controls.Add(Button7)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ManagePrebuilt"
        Text = "ManagePrebuilt"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
