'Import the sql server for sql functions.
'Import the necessary items for file IO so we can write to the file.
Imports Microsoft.SqlServer.Server
Imports System.IO
Imports System.Text
Public Class pokemonBuilder

    'This is the load function for the pokemon builder form. This particular form load a connection, open it, and load in the appropriate items needed.
    Private Sub pokemonBuilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'declare sql connection.
        Dim sqlconn = New SqlClient.SqlConnection("Data Source=DESKTOP-KGMCUKK\SQLEXPRESS;Initial Catalog=PokemonDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlCmd As New SqlClient.SqlCommand
        'Open the connection.
        sqlconn.Open()

        'using a with statement to do multiple sql commands
        With sqlCmd
            .Connection = sqlconn
            .CommandText = "Select [pokemon name] + ', ' + [Teir] from pokemonMainTable"
        End With

        'declare a local sql data reader
        Dim dReader As SqlClient.SqlDataReader = sqlCmd.ExecuteReader
        'Now we read from the database and load the right items to the list box.
        For Each item In dReader
            lstPokemonList.Items.Add(item(0))
        Next
        'Remember to close the sql connection for security and programing purpose.
        sqlconn.Close()

    End Sub

    'This particular button takes the selected pokemon and transfers it to a list that is your team.
    'This button also makes sure that teams can have no more than six pokemon, and are all from a particular tier.
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Declare local variables.
        Dim isValid As Boolean = True
        Dim responseMsg As String = ""

        'Making sure that something is selected
        If lstPokemonList.SelectedIndex > -1 Then
            'creating an array to get all necessary items
            Dim strpokemonTeir() As String = lstPokemonList.SelectedItem.ToString.Split(",")

            'Enforcing that the team count is less than 6 but greater than 0.
            If lstTeamList.Items.Count < 6 Then
                If lstTeamList.Items.Count > 0 Then
                    'If the team is acceptable, then put the team in. If not give the appropriate error.
                    For Each item As String In lstTeamList.Items
                        Dim strPokemonTeam() As String = item.Split(",")
                        If strpokemonTeir(1) = (strPokemonTeam(1)) Then
                            isValid = True
                        Else
                            isValid = False
                            responseMsg = "Team mismatch error"
                            Exit For
                        End If
                    Next
                End If
            Else
                isValid = False
                responseMsg = "Team cannot be greater than 6"
            End If

        Else
            isValid = False
            responseMsg = "Please select a pokemon first"
        End If

        'Add the right items if it's valid.
        If isValid Then
            lstTeamList.Items.Add(lstPokemonList.SelectedItem)
            lstPokemonList.Items.Remove(lstPokemonList.SelectedItem)
        Else
            'Display conformation message
            MessageBox.Show(responseMsg)
        End If





    End Sub

    ''' <summary>
    ''' This button remove the pokemon from the team and put it back on the list.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstPokemonList.Items.Add(lstTeamList.SelectedItem)
        lstTeamList.Items.Remove(lstTeamList.SelectedItem)

    End Sub

    'commented out to see if this was extra code shown by windows.

    'Private Sub FillBy3ToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.PokemonMainTableTableAdapter.FillBy3(Me.PokemonDBDataSet.PokemonMainTable)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    'This is what happens when the pokemon get saved to team one.
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim content As New StringBuilder
        For Each item As String In lstTeamList.Items
            content.AppendLine(item)
        Next
        File.WriteAllText("pokemonTeam.txt", content.ToString)
        MessageBox.Show("All selected pokemon saved to team one!")
    End Sub

    'This is what happens when the user switches from the different teirs.
    Private Sub cmbTeir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeir.SelectedIndexChanged
        'Declare local variables.
        Dim sqlconn = New SqlClient.SqlConnection("Data Source=DESKTOP-KGMCUKK\SQLEXPRESS;Initial Catalog=PokemonDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlCmd As New SqlClient.SqlCommand
        'Open sql connection.
        sqlconn.Open()

        'With the connection open find the right pokemon to display to the user useing sql.
        With sqlCmd
            .Connection = sqlconn
            If cmbTeir.Text = "All" Then
                .CommandText = "Select [pokemon name] + ',' + [Teir] from pokemonmaintable"
            Else
                .CommandText = "Select [pokemon name] + ',' + [Teir] from pokemonmaintable where [Teir] = '" & cmbTeir.Text.ToString() & "'"
            End If
        End With

        'declare local sql reader
        Dim dReader As SqlClient.SqlDataReader = sqlCmd.ExecuteReader
        'clear the main pokemon list
        lstPokemonList.Items.Clear()

        For Each item In dReader
            'Add what we found in that teir.
            lstPokemonList.Items.Add(item(0))
        Next
        'close the sql connection for programing purposes.
        sqlconn.Close()


    End Sub

    'This is what happens when the pokemon gets saved to team two.
    Private Sub btnSaveTeam2_Click(sender As Object, e As EventArgs) Handles btnSaveTeam2.Click
        Dim content As New StringBuilder
        For Each item As String In lstTeamList.Items
            content.AppendLine(item)
        Next
        File.WriteAllText("pokemonTeam2.txt", content.ToString)
        MessageBox.Show("All selected pokemon saved to team two!")
    End Sub
End Class