Imports System.Data
Imports System.Data.OleDb

Public Class busschedule
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub busschedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ticketbooking.Show()

        ticketbooking.ComboBox1.SelectedItem = BUS.ComboBox1.SelectedItem
        ticketbooking.ComboBox2.SelectedItem = BUS.ComboBox2.SelectedItem
        ticketbooking.ComboBox1.Enabled = "false"
        ticketbooking.ComboBox2.Enabled = "false"


        ticketbooking.TextBox7.Text = Label1.Text
        ticketbooking.TextBox7.ReadOnly = "true"
        ticketbooking.TextBox8.Text = Label19.Text

        Dim adp1 As New OleDbDataAdapter("select * from booking where [Buscode] = '" + Label19.Text + "'", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\bus ticket\db\booking.accdb")
        Dim dt1 As New DataTable
        adp1.Fill(dt1)
        Dim b As String
        b = dt1.Rows.Count.ToString()
        b = b + 1
        If b < 72 Then
            ticketbooking.TextBox5.Text = b.ToString
        Else
            MessageBox.Show("Bus is full")
        End If
        Me.Close()


    End Sub
End Class