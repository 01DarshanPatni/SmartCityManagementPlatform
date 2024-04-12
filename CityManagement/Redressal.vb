﻿Imports MySql.Data.MySqlClient

Public Class Redressal
    Dim connString As String = "server=172.16.114.244;userid=admin;password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Private Sub Redressal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up DataGridView
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True ' Enable text wrapping
        DataGridView1.RowHeadersVisible = False ' Hide row headers


        ' Add columns to the DataGridView
        Dim complaintIDColumn As New DataGridViewTextBoxColumn()
        complaintIDColumn.Name = "ComplaintID"
        complaintIDColumn.HeaderText = "Complaint ID"
        complaintIDColumn.Width = 148
        DataGridView1.Columns.Add(complaintIDColumn)

        Dim senderColumn As New DataGridViewTextBoxColumn()
        senderColumn.Name = "Sender"
        senderColumn.HeaderText = "Sender"
        senderColumn.Width = 198
        DataGridView1.Columns.Add(senderColumn)

        Dim dateColumn As New DataGridViewTextBoxColumn()
        dateColumn.Name = "sent_time"
        dateColumn.HeaderText = "Sent time"
        dateColumn.Width = 248
        DataGridView1.Columns.Add(dateColumn)

        Dim lastModifiedColumn As New DataGridViewTextBoxColumn()
        lastModifiedColumn.Name = "LastModified"
        lastModifiedColumn.HeaderText = "Last Modified"
        lastModifiedColumn.Width = 250
        DataGridView1.Columns.Add(lastModifiedColumn)

        Dim queryColumn As New DataGridViewTextBoxColumn()
        queryColumn.Name = "Query"
        queryColumn.HeaderText = "Query"
        queryColumn.Width = 200
        DataGridView1.Columns.Add(queryColumn)

        ' Add Status column as button
        Dim statusColumn As New DataGridViewButtonColumn()
        statusColumn.Name = "Status"
        statusColumn.HeaderText = "Status"
        statusColumn.Text = "Resolve" ' Change button text to "Resolve"
        statusColumn.UseColumnTextForButtonValue = True
        statusColumn.FlatStyle = FlatStyle.Popup ' Set button style to popup
        statusColumn.DefaultCellStyle.BackColor = Color.Red ' Set button background color to red
        statusColumn.Width = 150
        DataGridView1.Columns.Add(statusColumn)


        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        ' Fetch data from MySQL and populate DataGridView
        Try
            conn.Open()
            Dim query As String = "SELECT complaint_id,from_user_id,reply_time,sent_time,complaint,status FROM Complaints where status = false"
            Using command As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim row As DataGridViewRow = New DataGridViewRow()
                        row.CreateCells(DataGridView1)
                        row.Cells(0).Value = reader("complaint_id").ToString()
                        row.Cells(1).Value = reader("from_user_id").ToString()
                        row.Cells(2).Value = reader("sent_time").ToString()
                        row.Cells(3).Value = reader("reply_time").ToString()
                        row.Cells(4).Value = reader("complaint").ToString()
                        DataGridView1.Rows.Add(row)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is in the button column and perform action accordingly
        If e.ColumnIndex = DataGridView1.Columns("Status").Index AndAlso e.RowIndex >= 0 Then
            ' Get the complaint ID of the clicked row
            Dim complaintID As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("ComplaintID").Value.ToString())

            ' Set the complaint ID as an environment variable
            Environment.SetEnvironmentVariable("ComplaintID", complaintID)
            Dim Quer1 As New Quer1()
            MainPanel.switchPanel(Quer1)

        End If
    End Sub

End Class
