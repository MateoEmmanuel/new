Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Imports ConnectionModule
Public Class Admin
    Private Sub Admin_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        report()
        roomstatus()
        FormatDataGridViews()
    End Sub
    Private Sub report()
        Dim query As String = "SELECT * FROM report"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the report table
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            DGVreport.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving reports: " & ex.Message)
        End Try
    End Sub

    Private Sub roomstatus()
        Dim query As String = "SELECT * FROM sched" ' Use roomlist if you want to get room status from that table
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the sched table
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            DGVfeedback.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving room statuses: " & ex.Message)
        End Try
    End Sub

    Private Sub FormatDataGridViews()
        ' Format the reports DataGridView
        With DGVreport
            .Columns(0).HeaderText = "Report ID"  ' Customize as necessary
            .Columns(1).HeaderText = "Report"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Adjust column widths
        End With

        ' Format the rooms DataGridView
        With DGVfeedback
            .Columns(0).HeaderText = "Room Code"  ' Customize as necessary
            .Columns(1).HeaderText = "Room Name"
            .Columns(2).HeaderText = "Room Status"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Adjust column widths
        End With
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class