Public Class Kontak

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        lblNama.Text = txtNama.Text
        lblEmail.Text = txtEmail.Text
        lblTTL.Text = dtpTTL.Text
        lblPesan.Text = txtPesan.Text


        Dim status As String
        If cmbPilihan.SelectedIndex < 0 Then
            status = "Maaf Anda diharampkan mengisi Pilihan Konsultasi"
            MsgBox(status)
        Else
            status = cmbPilihan.SelectedItem.ToString
            lblPilihan.Text = status
        End If
    End Sub
End Class