Imports Microsoft.SqlServer.Server
Imports System.IO
Imports System.Text
Public Class pokemonBuilder
    Private Sub pokemonBuilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PokemonDBDataSet.PokemonMainTable' table. You can move, or remove it, as needed.
        ' Me.PokemonMainTableTableAdapter.Fill(Me.PokemonDBDataSet.PokemonMainTable)

        Dim sqlconn = New SqlClient.SqlConnection("Data Source=DESKTOP-KGMCUKK\SQLEXPRESS;Initial Catalog=PokemonDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlCmd As New SqlClient.SqlCommand
        sqlconn.Open()

        With sqlCmd
            .Connection = sqlconn
            .CommandText = "Select [pokemon name] + ', ' + [Teir] from pokemonmaintable"

        End With
        Dim dReader As SqlClient.SqlDataReader = sqlCmd.ExecuteReader
        For Each item In dReader
            lstPokemonList.Items.Add(item(0))
        Next
        sqlconn.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim isValid As Boolean = True
        Dim responseMsg As String = ""
        If lstPokemonList.SelectedIndex > -1 Then
            Dim strpokemonTeir() As String = lstPokemonList.SelectedItem.ToString.Split(",")


            If lstTeamList.Items.Count < 6 Then
                If lstTeamList.Items.Count > 0 Then
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

        If isValid Then
            lstTeamList.Items.Add(lstPokemonList.SelectedItem)
            lstPokemonList.Items.Remove(lstPokemonList.SelectedItem)
        Else
            MessageBox.Show(responseMsg)
        End If





    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstPokemonList.Items.Add(lstTeamList.SelectedItem)
        lstTeamList.Items.Remove(lstTeamList.SelectedItem)

    End Sub

    Private Sub FillBy3ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PokemonMainTableTableAdapter.FillBy3(Me.PokemonDBDataSet.PokemonMainTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim content As New StringBuilder
        For Each item As String In lstTeamList.Items
            content.AppendLine(item)
        Next
        File.WriteAllText("pokemonTeam.txt", content.ToString)
        MessageBox.Show("All selected pokemon saved to team one!")
    End Sub

    Private Sub cmbTeir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeir.SelectedIndexChanged
        Dim sqlconn = New SqlClient.SqlConnection("Data Source=DESKTOP-KGMCUKK\SQLEXPRESS;Initial Catalog=PokemonDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlCmd As New SqlClient.SqlCommand
        sqlconn.Open()

        With sqlCmd
            .Connection = sqlconn
            If cmbTeir.Text = "All" Then
                .CommandText = "Select [pokemon name] + ',' + [Teir] from pokemonmaintable"
            Else
                .CommandText = "Select [pokemon name] + ',' + [Teir] from pokemonmaintable where [Teir] = '" & cmbTeir.Text.ToString() & "'"
            End If


        End With
        Dim dReader As SqlClient.SqlDataReader = sqlCmd.ExecuteReader
        lstPokemonList.Items.Clear()

        For Each item In dReader
            lstPokemonList.Items.Add(item(0))
        Next
        sqlconn.Close()


    End Sub

    Private Sub btnSaveTeam2_Click(sender As Object, e As EventArgs) Handles btnSaveTeam2.Click
        Dim content As New StringBuilder
        For Each item As String In lstTeamList.Items
            content.AppendLine(item)
        Next
        File.WriteAllText("pokemonTeam2.txt", content.ToString)
        MessageBox.Show("All selected pokemon saved to team two!")
    End Sub
End Class