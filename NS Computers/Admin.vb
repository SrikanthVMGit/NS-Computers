Imports MySql.Data.MySqlClient
Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ManageProducts.Show()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String = "server=localhost;user id=root;password=system;database=ns"
        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand("SELECT * FROM order_log", conn)
        Dim cmd1 As New MySqlCommand("SELECT * FROM feedbacks", conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim da1 As New MySqlDataAdapter(cmd1)
        Dim ds As New DataSet()
        Dim ds1 As New DataSet()

        conn.Open()
        da.Fill(ds, "order_log")
        da1.Fill(ds1, "feedbacks") ' Fixed here, changed "da.Fill" to "da1.Fill"
        conn.Close()
        DataGridView1.DataSource = ds.Tables("order_log")
        DataGridView2.DataSource = ds1.Tables("feedbacks")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ManagePrebuilt.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class