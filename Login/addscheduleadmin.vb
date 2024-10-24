Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Imports ConnectionModule
Public Class addscheduleadmin

    Public Property rDate As String
    Public Property rTime As String
    Public Property rRoom As String

    Private Sub addscheduleadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnaddschedule.Enabled = False
        searchcbo()
        tableloader_rooms()
        tableroomsload()
    End Sub

    Private Sub searchcbo()
        ' Add options to ComboBox
        cbosearch.Items.Add("Room Name")
        cbosearch.Items.Add("Room Code")
        cbosearch.Items.Add("Building Letter")

        ' Set a default selection if desired
        cbosearch.SelectedIndex = 0 ' Selects the first item (Room Name) by default
    End Sub


    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        requestapproval.Show()
        Me.Hide()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtbuilding.Clear()
        txtrcode.Clear()
        txtrname.Clear()
        txtrdate.Clear()
        txtrday.Clear()
        txtrtime.Clear()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

    End Sub

    Private Sub tableloader_rooms()
        Dim query As String = "SELECT room_code, room_name, building_letter,room_status from roomlist" ' Use roomlist if you want to get room status from that table
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the sched table
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            DGVrooms.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving room statuses: " & ex.Message)
        End Try
    End Sub


    Private Sub tablesearcher_rooms()
        Dim category As String = cbosearch.Text()
        Dim search As String = txtsearchbox.Text()

        Dim query As String = ""

        ' Construct the SQL query based on the selected category
        Select Case category
            Case "Room Name"
                query = "SELECT * FROM roomlist WHERE room_name LIKE @search"
            Case "Room Code"
                query = "SELECT * FROM roomlist WHERE room_code LIKE @search"
            Case "Building Letter"
                query = "SELECT * FROM roomlist WHERE building_letter LIKE @search"
            Case Else
                MessageBox.Show("Please select a valid category.", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select

        ' Create the MySqlCommand object
        Dim command As New MySqlCommand(query, conn)

        ' Add the parameter for the search term, using '%' for partial matching
        command.Parameters.AddWithValue("@search", "%" & search & "%")

        Dim table As New DataTable()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Execute the query and fill the DataTable
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            DGVrooms.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving room list: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub tableroomsload()
        ' Format the schedules DataGridView
        If DGVrooms.Rows.Count > 0 Then ' Check if there are rows
            With DGVrooms
                .Columns(0).HeaderText = "Room Code"
                .Columns(1).HeaderText = "Room Name"
                .Columns(2).HeaderText = "Building"
                .Columns(3).HeaderText = "Statuts"

                ' First, adjust the columns based on data length
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ' Then, set it back to Fill for a balanced layout
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        Else
            With DGVrooms
                .Columns(0).HeaderText = "Room Code"
                .Columns(1).HeaderText = "Room Name"
                .Columns(2).HeaderText = "Building"
                .Columns(3).HeaderText = "Statuts"

                ' No auto-size adjustment if no data
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ' Check if a row is selected in the DataGridView
        If DGVrooms.SelectedRows.Count > 0 Then
            ' Retrieve the selected row
            Dim selectedRow As DataGridViewRow = DGVrooms.SelectedRows(0)

            ' Assign the values from the selected row to the text boxes
            txtrcode.Text = selectedRow.Cells("room_code").Value.ToString()   ' Assuming column name is "room_code"
            txtrname.Text = selectedRow.Cells("room_name").Value.ToString()   ' Assuming column name is "room_name"
            txtbuilding.Text = selectedRow.Cells("building_letter").Value.ToString() ' Assuming column name is "building_letter
        Else
            MessageBox.Show("Please select a room from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click

    End Sub
End Class