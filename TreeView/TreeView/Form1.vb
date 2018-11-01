Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tn As New TreeNode(TextBox1.Text)
        If TextBox1.Text = "" Then
            MessageBox.Show("Please put a name")
        Else

            TreeView1.Nodes.Add(tn)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TreeView1.SelectedNode IsNot Nothing Then
            If TextBox1.Text = "" Then
                MessageBox.Show("Please put a name")
            Else
                TreeView1.SelectedNode.Nodes.Add(New TreeNode(TextBox1.Text))
            End If

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
End Class
