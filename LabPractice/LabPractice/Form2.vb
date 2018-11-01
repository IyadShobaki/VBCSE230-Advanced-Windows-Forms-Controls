Imports System.ComponentModel

Public Class Form2
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        PictureBox1.Image = ImageList3.Images(TrackBar1.Value - 1)

        If TrackBar1.Value = 1 Then
            Label1.Text = "Honda"
        ElseIf TrackBar1.Value = 2 Then
            Label1.Text = "Jaguar"
        ElseIf TrackBar1.Value = 3 Then
            Label1.Text = "Lamborghini"
        ElseIf TrackBar1.Value = 4 Then
            Label1.Text = "Porche"
        End If

    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub


End Class