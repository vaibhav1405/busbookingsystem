Imports System.Data
Imports System.Data.OleDb
Public Class ViewBusTicket
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adp As New OleDbDataAdapter("select * from booking where [Buscode] = '" + TextBox1.Text + "'", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\bus ticket\db\booking.accdb")
        Dim dt As New DataTable
        adp.Fill(dt)
        ticketbookingdb.DataGridView1.DataSource = dt
        ticketbookingdb.Show()
    End Sub

    Private Sub ViewBusTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class