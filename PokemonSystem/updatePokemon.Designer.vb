<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class updatePokemon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.PokemonMainTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PokemonDBDataSet1 = New PokemonSystem.pokemonDBDataSet()
        Me.txtSpecialDefense = New System.Windows.Forms.TextBox()
        Me.txtSpecialAttack = New System.Windows.Forms.TextBox()
        Me.txtDefense = New System.Windows.Forms.TextBox()
        Me.txtAttack = New System.Windows.Forms.TextBox()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.cboType2 = New System.Windows.Forms.ComboBox()
        Me.cboType1 = New System.Windows.Forms.ComboBox()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblSpecialDefense = New System.Windows.Forms.Label()
        Me.lblSpecialAttack = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblDefense = New System.Windows.Forms.Label()
        Me.lblAttack = New System.Windows.Forms.Label()
        Me.lblHitPoints = New System.Windows.Forms.Label()
        Me.lblType2 = New System.Windows.Forms.Label()
        Me.lblType1 = New System.Windows.Forms.Label()
        Me.PokemonDBDataSet = New PokemonSystem.pokemonDBDataSet()
        Me.lblTier = New System.Windows.Forms.Label()
        Me.lblPokemonName = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.PokemonMainTableTableAdapter = New PokemonSystem.pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter()
        Me.cboTier = New System.Windows.Forms.ComboBox()
        CType(Me.PokemonMainTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSpeed
        '
        Me.txtSpeed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PokemonMainTableBindingSource, "Speed", True))
        Me.txtSpeed.Location = New System.Drawing.Point(586, 279)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(100, 22)
        Me.txtSpeed.TabIndex = 41
        '
        'PokemonMainTableBindingSource
        '
        Me.PokemonMainTableBindingSource.DataMember = "PokemonMainTable"
        Me.PokemonMainTableBindingSource.DataSource = Me.PokemonDBDataSet1
        '
        'PokemonDBDataSet1
        '
        Me.PokemonDBDataSet1.DataSetName = "pokemonDBDataSet"
        Me.PokemonDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSpecialDefense
        '
        Me.txtSpecialDefense.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PokemonMainTableBindingSource, "Special Defense", True))
        Me.txtSpecialDefense.Location = New System.Drawing.Point(405, 279)
        Me.txtSpecialDefense.Name = "txtSpecialDefense"
        Me.txtSpecialDefense.Size = New System.Drawing.Size(100, 22)
        Me.txtSpecialDefense.TabIndex = 40
        '
        'txtSpecialAttack
        '
        Me.txtSpecialAttack.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PokemonMainTableBindingSource, "Special Attack", True))
        Me.txtSpecialAttack.Location = New System.Drawing.Point(141, 279)
        Me.txtSpecialAttack.Name = "txtSpecialAttack"
        Me.txtSpecialAttack.Size = New System.Drawing.Size(100, 22)
        Me.txtSpecialAttack.TabIndex = 39
        '
        'txtDefense
        '
        Me.txtDefense.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PokemonMainTableBindingSource, "Defense", True))
        Me.txtDefense.Location = New System.Drawing.Point(523, 199)
        Me.txtDefense.Name = "txtDefense"
        Me.txtDefense.Size = New System.Drawing.Size(100, 22)
        Me.txtDefense.TabIndex = 38
        '
        'txtAttack
        '
        Me.txtAttack.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PokemonMainTableBindingSource, "Attack", True))
        Me.txtAttack.Location = New System.Drawing.Point(298, 202)
        Me.txtAttack.Name = "txtAttack"
        Me.txtAttack.Size = New System.Drawing.Size(100, 22)
        Me.txtAttack.TabIndex = 37
        '
        'txtHP
        '
        Me.txtHP.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PokemonMainTableBindingSource, "HP", True))
        Me.txtHP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PokemonMainTableBindingSource, "HP", True))
        Me.txtHP.Location = New System.Drawing.Point(77, 207)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(100, 22)
        Me.txtHP.TabIndex = 36
        '
        'cboType2
        '
        Me.cboType2.DataSource = Me.PokemonMainTableBindingSource
        Me.cboType2.DisplayMember = "Type 2"
        Me.cboType2.FormattingEnabled = True
        Me.cboType2.Location = New System.Drawing.Point(736, 27)
        Me.cboType2.Name = "cboType2"
        Me.cboType2.Size = New System.Drawing.Size(121, 24)
        Me.cboType2.TabIndex = 35
        Me.cboType2.ValueMember = "Type 2"
        '
        'cboType1
        '
        Me.cboType1.DataSource = Me.PokemonMainTableBindingSource
        Me.cboType1.DisplayMember = "Type 1"
        Me.cboType1.FormattingEnabled = True
        Me.cboType1.Location = New System.Drawing.Point(458, 32)
        Me.cboType1.Name = "cboType1"
        Me.cboType1.Size = New System.Drawing.Size(121, 24)
        Me.cboType1.TabIndex = 34
        Me.cboType1.ValueMember = "Type 1"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(530, 285)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(49, 17)
        Me.lblSpeed.TabIndex = 33
        Me.lblSpeed.Text = "Speed"
        '
        'lblSpecialDefense
        '
        Me.lblSpecialDefense.AutoSize = True
        Me.lblSpecialDefense.Location = New System.Drawing.Point(287, 279)
        Me.lblSpecialDefense.Name = "lblSpecialDefense"
        Me.lblSpecialDefense.Size = New System.Drawing.Size(111, 17)
        Me.lblSpecialDefense.TabIndex = 32
        Me.lblSpecialDefense.Text = "Special Defense"
        '
        'lblSpecialAttack
        '
        Me.lblSpecialAttack.AutoSize = True
        Me.lblSpecialAttack.Location = New System.Drawing.Point(30, 285)
        Me.lblSpecialAttack.Name = "lblSpecialAttack"
        Me.lblSpecialAttack.Size = New System.Drawing.Size(97, 17)
        Me.lblSpecialAttack.TabIndex = 31
        Me.lblSpecialAttack.Text = "Special Attack"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(206, 348)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(396, 138)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Update Pokemon"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblDefense
        '
        Me.lblDefense.AutoSize = True
        Me.lblDefense.Location = New System.Drawing.Point(455, 205)
        Me.lblDefense.Name = "lblDefense"
        Me.lblDefense.Size = New System.Drawing.Size(61, 17)
        Me.lblDefense.TabIndex = 29
        Me.lblDefense.Text = "Defense"
        '
        'lblAttack
        '
        Me.lblAttack.AutoSize = True
        Me.lblAttack.Location = New System.Drawing.Point(233, 207)
        Me.lblAttack.Name = "lblAttack"
        Me.lblAttack.Size = New System.Drawing.Size(47, 17)
        Me.lblAttack.TabIndex = 28
        Me.lblAttack.Text = "Attack"
        '
        'lblHitPoints
        '
        Me.lblHitPoints.AutoSize = True
        Me.lblHitPoints.Location = New System.Drawing.Point(30, 212)
        Me.lblHitPoints.Name = "lblHitPoints"
        Me.lblHitPoints.Size = New System.Drawing.Size(27, 17)
        Me.lblHitPoints.TabIndex = 27
        Me.lblHitPoints.Text = "HP"
        '
        'lblType2
        '
        Me.lblType2.AutoSize = True
        Me.lblType2.Location = New System.Drawing.Point(618, 32)
        Me.lblType2.Name = "lblType2"
        Me.lblType2.Size = New System.Drawing.Size(112, 17)
        Me.lblType2.TabIndex = 26
        Me.lblType2.Text = "Secondary Type"
        '
        'lblType1
        '
        Me.lblType1.AutoSize = True
        Me.lblType1.Location = New System.Drawing.Point(378, 34)
        Me.lblType1.Name = "lblType1"
        Me.lblType1.Size = New System.Drawing.Size(74, 17)
        Me.lblType1.TabIndex = 25
        Me.lblType1.Text = "Main Type"
        '
        'PokemonDBDataSet
        '
        Me.PokemonDBDataSet.DataSetName = "pokemonDBDataSet"
        Me.PokemonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblTier
        '
        Me.lblTier.AutoSize = True
        Me.lblTier.Location = New System.Drawing.Point(27, 81)
        Me.lblTier.Name = "lblTier"
        Me.lblTier.Size = New System.Drawing.Size(33, 17)
        Me.lblTier.TabIndex = 23
        Me.lblTier.Text = "Tier"
        '
        'lblPokemonName
        '
        Me.lblPokemonName.AutoSize = True
        Me.lblPokemonName.Location = New System.Drawing.Point(27, 34)
        Me.lblPokemonName.Name = "lblPokemonName"
        Me.lblPokemonName.Size = New System.Drawing.Size(108, 17)
        Me.lblPokemonName.TabIndex = 21
        Me.lblPokemonName.Text = "Pokemon Name"
        '
        'cboName
        '
        Me.cboName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PokemonMainTableBindingSource, "Id", True))
        Me.cboName.DataSource = Me.PokemonMainTableBindingSource
        Me.cboName.DisplayMember = "Pokemon Name"
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(141, 34)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(208, 24)
        Me.cboName.TabIndex = 42
        Me.cboName.ValueMember = "Pokemon Name"
        '
        'PokemonMainTableTableAdapter
        '
        Me.PokemonMainTableTableAdapter.ClearBeforeFill = True
        '
        'cboTier
        '
        Me.cboTier.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.PokemonMainTableBindingSource, "Teir", True))
        Me.cboTier.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PokemonMainTableBindingSource, "Teir", True))
        Me.cboTier.FormattingEnabled = True
        Me.cboTier.Items.AddRange(New Object() {"LC", "NU", "BL3", "RU", "BL2", "UU", "BL", "OU", "Uber"})
        Me.cboTier.Location = New System.Drawing.Point(67, 81)
        Me.cboTier.Name = "cboTier"
        Me.cboTier.Size = New System.Drawing.Size(121, 24)
        Me.cboTier.TabIndex = 43
        Me.cboTier.Tag = ""
        '
        'updatePokemon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 537)
        Me.Controls.Add(Me.cboTier)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.txtSpecialDefense)
        Me.Controls.Add(Me.txtSpecialAttack)
        Me.Controls.Add(Me.txtDefense)
        Me.Controls.Add(Me.txtAttack)
        Me.Controls.Add(Me.txtHP)
        Me.Controls.Add(Me.cboType2)
        Me.Controls.Add(Me.cboType1)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblSpecialDefense)
        Me.Controls.Add(Me.lblSpecialAttack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblDefense)
        Me.Controls.Add(Me.lblAttack)
        Me.Controls.Add(Me.lblHitPoints)
        Me.Controls.Add(Me.lblType2)
        Me.Controls.Add(Me.lblType1)
        Me.Controls.Add(Me.lblTier)
        Me.Controls.Add(Me.lblPokemonName)
        Me.Name = "updatePokemon"
        Me.Text = "updatePokemon"
        CType(Me.PokemonMainTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSpeed As TextBox
    Friend WithEvents txtSpecialDefense As TextBox
    Friend WithEvents txtSpecialAttack As TextBox
    Friend WithEvents txtDefense As TextBox
    Friend WithEvents txtAttack As TextBox
    Friend WithEvents txtHP As TextBox
    Friend WithEvents cboType2 As ComboBox
    Friend WithEvents cboType1 As ComboBox
    Friend WithEvents lblSpeed As Label
    Friend WithEvents lblSpecialDefense As Label
    Friend WithEvents lblSpecialAttack As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblDefense As Label
    Friend WithEvents lblAttack As Label
    Friend WithEvents lblHitPoints As Label
    Friend WithEvents lblType2 As Label
    Friend WithEvents lblType1 As Label
    Friend WithEvents lblTier As Label
    Friend WithEvents lblPokemonName As Label
    Friend WithEvents cboName As ComboBox
    Friend WithEvents PokemonDBDataSet As pokemonDBDataSet
    Friend WithEvents PokemonDBDataSet1 As pokemonDBDataSet
    Friend WithEvents PokemonMainTableBindingSource As BindingSource
    Friend WithEvents PokemonMainTableTableAdapter As pokemonDBDataSetTableAdapters.PokemonMainTableTableAdapter
    Friend WithEvents cboTier As ComboBox
End Class
