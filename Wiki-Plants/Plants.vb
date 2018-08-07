Imports System.Data.OleDb

Public Class Plants
    Public currentpID As String
    Private Sub BunifuImageButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub
    Private Sub BunifuFlatButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton2.Click
        Search.Show()
        Me.Hide()
    End Sub

    Private Sub Plants_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PlantDataSet.PLANT' table. You can move, or remove it, as needed.
        Me.PLANTTableAdapter.Fill(Me.PlantDataSet.PLANT)
        Dim i As Integer
        Dim x As Integer

        For i = 0 To PLANTBindingSource.Count - 1
            x = x + 1
            PLANTBindingSource.MoveNext()
        Next
        totalPlants.Text = CStr(x)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton3.Click
        Fav.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton4.Click
        AboutUs.Show()
        Me.Hide()
    End Sub

    Private Sub PLANTBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PLANTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PlantDataSet)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim OBJ As New desc
        Dim currentpID As String = DataRepeater1.CurrentItem.Controls("P_IDTextBox").Text
        Dim currentPName As String = DataRepeater1.CurrentItem.Controls("P_nameTextBox").Text
        OBJ.pID = currentpID
        OBJ.pName = currentPName
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub info_Click(sender As System.Object, e As System.EventArgs)
        Button1.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim currentpID As String = DataRepeater1.CurrentItem.Controls("P_IDTextBox").Text
        Dim currentpName As String = DataRepeater1.CurrentItem.Controls("P_nameTextBox").Text

        Call connect()
        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = Con
            com.CommandText = "insert into favourite values('" & currentpID & "','" & currentpName & "')"
            com.ExecuteNonQuery()
            MsgBox("Added to favorites!")

        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("Item Already Added into Favorites!")
        End Try
    End Sub

    'Private Sub Button1_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button1.MouseHover
    '   Button1.Image = My.Resources.HverUntitled
    'End Sub

    'Private Sub Button2_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button2.MouseHover
    '   Button1.Image = My.Resources.HoverUntitled
    'End Sub

    'Private Sub Button1_MouseLeave(sender As Object, e As System.EventArgs) Handles Button1.MouseLeave
    '   Button1.Image = My.Resources.gget
    'End Sub

    'Private Sub Button2_MouseLeave(sender As Object, e As System.EventArgs) Handles Button2.MouseLeave
    '   Button1.Image = My.Resources.Unffftitled
    'End Sub

    Private Sub BunifuFlatButton5_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton5.Click
        Report.Show()
        Me.Hide()
    End Sub
End Class