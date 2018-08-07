Imports System.Data.OleDb
Imports System.IO

Public Class Search

    Private Sub BunifuFlatButton1_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton1.Click
        Plants.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton3.Click
        Fav.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton4.Click
        AboutUs.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub Search_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PlantDataSet1.BIO' table. You can move, or remove it, as needed.
        'Me.BIOTableAdapter.Fill(Me.PlantDataSet1.BIO)
        Call connect()
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            adapt = New OleDbDataAdapter("select p_name from PLANT", Con)
            dt = New DataTable
            adapt.Fill(dt)
            sbyname.DataSource = dt
            sbyname.DisplayMember = "p_name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            adapt = New OleDbDataAdapter("select p_ID from PLANT", Con)
            dt = New DataTable
            adapt.Fill(dt)
            sbyid.DataSource = dt
            sbyid.DisplayMember = "p_ID"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub resultgetInfo_Click(sender As System.Object, e As System.EventArgs)
        fuc(sbyid.Text)
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton6.Click
        'MsgBox(sbyid.Text)
        Button2.PerformClick()
        resultPlantID1.Visible = True
        resultPlantName1.Visible = True
        resultPpicture.Visible = True
        resultPID.Visible = True
        resultPname.Visible = True
        getInfo1.Visible = True
        addFav1.Visible = True
        resultaddFav.Visible = True
        resultgetInfo.Visible = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'MsgBox(sbyname.Text)
        Call connect()
        Dim img() As Byte
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from PLANT WHERE p_name = '" & sbyname.Text & "'", Con)
            dt = New DataTable
            adapt.Fill(dt)
            img = dt.Rows(0)(2)
            Dim ms As New MemoryStream(img)
            resultPpicture.Image = Image.FromStream(ms)
            resultPID.Text = dt.Rows(0).Item("p_ID").ToString()
            resultPname.Text = dt.Rows(0).Item("p_name").ToString()
        Catch ex As Exception
            'MsgBox(ex.Message)
            resultPID.Text = "No Data Available"
            resultPname.Text = "No Data Available"
        End Try
    End Sub
    Private Sub fuc(a As String)
        MsgBox(sbyid.Text)
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton5.Click
        Button1.PerformClick()
        resultPlantID1.Visible = True
        resultPlantName1.Visible = True
        resultPpicture.Visible = True
        resultPID.Visible = True
        resultPname.Visible = True
        getInfo1.Visible = True
        addFav1.Visible = True
        resultaddFav.Visible = True
        resultgetInfo.Visible = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call connect()
        Dim img() As Byte
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from PLANT WHERE p_ID = '" & sbyid.Text & "'", Con)
            dt = New DataTable
            adapt.Fill(dt)
            img = dt.Rows(0)(2)
            Dim ms As New MemoryStream(img)
            resultPpicture.Image = Image.FromStream(ms)
            resultPID.Text = dt.Rows(0).Item("p_ID").ToString()
            resultPname.Text = dt.Rows(0).Item("p_name").ToString()
        Catch ex As Exception
            'MsgBox(ex.Message)
            resultPID.Text = "No Data Available"
            resultPname.Text = "No Data Available"
        End Try
    End Sub

    Private Sub resultgetInfo_Click_1(sender As System.Object, e As System.EventArgs) Handles resultgetInfo.Click
        Dim OBJ As New desc
        Dim currentpID As String = sbyid.Text
        OBJ.pID = currentpID
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub getInfo1_Click(sender As System.Object, e As System.EventArgs) Handles getInfo1.Click
        resultgetInfo.PerformClick()
    End Sub

    Private Sub resultaddFav_Click(sender As System.Object, e As System.EventArgs) Handles resultaddFav.Click
        Dim currentpID As String = resultPID.Text
        Dim currentpName As String = resultPname.Text

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

    Private Sub addFav1_Click(sender As System.Object, e As System.EventArgs) Handles addFav1.Click
        resultaddFav.PerformClick()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton7.Click
        Report.Show()
        Me.Hide()
    End Sub
End Class