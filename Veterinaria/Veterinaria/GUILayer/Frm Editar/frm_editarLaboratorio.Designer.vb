<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editarLaboratorio
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
        Me.gro_buscaLaboratorioEditar = New System.Windows.Forms.GroupBox()
        Me.btn_buscarLaboratorio = New System.Windows.Forms.Button()
        Me.txt_buscarLaboratorioEditar = New System.Windows.Forms.TextBox()
        Me.lbl_buscarEditar = New System.Windows.Forms.Label()
        Me.gro_datosLaboratorioEditar = New System.Windows.Forms.GroupBox()
        Me.lbl_idLaboratorioEditar = New System.Windows.Forms.Label()
        Me.txt_idLaboratorioEditar = New System.Windows.Forms.TextBox()
        Me.btn_guardarLaboratorioEditar = New System.Windows.Forms.Button()
        Me.txt_direccionEditar = New System.Windows.Forms.TextBox()
        Me.txt_razonSocialEditar = New System.Windows.Forms.TextBox()
        Me.lbl_direccionLaboratorioEditar = New System.Windows.Forms.Label()
        Me.lbl_razonSocialEditar = New System.Windows.Forms.Label()
        Me.gro_listaLaboratorioEditar = New System.Windows.Forms.GroupBox()
        Me.dgv_listaLaboratoriosEditar = New System.Windows.Forms.DataGridView()
        Me.col_idLaboratorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_razonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salirEditar = New System.Windows.Forms.Button()
        Me.gro_buscaLaboratorioEditar.SuspendLayout()
        Me.gro_datosLaboratorioEditar.SuspendLayout()
        Me.gro_listaLaboratorioEditar.SuspendLayout()
        CType(Me.dgv_listaLaboratoriosEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gro_buscaLaboratorioEditar
        '
        Me.gro_buscaLaboratorioEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_buscaLaboratorioEditar.Controls.Add(Me.btn_buscarLaboratorio)
        Me.gro_buscaLaboratorioEditar.Controls.Add(Me.txt_buscarLaboratorioEditar)
        Me.gro_buscaLaboratorioEditar.Controls.Add(Me.lbl_buscarEditar)
        Me.gro_buscaLaboratorioEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_buscaLaboratorioEditar.ForeColor = System.Drawing.Color.White
        Me.gro_buscaLaboratorioEditar.Location = New System.Drawing.Point(12, 54)
        Me.gro_buscaLaboratorioEditar.Name = "gro_buscaLaboratorioEditar"
        Me.gro_buscaLaboratorioEditar.Size = New System.Drawing.Size(414, 61)
        Me.gro_buscaLaboratorioEditar.TabIndex = 0
        Me.gro_buscaLaboratorioEditar.TabStop = False
        Me.gro_buscaLaboratorioEditar.Text = "Buscar Laboratorio"
        '
        'btn_buscarLaboratorio
        '
        Me.btn_buscarLaboratorio.BackgroundImage = Global.Veterinaria.My.Resources.Resources.find
        Me.btn_buscarLaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_buscarLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarLaboratorio.Location = New System.Drawing.Point(337, 22)
        Me.btn_buscarLaboratorio.Name = "btn_buscarLaboratorio"
        Me.btn_buscarLaboratorio.Size = New System.Drawing.Size(49, 33)
        Me.btn_buscarLaboratorio.TabIndex = 2
        Me.btn_buscarLaboratorio.UseVisualStyleBackColor = True
        '
        'txt_buscarLaboratorioEditar
        '
        Me.txt_buscarLaboratorioEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscarLaboratorioEditar.Location = New System.Drawing.Point(114, 22)
        Me.txt_buscarLaboratorioEditar.MaxLength = 50
        Me.txt_buscarLaboratorioEditar.Name = "txt_buscarLaboratorioEditar"
        Me.txt_buscarLaboratorioEditar.Size = New System.Drawing.Size(139, 23)
        Me.txt_buscarLaboratorioEditar.TabIndex = 1
        '
        'lbl_buscarEditar
        '
        Me.lbl_buscarEditar.AutoSize = True
        Me.lbl_buscarEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_buscarEditar.Location = New System.Drawing.Point(24, 25)
        Me.lbl_buscarEditar.Name = "lbl_buscarEditar"
        Me.lbl_buscarEditar.Size = New System.Drawing.Size(93, 16)
        Me.lbl_buscarEditar.TabIndex = 0
        Me.lbl_buscarEditar.Text = "Razon social:"
        '
        'gro_datosLaboratorioEditar
        '
        Me.gro_datosLaboratorioEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosLaboratorioEditar.Controls.Add(Me.lbl_idLaboratorioEditar)
        Me.gro_datosLaboratorioEditar.Controls.Add(Me.txt_idLaboratorioEditar)
        Me.gro_datosLaboratorioEditar.Controls.Add(Me.btn_guardarLaboratorioEditar)
        Me.gro_datosLaboratorioEditar.Controls.Add(Me.txt_direccionEditar)
        Me.gro_datosLaboratorioEditar.Controls.Add(Me.txt_razonSocialEditar)
        Me.gro_datosLaboratorioEditar.Controls.Add(Me.lbl_direccionLaboratorioEditar)
        Me.gro_datosLaboratorioEditar.Controls.Add(Me.lbl_razonSocialEditar)
        Me.gro_datosLaboratorioEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosLaboratorioEditar.ForeColor = System.Drawing.Color.White
        Me.gro_datosLaboratorioEditar.Location = New System.Drawing.Point(12, 121)
        Me.gro_datosLaboratorioEditar.Name = "gro_datosLaboratorioEditar"
        Me.gro_datosLaboratorioEditar.Size = New System.Drawing.Size(414, 110)
        Me.gro_datosLaboratorioEditar.TabIndex = 8
        Me.gro_datosLaboratorioEditar.TabStop = False
        Me.gro_datosLaboratorioEditar.Text = "Datos Laboratorio"
        '
        'lbl_idLaboratorioEditar
        '
        Me.lbl_idLaboratorioEditar.AutoSize = True
        Me.lbl_idLaboratorioEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idLaboratorioEditar.Location = New System.Drawing.Point(90, 27)
        Me.lbl_idLaboratorioEditar.Name = "lbl_idLaboratorioEditar"
        Me.lbl_idLaboratorioEditar.Size = New System.Drawing.Size(25, 16)
        Me.lbl_idLaboratorioEditar.TabIndex = 12
        Me.lbl_idLaboratorioEditar.Text = "ID:"
        '
        'txt_idLaboratorioEditar
        '
        Me.txt_idLaboratorioEditar.Enabled = False
        Me.txt_idLaboratorioEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idLaboratorioEditar.Location = New System.Drawing.Point(114, 20)
        Me.txt_idLaboratorioEditar.Name = "txt_idLaboratorioEditar"
        Me.txt_idLaboratorioEditar.Size = New System.Drawing.Size(141, 23)
        Me.txt_idLaboratorioEditar.TabIndex = 3
        '
        'btn_guardarLaboratorioEditar
        '
        Me.btn_guardarLaboratorioEditar.Enabled = False
        Me.btn_guardarLaboratorioEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarLaboratorioEditar.Image = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarLaboratorioEditar.Location = New System.Drawing.Point(337, 67)
        Me.btn_guardarLaboratorioEditar.Name = "btn_guardarLaboratorioEditar"
        Me.btn_guardarLaboratorioEditar.Size = New System.Drawing.Size(49, 37)
        Me.btn_guardarLaboratorioEditar.TabIndex = 6
        Me.btn_guardarLaboratorioEditar.UseVisualStyleBackColor = True
        '
        'txt_direccionEditar
        '
        Me.txt_direccionEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccionEditar.Location = New System.Drawing.Point(114, 72)
        Me.txt_direccionEditar.MaxLength = 50
        Me.txt_direccionEditar.Name = "txt_direccionEditar"
        Me.txt_direccionEditar.Size = New System.Drawing.Size(141, 23)
        Me.txt_direccionEditar.TabIndex = 5
        '
        'txt_razonSocialEditar
        '
        Me.txt_razonSocialEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_razonSocialEditar.Location = New System.Drawing.Point(114, 46)
        Me.txt_razonSocialEditar.MaxLength = 50
        Me.txt_razonSocialEditar.Name = "txt_razonSocialEditar"
        Me.txt_razonSocialEditar.Size = New System.Drawing.Size(141, 23)
        Me.txt_razonSocialEditar.TabIndex = 4
        '
        'lbl_direccionLaboratorioEditar
        '
        Me.lbl_direccionLaboratorioEditar.AutoSize = True
        Me.lbl_direccionLaboratorioEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccionLaboratorioEditar.Location = New System.Drawing.Point(38, 72)
        Me.lbl_direccionLaboratorioEditar.Name = "lbl_direccionLaboratorioEditar"
        Me.lbl_direccionLaboratorioEditar.Size = New System.Drawing.Size(73, 16)
        Me.lbl_direccionLaboratorioEditar.TabIndex = 4
        Me.lbl_direccionLaboratorioEditar.Text = "Dirección:"
        '
        'lbl_razonSocialEditar
        '
        Me.lbl_razonSocialEditar.AutoSize = True
        Me.lbl_razonSocialEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_razonSocialEditar.Location = New System.Drawing.Point(22, 49)
        Me.lbl_razonSocialEditar.Name = "lbl_razonSocialEditar"
        Me.lbl_razonSocialEditar.Size = New System.Drawing.Size(93, 16)
        Me.lbl_razonSocialEditar.TabIndex = 3
        Me.lbl_razonSocialEditar.Text = "Razon social:"
        '
        'gro_listaLaboratorioEditar
        '
        Me.gro_listaLaboratorioEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaLaboratorioEditar.Controls.Add(Me.dgv_listaLaboratoriosEditar)
        Me.gro_listaLaboratorioEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_listaLaboratorioEditar.ForeColor = System.Drawing.Color.White
        Me.gro_listaLaboratorioEditar.Location = New System.Drawing.Point(12, 237)
        Me.gro_listaLaboratorioEditar.Name = "gro_listaLaboratorioEditar"
        Me.gro_listaLaboratorioEditar.Size = New System.Drawing.Size(414, 148)
        Me.gro_listaLaboratorioEditar.TabIndex = 9
        Me.gro_listaLaboratorioEditar.TabStop = False
        Me.gro_listaLaboratorioEditar.Text = "Lista de laboratorios"
        '
        'dgv_listaLaboratoriosEditar
        '
        Me.dgv_listaLaboratoriosEditar.AllowUserToAddRows = False
        Me.dgv_listaLaboratoriosEditar.AllowUserToDeleteRows = False
        Me.dgv_listaLaboratoriosEditar.AllowUserToResizeColumns = False
        Me.dgv_listaLaboratoriosEditar.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listaLaboratoriosEditar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listaLaboratoriosEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaLaboratoriosEditar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idLaboratorio, Me.col_razonSocial, Me.col_direccion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listaLaboratoriosEditar.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_listaLaboratoriosEditar.GridColor = System.Drawing.SystemColors.Desktop
        Me.dgv_listaLaboratoriosEditar.Location = New System.Drawing.Point(8, 25)
        Me.dgv_listaLaboratoriosEditar.Name = "dgv_listaLaboratoriosEditar"
        Me.dgv_listaLaboratoriosEditar.ReadOnly = True
        Me.dgv_listaLaboratoriosEditar.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgv_listaLaboratoriosEditar.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_listaLaboratoriosEditar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaLaboratoriosEditar.Size = New System.Drawing.Size(406, 117)
        Me.dgv_listaLaboratoriosEditar.TabIndex = 6
        '
        'col_idLaboratorio
        '
        Me.col_idLaboratorio.FillWeight = 49.66922!
        Me.col_idLaboratorio.HeaderText = "ID"
        Me.col_idLaboratorio.Name = "col_idLaboratorio"
        Me.col_idLaboratorio.ReadOnly = True
        Me.col_idLaboratorio.Width = 67
        '
        'col_razonSocial
        '
        Me.col_razonSocial.FillWeight = 123.9348!
        Me.col_razonSocial.HeaderText = "Razon Social"
        Me.col_razonSocial.Name = "col_razonSocial"
        Me.col_razonSocial.ReadOnly = True
        Me.col_razonSocial.Width = 166
        '
        'col_direccion
        '
        Me.col_direccion.FillWeight = 126.3959!
        Me.col_direccion.HeaderText = "Direccion"
        Me.col_direccion.Name = "col_direccion"
        Me.col_direccion.ReadOnly = True
        Me.col_direccion.Width = 170
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Iconshock_Vista_General_Trash
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Location = New System.Drawing.Point(280, 384)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(47, 34)
        Me.btn_eliminar.TabIndex = 7
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_salirEditar
        '
        Me.btn_salirEditar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirEditar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salirEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salirEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirEditar.Location = New System.Drawing.Point(368, 384)
        Me.btn_salirEditar.Name = "btn_salirEditar"
        Me.btn_salirEditar.Size = New System.Drawing.Size(52, 30)
        Me.btn_salirEditar.TabIndex = 8
        Me.btn_salirEditar.UseVisualStyleBackColor = False
        '
        'frm_editarLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.editar_laboratorio1
        Me.ClientSize = New System.Drawing.Size(447, 417)
        Me.Controls.Add(Me.btn_salirEditar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.gro_listaLaboratorioEditar)
        Me.Controls.Add(Me.gro_datosLaboratorioEditar)
        Me.Controls.Add(Me.gro_buscaLaboratorioEditar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_editarLaboratorio"
        Me.Text = ".:. Editar Laboratorios .:."
        Me.gro_buscaLaboratorioEditar.ResumeLayout(False)
        Me.gro_buscaLaboratorioEditar.PerformLayout()
        Me.gro_datosLaboratorioEditar.ResumeLayout(False)
        Me.gro_datosLaboratorioEditar.PerformLayout()
        Me.gro_listaLaboratorioEditar.ResumeLayout(False)
        CType(Me.dgv_listaLaboratoriosEditar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gro_buscaLaboratorioEditar As System.Windows.Forms.GroupBox
    Friend WithEvents txt_buscarLaboratorioEditar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_buscarEditar As System.Windows.Forms.Label
    Friend WithEvents gro_datosLaboratorioEditar As System.Windows.Forms.GroupBox
    Friend WithEvents txt_direccionEditar As System.Windows.Forms.TextBox
    Friend WithEvents txt_razonSocialEditar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_direccionLaboratorioEditar As System.Windows.Forms.Label
    Friend WithEvents lbl_razonSocialEditar As System.Windows.Forms.Label
    Friend WithEvents gro_listaLaboratorioEditar As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_listaLaboratoriosEditar As System.Windows.Forms.DataGridView
    Friend WithEvents btn_guardarLaboratorioEditar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_salirEditar As System.Windows.Forms.Button
    Friend WithEvents btn_buscarLaboratorio As System.Windows.Forms.Button
    Friend WithEvents lbl_idLaboratorioEditar As System.Windows.Forms.Label
    Friend WithEvents txt_idLaboratorioEditar As System.Windows.Forms.TextBox
    Friend WithEvents col_idLaboratorio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_razonSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_direccion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
