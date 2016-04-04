Public Class updatePokemon
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'This button will not only check to see if there are any errors in the input of the pokemon but will also save it to the database.


        Dim strpokemonTier As String
        Dim strpokemonType1 As String
        Dim strpokemonType2 As String
        Dim intHP As Integer
        Dim intAttack As Integer
        Dim intDefense As Integer
        Dim intSpecialAttack As Integer
        Dim intSpecialDefense As Integer
        Dim intSpeed As Integer



        strpokemonType1 = cboType1.Text
        strpokemonType2 = cboType2.Text

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



        Dim pdt As New pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter

        ' pdt.Insert(strpokemonName, strpokemonTier, strpokemonType1, strpokemonType2, intHP, intAttack, intDefense, intSpecialAttack, intSpecialDefense, intSpeed)


        '        Dim sqlConn As New SqlClient.SqlConnection("Data Source=DESKTOP-KGMCUKK\SQLEXPRESS;Initial Catalog=PokemonDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        '        sqlConn.Open()

        '        Dim sqlcommand As New SqlClient.SqlCommand("insert into dbo.PokemonMainTable ([Pokemon Name],[teir],[type 1],[type 2],[hp],[attack],[defense],
        '[special attack],[special defense],[speed]) values ("",'','','',0,0,0,0,0,0)", sqlConn)

        '        Dim results As Integer = sqlcommand.ExecuteNonQuery()

        Dim s = "stop"


    End Sub

    Private Sub updatePokemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PokemonDBDataSet1.PokemonMainTable' table. You can move, or remove it, as needed.
        Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet1.PokemonMainTable)
        'TODO: This line of code loads data into the 'PokemonDBDataSet.PokemonMainTable' table. You can move, or remove it, as needed.
        Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet.PokemonMainTable)

    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        Dim pdt As New pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter


    End Sub

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PokemonMainTableTableAdapter.FillBy2(Me.PokemonDBDataSet.PokemonMainTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class