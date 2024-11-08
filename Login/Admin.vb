Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Imports ConnectionModule
Imports UniversalDim

Public Class Admin
    Public Property U_ID As String

    Private Sub Admin_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        report()
        feedback()
        accountname_reload()
    End Sub

    Private Sub report()
        ' Query to select necessary columns (ID, d, t)
        Dim query As String = "SELECT ID, d, t FROM report"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the report table
            adapter.Fill(table)

            ' Set AutoGenerateColumns to False to avoid extra columns
            DGVreport.AutoGenerateColumns = False

            ' Bind the DataTable to the DataGridView
            DGVreport.DataSource = table

            ' Manually map the data to the existing columns
            For Each column As DataGridViewColumn In DGVreport.Columns
                If column.Name = "ReportID" Then
                    column.DataPropertyName = "ID"
                ElseIf column.Name = "ReportDate" Then
                    column.DataPropertyName = "d"
                ElseIf column.Name = "ReportTime" Then
                    column.DataPropertyName = "t"
                End If
            Next

            ' Set the text for the buttons in the ReportView and ReportDelete columns
            SetButtonText(DGVreport, "ReportView")
            SetButtonText(DGVreport, "ReportDelete")

        Catch ex As Exception
            MessageBox.Show("Error retrieving reports: " & ex.Message)
        End Try
    End Sub

    Private Sub feedback()
        ' Query to select necessary columns (ID, d, t)
        Dim query As String = "SELECT ID, d, t FROM feedback"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the feedback table
            adapter.Fill(table)

            ' Set AutoGenerateColumns to False to avoid extra columns
            DGVfeedback.AutoGenerateColumns = False

            ' Bind the DataTable to the DataGridView
            DGVfeedback.DataSource = table

            ' Manually map the data to the existing columns
            For Each column As DataGridViewColumn In DGVfeedback.Columns
                If column.Name = "FeedbackID" Then
                    column.DataPropertyName = "ID"
                ElseIf column.Name = "FeedbackDate" Then
                    column.DataPropertyName = "d"
                ElseIf column.Name = "FeedbackTime" Then
                    column.DataPropertyName = "t"
                End If
            Next

            ' Set the text for the buttons in the FeedbackView and FeedbackDelete columns
            SetButtonText(DGVfeedback, "FeedbackView")
            SetButtonText(DGVfeedback, "FeedbackDelete")

        Catch ex As Exception
            MessageBox.Show("Error retrieving feedback: " & ex.Message)
        End Try
    End Sub

    Private Sub SetButtonText(dgv As DataGridView, columnName As String)
        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In dgv.Rows
            If row.IsNewRow Then
                Continue For ' Skip the new row placeholder
            End If

            ' Ensure the button is of the correct type (DataGridViewButtonCell)
            Dim buttonCell As DataGridViewButtonCell = TryCast(row.Cells(columnName), DataGridViewButtonCell)

            ' Check if the button cell exists and set the value (text) of the button
            If buttonCell IsNot Nothing Then
                buttonCell.Value = "View" ' or "Delete", depending on the column
                If columnName.Contains("Delete") Then
                    buttonCell.Value = "Delete" ' Set Delete text for Delete buttons
                End If
            End If
        Next
    End Sub

    ' Event handler for when a button inside the DataGridView is clicked
    Private Sub DGVreport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVreport.CellContentClick
        If e.RowIndex < 0 Then Return ' Avoid clicking on header row

        Dim columnName As String = DGVreport.Columns(e.ColumnIndex).Name
        Dim reportId As String = DGVreport.Rows(e.RowIndex).Cells("ReportID").Value.ToString()

        If columnName = "ReportView" Then
            ' Show the View Report form
            Dim viewReportForm As New ViewFeedbackReport()
            ViewFeedbackReport.report_Id = reportId
            viewReportForm.Show()
            Me.Hide()
        ElseIf columnName = "ReportDelete" Then
            ' Show the Delete Report form
            Dim deleteReportForm As New DeleteFeedbackReport()
            DeleteFeedbackReport.report_Id = reportId
            deleteReportForm.Show()
            Me.Hide()
        End If
    End Sub

    ' Event handler for when a button inside the DataGridView is clicked for feedback
    Private Sub DGVfeedback_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVfeedback.CellContentClick
        If e.RowIndex < 0 Then Return ' Avoid clicking on header row

        Dim columnName As String = DGVfeedback.Columns(e.ColumnIndex).Name
        Dim feedbackId As String = DGVfeedback.Rows(e.RowIndex).Cells("FeedbackID").Value.ToString()

        If columnName = "FeedbackView" Then
            ' Show the View Feedback form
            Dim viewFeedbackForm As New ViewFeedbackReport()
            ViewFeedbackReport.feedback_Id = feedbackId
            viewFeedbackForm.Show()
            Me.Hide()
        ElseIf columnName = "FeedbackDelete" Then
            ' Show the Delete Feedback form
            Dim deleteFeedbackForm As New DeleteFeedbackReport()
            DeleteFeedbackReport.feedback_Id = feedbackId
            deleteFeedbackForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        report()
    End Sub

    Private Sub btnfeedback_Click(sender As Object, e As EventArgs) Handles btnfeedback.Click
        feedback()
    End Sub

    Private Sub btnmanagement_Click(sender As Object, e As EventArgs) Handles btnmanagement.Click
        AccountManagement.Show()
        Me.Hide()
    End Sub

    Private Sub btnapproval_Click(sender As Object, e As EventArgs) Handles btnapproval.Click
        requestapproval.Show()
        Me.Hide()
    End Sub

    ' Sample deletion method (implement as needed)
    Private Sub DeleteReport(reportId As String)
        Dim query As String = "DELETE FROM report WHERE report_id = @reportId"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@reportId", reportId)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error deleting report: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ' Sample deletion method (implement as needed)
    Private Sub DeleteFeedback(feedbackId As String)
        Dim query As String = "DELETE FROM feedback WHERE feedback_id = @feedbackId"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@feedbackId", feedbackId)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error deleting feedback: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub accountname_reload()
        Dim query As String = "SELECT username FROM accounts WHERE ID = @U_ID"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@U_ID", UniversalDim.U_ID)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the query and get the username
                Dim result As Object = command.ExecuteScalar()

                ' Check if the result is not null (Nothing)
                If result IsNot Nothing Then
                    Dim username As String = result.ToString()
                    ' Update the button's text with the welcome message
                    btnprofile.Text = "Welcome " & username
                Else
                    ' Handle case where no username is found
                    MessageBox.Show("No username found for the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error retrieving username from database! Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click
    End Sub
End Class
