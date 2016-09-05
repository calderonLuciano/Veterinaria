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
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_fechanac = New System.Windows.Forms.Label()
        Me.lbl_fechaing = New System.Windows.Forms.Label()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.lbl_tipdoc = New System.Windows.Forms.Label()
        Me.lbl_numdoc = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lbl_foto = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pcb_fotoEmpleado = New System.Windows.Forms.PictureBox()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pcb_fotoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(79, 27)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(79, 53)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido:"
        '
        'lbl_fechanac
        '
        Me.lbl_fechanac.AutoSize = True
        Me.lbl_fechanac.Location = New System.Drawing.Point(17, 129)
        Me.lbl_fechanac.Name = "lbl_fechanac"
        Me.lbl_fechanac.Size = New System.Drawing.Size(109, 13)
        Me.lbl_fechanac.TabIndex = 2
        Me.lbl_fechanac.Text = "Fecha de nacimiento:"
        '
        'lbl_fechaing
        '
        Me.lbl_fechaing.AutoSize = True
        Me.lbl_fechaing.Location = New System.Drawing.Point(34, 160)
        Me.lbl_fechaing.Name = "lbl_fechaing"
        Me.lbl_fechaing.Size = New System.Drawing.Size(92, 13)
        Me.lbl_fechaing.TabIndex = 3
        Me.lbl_fechaing.Text = "Fecha de ingreso:"
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Location = New System.Drawing.Point(73, 185)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(53, 13)
        Me.lbl_matricula.TabIndex = 4
        Me.lbl_matricula.Text = "Matricula:"
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Location = New System.Drawing.Point(73, 213)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(51, 13)
        Me.lbl_sucursal.TabIndex = 5
        Me.lbl_sucursal.Text = "Sucursal:"
        '
        'lbl_tipdoc
        '
        Me.lbl_tipdoc.AutoSize = True
        Me.lbl_tipdoc.Location = New System.Drawing.Point(39, 79)
        Me.lbl_tipdoc.Name = "lbl_tipdoc"
        Me.lbl_tipdoc.Size = New System.Drawing.Size(87, 13)
        Me.lbl_tipdoc.TabIndex = 6
        Me.lbl_tipdoc.Text = "Tipo documento:"
        '
        'lbl_numdoc
        '
        Me.lbl_numdoc.AutoSize = True
        Me.lbl_numdoc.Location = New System.Drawing.Point(8, 107)
        Me.lbl_numdoc.Name = "lbl_numdoc"
        Me.lbl_numdoc.Size = New System.Drawing.Size(118, 13)
        Me.lbl_numdoc.TabIndex = 7
        Me.lbl_numdoc.Text = "Numero de documento:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(150, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(150, 205)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(150, 155)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(150, 179)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(150, 46)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(150, 20)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(150, 100)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 15
        '
        'lbl_foto
        '
        Me.lbl_foto.AutoSize = True
        Me.lbl_foto.Location = New System.Drawing.Point(18, 29)
        Me.lbl_foto.Name = "lbl_foto"
        Me.lbl_foto.Size = New System.Drawing.Size(31, 13)
        Me.lbl_foto.TabIndex = 17
        Me.lbl_foto.Text = "Foto:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(187, 287)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 19
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido)
        Me.GroupBox1.Controls.Add(Me.lbl_fechanac)
        Me.GroupBox1.Controls.Add(Me.lbl_fechaing)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.lbl_matricula)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.lbl_sucursal)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.lbl_tipdoc)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.lbl_numdoc)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 254)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Obligatorios"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pcb_fotoEmpleado)
        Me.GroupBox2.Controls.Add(Me.lbl_foto)
        Me.GroupBox2.Location = New System.Drawing.Point(314, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 254)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Opcionales"
        '
        'pcb_fotoEmpleado
        '
        Me.pcb_fotoEmpleado.Image = Global.Veterinaria.My.Resources.Resources.users
        Me.pcb_fotoEmpleado.Location = New System.Drawing.Point(21, 45)
        Me.pcb_fotoEmpleado.Name = "pcb_fotoEmpleado"
        Me.pcb_fotoEmpleado.Size = New System.Drawing.Size(90, 91)
        Me.pcb_fotoEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_fotoEmpleado.TabIndex = 16
        Me.pcb_fotoEmpleado.TabStop = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(54, 286)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(65, 24)
        Me.btn_Aceptar.TabIndex = 18
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'frm_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(479, 325)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Name = "frm_empleado"
        Me.Text = "frm_empleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pcb_fotoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_fechanac As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaing As System.Windows.Forms.Label
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents lbl_sucursal As System.Windows.Forms.Label
    Friend WithEvents lbl_tipdoc As System.Windows.Forms.Label
    Friend WithEvents lbl_numdoc As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents pcb_fotoEmpleado As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_foto As System.Windows.Forms.Label
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
