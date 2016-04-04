<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deletePokemon
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
        Me.dgvDelete = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PokemonNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefenseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialAttackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialDefenseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpeedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PokemonMainTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PokemonDBDataSet = New PokemonSystem.pokemonDBDataSet()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PokemonMainTableTableAdapter = New PokemonSystem.pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter()
        CType(Me.dgvDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonMainTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDelete
        '
        Me.dgvDelete.AllowUserToAddRows = False
        Me.dgvDelete.AllowUserToDeleteRows = False
        Me.dgvDelete.AutoGenerateColumns = False
        Me.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDelete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.PokemonNameDataGridViewTextBoxColumn, Me.TeirDataGridViewTextBoxColumn, Me.Type1DataGridViewTextBoxColumn, Me.Type2DataGridViewTextBoxColumn, Me.HPDataGridViewTextBoxColumn, Me.AttackDataGridViewTextBoxColumn, Me.DefenseDataGridViewTextBoxColumn, Me.SpecialAttackDataGridViewTextBoxColumn, Me.SpecialDefenseDataGridViewTextBoxColumn, Me.SpeedDataGridViewTextBoxColumn})
        Me.dgvDelete.DataSource = Me.PokemonMainTableBindingSource
        Me.dgvDelete.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvDelete.Location = New System.Drawing.Point(0, 0)
        Me.dgvDelete.Name = "dgvDelete"
        Me.dgvDelete.ReadOnly = True
        Me.dgvDelete.RowTemplate.Height = 24
        Me.dgvDelete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDelete.Size = New System.Drawing.Size(1296, 462)
        Me.dgvDelete.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PokemonNameDataGridViewTextBoxColumn
        '
        Me.PokemonNameDataGridViewTextBoxColumn.DataPropertyName = "Pokemon Name"
        Me.PokemonNameDataGridViewTextBoxColumn.HeaderText = "Pokemon Name"
        Me.PokemonNameDataGridViewTextBoxColumn.Name = "PokemonNameDataGridViewTextBoxColumn"
        Me.PokemonNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TeirDataGridViewTextBoxColumn
        '
        Me.TeirDataGridViewTextBoxColumn.DataPropertyName = "Teir"
        Me.TeirDataGridViewTextBoxColumn.HeaderText = "Teir"
        Me.TeirDataGridViewTextBoxColumn.Name = "TeirDataGridViewTextBoxColumn"
        Me.TeirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Type1DataGridViewTextBoxColumn
        '
        Me.Type1DataGridViewTextBoxColumn.DataPropertyName = "Type 1"
        Me.Type1DataGridViewTextBoxColumn.HeaderText = "Type 1"
        Me.Type1DataGridViewTextBoxColumn.Name = "Type1DataGridViewTextBoxColumn"
        Me.Type1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Type2DataGridViewTextBoxColumn
        '
        Me.Type2DataGridViewTextBoxColumn.DataPropertyName = "Type 2"
        Me.Type2DataGridViewTextBoxColumn.HeaderText = "Type 2"
        Me.Type2DataGridViewTextBoxColumn.Name = "Type2DataGridViewTextBoxColumn"
        Me.Type2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'HPDataGridViewTextBoxColumn
        '
        Me.HPDataGridViewTextBoxColumn.DataPropertyName = "HP"
        Me.HPDataGridViewTextBoxColumn.HeaderText = "HP"
        Me.HPDataGridViewTextBoxColumn.Name = "HPDataGridViewTextBoxColumn"
        Me.HPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttackDataGridViewTextBoxColumn
        '
        Me.AttackDataGridViewTextBoxColumn.DataPropertyName = "Attack"
        Me.AttackDataGridViewTextBoxColumn.HeaderText = "Attack"
        Me.AttackDataGridViewTextBoxColumn.Name = "AttackDataGridViewTextBoxColumn"
        Me.AttackDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DefenseDataGridViewTextBoxColumn
        '
        Me.DefenseDataGridViewTextBoxColumn.DataPropertyName = "Defense"
        Me.DefenseDataGridViewTextBoxColumn.HeaderText = "Defense"
        Me.DefenseDataGridViewTextBoxColumn.Name = "DefenseDataGridViewTextBoxColumn"
        Me.DefenseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpecialAttackDataGridViewTextBoxColumn
        '
        Me.SpecialAttackDataGridViewTextBoxColumn.DataPropertyName = "Special Attack"
        Me.SpecialAttackDataGridViewTextBoxColumn.HeaderText = "Special Attack"
        Me.SpecialAttackDataGridViewTextBoxColumn.Name = "SpecialAttackDataGridViewTextBoxColumn"
        Me.SpecialAttackDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpecialDefenseDataGridViewTextBoxColumn
        '
        Me.SpecialDefenseDataGridViewTextBoxColumn.DataPropertyName = "Special Defense"
        Me.SpecialDefenseDataGridViewTextBoxColumn.HeaderText = "Special Defense"
        Me.SpecialDefenseDataGridViewTextBoxColumn.Name = "SpecialDefenseDataGridViewTextBoxColumn"
        Me.SpecialDefenseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpeedDataGridViewTextBoxColumn
        '
        Me.SpeedDataGridViewTextBoxColumn.DataPropertyName = "Speed"
        Me.SpeedDataGridViewTextBoxColumn.HeaderText = "Speed"
        Me.SpeedDataGridViewTextBoxColumn.Name = "SpeedDataGridViewTextBoxColumn"
        Me.SpeedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PokemonMainTableBindingSource
        '
        Me.PokemonMainTableBindingSource.DataMember = "PokemonMainTable"
        Me.PokemonMainTableBindingSource.DataSource = Me.PokemonDBDataSet
        '
        'PokemonDBDataSet
        '
        Me.PokemonDBDataSet.DataSetName = "pokemonDBDataSet"
        Me.PokemonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(627, 498)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 48)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'PokemonMainTableTableAdapter
        '
        Me.PokemonMainTableTableAdapter.ClearBeforeFill = True
        '
        'deletePokemon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 576)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgvDelete)
        Me.Name = "deletePokemon"
        Me.Text = "deletePokemon"
        CType(Me.dgvDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonMainTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDelete As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents PokemonDBDataSet As pokemonDBDataSet
    Friend WithEvents PokemonMainTableBindingSource As BindingSource
    Friend WithEvents PokemonMainTableTableAdapter As pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PokemonNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Type1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Type2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DefenseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecialAttackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecialDefenseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpeedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
