<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editarEmpleado
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre_buscar = New System.Windows.Forms.TextBox()
        Me.dgv_datosEmpleados = New System.Windows.Forms.DataGridView()
        Me.col_tipo_docEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_num_docEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombreEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellidoEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaNacEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaIngresoEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_matriculaEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sucursalEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbox_DatosEmpleados = New System.Windows.Forms.GroupBox()
        Me.btn_buscarEmpleado = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.grbox_buscarEmpleado = New System.Windows.Forms.GroupBox()
        Me.gro_datosEmpleadoEditar = New System.Windows.Forms.GroupBox()
        Me.cbo_sucursalEditar = New System.Windows.Forms.ComboBox()
        Me.btn_guardarCambios = New System.Windows.Forms.Button()
        Me.cbo_tipodocumentoEditar = New System.Windows.Forms.ComboBox()
        Me.mkb_fechaingresoEditar = New System.Windows.Forms.MaskedTextBox()
        Me.mkb_fechanacimientoEditar = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_nombreEditar = New System.Windows.Forms.Label()
        Me.lbl_apellidoEditar = New System.Windows.Forms.Label()
        Me.lbl_fechanacEditar = New System.Windows.Forms.Label()
        Me.lbl_fechaingEditar = New System.Windows.Forms.Label()
        Me.txt_nrodocumentoEditar = New System.Windows.Forms.TextBox()
        Me.lbl_matriculaEditar = New System.Windows.Forms.Label()
        Me.txt_nombreempleadoEditar = New System.Windows.Forms.TextBox()
        Me.lbl_sucursalEditar = New System.Windows.Forms.Label()
        Me.txt_apellidoempleadoEditar = New System.Windows.Forms.TextBox()
        Me.lbl_tipdocEditar = New System.Windows.Forms.Label()
        Me.txt_matriculaEditar = New System.Windows.Forms.TextBox()
        Me.lbl_numdocEditar = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        CType(Me.dgv_datosEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbox_DatosEmpleados.SuspendLayout()
        Me.grbox_buscarEmpleado.SuspendLayout()
        Me.gro_datosEmpleadoEditar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar:"
        '
        'txt_nombre_buscar
        '
        Me.txt_nombre_buscar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_buscar.Location = New System.Drawing.Point(87, 28)
        Me.txt_nombre_buscar.Name = "txt_nombre_buscar"
        Me.txt_nombre_buscar.Size = New System.Drawing.Size(181, 23)
        Me.txt_nombre_buscar.TabIndex = 1
        '
        'dgv_datosEmpleados
        '
        Me.dgv_datosEmpleados.AllowUserToAddRows = False
        Me.dgv_datosEmpleados.AllowUserToDeleteRows = False
        Me.dgv_datosEmpleados.AllowUserToResizeColumns = False
        Me.dgv_datosEmpleados.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_datosEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_datosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datosEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_tipo_docEditar, Me.col_num_docEditar, Me.col_nombreEditar, Me.col_apellidoEditar, Me.col_fechaNacEditar, Me.col_fechaIngresoEditar, Me.col_matriculaEditar, Me.col_sucursalEditar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_datosEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_datosEmpleados.GridColor = System.Drawing.SystemColors.Desktop
        Me.dgv_datosEmpleados.Location = New System.Drawing.Point(6, 19)
        Me.dgv_datosEmpleados.MultiSelect = False
        Me.dgv_datosEmpleados.Name = "dgv_datosEmpleados"
        Me.dgv_datosEmpleados.ReadOnly = True
        Me.dgv_datosEmpleados.RowHeadersVisible = False
        Me.dgv_datosEmpleados.RowHeadersWidth = 22
        Me.dgv_datosEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgv_datosEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_datosEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_datosEmpleados.Size = New System.Drawing.Size(849, 194)
        Me.dgv_datosEmpleados.TabIndex = 6
        '
        'col_tipo_docEditar
        '
        Me.col_tipo_docEditar.HeaderText = "Tipo Documento"
        Me.col_tipo_docEditar.Name = "col_tipo_docEditar"
        Me.col_tipo_docEditar.ReadOnly = True
        Me.col_tipo_docEditar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_tipo_docEditar.Width = 129
        '
        'col_num_docEditar
        '
        Me.col_num_docEditar.HeaderText = "Numero Documento"
        Me.col_num_docEditar.Name = "col_num_docEditar"
        Me.col_num_docEditar.ReadOnly = True
        '
        'col_nombreEditar
        '
        Me.col_nombreEditar.HeaderText = "Nombre"
        Me.col_nombreEditar.Name = "col_nombreEditar"
        Me.col_nombreEditar.ReadOnly = True
        '
        'col_apellidoEditar
        '
        Me.col_apellidoEditar.HeaderText = "Apellido"
        Me.col_apellidoEditar.Name = "col_apellidoEditar"
        Me.col_apellidoEditar.ReadOnly = True
        '
        'col_fechaNacEditar
        '
        Me.col_fechaNacEditar.HeaderText = "Fecha Nacimiento"
        Me.col_fechaNacEditar.Name = "col_fechaNacEditar"
        Me.col_fechaNacEditar.ReadOnly = True
        '
        'col_fechaIngresoEditar
        '
        Me.col_fechaIngresoEditar.HeaderText = "Fecha de Ingreso"
        Me.col_fechaIngresoEditar.Name = "col_fechaIngresoEditar"
        Me.col_fechaIngresoEditar.ReadOnly = True
        '
        'col_matriculaEditar
        '
        Me.col_matriculaEditar.HeaderText = "Matricula"
        Me.col_matriculaEditar.Name = "col_matriculaEditar"
        Me.col_matriculaEditar.ReadOnly = True
        '
        'col_sucursalEditar
        '
        Me.col_sucursalEditar.HeaderText = "Sucursal"
        Me.col_sucursalEditar.Name = "col_sucursalEditar"
        Me.col_sucursalEditar.ReadOnly = True
        Me.col_sucursalEditar.Width = 83
        '
        'grbox_DatosEmpleados
        '
        Me.grbox_DatosEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.grbox_DatosEmpleados.Controls.Add(Me.dgv_datosEmpleados)
        Me.grbox_DatosEmpleados.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbox_DatosEmpleados.ForeColor = System.Drawing.Color.White
        Me.grbox_DatosEmpleados.Location = New System.Drawing.Point(12, 209)
        Me.grbox_DatosEmpleados.Name = "grbox_DatosEmpleados"
        Me.grbox_DatosEmpleados.Size = New System.Drawing.Size(861, 219)
        Me.grbox_DatosEmpleados.TabIndex = 7
        Me.grbox_DatosEmpleados.TabStop = False
        Me.grbox_DatosEmpleados.Text = "Lista de Empleados"
        '
        'btn_buscarEmpleado
        '
        Me.btn_buscarEmpleado.BackgroundImage = Global.Veterinaria.My.Resources.Resources.find
        Me.btn_buscarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_buscarEmpleado.Enabled = False
        Me.btn_buscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarEmpleado.ForeColor = System.Drawing.Color.Black
        Me.btn_buscarEmpleado.Location = New System.Drawing.Point(716, 18)
        Me.btn_buscarEmpleado.Name = "btn_buscarEmpleado"
        Me.btn_buscarEmpleado.Size = New System.Drawing.Size(40, 33)
        Me.btn_buscarEmpleado.TabIndex = 2
        Me.btn_buscarEmpleado.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_salir.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.ForeColor = System.Drawing.Color.Black
        Me.btn_salir.Location = New System.Drawing.Point(781, 428)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(41, 33)
        Me.btn_salir.TabIndex = 13
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'grbox_buscarEmpleado
        '
        Me.grbox_buscarEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.grbox_buscarEmpleado.Controls.Add(Me.btn_buscarEmpleado)
        Me.grbox_buscarEmpleado.Controls.Add(Me.Label1)
        Me.grbox_buscarEmpleado.Controls.Add(Me.txt_nombre_buscar)
        Me.grbox_buscarEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbox_buscarEmpleado.ForeColor = System.Drawing.Color.White
        Me.grbox_buscarEmpleado.Location = New System.Drawing.Point(12, 38)
        Me.grbox_buscarEmpleado.Name = "grbox_buscarEmpleado"
        Me.grbox_buscarEmpleado.Size = New System.Drawing.Size(861, 59)
        Me.grbox_buscarEmpleado.TabIndex = 10
        Me.grbox_buscarEmpleado.TabStop = False
        Me.grbox_buscarEmpleado.Text = "Buscar Empleado"
        '
        'gro_datosEmpleadoEditar
        '
        Me.gro_datosEmpleadoEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.cbo_sucursalEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.btn_guardarCambios)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.cbo_tipodocumentoEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.mkb_fechaingresoEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.mkb_fechanacimientoEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.lbl_nombreEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.lbl_apellidoEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.lbl_fechanacEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.lbl_fechaingEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.txt_nrodocumentoEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.lbl_matriculaEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.txt_nombreempleadoEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.lbl_sucursalEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.txt_apellidoempleadoEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.lbl_tipdocEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.txt_matriculaEditar)
        Me.gro_datosEmpleadoEditar.Controls.Add(Me.lbl_numdocEditar)
        Me.gro_datosEmpleadoEditar.Enabled = False
        Me.gro_datosEmpleadoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosEmpleadoEditar.ForeColor = System.Drawing.Color.White
        Me.gro_datosEmpleadoEditar.Location = New System.Drawing.Point(12, 103)
        Me.gro_datosEmpleadoEditar.Name = "gro_datosEmpleadoEditar"
        Me.gro_datosEmpleadoEditar.Size = New System.Drawing.Size(861, 100)
        Me.gro_datosEmpleadoEditar.TabIndex = 11
        Me.gro_datosEmpleadoEditar.TabStop = False
        Me.gro_datosEmpleadoEditar.Text = "Datos Empleado"
        '
        'cbo_sucursalEditar
        '
        Me.cbo_sucursalEditar.Enabled = False
        Me.cbo_sucursalEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_sucursalEditar.FormattingEnabled = True
        Me.cbo_sucursalEditar.Location = New System.Drawing.Point(428, 71)
        Me.cbo_sucursalEditar.Name = "cbo_sucursalEditar"
        Me.cbo_sucursalEditar.Size = New System.Drawing.Size(121, 24)
        Me.cbo_sucursalEditar.TabIndex = 8
        '
        'btn_guardarCambios
        '
        Me.btn_guardarCambios.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarCambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardarCambios.Enabled = False
        Me.btn_guardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarCambios.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardarCambios.ForeColor = System.Drawing.Color.Black
        Me.btn_guardarCambios.Location = New System.Drawing.Point(777, 70)
        Me.btn_guardarCambios.Name = "btn_guardarCambios"
        Me.btn_guardarCambios.Size = New System.Drawing.Size(33, 26)
        Me.btn_guardarCambios.TabIndex = 11
        Me.btn_guardarCambios.UseVisualStyleBackColor = True
        '
        'cbo_tipodocumentoEditar
        '
        Me.cbo_tipodocumentoEditar.Enabled = False
        Me.cbo_tipodocumentoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipodocumentoEditar.FormattingEnabled = True
        Me.cbo_tipodocumentoEditar.Items.AddRange(New Object() {"DNI", "L.E"})
        Me.cbo_tipodocumentoEditar.Location = New System.Drawing.Point(129, 71)
        Me.cbo_tipodocumentoEditar.Name = "cbo_tipodocumentoEditar"
        Me.cbo_tipodocumentoEditar.Size = New System.Drawing.Size(121, 24)
        Me.cbo_tipodocumentoEditar.TabIndex = 5
        '
        'mkb_fechaingresoEditar
        '
        Me.mkb_fechaingresoEditar.Enabled = False
        Me.mkb_fechaingresoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkb_fechaingresoEditar.Location = New System.Drawing.Point(705, 41)
        Me.mkb_fechaingresoEditar.Mask = "00/00/0000"
        Me.mkb_fechaingresoEditar.Name = "mkb_fechaingresoEditar"
        Me.mkb_fechaingresoEditar.Size = New System.Drawing.Size(105, 23)
        Me.mkb_fechaingresoEditar.TabIndex = 10
        Me.mkb_fechaingresoEditar.ValidatingType = GetType(Date)
        '
        'mkb_fechanacimientoEditar
        '
        Me.mkb_fechanacimientoEditar.Enabled = False
        Me.mkb_fechanacimientoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkb_fechanacimientoEditar.Location = New System.Drawing.Point(705, 16)
        Me.mkb_fechanacimientoEditar.Mask = "00/00/0000"
        Me.mkb_fechanacimientoEditar.Name = "mkb_fechanacimientoEditar"
        Me.mkb_fechanacimientoEditar.Size = New System.Drawing.Size(105, 23)
        Me.mkb_fechanacimientoEditar.TabIndex = 9
        Me.mkb_fechanacimientoEditar.ValidatingType = GetType(Date)
        '
        'lbl_nombreEditar
        '
        Me.lbl_nombreEditar.AutoSize = True
        Me.lbl_nombreEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombreEditar.ForeColor = System.Drawing.Color.White
        Me.lbl_nombreEditar.Location = New System.Drawing.Point(58, 26)
        Me.lbl_nombreEditar.Name = "lbl_nombreEditar"
        Me.lbl_nombreEditar.Size = New System.Drawing.Size(65, 16)
        Me.lbl_nombreEditar.TabIndex = 23
        Me.lbl_nombreEditar.Text = "Nombre:"
        '
        'lbl_apellidoEditar
        '
        Me.lbl_apellidoEditar.AutoSize = True
        Me.lbl_apellidoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellidoEditar.ForeColor = System.Drawing.Color.White
        Me.lbl_apellidoEditar.Location = New System.Drawing.Point(57, 52)
        Me.lbl_apellidoEditar.Name = "lbl_apellidoEditar"
        Me.lbl_apellidoEditar.Size = New System.Drawing.Size(66, 16)
        Me.lbl_apellidoEditar.TabIndex = 24
        Me.lbl_apellidoEditar.Text = "Apellido:"
        '
        'lbl_fechanacEditar
        '
        Me.lbl_fechanacEditar.AutoSize = True
        Me.lbl_fechanacEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechanacEditar.ForeColor = System.Drawing.Color.White
        Me.lbl_fechanacEditar.Location = New System.Drawing.Point(555, 23)
        Me.lbl_fechanacEditar.Name = "lbl_fechanacEditar"
        Me.lbl_fechanacEditar.Size = New System.Drawing.Size(150, 16)
        Me.lbl_fechanacEditar.TabIndex = 25
        Me.lbl_fechanacEditar.Text = "Fecha de nacimiento:"
        '
        'lbl_fechaingEditar
        '
        Me.lbl_fechaingEditar.AutoSize = True
        Me.lbl_fechaingEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaingEditar.ForeColor = System.Drawing.Color.White
        Me.lbl_fechaingEditar.Location = New System.Drawing.Point(583, 48)
        Me.lbl_fechaingEditar.Name = "lbl_fechaingEditar"
        Me.lbl_fechaingEditar.Size = New System.Drawing.Size(122, 16)
        Me.lbl_fechaingEditar.TabIndex = 26
        Me.lbl_fechaingEditar.Text = "Fecha de ingreso:"
        '
        'txt_nrodocumentoEditar
        '
        Me.txt_nrodocumentoEditar.Enabled = False
        Me.txt_nrodocumentoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nrodocumentoEditar.Location = New System.Drawing.Point(428, 19)
        Me.txt_nrodocumentoEditar.MaxLength = 8
        Me.txt_nrodocumentoEditar.Name = "txt_nrodocumentoEditar"
        Me.txt_nrodocumentoEditar.Size = New System.Drawing.Size(121, 23)
        Me.txt_nrodocumentoEditar.TabIndex = 6
        '
        'lbl_matriculaEditar
        '
        Me.lbl_matriculaEditar.AutoSize = True
        Me.lbl_matriculaEditar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_matriculaEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matriculaEditar.ForeColor = System.Drawing.Color.White
        Me.lbl_matriculaEditar.Location = New System.Drawing.Point(348, 48)
        Me.lbl_matriculaEditar.Name = "lbl_matriculaEditar"
        Me.lbl_matriculaEditar.Size = New System.Drawing.Size(74, 16)
        Me.lbl_matriculaEditar.TabIndex = 27
        Me.lbl_matriculaEditar.Text = "Matricula:"
        '
        'txt_nombreempleadoEditar
        '
        Me.txt_nombreempleadoEditar.Enabled = False
        Me.txt_nombreempleadoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombreempleadoEditar.Location = New System.Drawing.Point(129, 19)
        Me.txt_nombreempleadoEditar.MaxLength = 40
        Me.txt_nombreempleadoEditar.Name = "txt_nombreempleadoEditar"
        Me.txt_nombreempleadoEditar.Size = New System.Drawing.Size(121, 23)
        Me.txt_nombreempleadoEditar.TabIndex = 3
        '
        'lbl_sucursalEditar
        '
        Me.lbl_sucursalEditar.AutoSize = True
        Me.lbl_sucursalEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sucursalEditar.ForeColor = System.Drawing.Color.White
        Me.lbl_sucursalEditar.Location = New System.Drawing.Point(359, 74)
        Me.lbl_sucursalEditar.Name = "lbl_sucursalEditar"
        Me.lbl_sucursalEditar.Size = New System.Drawing.Size(63, 16)
        Me.lbl_sucursalEditar.TabIndex = 28
        Me.lbl_sucursalEditar.Text = "Sucursal:"
        '
        'txt_apellidoempleadoEditar
        '
        Me.txt_apellidoempleadoEditar.Enabled = False
        Me.txt_apellidoempleadoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellidoempleadoEditar.Location = New System.Drawing.Point(129, 45)
        Me.txt_apellidoempleadoEditar.MaxLength = 40
        Me.txt_apellidoempleadoEditar.Name = "txt_apellidoempleadoEditar"
        Me.txt_apellidoempleadoEditar.Size = New System.Drawing.Size(121, 23)
        Me.txt_apellidoempleadoEditar.TabIndex = 4
        '
        'lbl_tipdocEditar
        '
        Me.lbl_tipdocEditar.AutoSize = True
        Me.lbl_tipdocEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipdocEditar.ForeColor = System.Drawing.Color.White
        Me.lbl_tipdocEditar.Location = New System.Drawing.Point(4, 77)
        Me.lbl_tipdocEditar.Name = "lbl_tipdocEditar"
        Me.lbl_tipdocEditar.Size = New System.Drawing.Size(119, 16)
        Me.lbl_tipdocEditar.TabIndex = 29
        Me.lbl_tipdocEditar.Text = "Tipo documento:"
        '
        'txt_matriculaEditar
        '
        Me.txt_matriculaEditar.Enabled = False
        Me.txt_matriculaEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matriculaEditar.Location = New System.Drawing.Point(428, 45)
        Me.txt_matriculaEditar.MaxLength = 6
        Me.txt_matriculaEditar.Name = "txt_matriculaEditar"
        Me.txt_matriculaEditar.Size = New System.Drawing.Size(121, 23)
        Me.txt_matriculaEditar.TabIndex = 7
        '
        'lbl_numdocEditar
        '
        Me.lbl_numdocEditar.AutoSize = True
        Me.lbl_numdocEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numdocEditar.ForeColor = System.Drawing.Color.White
        Me.lbl_numdocEditar.Location = New System.Drawing.Point(256, 22)
        Me.lbl_numdocEditar.Name = "lbl_numdocEditar"
        Me.lbl_numdocEditar.Size = New System.Drawing.Size(166, 16)
        Me.lbl_numdocEditar.TabIndex = 30
        Me.lbl_numdocEditar.Text = "Numero de documento:"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Iconshock_Vista_General_Trash
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Location = New System.Drawing.Point(700, 428)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 33)
        Me.btn_eliminar.TabIndex = 12
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'frm_editarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Editar_empleado
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 469)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.gro_datosEmpleadoEditar)
        Me.Controls.Add(Me.grbox_buscarEmpleado)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.grbox_DatosEmpleados)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_editarEmpleado"
        Me.Text = ".:. Editar empleados .:."
        CType(Me.dgv_datosEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbox_DatosEmpleados.ResumeLayout(False)
        Me.grbox_buscarEmpleado.ResumeLayout(False)
        Me.grbox_buscarEmpleado.PerformLayout()
        Me.gro_datosEmpleadoEditar.ResumeLayout(False)
        Me.gro_datosEmpleadoEditar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_buscar As System.Windows.Forms.TextBox
    Friend WithEvents dgv_datosEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents grbox_DatosEmpleados As System.Windows.Forms.GroupBox
    Friend WithEvents btn_buscarEmpleado As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents grbox_buscarEmpleado As System.Windows.Forms.GroupBox
    Friend WithEvents gro_datosEmpleadoEditar As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_sucursalEditar As System.Windows.Forms.ComboBox
    Friend WithEvents btn_guardarCambios As System.Windows.Forms.Button
    Friend WithEvents cbo_tipodocumentoEditar As System.Windows.Forms.ComboBox
    Friend WithEvents mkb_fechaingresoEditar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkb_fechanacimientoEditar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_nombreEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_apellidoEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_fechanacEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaingEditar As System.Windows.Forms.Label
    Friend WithEvents txt_nrodocumentoEditar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_matriculaEditar As System.Windows.Forms.Label
    Friend WithEvents txt_nombreempleadoEditar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_sucursalEditar As System.Windows.Forms.Label
    Friend WithEvents txt_apellidoempleadoEditar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tipdocEditar As System.Windows.Forms.Label
    Friend WithEvents txt_matriculaEditar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_numdocEditar As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents col_tipo_docEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_num_docEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombreEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_apellidoEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaNacEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaIngresoEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_matriculaEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_sucursalEditar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
