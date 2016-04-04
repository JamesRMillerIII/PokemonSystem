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
        Me.lstTeamList = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.PokemonDBDataSet = New PokemonSystem.pokemonDBDataSet()
        Me.PokemonMainTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PokemonMainTableTableAdapter = New PokemonSystem.pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter()
        Me.PokemonMainTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PokemonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonMainTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonMainTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstPokemonList
        '
        Me.lstPokemonList.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PokemonMainTableBindingSource1, "Pokemon Name", True))
        Me.lstPokemonList.DataSource = Me.PokemonMainTableBindingSource
        Me.lstPokemonList.DisplayMember = "Pokemon Name"
        Me.lstPokemonList.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstPokemonList.FormattingEnabled = True
        Me.lstPokemonList.ItemHeight = 16
        Me.lstPokemonList.Location = New System.Drawing.Point(0, 0)
        Me.lstPokemonList.Name = "lstPokemonList"
        Me.lstPokemonList.Size = New System.Drawing.Size(332, 605)
        Me.lstPokemonList.TabIndex = 0
        Me.lstPokemonList.ValueMember = "Pokemon Name"
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
        Me.btnAdd.Location = New System.Drawing.Point(372, 178)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 51)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Move to Team"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(372, 298)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(119, 50)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove from Team"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'PokemonDBDataSet
        '
        Me.PokemonDBDataSet.DataSetName = "pokemonDBDataSet"
        Me.PokemonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PokemonMainTableBindingSource
        '
        Me.PokemonMainTableBindingSource.DataMember = "PokemonMainTable"
        Me.PokemonMainTableBindingSource.DataSource = Me.PokemonDBDataSet
        '
        'PokemonMainTableTableAdapter
        '
        Me.PokemonMainTableTableAdapter.ClearBeforeFill = True
        '
        'PokemonMainTableBindingSource1
        '
        Me.PokemonMainTableBindingSource1.DataMember = "PokemonMainTable"
        Me.PokemonMainTableBindingSource1.DataSource = Me.PokemonDBDataSet
        '
        'pokemonBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 605)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstTeamList)
        Me.Controls.Add(Me.lstPokemonList)
        Me.Name = "pokemonBuilder"
        Me.Text = "pokemonBuilder"
        CType(Me.PokemonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonMainTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonMainTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstPokemonList As ListBox
    Friend WithEvents lstTeamList As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents PokemonDBDataSet As pokemonDBDataSet
    Friend WithEvents PokemonMainTableBindingSource As BindingSource
    Friend WithEvents PokemonMainTableTableAdapter As pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter
    Friend WithEvents PokemonMainTableBindingSource1 As BindingSource
End Class
