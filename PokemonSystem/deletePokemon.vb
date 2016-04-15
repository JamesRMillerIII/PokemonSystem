Public Class deletePokemon
    Private Sub deletePokemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load the table for user viewing
        Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet.PokemonMainTable)

    End Sub
    'This button will delete a pokemon from the database, the id primary key that was used by this particular pokemon will be retired.
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'declare local table adapter
        Dim pdt As New pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter

        'declare item that will get the value of the primary key of the pokemon that we want to delete.
        Dim item As Integer = dgvDelete.SelectedRows.Item(0).Cells(0).Value

        'This deletes the pokemon.
        pdt.DeleteById(item)


    End Sub


End Class