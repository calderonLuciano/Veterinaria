<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cargaPerro
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
        Me.lbl_nro_historiaClinica = New System.Windows.Forms.Label()
        Me.lbl_idSucursal = New System.Windows.Forms.Label()
        Me.lbl_nombrePerro = New System.Windows.Forms.Label()
        Me.lbl_fechaNacPerro = New System.Windows.Forms.Label()
        Me.lbl_idRaza = New System.Windows.Forms.Label()
        Me.lbl_pesoPerro = New System.Windows.Forms.Label()
        Me.lbl_alturaPerro = New System.Windows.Forms.Label()
        Me.lbl_idDueñoPerro = New System.Windows.Forms.Label()
        Me.txt_nroHistoriaClinica = New System.Windows.Forms.TextBox()
        Me.txt_nombrePerro = New System.Windows.Forms.TextBox()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.txt_altura = New System.Windows.Forms.TextBox()
        Me.cbo_idSucursal = New System.Windows.Forms.ComboBox()
        Me.cbo_idDueño = New System.Windows.Forms.ComboBox()
        Me.cbo_idRaza = New System.Windows.Forms.ComboBox()
        Me.mkb_fechaNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.gro_datosPerros = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_agregarPerro = New System.Windows.Forms.Button()
        Me.gro_listaPerros = New System.Windows.Forms.GroupBox()
        Me.dgv_listaPerros = New System.Windows.Forms.DataGridView()
        Me.col_nroHistoriaClinica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombrePerro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaNacimientoPerro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idRaza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idDueño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_altura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_guardarPerro = New System.Windows.Forms.Button()
        Me.gro_datosPerros.SuspendLayout()
        Me.gro_listaPerros.SuspendLayout()
        CType(Me.dgv_listaPerros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nro_historiaClinica
        '
        Me.lbl_nro_historiaClinica.AutoSize = True
        Me.lbl_nro_historiaClinica.Location = New System.Drawing.Point(6, 21)
        Me.lbl_nro_historiaClinica.Name = "lbl_nro_historiaClinica"
        Me.lbl_nro_historiaClinica.Size = New System.Drawing.Size(181, 16)
        Me.lbl_nro_historiaClinica.TabIndex = 0
        Me.lbl_nro_historiaClinica.Text = "Nùmero de historia clínica:"
        '
        'lbl_idSucursal
        '
        Me.lbl_idSucursal.AutoSize = True
        Me.lbl_idSucursal.Location = New System.Drawing.Point(450, 25)
        Me.lbl_idSucursal.Name = "lbl_idSucursal"
        Me.lbl_idSucursal.Size = New System.Drawing.Size(67, 16)
        Me.lbl_idSucursal.TabIndex = 1
        Me.lbl_idSucursal.Text = " Sucursal:"
        '
        'lbl_nombrePerro
        '
        Me.lbl_nombrePerro.AutoSize = True
        Me.lbl_nombrePerro.Location = New System.Drawing.Point(121, 50)
        Me.lbl_nombrePerro.Name = "lbl_nombrePerro"
        Me.lbl_nombrePerro.Size = New System.Drawing.Size(65, 16)
        Me.lbl_nombrePerro.TabIndex = 2
        Me.lbl_nombrePerro.Text = "Nombre:"
        '
        'lbl_fechaNacPerro
        '
        Me.lbl_fechaNacPerro.AutoSize = True
        Me.lbl_fechaNacPerro.Location = New System.Drawing.Point(386, 112)
        Me.lbl_fechaNacPerro.Name = "lbl_fechaNacPerro"
        Me.lbl_fechaNacPerro.Size = New System.Drawing.Size(131, 16)
        Me.lbl_fechaNacPerro.TabIndex = 3
        Me.lbl_fechaNacPerro.Text = "Fecha Nacimiento:"
        '
        'lbl_idRaza
        '
        Me.lbl_idRaza.AutoSize = True
        Me.lbl_idRaza.Location = New System.Drawing.Point(469, 51)
        Me.lbl_idRaza.Name = "lbl_idRaza"
        Me.lbl_idRaza.Size = New System.Drawing.Size(48, 16)
        Me.lbl_idRaza.TabIndex = 4
        Me.lbl_idRaza.Text = " Raza:"
        '
        'lbl_pesoPerro
        '
        Me.lbl_pesoPerro.AutoSize = True
        Me.lbl_pesoPerro.Location = New System.Drawing.Point(144, 76)
        Me.lbl_pesoPerro.Name = "lbl_pesoPerro"
        Me.lbl_pesoPerro.Size = New System.Drawing.Size(42, 16)
        Me.lbl_pesoPerro.TabIndex = 5
        Me.lbl_pesoPerro.Text = "Peso:"
        '
        'lbl_alturaPerro
        '
        Me.lbl_alturaPerro.AutoSize = True
        Me.lbl_alturaPerro.Location = New System.Drawing.Point(136, 108)
        Me.lbl_alturaPerro.Name = "lbl_alturaPerro"
        Me.lbl_alturaPerro.Size = New System.Drawing.Size(51, 16)
        Me.lbl_alturaPerro.TabIndex = 6
        Me.lbl_alturaPerro.Text = "Altura:"
        '
        'lbl_idDueñoPerro
        '
        Me.lbl_idDueñoPerro.AutoSize = True
        Me.lbl_idDueñoPerro.Location = New System.Drawing.Point(458, 83)
        Me.lbl_idDueñoPerro.Name = "lbl_idDueñoPerro"
        Me.lbl_idDueñoPerro.Size = New System.Drawing.Size(59, 16)
        Me.lbl_idDueñoPerro.TabIndex = 7
        Me.lbl_idDueñoPerro.Text = " Dueño:"
        '
        'txt_nroHistoriaClinica
        '
        Me.txt_nroHistoriaClinica.Enabled = False
        Me.txt_nroHistoriaClinica.Location = New System.Drawing.Point(192, 18)
        Me.txt_nroHistoriaClinica.MaxLength = 10
        Me.txt_nroHistoriaClinica.Name = "txt_nroHistoriaClinica"
        Me.txt_nroHistoriaClinica.Size = New System.Drawing.Size(138, 23)
        Me.txt_nroHistoriaClinica.TabIndex = 8
        '
        'txt_nombrePerro
        '
        Me.txt_nombrePerro.Location = New System.Drawing.Point(192, 47)
        Me.txt_nombrePerro.MaxLength = 40
        Me.txt_nombrePerro.Name = "txt_nombrePerro"
        Me.txt_nombrePerro.Size = New System.Drawing.Size(138, 23)
        Me.txt_nombrePerro.TabIndex = 9
        '
        'txt_peso
        '
        Me.txt_peso.Location = New System.Drawing.Point(192, 76)
        Me.txt_peso.MaxLength = 5
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(138, 23)
        Me.txt_peso.TabIndex = 10
        '
        'txt_altura
        '
        Me.txt_altura.Location = New System.Drawing.Point(192, 105)
        Me.txt_altura.MaxLength = 5
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(138, 23)
        Me.txt_altura.TabIndex = 11
        '
        'cbo_idSucursal
        '
        Me.cbo_idSucursal.FormattingEnabled = True
        Me.cbo_idSucursal.Location = New System.Drawing.Point(523, 18)
        Me.cbo_idSucursal.Name = "cbo_idSucursal"
        Me.cbo_idSucursal.Size = New System.Drawing.Size(141, 24)
        Me.cbo_idSucursal.TabIndex = 12
        '
        'cbo_idDueño
        '
        Me.cbo_idDueño.FormattingEnabled = True
        Me.cbo_idDueño.Location = New System.Drawing.Point(523, 78)
        Me.cbo_idDueño.Name = "cbo_idDueño"
        Me.cbo_idDueño.Size = New System.Drawing.Size(141, 24)
        Me.cbo_idDueño.TabIndex = 13
        '
        'cbo_idRaza
        '
        Me.cbo_idRaza.FormattingEnabled = True
        Me.cbo_idRaza.Location = New System.Drawing.Point(523, 48)
        Me.cbo_idRaza.Name = "cbo_idRaza"
        Me.cbo_idRaza.Size = New System.Drawing.Size(141, 24)
        Me.cbo_idRaza.TabIndex = 14
        '
        'mkb_fechaNacimiento
        '
        Me.mkb_fechaNacimiento.Location = New System.Drawing.Point(523, 108)
        Me.mkb_fechaNacimiento.Mask = "00/00/0000"
        Me.mkb_fechaNacimiento.Name = "mkb_fechaNacimiento"
        Me.mkb_fechaNacimiento.Size = New System.Drawing.Size(141, 23)
        Me.mkb_fechaNacimiento.TabIndex = 15
        Me.mkb_fechaNacimiento.ValidatingType = GetType(Date)
        '
        'gro_datosPerros
        '
        Me.gro_datosPerros.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosPerros.Controls.Add(Me.Label2)
        Me.gro_datosPerros.Controls.Add(Me.Label1)
        Me.gro_datosPerros.Controls.Add(Me.btn_agregarPerro)
        Me.gro_datosPerros.Controls.Add(Me.mkb_fechaNacimiento)
        Me.gro_datosPerros.Controls.Add(Me.cbo_idRaza)
        Me.gro_datosPerros.Controls.Add(Me.cbo_idDueño)
        Me.gro_datosPerros.Controls.Add(Me.cbo_idSucursal)
        Me.gro_datosPerros.Controls.Add(Me.txt_altura)
        Me.gro_datosPerros.Controls.Add(Me.txt_peso)
        Me.gro_datosPerros.Controls.Add(Me.txt_nombrePerro)
        Me.gro_datosPerros.Controls.Add(Me.txt_nroHistoriaClinica)
        Me.gro_datosPerros.Controls.Add(Me.lbl_idDueñoPerro)
        Me.gro_datosPerros.Controls.Add(Me.lbl_alturaPerro)
        Me.gro_datosPerros.Controls.Add(Me.lbl_pesoPerro)
        Me.gro_datosPerros.Controls.Add(Me.lbl_idRaza)
        Me.gro_datosPerros.Controls.Add(Me.lbl_fechaNacPerro)
        Me.gro_datosPerros.Controls.Add(Me.lbl_nombrePerro)
        Me.gro_datosPerros.Controls.Add(Me.lbl_idSucursal)
        Me.gro_datosPerros.Controls.Add(Me.lbl_nro_historiaClinica)
        Me.gro_datosPerros.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosPerros.ForeColor = System.Drawing.Color.White
        Me.gro_datosPerros.Location = New System.Drawing.Point(12, 57)
        Me.gro_datosPerros.Name = "gro_datosPerros"
        Me.gro_datosPerros.Size = New System.Drawing.Size(887, 150)
        Me.gro_datosPerros.TabIndex = 16
        Me.gro_datosPerros.TabStop = False
        Me.gro_datosPerros.Text = "Datos Perros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "CM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "KG"
        '
        'btn_agregarPerro
        '
        Me.btn_agregarPerro.BackgroundImage = Global.Veterinaria.My.Resources.Resources.add
        Me.btn_agregarPerro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregarPerro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregarPerro.Location = New System.Drawing.Point(716, 87)
        Me.btn_agregarPerro.Name = "btn_agregarPerro"
        Me.btn_agregarPerro.Size = New System.Drawing.Size(52, 41)
        Me.btn_agregarPerro.TabIndex = 16
        Me.btn_agregarPerro.UseVisualStyleBackColor = True
        '
        'gro_listaPerros
        '
        Me.gro_listaPerros.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaPerros.Controls.Add(Me.dgv_listaPerros)
        Me.gro_listaPerros.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_listaPerros.ForeColor = System.Drawing.Color.White
        Me.gro_listaPerros.Location = New System.Drawing.Point(9, 213)
        Me.gro_listaPerros.Name = "gro_listaPerros"
        Me.gro_listaPerros.Size = New System.Drawing.Size(890, 180)
        Me.gro_listaPerros.TabIndex = 17
        Me.gro_listaPerros.TabStop = False
        Me.gro_listaPerros.Text = "Lista de Perros"
        '
        'dgv_listaPerros
        '
        Me.dgv_listaPerros.AllowUserToAddRows = False
        Me.dgv_listaPerros.AllowUserToDeleteRows = False
        Me.dgv_listaPerros.AllowUserToResizeColumns = False
        Me.dgv_listaPerros.AllowUserToResizeRows = False
        Me.dgv_listaPerros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaPerros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nroHistoriaClinica, Me.col_idSucursal, Me.col_nombrePerro, Me.col_fechaNacimientoPerro, Me.col_idRaza, Me.col_idDueño, Me.col_peso, Me.col_altura})
        Me.dgv_listaPerros.Location = New System.Drawing.Point(14, 22)
        Me.dgv_listaPerros.MultiSelect = False
        Me.dgv_listaPerros.Name = "dgv_listaPerros"
        Me.dgv_listaPerros.RowHeadersVisible = False
        Me.dgv_listaPerros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaPerros.Size = New System.Drawing.Size(870, 152)
        Me.dgv_listaPerros.TabIndex = 0
        '
        'col_nroHistoriaClinica
        '
        Me.col_nroHistoriaClinica.HeaderText = "Número de Historia Clínica"
        Me.col_nroHistoriaClinica.Name = "col_nroHistoriaClinica"
        '
        'col_idSucursal
        '
        Me.col_idSucursal.HeaderText = "ID Sucursal"
        Me.col_idSucursal.Name = "col_idSucursal"
        '
        'col_nombrePerro
        '
        Me.col_nombrePerro.HeaderText = "Nombre"
        Me.col_nombrePerro.Name = "col_nombrePerro"
        '
        'col_fechaNacimientoPerro
        '
        Me.col_fechaNacimientoPerro.HeaderText = "Fecha de Nacimiento"
        Me.col_fechaNacimientoPerro.Name = "col_fechaNacimientoPerro"
        '
        'col_idRaza
        '
        Me.col_idRaza.HeaderText = "ID Raza"
        Me.col_idRaza.Name = "col_idRaza"
        '
        'col_idDueño
        '
        Me.col_idDueño.HeaderText = "ID Dueño"
        Me.col_idDueño.Name = "col_idDueño"
        '
        'col_peso
        '
        Me.col_peso.HeaderText = "Peso"
        Me.col_peso.Name = "col_peso"
        '
        'col_altura
        '
        Me.col_altura.HeaderText = "Altura"
        Me.col_altura.Name = "col_altura"
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_salir.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Location = New System.Drawing.Point(736, 399)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(44, 35)
        Me.btn_salir.TabIndex = 17
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_guardarPerro
        '
        Me.btn_guardarPerro.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardarPerro.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarPerro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardarPerro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarPerro.Location = New System.Drawing.Point(672, 399)
        Me.btn_guardarPerro.Name = "btn_guardarPerro"
        Me.btn_guardarPerro.Size = New System.Drawing.Size(48, 35)
        Me.btn_guardarPerro.TabIndex = 18
        Me.btn_guardarPerro.UseVisualStyleBackColor = False
        '
        'frm_cargaPerro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.registrar_perros
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(911, 441)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardarPerro)
        Me.Controls.Add(Me.gro_listaPerros)
        Me.Controls.Add(Me.gro_datosPerros)
        Me.Name = "frm_cargaPerro"
        Me.Text = ".:.Registrar Perros.:."
        Me.gro_datosPerros.ResumeLayout(False)
        Me.gro_datosPerros.PerformLayout()
        Me.gro_listaPerros.ResumeLayout(False)
        CType(Me.dgv_listaPerros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_nro_historiaClinica As System.Windows.Forms.Label
    Friend WithEvents lbl_idSucursal As System.Windows.Forms.Label
    Friend WithEvents lbl_nombrePerro As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaNacPerro As System.Windows.Forms.Label
    Friend WithEvents lbl_idRaza As System.Windows.Forms.Label
    Friend WithEvents lbl_pesoPerro As System.Windows.Forms.Label
    Friend WithEvents lbl_alturaPerro As System.Windows.Forms.Label
    Friend WithEvents lbl_idDueñoPerro As System.Windows.Forms.Label
    Friend WithEvents txt_nroHistoriaClinica As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombrePerro As System.Windows.Forms.TextBox
    Friend WithEvents txt_peso As System.Windows.Forms.TextBox
    Friend WithEvents txt_altura As System.Windows.Forms.TextBox
    Friend WithEvents cbo_idSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_idDueño As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_idRaza As System.Windows.Forms.ComboBox
    Friend WithEvents mkb_fechaNacimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents gro_datosPerros As System.Windows.Forms.GroupBox
    Friend WithEvents btn_agregarPerro As System.Windows.Forms.Button
    Friend WithEvents gro_listaPerros As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_listaPerros As System.Windows.Forms.DataGridView
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_guardarPerro As System.Windows.Forms.Button
    Friend WithEvents col_nroHistoriaClinica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombrePerro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaNacimientoPerro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idRaza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idDueño As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_peso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_altura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
