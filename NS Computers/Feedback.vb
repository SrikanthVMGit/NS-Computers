Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Feedback
    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Choose.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Establish a connection to your MySQL database '
        Dim connectionString As String = "Server=localhost;Database=ns;Uid=root;Pwd=system;"
        Dim conn As New MySqlConnection(connectionString)
        conn.Open()
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Please enter your Username")
            Exit Sub
        ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("Please enter feedback")
            Exit Sub
            Me.Hide()
        End If

        ' Prepare the SQL query '
        Dim query As String = "INSERT INTO feedbacks (Feedback, name) VALUES (@Feedback, @name)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Feedback", TextBox2.Text)
            cmd.Parameters.AddWithValue("@name", TextBox1.Text)

            ' Execute the SQL query '
            cmd.ExecuteNonQuery()
            MessageBox.Show("Feedback submitted successfully.Thank you Happy Shopping")
            Choose.Show()
            ' Close the connection to your MySQL database '
            conn.Close()
            TextBox1.Text = ""
        TextBox2.Text = ""
        Me.Hide()
    End Sub


End Class