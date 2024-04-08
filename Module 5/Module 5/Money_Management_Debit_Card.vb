﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Money_Management_Debit_Card
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Dim card As String
    Dim expiry As String
    Dim cvv As String
    Dim remark As String

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox_Card.Text = RichTextBox_Card.Text.Trim()
        RichTextBox_Expiry.Text = RichTextBox_Expiry.Text.Trim()
        RichTextBox_Cvv.Text = RichTextBox_Cvv.Text.Trim()
        RichTextBox_Remark.Text = RichTextBox_Remark.Text.Trim()

        card = RichTextBox_Card.Text
        expiry = RichTextBox_Expiry.Text
        cvv = RichTextBox_Cvv.Text
        remark = RichTextBox_Remark.Text

        If Not card <> "" Then
            MessageBox.Show("Please enter Card Number.")
        ElseIf Not expiry <> "" Then
            MessageBox.Show("Please enter Expiry Date.")
        ElseIf Not cvv <> "" Then
            MessageBox.Show("Please enter CVV.")
        ElseIf Not remark <> "" Then
            MessageBox.Show("Please enter remark.")
        Else
            Try
                conn.Open()
                Dim query = "SELECT * FROM CreditDebitCard Where CardNumber = ' " & card & "' AND Cvv = " & cvv & " AND Type = 'DEBIT' ;"
                Dim cmd = New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                Dim sqlDt As New DataTable
                sqlDt.Load(reader)
                reader.Close()
                conn.Close()

                If sqlDt.Rows.Count = 0 Then
                    MessageBox.Show("Wrong Card Details.")
                Else
                    conn.Open()
                    query = "SELECT * FROM UserData Where Bank_Account_Number = '" & CType(sqlDt.Rows(0)("Bank_Account_Number"), String) & "' ;"
                    cmd = New MySqlCommand(query, conn)
                    reader = cmd.ExecuteReader
                    Dim sqlDt2 As New DataTable
                    sqlDt2.Load(reader)
                    reader.Close()
                    conn.Close()

                    Dim balance As Single = CType(sqlDt2.Rows(0)("Balance"), Single)
                    If Money_Management_Homepage.amount > balance Then
                        MessageBox.Show("Insufficient Balane.")
                    Else
                        conn.Open()
                        ' withdraw
                        query = "UPDATE UserData SET Balance = Balance - " & Money_Management_Homepage.amount & " Where Bank_Account_Number = '" & CType(sqlDt.Rows(0)("Bank_Account_Number"), String) & "' ;"
                        cmd = New MySqlCommand(query, conn)
                        reader = cmd.ExecuteReader
                        reader.Close()

                        ' deposit
                        query = "UPDATE UserData SET Balance = Balance + " & Money_Management_Homepage.amount & " Where Bank_Account_Number = '" & Money_Management_Homepage.account_number & "' ;"
                        cmd = New MySqlCommand(query, conn)
                        reader = cmd.ExecuteReader
                        reader.Close()

                        ' log
                        query = "Insert Into TransactionLog(Bank_Account_Number,Involved_Bank_Account_Number,Type_of_Transaction,Amount,Date_Time,Description) Values ('" & CType(sqlDt.Rows(0)("Bank_Account_Number"), String) & "','" & CType(Money_Management_Homepage.sqlDt.Rows(0)("Bank_Account_Number"), String) & "','Money Transfer'," & Money_Management_Homepage.amount & ",'0000-00-00','" & remark & "');"
                        cmd = New MySqlCommand(query, conn)
                        reader = cmd.ExecuteReader
                        reader.Close()
                        conn.Close()
                        Money_Management_Final.Show()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error: {0}", ex.Message)
                conn.Close()
            End Try
        End If
    End Sub
End Class