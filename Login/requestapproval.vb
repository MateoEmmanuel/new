Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Imports ConnectionModule

Public Class requestapproval
    Private Sub requestapproval_loader(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        tableloader()
        FormatDataGridViews_schedules()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

    End Sub

    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Admin.Show()
        Me.Hide()
    End Sub
    Private Sub tableloader()
        Dim query As String = "SELECT request_d, request_t, room, request FROM requests" ' Use roomlist if you want to get room status from that table
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the sched table
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            DGVschedules.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving room statuses: " & ex.Message)
        End Try
    End Sub

    Private Sub FormatDataGridViews_schedules()
        ' Format the schedules DataGridView
        If DGVschedules.Rows.Count > 0 Then ' Check if there are rows
            With DGVschedules
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Room"
                .Columns(3).HeaderText = "Request Message"

                ' First, adjust the columns based on data length
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ' Then, set it back to Fill for a balanced layout
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        Else
            With DGVschedules
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Room"
                .Columns(3).HeaderText = "Request Message"

                ' No auto-size adjustment if no data
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        End If
    End Sub

End Class