Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Imports ConnectionModule
Imports UniversalDim

Public Class ViewFeedbackReport
    Public Property report_ID As String
    Public Property feedback_ID As String

    Private Sub ViewFeedbackReort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If report_ID > 0 Then
            reportinserter(report_ID)
            txttype.Text = "Report"
        ElseIf feedback_ID > 0 Then
            feedbackinserter()
            txttype.Text = "Feedback"
        End If
    End Sub

    Private Sub reportinserter(report_ID As String)
        ' Query to select necessary columns (sender, d, t, report) based on report_Id
        Dim query As String = "SELECT sender, d, t, report FROM report WHERE ID = @reportId"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        ' Add parameter to prevent SQL injection
        adapter.SelectCommand.Parameters.AddWithValue("@reportId", report_ID)

        Try
            ' Fill the DataTable with data from the report table
            adapter.Fill(table)

            ' If the table has rows, populate the controls
            If table.Rows.Count > 0 Then
                ' Assuming there is only one row, get it
                Dim row As DataRow = table.Rows(0)

                ' Populate the respective controls with the values from the row
                txtsender.Text = row("sender").ToString()
                txtdate.Text = row("d").ToString()
                txttime.Text = row("t").ToString()

                ' Set the DataGridView's text column data source
                DGVtext.AutoGenerateColumns = False
                DGVtext.DataSource = table

                ' Manually map the data to the existing columns
                For Each column As DataGridViewColumn In DGVtext.Columns
                    If column.Name = "Text" Then
                        column.DataPropertyName = "report"
                    End If
                Next
            Else
                MessageBox.Show("No report found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving report: " & ex.Message)
        End Try
    End Sub

    Private Sub feedbackinserter()
        ' Query to select necessary columns (sender, d, t, report) based on report_Id
        Dim query As String = "SELECT sender, d, t, report FROM feedback WHERE ID = @feedbacktId"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        ' Add parameter to prevent SQL injection
        adapter.SelectCommand.Parameters.AddWithValue("@feedbackId", feedback_ID)

        Try
            ' Fill the DataTable with data from the report table
            adapter.Fill(table)

            ' If the table has rows, populate the controls
            If table.Rows.Count > 0 Then
                ' Assuming there is only one row, get it
                Dim row As DataRow = table.Rows(0)

                ' Populate the respective controls with the values from the row
                txtsender.Text = row("sender").ToString()
                txtdate.Text = row("d").ToString()
                txttime.Text = row("t").ToString()

                ' Set the DataGridView's text column data source
                DGVtext.AutoGenerateColumns = False
                DGVtext.DataSource = table

                ' Manually map the data to the existing columns
                For Each column As DataGridViewColumn In DGVtext.Columns
                    If column.Name = "Text" Then
                        column.DataPropertyName = "report"
                    End If
                Next
            Else
                MessageBox.Show("No report found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving report: " & ex.Message)
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Admin.Show()
        Me.Hide()
    End Sub
End Class