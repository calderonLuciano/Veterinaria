<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cargaDueño
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_idDueño = New System.Windows.Forms.Label()
        Me.lbl_nombreDueño = New System.Windows.Forms.Label()
        Me.lbl_apellidoDueño = New System.Windows.Forms.Label()
        Me.lbl_telefonoDueño = New System.Windows.Forms.Label()
        Me.txt_idDueño = New System.Windows.Forms.TextBox()
        Me.txt_nombreDueño = New System.Windows.Forms.TextBox()
        Me.txt_apellidoDueño = New System.Windows.Forms.TextBox()
        Me.txt_telefonoDueño = New System.Windows.Forms.TextBox()
        Me.btn_agregarDueño = New System.Windows.Forms.Button()
        Me.btn_guardarDueño = New System.Windows.Forms.Button()
        Me.btn_salirDueño = New System.Windows.Forms.Button()
        Me.gro_datosDueños = New System.Windows.Forms.GroupBox()
        Me.gro_listaDueños = New System.Windows.Forms.GroupBox()
        Me.dgv_listaDueños = New System.Windows.Forms.DataGridView()
        Me.col_idDueño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombreDueño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellidoDueño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefonoDueño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gro_datosDueños.SuspendLayout()
        Me.gro_listaDueños.SuspendLayout()
        CType(Me.dgv_listaDueños, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_idDueño
        '
        Me.lbl_idDueño.AutoSize = True
        Me.lbl_idDueño.Location = New System.Drawing.Point(65, 32)
        Me.lbl_idDueño.Name = "lbl_idDueño"
        Me.lbl_idDueño.Size = New System.Drawing.Size(25, 16)
        Me.lbl_idDueño.TabIndex = 0
        Me.lbl_idDueño.Text = "ID:"
        '
        'lbl_nombreDueño
        '
        Me.lbl_nombreDueño.AutoSize = True
        Me.lbl_nombreDueño.Location = New System.Drawing.Point(25, 64)
        Me.lbl_nombreDueño.Name = "lbl_nombreDueño"
        Me.lbl_nombreDueño.Size = New System.Drawing.Size(65, 16)
        Me.lbl_nombreDueño.TabIndex = 1
        Me.lbl_nombreDueño.Text = "Nombre:"
        '
        'lbl_apellidoDueño
        '
        Me.lbl_apellidoDueño.AutoSize = True
        Me.lbl_apellidoDueño.Location = New System.Drawing.Point(259, 32)
        Me.lbl_apellidoDueño.Name = "lbl_apellidoDueño"
        Me.lbl_apellidoDueño.Size = New System.Drawing.Size(66, 16)
        Me.lbl_apellidoDueño.TabIndex = 2
        Me.lbl_apellidoDueño.Text = "Apellido:"
        '
        'lbl_telefonoDueño
        '
        Me.lbl_telefonoDueño.AutoSize = True
        Me.lbl_telefonoDueño.Location = New System.Drawing.Point(260, 64)
        Me.lbl_telefonoDueño.Name = "lbl_telefonoDueño"
        Me.lbl_telefonoDueño.Size = New System.Drawing.Size(65, 16)
        Me.lbl_telefonoDueño.TabIndex = 3
        Me.lbl_telefonoDueño.Text = "Telefono:"
        '
        'txt_idDueño
        '
        Me.txt_idDueño.Enabled = False
        Me.txt_idDueño.Location = New System.Drawing.Point(96, 29)
        Me.txt_idDueño.Name = "txt_idDueño"
        Me.txt_idDueño.Size = New System.Drawing.Size(138, 23)
        Me.txt_idDueño.TabIndex = 4
        '
        'txt_nombreDueño
        '
        Me.txt_nombreDueño.Location = New System.Drawing.Point(96, 61)
        Me.txt_nombreDueño.MaxLength = 40
        Me.txt_nombreDueño.Name = "txt_nombreDueño"
        Me.txt_nombreDueño.Size = New System.Drawing.Size(138, 23)
        Me.txt_nombreDueño.TabIndex = 5
        '
        'txt_apellidoDueño
        '
        Me.txt_apellidoDueño.Location = New System.Drawing.Point(331, 29)
        Me.txt_apellidoDueño.MaxLength = 40
        Me.txt_apellidoDueño.Name = "txt_apellidoDueño"
        Me.txt_apellidoDueño.Size = New System.Drawing.Size(138, 23)
        Me.txt_apellidoDueño.TabIndex = 6
        '
        'txt_telefonoDueño
        '
        Me.txt_telefonoDueño.Location = New System.Drawing.Point(331, 61)
        Me.txt_telefonoDueño.MaxLength = 6
        Me.txt_telefonoDueño.Name = "txt_telefonoDueño"
        Me.txt_telefonoDueño.Size = New System.Drawing.Size(138, 23)
        Me.txt_telefonoDueño.TabIndex = 7
        '
        'btn_agregarDueño
        '
        Me.btn_agregarDueño.BackgroundImage = Global.Veterinaria.My.Resources.Resources.add
        Me.btn_agregarDueño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregarDueño.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregarDueño.Location = New System.Drawing.Point(477, 76)
        Me.btn_agregarDueño.Name = "btn_agregarDueño"
        Me.btn_agregarDueño.Size = New System.Drawing.Size(42, 41)
        Me.btn_agregarDueño.TabIndex = 8
        Me.btn_agregarDueño.UseVisualStyleBackColor = True
        '
        'btn_guardarDueño
        '
        Me.btn_guardarDueño.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardarDueño.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarDueño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardarDueño.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarDueño.Location = New System.Drawing.Point(409, 266)
        Me.btn_guardarDueño.Name = "btn_guardarDueño"
        Me.btn_guardarDueño.Size = New System.Drawing.Size(38, 32)
        Me.btn_guardarDueño.TabIndex = 9
        Me.btn_guardarDueño.UseVisualStyleBackColor = False
        '
        'btn_salirDueño
        '
        Me.btn_salirDueño.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirDueño.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salirDueño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salirDueño.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirDueño.Location = New System.Drawing.Point(463, 266)
        Me.btn_salirDueño.Name = "btn_salirDueño"
        Me.btn_salirDueño.Size = New System.Drawing.Size(36, 32)
        Me.btn_salirDueño.TabIndex = 10
        Me.btn_salirDueño.UseVisualStyleBackColor = False
        '
        'gro_datosDueños
        '
        Me.gro_datosDueños.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosDueños.Controls.Add(Me.btn_agregarDueño)
        Me.gro_datosDueños.Controls.Add(Me.txt_telefonoDueño)
        Me.gro_datosDueños.Controls.Add(Me.txt_apellidoDueño)
        Me.gro_datosDueños.Controls.Add(Me.txt_nombreDueño)
        Me.gro_datosDueños.Controls.Add(Me.txt_idDueño)
        Me.gro_datosDueños.Controls.Add(Me.lbl_telefonoDueño)
        Me.gro_datosDueños.Controls.Add(Me.lbl_apellidoDueño)
        Me.gro_datosDueños.Controls.Add(Me.lbl_nombreDueño)
        Me.gro_datosDueños.Controls.Add(Me.lbl_idDueño)
        Me.gro_datosDueños.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosDueños.ForeColor = System.Drawing.Color.White
        Me.gro_datosDueños.Location = New System.Drawing.Point(9, 32)
        Me.gro_datosDueños.Name = "gro_datosDueños"
        Me.gro_datosDueños.Size = New System.Drawing.Size(541, 123)
        Me.gro_datosDueños.TabIndex = 11
        Me.gro_datosDueños.TabStop = False
        Me.gro_datosDueños.Text = "Datos Dueños"
        '
        'gro_listaDueños
        '
        Me.gro_listaDueños.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaDueños.Controls.Add(Me.dgv_listaDueños)
        Me.gro_listaDueños.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_listaDueños.ForeColor = System.Drawing.Color.White
        Me.gro_listaDueños.Location = New System.Drawing.Point(9, 164)
        Me.gro_listaDueños.Name = "gro_listaDueños"
        Me.gro_listaDueños.Size = New System.Drawing.Size(541, 96)
        Me.gro_listaDueños.TabIndex = 12
        Me.gro_listaDueños.TabStop = False
        Me.gro_listaDueños.Text = "Lista de Dueños"
        '
        'dgv_listaDueños
        '
        Me.dgv_listaDueños.AllowUserToAddRows = False
        Me.dgv_listaDueños.AllowUserToDeleteRows = False
        Me.dgv_listaDueños.AllowUserToResizeColumns = False
        Me.dgv_listaDueños.AllowUserToResizeRows = False
        Me.dgv_listaDueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaDueños.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idDueño, Me.col_nombreDueño, Me.col_apellidoDueño, Me.col_telefonoDueño})
        Me.dgv_listaDueños.Location = New System.Drawing.Point(6, 19)
        Me.dgv_listaDueños.Name = "dgv_listaDueños"
        Me.dgv_listaDueños.ReadOnly = True
        Me.dgv_listaDueños.RowHeadersVisible = False
        Me.dgv_listaDueños.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaDueños.Size = New System.Drawing.Size(529, 71)
        Me.dgv_listaDueños.TabIndex = 0
        '
        'col_idDueño
        '
        Me.col_idDueño.HeaderText = "ID"
        Me.col_idDueño.Name = "col_idDueño"
        Me.col_idDueño.ReadOnly = True
        Me.col_idDueño.Width = 50
        '
        'col_nombreDueño
        '
        Me.col_nombreDueño.HeaderText = "Nombre"
        Me.col_nombreDueño.Name = "col_nombreDueño"
        Me.col_nombreDueño.ReadOnly = True
        Me.col_nombreDueño.Width = 150
        '
        'col_apellidoDueño
        '
        Me.col_apellidoDueño.HeaderText = "Apellido"
        Me.col_apellidoDueño.Name = "col_apellidoDueño"
        Me.col_apellidoDueño.ReadOnly = True
        Me.col_apellidoDueño.Width = 150
        '
        'col_telefonoDueño
        '
        Me.col_telefonoDueño.HeaderText = "Telefono"
        Me.col_telefonoDueño.Name = "col_telefonoDueño"
        Me.col_telefonoDueño.ReadOnly = True
        '
        'frm_cargaDueño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Registrar_Dueño1
        Me.ClientSize = New System.Drawing.Size(567, 301)
        Me.Controls.Add(Me.gro_listaDueños)
        Me.Controls.Add(Me.gro_datosDueños)
        Me.Controls.Add(Me.btn_salirDueño)
        Me.Controls.Add(Me.btn_guardarDueño)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cargaDueño"
        Me.Text = ".:.Registrar Dueño.:."
        Me.gro_datosDueños.ResumeLayout(False)
        Me.gro_datosDueños.PerformLayout()
        Me.gro_listaDueños.ResumeLayout(False)
        CType(Me.dgv_listaDueños, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_idDueño As System.Windows.Forms.Label
    Friend WithEvents lbl_nombreDueño As System.Windows.Forms.Label
    Friend WithEvents lbl_apellidoDueño As System.Windows.Forms.Label
    Friend WithEvents lbl_telefonoDueño As System.Windows.Forms.Label
    Friend WithEvents txt_idDueño As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombreDueño As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellidoDueño As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefonoDueño As System.Windows.Forms.TextBox
    Friend WithEvents btn_agregarDueño As System.Windows.Forms.Button
    Friend WithEvents btn_guardarDueño As System.Windows.Forms.Button
    Friend WithEvents btn_salirDueño As System.Windows.Forms.Button
    Friend WithEvents gro_datosDueños As System.Windows.Forms.GroupBox
    Friend WithEvents gro_listaDueños As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_listaDueños As System.Windows.Forms.DataGridView
    Friend WithEvents col_idDueño As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombreDueño As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_apellidoDueño As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_telefonoDueño As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
