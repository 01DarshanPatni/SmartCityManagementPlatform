﻿Public Class transport_cabbooking
    Public Shared FromLocation As String
    Public Shared ToLocation As String
    Public Shared sqlFormattedDateTime As String

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FromLocation = ComboBox1.SelectedItem.ToString()
        ToLocation = ComboBox2.SelectedItem.ToString()
        'MessageBox.Show(FromLocation & " " & ToLocation)
        'departTime = DateTimePicker1.Value.TimeOfDay

        Dim selectedDateTime As DateTime = DateTimePicker1.Value

        ' Format the DateTime object as a string in the required format for SQL
        sqlFormattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss")

        ' Now you can use sqlFormattedDateTime in your SQL query
        'MessageBox.Show("Selected date and time in SQL format: " & sqlFormattedDateTime)
        mypanel.panel1.Controls.Clear()
        Dim form As New transport_cabavailable
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()

    End Sub

    Private Sub transport_cabbooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.ControlBox = False
        Me.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New transport_cabdriverlogin()

        ' Show Form2
        Me.Hide()
        form2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        mypanel.panel1.Controls.Clear()
        Dim form As New transport_cabuserhistory
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class