﻿Imports MySql.Data.MySqlClient

Public Class Build
    Private Sub Build_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("AMD Ryzen 9 7900X")
        ComboBox1.Items.Add("AMD Ryzen 7 7700X")
        ComboBox1.Items.Add("Intel Core I7-11700K")
        ComboBox2.Items.Add("Nvidia RTX 4090 24GB")
        ComboBox2.Items.Add("MSI Radeon 6600 XT")
        ComboBox2.Items.Add("GeForce GTX1660 6GB")
        ComboBox3.Items.Add("CORSAIR  32GB RAM")
        ComboBox3.Items.Add("ALKETR Quantum4GB")
        ComboBox3.Items.Add("CrucialRAM 16GBDDR5")
        ComboBox4.Items.Add("Samsung T7 Shield 1TB")
        ComboBox4.Items.Add("SanDisk 1TB Portable")
        ComboBox4.Items.Add("Samsung T7 500GB")
        ComboBox5.Items.Add("ASRock")
        ComboBox5.Items.Add("Gigabyte")
        ComboBox5.Items.Add("Asus")
        ComboBox6.Items.Add("Corsair RM550x")
        ComboBox6.Items.Add("XPG Core 650W")
        ComboBox6.Items.Add("EVGA SuperNOVA 850")
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, ComboBox2.SelectedIndexChanged, ComboBox3.SelectedIndexChanged, ComboBox4.SelectedIndexChanged, ComboBox5.SelectedIndexChanged, ComboBox6.SelectedIndexChanged
        ' Cast the sender to a ComboBox
        ' Cast the sender to a ComboBox
        ' Cast the sender to a ComboBox
        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)

        ' Get the selected item from the ComboBox
        Dim selectedItem As String = comboBox.SelectedItem.ToString()

        ' Update the appropriate TextBox control
        Select Case comboBox.Name
            Case "ComboBox1"
                TextBox1.Text = selectedItem
            Case "ComboBox2"
                TextBox2.Text = selectedItem
            Case "ComboBox3"
                TextBox3.Text = selectedItem
            Case "ComboBox4"
                TextBox4.Text = selectedItem
            Case "ComboBox5"
                TextBox5.Text = selectedItem
            Case "ComboBox6"
                TextBox6.Text = selectedItem
        End Select
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "AMD Ryzen 9 7900X" Then
            TextBox7.Text = "43599"
        ElseIf ComboBox1.SelectedItem = "AMD Ryzen 7 7700X" Then
            TextBox7.Text = "37599"
        ElseIf ComboBox1.SelectedItem = "Intel Core I7-11700K" Then
            TextBox7.Text = "36099"
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Nvidia RTX 4090 24GB" Then
            TextBox8.Text = "156099"
        ElseIf ComboBox2.SelectedItem = "MSI Radeon 6600 XT" Then
            TextBox8.Text = "27099"
        ElseIf ComboBox2.SelectedItem = "GeForce GTX1660 6GB" Then
            TextBox8.Text = "22099"
        End If
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = "CORSAIR  32GB RAM" Then
            TextBox9.Text = "13099"
        ElseIf ComboBox3.SelectedItem = "ALKETR Quantum4GB" Then
            TextBox9.Text = "599"
        ElseIf ComboBox3.SelectedItem = "CrucialRAM 16GBDDR5" Then
            TextBox9.Text = "5600"
        End If
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedItem = "Samsung T7 Shield 1TB" Then
            TextBox10.Text = "8999"
        ElseIf ComboBox4.SelectedItem = "SanDisk 1TB Portable" Then
            TextBox10.Text = "7299"
        ElseIf ComboBox4.SelectedItem = "Samsung T7 500GB" Then
            TextBox10.Text = "1265"
        End If
    End Sub
    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedItem = "ASRock" Then
            TextBox11.Text = "12265"
        ElseIf ComboBox5.SelectedItem = "Gigabyte" Then
            TextBox11.Text = "11265"
        ElseIf ComboBox5.SelectedItem = "Asus" Then
            TextBox11.Text = "7265"
        End If
    End Sub
    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged

        If ComboBox6.SelectedItem = "Corsair RM550x" Then
            TextBox12.Text = "6765"
        ElseIf ComboBox6.SelectedItem = "XPG Core 650W" Then
            TextBox12.Text = "5645"
        ElseIf ComboBox6.SelectedItem = "EVGA SuperNOVA 850" Then
            TextBox12.Text = "4532"
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged, TextBox8.TextChanged, TextBox9.TextChanged, TextBox10.TextChanged, TextBox11.TextChanged, TextBox12.TextChanged
        Dim total As Double = 0

        'Loop through all the textboxes and add their values to the total
        For Each tb As TextBox In {TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12}
            Dim value As Double
            If Double.TryParse(tb.Text, value) Then
                total += value
            End If
        Next

        'Update the value of textbox 13 with the total
        TextBox13.Text = total.ToString()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim cmd As MySqlCommand = New MySqlCommand()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or
       TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or
       TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Then
            ' Display error message
            MessageBox.Show("Please complete your build.")
        Else

            Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO cart (details, price) VALUES (@details1, @price1), (@details2, @price2), (@details3, @price3), (@details4, @price4), (@details5, @price5), (@details6, @price6)"
            cmd.Parameters.AddWithValue("@details1", TextBox1.Text)
            cmd.Parameters.AddWithValue("@price1", TextBox7.Text)
            cmd.Parameters.AddWithValue("@details2", TextBox2.Text)
            cmd.Parameters.AddWithValue("@price2", TextBox8.Text)
            cmd.Parameters.AddWithValue("@details3", TextBox3.Text)
            cmd.Parameters.AddWithValue("@price3", TextBox9.Text)
            cmd.Parameters.AddWithValue("@details4", TextBox4.Text)
            cmd.Parameters.AddWithValue("@price4", TextBox10.Text)
            cmd.Parameters.AddWithValue("@details5", TextBox5.Text)
            cmd.Parameters.AddWithValue("@price5", TextBox11.Text)
            cmd.Parameters.AddWithValue("@details6", TextBox6.Text)
            cmd.Parameters.AddWithValue("@price6", TextBox12.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Your Build has been added to the cart")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
            TextBox13.Text = ""
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Me.Hide()
        Choose.Show()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Me.Hide()
        Parts.Show()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Me.Hide()
        Prebuilt.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Application.Exit()
    End Sub

End Class