Imports System.Data.OleDb
Imports System.IO

Public Class desc

    Private Sub BunifuFlatButton9_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton9.Click
        TabControl1.SelectedTab = ConatactTabPage
    End Sub
    Public Property pID As String
    Public Property pName As String
    Private Sub desc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call connect()
        Dim img() As Byte
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from PLANT WHERE p_ID = '" & pID & "'", Con)
            dt = New DataTable
            adapt.Fill(dt)
            img = dt.Rows(0)(2)
            Dim ms As New MemoryStream(img)
            plantPicture.Image = Image.FromStream(ms)
            tbplant.Text = dt.Rows(0).Item("p_name").ToString()
        Catch ex As Exception
            'MsgBox(ex.Message)
            tbplant.Text = "No Data Available"
        End Try
        Try
            adapt = New OleDbDataAdapter("select * from BIO WHERE pb_ID = '" & pID & "'", Con)
            dt = New DataTable
            adapt.Fill(dt) 
            tbpID.Text = dt.Rows(0).Item("pb_ID").ToString()
            tbscn.Text = dt.Rows(0).Item("scientific_name").ToString()
            tbfamily.Text = dt.Rows(0).Item("family").ToString()
            tbcolor.Text = dt.Rows(0).Item("color").ToString()
            tbgenus.Text = dt.Rows(0).Item("genus").ToString()
            tbdesc.Text = dt.Rows(0).Item("description").ToString()
            tbseason.Text = dt.Rows(0).Item("season").ToString()
            tbloc.Text = dt.Rows(0).Item("plocation").ToString()
            tbgrowth.Text = dt.Rows(0).Item("growth_req").ToString()
            tbadv.Text = dt.Rows(0).Item("advantages").ToString()
            tbdisadv.Text = dt.Rows(0).Item("disadvantages").ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
            tbpID.Text = "No Data Available"
            tbscn.Text = "No Data Available"
            tbfamily.Text = "No Data Available"
            tbcolor.Text = "No Data Available"
            tbgenus.Text = "No Data Available"
            tbdesc.Text = "No Data Available"
            tbseason.Text = "No Data Available"
            tbloc.Text = "No Data Available"
            tbgrowth.Text = "No Data Available"
            tbadv.Text = "No Data Available"
            tbdisadv.Text = "No Data Available"
        End Try
        Try
            adapt = New OleDbDataAdapter("select ss_ID from sell WHERE sp_ID = '" & pID & "'", Con)
            dt = New DataTable
            adapt.Fill(dt)
            Dim ssid As String = dt.Rows(0).Item("ss_ID").ToString
            Try
                adapt = New OleDbDataAdapter("select * from SELLER WHERE s_ID = '" & ssid & "'", Con)
                dt = New DataTable
                adapt.Fill(dt)
                tbselname.Text = dt.Rows(0).Item("s_name").ToString()
                tbseloc.Text = dt.Rows(0).Item("s_location").ToString()
                tbselno.Text = dt.Rows(0).Item("s_contact").ToString()
                tbemail.Text = dt.Rows(0).Item("s_email").ToString()
            Catch ex As Exception
                'MsgBox(ex.Message)
                MsgBox("No Data Available")
                tbselname.Text = "No Data Available"
                tbseloc.Text = "No Data Available"
                tbselno.Text = "No Data Available"
                tbemail.Text = "No Data Available"
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("No Data Available")
        End Try
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton5.Click
        Plants.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton10.Click
        Dim currentpID As String = pID
        Dim currentpName As String = pName

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
            MsgBox("Item is already in Favorites List!")
        End Try
    End Sub

End Class