Imports System.Data
Imports System.Data.OleDb
Public Class ticketbooking
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub TextBox3_Enter(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gender As String
        If RadioButton1.Checked = True Then
            gender = "Male"
        ElseIf RadioButton2.Checked = True Then
            gender = "Female"
        Else
            gender = "Not Specified"
        End If

        Dim bfrom As String
        Dim bto As String
        Dim dot As String
        bfrom = ComboBox1.SelectedItem.ToString()
        bto = ComboBox2.SelectedItem.ToString()
        dot = DateTimePicker1.Value.ToShortDateString

        Dim adp As New OleDbDataAdapter("insert into booking values('" + TextBox4.Text + "','" + TextBox8.Text + "','" + TextBox7.Text + "','" + dot.ToString + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + gender + "','" + bfrom + "','" + TextBox6.Text + "','" + bto + "','" + TextBox3.Text + "','" + TextBox5.Text + "')", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\bus ticket\db\booking.accdb")
        Dim dt As New DataTable
        adp.Fill(dt)
        MessageBox.Show("ticket is booked")
        Me.Close()
        HOME.Show()


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_Leave(sender As Object, e As EventArgs) Handles ComboBox2.Leave
        Dim bfrom As String
        Dim bto As String
        bfrom = ComboBox1.SelectedItem.ToString()
        bto = ComboBox2.SelectedItem.ToString()
        If bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "JAIPUR" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "400"
            Else
                TextBox3.Text = "500"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "DELHI" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "KOTA" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "720"
            Else
                TextBox3.Text = "800"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "DELHI" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "820"
            Else
                TextBox3.Text = "900"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "AJMER" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "800"
            Else
                TextBox3.Text = "1000"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "DEOLI" Or bfrom = "AJMER" And bto = "JODHPUR" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "1000"
            Else
                TextBox3.Text = "1200"
            End If
        End If

    End Sub

    Private Sub ComboBox1_Leave(sender As Object, e As EventArgs) Handles ComboBox1.Leave

        If ComboBox1.SelectedItem = "KOTA" Then
            ComboBox2.Items.Remove("KOTA")
        ElseIf ComboBox1.SelectedItem = "JAIPUR" Then
            ComboBox2.Items.Remove("JAIPUR")
        ElseIf ComboBox1.SelectedItem = "AJMER" Then
            ComboBox2.Items.Remove("AJMER")

        ElseIf ComboBox1.SelectedItem = "DEOLI" Then
            ComboBox2.Items.Remove("DEOLI")

        ElseIf ComboBox1.SelectedItem = "JODHPUR" Then
            ComboBox2.Items.Remove("JODHPUR")
        ElseIf ComboBox1.SelectedItem = "DELHI" Then
            ComboBox2.Items.Remove("DELHI")


        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        'code for ticket number
        Dim adp As New OleDbDataAdapter("select Ticket from booking ", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\bus ticket\db\booking.accdb")
        Dim dt As New DataTable
        adp.Fill(dt)
        Dim a As String
        a = dt.Rows.Count.ToString()
        a = a + 1
        TextBox4.Text = a.ToString



        'code for date today
        DateTimePicker1.MinDate = DateTime.Today
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        '  If TextBox2.Text > 120 Then
        'MessageBox.Show("age is invalid")
        '
        ' End If
        If TextBox2.Text = "" Then
            MessageBox.Show("enter age please")
        End If
        Dim validinputchar = ""
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HOME.Show()
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub RadioButton2_MouseEnter(sender As Object, e As EventArgs) Handles RadioButton2.MouseEnter


    End Sub

    Private Sub RadioButton1_MouseEnter(sender As Object, e As EventArgs) Handles RadioButton1.MouseEnter

    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick

    End Sub

    Private Sub DateTimePicker1_Leave(sender As Object, e As EventArgs) Handles DateTimePicker1.Leave

    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
        If TextBox4.Text = "" Then
            MessageBox.Show("enter ticket number please")
        End If
    End Sub

    Private Sub TextBox7_Leave(sender As Object, e As EventArgs) Handles TextBox7.Leave
        If TextBox7.Text = "" Then
            MessageBox.Show("enter bus name please")
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles TextBox5.Leave

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            MessageBox.Show("enter name please")
        End If
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.Leave
        If TextBox6.Text = "" Then
            MessageBox.Show("enter  number please")
        End If
    End Sub

    Private Sub TextBox4_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox8_Leave(sender As Object, e As EventArgs) Handles TextBox8.Leave
        Dim a As String
        'code for bus name by code
        a = TextBox8.Text
        If a = "1001" Then
            TextBox7.Text = "JANTA EXPRESS"
        ElseIf a = "1002" Then
            TextBox7.Text = "KOTA-JAIPUR EXPRESS"
        ElseIf a = "1003" Then
            TextBox7.Text = "SWARAJ EXPRESS"
        ElseIf a = "1004" Then
            TextBox7.Text = "JODHPUR EXPRESS"
        ElseIf a = "1005" Then
            TextBox7.Text = "NATIONAL EXPRESS"
        Else
            MessageBox.Show("code is invalid if you forgeted the code go to bus search section and then book")
        End If



        'code for seat number


        Dim adp1 As New OleDbDataAdapter("select * from booking where [Buscode] = '" + TextBox8.Text + "'", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\bus ticket\db\booking.accdb")
        Dim dt1 As New DataTable
        adp1.Fill(dt1)
        Dim b As String
        b = dt1.Rows.Count.ToString()
        b = b + 1
        If b < 72 Then
            TextBox5.Text = b.ToString
        Else
            MessageBox.Show("Bus is full")
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub ComboBox2_MouseLeave(sender As Object, e As EventArgs) Handles ComboBox2.MouseLeave

    End Sub

    Private Sub RadioButton1_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton1.MouseClick
        Dim bfrom As String
        Dim bto As String
        bfrom = ComboBox1.SelectedItem.ToString()
        bto = ComboBox2.SelectedItem.ToString()
        If bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "JAIPUR" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "400"
            Else
                TextBox3.Text = "500"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "DELHI" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "KOTA" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "720"
            Else
                TextBox3.Text = "800"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "DELHI" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "820"
            Else
                TextBox3.Text = "900"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "AJMER" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "800"
            Else
                TextBox3.Text = "1000"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "DEOLI" Or bfrom = "AJMER" And bto = "JODHPUR" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "1000"
            Else
                TextBox3.Text = "1200"
            End If
        End If

    End Sub

    Private Sub RadioButton2_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton2.MouseClick
        Dim bfrom As String
        Dim bto As String
        bfrom = ComboBox1.SelectedItem.ToString()
        bto = ComboBox2.SelectedItem.ToString()
        If bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "JAIPUR" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "400"
            Else
                TextBox3.Text = "500"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "DELHI" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "KOTA" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "720"
            Else
                TextBox3.Text = "800"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "DELHI" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "820"
            Else
                TextBox3.Text = "900"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "AJMER" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "800"
            Else
                TextBox3.Text = "1000"
            End If
        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "DEOLI" Or bfrom = "AJMER" And bto = "JODHPUR" Then
            If RadioButton2.Checked = True Then
                TextBox3.Text = "1000"
            Else
                TextBox3.Text = "1200"
            End If
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class
'Dim seat As Integer

'Dim adp As New OleDbDataAdapter("select SEATNUM from booking ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + gender + "','" + bfrom + "','" + bto + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Use\User\Desktop\booking.accdb")
'Dim dt As New DataTable

