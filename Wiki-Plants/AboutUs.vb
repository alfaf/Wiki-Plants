Public Class AboutUs

    Private Sub BunifuImageButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton1.Click
        Plants.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton3.Click
        Fav.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton2.Click
        Search.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton5.Click
        Report.Show()
        Me.Hide()
    End Sub
End Class