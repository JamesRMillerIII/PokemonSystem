Public Class deletePokemon
    Private Sub deletePokemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PokemonDBDataSet.PokemonMainTable' table. You can move, or remove it, as needed.
        Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet.PokemonMainTable)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim pdt As New pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter

        Dim item As Integer = dgvDelete.SelectedRows.Item(0).Cells(0).Value


        pdt.DeleteById(item)


    End Sub


End Class