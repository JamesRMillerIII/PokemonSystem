Public Class viewAll
    Private Sub viewAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using one line to view all of the pokemon in the load code.
        Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet.PokemonMainTable)

    End Sub
End Class