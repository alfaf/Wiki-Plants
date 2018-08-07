Imports System.Data.OleDb

Public Class Fav

    Private Sub BunifuFlatButton1_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton1.Click
        Plants.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton4.Click
        AboutUs.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton2.Click
        Search.Show()
        Me.Hide()
    End Sub

    Private Sub Fav_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.favourite' table. You can move, or remove it, as needed.
        Me.FavouriteTableAdapter.Fill(Me.DataSet1.favourite)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim OBJ As New desc
        Dim currentpID As String = DataRepeater1.CurrentItem.Controls("favPID").Text
        OBJ.pID = currentpID
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim currentpID As String = DataRepeater1.CurrentItem.Controls("favPID").Text

        Call connect()
        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = Con
            com.CommandText = "delete from favourite WHERE fp_ID = '" & currentpID & "'"
            com.ExecuteNonQuery()
            Button3.PerformClick()
            MsgBox("Removed from favorites!")

        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("Sorry! Could not remove from Favorites!")
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.FavouriteTableAdapter.Fill(Me.DataSet1.favourite)
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton5.Click
        Report.Show()
        Me.Hide()
    End Sub
End Class