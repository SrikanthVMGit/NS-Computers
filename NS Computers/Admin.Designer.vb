<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Admin))
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        Label1 = New Label()
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox2 = New PictureBox()
        Button3 = New Button()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(54, 85)
        Button1.Name = "Button1"
        Button1.Size = New Size(586, 327)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.Green
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.GridColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        DataGridView1.Location = New Point(54, 564)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(586, 473)
        DataGridView1.TabIndex = 2
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = Color.Navy
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.GridColor = Color.DeepSkyBlue
        DataGridView2.Location = New Point(1282, 564)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(586, 473)
        DataGridView2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(54, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 64)
        Label1.TabIndex = 4
        Label1.Text = "Manage Products"' 
        ' Button2
        ' 
        Button2.BackColor = Color.Chartreuse
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(1282, 85)
        Button2.Name = "Button2"
        Button2.Size = New Size(586, 327)
        Button2.TabIndex = 5
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(1282, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(417, 64)
        Label2.TabIndex = 6
        Label2.Text = "Manage Prebuilt PCs"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe Print", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(54, 500)
        Label3.Name = "Label3"
        Label3.Size = New Size(425, 61)
        Label3.TabIndex = 7
        Label3.Text = "Recived Orders Details"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe Print", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(1282, 500)
        Label4.Name = "Label4"
        Label4.Size = New Size(376, 61)
        Label4.TabIndex = 8
        Label4.Text = "Customer feedbacks"' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(749, 584)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(425, 392)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe Print", 48F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Orange
        Label5.Location = New Point(706, 85)
        Label5.Name = "Label5"
        Label5.Size = New Size(542, 112)
        Label5.TabIndex = 10
        Label5.Text = "NS Computers "' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.SandyBrown
        Label6.Location = New Point(785, 185)
        Label6.Name = "Label6"
        Label6.Size = New Size(362, 64)
        Label6.TabIndex = 11
        Label6.Text = "Admin dashboard"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.Peru
        Label7.Location = New Point(698, 425)
        Label7.Name = "Label7"
        Label7.Size = New Size(550, 64)
        Label7.TabIndex = 12
        Label7.Text = "Buy your dream technology"' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(814, 252)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(302, 170)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Location = New Point(1871, 9)
        Button3.Name = "Button3"
        Button3.Size = New Size(41, 40)
        Button3.TabIndex = 14
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Gold
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(899, 993)
        Button4.Name = "Button4"
        Button4.Size = New Size(139, 41)
        Button4.TabIndex = 15
        Button4.Text = "Logout"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chocolate
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 1061)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(PictureBox2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        ForeColor = SystemColors.ControlDarkDark
        FormBorderStyle = FormBorderStyle.None
        Name = "Admin"
        StartPosition = FormStartPosition.CenterParent
        Text = "Admin"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
