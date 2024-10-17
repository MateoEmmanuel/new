﻿Imports MySql.Data.MySqlClient
Imports ConnectionModule

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a new TableLayoutPanel and set Dock to fill the form
        Dim tableLayoutPanel As New TableLayoutPanel()
        tableLayoutPanel.Dock = DockStyle.Fill

        ' Set the number of rows and columns
        tableLayoutPanel.RowCount = 6
        tableLayoutPanel.ColumnCount = 5

        ' Define row styles based on the percentages you provided
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.56F)) ' Row 1
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 7.56F))  ' Row 2
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 8.67F))  ' Row 3
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 9.56F))  ' Row 4
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 8.22F))  ' Row 5
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.56F)) ' Row 6

        ' Define column styles based on the percentages you provided
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F)) ' Column 1
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.67F)) ' Column 2
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.67F)) ' Column 3
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31.13F)) ' Column 4
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2.38F))  ' Column 5

        ' Optionally, add controls to specific cells
        Dim label1 As New Label()
        label1.Text = "Label 1"
        label1.Dock = DockStyle.Fill
        tableLayoutPanel.Controls.Add(label1, 0, 0) ' (column, row)

        ' Add TableLayoutPanel to the form
        Me.Controls.Add(tableLayoutPanel)
        DbConnect() ' Ensure the connection is established when the form loads
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = txtuname.Text.Trim()
        Dim password As String = txtpassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MsgBox("Username or Password is Incorrect, Please Try Again!")
            Return
        End If

        Try
            ' Ensure the connection is open
            If conn.State <> ConnectionState.Open Then
                DbConnect()
            End If

            ' Combine the login and account level query in one
            Dim query As String = "SELECT accesslevel FROM accounts WHERE username=@username AND pword=@pword"
            Dim command As New MySqlCommand(query, conn)

            ' Add parameters to the command
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@pword", password)

            ' Execute the query and check if user exists
            Using reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    reader.Read() ' Move to the first row
                    Dim accountlevel As String = reader("accesslevel").ToString().ToLower() ' Get account level in lowercase

                    ' Close the reader as it's no longer needed
                    reader.Close()

                    ' Open different forms based on account level
                    Select Case accountlevel
                        Case "low"
                            Dim low As New Student()
                            low.Show() ' Open Form3 for low level account UI
                            Me.Hide() ' Hide current form
                        Case "mid"
                            Dim mid As New Staff()
                            mid.Show() ' Open Form4 for mid level account UI
                            Me.Hide() ' Hide current form
                        Case "high"
                            Dim high As New Admin()
                            high.Show() ' Open Form5 for high level account UI
                            Me.Hide() ' Hide current form
                        Case Else
                            MsgBox("Error: Account level not recognized")
                    End Select

                    MsgBox("Welcome " & username)
                    txtpassword.Clear()
                    txtuname.Clear()
                Else
                    MsgBox("Username or Password is Incorrect, Please Try Again!")
                End If
            End Using ' Reader and connection will be properly closed here

        Catch ex As MySqlException
            MsgBox("Database Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ' Close the connection if it's open
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        ' Ensure the connection is closed
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Dim create As New Form2()
        create.Show() ' Open Form2 for account creation
        Me.Hide() ' Hide Form1
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Application.Exit()
    End Sub
End Class
