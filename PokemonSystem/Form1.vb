Public Class Form1
    'Overview:
    'As of now this is just all of the connections that will lead to other forms in this final project.

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Closes the program.
        Me.Close()
    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllToolStripMenuItem.Click
        'Goes to the view pokemon page.
        viewAll.ShowDialog()
    End Sub

    Private Sub NewPokemonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPokemonToolStripMenuItem.Click
        'Goes to the create pokemon page.
        createPokemon.ShowDialog()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        'Goes to the update pokemon page.
        updatePokemon.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        'Goes to the delete pokemon page.
        deletePokemon.ShowDialog()
    End Sub

    Private Sub BuildNewTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuildNewTeamToolStripMenuItem.Click
        'Goes to the pokemon builder
        pokemonBuilder.ShowDialog()
    End Sub

    Private Sub CompareTeamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompareTeamsToolStripMenuItem.Click
        'Goes to analyze pokemon page
        analyzePokemon.ShowDialog()
    End Sub
End Class
