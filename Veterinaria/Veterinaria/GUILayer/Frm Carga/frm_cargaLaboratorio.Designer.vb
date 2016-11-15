<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cargaLaboratorio
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
        Me.dgv_cargaLaboratorio = New System.Windows.Forms.DataGridView()
        Me.col_idLaboratorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_razonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gro_listaLaboratios = New System.Windows.Forms.GroupBox()
        Me.lbl_razonSocial = New System.Windows.Forms.Label()
        Me.lbl_direccionLaboratorio = New System.Windows.Forms.Label()
        Me.txt_razonSocial = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.gro_datosLaboratorio = New System.Windows.Forms.GroupBox()
        Me.lbl_idLaboratorio = New System.Windows.Forms.Label()
        Me.txt_id_laboratorio = New System.Windows.Forms.TextBox()
        Me.btn_agregarLaboratorio = New System.Windows.Forms.Button()
        Me.btn_guardarLaboratorio = New System.Windows.Forms.Button()
        Me.btn_salirLaboratorio = New System.Windows.Forms.Button()
        CType(Me.dgv_cargaLaboratorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gro_listaLaboratios.SuspendLayout()
        Me.gro_datosLaboratorio.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_cargaLaboratorio
        '
        Me.dgv_cargaLaboratorio.AllowUserToAddRows = False
        Me.dgv_cargaLaboratorio.AllowUserToDeleteRows = False
        Me.dgv_cargaLaboratorio.AllowUserToResizeColumns = False
        Me.dgv_cargaLaboratorio.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue
        Me.dgv_cargaLaboratorio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_cargaLaboratorio.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_cargaLaboratorio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_cargaLaboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cargaLaboratorio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idLaboratorio, Me.col_razonSocial, Me.col_direccion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_cargaLaboratorio.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_cargaLaboratorio.Location = New System.Drawing.Point(6, 19)
        Me.dgv_cargaLaboratorio.MultiSelect = False
        Me.dgv_cargaLaboratorio.Name = "dgv_cargaLaboratorio"
        Me.dgv_cargaLaboratorio.ReadOnly = True
        Me.dgv_cargaLaboratorio.RowHeadersVisible = False
        Me.dgv_cargaLaboratorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cargaLaboratorio.Size = New System.Drawing.Size(355, 123)
        Me.dgv_cargaLaboratorio.TabIndex = 1
        '
        'col_idLaboratorio
        '
        Me.col_idLaboratorio.HeaderText = "ID"
        Me.col_idLaboratorio.Name = "col_idLaboratorio"
        Me.col_idLaboratorio.ReadOnly = True
        Me.col_idLaboratorio.Width = 50
        '
        'col_razonSocial
        '
        Me.col_razonSocial.HeaderText = "Razon Social"
        Me.col_razonSocial.Name = "col_razonSocial"
        Me.col_razonSocial.ReadOnly = True
        Me.col_razonSocial.Width = 150
        '
        'col_direccion
        '
        Me.col_direccion.HeaderText = "Direccion"
        Me.col_direccion.Name = "col_direccion"
        Me.col_direccion.ReadOnly = True
        Me.col_direccion.Width = 150
        '
        'gro_listaLaboratios
        '
        Me.gro_listaLaboratios.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaLaboratios.Controls.Add(Me.dgv_cargaLaboratorio)
        Me.gro_listaLaboratios.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_listaLaboratios.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gro_listaLaboratios.Location = New System.Drawing.Point(6, 152)
        Me.gro_listaLaboratios.Name = "gro_listaLaboratios"
        Me.gro_listaLaboratios.Size = New System.Drawing.Size(367, 148)
        Me.gro_listaLaboratios.TabIndex = 2
        Me.gro_listaLaboratios.TabStop = False
        Me.gro_listaLaboratios.Text = "Lista de Laboratorios"
        '
        'lbl_razonSocial
        '
        Me.lbl_razonSocial.AutoSize = True
        Me.lbl_razonSocial.BackColor = System.Drawing.Color.Transparent
        Me.lbl_razonSocial.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_razonSocial.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_razonSocial.Location = New System.Drawing.Point(24, 52)
        Me.lbl_razonSocial.Name = "lbl_razonSocial"
        Me.lbl_razonSocial.Size = New System.Drawing.Size(93, 16)
        Me.lbl_razonSocial.TabIndex = 3
        Me.lbl_razonSocial.Text = "Razon social:"
        '
        'lbl_direccionLaboratorio
        '
        Me.lbl_direccionLaboratorio.AutoSize = True
        Me.lbl_direccionLaboratorio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccionLaboratorio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_direccionLaboratorio.Location = New System.Drawing.Point(44, 80)
        Me.lbl_direccionLaboratorio.Name = "lbl_direccionLaboratorio"
        Me.lbl_direccionLaboratorio.Size = New System.Drawing.Size(73, 16)
        Me.lbl_direccionLaboratorio.TabIndex = 4
        Me.lbl_direccionLaboratorio.Text = "Dirección:"
        '
        'txt_razonSocial
        '
        Me.txt_razonSocial.Location = New System.Drawing.Point(123, 49)
        Me.txt_razonSocial.Multiline = True
        Me.txt_razonSocial.Name = "txt_razonSocial"
        Me.txt_razonSocial.Size = New System.Drawing.Size(141, 20)
        Me.txt_razonSocial.TabIndex = 2
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(123, 78)
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(141, 20)
        Me.txt_direccion.TabIndex = 3
        '
        'gro_datosLaboratorio
        '
        Me.gro_datosLaboratorio.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosLaboratorio.Controls.Add(Me.lbl_idLaboratorio)
        Me.gro_datosLaboratorio.Controls.Add(Me.txt_id_laboratorio)
        Me.gro_datosLaboratorio.Controls.Add(Me.btn_agregarLaboratorio)
        Me.gro_datosLaboratorio.Controls.Add(Me.txt_direccion)
        Me.gro_datosLaboratorio.Controls.Add(Me.txt_razonSocial)
        Me.gro_datosLaboratorio.Controls.Add(Me.lbl_direccionLaboratorio)
        Me.gro_datosLaboratorio.Controls.Add(Me.lbl_razonSocial)
        Me.gro_datosLaboratorio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosLaboratorio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gro_datosLaboratorio.Location = New System.Drawing.Point(6, 42)
        Me.gro_datosLaboratorio.Name = "gro_datosLaboratorio"
        Me.gro_datosLaboratorio.Size = New System.Drawing.Size(367, 104)
        Me.gro_datosLaboratorio.TabIndex = 7
        Me.gro_datosLaboratorio.TabStop = False
        Me.gro_datosLaboratorio.Text = "Datos Laboratorio"
        '
        'lbl_idLaboratorio
        '
        Me.lbl_idLaboratorio.AutoSize = True
        Me.lbl_idLaboratorio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idLaboratorio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_idLaboratorio.Location = New System.Drawing.Point(92, 23)
        Me.lbl_idLaboratorio.Name = "lbl_idLaboratorio"
        Me.lbl_idLaboratorio.Size = New System.Drawing.Size(25, 16)
        Me.lbl_idLaboratorio.TabIndex = 9
        Me.lbl_idLaboratorio.Text = "ID:"
        '
        'txt_id_laboratorio
        '
        Me.txt_id_laboratorio.Enabled = False
        Me.txt_id_laboratorio.Location = New System.Drawing.Point(123, 19)
        Me.txt_id_laboratorio.MaxLength = 5
        Me.txt_id_laboratorio.Multiline = True
        Me.txt_id_laboratorio.Name = "txt_id_laboratorio"
        Me.txt_id_laboratorio.Size = New System.Drawing.Size(141, 20)
        Me.txt_id_laboratorio.TabIndex = 1
        '
        'btn_agregarLaboratorio
        '
        Me.btn_agregarLaboratorio.BackgroundImage = Global.Veterinaria.My.Resources.Resources.add
        Me.btn_agregarLaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_agregarLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregarLaboratorio.ForeColor = System.Drawing.Color.Transparent
        Me.btn_agregarLaboratorio.Location = New System.Drawing.Point(296, 69)
        Me.btn_agregarLaboratorio.Name = "btn_agregarLaboratorio"
        Me.btn_agregarLaboratorio.Size = New System.Drawing.Size(34, 27)
        Me.btn_agregarLaboratorio.TabIndex = 4
        Me.btn_agregarLaboratorio.UseVisualStyleBackColor = True
        '
        'btn_guardarLaboratorio
        '
        Me.btn_guardarLaboratorio.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardarLaboratorio.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarLaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_guardarLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarLaboratorio.ForeColor = System.Drawing.Color.Transparent
        Me.btn_guardarLaboratorio.Location = New System.Drawing.Point(267, 303)
        Me.btn_guardarLaboratorio.Name = "btn_guardarLaboratorio"
        Me.btn_guardarLaboratorio.Size = New System.Drawing.Size(33, 28)
        Me.btn_guardarLaboratorio.TabIndex = 5
        Me.btn_guardarLaboratorio.UseVisualStyleBackColor = False
        '
        'btn_salirLaboratorio
        '
        Me.btn_salirLaboratorio.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirLaboratorio.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salirLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirLaboratorio.ForeColor = System.Drawing.Color.Transparent
        Me.btn_salirLaboratorio.Location = New System.Drawing.Point(322, 303)
        Me.btn_salirLaboratorio.Name = "btn_salirLaboratorio"
        Me.btn_salirLaboratorio.Size = New System.Drawing.Size(30, 28)
        Me.btn_salirLaboratorio.TabIndex = 6
        Me.btn_salirLaboratorio.UseVisualStyleBackColor = False
        '
        'frm_cargaLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.asd
        Me.ClientSize = New System.Drawing.Size(396, 340)
        Me.Controls.Add(Me.btn_salirLaboratorio)
        Me.Controls.Add(Me.btn_guardarLaboratorio)
        Me.Controls.Add(Me.gro_datosLaboratorio)
        Me.Controls.Add(Me.gro_listaLaboratios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cargaLaboratorio"
        Me.Text = ".:. Registrar Laboratorio .:."
        CType(Me.dgv_cargaLaboratorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gro_listaLaboratios.ResumeLayout(False)
        Me.gro_datosLaboratorio.ResumeLayout(False)
        Me.gro_datosLaboratorio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_cargaLaboratorio As System.Windows.Forms.DataGridView
    Friend WithEvents gro_listaLaboratios As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_razonSocial As System.Windows.Forms.Label
    Friend WithEvents lbl_direccionLaboratorio As System.Windows.Forms.Label
    Friend WithEvents txt_razonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents gro_datosLaboratorio As System.Windows.Forms.GroupBox
    Friend WithEvents btn_agregarLaboratorio As System.Windows.Forms.Button
    Friend WithEvents btn_guardarLaboratorio As System.Windows.Forms.Button
    Friend WithEvents btn_salirLaboratorio As System.Windows.Forms.Button
    Friend WithEvents lbl_idLaboratorio As System.Windows.Forms.Label
    Friend WithEvents txt_id_laboratorio As System.Windows.Forms.TextBox
    Friend WithEvents col_idLaboratorio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_razonSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_direccion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
