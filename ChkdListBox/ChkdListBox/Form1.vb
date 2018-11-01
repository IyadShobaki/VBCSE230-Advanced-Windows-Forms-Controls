Public Class Form1
    Dim bool1 As Boolean = False
    Dim bool2 As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If bool1 Then
            CheckedListBox1.SetItemChecked(0, False)
            bool1 = False
        Else
            CheckedListBox1.SetItemChecked(0, True)
            bool1 = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If bool2 Then
            CheckedListBox1.SetItemChecked(1, False)
            bool2 = False
        Else
            CheckedListBox1.SetItemChecked(1, True)
            bool2 = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckedListBox1.SetItemChecked(0, CheckState.Indeterminate)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not CheckedListBox1.Items.Contains("Four") Then
            CheckedListBox1.Items.Add("Four")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CheckedListBox1.Items.AddRange(New String() {"Five", "Six", "Seven"})
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CheckedListBox1.Items.Insert(2, "Two 1/2")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CheckedListBox1.Items.RemoveAt(2)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CheckedListBox1.Items.Remove("Three")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim aIndex As Integer
        aIndex = CheckedListBox1.Items.IndexOf("Two")
        MessageBox.Show(aIndex)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        CheckedListBox1.Items.Clear()
    End Sub
End Class
