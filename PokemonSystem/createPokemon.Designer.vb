<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createPokemon
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
        Me.lblPokemonName = New System.Windows.Forms.Label()
        Me.txtPokemonName = New System.Windows.Forms.TextBox()
        Me.lblTier = New System.Windows.Forms.Label()
        Me.cboTeir = New System.Windows.Forms.ComboBox()
        Me.lblType1 = New System.Windows.Forms.Label()
        Me.lblType2 = New System.Windows.Forms.Label()
        Me.lblHitPoints = New System.Windows.Forms.Label()
        Me.lblAttack = New System.Windows.Forms.Label()
        Me.lblDefense = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblSpecialAttack = New System.Windows.Forms.Label()
        Me.lblSpecialDefense = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.cboType1 = New System.Windows.Forms.ComboBox()
        Me.cboType2 = New System.Windows.Forms.ComboBox()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.txtAttack = New System.Windows.Forms.TextBox()
        Me.txtDefense = New System.Windows.Forms.TextBox()
        Me.txtSpecialAttack = New System.Windows.Forms.TextBox()
        Me.txtSpecialDefense = New System.Windows.Forms.TextBox()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPokemonName
        '
        Me.lblPokemonName.AutoSize = True
        Me.lblPokemonName.Location = New System.Drawing.Point(32, 37)
        Me.lblPokemonName.Name = "lblPokemonName"
        Me.lblPokemonName.Size = New System.Drawing.Size(108, 17)
        Me.lblPokemonName.TabIndex = 0
        Me.lblPokemonName.Text = "Pokemon Name"
        '
        'txtPokemonName
        '
        Me.txtPokemonName.Location = New System.Drawing.Point(146, 37)
        Me.txtPokemonName.Name = "txtPokemonName"
        Me.txtPokemonName.Size = New System.Drawing.Size(189, 22)
        Me.txtPokemonName.TabIndex = 1
        '
        'lblTier
        '
        Me.lblTier.AutoSize = True
        Me.lblTier.Location = New System.Drawing.Point(32, 84)
        Me.lblTier.Name = "lblTier"
        Me.lblTier.Size = New System.Drawing.Size(33, 17)
        Me.lblTier.TabIndex = 2
        Me.lblTier.Text = "Tier"
        '
        'cboTeir
        '
        Me.cboTeir.FormattingEnabled = True
        Me.cboTeir.Items.AddRange(New Object() {"LC", "NU", "BL3", "RU", "BL2", "UU", "BL", "OU", "Uber"})
        Me.cboTeir.Location = New System.Drawing.Point(146, 84)
        Me.cboTeir.Name = "cboTeir"
        Me.cboTeir.Size = New System.Drawing.Size(121, 24)
        Me.cboTeir.TabIndex = 3
        '
        'lblType1
        '
        Me.lblType1.AutoSize = True
        Me.lblType1.Location = New System.Drawing.Point(383, 37)
        Me.lblType1.Name = "lblType1"
        Me.lblType1.Size = New System.Drawing.Size(74, 17)
        Me.lblType1.TabIndex = 4
        Me.lblType1.Text = "Main Type"
        '
        'lblType2
        '
        Me.lblType2.AutoSize = True
        Me.lblType2.Location = New System.Drawing.Point(623, 35)
        Me.lblType2.Name = "lblType2"
        Me.lblType2.Size = New System.Drawing.Size(112, 17)
        Me.lblType2.TabIndex = 5
        Me.lblType2.Text = "Secondary Type"
        '
        'lblHitPoints
        '
        Me.lblHitPoints.AutoSize = True
        Me.lblHitPoints.Location = New System.Drawing.Point(35, 215)
        Me.lblHitPoints.Name = "lblHitPoints"
        Me.lblHitPoints.Size = New System.Drawing.Size(27, 17)
        Me.lblHitPoints.TabIndex = 6
        Me.lblHitPoints.Text = "HP"
        '
        'lblAttack
        '
        Me.lblAttack.AutoSize = True
        Me.lblAttack.Location = New System.Drawing.Point(238, 210)
        Me.lblAttack.Name = "lblAttack"
        Me.lblAttack.Size = New System.Drawing.Size(47, 17)
        Me.lblAttack.TabIndex = 7
        Me.lblAttack.Text = "Attack"
        '
        'lblDefense
        '
        Me.lblDefense.AutoSize = True
        Me.lblDefense.Location = New System.Drawing.Point(460, 208)
        Me.lblDefense.Name = "lblDefense"
        Me.lblDefense.Size = New System.Drawing.Size(61, 17)
        Me.lblDefense.TabIndex = 8
        Me.lblDefense.Text = "Defense"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(208, 355)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(396, 138)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save Pokemon"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblSpecialAttack
        '
        Me.lblSpecialAttack.AutoSize = True
        Me.lblSpecialAttack.Location = New System.Drawing.Point(35, 288)
        Me.lblSpecialAttack.Name = "lblSpecialAttack"
        Me.lblSpecialAttack.Size = New System.Drawing.Size(97, 17)
        Me.lblSpecialAttack.TabIndex = 10
        Me.lblSpecialAttack.Text = "Special Attack"
        '
        'lblSpecialDefense
        '
        Me.lblSpecialDefense.AutoSize = True
        Me.lblSpecialDefense.Location = New System.Drawing.Point(292, 282)
        Me.lblSpecialDefense.Name = "lblSpecialDefense"
        Me.lblSpecialDefense.Size = New System.Drawing.Size(111, 17)
        Me.lblSpecialDefense.TabIndex = 11
        Me.lblSpecialDefense.Text = "Special Defense"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(535, 288)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(49, 17)
        Me.lblSpeed.TabIndex = 12
        Me.lblSpeed.Text = "Speed"
        '
        'cboType1
        '
        Me.cboType1.FormattingEnabled = True
        Me.cboType1.Items.AddRange(New Object() {"Normal", "Fire", "Fighting", "Water", "Flying", "Grass", "Poison", "Electric", "Ground", "Psychic", "Rock", "Ice", "Bug", "Dragon", "Ghost", "Dark", "Steel", "Fairy"})
        Me.cboType1.Location = New System.Drawing.Point(463, 35)
        Me.cboType1.Name = "cboType1"
        Me.cboType1.Size = New System.Drawing.Size(121, 24)
        Me.cboType1.TabIndex = 13
        '
        'cboType2
        '
        Me.cboType2.FormattingEnabled = True
        Me.cboType2.Items.AddRange(New Object() {"Normal", "Fire", "Fighting", "Water", "Flying", "Grass", "Poison", "Electric", "Ground", "Psychic", "Rock", "Ice", "Bug", "Dragon", "Ghost", "Dark", "Steel", "Fairy"})
        Me.cboType2.Location = New System.Drawing.Point(741, 30)
        Me.cboType2.Name = "cboType2"
        Me.cboType2.Size = New System.Drawing.Size(121, 24)
        Me.cboType2.TabIndex = 14
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(82, 210)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(100, 22)
        Me.txtHP.TabIndex = 15
        '
        'txtAttack
        '
        Me.txtAttack.Location = New System.Drawing.Point(303, 205)
        Me.txtAttack.Name = "txtAttack"
        Me.txtAttack.Size = New System.Drawing.Size(100, 22)
        Me.txtAttack.TabIndex = 16
        '
        'txtDefense
        '
        Me.txtDefense.Location = New System.Drawing.Point(528, 202)
        Me.txtDefense.Name = "txtDefense"
        Me.txtDefense.Size = New System.Drawing.Size(100, 22)
        Me.txtDefense.TabIndex = 17
        '
        'txtSpecialAttack
        '
        Me.txtSpecialAttack.Location = New System.Drawing.Point(146, 282)
        Me.txtSpecialAttack.Name = "txtSpecialAttack"
        Me.txtSpecialAttack.Size = New System.Drawing.Size(100, 22)
        Me.txtSpecialAttack.TabIndex = 18
        '
        'txtSpecialDefense
        '
        Me.txtSpecialDefense.Location = New System.Drawing.Point(410, 282)
        Me.txtSpecialDefense.Name = "txtSpecialDefense"
        Me.txtSpecialDefense.Size = New System.Drawing.Size(100, 22)
        Me.txtSpecialDefense.TabIndex = 19
        '
        'txtSpeed
        '
        Me.txtSpeed.Location = New System.Drawing.Point(591, 282)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(100, 22)
        Me.txtSpeed.TabIndex = 20
        '
        'createPokemon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 527)
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
        Me.Controls.Add(Me.cboTeir)
        Me.Controls.Add(Me.lblTier)
        Me.Controls.Add(Me.txtPokemonName)
        Me.Controls.Add(Me.lblPokemonName)
        Me.Name = "createPokemon"
        Me.Text = "createPokemon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPokemonName As Label
    Friend WithEvents txtPokemonName As TextBox
    Friend WithEvents lblTier As Label
    Friend WithEvents cboTeir As ComboBox
    Friend WithEvents lblType1 As Label
    Friend WithEvents lblType2 As Label
    Friend WithEvents lblHitPoints As Label
    Friend WithEvents lblAttack As Label
    Friend WithEvents lblDefense As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblSpecialAttack As Label
    Friend WithEvents lblSpecialDefense As Label
    Friend WithEvents lblSpeed As Label
    Friend WithEvents cboType1 As ComboBox
    Friend WithEvents cboType2 As ComboBox
    Friend WithEvents txtHP As TextBox
    Friend WithEvents txtAttack As TextBox
    Friend WithEvents txtDefense As TextBox
    Friend WithEvents txtSpecialAttack As TextBox
    Friend WithEvents txtSpecialDefense As TextBox
    Friend WithEvents txtSpeed As TextBox
End Class
