Public Class Form1
    Private imageNum As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim b As New System.Drawing.Bitmap(My.Resources.Cleveland)
        PictureBox1.Image = b

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m As New System.Drawing.Bitmap(My.Resources.Miami)
        PictureBox1.Image = m
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.Normal

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PictureBox2.Image = ImageList1.Images(imageNum)
        imageNum += 1
        If imageNum = 3 Then imageNum = 0
    End Sub


End Class
