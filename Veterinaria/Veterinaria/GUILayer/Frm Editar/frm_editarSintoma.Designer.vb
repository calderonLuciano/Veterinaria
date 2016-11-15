<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editarSintoma
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
        Me.btn_salirEditar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.gro_listaSintomasEditar = New System.Windows.Forms.GroupBox()
        Me.dgv_listaSintomasEditar = New System.Windows.Forms.DataGridView()
        Me.col_idSintomaEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcionSintomaEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gro_datosSintomaEditar = New System.Windows.Forms.GroupBox()
        Me.btn_guardarSintomaEditar = New System.Windows.Forms.Button()
        Me.lbl_idSintoma = New System.Windows.Forms.Label()
        Me.txt_descripcionSintomaEditar = New System.Windows.Forms.TextBox()
        Me.lbl_descripcionSintoma = New System.Windows.Forms.Label()
        Me.txt_idSintomaEditar = New System.Windows.Forms.TextBox()
        Me.gro_buscarSintoma = New System.Windows.Forms.GroupBox()
        Me.btn_buscarSintoma = New System.Windows.Forms.Button()
        Me.txt_buscarSintoma = New System.Windows.Forms.TextBox()
        Me.lbl_buscar = New System.Windows.Forms.Label()
        Me.gro_listaSintomasEditar.SuspendLayout()
        CType(Me.dgv_listaSintomasEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gro_datosSintomaEditar.SuspendLayout()
        Me.gro_buscarSintoma.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salirEditar
        '
        Me.btn_salirEditar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirEditar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salirEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salirEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirEditar.Location = New System.Drawing.Point(432, 384)
        Me.btn_salirEditar.Name = "btn_salirEditar"
        Me.btn_salirEditar.Size = New System.Drawing.Size(61, 32)
        Me.btn_salirEditar.TabIndex = 8
        Me.btn_salirEditar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Iconshock_Vista_General_Trash
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Location = New System.Drawing.Point(351, 383)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(57, 33)
        Me.btn_eliminar.TabIndex = 7
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'gro_listaSintomasEditar
        '
        Me.gro_listaSintomasEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaSintomasEditar.Controls.Add(Me.dgv_listaSintomasEditar)
        Me.gro_listaSintomasEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_listaSintomasEditar.ForeColor = System.Drawing.Color.White
        Me.gro_listaSintomasEditar.Location = New System.Drawing.Point(6, 258)
        Me.gro_listaSintomasEditar.Name = "gro_listaSintomasEditar"
        Me.gro_listaSintomasEditar.Size = New System.Drawing.Size(496, 119)
        Me.gro_listaSintomasEditar.TabIndex = 5
        Me.gro_listaSintomasEditar.TabStop = False
        Me.gro_listaSintomasEditar.Text = "Lista de Sintomas"
        '
        'dgv_listaSintomasEditar
        '
        Me.dgv_listaSintomasEditar.AllowUserToAddRows = False
        Me.dgv_listaSintomasEditar.AllowUserToDeleteRows = False
        Me.dgv_listaSintomasEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaSintomasEditar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idSintomaEditar, Me.col_descripcionSintomaEditar})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listaSintomasEditar.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listaSintomasEditar.Location = New System.Drawing.Point(6, 22)
        Me.dgv_listaSintomasEditar.Name = "dgv_listaSintomasEditar"
        Me.dgv_listaSintomasEditar.ReadOnly = True
        Me.dgv_listaSintomasEditar.RowHeadersVisible = False
        Me.dgv_listaSintomasEditar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaSintomasEditar.Size = New System.Drawing.Size(484, 91)
        Me.dgv_listaSintomasEditar.TabIndex = 10
        '
        'col_idSintomaEditar
        '
        Me.col_idSintomaEditar.HeaderText = "ID"
        Me.col_idSintomaEditar.Name = "col_idSintomaEditar"
        Me.col_idSintomaEditar.ReadOnly = True
        Me.col_idSintomaEditar.Width = 50
        '
        'col_descripcionSintomaEditar
        '
        Me.col_descripcionSintomaEditar.HeaderText = "Descripcion"
        Me.col_descripcionSintomaEditar.Name = "col_descripcionSintomaEditar"
        Me.col_descripcionSintomaEditar.ReadOnly = True
        Me.col_descripcionSintomaEditar.Width = 400
        '
        'gro_datosSintomaEditar
        '
        Me.gro_datosSintomaEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosSintomaEditar.Controls.Add(Me.btn_guardarSintomaEditar)
        Me.gro_datosSintomaEditar.Controls.Add(Me.lbl_idSintoma)
        Me.gro_datosSintomaEditar.Controls.Add(Me.txt_descripcionSintomaEditar)
        Me.gro_datosSintomaEditar.Controls.Add(Me.lbl_descripcionSintoma)
        Me.gro_datosSintomaEditar.Controls.Add(Me.txt_idSintomaEditar)
        Me.gro_datosSintomaEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosSintomaEditar.ForeColor = System.Drawing.Color.White
        Me.gro_datosSintomaEditar.Location = New System.Drawing.Point(6, 117)
        Me.gro_datosSintomaEditar.Name = "gro_datosSintomaEditar"
        Me.gro_datosSintomaEditar.Size = New System.Drawing.Size(496, 135)
        Me.gro_datosSintomaEditar.TabIndex = 6
        Me.gro_datosSintomaEditar.TabStop = False
        Me.gro_datosSintomaEditar.Text = "Datos de Diagnosticos"
        '
        'btn_guardarSintomaEditar
        '
        Me.btn_guardarSintomaEditar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarSintomaEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardarSintomaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarSintomaEditar.Location = New System.Drawing.Point(441, 89)
        Me.btn_guardarSintomaEditar.Name = "btn_guardarSintomaEditar"
        Me.btn_guardarSintomaEditar.Size = New System.Drawing.Size(49, 40)
        Me.btn_guardarSintomaEditar.TabIndex = 9
        Me.btn_guardarSintomaEditar.UseVisualStyleBackColor = True
        '
        'lbl_idSintoma
        '
        Me.lbl_idSintoma.AutoSize = True
        Me.lbl_idSintoma.Enabled = False
        Me.lbl_idSintoma.Location = New System.Drawing.Point(93, 16)
        Me.lbl_idSintoma.Name = "lbl_idSintoma"
        Me.lbl_idSintoma.Size = New System.Drawing.Size(25, 16)
        Me.lbl_idSintoma.TabIndex = 5
        Me.lbl_idSintoma.Text = "ID:"
        '
        'txt_descripcionSintomaEditar
        '
        Me.txt_descripcionSintomaEditar.Location = New System.Drawing.Point(124, 42)
        Me.txt_descripcionSintomaEditar.MaxLength = 100
        Me.txt_descripcionSintomaEditar.Multiline = True
        Me.txt_descripcionSintomaEditar.Name = "txt_descripcionSintomaEditar"
        Me.txt_descripcionSintomaEditar.Size = New System.Drawing.Size(311, 87)
        Me.txt_descripcionSintomaEditar.TabIndex = 8
        '
        'lbl_descripcionSintoma
        '
        Me.lbl_descripcionSintoma.AutoSize = True
        Me.lbl_descripcionSintoma.Location = New System.Drawing.Point(31, 45)
        Me.lbl_descripcionSintoma.Name = "lbl_descripcionSintoma"
        Me.lbl_descripcionSintoma.Size = New System.Drawing.Size(87, 16)
        Me.lbl_descripcionSintoma.TabIndex = 6
        Me.lbl_descripcionSintoma.Text = "Descripción:"
        '
        'txt_idSintomaEditar
        '
        Me.txt_idSintomaEditar.Location = New System.Drawing.Point(124, 16)
        Me.txt_idSintomaEditar.Name = "txt_idSintomaEditar"
        Me.txt_idSintomaEditar.Size = New System.Drawing.Size(100, 23)
        Me.txt_idSintomaEditar.TabIndex = 7
        '
        'gro_buscarSintoma
        '
        Me.gro_buscarSintoma.BackColor = System.Drawing.Color.Transparent
        Me.gro_buscarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gro_buscarSintoma.Controls.Add(Me.btn_buscarSintoma)
        Me.gro_buscarSintoma.Controls.Add(Me.txt_buscarSintoma)
        Me.gro_buscarSintoma.Controls.Add(Me.lbl_buscar)
        Me.gro_buscarSintoma.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_buscarSintoma.ForeColor = System.Drawing.Color.White
        Me.gro_buscarSintoma.Location = New System.Drawing.Point(6, 50)
        Me.gro_buscarSintoma.Name = "gro_buscarSintoma"
        Me.gro_buscarSintoma.Size = New System.Drawing.Size(496, 61)
        Me.gro_buscarSintoma.TabIndex = 4
        Me.gro_buscarSintoma.TabStop = False
        Me.gro_buscarSintoma.Text = "Buscar Sintoma"
        '
        'btn_buscarSintoma
        '
        Me.btn_buscarSintoma.BackgroundImage = Global.Veterinaria.My.Resources.Resources.find
        Me.btn_buscarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_buscarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarSintoma.Location = New System.Drawing.Point(432, 18)
        Me.btn_buscarSintoma.Name = "btn_buscarSintoma"
        Me.btn_buscarSintoma.Size = New System.Drawing.Size(55, 37)
        Me.btn_buscarSintoma.TabIndex = 2
        Me.btn_buscarSintoma.UseVisualStyleBackColor = True
        '
        'txt_buscarSintoma
        '
        Me.txt_buscarSintoma.Location = New System.Drawing.Point(124, 25)
        Me.txt_buscarSintoma.Name = "txt_buscarSintoma"
        Me.txt_buscarSintoma.Size = New System.Drawing.Size(100, 23)
        Me.txt_buscarSintoma.TabIndex = 1
        '
        'lbl_buscar
        '
        Me.lbl_buscar.AutoSize = True
        Me.lbl_buscar.Location = New System.Drawing.Point(93, 28)
        Me.lbl_buscar.Name = "lbl_buscar"
        Me.lbl_buscar.Size = New System.Drawing.Size(25, 16)
        Me.lbl_buscar.TabIndex = 0
        Me.lbl_buscar.Text = "ID:"
        '
        'frm_editarSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Editar_sintoma
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(514, 428)
        Me.Controls.Add(Me.btn_salirEditar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.gro_listaSintomasEditar)
        Me.Controls.Add(Me.gro_datosSintomaEditar)
        Me.Controls.Add(Me.gro_buscarSintoma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_editarSintoma"
        Me.Text = "frm_editarSintoma"
        Me.gro_listaSintomasEditar.ResumeLayout(False)
        CType(Me.dgv_listaSintomasEditar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gro_datosSintomaEditar.ResumeLayout(False)
        Me.gro_datosSintomaEditar.PerformLayout()
        Me.gro_buscarSintoma.ResumeLayout(False)
        Me.gro_buscarSintoma.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_salirEditar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents gro_listaSintomasEditar As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_listaSintomasEditar As System.Windows.Forms.DataGridView
    Friend WithEvents gro_datosSintomaEditar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardarSintomaEditar As System.Windows.Forms.Button
    Friend WithEvents lbl_idSintoma As System.Windows.Forms.Label
    Friend WithEvents txt_descripcionSintomaEditar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcionSintoma As System.Windows.Forms.Label
    Friend WithEvents txt_idSintomaEditar As System.Windows.Forms.TextBox
    Friend WithEvents gro_buscarSintoma As System.Windows.Forms.GroupBox
    Friend WithEvents btn_buscarSintoma As System.Windows.Forms.Button
    Friend WithEvents txt_buscarSintoma As System.Windows.Forms.TextBox
    Friend WithEvents lbl_buscar As System.Windows.Forms.Label
    Friend WithEvents col_idSintomaEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcionSintomaEditar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
