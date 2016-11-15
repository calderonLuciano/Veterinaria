<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editarDueño
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gro_buscarDueñoEditar = New System.Windows.Forms.GroupBox()
        Me.btn_buscarDueño = New System.Windows.Forms.Button()
        Me.txt_buscarDueño = New System.Windows.Forms.TextBox()
        Me.lbl_buscarDueñoEditar = New System.Windows.Forms.Label()
        Me.gro_datosDueñoEditar = New System.Windows.Forms.GroupBox()
        Me.btn_guardarDueñoEditar = New System.Windows.Forms.Button()
        Me.txt_idDueñoEditar = New System.Windows.Forms.TextBox()
        Me.txt_nombreDueñoEditar = New System.Windows.Forms.TextBox()
        Me.txt_apellidoDueñoEditar = New System.Windows.Forms.TextBox()
        Me.txt_telefonoDueñoEditar = New System.Windows.Forms.TextBox()
        Me.lbl_idDueñoEditar = New System.Windows.Forms.Label()
        Me.lbl_nombreDueñoEditar = New System.Windows.Forms.Label()
        Me.lbl_apellidoDueñoEditar = New System.Windows.Forms.Label()
        Me.lbl_telefonoDueñoEditar = New System.Windows.Forms.Label()
        Me.gro_listaDueñoEditar = New System.Windows.Forms.GroupBox()
        Me.dgv_listaDueñosEditar = New System.Windows.Forms.DataGridView()
        Me.col_idDueñoEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombreDueñoEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellidoDueñoEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefonoDueñoEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salirEditar = New System.Windows.Forms.Button()
        Me.gro_buscarDueñoEditar.SuspendLayout()
        Me.gro_datosDueñoEditar.SuspendLayout()
        Me.gro_listaDueñoEditar.SuspendLayout()
        CType(Me.dgv_listaDueñosEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gro_buscarDueñoEditar
        '
        Me.gro_buscarDueñoEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_buscarDueñoEditar.Controls.Add(Me.btn_buscarDueño)
        Me.gro_buscarDueñoEditar.Controls.Add(Me.txt_buscarDueño)
        Me.gro_buscarDueñoEditar.Controls.Add(Me.lbl_buscarDueñoEditar)
        Me.gro_buscarDueñoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_buscarDueñoEditar.ForeColor = System.Drawing.Color.White
        Me.gro_buscarDueñoEditar.Location = New System.Drawing.Point(12, 51)
        Me.gro_buscarDueñoEditar.Name = "gro_buscarDueñoEditar"
        Me.gro_buscarDueñoEditar.Size = New System.Drawing.Size(630, 66)
        Me.gro_buscarDueñoEditar.TabIndex = 0
        Me.gro_buscarDueñoEditar.TabStop = False
        Me.gro_buscarDueñoEditar.Text = "Buscar Dueño"
        '
        'btn_buscarDueño
        '
        Me.btn_buscarDueño.BackgroundImage = Global.Veterinaria.My.Resources.Resources.find
        Me.btn_buscarDueño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_buscarDueño.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarDueño.Location = New System.Drawing.Point(545, 22)
        Me.btn_buscarDueño.Name = "btn_buscarDueño"
        Me.btn_buscarDueño.Size = New System.Drawing.Size(59, 34)
        Me.btn_buscarDueño.TabIndex = 2
        Me.btn_buscarDueño.UseVisualStyleBackColor = True
        '
        'txt_buscarDueño
        '
        Me.txt_buscarDueño.Location = New System.Drawing.Point(134, 22)
        Me.txt_buscarDueño.Name = "txt_buscarDueño"
        Me.txt_buscarDueño.Size = New System.Drawing.Size(153, 23)
        Me.txt_buscarDueño.TabIndex = 1
        '
        'lbl_buscarDueñoEditar
        '
        Me.lbl_buscarDueñoEditar.AutoSize = True
        Me.lbl_buscarDueñoEditar.Location = New System.Drawing.Point(63, 25)
        Me.lbl_buscarDueñoEditar.Name = "lbl_buscarDueñoEditar"
        Me.lbl_buscarDueñoEditar.Size = New System.Drawing.Size(65, 16)
        Me.lbl_buscarDueñoEditar.TabIndex = 0
        Me.lbl_buscarDueñoEditar.Text = "Nombre:"
        '
        'gro_datosDueñoEditar
        '
        Me.gro_datosDueñoEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosDueñoEditar.Controls.Add(Me.btn_guardarDueñoEditar)
        Me.gro_datosDueñoEditar.Controls.Add(Me.txt_idDueñoEditar)
        Me.gro_datosDueñoEditar.Controls.Add(Me.txt_nombreDueñoEditar)
        Me.gro_datosDueñoEditar.Controls.Add(Me.txt_apellidoDueñoEditar)
        Me.gro_datosDueñoEditar.Controls.Add(Me.txt_telefonoDueñoEditar)
        Me.gro_datosDueñoEditar.Controls.Add(Me.lbl_idDueñoEditar)
        Me.gro_datosDueñoEditar.Controls.Add(Me.lbl_nombreDueñoEditar)
        Me.gro_datosDueñoEditar.Controls.Add(Me.lbl_apellidoDueñoEditar)
        Me.gro_datosDueñoEditar.Controls.Add(Me.lbl_telefonoDueñoEditar)
        Me.gro_datosDueñoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosDueñoEditar.ForeColor = System.Drawing.Color.White
        Me.gro_datosDueñoEditar.Location = New System.Drawing.Point(12, 123)
        Me.gro_datosDueñoEditar.Name = "gro_datosDueñoEditar"
        Me.gro_datosDueñoEditar.Size = New System.Drawing.Size(630, 114)
        Me.gro_datosDueñoEditar.TabIndex = 1
        Me.gro_datosDueñoEditar.TabStop = False
        Me.gro_datosDueñoEditar.Text = "Datos Dueños"
        '
        'btn_guardarDueñoEditar
        '
        Me.btn_guardarDueñoEditar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarDueñoEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardarDueñoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarDueñoEditar.Location = New System.Drawing.Point(545, 72)
        Me.btn_guardarDueñoEditar.Name = "btn_guardarDueñoEditar"
        Me.btn_guardarDueñoEditar.Size = New System.Drawing.Size(59, 36)
        Me.btn_guardarDueñoEditar.TabIndex = 3
        Me.btn_guardarDueñoEditar.UseVisualStyleBackColor = True
        '
        'txt_idDueñoEditar
        '
        Me.txt_idDueñoEditar.Enabled = False
        Me.txt_idDueñoEditar.Location = New System.Drawing.Point(134, 16)
        Me.txt_idDueñoEditar.Name = "txt_idDueñoEditar"
        Me.txt_idDueñoEditar.Size = New System.Drawing.Size(153, 23)
        Me.txt_idDueñoEditar.TabIndex = 2
        '
        'txt_nombreDueñoEditar
        '
        Me.txt_nombreDueñoEditar.Location = New System.Drawing.Point(134, 47)
        Me.txt_nombreDueñoEditar.MaxLength = 40
        Me.txt_nombreDueñoEditar.Name = "txt_nombreDueñoEditar"
        Me.txt_nombreDueñoEditar.Size = New System.Drawing.Size(153, 23)
        Me.txt_nombreDueñoEditar.TabIndex = 3
        '
        'txt_apellidoDueñoEditar
        '
        Me.txt_apellidoDueñoEditar.Location = New System.Drawing.Point(410, 13)
        Me.txt_apellidoDueñoEditar.MaxLength = 40
        Me.txt_apellidoDueñoEditar.Name = "txt_apellidoDueñoEditar"
        Me.txt_apellidoDueñoEditar.Size = New System.Drawing.Size(153, 23)
        Me.txt_apellidoDueñoEditar.TabIndex = 4
        '
        'txt_telefonoDueñoEditar
        '
        Me.txt_telefonoDueñoEditar.Location = New System.Drawing.Point(409, 43)
        Me.txt_telefonoDueñoEditar.MaxLength = 6
        Me.txt_telefonoDueñoEditar.Name = "txt_telefonoDueñoEditar"
        Me.txt_telefonoDueñoEditar.Size = New System.Drawing.Size(153, 23)
        Me.txt_telefonoDueñoEditar.TabIndex = 5
        '
        'lbl_idDueñoEditar
        '
        Me.lbl_idDueñoEditar.AutoSize = True
        Me.lbl_idDueñoEditar.Location = New System.Drawing.Point(103, 19)
        Me.lbl_idDueñoEditar.Name = "lbl_idDueñoEditar"
        Me.lbl_idDueñoEditar.Size = New System.Drawing.Size(25, 16)
        Me.lbl_idDueñoEditar.TabIndex = 1
        Me.lbl_idDueñoEditar.Text = "ID:"
        '
        'lbl_nombreDueñoEditar
        '
        Me.lbl_nombreDueñoEditar.AutoSize = True
        Me.lbl_nombreDueñoEditar.Location = New System.Drawing.Point(63, 50)
        Me.lbl_nombreDueñoEditar.Name = "lbl_nombreDueñoEditar"
        Me.lbl_nombreDueñoEditar.Size = New System.Drawing.Size(65, 16)
        Me.lbl_nombreDueñoEditar.TabIndex = 2
        Me.lbl_nombreDueñoEditar.Text = "Nombre:"
        '
        'lbl_apellidoDueñoEditar
        '
        Me.lbl_apellidoDueñoEditar.AutoSize = True
        Me.lbl_apellidoDueñoEditar.Location = New System.Drawing.Point(338, 16)
        Me.lbl_apellidoDueñoEditar.Name = "lbl_apellidoDueñoEditar"
        Me.lbl_apellidoDueñoEditar.Size = New System.Drawing.Size(66, 16)
        Me.lbl_apellidoDueñoEditar.TabIndex = 3
        Me.lbl_apellidoDueñoEditar.Text = "Apellido:"
        '
        'lbl_telefonoDueñoEditar
        '
        Me.lbl_telefonoDueñoEditar.AutoSize = True
        Me.lbl_telefonoDueñoEditar.Location = New System.Drawing.Point(338, 46)
        Me.lbl_telefonoDueñoEditar.Name = "lbl_telefonoDueñoEditar"
        Me.lbl_telefonoDueñoEditar.Size = New System.Drawing.Size(65, 16)
        Me.lbl_telefonoDueñoEditar.TabIndex = 4
        Me.lbl_telefonoDueñoEditar.Text = "Telefono:"
        '
        'gro_listaDueñoEditar
        '
        Me.gro_listaDueñoEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaDueñoEditar.Controls.Add(Me.dgv_listaDueñosEditar)
        Me.gro_listaDueñoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_listaDueñoEditar.ForeColor = System.Drawing.Color.White
        Me.gro_listaDueñoEditar.Location = New System.Drawing.Point(12, 243)
        Me.gro_listaDueñoEditar.Name = "gro_listaDueñoEditar"
        Me.gro_listaDueñoEditar.Size = New System.Drawing.Size(630, 142)
        Me.gro_listaDueñoEditar.TabIndex = 1
        Me.gro_listaDueñoEditar.TabStop = False
        Me.gro_listaDueñoEditar.Text = "Lista de Dueños"
        '
        'dgv_listaDueñosEditar
        '
        Me.dgv_listaDueñosEditar.AllowUserToAddRows = False
        Me.dgv_listaDueñosEditar.AllowUserToDeleteRows = False
        Me.dgv_listaDueñosEditar.AllowUserToResizeColumns = False
        Me.dgv_listaDueñosEditar.AllowUserToResizeRows = False
        Me.dgv_listaDueñosEditar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_listaDueñosEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaDueñosEditar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idDueñoEditar, Me.col_nombreDueñoEditar, Me.col_apellidoDueñoEditar, Me.col_telefonoDueñoEditar})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listaDueñosEditar.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listaDueñosEditar.Location = New System.Drawing.Point(6, 22)
        Me.dgv_listaDueñosEditar.MultiSelect = False
        Me.dgv_listaDueñosEditar.Name = "dgv_listaDueñosEditar"
        Me.dgv_listaDueñosEditar.ReadOnly = True
        Me.dgv_listaDueñosEditar.RowHeadersVisible = False
        Me.dgv_listaDueñosEditar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaDueñosEditar.Size = New System.Drawing.Size(618, 114)
        Me.dgv_listaDueñosEditar.TabIndex = 1
        '
        'col_idDueñoEditar
        '
        Me.col_idDueñoEditar.HeaderText = "ID"
        Me.col_idDueñoEditar.Name = "col_idDueñoEditar"
        Me.col_idDueñoEditar.ReadOnly = True
        '
        'col_nombreDueñoEditar
        '
        Me.col_nombreDueñoEditar.HeaderText = "Nombre"
        Me.col_nombreDueñoEditar.Name = "col_nombreDueñoEditar"
        Me.col_nombreDueñoEditar.ReadOnly = True
        '
        'col_apellidoDueñoEditar
        '
        Me.col_apellidoDueñoEditar.HeaderText = "Apellido"
        Me.col_apellidoDueñoEditar.Name = "col_apellidoDueñoEditar"
        Me.col_apellidoDueñoEditar.ReadOnly = True
        '
        'col_telefonoDueñoEditar
        '
        Me.col_telefonoDueñoEditar.HeaderText = "Telefono"
        Me.col_telefonoDueñoEditar.Name = "col_telefonoDueñoEditar"
        Me.col_telefonoDueñoEditar.ReadOnly = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Iconshock_Vista_General_Trash
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Location = New System.Drawing.Point(477, 391)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(60, 39)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_salirEditar
        '
        Me.btn_salirEditar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirEditar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salirEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salirEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirEditar.Location = New System.Drawing.Point(557, 391)
        Me.btn_salirEditar.Name = "btn_salirEditar"
        Me.btn_salirEditar.Size = New System.Drawing.Size(58, 39)
        Me.btn_salirEditar.TabIndex = 5
        Me.btn_salirEditar.UseVisualStyleBackColor = False
        '
        'frm_editarDueño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Editar_dueño
        Me.ClientSize = New System.Drawing.Size(660, 435)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_salirEditar)
        Me.Controls.Add(Me.gro_datosDueñoEditar)
        Me.Controls.Add(Me.gro_listaDueñoEditar)
        Me.Controls.Add(Me.gro_buscarDueñoEditar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_editarDueño"
        Me.Text = "frm_editarDueño"
        Me.gro_buscarDueñoEditar.ResumeLayout(False)
        Me.gro_buscarDueñoEditar.PerformLayout()
        Me.gro_datosDueñoEditar.ResumeLayout(False)
        Me.gro_datosDueñoEditar.PerformLayout()
        Me.gro_listaDueñoEditar.ResumeLayout(False)
        CType(Me.dgv_listaDueñosEditar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gro_buscarDueñoEditar As System.Windows.Forms.GroupBox
    Friend WithEvents gro_datosDueñoEditar As System.Windows.Forms.GroupBox
    Friend WithEvents gro_listaDueñoEditar As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_buscarDueñoEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_idDueñoEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_nombreDueñoEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_apellidoDueñoEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_telefonoDueñoEditar As System.Windows.Forms.Label
    Friend WithEvents btn_guardarDueñoEditar As System.Windows.Forms.Button
    Friend WithEvents btn_buscarDueño As System.Windows.Forms.Button
    Friend WithEvents txt_buscarDueño As System.Windows.Forms.TextBox
    Friend WithEvents txt_idDueñoEditar As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombreDueñoEditar As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellidoDueñoEditar As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefonoDueñoEditar As System.Windows.Forms.TextBox
    Friend WithEvents dgv_listaDueñosEditar As System.Windows.Forms.DataGridView
    Friend WithEvents col_idDueñoEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombreDueñoEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_apellidoDueñoEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_telefonoDueñoEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_salirEditar As System.Windows.Forms.Button
End Class
