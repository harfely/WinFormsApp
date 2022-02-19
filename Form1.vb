Public Class Form1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(TentangKu)
    End Sub

    Sub switchPanel(ByRef panel As Form)
        pnlKonten.Controls.Clear()
        panel.TopLevel = False
        pnlKonten.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(Pendidikan)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(Projek)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchPanel(Kontak)
    End Sub
End Class
