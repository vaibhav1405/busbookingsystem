Imports System.Data
Imports System.Data.OleDb

Public Class BUS
    Private Sub ComboBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim bfrom As String
        Dim bto As String
        bfrom = ComboBox1.SelectedItem
        bto = ComboBox2.SelectedItem
        If bfrom = "" Or bto = "" Then
            MessageBox.Show("Enter place please")
        End If
        If bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "JAIPUR" Then
            busschedule.Label1.Text = "JANTA EXPRESS"
            busschedule.Label2.Text = "1PM"
            busschedule.Label3.Text = "5PM"
            busschedule.Label4.Text = "4 hours"
            busschedule.Label19.Text = "1001"
            busschedule.Show()
            busschedule.Label9.Hide()
            busschedule.Label10.Hide()
            busschedule.Label11.Hide()
            busschedule.Label12.Hide()
            busschedule.Label15.Hide()
            busschedule.Label16.Hide()
            busschedule.Label17.Hide()
            busschedule.Label18.Hide()
            busschedule.Label20.Hide()
            busschedule.Label21.Hide()


            busschedule.Button1.Visible = "true"
            busschedule.Button2.Visible = "false"
            busschedule.Button3.Visible = "false"

        ElseIf bfrom = "JAIPUR" Or bfrom = "DELHI" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "KOTA" Then
            busschedule.Label1.Text = "JANTA EXPRESS"
            busschedule.Label2.Text = "1PM"
            busschedule.Label3.Text = "5PM"
            busschedule.Label4.Text = "4 hours"
            busschedule.Label19.Text = "1002"
            busschedule.Show()
            busschedule.Label9.Hide()
            busschedule.Label10.Hide()
            busschedule.Label11.Hide()
            busschedule.Label12.Hide()
            busschedule.Label15.Hide()
            busschedule.Label16.Hide()
            busschedule.Label17.Hide()
            busschedule.Label18.Hide()
            busschedule.Label20.Hide()
            busschedule.Label21.Hide()


            busschedule.Button1.Visible = "true"
            busschedule.Button2.Visible = "false"
            busschedule.Button3.Visible = "false"

        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "AJMER" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "DELHI" Then
            busschedule.Label1.Text = "DELHI EXPRESS"
            busschedule.Label2.Text = "1PM"
            busschedule.Label3.Text = "5PM"
            busschedule.Label4.Text = "4 hours"
            busschedule.Label19.Text = "1003"
            busschedule.Show()
            busschedule.Label9.Hide()
            busschedule.Label10.Hide()
            busschedule.Label11.Hide()
            busschedule.Label12.Hide()
            busschedule.Label15.Hide()
            busschedule.Label16.Hide()
            busschedule.Label17.Hide()
            busschedule.Label18.Hide()
            busschedule.Label20.Hide()
            busschedule.Label21.Hide()


            busschedule.Button1.Visible = "true"
            busschedule.Button2.Visible = "false"
            busschedule.Button3.Visible = "false"

        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "DEOLI" Or bfrom = "JODHPUR" And bto = "AJMER" Then
            busschedule.Label1.Text = "AJMER EXPRESS"
            busschedule.Label2.Text = "1PM"
            busschedule.Label3.Text = "5PM"
            busschedule.Label4.Text = "4 hours"
            busschedule.Label19.Text = "1004"
            busschedule.Show()
            busschedule.Label9.Hide()
            busschedule.Label10.Hide()
            busschedule.Label11.Hide()
            busschedule.Label12.Hide()
            busschedule.Label15.Hide()
            busschedule.Label16.Hide()
            busschedule.Label17.Hide()
            busschedule.Label18.Hide()
            busschedule.Label20.Hide()
            busschedule.Label21.Hide()


            busschedule.Button1.Visible = "true"
            busschedule.Button2.Visible = "false"
            busschedule.Button3.Visible = "false"

        ElseIf bfrom = "JAIPUR" Or bfrom = "KOTA" Or bfrom = "DELHI" Or bfrom = "DEOLI" Or bfrom = "AJMER" And bto = "JODHPUR" Then
            busschedule.Label1.Text = "JODHPUR EXPRESS EXPRESS"
            busschedule.Label2.Text = "1PM"
            busschedule.Label3.Text = "5PM"
            busschedule.Label4.Text = "4 hours"
            busschedule.Label19.Text = "1005"
            busschedule.Show()
            busschedule.Label9.Hide()
            busschedule.Label10.Hide()
            busschedule.Label11.Hide()
            busschedule.Label12.Hide()
            busschedule.Label15.Hide()
            busschedule.Label16.Hide()
            busschedule.Label17.Hide()
            busschedule.Label18.Hide()
            busschedule.Label20.Hide()
            busschedule.Label21.Hide()


            busschedule.Button1.Visible = "true"
            busschedule.Button2.Visible = "false"
            busschedule.Button3.Visible = "false"
        End If


        busschedule.Label22.Text = "SCHEDULE OF BUS FROM  " + bfrom + "  TO  " + bto + "  IS:- "
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HOME.Show()
        Me.Close()
    End Sub

    Private Sub BUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class