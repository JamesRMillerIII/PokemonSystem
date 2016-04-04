Public Class viewAll
    Private Sub viewAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PokemonDBDataSet.PokemonMainTable' table. You can move, or remove it, as needed.
        Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet.PokemonMainTable)

    End Sub
End Class