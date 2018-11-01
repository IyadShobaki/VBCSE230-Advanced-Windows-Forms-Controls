Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item")
        Else
            Dim selecteditems = (From i In ListBox1.SelectedItems).ToList
            For Each selectitem In selecteditems
                ListBox2.Items.Add(selectitem)
                ListBox1.Items.Remove(selectitem)
            Next

        End If
    End Sub
End Class
