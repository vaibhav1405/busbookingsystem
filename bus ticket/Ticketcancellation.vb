Imports System.Data
Imports System.Data.OleDb
Public Class Ticketcancellation
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        MessageBox.Show("ticket is cancelled")

        Dim adp As New OleDbDataAdapter("insert into cancelticket values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\bus ticket\db\booking.accdb")
        Dim dt As New DataTable
        adp.Fill(dt)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        HOME.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            MessageBox.Show("please enter ticket number")
        End If

        Dim adp As New OleDbDataAdapter("select * from booking where [Ticket] = '" + TextBox1.Text + "'", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\bus ticket\db\booking.accdb")
        Dim dt As New DataTable
        adp.Fill(dt)
        Dim a As String
        a = dt.Rows(0)(1).ToString()

        If a = "" Then
            MessageBox.Show("ticket number is invalid")
        Else

            TextBox2.Text = dt.Rows(0)(10).ToString
            Dim calc As Integer
            Dim deduc As Integer
            Dim ret As Integer
            calc = Convert.ToInt16(TextBox2.Text)
            TextBox3.Text = calc * 1 / 10.ToString
            deduc = Convert.ToInt16(TextBox3.Text)
            ret = calc - deduc
            TextBox4.Text = ret.ToString

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Ticketcancellation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class