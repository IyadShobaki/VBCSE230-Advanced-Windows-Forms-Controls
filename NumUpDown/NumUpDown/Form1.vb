Public Class Form1
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Label1.Text = NumericUpDown1.Value


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = NumericUpDown1.Value
        Label2.Text = DomainUpDown1.Text
        Label3.Text = TrackBar1.Value
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged
        Label2.Text = DomainUpDown1.Text
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label3.Text = TrackBar1.Value

    End Sub
End Class
