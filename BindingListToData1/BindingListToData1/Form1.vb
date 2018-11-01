Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Sorted = True
        'TODO: This line of code loads data into the 'FpnwindDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.FpnwindDataSet.Products)

    End Sub
End Class
