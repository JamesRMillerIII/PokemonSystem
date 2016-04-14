Public Class updatePokemon
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'This button will not only check to see if there are any errors in the input of the pokemon but will also save it to the database.


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



        strpokemonType1 = cboType1.Text
        strpokemonType2 = cboType2.Text
        strpokemonName = cboName.Text
        intID = CInt(LabelID.Text)


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


        Dim sqlconn = New SqlClient.SqlConnection("Data Source=DESKTOP-KGMCUKK\SQLEXPRESS;Initial Catalog=PokemonDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlCmd As New SqlClient.SqlCommand
        sqlconn.Open()
        sqlCmd.Connection = sqlconn
        Dim typeOneParam As New SqlClient.SqlParameter
        typeOneParam.SqlDbType = SqlDbType.NVarChar
        typeOneParam.Direction = ParameterDirection.Input
        typeOneParam.Value = strpokemonType1
        typeOneParam.ParameterName = "@typeOne"


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


        sqlCmd.Parameters.Add(pokemonName)
        sqlCmd.Parameters.Add(typeOneParam)
        sqlCmd.Parameters.Add(pokemonID)
        sqlCmd.Parameters.Add(pokemonHP)
        sqlCmd.Parameters.Add(pokemonAttk)
        sqlCmd.CommandText = "UPDATE PokemonMainTable SET [Type 1] = @typeOne, [Pokemon Name] = @pokemonName, [HP] = @pokemonHP, [Attack] = @pokemonAttk" &
            " WHERE [Id] =  @pokemonID"

        Dim result As Integer = sqlCmd.ExecuteNonQuery








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
        sqlconn.Close()




    End Sub

    Private Sub updatePokemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PokemonDBDataSet1.PokemonMainTable' table. You can move, or remove it, as needed.
        Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet1.PokemonMainTable)
        'TODO: This line of code loads data into the 'PokemonDBDataSet.PokemonMainTable' table. You can move, or remove it, as needed.
        Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet.PokemonMainTable)

    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        Dim pdt As New pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter
        LabelID.Text = cboName.SelectedValue

        Dim sqlconn = New SqlClient.SqlConnection("Data Source=DESKTOP-KGMCUKK\SQLEXPRESS;Initial Catalog=PokemonDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlCmd As New SqlClient.SqlCommand
        sqlconn.Open()


        Dim pokemonID As New SqlClient.SqlParameter
        pokemonID.SqlDbType = SqlDbType.Int
        pokemonID.Direction = ParameterDirection.Input
        pokemonID.Value = CInt(LabelID.Text)
        pokemonID.ParameterName = "@pokemonID"


        With sqlCmd
            .Connection = sqlconn
            .CommandText = "Select * FROM PokemonMainTable WHERE Id =  @pokemonID"
            .Parameters.Add(pokemonID)

        End With


        Dim dReader As SqlClient.SqlDataReader = sqlCmd.ExecuteReader

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

        sqlconn.Close()

    End Sub

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PokemonMainTableTableAdapter.FillBy2(Me.PokemonDBDataSet.PokemonMainTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class