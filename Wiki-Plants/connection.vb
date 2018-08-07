Imports System.Data.OleDb

Module connection
    Public Con As OleDbConnection
    Public Function connect()
        Try
            'Con = New OleDbConnection("Provider=SQLOLEDB;server=172.16.2.5;uid=4nm16cs433;pwd=4nm16cs433)
            Con = New OleDbConnection("Provider=SQLOLEDB;Data Source=VAIBHAV;Integrated Security=SSPI;Initial Catalog=wikiplants")
            Con.Open()

            'MsgBox("Connected to the database successfully")
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("Nol Data Available! Try Again")
        End Try
        Return Nothing
    End Function
End Module
