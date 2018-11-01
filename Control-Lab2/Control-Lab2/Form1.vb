Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tn As New TreeNode(TextBox1.Text)
        If TextBox1.Text = "textbox1" Or TextBox1.Text = "" Then
            MessageBox.Show("Please put a text in textbox1")
        Else
            TreeView1.Nodes.Add(tn)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TreeView1.SelectedNode IsNot Nothing Then
            TreeView1.SelectedNode.Nodes.Add(New TreeNode(TextBox1.Text))

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TreeView1.SelectedNode.Remove()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TreeView1.SelectedNode.IsExpanded Then
            TreeView1.SelectedNode.Collapse()
        Else
            TreeView1.SelectedNode.Expand()

        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Add(TreeView1.SelectedNode.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim selecteditems = (From i In ListBox1.SelectedItems).ToList
        For Each selectitem In selecteditems
            TreeView1.Nodes.Add(selectitem)

        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim selecteditems = (From i In ListBox1.SelectedItems).ToList
        For Each selectitem In selecteditems
            TreeView1.Nodes.Insert(1, selectitem)

        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim selecteditems = (From i In ListBox1.SelectedItems).ToList
        For Each selectitem In selecteditems
            ListBox1.Items.Remove(selectitem)

        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = "textbox1" Or TextBox1.Text = "" Then
            MessageBox.Show("Please put a text in textbox1")
        Else
            ListBox1.Items.Add(TextBox1.Text)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub
End Class
