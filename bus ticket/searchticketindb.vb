Imports System.Data
Imports System.Data.OleDb
Public Class searchticketindb
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub searchticketindb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim adp As New OleDbDataAdapter("select * from booking", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\bus ticket\db\booking.accdb")
        Dim dt As New DataTable
        adp.Fill(dt)
        ticketbookingdb.DataGridView1.DataSource = dt
        ticketbookingdb.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("enter ticket number please")
        Else

            Dim adp As New OleDbDataAdapter("select * from booking where [Ticket] = '" + TextBox1.Text + "'", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\bus ticket\db\booking.accdb")
            Dim dt As New DataTable
            adp.Fill(dt)
            ticketbookingdb.DataGridView1.DataSource = dt
            ticketbookingdb.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HOME.Show()
    End Sub
End Class