Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DataSet3.Table1)
        'TODO: This line of code loads data into the 'DataSet31.Table1' table. You can move, or remove it, as needed.


    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class