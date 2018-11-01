Public Class Form1


    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

        PictureBox1.Image = ImageList3.Images(TrackBar1.Value - 1)


    End Sub
End Class
