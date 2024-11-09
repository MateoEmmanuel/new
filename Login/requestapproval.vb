Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class requestapproval
    Public Property U_ID As String

    Private Sub requestapproval_loader(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        LoadRequests()
        LoadSchedules()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to add a new schedule?", "Confirm Creation of New Schedule?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            ' If a row is selected in the schedules DataGridView
            If DGVrequest.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DGVschedules.SelectedRows(0)

                ' Create an instance of the add schedule form and pass selected data
                Dim addForm As New addscheduleadmin()
                addForm.rDate = selectedRow.Cells("Date").Value.ToString()
                addForm.rTime = selectedRow.Cells("Time").Value.ToString()
                addForm.rRoom = selectedRow.Cells("Room").Value.ToString()

                ' Show the add schedule form
                addForm.ShowDialog()
                Me.Hide()
            Else
                ' Show add schedule form without selecting a row
                addscheduleadmin.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If DGVrequest.SelectedRows.Count > 0 Then
            Dim selectedRequestID As Integer = Convert.ToInt32(DGVrequest.SelectedRows(0).Cells("requestID").Value)

            ' Confirm deletion of request
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected request?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                DeleteRequest(selectedRequestID)
            End If
        ElseIf DGVschedules.SelectedRows.Count > 0 Then
            Dim selectedShedID As Integer = Convert.ToInt32(DGVschedules.SelectedRows(0).Cells("shed_id").Value)

            ' Confirm deletion of schedule
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected schedule?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                DeleteSchedule(selectedShedID)
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    ' Delete request by ID
    Private Sub DeleteRequest(requestID As Integer)
        Dim query As String = "DELETE FROM requests WHERE requestID = @requestID"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@requestID", requestID)

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                cmd.ExecuteNonQuery()
                LoadRequests()
                MessageBox.Show("Request deleted successfully.")
            Catch ex As Exception
                MessageBox.Show("Error deleting request: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ' Delete schedule by ID
    Private Sub DeleteSchedule(shedID As Integer)
        Dim query As String = "DELETE FROM sched WHERE shed_id = @shed_id"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@shed_id", shedID)

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                cmd.ExecuteNonQuery()
                LoadRequests()
                MessageBox.Show("Schedule deleted successfully.")
            Catch ex As Exception
                MessageBox.Show("Error deleting schedule: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ' Load requests from the database and bind to DataGridView
    Private Sub LoadRequests()
        Dim query As String = "SELECT request_d, request_t, room, request, requestID FROM requests"
        Using adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            Try
                adapter.Fill(table)
                DGVrequest.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error retrieving requests: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Admin.Show()
        Me.Hide()
    End Sub
End Class
