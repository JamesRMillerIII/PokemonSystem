'Import the sql server commands
Imports Microsoft.SqlServer
Public Class createPokemon
    'This button is used to save pokemon, and all the states thereof in the database specified. 
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Declare all local varibles
        Dim strpokemonName As String
        Dim strpokemonTier As String
        Dim strpokemonType1 As String
        Dim strpokemonType2 As String
        Dim intHP As Integer
        Dim intAttack As Integer
        Dim intDefense As Integer
        Dim intSpecialAttack As Integer
        Dim intSpecialDefense As Integer
        Dim intSpeed As Integer

        'Set string variables to the appropriate text boxes.
        strpokemonName = txtPokemonName.Text
        strpokemonTier = cboTeir.Text
        strpokemonType1 = cboType1.Text
        strpokemonType2 = cboType2.Text

        'While collecting for the local variables we are doing input validation
        Try
            intHP = CInt(txtHP.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtHP.Clear()
            txtHP.Focus()
        End Try

        'local variable collection for attack
        Try
            intAttack = CInt(txtAttack.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtAttack.Clear()
            txtAttack.Focus()
        End Try

        'local variable collection for defense
        Try
            intDefense = CInt(txtDefense.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtDefense.Clear()
            txtDefense.Focus()
        End Try

        'local variable collection for special attack
        Try
            intSpecialAttack = CInt(txtSpecialAttack.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtSpecialAttack.Clear()
            txtSpecialAttack.Focus()
        End Try

        'local variable collection for special defense
        Try
            intSpecialDefense = CInt(txtSpecialDefense.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtSpecialDefense.Clear()
            txtSpecialDefense.Focus()
        End Try

        'local variable collection for speed
        Try
            intSpeed = CInt(txtSpeed.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtSpeed.Clear()
            txtSpeed.Focus()
        End Try


        'declare local table adapter
        Dim pdt As New pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter

        'command the table adapter to insert all of the collect local variables to the database. 
        pdt.Insert(strpokemonName, strpokemonTier, strpokemonType1, strpokemonType2, intHP, intAttack, intDefense, intSpecialAttack, intSpecialDefense, intSpeed)



    End Sub
End Class