<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EliminarConsultarEmpleado
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.dgv_datosEmpleados = New System.Windows.Forms.DataGridView()
        Me.grbox_DatosEmpleados = New System.Windows.Forms.GroupBox()
        Me.btn_buscarEmpleado = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.grbox_buscarEmpleado = New System.Windows.Forms.GroupBox()
        Me.col_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_FechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_datosEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbox_DatosEmpleados.SuspendLayout()
        Me.grbox_buscarEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(34, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(85, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(85, 84)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'dgv_datosEmpleados
        '
        Me.dgv_datosEmpleados.AllowUserToAddRows = False
        Me.dgv_datosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datosEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_Nombre, Me.col_Apellido, Me.tipo_doc, Me.num_doc, Me.col_fechaNac, Me.col_FechaIngreso, Me.col_matricula, Me.col_Sucursal})
        Me.dgv_datosEmpleados.Location = New System.Drawing.Point(6, 19)
        Me.dgv_datosEmpleados.Name = "dgv_datosEmpleados"
        Me.dgv_datosEmpleados.Size = New System.Drawing.Size(616, 129)
        Me.dgv_datosEmpleados.TabIndex = 6
        '
        'grbox_DatosEmpleados
        '
        Me.grbox_DatosEmpleados.Controls.Add(Me.dgv_datosEmpleados)
        Me.grbox_DatosEmpleados.Location = New System.Drawing.Point(13, 128)
        Me.grbox_DatosEmpleados.Name = "grbox_DatosEmpleados"
        Me.grbox_DatosEmpleados.Size = New System.Drawing.Size(628, 154)
        Me.grbox_DatosEmpleados.TabIndex = 7
        Me.grbox_DatosEmpleados.TabStop = False
        Me.grbox_DatosEmpleados.Text = "Datos de Empleados"
        '
        'btn_buscarEmpleado
        '
        Me.btn_buscarEmpleado.ForeColor = System.Drawing.Color.Black
        Me.btn_buscarEmpleado.Location = New System.Drawing.Point(220, 81)
        Me.btn_buscarEmpleado.Name = "btn_buscarEmpleado"
        Me.btn_buscarEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscarEmpleado.TabIndex = 8
        Me.btn_buscarEmpleado.Text = "Buscar"
        Me.btn_buscarEmpleado.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.ForeColor = System.Drawing.Color.Black
        Me.btn_salir.Location = New System.Drawing.Point(566, 297)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'grbox_buscarEmpleado
        '
        Me.grbox_buscarEmpleado.Controls.Add(Me.btn_buscarEmpleado)
        Me.grbox_buscarEmpleado.Controls.Add(Me.Label1)
        Me.grbox_buscarEmpleado.Controls.Add(Me.Label2)
        Me.grbox_buscarEmpleado.Controls.Add(Me.Label3)
        Me.grbox_buscarEmpleado.Controls.Add(Me.TextBox3)
        Me.grbox_buscarEmpleado.Controls.Add(Me.TextBox1)
        Me.grbox_buscarEmpleado.Controls.Add(Me.TextBox2)
        Me.grbox_buscarEmpleado.Location = New System.Drawing.Point(12, 12)
        Me.grbox_buscarEmpleado.Name = "grbox_buscarEmpleado"
        Me.grbox_buscarEmpleado.Size = New System.Drawing.Size(629, 110)
        Me.grbox_buscarEmpleado.TabIndex = 10
        Me.grbox_buscarEmpleado.TabStop = False
        Me.grbox_buscarEmpleado.Text = "Buscar Empleado"
        '
        'col_Nombre
        '
        Me.col_Nombre.HeaderText = "Nombre"
        Me.col_Nombre.Name = "col_Nombre"
        '
        'col_Apellido
        '
        Me.col_Apellido.HeaderText = "Apellido"
        Me.col_Apellido.Name = "col_Apellido"
        '
        'tipo_doc
        '
        Me.tipo_doc.HeaderText = "Tipo Documento"
        Me.tipo_doc.Name = "tipo_doc"
        '
        'num_doc
        '
        Me.num_doc.HeaderText = "Numero Documento"
        Me.num_doc.Name = "num_doc"
        '
        'col_fechaNac
        '
        Me.col_fechaNac.HeaderText = "Fecha Nacimiento"
        Me.col_fechaNac.Name = "col_fechaNac"
        '
        'col_FechaIngreso
        '
        Me.col_FechaIngreso.HeaderText = "Fecha de Ingreso"
        Me.col_FechaIngreso.Name = "col_FechaIngreso"
        '
        'col_matricula
        '
        Me.col_matricula.HeaderText = "Matricula"
        Me.col_matricula.Name = "col_matricula"
        '
        'col_Sucursal
        '
        Me.col_Sucursal.HeaderText = "Sucursal"
        Me.col_Sucursal.Name = "col_Sucursal"
        '
        'frm_EliminarConsultarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(681, 342)
        Me.Controls.Add(Me.grbox_buscarEmpleado)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.grbox_DatosEmpleados)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Name = "frm_EliminarConsultarEmpleado"
        Me.Text = ".:. Consultar o Eliminar Empleados .:."
        CType(Me.dgv_datosEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbox_DatosEmpleados.ResumeLayout(False)
        Me.grbox_buscarEmpleado.ResumeLayout(False)
        Me.grbox_buscarEmpleado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents dgv_datosEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents grbox_DatosEmpleados As System.Windows.Forms.GroupBox
    Friend WithEvents btn_buscarEmpleado As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents grbox_buscarEmpleado As System.Windows.Forms.GroupBox
    Friend WithEvents col_Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaNac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_FechaIngreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_matricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
