Imports MySql.Data.MySqlClient

Module DB

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = "root"
    Private database As String = "ems"
    Public conn As MySqlConnection


    Public Function Connect() As Boolean
        Try
            Dim connectionString As String = $"Server={server};Database={database};User ID={username};Password={password};"
            conn = New MySqlConnection(connectionString)
            conn.Open()
            Return True

        Catch ex As Exception

            MessageBox.Show("Error connecting to the database: " & ex.Message)
            Return False

        End Try
    End Function
End Module