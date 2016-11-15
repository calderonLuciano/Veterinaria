<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cargaDiagnostico
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
        Me.gro_datosDiagnostico = New System.Windows.Forms.GroupBox()
        Me.btn_agregarDiagnostico = New System.Windows.Forms.Button()
        Me.txt_descripcionDiagnostico = New System.Windows.Forms.TextBox()
        Me.txt_idDiagnostico = New System.Windows.Forms.TextBox()
        Me.lbl_descripcionDiagnostico = New System.Windows.Forms.Label()
        Me.lbl_idDiagnostico = New System.Windows.Forms.Label()
        Me.gro_listaDiagnosticos = New System.Windows.Forms.GroupBox()
        Me.dgv_listaDiagnosticos = New System.Windows.Forms.DataGridView()
        Me.col_idDiagnostico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcionDiagnostico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_salirDiagnostico = New System.Windows.Forms.Button()
        Me.btn_guardarDiagnostico = New System.Windows.Forms.Button()
        Me.gro_datosDiagnostico.SuspendLayout()
        Me.gro_listaDiagnosticos.SuspendLayout()
        CType(Me.dgv_listaDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gro_datosDiagnostico
        '
        Me.gro_datosDiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosDiagnostico.Controls.Add(Me.btn_agregarDiagnostico)
        Me.gro_datosDiagnostico.Controls.Add(Me.txt_descripcionDiagnostico)
        Me.gro_datosDiagnostico.Controls.Add(Me.txt_idDiagnostico)
        Me.gro_datosDiagnostico.Controls.Add(Me.lbl_descripcionDiagnostico)
        Me.gro_datosDiagnostico.Controls.Add(Me.lbl_idDiagnostico)
        Me.gro_datosDiagnostico.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosDiagnostico.ForeColor = System.Drawing.Color.White
        Me.gro_datosDiagnostico.Location = New System.Drawing.Point(12, 49)
        Me.gro_datosDiagnostico.Name = "gro_datosDiagnostico"
        Me.gro_datosDiagnostico.Size = New System.Drawing.Size(488, 124)
        Me.gro_datosDiagnostico.TabIndex = 0
        Me.gro_datosDiagnostico.TabStop = False
        Me.gro_datosDiagnostico.Text = "Datos Diagnostico"
        '
        'btn_agregarDiagnostico
        '
        Me.btn_agregarDiagnostico.BackgroundImage = Global.Veterinaria.My.Resources.Resources.add
        Me.btn_agregarDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregarDiagnostico.Location = New System.Drawing.Point(433, 80)
        Me.btn_agregarDiagnostico.Name = "btn_agregarDiagnostico"
        Me.btn_agregarDiagnostico.Size = New System.Drawing.Size(49, 38)
        Me.btn_agregarDiagnostico.TabIndex = 4
        Me.btn_agregarDiagnostico.UseVisualStyleBackColor = True
        '
        'txt_descripcionDiagnostico
        '
        Me.txt_descripcionDiagnostico.Location = New System.Drawing.Point(95, 51)
        Me.txt_descripcionDiagnostico.MaxLength = 100
        Me.txt_descripcionDiagnostico.Multiline = True
        Me.txt_descripcionDiagnostico.Name = "txt_descripcionDiagnostico"
        Me.txt_descripcionDiagnostico.Size = New System.Drawing.Size(323, 67)
        Me.txt_descripcionDiagnostico.TabIndex = 3
        '
        'txt_idDiagnostico
        '
        Me.txt_idDiagnostico.Location = New System.Drawing.Point(95, 21)
        Me.txt_idDiagnostico.Name = "txt_idDiagnostico"
        Me.txt_idDiagnostico.Size = New System.Drawing.Size(135, 23)
        Me.txt_idDiagnostico.TabIndex = 2
        '
        'lbl_descripcionDiagnostico
        '
        Me.lbl_descripcionDiagnostico.AutoSize = True
        Me.lbl_descripcionDiagnostico.Location = New System.Drawing.Point(6, 53)
        Me.lbl_descripcionDiagnostico.Name = "lbl_descripcionDiagnostico"
        Me.lbl_descripcionDiagnostico.Size = New System.Drawing.Size(87, 16)
        Me.lbl_descripcionDiagnostico.TabIndex = 1
        Me.lbl_descripcionDiagnostico.Text = "Descripción:"
        '
        'lbl_idDiagnostico
        '
        Me.lbl_idDiagnostico.AutoSize = True
        Me.lbl_idDiagnostico.Enabled = False
        Me.lbl_idDiagnostico.Location = New System.Drawing.Point(64, 24)
        Me.lbl_idDiagnostico.Name = "lbl_idDiagnostico"
        Me.lbl_idDiagnostico.Size = New System.Drawing.Size(25, 16)
        Me.lbl_idDiagnostico.TabIndex = 0
        Me.lbl_idDiagnostico.Text = "ID:"
        '
        'gro_listaDiagnosticos
        '
        Me.gro_listaDiagnosticos.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaDiagnosticos.Controls.Add(Me.dgv_listaDiagnosticos)
        Me.gro_listaDiagnosticos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_listaDiagnosticos.ForeColor = System.Drawing.Color.White
        Me.gro_listaDiagnosticos.Location = New System.Drawing.Point(12, 179)
        Me.gro_listaDiagnosticos.Name = "gro_listaDiagnosticos"
        Me.gro_listaDiagnosticos.Size = New System.Drawing.Size(494, 132)
        Me.gro_listaDiagnosticos.TabIndex = 1
        Me.gro_listaDiagnosticos.TabStop = False
        Me.gro_listaDiagnosticos.Text = "Lista de Diagnosticos"
        '
        'dgv_listaDiagnosticos
        '
        Me.dgv_listaDiagnosticos.AllowUserToAddRows = False
        Me.dgv_listaDiagnosticos.AllowUserToDeleteRows = False
        Me.dgv_listaDiagnosticos.AllowUserToResizeColumns = False
        Me.dgv_listaDiagnosticos.AllowUserToResizeRows = False
        Me.dgv_listaDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaDiagnosticos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idDiagnostico, Me.col_descripcionDiagnostico})
        Me.dgv_listaDiagnosticos.Location = New System.Drawing.Point(6, 22)
        Me.dgv_listaDiagnosticos.MultiSelect = False
        Me.dgv_listaDiagnosticos.Name = "dgv_listaDiagnosticos"
        Me.dgv_listaDiagnosticos.ReadOnly = True
        Me.dgv_listaDiagnosticos.RowHeadersVisible = False
        Me.dgv_listaDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaDiagnosticos.Size = New System.Drawing.Size(479, 102)
        Me.dgv_listaDiagnosticos.TabIndex = 0
        '
        'col_idDiagnostico
        '
        Me.col_idDiagnostico.HeaderText = "ID"
        Me.col_idDiagnostico.Name = "col_idDiagnostico"
        Me.col_idDiagnostico.ReadOnly = True
        Me.col_idDiagnostico.Width = 50
        '
        'col_descripcionDiagnostico
        '
        Me.col_descripcionDiagnostico.HeaderText = "Descripcion"
        Me.col_descripcionDiagnostico.Name = "col_descripcionDiagnostico"
        Me.col_descripcionDiagnostico.ReadOnly = True
        Me.col_descripcionDiagnostico.Width = 400
        '
        'btn_salirDiagnostico
        '
        Me.btn_salirDiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirDiagnostico.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salirDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salirDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirDiagnostico.Location = New System.Drawing.Point(457, 317)
        Me.btn_salirDiagnostico.Name = "btn_salirDiagnostico"
        Me.btn_salirDiagnostico.Size = New System.Drawing.Size(49, 30)
        Me.btn_salirDiagnostico.TabIndex = 5
        Me.btn_salirDiagnostico.UseVisualStyleBackColor = False
        '
        'btn_guardarDiagnostico
        '
        Me.btn_guardarDiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardarDiagnostico.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarDiagnostico.Location = New System.Drawing.Point(391, 317)
        Me.btn_guardarDiagnostico.Name = "btn_guardarDiagnostico"
        Me.btn_guardarDiagnostico.Size = New System.Drawing.Size(54, 30)
        Me.btn_guardarDiagnostico.TabIndex = 6
        Me.btn_guardarDiagnostico.UseVisualStyleBackColor = False
        '
        'frm_cargaDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Registrar_diagnostico
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(518, 359)
        Me.Controls.Add(Me.btn_salirDiagnostico)
        Me.Controls.Add(Me.btn_guardarDiagnostico)
        Me.Controls.Add(Me.gro_listaDiagnosticos)
        Me.Controls.Add(Me.gro_datosDiagnostico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cargaDiagnostico"
        Me.Text = "frm_cargaDiagnostico"
        Me.gro_datosDiagnostico.ResumeLayout(False)
        Me.gro_datosDiagnostico.PerformLayout()
        Me.gro_listaDiagnosticos.ResumeLayout(False)
        CType(Me.dgv_listaDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gro_datosDiagnostico As System.Windows.Forms.GroupBox
    Friend WithEvents btn_agregarDiagnostico As System.Windows.Forms.Button
    Friend WithEvents txt_descripcionDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents txt_idDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcionDiagnostico As System.Windows.Forms.Label
    Friend WithEvents lbl_idDiagnostico As System.Windows.Forms.Label
    Friend WithEvents gro_listaDiagnosticos As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_listaDiagnosticos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_salirDiagnostico As System.Windows.Forms.Button
    Friend WithEvents btn_guardarDiagnostico As System.Windows.Forms.Button
    Friend WithEvents col_idDiagnostico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcionDiagnostico As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
