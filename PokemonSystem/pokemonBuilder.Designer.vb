<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pokemonBuilder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstPokemonList = New System.Windows.Forms.ListBox()
        Me.PokemonMainTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PokemonDBDataSet = New PokemonSystem.pokemonDBDataSet()
        Me.lstTeamList = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.PokemonMainTableTableAdapter = New PokemonSystem.pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbTeir = New System.Windows.Forms.ComboBox()
        Me.lblTeirTitle = New System.Windows.Forms.Label()
        Me.PokemonMainTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSaveTeam2 = New System.Windows.Forms.Button()
        Me.btnRandomize = New System.Windows.Forms.Button()
        CType(Me.PokemonMainTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonMainTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstPokemonList
        '
        Me.lstPokemonList.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PokemonMainTableBindingSource1, "Pokemon Name", True))
        Me.lstPokemonList.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstPokemonList.FormattingEnabled = True
        Me.lstPokemonList.ItemHeight = 16
        Me.lstPokemonList.Location = New System.Drawing.Point(0, 0)
        Me.lstPokemonList.Name = "lstPokemonList"
        Me.lstPokemonList.Size = New System.Drawing.Size(332, 605)
        Me.lstPokemonList.Sorted = True
        Me.lstPokemonList.TabIndex = 0
        '
        'PokemonMainTableBindingSource1
        '
        Me.PokemonMainTableBindingSource1.DataMember = "PokemonMainTable"
        Me.PokemonMainTableBindingSource1.DataSource = Me.PokemonDBDataSet
        '
        'PokemonDBDataSet
        '
        Me.PokemonDBDataSet.DataSetName = "pokemonDBDataSet"
        Me.PokemonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lstTeamList
        '
        Me.lstTeamList.Dock = System.Windows.Forms.DockStyle.Right
        Me.lstTeamList.FormattingEnabled = True
        Me.lstTeamList.ItemHeight = 16
        Me.lstTeamList.Location = New System.Drawing.Point(534, 0)
        Me.lstTeamList.Name = "lstTeamList"
        Me.lstTeamList.Size = New System.Drawing.Size(369, 605)
        Me.lstTeamList.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(372, 102)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 51)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Move to Team"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(372, 183)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(119, 50)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove from Team"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'PokemonMainTableTableAdapter
        '
        Me.PokemonMainTableTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(372, 464)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 53)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save Team 1"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmbTeir
        '
        Me.cmbTeir.FormattingEnabled = True
        Me.cmbTeir.Items.AddRange(New Object() {"All", "LC", "PU", "RU", "UA"})
        Me.cmbTeir.Location = New System.Drawing.Point(370, 61)
        Me.cmbTeir.Name = "cmbTeir"
        Me.cmbTeir.Size = New System.Drawing.Size(121, 24)
        Me.cmbTeir.Sorted = True
        Me.cmbTeir.TabIndex = 5
        '
        'lblTeirTitle
        '
        Me.lblTeirTitle.AutoSize = True
        Me.lblTeirTitle.Location = New System.Drawing.Point(369, 27)
        Me.lblTeirTitle.Name = "lblTeirTitle"
        Me.lblTeirTitle.Size = New System.Drawing.Size(84, 17)
        Me.lblTeirTitle.TabIndex = 6
        Me.lblTeirTitle.Text = "Teir of Play:"
        '
        'PokemonMainTableBindingSource
        '
        Me.PokemonMainTableBindingSource.DataMember = "PokemonMainTable"
        Me.PokemonMainTableBindingSource.DataSource = Me.PokemonDBDataSet
        '
        'btnSaveTeam2
        '
        Me.btnSaveTeam2.Location = New System.Drawing.Point(372, 536)
        Me.btnSaveTeam2.Name = "btnSaveTeam2"
        Me.btnSaveTeam2.Size = New System.Drawing.Size(119, 57)
        Me.btnSaveTeam2.TabIndex = 7
        Me.btnSaveTeam2.Text = "Save Team 2"
        Me.btnSaveTeam2.UseVisualStyleBackColor = True
        '
        'btnRandomize
        '
        Me.btnRandomize.Location = New System.Drawing.Point(372, 299)
        Me.btnRandomize.Name = "btnRandomize"
        Me.btnRandomize.Size = New System.Drawing.Size(119, 52)
        Me.btnRandomize.TabIndex = 8
        Me.btnRandomize.Text = "Pull 6 Pokemon from Teir"
        Me.btnRandomize.UseVisualStyleBackColor = True
        '
        'pokemonBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 605)
        Me.Controls.Add(Me.btnRandomize)
        Me.Controls.Add(Me.btnSaveTeam2)
        Me.Controls.Add(Me.lblTeirTitle)
        Me.Controls.Add(Me.cmbTeir)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstTeamList)
        Me.Controls.Add(Me.lstPokemonList)
        Me.Name = "pokemonBuilder"
        Me.Text = "pokemonBuilder"
        CType(Me.PokemonMainTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonMainTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstPokemonList As ListBox
    Friend WithEvents lstTeamList As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents PokemonDBDataSet As pokemonDBDataSet
    Friend WithEvents PokemonMainTableBindingSource As BindingSource
    Friend WithEvents PokemonMainTableTableAdapter As pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter
    Friend WithEvents PokemonMainTableBindingSource1 As BindingSource
    Friend WithEvents btnSave As Button
    Friend WithEvents cmbTeir As ComboBox
    Friend WithEvents lblTeirTitle As Label
    Friend WithEvents btnSaveTeam2 As Button
    Friend WithEvents btnRandomize As Button
End Class
