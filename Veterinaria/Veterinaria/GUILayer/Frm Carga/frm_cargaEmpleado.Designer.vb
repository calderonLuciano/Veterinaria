<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cargaEmpleado
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
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        Me.txt_apellidoempleado = New System.Windows.Forms.TextBox()
        Me.txt_nombreempleado = New System.Windows.Forms.TextBox()
        Me.txt_nrodocumento = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.grb_datosempleado = New System.Windows.Forms.GroupBox()
        Me.cbo_sucursal = New System.Windows.Forms.ComboBox()
        Me.lbl_fechaNacEmpleado = New System.Windows.Forms.Label()
        Me.lbl_fechaIngresoEmpleado = New System.Windows.Forms.Label()
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.lbl_matriculaEmpleado = New System.Windows.Forms.Label()
        Me.lbl_nroDocEmpleado = New System.Windows.Forms.Label()
        Me.lbl_tpoDocEmpleado = New System.Windows.Forms.Label()
        Me.lbl_apellidoEmpleado = New System.Windows.Forms.Label()
        Me.lbl_nombreEmpleado = New System.Windows.Forms.Label()
        Me.mkb_fechaIngreso = New System.Windows.Forms.MaskedTextBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.cbo_tipodocumento = New System.Windows.Forms.ComboBox()
        Me.mkb_fechaNac = New System.Windows.Forms.MaskedTextBox()
        Me.grb_listaempleados = New System.Windows.Forms.GroupBox()
        Me.dgv_cargarEmpleado = New System.Windows.Forms.DataGridView()
        Me.col_tipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.grb_datosempleado.SuspendLayout()
        Me.grb_listaempleados.SuspendLayout()
        CType(Me.dgv_cargarEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_matricula
        '
        Me.txt_matricula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_matricula.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matricula.Location = New System.Drawing.Point(454, 69)
        Me.txt_matricula.MaxLength = 6
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(121, 16)
        Me.txt_matricula.TabIndex = 5
        '
        'txt_apellidoempleado
        '
        Me.txt_apellidoempleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellidoempleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellidoempleado.Location = New System.Drawing.Point(153, 73)
        Me.txt_apellidoempleado.MaxLength = 40
        Me.txt_apellidoempleado.Name = "txt_apellidoempleado"
        Me.txt_apellidoempleado.Size = New System.Drawing.Size(121, 16)
        Me.txt_apellidoempleado.TabIndex = 2
        '
        'txt_nombreempleado
        '
        Me.txt_nombreempleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombreempleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombreempleado.Location = New System.Drawing.Point(153, 47)
        Me.txt_nombreempleado.MaxLength = 50
        Me.txt_nombreempleado.Name = "txt_nombreempleado"
        Me.txt_nombreempleado.Size = New System.Drawing.Size(121, 16)
        Me.txt_nombreempleado.TabIndex = 1
        '
        'txt_nrodocumento
        '
        Me.txt_nrodocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nrodocumento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nrodocumento.Location = New System.Drawing.Point(454, 47)
        Me.txt_nrodocumento.MaxLength = 8
        Me.txt_nrodocumento.Name = "txt_nrodocumento"
        Me.txt_nrodocumento.Size = New System.Drawing.Size(121, 16)
        Me.txt_nrodocumento.TabIndex = 4
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.Image = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_cancelar.Location = New System.Drawing.Point(746, 383)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(35, 23)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'grb_datosempleado
        '
        Me.grb_datosempleado.BackColor = System.Drawing.Color.Transparent
        Me.grb_datosempleado.Controls.Add(Me.cbo_sucursal)
        Me.grb_datosempleado.Controls.Add(Me.lbl_fechaNacEmpleado)
        Me.grb_datosempleado.Controls.Add(Me.lbl_fechaIngresoEmpleado)
        Me.grb_datosempleado.Controls.Add(Me.lbl_sucursal)
        Me.grb_datosempleado.Controls.Add(Me.lbl_matriculaEmpleado)
        Me.grb_datosempleado.Controls.Add(Me.lbl_nroDocEmpleado)
        Me.grb_datosempleado.Controls.Add(Me.lbl_tpoDocEmpleado)
        Me.grb_datosempleado.Controls.Add(Me.lbl_apellidoEmpleado)
        Me.grb_datosempleado.Controls.Add(Me.lbl_nombreEmpleado)
        Me.grb_datosempleado.Controls.Add(Me.mkb_fechaIngreso)
        Me.grb_datosempleado.Controls.Add(Me.btn_agregar)
        Me.grb_datosempleado.Controls.Add(Me.cbo_tipodocumento)
        Me.grb_datosempleado.Controls.Add(Me.mkb_fechaNac)
        Me.grb_datosempleado.Controls.Add(Me.txt_nrodocumento)
        Me.grb_datosempleado.Controls.Add(Me.txt_nombreempleado)
        Me.grb_datosempleado.Controls.Add(Me.txt_apellidoempleado)
        Me.grb_datosempleado.Controls.Add(Me.txt_matricula)
        Me.grb_datosempleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_datosempleado.ForeColor = System.Drawing.Color.White
        Me.grb_datosempleado.Location = New System.Drawing.Point(5, 32)
        Me.grb_datosempleado.Name = "grb_datosempleado"
        Me.grb_datosempleado.Size = New System.Drawing.Size(821, 129)
        Me.grb_datosempleado.TabIndex = 20
        Me.grb_datosempleado.TabStop = False
        Me.grb_datosempleado.Text = "Datos Empleado"
        '
        'cbo_sucursal
        '
        Me.cbo_sucursal.FormattingEnabled = True
        Me.cbo_sucursal.Location = New System.Drawing.Point(453, 92)
        Me.cbo_sucursal.Name = "cbo_sucursal"
        Me.cbo_sucursal.Size = New System.Drawing.Size(121, 24)
        Me.cbo_sucursal.TabIndex = 23
        '
        'lbl_fechaNacEmpleado
        '
        Me.lbl_fechaNacEmpleado.AutoSize = True
        Me.lbl_fechaNacEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaNacEmpleado.ForeColor = System.Drawing.Color.White
        Me.lbl_fechaNacEmpleado.Location = New System.Drawing.Point(581, 47)
        Me.lbl_fechaNacEmpleado.Name = "lbl_fechaNacEmpleado"
        Me.lbl_fechaNacEmpleado.Size = New System.Drawing.Size(152, 16)
        Me.lbl_fechaNacEmpleado.TabIndex = 22
        Me.lbl_fechaNacEmpleado.Text = "Fecha de Nacimiento:"
        '
        'lbl_fechaIngresoEmpleado
        '
        Me.lbl_fechaIngresoEmpleado.AutoSize = True
        Me.lbl_fechaIngresoEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaIngresoEmpleado.ForeColor = System.Drawing.Color.White
        Me.lbl_fechaIngresoEmpleado.Location = New System.Drawing.Point(611, 73)
        Me.lbl_fechaIngresoEmpleado.Name = "lbl_fechaIngresoEmpleado"
        Me.lbl_fechaIngresoEmpleado.Size = New System.Drawing.Size(122, 16)
        Me.lbl_fechaIngresoEmpleado.TabIndex = 21
        Me.lbl_fechaIngresoEmpleado.Text = "Fecha de Ingreso:"
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sucursal.ForeColor = System.Drawing.Color.White
        Me.lbl_sucursal.Location = New System.Drawing.Point(383, 98)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(63, 16)
        Me.lbl_sucursal.TabIndex = 19
        Me.lbl_sucursal.Text = "Sucursal:"
        '
        'lbl_matriculaEmpleado
        '
        Me.lbl_matriculaEmpleado.AutoSize = True
        Me.lbl_matriculaEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matriculaEmpleado.ForeColor = System.Drawing.Color.White
        Me.lbl_matriculaEmpleado.Location = New System.Drawing.Point(374, 69)
        Me.lbl_matriculaEmpleado.Name = "lbl_matriculaEmpleado"
        Me.lbl_matriculaEmpleado.Size = New System.Drawing.Size(74, 16)
        Me.lbl_matriculaEmpleado.TabIndex = 18
        Me.lbl_matriculaEmpleado.Text = "Matricula:"
        '
        'lbl_nroDocEmpleado
        '
        Me.lbl_nroDocEmpleado.AutoSize = True
        Me.lbl_nroDocEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nroDocEmpleado.ForeColor = System.Drawing.Color.White
        Me.lbl_nroDocEmpleado.Location = New System.Drawing.Point(281, 47)
        Me.lbl_nroDocEmpleado.Name = "lbl_nroDocEmpleado"
        Me.lbl_nroDocEmpleado.Size = New System.Drawing.Size(167, 16)
        Me.lbl_nroDocEmpleado.TabIndex = 17
        Me.lbl_nroDocEmpleado.Text = "Número de Documento:"
        '
        'lbl_tpoDocEmpleado
        '
        Me.lbl_tpoDocEmpleado.AutoSize = True
        Me.lbl_tpoDocEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tpoDocEmpleado.ForeColor = System.Drawing.Color.White
        Me.lbl_tpoDocEmpleado.Location = New System.Drawing.Point(7, 95)
        Me.lbl_tpoDocEmpleado.Name = "lbl_tpoDocEmpleado"
        Me.lbl_tpoDocEmpleado.Size = New System.Drawing.Size(141, 16)
        Me.lbl_tpoDocEmpleado.TabIndex = 12
        Me.lbl_tpoDocEmpleado.Text = "Tipo de Documento:"
        '
        'lbl_apellidoEmpleado
        '
        Me.lbl_apellidoEmpleado.AutoSize = True
        Me.lbl_apellidoEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellidoEmpleado.ForeColor = System.Drawing.Color.White
        Me.lbl_apellidoEmpleado.Location = New System.Drawing.Point(82, 76)
        Me.lbl_apellidoEmpleado.Name = "lbl_apellidoEmpleado"
        Me.lbl_apellidoEmpleado.Size = New System.Drawing.Size(66, 16)
        Me.lbl_apellidoEmpleado.TabIndex = 11
        Me.lbl_apellidoEmpleado.Text = "Apellido:"
        '
        'lbl_nombreEmpleado
        '
        Me.lbl_nombreEmpleado.AutoSize = True
        Me.lbl_nombreEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombreEmpleado.ForeColor = System.Drawing.Color.White
        Me.lbl_nombreEmpleado.Location = New System.Drawing.Point(83, 47)
        Me.lbl_nombreEmpleado.Name = "lbl_nombreEmpleado"
        Me.lbl_nombreEmpleado.Size = New System.Drawing.Size(65, 16)
        Me.lbl_nombreEmpleado.TabIndex = 10
        Me.lbl_nombreEmpleado.Text = "Nombre:"
        '
        'mkb_fechaIngreso
        '
        Me.mkb_fechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mkb_fechaIngreso.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkb_fechaIngreso.Location = New System.Drawing.Point(731, 73)
        Me.mkb_fechaIngreso.Mask = "00/00/0000"
        Me.mkb_fechaIngreso.Name = "mkb_fechaIngreso"
        Me.mkb_fechaIngreso.Size = New System.Drawing.Size(80, 16)
        Me.mkb_fechaIngreso.TabIndex = 8
        '
        'btn_agregar
        '
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar.Image = Global.Veterinaria.My.Resources.Resources.add
        Me.btn_agregar.Location = New System.Drawing.Point(741, 100)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(37, 23)
        Me.btn_agregar.TabIndex = 9
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'cbo_tipodocumento
        '
        Me.cbo_tipodocumento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipodocumento.FormattingEnabled = True
        Me.cbo_tipodocumento.Items.AddRange(New Object() {"DNI", "L.E"})
        Me.cbo_tipodocumento.Location = New System.Drawing.Point(153, 95)
        Me.cbo_tipodocumento.Name = "cbo_tipodocumento"
        Me.cbo_tipodocumento.Size = New System.Drawing.Size(121, 24)
        Me.cbo_tipodocumento.TabIndex = 3
        '
        'mkb_fechaNac
        '
        Me.mkb_fechaNac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mkb_fechaNac.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkb_fechaNac.Location = New System.Drawing.Point(731, 47)
        Me.mkb_fechaNac.Margin = New System.Windows.Forms.Padding(2)
        Me.mkb_fechaNac.Mask = "00/00/0000"
        Me.mkb_fechaNac.Name = "mkb_fechaNac"
        Me.mkb_fechaNac.Size = New System.Drawing.Size(80, 16)
        Me.mkb_fechaNac.TabIndex = 7
        '
        'grb_listaempleados
        '
        Me.grb_listaempleados.BackColor = System.Drawing.Color.Transparent
        Me.grb_listaempleados.Controls.Add(Me.dgv_cargarEmpleado)
        Me.grb_listaempleados.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_listaempleados.ForeColor = System.Drawing.Color.White
        Me.grb_listaempleados.Location = New System.Drawing.Point(5, 161)
        Me.grb_listaempleados.Name = "grb_listaempleados"
        Me.grb_listaempleados.Size = New System.Drawing.Size(821, 219)
        Me.grb_listaempleados.TabIndex = 21
        Me.grb_listaempleados.TabStop = False
        Me.grb_listaempleados.Text = "Lista de Empleados"
        '
        'dgv_cargarEmpleado
        '
        Me.dgv_cargarEmpleado.AllowUserToAddRows = False
        Me.dgv_cargarEmpleado.AllowUserToDeleteRows = False
        Me.dgv_cargarEmpleado.AllowUserToResizeColumns = False
        Me.dgv_cargarEmpleado.AllowUserToResizeRows = False
        Me.dgv_cargarEmpleado.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_cargarEmpleado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_cargarEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cargarEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_tipoDoc, Me.col_nroDoc, Me.col_nombre, Me.col_apellido, Me.col_fechaNacimiento, Me.col_fechaIngreso, Me.col_matricula, Me.col_sucursal})
        Me.dgv_cargarEmpleado.Location = New System.Drawing.Point(25, 32)
        Me.dgv_cargarEmpleado.MultiSelect = False
        Me.dgv_cargarEmpleado.Name = "dgv_cargarEmpleado"
        Me.dgv_cargarEmpleado.ReadOnly = True
        Me.dgv_cargarEmpleado.RowHeadersVisible = False
        Me.dgv_cargarEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cargarEmpleado.Size = New System.Drawing.Size(786, 169)
        Me.dgv_cargarEmpleado.TabIndex = 0
        '
        'col_tipoDoc
        '
        Me.col_tipoDoc.HeaderText = "Tipo Documento"
        Me.col_tipoDoc.Name = "col_tipoDoc"
        Me.col_tipoDoc.ReadOnly = True
        Me.col_tipoDoc.Width = 73
        '
        'col_nroDoc
        '
        Me.col_nroDoc.HeaderText = "Numero de Documento"
        Me.col_nroDoc.Name = "col_nroDoc"
        Me.col_nroDoc.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        Me.col_apellido.ReadOnly = True
        '
        'col_fechaNacimiento
        '
        Me.col_fechaNacimiento.HeaderText = "Fecha de Nacimiento"
        Me.col_fechaNacimiento.Name = "col_fechaNacimiento"
        Me.col_fechaNacimiento.ReadOnly = True
        '
        'col_fechaIngreso
        '
        Me.col_fechaIngreso.HeaderText = "Fecha de Ingreso"
        Me.col_fechaIngreso.Name = "col_fechaIngreso"
        Me.col_fechaIngreso.ReadOnly = True
        '
        'col_matricula
        '
        Me.col_matricula.HeaderText = "Matricula"
        Me.col_matricula.Name = "col_matricula"
        Me.col_matricula.ReadOnly = True
        Me.col_matricula.Width = 110
        '
        'col_sucursal
        '
        Me.col_sucursal.HeaderText = "Sucursal"
        Me.col_sucursal.Name = "col_sucursal"
        Me.col_sucursal.ReadOnly = True
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Image = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardar.Location = New System.Drawing.Point(672, 379)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(33, 31)
        Me.btn_guardar.TabIndex = 10
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'frm_cargaEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Registrar_empleado
        Me.ClientSize = New System.Drawing.Size(832, 414)
        Me.Controls.Add(Me.grb_listaempleados)
        Me.Controls.Add(Me.grb_datosempleado)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cargaEmpleado"
        Me.Text = ".:. Registrar Empleado .:."
        Me.grb_datosempleado.ResumeLayout(False)
        Me.grb_datosempleado.PerformLayout()
        Me.grb_listaempleados.ResumeLayout(False)
        CType(Me.dgv_cargarEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_matricula As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellidoempleado As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombreempleado As System.Windows.Forms.TextBox
    Friend WithEvents txt_nrodocumento As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents grb_listaempleados As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_tipodocumento As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_cargarEmpleado As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents mkb_fechaIngreso As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkb_fechaNac As System.Windows.Forms.MaskedTextBox
    Friend WithEvents col_tipoDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaNacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaIngreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_matricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grb_datosempleado As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_sucursal As System.Windows.Forms.Label
    Friend WithEvents lbl_matriculaEmpleado As System.Windows.Forms.Label
    Friend WithEvents lbl_nroDocEmpleado As System.Windows.Forms.Label
    Friend WithEvents lbl_tpoDocEmpleado As System.Windows.Forms.Label
    Friend WithEvents lbl_apellidoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lbl_nombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaNacEmpleado As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaIngresoEmpleado As System.Windows.Forms.Label
    Friend WithEvents cbo_sucursal As System.Windows.Forms.ComboBox
End Class
