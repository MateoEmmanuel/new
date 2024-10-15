Imports MySql.Data.MySqlClient

Module ConnectionModule
    Public conn As MySqlConnection ' Make it public so it's accessible in Form1

    Public Sub DbConnect()
        Dim dbname As String = "Project"
        Dim username As String = "root"
        Dim password As String = "password"
        Dim server As String = "127.0.0.1"

        ' Initialize the connection if it is Nothing
        If conn Is Nothing Then
            conn = New MySqlConnection()
        End If

        ' Set up the connection string
        conn.ConnectionString = $"server={server};user id={username};password={password};database={dbname}"

        Try
            ' Open the connection
            If conn.State <> ConnectionState.Open Then
                conn.Open()
                ' for debugging: MsgBox("MySql Connected")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Module
