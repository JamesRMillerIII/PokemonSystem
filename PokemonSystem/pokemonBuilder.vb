Public Class pokemonBuilder
    Private Sub pokemonBuilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PokemonDBDataSet.PokemonMainTable' table. You can move, or remove it, as needed.
        Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet.PokemonMainTable)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstTeamList.Items.Add(lstPokemonList.SelectedValue)
        lstPokemonList.Items.RemoveAt(lstPokemonList.SelectedIndex)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstTeamList.Items.RemoveAt(lstTeamList.SelectedIndex)
    End Sub
End Class