<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editarDiagnostico
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
        Me.gro_buscarDiagnostico = New System.Windows.Forms.GroupBox()
        Me.btn_buscarDiagnostico = New System.Windows.Forms.Button()
        Me.txt_buscarDiagnostico = New System.Windows.Forms.TextBox()
        Me.lbl_buscar = New System.Windows.Forms.Label()
        Me.gro_datosDiagnosticoEditar = New System.Windows.Forms.GroupBox()
        Me.btn_guardarDiagnosticoEditar = New System.Windows.Forms.Button()
        Me.lbl_idDiagnostico = New System.Windows.Forms.Label()
        Me.txt_descripcionDiagnosticoEditar = New System.Windows.Forms.TextBox()
        Me.lbl_descripcionDiagnostico = New System.Windows.Forms.Label()
        Me.txt_idDiagnosticoEditar = New System.Windows.Forms.TextBox()
        Me.gro_listaDiagnosticosEditar = New System.Windows.Forms.GroupBox()
        Me.dgv_listaDiagnosticosEditar = New System.Windows.Forms.DataGridView()
        Me.col_idDiagnosticoEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcionDiagnosticoEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salirEditar = New System.Windows.Forms.Button()
        Me.gro_buscarDiagnostico.SuspendLayout()
        Me.gro_datosDiagnosticoEditar.SuspendLayout()
        Me.gro_listaDiagnosticosEditar.SuspendLayout()
        CType(Me.dgv_listaDiagnosticosEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gro_buscarDiagnostico
        '
        Me.gro_buscarDiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.gro_buscarDiagnostico.Controls.Add(Me.btn_buscarDiagnostico)
        Me.gro_buscarDiagnostico.Controls.Add(Me.txt_buscarDiagnostico)
        Me.gro_buscarDiagnostico.Controls.Add(Me.lbl_buscar)
        Me.gro_buscarDiagnostico.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_buscarDiagnostico.ForeColor = System.Drawing.Color.White
        Me.gro_buscarDiagnostico.Location = New System.Drawing.Point(16, 50)
        Me.gro_buscarDiagnostico.Name = "gro_buscarDiagnostico"
        Me.gro_buscarDiagnostico.Size = New System.Drawing.Size(532, 61)
        Me.gro_buscarDiagnostico.TabIndex = 0
        Me.gro_buscarDiagnostico.TabStop = False
        Me.gro_buscarDiagnostico.Text = "Buscar Diagnostico"
        '
        'btn_buscarDiagnostico
        '
        Me.btn_buscarDiagnostico.BackgroundImage = Global.Veterinaria.My.Resources.Resources.find
        Me.btn_buscarDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_buscarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarDiagnostico.Location = New System.Drawing.Point(281, 18)
        Me.btn_buscarDiagnostico.Name = "btn_buscarDiagnostico"
        Me.btn_buscarDiagnostico.Size = New System.Drawing.Size(56, 31)
        Me.btn_buscarDiagnostico.TabIndex = 2
        Me.btn_buscarDiagnostico.UseVisualStyleBackColor = True
        '
        'txt_buscarDiagnostico
        '
        Me.txt_buscarDiagnostico.Location = New System.Drawing.Point(108, 26)
        Me.txt_buscarDiagnostico.Name = "txt_buscarDiagnostico"
        Me.txt_buscarDiagnostico.Size = New System.Drawing.Size(154, 23)
        Me.txt_buscarDiagnostico.TabIndex = 1
        '
        'lbl_buscar
        '
        Me.lbl_buscar.AutoSize = True
        Me.lbl_buscar.Location = New System.Drawing.Point(49, 29)
        Me.lbl_buscar.Name = "lbl_buscar"
        Me.lbl_buscar.Size = New System.Drawing.Size(53, 16)
        Me.lbl_buscar.TabIndex = 0
        Me.lbl_buscar.Text = "Buscar:"
        '
        'gro_datosDiagnosticoEditar
        '
        Me.gro_datosDiagnosticoEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosDiagnosticoEditar.Controls.Add(Me.btn_guardarDiagnosticoEditar)
        Me.gro_datosDiagnosticoEditar.Controls.Add(Me.lbl_idDiagnostico)
        Me.gro_datosDiagnosticoEditar.Controls.Add(Me.txt_descripcionDiagnosticoEditar)
        Me.gro_datosDiagnosticoEditar.Controls.Add(Me.lbl_descripcionDiagnostico)
        Me.gro_datosDiagnosticoEditar.Controls.Add(Me.txt_idDiagnosticoEditar)
        Me.gro_datosDiagnosticoEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosDiagnosticoEditar.ForeColor = System.Drawing.Color.White
        Me.gro_datosDiagnosticoEditar.Location = New System.Drawing.Point(16, 117)
        Me.gro_datosDiagnosticoEditar.Name = "gro_datosDiagnosticoEditar"
        Me.gro_datosDiagnosticoEditar.Size = New System.Drawing.Size(532, 146)
        Me.gro_datosDiagnosticoEditar.TabIndex = 1
        Me.gro_datosDiagnosticoEditar.TabStop = False
        Me.gro_datosDiagnosticoEditar.Text = "Datos de Diagnosticos"
        '
        'btn_guardarDiagnosticoEditar
        '
        Me.btn_guardarDiagnosticoEditar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarDiagnosticoEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardarDiagnosticoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarDiagnosticoEditar.Location = New System.Drawing.Point(470, 110)
        Me.btn_guardarDiagnosticoEditar.Name = "btn_guardarDiagnosticoEditar"
        Me.btn_guardarDiagnosticoEditar.Size = New System.Drawing.Size(56, 30)
        Me.btn_guardarDiagnosticoEditar.TabIndex = 9
        Me.btn_guardarDiagnosticoEditar.UseVisualStyleBackColor = True
        '
        'lbl_idDiagnostico
        '
        Me.lbl_idDiagnostico.AutoSize = True
        Me.lbl_idDiagnostico.Enabled = False
        Me.lbl_idDiagnostico.Location = New System.Drawing.Point(77, 33)
        Me.lbl_idDiagnostico.Name = "lbl_idDiagnostico"
        Me.lbl_idDiagnostico.Size = New System.Drawing.Size(25, 16)
        Me.lbl_idDiagnostico.TabIndex = 5
        Me.lbl_idDiagnostico.Text = "ID:"
        '
        'txt_descripcionDiagnosticoEditar
        '
        Me.txt_descripcionDiagnosticoEditar.Location = New System.Drawing.Point(108, 56)
        Me.txt_descripcionDiagnosticoEditar.MaxLength = 100
        Me.txt_descripcionDiagnosticoEditar.Multiline = True
        Me.txt_descripcionDiagnosticoEditar.Name = "txt_descripcionDiagnosticoEditar"
        Me.txt_descripcionDiagnosticoEditar.Size = New System.Drawing.Size(346, 84)
        Me.txt_descripcionDiagnosticoEditar.TabIndex = 8
        '
        'lbl_descripcionDiagnostico
        '
        Me.lbl_descripcionDiagnostico.AutoSize = True
        Me.lbl_descripcionDiagnostico.Location = New System.Drawing.Point(19, 59)
        Me.lbl_descripcionDiagnostico.Name = "lbl_descripcionDiagnostico"
        Me.lbl_descripcionDiagnostico.Size = New System.Drawing.Size(87, 16)
        Me.lbl_descripcionDiagnostico.TabIndex = 6
        Me.lbl_descripcionDiagnostico.Text = "Descripción:"
        '
        'txt_idDiagnosticoEditar
        '
        Me.txt_idDiagnosticoEditar.Location = New System.Drawing.Point(108, 30)
        Me.txt_idDiagnosticoEditar.Name = "txt_idDiagnosticoEditar"
        Me.txt_idDiagnosticoEditar.Size = New System.Drawing.Size(154, 23)
        Me.txt_idDiagnosticoEditar.TabIndex = 7
        '
        'gro_listaDiagnosticosEditar
        '
        Me.gro_listaDiagnosticosEditar.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaDiagnosticosEditar.Controls.Add(Me.dgv_listaDiagnosticosEditar)
        Me.gro_listaDiagnosticosEditar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gro_listaDiagnosticosEditar.Location = New System.Drawing.Point(16, 269)
        Me.gro_listaDiagnosticosEditar.Name = "gro_listaDiagnosticosEditar"
        Me.gro_listaDiagnosticosEditar.Size = New System.Drawing.Size(532, 93)
        Me.gro_listaDiagnosticosEditar.TabIndex = 1
        Me.gro_listaDiagnosticosEditar.TabStop = False
        Me.gro_listaDiagnosticosEditar.Text = "Lista de Diagnosticos"
        '
        'dgv_listaDiagnosticosEditar
        '
        Me.dgv_listaDiagnosticosEditar.AllowUserToAddRows = False
        Me.dgv_listaDiagnosticosEditar.AllowUserToDeleteRows = False
        Me.dgv_listaDiagnosticosEditar.AllowUserToResizeColumns = False
        Me.dgv_listaDiagnosticosEditar.AllowUserToResizeRows = False
        Me.dgv_listaDiagnosticosEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaDiagnosticosEditar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idDiagnosticoEditar, Me.col_descripcionDiagnosticoEditar})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listaDiagnosticosEditar.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listaDiagnosticosEditar.Location = New System.Drawing.Point(6, 19)
        Me.dgv_listaDiagnosticosEditar.MultiSelect = False
        Me.dgv_listaDiagnosticosEditar.Name = "dgv_listaDiagnosticosEditar"
        Me.dgv_listaDiagnosticosEditar.ReadOnly = True
        Me.dgv_listaDiagnosticosEditar.RowHeadersVisible = False
        Me.dgv_listaDiagnosticosEditar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaDiagnosticosEditar.Size = New System.Drawing.Size(520, 67)
        Me.dgv_listaDiagnosticosEditar.TabIndex = 10
        '
        'col_idDiagnosticoEditar
        '
        Me.col_idDiagnosticoEditar.HeaderText = "ID"
        Me.col_idDiagnosticoEditar.Name = "col_idDiagnosticoEditar"
        Me.col_idDiagnosticoEditar.ReadOnly = True
        Me.col_idDiagnosticoEditar.Width = 50
        '
        'col_descripcionDiagnosticoEditar
        '
        Me.col_descripcionDiagnosticoEditar.HeaderText = "Descripcion"
        Me.col_descripcionDiagnosticoEditar.Name = "col_descripcionDiagnosticoEditar"
        Me.col_descripcionDiagnosticoEditar.ReadOnly = True
        Me.col_descripcionDiagnosticoEditar.Width = 430
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Iconshock_Vista_General_Trash
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Location = New System.Drawing.Point(408, 368)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(62, 35)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_salirEditar
        '
        Me.btn_salirEditar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirEditar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salirEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salirEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirEditar.Location = New System.Drawing.Point(489, 368)
        Me.btn_salirEditar.Name = "btn_salirEditar"
        Me.btn_salirEditar.Size = New System.Drawing.Size(56, 35)
        Me.btn_salirEditar.TabIndex = 3
        Me.btn_salirEditar.UseVisualStyleBackColor = False
        '
        'frm_editarDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.editar_diagnostico
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(560, 409)
        Me.Controls.Add(Me.btn_salirEditar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.gro_listaDiagnosticosEditar)
        Me.Controls.Add(Me.gro_datosDiagnosticoEditar)
        Me.Controls.Add(Me.gro_buscarDiagnostico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_editarDiagnostico"
        Me.Text = "frm_editarDiagnostico"
        Me.gro_buscarDiagnostico.ResumeLayout(False)
        Me.gro_buscarDiagnostico.PerformLayout()
        Me.gro_datosDiagnosticoEditar.ResumeLayout(False)
        Me.gro_datosDiagnosticoEditar.PerformLayout()
        Me.gro_listaDiagnosticosEditar.ResumeLayout(False)
        CType(Me.dgv_listaDiagnosticosEditar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gro_buscarDiagnostico As System.Windows.Forms.GroupBox
    Friend WithEvents btn_buscarDiagnostico As System.Windows.Forms.Button
    Friend WithEvents txt_buscarDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents lbl_buscar As System.Windows.Forms.Label
    Friend WithEvents gro_datosDiagnosticoEditar As System.Windows.Forms.GroupBox
    Friend WithEvents gro_listaDiagnosticosEditar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardarDiagnosticoEditar As System.Windows.Forms.Button
    Friend WithEvents lbl_idDiagnostico As System.Windows.Forms.Label
    Friend WithEvents txt_descripcionDiagnosticoEditar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcionDiagnostico As System.Windows.Forms.Label
    Friend WithEvents txt_idDiagnosticoEditar As System.Windows.Forms.TextBox
    Friend WithEvents dgv_listaDiagnosticosEditar As System.Windows.Forms.DataGridView
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_salirEditar As System.Windows.Forms.Button
    Friend WithEvents col_idDiagnosticoEditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcionDiagnosticoEditar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
