Public Class updatePokemon

    'This button will Not only check To see If there are any errors In the input Of the pokemon but will also save it To the database.
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Declare local varibles
        Dim strpokemonName As String
        Dim strpokemonTier As String
        Dim strpokemonType1 As String
        Dim strpokemonType2 As String
        Dim intID As Integer
        Dim intHP As Integer
        Dim intAttack As Integer
        Dim intDefense As Integer
        Dim intSpecialAttack As Integer
        Dim intSpecialDefense As Integer
        Dim intSpeed As Integer


        'Have some string variables equal from a control
        strpokemonType1 = cboType1.Text
        strpokemonType2 = cboType2.Text
        strpokemonName = cboName.Text
        ' strpokemonTier = cboTier.Text
        intID = CInt(LabelID.Text)

        'validate the input for all varibles
        Try
            intHP = CInt(txtHP.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtHP.Clear()
            txtHP.Focus()
        End Try

        Try
            intAttack = CInt(txtAttack.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtAttack.Clear()
            txtAttack.Focus()
        End Try

        Try
            intDefense = CInt(txtDefense.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtDefense.Clear()
            txtDefense.Focus()
        End Try

        Try
            intSpecialAttack = CInt(txtSpecialAttack.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtSpecialAttack.Clear()
            txtSpecialAttack.Focus()
        End Try

        Try
            intSpecialDefense = CInt(txtSpecialDefense.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtSpecialDefense.Clear()
            txtSpecialDefense.Focus()
        End Try

        Try
            intSpeed = CInt(txtSpeed.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a numeric value.")
            txtSpeed.Clear()
            txtSpeed.Focus()
        End Try

        'decalre connection to the database
        Dim sqlconn = New SqlClient.SqlConnection("Data Source=DESKTOP-KGMCUKK\SQLEXPRESS;Initial Catalog=PokemonDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlCmd As New SqlClient.SqlCommand
        'Open the connection
        sqlconn.Open()
        sqlCmd.Connection = sqlconn

        'declare sql parameters for all stats.
        Dim typeOneParam As New SqlClient.SqlParameter
        typeOneParam.SqlDbType = SqlDbType.NVarChar
        typeOneParam.Direction = ParameterDirection.Input
        typeOneParam.Value = strpokemonType1
        typeOneParam.ParameterName = "@typeOne"

        Dim typeTwoParam As New SqlClient.SqlParameter
        typeTwoParam.SqlDbType = SqlDbType.NVarChar
        typeTwoParam.Direction = ParameterDirection.Input
        typeTwoParam.Value = strpokemonType2
        typeTwoParam.ParameterName = "@typeTwo"

        'Dim pokemonTeir As New SqlClient.SqlParameter
        'pokemonTeir.SqlDbType = SqlDbType.NVarChar
        'pokemonTeir.Direction = ParameterDirection.Input
        'pokemonTeir.Value = strpokemonTier
        'pokemonTeir.ParameterName = "@pokemonTeir"

        Dim pokemonName As New SqlClient.SqlParameter
        pokemonName.SqlDbType = SqlDbType.NVarChar
        pokemonName.Direction = ParameterDirection.Input
        pokemonName.Value = strpokemonName
        pokemonName.ParameterName = "@pokemonName"

        Dim pokemonID As New SqlClient.SqlParameter
        pokemonID.SqlDbType = SqlDbType.Int
        pokemonID.Direction = ParameterDirection.Input
        pokemonID.Value = intID
        pokemonID.ParameterName = "@pokemonID"

        Dim pokemonHP As New SqlClient.SqlParameter
        pokemonHP.SqlDbType = SqlDbType.Int
        pokemonHP.Direction = ParameterDirection.Input
        pokemonHP.Value = intHP
        pokemonHP.ParameterName = "@pokemonHP"

        Dim pokemonAttk As New SqlClient.SqlParameter
        pokemonAttk.SqlDbType = SqlDbType.Int
        pokemonAttk.Direction = ParameterDirection.Input
        pokemonAttk.Value = intAttack
        pokemonAttk.ParameterName = "@pokemonAttk"

        Dim pokemonDef As New SqlClient.SqlParameter
        pokemonDef.SqlDbType = SqlDbType.Int
        pokemonDef.Direction = ParameterDirection.Input
        pokemonDef.Value = intDefense
        pokemonDef.ParameterName = "@pokemonDef"

        Dim pokemonSpAttk As New SqlClient.SqlParameter
        pokemonSpAttk.SqlDbType = SqlDbType.Int
        pokemonSpAttk.Direction = ParameterDirection.Input
        pokemonSpAttk.Value = intSpecialAttack
        pokemonSpAttk.ParameterName = "@pokemonSpAttk"

        Dim pokemonSpDef As New SqlClient.SqlParameter
        pokemonSpDef.SqlDbType = SqlDbType.Int
        pokemonSpDef.Direction = ParameterDirection.Input
        pokemonSpDef.Value = intSpecialDefense
        pokemonSpDef.ParameterName = "@pokemonSpDef"

        Dim pokemonSpeed As New SqlClient.SqlParameter
        pokemonSpeed.SqlDbType = SqlDbType.Int
        pokemonSpeed.Direction = ParameterDirection.Input
        pokemonSpeed.Value = intSpeed
        pokemonSpeed.ParameterName = "@pokemonSpeed"

        'Add all said parameteres
        sqlCmd.Parameters.Add(pokemonName)
        sqlCmd.Parameters.Add(typeOneParam)
        sqlCmd.Parameters.Add(typeTwoParam)
        '  sqlCmd.Parameters.Add(pokemonTeir)
        sqlCmd.Parameters.Add(pokemonID)
        sqlCmd.Parameters.Add(pokemonHP)
        sqlCmd.Parameters.Add(pokemonAttk)
        sqlCmd.Parameters.Add(pokemonDef)
        sqlCmd.Parameters.Add(pokemonSpAttk)
        sqlCmd.Parameters.Add(pokemonSpDef)
        sqlCmd.Parameters.Add(pokemonSpeed)

        'Useing sql to update the database.
        sqlCmd.CommandText = "UPDATE PokemonMainTable SET [Type 1] = @typeOne, [Type 2] = @typeTwo, [Pokemon Name] = @pokemonName, [HP] = @pokemonHP, [Attack] = @pokemonAttk, [Defense] = @pokemonDef, [Special Attack] = @pokemonSpAttk, [Special Defense] = @pokemonSpDef, [Speed] = @pokemonSpeed" &
            " WHERE [Id] =  @pokemonID"

        'Using this line as a tester for sql commands. Will delete later.
        Dim result As Integer = sqlCmd.ExecuteNonQuery





        'Testing some stuff and will clean this up latter.


        'With sqlCmd
        '    .Connection = sqlconn
        '    If cmbTeir.Text = "All" Then
        '        .CommandText = "Select [pokemon name] + ',' + [Teir] from pokemonmaintable"
        '    Else
        '        .CommandText = "Select [pokemon name] + ',' + [Teir] from pokemonmaintable where [Teir] = '" & cmbTeir.Text.ToString() & "'"
        '    End If


        'End With
        'Dim dReader As SqlClient.SqlDataReader = sqlCmd.ExecuteReader
        'lstPokemonList.Items.Clear()

        'For Each item In dReader
        '    lstPokemonList.Items.Add(item(0))
        'Next

        'close sql connection
        sqlconn.Close()




    End Sub

    Private Sub updatePokemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Preload a pokemon that is first in the database.
        Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet1.PokemonMainTable)
        Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet.PokemonMainTable)

    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        'declare local table adapter
        Dim pdt As New pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter
        'useing this to get our selected value
        LabelID.Text = cboName.SelectedValue

        'declare local database connection
        Dim sqlconn = New SqlClient.SqlConnection("Data Source=DESKTOP-KGMCUKK\SQLEXPRESS;Initial Catalog=PokemonDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlCmd As New SqlClient.SqlCommand
        'open database connection.
        sqlconn.Open()

        'Like the update button code, this grabs the pokemon based upon the id.
        Dim pokemonID As New SqlClient.SqlParameter
        pokemonID.SqlDbType = SqlDbType.Int
        pokemonID.Direction = ParameterDirection.Input
        pokemonID.Value = CInt(LabelID.Text)
        pokemonID.ParameterName = "@pokemonID"

        'with sql comands, we are searching the pokemon based upon the id that the pokemon has and displaying that for the user.
        With sqlCmd
            .Connection = sqlconn
            .CommandText = "Select * FROM PokemonMainTable WHERE Id =  @pokemonID"
            .Parameters.Add(pokemonID)

        End With

        'declare local sql reader
        Dim dReader As SqlClient.SqlDataReader = sqlCmd.ExecuteReader

        'useing an array called item, we now can display the pokemon and its stats in the correct places.
        For Each item In dReader
            cboTier.SelectedItem = item(2)
            cboType1.SelectedItem = item(3)
            cboType2.SelectedItem = item(4)
            txtHP.Text = item(5)
            txtAttack.Text = item(6)
            txtDefense.Text = item(6)
            txtSpecialAttack.Text = item(7)
            txtSpecialDefense.Text = item(8)
            txtSpeed.Text = item(9)

        Next

        'close sql connection
        sqlconn.Close()

    End Sub

    'Not sure if windows had put this in while im codeing, will test it out and polish this if nessesary.
    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PokemonMainTableTableAdapter.FillBy2(Me.PokemonDBDataSet.PokemonMainTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class