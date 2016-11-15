<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editarPerro
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
        Me.lbl_buscarPerro = New System.Windows.Forms.Label()
        Me.gro_buscarPerro = New System.Windows.Forms.GroupBox()
        Me.btn_buscarPerro = New System.Windows.Forms.Button()
        Me.txt_buscarPerro = New System.Windows.Forms.TextBox()
        Me.gro_datosPerroEditar = New System.Windows.Forms.GroupBox()
        Me.btn_guardarPerroEditar = New System.Windows.Forms.Button()
        Me.mkb_fechaNacimientoEditar = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_idRazaEditar = New System.Windows.Forms.ComboBox()
        Me.cbo_idDueñoEditar = New System.Windows.Forms.ComboBox()
        Me.cbo_idSucursalEditar = New System.Windows.Forms.ComboBox()
        Me.txt_alturaEditar = New System.Windows.Forms.TextBox()
        Me.txt_pesoEditar = New System.Windows.Forms.TextBox()
        Me.txt_nombrePerroEditar = New System.Windows.Forms.TextBox()
        Me.txt_nroHistoriaClinicaEditar = New System.Windows.Forms.TextBox()
        Me.lbl_idDueñoPerroEditar = New System.Windows.Forms.Label()
        Me.lbl_alturaPerroEditar = New System.Windows.Forms.Label()
        Me.lbl_pesoPerroEditar = New System.Windows.Forms.Label()
        Me.lbl_idRazaEditar = New System.Windows.Forms.Label()
        Me.lbl_fechaNacPerroEditar = New System.Windows.Forms.Label()
        Me.lbl_nombrePerroEditar = New System.Windows.Forms.Label()
        Me.lbl_idSucursalEditar = New System.Windows.Forms.Label()
        Me.lbl_nro_historiaClinicaEditar = New System.Windows.Forms.Label()
        Me.gro_listaPerrosEditar = New System.Windows.Forms.GroupBox()
        Me.dgv_listaPerrosEditar = New System.Windows.Forms.DataGridView()
        Me.col_nroHistoriaClinicaEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idSucursalEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombrePerroEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaNacimientoPerroEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idRazaEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idDueñoEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pesoEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_alturaEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_eliminarPerro = New System.Windows.Forms.Button()
        Me.btn_SalirEditar = New System.Windows.Forms.Button()
        Me.gro_buscarPerro.SuspendLayout()
        Me.gro_datosPerroEditar.SuspendLayout()
        Me.gro_listaPerrosEditar.SuspendLayout()
        CType(Me.dgv_listaPerrosEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_buscarPerro
        '
        Me.lbl_buscarPerro.AutoSize = True
        Me.lbl_buscarPerro.Location = New System.Drawing.Point(117, 30)
        Me.lbl_buscarPerro.Name = "lbl_buscarPerro"
        Me.lbl_buscarPerro.Size = New System.Drawing.Size(65, 16)
        Me.lbl_buscarPerro.TabIndex = 1
        Me.lbl_buscarPerro.Text = "Nombre:"
        '
        'gro_buscarPerro
        '
        Me.gro_buscarPerro.BackColor = System.Drawing.Color.Transparent
        Me.gro_buscarPerro.Controls.Add(Me.btn_buscarPerro)
        Me.gro_buscarPerro.Controls.Add(Me.txt_buscarPerro)
        Me.gro_buscarPerro.Controls.Add(Me.lbl_buscarPerro)
        Me.gro_buscarPerro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_buscarPerro.ForeColor = System.Drawing.Color.White
        Me.gro_buscarPerro.Location = New System.Drawing.Point(6, 46)
        Me.gro_buscarPerro.Name = "gro_buscarPerro"
        Me.gro_buscarPerro.Size = New System.Drawing.Size(851, 67)
        Me.gro_buscarPerro.TabIndex = 8
        Me.gro_buscarPerro.TabStop = False
        Me.gro_buscarPerro.Text = "Buscar Perro"
        '
        'btn_buscarPerro
        '
        Me.btn_buscarPerro.BackgroundImage = Global.Veterinaria.My.Resources.Resources.find
        Me.btn_buscarPerro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_buscarPerro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarPerro.Location = New System.Drawing.Point(716, 15)
        Me.btn_buscarPerro.Name = "btn_buscarPerro"
        Me.btn_buscarPerro.Size = New System.Drawing.Size(62, 46)
        Me.btn_buscarPerro.TabIndex = 3
        Me.btn_buscarPerro.UseVisualStyleBackColor = True
        '
        'txt_buscarPerro
        '
        Me.txt_buscarPerro.Location = New System.Drawing.Point(193, 28)
        Me.txt_buscarPerro.Name = "txt_buscarPerro"
        Me.txt_buscarPerro.Size = New System.Drawing.Size(251, 23)
        Me.txt_buscarPerro.TabIndex = 2
        '
        'gro_datosPerroEditar
        '
        Me.gro_datosPerroEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosPerroEditar.Controls.Add(Me.btn_guardarPerroEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.mkb_fechaNacimientoEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.cbo_idRazaEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.cbo_idDueñoEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.cbo_idSucursalEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.txt_alturaEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.txt_pesoEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.txt_nombrePerroEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.txt_nroHistoriaClinicaEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.lbl_idDueñoPerroEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.lbl_alturaPerroEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.lbl_pesoPerroEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.lbl_idRazaEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.lbl_fechaNacPerroEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.lbl_nombrePerroEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.lbl_idSucursalEditar)
        Me.gro_datosPerroEditar.Controls.Add(Me.lbl_nro_historiaClinicaEditar)
        Me.gro_datosPerroEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosPerroEditar.ForeColor = System.Drawing.Color.White
        Me.gro_datosPerroEditar.Location = New System.Drawing.Point(8, 119)
        Me.gro_datosPerroEditar.Name = "gro_datosPerroEditar"
        Me.gro_datosPerroEditar.Size = New System.Drawing.Size(849, 198)
        Me.gro_datosPerroEditar.TabIndex = 9
        Me.gro_datosPerroEditar.TabStop = False
        Me.gro_datosPerroEditar.Text = "Datos Perros"
        '
        'btn_guardarPerroEditar
        '
        Me.btn_guardarPerroEditar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarPerroEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardarPerroEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarPerroEditar.Location = New System.Drawing.Point(771, 152)
        Me.btn_guardarPerroEditar.Name = "btn_guardarPerroEditar"
        Me.btn_guardarPerroEditar.Size = New System.Drawing.Size(57, 40)
        Me.btn_guardarPerroEditar.TabIndex = 33
        Me.btn_guardarPerroEditar.UseVisualStyleBackColor = True
        '
        'mkb_fechaNacimientoEditar
        '
        Me.mkb_fechaNacimientoEditar.Location = New System.Drawing.Point(517, 140)
        Me.mkb_fechaNacimientoEditar.Mask = "00/00/0000"
        Me.mkb_fechaNacimientoEditar.Name = "mkb_fechaNacimientoEditar"
        Me.mkb_fechaNacimientoEditar.Size = New System.Drawing.Size(141, 23)
        Me.mkb_fechaNacimientoEditar.TabIndex = 32
        Me.mkb_fechaNacimientoEditar.ValidatingType = GetType(Date)
        '
        'cbo_idRazaEditar
        '
        Me.cbo_idRazaEditar.FormattingEnabled = True
        Me.cbo_idRazaEditar.Location = New System.Drawing.Point(517, 63)
        Me.cbo_idRazaEditar.Name = "cbo_idRazaEditar"
        Me.cbo_idRazaEditar.Size = New System.Drawing.Size(141, 24)
        Me.cbo_idRazaEditar.TabIndex = 31
        '
        'cbo_idDueñoEditar
        '
        Me.cbo_idDueñoEditar.FormattingEnabled = True
        Me.cbo_idDueñoEditar.Location = New System.Drawing.Point(517, 98)
        Me.cbo_idDueñoEditar.Name = "cbo_idDueñoEditar"
        Me.cbo_idDueñoEditar.Size = New System.Drawing.Size(141, 24)
        Me.cbo_idDueñoEditar.TabIndex = 30
        '
        'cbo_idSucursalEditar
        '
        Me.cbo_idSucursalEditar.FormattingEnabled = True
        Me.cbo_idSucursalEditar.Location = New System.Drawing.Point(517, 21)
        Me.cbo_idSucursalEditar.Name = "cbo_idSucursalEditar"
        Me.cbo_idSucursalEditar.Size = New System.Drawing.Size(141, 24)
        Me.cbo_idSucursalEditar.TabIndex = 29
        '
        'txt_alturaEditar
        '
        Me.txt_alturaEditar.Location = New System.Drawing.Point(186, 140)
        Me.txt_alturaEditar.MaxLength = 5
        Me.txt_alturaEditar.Name = "txt_alturaEditar"
        Me.txt_alturaEditar.Size = New System.Drawing.Size(138, 23)
        Me.txt_alturaEditar.TabIndex = 28
        '
        'txt_pesoEditar
        '
        Me.txt_pesoEditar.Location = New System.Drawing.Point(186, 98)
        Me.txt_pesoEditar.MaxLength = 5
        Me.txt_pesoEditar.Name = "txt_pesoEditar"
        Me.txt_pesoEditar.Size = New System.Drawing.Size(138, 23)
        Me.txt_pesoEditar.TabIndex = 27
        '
        'txt_nombrePerroEditar
        '
        Me.txt_nombrePerroEditar.Location = New System.Drawing.Point(186, 59)
        Me.txt_nombrePerroEditar.MaxLength = 40
        Me.txt_nombrePerroEditar.Name = "txt_nombrePerroEditar"
        Me.txt_nombrePerroEditar.Size = New System.Drawing.Size(138, 23)
        Me.txt_nombrePerroEditar.TabIndex = 26
        '
        'txt_nroHistoriaClinicaEditar
        '
        Me.txt_nroHistoriaClinicaEditar.Enabled = False
        Me.txt_nroHistoriaClinicaEditar.Location = New System.Drawing.Point(186, 21)
        Me.txt_nroHistoriaClinicaEditar.MaxLength = 10
        Me.txt_nroHistoriaClinicaEditar.Name = "txt_nroHistoriaClinicaEditar"
        Me.txt_nroHistoriaClinicaEditar.Size = New System.Drawing.Size(138, 23)
        Me.txt_nroHistoriaClinicaEditar.TabIndex = 25
        '
        'lbl_idDueñoPerroEditar
        '
        Me.lbl_idDueñoPerroEditar.AutoSize = True
        Me.lbl_idDueñoPerroEditar.Location = New System.Drawing.Point(420, 105)
        Me.lbl_idDueñoPerroEditar.Name = "lbl_idDueñoPerroEditar"
        Me.lbl_idDueñoPerroEditar.Size = New System.Drawing.Size(59, 16)
        Me.lbl_idDueñoPerroEditar.TabIndex = 24
        Me.lbl_idDueñoPerroEditar.Text = " Dueño:"
        '
        'lbl_alturaPerroEditar
        '
        Me.lbl_alturaPerroEditar.AutoSize = True
        Me.lbl_alturaPerroEditar.Location = New System.Drawing.Point(129, 143)
        Me.lbl_alturaPerroEditar.Name = "lbl_alturaPerroEditar"
        Me.lbl_alturaPerroEditar.Size = New System.Drawing.Size(51, 16)
        Me.lbl_alturaPerroEditar.TabIndex = 23
        Me.lbl_alturaPerroEditar.Text = "Altura:"
        '
        'lbl_pesoPerroEditar
        '
        Me.lbl_pesoPerroEditar.AutoSize = True
        Me.lbl_pesoPerroEditar.Location = New System.Drawing.Point(138, 105)
        Me.lbl_pesoPerroEditar.Name = "lbl_pesoPerroEditar"
        Me.lbl_pesoPerroEditar.Size = New System.Drawing.Size(42, 16)
        Me.lbl_pesoPerroEditar.TabIndex = 22
        Me.lbl_pesoPerroEditar.Text = "Peso:"
        '
        'lbl_idRazaEditar
        '
        Me.lbl_idRazaEditar.AutoSize = True
        Me.lbl_idRazaEditar.Location = New System.Drawing.Point(427, 66)
        Me.lbl_idRazaEditar.Name = "lbl_idRazaEditar"
        Me.lbl_idRazaEditar.Size = New System.Drawing.Size(48, 16)
        Me.lbl_idRazaEditar.TabIndex = 21
        Me.lbl_idRazaEditar.Text = " Raza:"
        '
        'lbl_fechaNacPerroEditar
        '
        Me.lbl_fechaNacPerroEditar.AutoSize = True
        Me.lbl_fechaNacPerroEditar.Location = New System.Drawing.Point(380, 143)
        Me.lbl_fechaNacPerroEditar.Name = "lbl_fechaNacPerroEditar"
        Me.lbl_fechaNacPerroEditar.Size = New System.Drawing.Size(131, 16)
        Me.lbl_fechaNacPerroEditar.TabIndex = 20
        Me.lbl_fechaNacPerroEditar.Text = "Fecha Nacimiento:"
        '
        'lbl_nombrePerroEditar
        '
        Me.lbl_nombrePerroEditar.AutoSize = True
        Me.lbl_nombrePerroEditar.Location = New System.Drawing.Point(115, 62)
        Me.lbl_nombrePerroEditar.Name = "lbl_nombrePerroEditar"
        Me.lbl_nombrePerroEditar.Size = New System.Drawing.Size(65, 16)
        Me.lbl_nombrePerroEditar.TabIndex = 19
        Me.lbl_nombrePerroEditar.Text = "Nombre:"
        '
        'lbl_idSucursalEditar
        '
        Me.lbl_idSucursalEditar.AutoSize = True
        Me.lbl_idSucursalEditar.Location = New System.Drawing.Point(411, 24)
        Me.lbl_idSucursalEditar.Name = "lbl_idSucursalEditar"
        Me.lbl_idSucursalEditar.Size = New System.Drawing.Size(67, 16)
        Me.lbl_idSucursalEditar.TabIndex = 18
        Me.lbl_idSucursalEditar.Text = " Sucursal:"
        '
        'lbl_nro_historiaClinicaEditar
        '
        Me.lbl_nro_historiaClinicaEditar.AutoSize = True
        Me.lbl_nro_historiaClinicaEditar.Location = New System.Drawing.Point(-1, 24)
        Me.lbl_nro_historiaClinicaEditar.Name = "lbl_nro_historiaClinicaEditar"
        Me.lbl_nro_historiaClinicaEditar.Size = New System.Drawing.Size(181, 16)
        Me.lbl_nro_historiaClinicaEditar.TabIndex = 17
        Me.lbl_nro_historiaClinicaEditar.Text = "Nùmero de historia clínica:"
        '
        'gro_listaPerrosEditar
        '
        Me.gro_listaPerrosEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaPerrosEditar.Controls.Add(Me.dgv_listaPerrosEditar)
        Me.gro_listaPerrosEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_listaPerrosEditar.ForeColor = System.Drawing.Color.White
        Me.gro_listaPerrosEditar.Location = New System.Drawing.Point(12, 323)
        Me.gro_listaPerrosEditar.Name = "gro_listaPerrosEditar"
        Me.gro_listaPerrosEditar.Size = New System.Drawing.Size(845, 178)
        Me.gro_listaPerrosEditar.TabIndex = 10
        Me.gro_listaPerrosEditar.TabStop = False
        Me.gro_listaPerrosEditar.Text = "Lista de Perros"
        '
        'dgv_listaPerrosEditar
        '
        Me.dgv_listaPerrosEditar.AllowUserToAddRows = False
        Me.dgv_listaPerrosEditar.AllowUserToDeleteRows = False
        Me.dgv_listaPerrosEditar.AllowUserToResizeColumns = False
        Me.dgv_listaPerrosEditar.AllowUserToResizeRows = False
        Me.dgv_listaPerrosEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaPerrosEditar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nroHistoriaClinicaEditar, Me.col_idSucursalEditar, Me.col_nombrePerroEditar, Me.col_fechaNacimientoPerroEditar, Me.col_idRazaEditar, Me.col_idDueñoEditar, Me.col_pesoEditar, Me.col_alturaEditar})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listaPerrosEditar.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listaPerrosEditar.Location = New System.Drawing.Point(6, 19)
        Me.dgv_listaPerrosEditar.MultiSelect = False
        Me.dgv_listaPerrosEditar.Name = "dgv_listaPerrosEditar"
        Me.dgv_listaPerrosEditar.ReadOnly = True
        Me.dgv_listaPerrosEditar.RowHeadersVisible = False
        Me.dgv_listaPerrosEditar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaPerrosEditar.Size = New System.Drawing.Size(829, 143)
        Me.dgv_listaPerrosEditar.TabIndex = 1
        '
        'col_nroHistoriaClinicaEditar
        '
        Me.col_nroHistoriaClinicaEditar.HeaderText = "Número de Historia Clínica"
        Me.col_nroHistoriaClinicaEditar.Name = "col_nroHistoriaClinicaEditar"
        Me.col_nroHistoriaClinicaEditar.ReadOnly = True
        '
        'col_idSucursalEditar
        '
        Me.col_idSucursalEditar.HeaderText = "ID Sucursal"
        Me.col_idSucursalEditar.Name = "col_idSucursalEditar"
        Me.col_idSucursalEditar.ReadOnly = True
        '
        'col_nombrePerroEditar
        '
        Me.col_nombrePerroEditar.HeaderText = "Nombre"
        Me.col_nombrePerroEditar.Name = "col_nombrePerroEditar"
        Me.col_nombrePerroEditar.ReadOnly = True
        '
        'col_fechaNacimientoPerroEditar
        '
        Me.col_fechaNacimientoPerroEditar.HeaderText = "Fecha de Nacimiento"
        Me.col_fechaNacimientoPerroEditar.Name = "col_fechaNacimientoPerroEditar"
        Me.col_fechaNacimientoPerroEditar.ReadOnly = True
        '
        'col_idRazaEditar
        '
        Me.col_idRazaEditar.HeaderText = "ID Raza"
        Me.col_idRazaEditar.Name = "col_idRazaEditar"
        Me.col_idRazaEditar.ReadOnly = True
        '
        'col_idDueñoEditar
        '
        Me.col_idDueñoEditar.HeaderText = "ID Dueño"
        Me.col_idDueñoEditar.Name = "col_idDueñoEditar"
        Me.col_idDueñoEditar.ReadOnly = True
        '
        'col_pesoEditar
        '
        Me.col_pesoEditar.HeaderText = "Peso"
        Me.col_pesoEditar.Name = "col_pesoEditar"
        Me.col_pesoEditar.ReadOnly = True
        '
        'col_alturaEditar
        '
        Me.col_alturaEditar.HeaderText = "Altura"
        Me.col_alturaEditar.Name = "col_alturaEditar"
        Me.col_alturaEditar.ReadOnly = True
        '
        'btn_eliminarPerro
        '
        Me.btn_eliminarPerro.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminarPerro.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Iconshock_Vista_General_Trash
        Me.btn_eliminarPerro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminarPerro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminarPerro.Location = New System.Drawing.Point(739, 507)
        Me.btn_eliminarPerro.Name = "btn_eliminarPerro"
        Me.btn_eliminarPerro.Size = New System.Drawing.Size(58, 36)
        Me.btn_eliminarPerro.TabIndex = 12
        Me.btn_eliminarPerro.UseVisualStyleBackColor = False
        '
        'btn_SalirEditar
        '
        Me.btn_SalirEditar.BackColor = System.Drawing.Color.Transparent
        Me.btn_SalirEditar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_SalirEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_SalirEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SalirEditar.Location = New System.Drawing.Point(803, 507)
        Me.btn_SalirEditar.Name = "btn_SalirEditar"
        Me.btn_SalirEditar.Size = New System.Drawing.Size(56, 36)
        Me.btn_SalirEditar.TabIndex = 13
        Me.btn_SalirEditar.UseVisualStyleBackColor = False
        '
        'frm_editarPerro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.editar_perros
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 555)
        Me.Controls.Add(Me.btn_eliminarPerro)
        Me.Controls.Add(Me.btn_SalirEditar)
        Me.Controls.Add(Me.gro_listaPerrosEditar)
        Me.Controls.Add(Me.gro_datosPerroEditar)
        Me.Controls.Add(Me.gro_buscarPerro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_editarPerro"
        Me.Text = ".:.Editar Perros.:."
        Me.gro_buscarPerro.ResumeLayout(False)
        Me.gro_buscarPerro.PerformLayout()
        Me.gro_datosPerroEditar.ResumeLayout(False)
        Me.gro_datosPerroEditar.PerformLayout()
        Me.gro_listaPerrosEditar.ResumeLayout(False)
        CType(Me.dgv_listaPerrosEditar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_buscarPerro As System.Windows.Forms.Label
    Friend WithEvents gro_buscarPerro As System.Windows.Forms.GroupBox
    Friend WithEvents btn_buscarPerro As System.Windows.Forms.Button
    Friend WithEvents txt_buscarPerro As System.Windows.Forms.TextBox
    Friend WithEvents gro_datosPerroEditar As System.Windows.Forms.GroupBox
    Friend WithEvents gro_listaPerrosEditar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminarPerro As System.Windows.Forms.Button
    Friend WithEvents btn_SalirEditar As System.Windows.Forms.Button
    Friend WithEvents dgv_listaPerrosEditar As System.Windows.Forms.DataGridView
    Friend WithEvents btn_guardarPerroEditar As System.Windows.Forms.Button
    Friend WithEvents mkb_fechaNacimientoEditar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbo_idRazaEditar As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_idDueñoEditar As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_idSucursalEditar As System.Windows.Forms.ComboBox
    Friend WithEvents txt_alturaEditar As System.Windows.Forms.TextBox
    Friend WithEvents txt_pesoEditar As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombrePerroEditar As System.Windows.Forms.TextBox
    Friend WithEvents txt_nroHistoriaClinicaEditar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_idDueñoPerroEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_alturaPerroEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_pesoPerroEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_idRazaEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaNacPerroEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_nombrePerroEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_idSucursalEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_nro_historiaClinicaEditar As System.Windows.Forms.Label
    Friend WithEvents col_nroHistoriaClinicaEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idSucursalEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombrePerroEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaNacimientoPerroEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idRazaEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idDueñoEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_pesoEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_alturaEditar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
