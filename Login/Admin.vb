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
        feedback()
        FormatDataGridViews_report()
        FormatDataGridViews_feedback()
    End Sub
    Private Sub report()
        Dim query As String = "SELECT d,t,report FROM report"
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

    Private Sub feedback()
        Dim query As String = "SELECT d,t,feedback FROM feedback" ' Use roomlist if you want to get room status from that table
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

    Private Sub FormatDataGridViews_report()
        ' Format the reports DataGridView
        If DGVreport.Rows.Count > 0 Then ' Check if there are rows
            With DGVreport
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Report"

                ' First, adjust the columns based on data length
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ' Then, set it back to Fill for a balanced layout
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        Else
            With DGVreport
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Report"

                ' No auto-size adjustment if no data
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        End If
    End Sub

    Private Sub FormatDataGridViews_feedback()
        ' Format the feedback DataGridView
        If DGVfeedback.Rows.Count > 0 Then ' Check if there are rows
            With DGVfeedback
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Feedback"

                ' First, adjust the columns based on data length
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ' Then, set it back to Fill for a balanced layout
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        Else
            With DGVfeedback
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Feedback"

                ' No auto-size adjustment if no data
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        End If
    End Sub


    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        report()
        FormatDataGridViews_report()
    End Sub

    Private Sub btnfeedback_Click(sender As Object, e As EventArgs) Handles btnfeedback.Click
        feedback()
        FormatDataGridViews_feedback()
    End Sub

    Private Sub btnmanagement_Click(sender As Object, e As EventArgs) Handles btnmanagement.Click

    End Sub

    Private Sub btnapproval_Click(sender As Object, e As EventArgs) Handles btnapproval.Click
        requestapproval.Show()
        Me.Hide()
    End Sub
End Class