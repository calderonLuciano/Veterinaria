<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cargaSintoma
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
        Me.btn_salirSintoma = New System.Windows.Forms.Button()
        Me.btn_guardarSintoma = New System.Windows.Forms.Button()
        Me.gro_listaSintomas = New System.Windows.Forms.GroupBox()
        Me.dgv_listaSintomas = New System.Windows.Forms.DataGridView()
        Me.col_idSintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcionSintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gro_datosSintoma = New System.Windows.Forms.GroupBox()
        Me.btn_agregarSintoma = New System.Windows.Forms.Button()
        Me.txt_descripcionSintoma = New System.Windows.Forms.TextBox()
        Me.txt_idSintoma = New System.Windows.Forms.TextBox()
        Me.lbl_descripcionSintoma = New System.Windows.Forms.Label()
        Me.lbl_idSintoma = New System.Windows.Forms.Label()
        Me.gro_listaSintomas.SuspendLayout()
        CType(Me.dgv_listaSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gro_datosSintoma.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salirSintoma
        '
        Me.btn_salirSintoma.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirSintoma.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salirSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salirSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirSintoma.Location = New System.Drawing.Point(475, 310)
        Me.btn_salirSintoma.Name = "btn_salirSintoma"
        Me.btn_salirSintoma.Size = New System.Drawing.Size(51, 30)
        Me.btn_salirSintoma.TabIndex = 9
        Me.btn_salirSintoma.UseVisualStyleBackColor = False
        '
        'btn_guardarSintoma
        '
        Me.btn_guardarSintoma.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardarSintoma.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarSintoma.Location = New System.Drawing.Point(404, 310)
        Me.btn_guardarSintoma.Name = "btn_guardarSintoma"
        Me.btn_guardarSintoma.Size = New System.Drawing.Size(51, 30)
        Me.btn_guardarSintoma.TabIndex = 10
        Me.btn_guardarSintoma.UseVisualStyleBackColor = False
        '
        'gro_listaSintomas
        '
        Me.gro_listaSintomas.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaSintomas.Controls.Add(Me.dgv_listaSintomas)
        Me.gro_listaSintomas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_listaSintomas.ForeColor = System.Drawing.Color.White
        Me.gro_listaSintomas.Location = New System.Drawing.Point(4, 202)
        Me.gro_listaSintomas.Name = "gro_listaSintomas"
        Me.gro_listaSintomas.Size = New System.Drawing.Size(540, 102)
        Me.gro_listaSintomas.TabIndex = 8
        Me.gro_listaSintomas.TabStop = False
        Me.gro_listaSintomas.Text = "Lista de Sintomas"
        '
        'dgv_listaSintomas
        '
        Me.dgv_listaSintomas.AllowUserToAddRows = False
        Me.dgv_listaSintomas.AllowUserToDeleteRows = False
        Me.dgv_listaSintomas.AllowUserToResizeColumns = False
        Me.dgv_listaSintomas.AllowUserToResizeRows = False
        Me.dgv_listaSintomas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgv_listaSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idSintoma, Me.col_descripcionSintoma})
        Me.dgv_listaSintomas.Location = New System.Drawing.Point(8, 23)
        Me.dgv_listaSintomas.MultiSelect = False
        Me.dgv_listaSintomas.Name = "dgv_listaSintomas"
        Me.dgv_listaSintomas.ReadOnly = True
        Me.dgv_listaSintomas.RowHeadersVisible = False
        Me.dgv_listaSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaSintomas.Size = New System.Drawing.Size(526, 67)
        Me.dgv_listaSintomas.TabIndex = 0
        '
        'col_idSintoma
        '
        Me.col_idSintoma.HeaderText = "ID"
        Me.col_idSintoma.Name = "col_idSintoma"
        Me.col_idSintoma.ReadOnly = True
        Me.col_idSintoma.Width = 50
        '
        'col_descripcionSintoma
        '
        Me.col_descripcionSintoma.HeaderText = "Sintoma"
        Me.col_descripcionSintoma.Name = "col_descripcionSintoma"
        Me.col_descripcionSintoma.ReadOnly = True
        Me.col_descripcionSintoma.Width = 470
        '
        'gro_datosSintoma
        '
        Me.gro_datosSintoma.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosSintoma.Controls.Add(Me.btn_agregarSintoma)
        Me.gro_datosSintoma.Controls.Add(Me.txt_descripcionSintoma)
        Me.gro_datosSintoma.Controls.Add(Me.txt_idSintoma)
        Me.gro_datosSintoma.Controls.Add(Me.lbl_descripcionSintoma)
        Me.gro_datosSintoma.Controls.Add(Me.lbl_idSintoma)
        Me.gro_datosSintoma.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosSintoma.ForeColor = System.Drawing.Color.White
        Me.gro_datosSintoma.Location = New System.Drawing.Point(4, 48)
        Me.gro_datosSintoma.Name = "gro_datosSintoma"
        Me.gro_datosSintoma.Size = New System.Drawing.Size(534, 148)
        Me.gro_datosSintoma.TabIndex = 7
        Me.gro_datosSintoma.TabStop = False
        Me.gro_datosSintoma.Text = "Datos Sintoma"
        '
        'btn_agregarSintoma
        '
        Me.btn_agregarSintoma.BackgroundImage = Global.Veterinaria.My.Resources.Resources.add
        Me.btn_agregarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregarSintoma.Location = New System.Drawing.Point(465, 96)
        Me.btn_agregarSintoma.Name = "btn_agregarSintoma"
        Me.btn_agregarSintoma.Size = New System.Drawing.Size(57, 33)
        Me.btn_agregarSintoma.TabIndex = 4
        Me.btn_agregarSintoma.UseVisualStyleBackColor = True
        '
        'txt_descripcionSintoma
        '
        Me.txt_descripcionSintoma.Location = New System.Drawing.Point(95, 50)
        Me.txt_descripcionSintoma.MaxLength = 100
        Me.txt_descripcionSintoma.Multiline = True
        Me.txt_descripcionSintoma.Name = "txt_descripcionSintoma"
        Me.txt_descripcionSintoma.Size = New System.Drawing.Size(356, 92)
        Me.txt_descripcionSintoma.TabIndex = 3
        '
        'txt_idSintoma
        '
        Me.txt_idSintoma.Enabled = False
        Me.txt_idSintoma.Location = New System.Drawing.Point(95, 17)
        Me.txt_idSintoma.Name = "txt_idSintoma"
        Me.txt_idSintoma.Size = New System.Drawing.Size(113, 23)
        Me.txt_idSintoma.TabIndex = 2
        '
        'lbl_descripcionSintoma
        '
        Me.lbl_descripcionSintoma.AutoSize = True
        Me.lbl_descripcionSintoma.Location = New System.Drawing.Point(24, 53)
        Me.lbl_descripcionSintoma.Name = "lbl_descripcionSintoma"
        Me.lbl_descripcionSintoma.Size = New System.Drawing.Size(65, 16)
        Me.lbl_descripcionSintoma.TabIndex = 1
        Me.lbl_descripcionSintoma.Text = "Sintoma:"
        '
        'lbl_idSintoma
        '
        Me.lbl_idSintoma.AutoSize = True
        Me.lbl_idSintoma.Enabled = False
        Me.lbl_idSintoma.Location = New System.Drawing.Point(64, 24)
        Me.lbl_idSintoma.Name = "lbl_idSintoma"
        Me.lbl_idSintoma.Size = New System.Drawing.Size(25, 16)
        Me.lbl_idSintoma.TabIndex = 0
        Me.lbl_idSintoma.Text = "ID:"
        '
        'frm_cargaSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.registrar_sintoma
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(556, 347)
        Me.Controls.Add(Me.btn_salirSintoma)
        Me.Controls.Add(Me.btn_guardarSintoma)
        Me.Controls.Add(Me.gro_listaSintomas)
        Me.Controls.Add(Me.gro_datosSintoma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cargaSintoma"
        Me.Text = "frm_cargaSintoma"
        Me.gro_listaSintomas.ResumeLayout(False)
        CType(Me.dgv_listaSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gro_datosSintoma.ResumeLayout(False)
        Me.gro_datosSintoma.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_salirSintoma As System.Windows.Forms.Button
    Friend WithEvents btn_guardarSintoma As System.Windows.Forms.Button
    Friend WithEvents gro_listaSintomas As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_listaSintomas As System.Windows.Forms.DataGridView
    Friend WithEvents gro_datosSintoma As System.Windows.Forms.GroupBox
    Friend WithEvents btn_agregarSintoma As System.Windows.Forms.Button
    Friend WithEvents txt_descripcionSintoma As System.Windows.Forms.TextBox
    Friend WithEvents txt_idSintoma As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcionSintoma As System.Windows.Forms.Label
    Friend WithEvents lbl_idSintoma As System.Windows.Forms.Label
    Friend WithEvents col_idSintoma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcionSintoma As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
