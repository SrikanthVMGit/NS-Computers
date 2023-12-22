Imports System.Diagnostics.Contracts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Parts


    'Displaying Details from Database
    Private Sub Parts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As MySqlConnection
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;password=system;database=ns"
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'set the value of the details from the database
        'CPU Details
        Dim query As String = "SELECT name FROM products WHERE id = '1'"
        cmd = New MySqlCommand(query, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox1.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query1 As String = "SELECT name FROM products WHERE id = '2'"
        cmd = New MySqlCommand(query1, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox2.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query2 As String = "SELECT name FROM products WHERE id = '3'"
        cmd = New MySqlCommand(query2, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox3.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query3 As String = "SELECT name FROM products WHERE id = '4'"
        cmd = New MySqlCommand(query3, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox4.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query4 As String = "SELECT name FROM products WHERE id = '5'"
        cmd = New MySqlCommand(query4, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox5.Text = reader.GetString(0)
        End If
        reader.Close()
        'GPU
        Dim query5 As String = "SELECT name FROM products WHERE id = '6'"
        cmd = New MySqlCommand(query5, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox20.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query6 As String = "SELECT name FROM products WHERE id = '7'"
        cmd = New MySqlCommand(query6, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox19.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query7 As String = "SELECT name FROM products WHERE id = '8'"
        cmd = New MySqlCommand(query7, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox18.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query8 As String = "SELECT name FROM products WHERE id = '9'"
        cmd = New MySqlCommand(query8, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox17.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query9 As String = "SELECT name FROM products WHERE id = '10'"
        cmd = New MySqlCommand(query9, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox16.Text = reader.GetString(0)
        End If
        reader.Close()
        'RAM
        Dim query10 As String = "SELECT name FROM products WHERE id = '11'"
        cmd = New MySqlCommand(query10, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox30.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query11 As String = "SELECT name FROM products WHERE id = '12'"
        cmd = New MySqlCommand(query11, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox29.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query12 As String = "SELECT name FROM products WHERE id = '13'"
        cmd = New MySqlCommand(query12, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox28.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query13 As String = "SELECT name FROM products WHERE id = '14'"
        cmd = New MySqlCommand(query13, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox27.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query14 As String = "SELECT name FROM products WHERE id = '15'"
        cmd = New MySqlCommand(query14, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox26.Text = reader.GetString(0)
        End If
        reader.Close()
        'SSD
        Dim query15 As String = "SELECT name FROM products WHERE id = '16'"
        cmd = New MySqlCommand(query15, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox40.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query16 As String = "SELECT name FROM products WHERE id = '17'"
        cmd = New MySqlCommand(query16, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox39.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query17 As String = "SELECT name FROM products WHERE id = '18'"
        cmd = New MySqlCommand(query17, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox38.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query18 As String = "SELECT name FROM products WHERE id = '19'"
        cmd = New MySqlCommand(query18, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox37.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query19 As String = "SELECT name FROM products WHERE id = '20'"
        cmd = New MySqlCommand(query19, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox36.Text = reader.GetString(0)
        End If
        reader.Close()
        'Monitors
        Dim query20 As String = "SELECT name FROM products WHERE id = '21'"
        cmd = New MySqlCommand(query20, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox50.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query21 As String = "SELECT name FROM products WHERE id = '22'"
        cmd = New MySqlCommand(query21, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox49.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query22 As String = "SELECT name FROM products WHERE id = '23'"
        cmd = New MySqlCommand(query22, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox48.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query23 As String = "SELECT name FROM products WHERE id = '24'"
        cmd = New MySqlCommand(query23, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox47.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query24 As String = "SELECT name FROM products WHERE id = '25'"
        cmd = New MySqlCommand(query24, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox46.Text = reader.GetString(0)
        End If
        reader.Close()
        'Keyboards
        Dim query25 As String = "SELECT name FROM products WHERE id = '26'"
        cmd = New MySqlCommand(query25, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox60.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query26 As String = "SELECT name FROM products WHERE id = '27'"
        cmd = New MySqlCommand(query26, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox59.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query27 As String = "SELECT name FROM products WHERE id = '28'"
        cmd = New MySqlCommand(query27, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox58.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query28 As String = "SELECT name FROM products WHERE id = '29'"
        cmd = New MySqlCommand(query28, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox57.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query29 As String = "SELECT name FROM products WHERE id = '30'"
        cmd = New MySqlCommand(query29, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox56.Text = reader.GetString(0)
        End If
        reader.Close()
        'Speakers
        Dim query30 As String = "SELECT name FROM products WHERE id = '31'"
        cmd = New MySqlCommand(query30, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox70.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query31 As String = "SELECT name FROM products WHERE id = '32'"
        cmd = New MySqlCommand(query31, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox69.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query32 As String = "SELECT name FROM products WHERE id = '33'"
        cmd = New MySqlCommand(query32, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox68.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query33 As String = "SELECT name FROM products WHERE id = '34'"
        cmd = New MySqlCommand(query33, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox67.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query34 As String = "SELECT name FROM products WHERE id = '35'"
        cmd = New MySqlCommand(query34, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox66.Text = reader.GetString(0)
        End If
        reader.Close()
        'Mouse
        Dim query35 As String = "SELECT name FROM products WHERE id = '36'"
        cmd = New MySqlCommand(query35, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox80.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query36 As String = "SELECT name FROM products WHERE id = '37'"
        cmd = New MySqlCommand(query36, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox79.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query37 As String = "SELECT name FROM products WHERE id = '38'"
        cmd = New MySqlCommand(query37, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox78.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query38 As String = "SELECT name FROM products WHERE id = '39'"
        cmd = New MySqlCommand(query38, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox77.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim query39 As String = "SELECT name FROM products WHERE id = '40'"
        cmd = New MySqlCommand(query39, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox76.Text = reader.GetString(0)
        End If
        reader.Close()






        'CPU Prices
        Dim p1 As String = "SELECT price FROM products WHERE id = '1'"
        cmd = New MySqlCommand(p1, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox6.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p2 As String = "SELECT price FROM products WHERE id = '2'"
        cmd = New MySqlCommand(p2, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox7.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p3 As String = "SELECT price FROM products WHERE id = '3'"
        cmd = New MySqlCommand(p3, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox8.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p4 As String = "SELECT price FROM products WHERE id = '4'"
        cmd = New MySqlCommand(p4, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox9.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p5 As String = "SELECT price FROM products WHERE id = '5'"
        cmd = New MySqlCommand(p5, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox10.Text = reader.GetString(0)
        End If
        reader.Close()
        'GPU
        Dim p6 As String = "SELECT price FROM products WHERE id = '6'"
        cmd = New MySqlCommand(p6, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox13.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p7 As String = "SELECT price FROM products WHERE id = '7'"
        cmd = New MySqlCommand(p7, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox14.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p8 As String = "SELECT price FROM products WHERE id = '8'"
        cmd = New MySqlCommand(p8, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox15.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p9 As String = "SELECT price FROM products WHERE id = '9'"
        cmd = New MySqlCommand(p9, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox11.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p10 As String = "SELECT price FROM products WHERE id = '10'"
        cmd = New MySqlCommand(p10, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox12.Text = reader.GetString(0)
        End If
        reader.Close()
        'RAM
        Dim p11 As String = "SELECT price FROM products WHERE id = '11'"
        cmd = New MySqlCommand(p11, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox23.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p12 As String = "SELECT price FROM products WHERE id = '12'"
        cmd = New MySqlCommand(p12, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox24.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p13 As String = "SELECT price FROM products WHERE id = '13'"
        cmd = New MySqlCommand(p13, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox25.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p14 As String = "SELECT price FROM products WHERE id = '14'"
        cmd = New MySqlCommand(p14, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox21.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p15 As String = "SELECT price FROM products WHERE id = '15'"
        cmd = New MySqlCommand(p15, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox22.Text = reader.GetString(0)
        End If
        reader.Close()
        'SSD
        Dim p16 As String = "SELECT price FROM products WHERE id = '16'"
        cmd = New MySqlCommand(p16, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox33.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p17 As String = "SELECT price FROM products WHERE id = '17'"
        cmd = New MySqlCommand(p17, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox34.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p18 As String = "SELECT price FROM products WHERE id = '18'"
        cmd = New MySqlCommand(p18, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox35.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p19 As String = "SELECT price FROM products WHERE id = '19'"
        cmd = New MySqlCommand(p19, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox31.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p20 As String = "SELECT price FROM products WHERE id = '20'"
        cmd = New MySqlCommand(p20, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox32.Text = reader.GetString(0)
        End If
        reader.Close()
        'Monitors
        Dim p21 As String = "SELECT price FROM products WHERE id = '21'"
        cmd = New MySqlCommand(p21, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox43.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p22 As String = "SELECT price FROM products WHERE id = '22'"
        cmd = New MySqlCommand(p22, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox44.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p23 As String = "SELECT price FROM products WHERE id = '23'"
        cmd = New MySqlCommand(p23, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox45.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p24 As String = "SELECT price FROM products WHERE id = '24'"
        cmd = New MySqlCommand(p24, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox41.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p25 As String = "SELECT price FROM products WHERE id = '25'"
        cmd = New MySqlCommand(p25, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox42.Text = reader.GetString(0)
        End If
        reader.Close()
        'Keyboards
        Dim p26 As String = "SELECT price FROM products WHERE id = '26'"
        cmd = New MySqlCommand(p26, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox53.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p27 As String = "SELECT price FROM products WHERE id = '27'"
        cmd = New MySqlCommand(p27, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox54.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p28 As String = "SELECT price FROM products WHERE id = '28'"
        cmd = New MySqlCommand(p28, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox55.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p29 As String = "SELECT price FROM products WHERE id = '29'"
        cmd = New MySqlCommand(p29, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox51.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p30 As String = "SELECT price FROM products WHERE id = '30'"
        cmd = New MySqlCommand(p30, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox52.Text = reader.GetString(0)
        End If
        reader.Close()
        'Speakers
        Dim p31 As String = "SELECT price FROM products WHERE id = '31'"
        cmd = New MySqlCommand(p31, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox63.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p32 As String = "SELECT price FROM products WHERE id = '32'"
        cmd = New MySqlCommand(p32, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox64.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p33 As String = "SELECT price FROM products WHERE id = '33'"
        cmd = New MySqlCommand(p33, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox65.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p34 As String = "SELECT price FROM products WHERE id = '34'"
        cmd = New MySqlCommand(p34, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox61.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p35 As String = "SELECT price FROM products WHERE id = '35'"
        cmd = New MySqlCommand(p35, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox62.Text = reader.GetString(0)
        End If
        reader.Close()
        'Mouse
        Dim p36 As String = "SELECT price FROM products WHERE id = '36'"
        cmd = New MySqlCommand(p36, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox73.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p37 As String = "SELECT price FROM products WHERE id = '37'"
        cmd = New MySqlCommand(p37, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox74.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p38 As String = "SELECT price FROM products WHERE id = '38'"
        cmd = New MySqlCommand(p38, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox75.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p39 As String = "SELECT price FROM products WHERE id = '39'"
        cmd = New MySqlCommand(p39, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox71.Text = reader.GetString(0)
        End If
        reader.Close()
        Dim p40 As String = "SELECT price FROM products WHERE id = '40'"
        cmd = New MySqlCommand(p40, conn)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            TextBox72.Text = reader.GetString(0)
        End If
        reader.Close()

    End Sub

    'Buttons
    'Add Cart{
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox1.Text
        Dim price As Decimal = Decimal.Parse(TextBox6.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    '}Add Cart

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Me.Hide()
        Choose.Show()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Prebuilt.Show()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Me.Hide()
        Build.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox2.Text
        Dim price As Decimal = Decimal.Parse(TextBox7.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button25_Click_1(sender As Object, e As EventArgs) Handles Button25.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox3.Text
        Dim price As Decimal = Decimal.Parse(TextBox8.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox4.Text
        Dim price As Decimal = Decimal.Parse(TextBox9.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox5.Text
        Dim price As Decimal = Decimal.Parse(TextBox10.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox20.Text
        Dim price As Decimal = Decimal.Parse(TextBox13.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox19.Text
        Dim price As Decimal = Decimal.Parse(TextBox14.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox18.Text
        Dim price As Decimal = Decimal.Parse(TextBox15.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox17.Text
        Dim price As Decimal = Decimal.Parse(TextBox12.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox16.Text
        Dim price As Decimal = Decimal.Parse(TextBox13.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox30.Text
        Dim price As Decimal = Decimal.Parse(TextBox23.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox29.Text
        Dim price As Decimal = Decimal.Parse(TextBox24.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox28.Text
        Dim price As Decimal = Decimal.Parse(TextBox25.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox27.Text
        Dim price As Decimal = Decimal.Parse(TextBox21.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox26.Text
        Dim price As Decimal = Decimal.Parse(TextBox22.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox40.Text
        Dim price As Decimal = Decimal.Parse(TextBox33.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox39.Text
        Dim price As Decimal = Decimal.Parse(TextBox34.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox38.Text
        Dim price As Decimal = Decimal.Parse(TextBox35.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox37.Text
        Dim price As Decimal = Decimal.Parse(TextBox31.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox36.Text
        Dim price As Decimal = Decimal.Parse(TextBox32.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox50.Text
        Dim price As Decimal = Decimal.Parse(TextBox43.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox49.Text
        Dim price As Decimal = Decimal.Parse(TextBox44.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox48.Text
        Dim price As Decimal = Decimal.Parse(TextBox45.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox47.Text
        Dim price As Decimal = Decimal.Parse(TextBox41.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox46.Text
        Dim price As Decimal = Decimal.Parse(TextBox42.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox60.Text
        Dim price As Decimal = Decimal.Parse(TextBox53.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox59.Text
        Dim price As Decimal = Decimal.Parse(TextBox54.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox58.Text
        Dim price As Decimal = Decimal.Parse(TextBox55.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox57.Text
        Dim price As Decimal = Decimal.Parse(TextBox51.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox56.Text
        Dim price As Decimal = Decimal.Parse(TextBox52.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox70.Text
        Dim price As Decimal = Decimal.Parse(TextBox63.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox69.Text
        Dim price As Decimal = Decimal.Parse(TextBox64.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox68.Text
        Dim price As Decimal = Decimal.Parse(TextBox65.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox67.Text
        Dim price As Decimal = Decimal.Parse(TextBox61.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox66.Text
        Dim price As Decimal = Decimal.Parse(TextBox62.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox80.Text
        Dim price As Decimal = Decimal.Parse(TextBox73.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox79.Text
        Dim price As Decimal = Decimal.Parse(TextBox74.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox78.Text
        Dim price As Decimal = Decimal.Parse(TextBox75.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox77.Text
        Dim price As Decimal = Decimal.Parse(TextBox71.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim item As String = TextBox76.Text
        Dim price As Decimal = Decimal.Parse(TextBox72.Text)
        Dim query As String = "INSERT INTO cart (details, price) VALUES (@item, @price);"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@price", price)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item added to cart successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding item to cart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class