Public Class Form1
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllToolStripMenuItem.Click
        viewAll.ShowDialog()
    End Sub

    Private Sub NewPokemonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPokemonToolStripMenuItem.Click
        createPokemon.ShowDialog()

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        updatePokemon.ShowDialog()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        deletePokemon.ShowDialog()
    End Sub

    Private Sub BuildNewTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuildNewTeamToolStripMenuItem.Click
        pokemonBuilder.ShowDialog()
    End Sub

    Private Sub CompareTeamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompareTeamsToolStripMenuItem.Click
        analyzePokemon.ShowDialog()
    End Sub
End Class
