﻿Imports System.Windows.Documents

Public Class makeAppointment
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub makeAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
        specialisation.Show()
        Me.Close()
    End Sub

    Private Sub Guna2GradientTileButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton2.Click
        listHospitals.Show()
        Me.Close()
    End Sub

    Private Sub Guna2GradientTileButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton3.Click

    End Sub


    Private Sub Guna2GradientTileButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton4.Click

    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged

    End Sub

    Private Sub Guna2TextBox2_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Doctor1 As New cMakeAppointment("Dr. John Doe", "10 Years", "Male", "9 am to 12 am", 4.5)
        Dim Doctor2 As New cMakeAppointment("Dr. Jane Smith", "4 Years", "Male", "3 pm to 5 pm", 3.8)
        Dim Doctor3 As New cMakeAppointment("Dr. Bob Johnson", "6 Years", "Male", "9 am to 11 am ", 2.7)
        Dim Doctor4 As New cMakeAppointment("Dr. Hello", "8 Years", "Male", "2 pm to 5 pm ", 4.7)



        Panel1.Controls.Add(Doctor1)
        Panel1.Controls.Add(Doctor2)
        Panel1.Controls.Add(Doctor3)
        Panel1.Controls.Add(Doctor4)

        If Panel1.Controls.Count > 1 Then
            Dim prevMessageLabel As Control = Panel1.Controls(Panel1.Controls.Count - 2)
            Doctor1.Left = 20
            Doctor2.Left = 300
            Doctor3.Left = 590
            Doctor4.Left = 880

            Doctor3.Top = 0
            Doctor2.Top = 0
            Doctor4.Top = 0


        End If
    End Sub
End Class