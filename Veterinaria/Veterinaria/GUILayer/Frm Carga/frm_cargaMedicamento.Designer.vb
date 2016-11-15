<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cargaMedicamento
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
        Me.gro_datosMedicamento = New System.Windows.Forms.GroupBox()
        Me.mkb_fechaUltimaCompra = New System.Windows.Forms.MaskedTextBox()
        Me.btn_agregarMedicamento = New System.Windows.Forms.Button()
        Me.cbo_idLaboratorio = New System.Windows.Forms.ComboBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_idMedicamento = New System.Windows.Forms.TextBox()
        Me.lbl_fechaUltCompra = New System.Windows.Forms.Label()
        Me.id_laboratorio = New System.Windows.Forms.Label()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.lbl_idMedicamento = New System.Windows.Forms.Label()
        Me.gro_listaMedicamentos = New System.Windows.Forms.GroupBox()
        Me.dgv_cargaMedicamentos = New System.Windows.Forms.DataGridView()
        Me.col_idMedicamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idLaboratorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaUltCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_guardarMedicamento = New System.Windows.Forms.Button()
        Me.btn_salirLaboratorio = New System.Windows.Forms.Button()
        Me.gro_datosMedicamento.SuspendLayout()
        Me.gro_listaMedicamentos.SuspendLayout()
        CType(Me.dgv_cargaMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gro_datosMedicamento
        '
        Me.gro_datosMedicamento.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosMedicamento.Controls.Add(Me.mkb_fechaUltimaCompra)
        Me.gro_datosMedicamento.Controls.Add(Me.btn_agregarMedicamento)
        Me.gro_datosMedicamento.Controls.Add(Me.cbo_idLaboratorio)
        Me.gro_datosMedicamento.Controls.Add(Me.txt_descripcion)
        Me.gro_datosMedicamento.Controls.Add(Me.txt_idMedicamento)
        Me.gro_datosMedicamento.Controls.Add(Me.lbl_fechaUltCompra)
        Me.gro_datosMedicamento.Controls.Add(Me.id_laboratorio)
        Me.gro_datosMedicamento.Controls.Add(Me.lbl_Descripcion)
        Me.gro_datosMedicamento.Controls.Add(Me.lbl_idMedicamento)
        Me.gro_datosMedicamento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosMedicamento.ForeColor = System.Drawing.Color.White
        Me.gro_datosMedicamento.Location = New System.Drawing.Point(4, 36)
        Me.gro_datosMedicamento.Name = "gro_datosMedicamento"
        Me.gro_datosMedicamento.Size = New System.Drawing.Size(480, 102)
        Me.gro_datosMedicamento.TabIndex = 0
        Me.gro_datosMedicamento.TabStop = False
        Me.gro_datosMedicamento.Text = "Datos Medicamentos"
        '
        'mkb_fechaUltimaCompra
        '
        Me.mkb_fechaUltimaCompra.Location = New System.Drawing.Point(383, 22)
        Me.mkb_fechaUltimaCompra.Mask = "00/00/0000"
        Me.mkb_fechaUltimaCompra.Name = "mkb_fechaUltimaCompra"
        Me.mkb_fechaUltimaCompra.Size = New System.Drawing.Size(91, 23)
        Me.mkb_fechaUltimaCompra.TabIndex = 4
        Me.mkb_fechaUltimaCompra.ValidatingType = GetType(Date)
        '
        'btn_agregarMedicamento
        '
        Me.btn_agregarMedicamento.BackgroundImage = Global.Veterinaria.My.Resources.Resources.add
        Me.btn_agregarMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregarMedicamento.Location = New System.Drawing.Point(383, 56)
        Me.btn_agregarMedicamento.Name = "btn_agregarMedicamento"
        Me.btn_agregarMedicamento.Size = New System.Drawing.Size(50, 36)
        Me.btn_agregarMedicamento.TabIndex = 5
        Me.btn_agregarMedicamento.UseVisualStyleBackColor = True
        '
        'cbo_idLaboratorio
        '
        Me.cbo_idLaboratorio.FormattingEnabled = True
        Me.cbo_idLaboratorio.Location = New System.Drawing.Point(117, 68)
        Me.cbo_idLaboratorio.Name = "cbo_idLaboratorio"
        Me.cbo_idLaboratorio.Size = New System.Drawing.Size(144, 24)
        Me.cbo_idLaboratorio.TabIndex = 3
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(117, 44)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(144, 23)
        Me.txt_descripcion.TabIndex = 2
        '
        'txt_idMedicamento
        '
        Me.txt_idMedicamento.Enabled = False
        Me.txt_idMedicamento.Location = New System.Drawing.Point(117, 18)
        Me.txt_idMedicamento.Name = "txt_idMedicamento"
        Me.txt_idMedicamento.Size = New System.Drawing.Size(144, 23)
        Me.txt_idMedicamento.TabIndex = 1
        '
        'lbl_fechaUltCompra
        '
        Me.lbl_fechaUltCompra.AutoSize = True
        Me.lbl_fechaUltCompra.Location = New System.Drawing.Point(263, 25)
        Me.lbl_fechaUltCompra.Name = "lbl_fechaUltCompra"
        Me.lbl_fechaUltCompra.Size = New System.Drawing.Size(114, 16)
        Me.lbl_fechaUltCompra.TabIndex = 3
        Me.lbl_fechaUltCompra.Text = " Ultima compra:"
        '
        'id_laboratorio
        '
        Me.id_laboratorio.AutoSize = True
        Me.id_laboratorio.Location = New System.Drawing.Point(19, 71)
        Me.id_laboratorio.Name = "id_laboratorio"
        Me.id_laboratorio.Size = New System.Drawing.Size(92, 16)
        Me.id_laboratorio.TabIndex = 2
        Me.id_laboratorio.Text = " Laboratorio:"
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(46, 47)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(65, 16)
        Me.lbl_Descripcion.TabIndex = 1
        Me.lbl_Descripcion.Text = "Nombre:"
        '
        'lbl_idMedicamento
        '
        Me.lbl_idMedicamento.AutoSize = True
        Me.lbl_idMedicamento.Location = New System.Drawing.Point(86, 21)
        Me.lbl_idMedicamento.Name = "lbl_idMedicamento"
        Me.lbl_idMedicamento.Size = New System.Drawing.Size(25, 16)
        Me.lbl_idMedicamento.TabIndex = 0
        Me.lbl_idMedicamento.Text = "ID:"
        '
        'gro_listaMedicamentos
        '
        Me.gro_listaMedicamentos.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaMedicamentos.Controls.Add(Me.dgv_cargaMedicamentos)
        Me.gro_listaMedicamentos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_listaMedicamentos.ForeColor = System.Drawing.Color.White
        Me.gro_listaMedicamentos.Location = New System.Drawing.Point(4, 144)
        Me.gro_listaMedicamentos.Name = "gro_listaMedicamentos"
        Me.gro_listaMedicamentos.Size = New System.Drawing.Size(480, 152)
        Me.gro_listaMedicamentos.TabIndex = 1
        Me.gro_listaMedicamentos.TabStop = False
        Me.gro_listaMedicamentos.Text = "Lista de Medicamentos"
        '
        'dgv_cargaMedicamentos
        '
        Me.dgv_cargaMedicamentos.AllowUserToAddRows = False
        Me.dgv_cargaMedicamentos.AllowUserToDeleteRows = False
        Me.dgv_cargaMedicamentos.AllowUserToResizeColumns = False
        Me.dgv_cargaMedicamentos.AllowUserToResizeRows = False
        Me.dgv_cargaMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cargaMedicamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idMedicamento, Me.col_descripcion, Me.col_idLaboratorio, Me.col_fechaUltCompra})
        Me.dgv_cargaMedicamentos.Location = New System.Drawing.Point(8, 19)
        Me.dgv_cargaMedicamentos.MultiSelect = False
        Me.dgv_cargaMedicamentos.Name = "dgv_cargaMedicamentos"
        Me.dgv_cargaMedicamentos.ReadOnly = True
        Me.dgv_cargaMedicamentos.RowHeadersVisible = False
        Me.dgv_cargaMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cargaMedicamentos.Size = New System.Drawing.Size(466, 127)
        Me.dgv_cargaMedicamentos.TabIndex = 0
        '
        'col_idMedicamento
        '
        Me.col_idMedicamento.HeaderText = "ID"
        Me.col_idMedicamento.Name = "col_idMedicamento"
        Me.col_idMedicamento.ReadOnly = True
        Me.col_idMedicamento.Width = 50
        '
        'col_descripcion
        '
        Me.col_descripcion.HeaderText = "Nombre"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.ReadOnly = True
        Me.col_descripcion.Width = 212
        '
        'col_idLaboratorio
        '
        Me.col_idLaboratorio.HeaderText = "ID Laboratorio"
        Me.col_idLaboratorio.Name = "col_idLaboratorio"
        Me.col_idLaboratorio.ReadOnly = True
        '
        'col_fechaUltCompra
        '
        Me.col_fechaUltCompra.HeaderText = "Fecha ultima compra"
        Me.col_fechaUltCompra.Name = "col_fechaUltCompra"
        Me.col_fechaUltCompra.ReadOnly = True
        '
        'btn_guardarMedicamento
        '
        Me.btn_guardarMedicamento.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardarMedicamento.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarMedicamento.Location = New System.Drawing.Point(334, 302)
        Me.btn_guardarMedicamento.Name = "btn_guardarMedicamento"
        Me.btn_guardarMedicamento.Size = New System.Drawing.Size(47, 30)
        Me.btn_guardarMedicamento.TabIndex = 6
        Me.btn_guardarMedicamento.UseVisualStyleBackColor = False
        '
        'btn_salirLaboratorio
        '
        Me.btn_salirLaboratorio.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirLaboratorio.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salirLaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salirLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirLaboratorio.Location = New System.Drawing.Point(403, 302)
        Me.btn_salirLaboratorio.Name = "btn_salirLaboratorio"
        Me.btn_salirLaboratorio.Size = New System.Drawing.Size(48, 30)
        Me.btn_salirLaboratorio.TabIndex = 7
        Me.btn_salirLaboratorio.UseVisualStyleBackColor = False
        '
        'frm_cargaMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Registrar_medicamento
        Me.ClientSize = New System.Drawing.Size(490, 337)
        Me.Controls.Add(Me.btn_salirLaboratorio)
        Me.Controls.Add(Me.btn_guardarMedicamento)
        Me.Controls.Add(Me.gro_listaMedicamentos)
        Me.Controls.Add(Me.gro_datosMedicamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cargaMedicamento"
        Me.Text = ".:.Registrar Medicamento.:."
        Me.gro_datosMedicamento.ResumeLayout(False)
        Me.gro_datosMedicamento.PerformLayout()
        Me.gro_listaMedicamentos.ResumeLayout(False)
        CType(Me.dgv_cargaMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gro_datosMedicamento As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_idLaboratorio As System.Windows.Forms.ComboBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_idMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fechaUltCompra As System.Windows.Forms.Label
    Friend WithEvents id_laboratorio As System.Windows.Forms.Label
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_idMedicamento As System.Windows.Forms.Label
    Friend WithEvents btn_agregarMedicamento As System.Windows.Forms.Button
    Friend WithEvents gro_listaMedicamentos As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_cargaMedicamentos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_guardarMedicamento As System.Windows.Forms.Button
    Friend WithEvents btn_salirLaboratorio As System.Windows.Forms.Button
    Friend WithEvents mkb_fechaUltimaCompra As System.Windows.Forms.MaskedTextBox
    Friend WithEvents col_idMedicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idLaboratorio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaUltCompra As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
