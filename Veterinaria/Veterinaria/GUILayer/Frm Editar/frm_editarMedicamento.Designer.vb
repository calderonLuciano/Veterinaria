<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editarMedicamento
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
        Me.gro_buscarMedicamento = New System.Windows.Forms.GroupBox()
        Me.btn_buscarMedicamento = New System.Windows.Forms.Button()
        Me.txt_buscarMedicamento = New System.Windows.Forms.TextBox()
        Me.lbl_idBuscarMedicamento = New System.Windows.Forms.Label()
        Me.gro_datosMedicamentosEditar = New System.Windows.Forms.GroupBox()
        Me.mkb_fechaUltCompraEditar = New System.Windows.Forms.MaskedTextBox()
        Me.btn_guardarMedicamentoEditar = New System.Windows.Forms.Button()
        Me.cbo_idLaboratorioEditar = New System.Windows.Forms.ComboBox()
        Me.txt_descripcionEditar = New System.Windows.Forms.TextBox()
        Me.txt_idMedicamentoEditar = New System.Windows.Forms.TextBox()
        Me.lbl_fechaUltCompraEditar = New System.Windows.Forms.Label()
        Me.id_laboratorioEditar = New System.Windows.Forms.Label()
        Me.lbl_DescripcionEditar = New System.Windows.Forms.Label()
        Me.lbl_idMedicamentoEditar = New System.Windows.Forms.Label()
        Me.dgv_editarMedicamentos = New System.Windows.Forms.DataGridView()
        Me.col_idMedicamentoEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcionEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idLaboratorioEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaUltCompraEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_eliminarMedicamento = New System.Windows.Forms.Button()
        Me.btn_salirEditar = New System.Windows.Forms.Button()
        Me.gro_buscarMedicamento.SuspendLayout()
        Me.gro_datosMedicamentosEditar.SuspendLayout()
        CType(Me.dgv_editarMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gro_buscarMedicamento
        '
        Me.gro_buscarMedicamento.BackColor = System.Drawing.Color.Transparent
        Me.gro_buscarMedicamento.Controls.Add(Me.btn_buscarMedicamento)
        Me.gro_buscarMedicamento.Controls.Add(Me.txt_buscarMedicamento)
        Me.gro_buscarMedicamento.Controls.Add(Me.lbl_idBuscarMedicamento)
        Me.gro_buscarMedicamento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_buscarMedicamento.ForeColor = System.Drawing.Color.White
        Me.gro_buscarMedicamento.Location = New System.Drawing.Point(9, 42)
        Me.gro_buscarMedicamento.Name = "gro_buscarMedicamento"
        Me.gro_buscarMedicamento.Size = New System.Drawing.Size(462, 56)
        Me.gro_buscarMedicamento.TabIndex = 0
        Me.gro_buscarMedicamento.TabStop = False
        Me.gro_buscarMedicamento.Text = "Buscar Medicamento"
        '
        'btn_buscarMedicamento
        '
        Me.btn_buscarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarMedicamento.Image = Global.Veterinaria.My.Resources.Resources.find
        Me.btn_buscarMedicamento.Location = New System.Drawing.Point(378, 18)
        Me.btn_buscarMedicamento.Name = "btn_buscarMedicamento"
        Me.btn_buscarMedicamento.Size = New System.Drawing.Size(56, 32)
        Me.btn_buscarMedicamento.TabIndex = 2
        Me.btn_buscarMedicamento.UseVisualStyleBackColor = True
        '
        'txt_buscarMedicamento
        '
        Me.txt_buscarMedicamento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscarMedicamento.Location = New System.Drawing.Point(110, 21)
        Me.txt_buscarMedicamento.Name = "txt_buscarMedicamento"
        Me.txt_buscarMedicamento.Size = New System.Drawing.Size(137, 23)
        Me.txt_buscarMedicamento.TabIndex = 1
        '
        'lbl_idBuscarMedicamento
        '
        Me.lbl_idBuscarMedicamento.AutoSize = True
        Me.lbl_idBuscarMedicamento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idBuscarMedicamento.Location = New System.Drawing.Point(17, 24)
        Me.lbl_idBuscarMedicamento.Name = "lbl_idBuscarMedicamento"
        Me.lbl_idBuscarMedicamento.Size = New System.Drawing.Size(87, 16)
        Me.lbl_idBuscarMedicamento.TabIndex = 0
        Me.lbl_idBuscarMedicamento.Text = "Descripcion:"
        '
        'gro_datosMedicamentosEditar
        '
        Me.gro_datosMedicamentosEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosMedicamentosEditar.Controls.Add(Me.mkb_fechaUltCompraEditar)
        Me.gro_datosMedicamentosEditar.Controls.Add(Me.btn_guardarMedicamentoEditar)
        Me.gro_datosMedicamentosEditar.Controls.Add(Me.cbo_idLaboratorioEditar)
        Me.gro_datosMedicamentosEditar.Controls.Add(Me.txt_descripcionEditar)
        Me.gro_datosMedicamentosEditar.Controls.Add(Me.txt_idMedicamentoEditar)
        Me.gro_datosMedicamentosEditar.Controls.Add(Me.lbl_fechaUltCompraEditar)
        Me.gro_datosMedicamentosEditar.Controls.Add(Me.id_laboratorioEditar)
        Me.gro_datosMedicamentosEditar.Controls.Add(Me.lbl_DescripcionEditar)
        Me.gro_datosMedicamentosEditar.Controls.Add(Me.lbl_idMedicamentoEditar)
        Me.gro_datosMedicamentosEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosMedicamentosEditar.ForeColor = System.Drawing.Color.White
        Me.gro_datosMedicamentosEditar.Location = New System.Drawing.Point(13, 104)
        Me.gro_datosMedicamentosEditar.Name = "gro_datosMedicamentosEditar"
        Me.gro_datosMedicamentosEditar.Size = New System.Drawing.Size(478, 117)
        Me.gro_datosMedicamentosEditar.TabIndex = 1
        Me.gro_datosMedicamentosEditar.TabStop = False
        Me.gro_datosMedicamentosEditar.Text = "Datos Medicamentos"
        '
        'mkb_fechaUltCompraEditar
        '
        Me.mkb_fechaUltCompraEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkb_fechaUltCompraEditar.ForeColor = System.Drawing.Color.Black
        Me.mkb_fechaUltCompraEditar.Location = New System.Drawing.Point(387, 47)
        Me.mkb_fechaUltCompraEditar.Mask = "00/00/0000"
        Me.mkb_fechaUltCompraEditar.Name = "mkb_fechaUltCompraEditar"
        Me.mkb_fechaUltCompraEditar.Size = New System.Drawing.Size(75, 23)
        Me.mkb_fechaUltCompraEditar.TabIndex = 6
        Me.mkb_fechaUltCompraEditar.ValidatingType = GetType(Date)
        '
        'btn_guardarMedicamentoEditar
        '
        Me.btn_guardarMedicamentoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarMedicamentoEditar.Image = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarMedicamentoEditar.Location = New System.Drawing.Point(374, 83)
        Me.btn_guardarMedicamentoEditar.Name = "btn_guardarMedicamentoEditar"
        Me.btn_guardarMedicamentoEditar.Size = New System.Drawing.Size(50, 28)
        Me.btn_guardarMedicamentoEditar.TabIndex = 7
        Me.btn_guardarMedicamentoEditar.UseVisualStyleBackColor = True
        '
        'cbo_idLaboratorioEditar
        '
        Me.cbo_idLaboratorioEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_idLaboratorioEditar.ForeColor = System.Drawing.Color.Black
        Me.cbo_idLaboratorioEditar.FormattingEnabled = True
        Me.cbo_idLaboratorioEditar.Location = New System.Drawing.Point(387, 21)
        Me.cbo_idLaboratorioEditar.Name = "cbo_idLaboratorioEditar"
        Me.cbo_idLaboratorioEditar.Size = New System.Drawing.Size(75, 24)
        Me.cbo_idLaboratorioEditar.TabIndex = 5
        '
        'txt_descripcionEditar
        '
        Me.txt_descripcionEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcionEditar.ForeColor = System.Drawing.Color.Black
        Me.txt_descripcionEditar.Location = New System.Drawing.Point(82, 47)
        Me.txt_descripcionEditar.Name = "txt_descripcionEditar"
        Me.txt_descripcionEditar.Size = New System.Drawing.Size(137, 23)
        Me.txt_descripcionEditar.TabIndex = 4
        '
        'txt_idMedicamentoEditar
        '
        Me.txt_idMedicamentoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idMedicamentoEditar.ForeColor = System.Drawing.Color.Black
        Me.txt_idMedicamentoEditar.Location = New System.Drawing.Point(82, 22)
        Me.txt_idMedicamentoEditar.MaxLength = 5
        Me.txt_idMedicamentoEditar.Name = "txt_idMedicamentoEditar"
        Me.txt_idMedicamentoEditar.Size = New System.Drawing.Size(137, 23)
        Me.txt_idMedicamentoEditar.TabIndex = 3
        '
        'lbl_fechaUltCompraEditar
        '
        Me.lbl_fechaUltCompraEditar.AutoSize = True
        Me.lbl_fechaUltCompraEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaUltCompraEditar.ForeColor = System.Drawing.Color.White
        Me.lbl_fechaUltCompraEditar.Location = New System.Drawing.Point(267, 54)
        Me.lbl_fechaUltCompraEditar.Name = "lbl_fechaUltCompraEditar"
        Me.lbl_fechaUltCompraEditar.Size = New System.Drawing.Size(114, 16)
        Me.lbl_fechaUltCompraEditar.TabIndex = 3
        Me.lbl_fechaUltCompraEditar.Text = " Ultima compra:"
        '
        'id_laboratorioEditar
        '
        Me.id_laboratorioEditar.AutoSize = True
        Me.id_laboratorioEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_laboratorioEditar.ForeColor = System.Drawing.Color.White
        Me.id_laboratorioEditar.Location = New System.Drawing.Point(276, 25)
        Me.id_laboratorioEditar.Name = "id_laboratorioEditar"
        Me.id_laboratorioEditar.Size = New System.Drawing.Size(105, 16)
        Me.id_laboratorioEditar.TabIndex = 2
        Me.id_laboratorioEditar.Text = "ID Laboratorio:"
        '
        'lbl_DescripcionEditar
        '
        Me.lbl_DescripcionEditar.AutoSize = True
        Me.lbl_DescripcionEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescripcionEditar.ForeColor = System.Drawing.Color.White
        Me.lbl_DescripcionEditar.Location = New System.Drawing.Point(11, 50)
        Me.lbl_DescripcionEditar.Name = "lbl_DescripcionEditar"
        Me.lbl_DescripcionEditar.Size = New System.Drawing.Size(65, 16)
        Me.lbl_DescripcionEditar.TabIndex = 1
        Me.lbl_DescripcionEditar.Text = "Nombre:"
        '
        'lbl_idMedicamentoEditar
        '
        Me.lbl_idMedicamentoEditar.AutoSize = True
        Me.lbl_idMedicamentoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idMedicamentoEditar.ForeColor = System.Drawing.Color.White
        Me.lbl_idMedicamentoEditar.Location = New System.Drawing.Point(51, 24)
        Me.lbl_idMedicamentoEditar.Name = "lbl_idMedicamentoEditar"
        Me.lbl_idMedicamentoEditar.Size = New System.Drawing.Size(25, 16)
        Me.lbl_idMedicamentoEditar.TabIndex = 0
        Me.lbl_idMedicamentoEditar.Text = "ID:"
        '
        'dgv_editarMedicamentos
        '
        Me.dgv_editarMedicamentos.AllowUserToAddRows = False
        Me.dgv_editarMedicamentos.AllowUserToDeleteRows = False
        Me.dgv_editarMedicamentos.AllowUserToResizeColumns = False
        Me.dgv_editarMedicamentos.AllowUserToResizeRows = False
        Me.dgv_editarMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_editarMedicamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_editarMedicamentos.CausesValidation = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_editarMedicamentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_editarMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_editarMedicamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idMedicamentoEditar, Me.col_descripcionEditar, Me.col_idLaboratorioEditar, Me.col_fechaUltCompraEditar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_editarMedicamentos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_editarMedicamentos.GridColor = System.Drawing.SystemColors.Desktop
        Me.dgv_editarMedicamentos.Location = New System.Drawing.Point(6, 19)
        Me.dgv_editarMedicamentos.MultiSelect = False
        Me.dgv_editarMedicamentos.Name = "dgv_editarMedicamentos"
        Me.dgv_editarMedicamentos.ReadOnly = True
        Me.dgv_editarMedicamentos.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgv_editarMedicamentos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_editarMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_editarMedicamentos.Size = New System.Drawing.Size(448, 120)
        Me.dgv_editarMedicamentos.TabIndex = 2
        '
        'col_idMedicamentoEditar
        '
        Me.col_idMedicamentoEditar.FillWeight = 64.4037!
        Me.col_idMedicamentoEditar.HeaderText = "ID"
        Me.col_idMedicamentoEditar.Name = "col_idMedicamentoEditar"
        Me.col_idMedicamentoEditar.ReadOnly = True
        '
        'col_descripcionEditar
        '
        Me.col_descripcionEditar.FillWeight = 130.3487!
        Me.col_descripcionEditar.HeaderText = "Nombre"
        Me.col_descripcionEditar.Name = "col_descripcionEditar"
        Me.col_descripcionEditar.ReadOnly = True
        '
        'col_idLaboratorioEditar
        '
        Me.col_idLaboratorioEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.col_idLaboratorioEditar.FillWeight = 63.11563!
        Me.col_idLaboratorioEditar.HeaderText = "ID Laboratorio"
        Me.col_idLaboratorioEditar.Name = "col_idLaboratorioEditar"
        Me.col_idLaboratorioEditar.ReadOnly = True
        Me.col_idLaboratorioEditar.Width = 115
        '
        'col_fechaUltCompraEditar
        '
        Me.col_fechaUltCompraEditar.FillWeight = 142.132!
        Me.col_fechaUltCompraEditar.HeaderText = "Fecha Ultima Compra"
        Me.col_fechaUltCompraEditar.Name = "col_fechaUltCompraEditar"
        Me.col_fechaUltCompraEditar.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dgv_editarMedicamentos)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 145)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Medicamentos"
        '
        'btn_eliminarMedicamento
        '
        Me.btn_eliminarMedicamento.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminarMedicamento.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Iconshock_Vista_General_Trash
        Me.btn_eliminarMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_eliminarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminarMedicamento.Location = New System.Drawing.Point(344, 366)
        Me.btn_eliminarMedicamento.Name = "btn_eliminarMedicamento"
        Me.btn_eliminarMedicamento.Size = New System.Drawing.Size(49, 22)
        Me.btn_eliminarMedicamento.TabIndex = 8
        Me.btn_eliminarMedicamento.UseVisualStyleBackColor = False
        '
        'btn_salirEditar
        '
        Me.btn_salirEditar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirEditar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salirEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_salirEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirEditar.Location = New System.Drawing.Point(421, 366)
        Me.btn_salirEditar.Name = "btn_salirEditar"
        Me.btn_salirEditar.Size = New System.Drawing.Size(50, 22)
        Me.btn_salirEditar.TabIndex = 9
        Me.btn_salirEditar.UseVisualStyleBackColor = False
        '
        'frm_editarMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.editar_medicamentos1
        Me.ClientSize = New System.Drawing.Size(495, 396)
        Me.Controls.Add(Me.btn_salirEditar)
        Me.Controls.Add(Me.btn_eliminarMedicamento)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gro_datosMedicamentosEditar)
        Me.Controls.Add(Me.gro_buscarMedicamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_editarMedicamento"
        Me.Text = ".:.Editar Medicamentos.:."
        Me.gro_buscarMedicamento.ResumeLayout(False)
        Me.gro_buscarMedicamento.PerformLayout()
        Me.gro_datosMedicamentosEditar.ResumeLayout(False)
        Me.gro_datosMedicamentosEditar.PerformLayout()
        CType(Me.dgv_editarMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gro_buscarMedicamento As System.Windows.Forms.GroupBox
    Friend WithEvents txt_buscarMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_idBuscarMedicamento As System.Windows.Forms.Label
    Friend WithEvents btn_buscarMedicamento As System.Windows.Forms.Button
    Friend WithEvents gro_datosMedicamentosEditar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardarMedicamentoEditar As System.Windows.Forms.Button
    Friend WithEvents cbo_idLaboratorioEditar As System.Windows.Forms.ComboBox
    Friend WithEvents txt_descripcionEditar As System.Windows.Forms.TextBox
    Friend WithEvents txt_idMedicamentoEditar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fechaUltCompraEditar As System.Windows.Forms.Label
    Friend WithEvents id_laboratorioEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_DescripcionEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_idMedicamentoEditar As System.Windows.Forms.Label
    Friend WithEvents dgv_editarMedicamentos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminarMedicamento As System.Windows.Forms.Button
    Friend WithEvents btn_salirEditar As System.Windows.Forms.Button
    Friend WithEvents mkb_fechaUltCompraEditar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents col_idMedicamentoEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcionEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idLaboratorioEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaUltCompraEditar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
