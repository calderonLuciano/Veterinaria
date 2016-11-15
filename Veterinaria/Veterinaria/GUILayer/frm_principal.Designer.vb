<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DueñosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoDueñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarDueñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoMedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarMedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaboratoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoLaboratorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarLaboratorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPerroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarPerroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiagnosticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoDiagnosticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarDiagnosticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SintomasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoSintomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarSintomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RazasMasAtendidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosMasActivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosPorSucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerrosPorDueñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pcb_atencion = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pcb_atencion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.DueñosToolStripMenuItem, Me.MedicamentosToolStripMenuItem, Me.LaboratoriosToolStripMenuItem, Me.PerrosToolStripMenuItem, Me.DiagnosticosToolStripMenuItem, Me.SintomasToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ReportesToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(19, 7, 0, 7)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1354, 54)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoEmpleadoToolStripMenuItem, Me.EditarEmpleadoToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(175, 40)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'NuevoEmpleadoToolStripMenuItem
        '
        Me.NuevoEmpleadoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.NuevoEmpleadoToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.add
        Me.NuevoEmpleadoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NuevoEmpleadoToolStripMenuItem.Name = "NuevoEmpleadoToolStripMenuItem"
        Me.NuevoEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(322, 38)
        Me.NuevoEmpleadoToolStripMenuItem.Text = "Nuevo Empleado"
        '
        'EditarEmpleadoToolStripMenuItem
        '
        Me.EditarEmpleadoToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.edit2
        Me.EditarEmpleadoToolStripMenuItem.Name = "EditarEmpleadoToolStripMenuItem"
        Me.EditarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(322, 38)
        Me.EditarEmpleadoToolStripMenuItem.Text = "Editar Empleado"
        '
        'DueñosToolStripMenuItem
        '
        Me.DueñosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoDueñoToolStripMenuItem, Me.EditarDueñoToolStripMenuItem})
        Me.DueñosToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueñosToolStripMenuItem.Name = "DueñosToolStripMenuItem"
        Me.DueñosToolStripMenuItem.Size = New System.Drawing.Size(125, 40)
        Me.DueñosToolStripMenuItem.Text = "Dueños"
        '
        'NuevoDueñoToolStripMenuItem
        '
        Me.NuevoDueñoToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.add
        Me.NuevoDueñoToolStripMenuItem.Name = "NuevoDueñoToolStripMenuItem"
        Me.NuevoDueñoToolStripMenuItem.Size = New System.Drawing.Size(272, 38)
        Me.NuevoDueñoToolStripMenuItem.Text = "Nuevo Dueño"
        '
        'EditarDueñoToolStripMenuItem
        '
        Me.EditarDueñoToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.edit2
        Me.EditarDueñoToolStripMenuItem.Name = "EditarDueñoToolStripMenuItem"
        Me.EditarDueñoToolStripMenuItem.Size = New System.Drawing.Size(272, 38)
        Me.EditarDueñoToolStripMenuItem.Text = "Editar Dueño"
        '
        'MedicamentosToolStripMenuItem
        '
        Me.MedicamentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoMedicamentoToolStripMenuItem, Me.EditarMedicamentoToolStripMenuItem})
        Me.MedicamentosToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicamentosToolStripMenuItem.Name = "MedicamentosToolStripMenuItem"
        Me.MedicamentosToolStripMenuItem.Size = New System.Drawing.Size(230, 40)
        Me.MedicamentosToolStripMenuItem.Text = "Medicamentos"
        '
        'NuevoMedicamentoToolStripMenuItem
        '
        Me.NuevoMedicamentoToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.add
        Me.NuevoMedicamentoToolStripMenuItem.Name = "NuevoMedicamentoToolStripMenuItem"
        Me.NuevoMedicamentoToolStripMenuItem.Size = New System.Drawing.Size(377, 38)
        Me.NuevoMedicamentoToolStripMenuItem.Text = "Nuevo Medicamento"
        '
        'EditarMedicamentoToolStripMenuItem
        '
        Me.EditarMedicamentoToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.edit2
        Me.EditarMedicamentoToolStripMenuItem.Name = "EditarMedicamentoToolStripMenuItem"
        Me.EditarMedicamentoToolStripMenuItem.Size = New System.Drawing.Size(377, 38)
        Me.EditarMedicamentoToolStripMenuItem.Text = "Editar Medicamento"
        '
        'LaboratoriosToolStripMenuItem
        '
        Me.LaboratoriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoLaboratorioToolStripMenuItem, Me.EditarLaboratorioToolStripMenuItem})
        Me.LaboratoriosToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaboratoriosToolStripMenuItem.Name = "LaboratoriosToolStripMenuItem"
        Me.LaboratoriosToolStripMenuItem.Size = New System.Drawing.Size(191, 40)
        Me.LaboratoriosToolStripMenuItem.Text = "Laboratorios"
        '
        'NuevoLaboratorioToolStripMenuItem
        '
        Me.NuevoLaboratorioToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.add
        Me.NuevoLaboratorioToolStripMenuItem.Name = "NuevoLaboratorioToolStripMenuItem"
        Me.NuevoLaboratorioToolStripMenuItem.Size = New System.Drawing.Size(338, 38)
        Me.NuevoLaboratorioToolStripMenuItem.Text = "Nuevo Laboratorio"
        '
        'EditarLaboratorioToolStripMenuItem
        '
        Me.EditarLaboratorioToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.edit2
        Me.EditarLaboratorioToolStripMenuItem.Name = "EditarLaboratorioToolStripMenuItem"
        Me.EditarLaboratorioToolStripMenuItem.Size = New System.Drawing.Size(338, 38)
        Me.EditarLaboratorioToolStripMenuItem.Text = "Editar Laboratorio"
        '
        'PerrosToolStripMenuItem
        '
        Me.PerrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoPerroToolStripMenuItem, Me.EditarPerroToolStripMenuItem})
        Me.PerrosToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerrosToolStripMenuItem.Name = "PerrosToolStripMenuItem"
        Me.PerrosToolStripMenuItem.Size = New System.Drawing.Size(105, 40)
        Me.PerrosToolStripMenuItem.Text = "Perros"
        '
        'NuevoPerroToolStripMenuItem
        '
        Me.NuevoPerroToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.add
        Me.NuevoPerroToolStripMenuItem.Name = "NuevoPerroToolStripMenuItem"
        Me.NuevoPerroToolStripMenuItem.Size = New System.Drawing.Size(252, 38)
        Me.NuevoPerroToolStripMenuItem.Text = "Nuevo Perro"
        '
        'EditarPerroToolStripMenuItem
        '
        Me.EditarPerroToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.edit2
        Me.EditarPerroToolStripMenuItem.Name = "EditarPerroToolStripMenuItem"
        Me.EditarPerroToolStripMenuItem.Size = New System.Drawing.Size(252, 38)
        Me.EditarPerroToolStripMenuItem.Text = "Editar Perro"
        '
        'DiagnosticosToolStripMenuItem
        '
        Me.DiagnosticosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoDiagnosticoToolStripMenuItem, Me.EditarDiagnosticoToolStripMenuItem})
        Me.DiagnosticosToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiagnosticosToolStripMenuItem.Name = "DiagnosticosToolStripMenuItem"
        Me.DiagnosticosToolStripMenuItem.Size = New System.Drawing.Size(197, 40)
        Me.DiagnosticosToolStripMenuItem.Text = "Diagnosticos"
        '
        'NuevoDiagnosticoToolStripMenuItem
        '
        Me.NuevoDiagnosticoToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.add
        Me.NuevoDiagnosticoToolStripMenuItem.Name = "NuevoDiagnosticoToolStripMenuItem"
        Me.NuevoDiagnosticoToolStripMenuItem.Size = New System.Drawing.Size(344, 38)
        Me.NuevoDiagnosticoToolStripMenuItem.Text = "Nuevo Diagnostico"
        '
        'EditarDiagnosticoToolStripMenuItem
        '
        Me.EditarDiagnosticoToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.edit2
        Me.EditarDiagnosticoToolStripMenuItem.Name = "EditarDiagnosticoToolStripMenuItem"
        Me.EditarDiagnosticoToolStripMenuItem.Size = New System.Drawing.Size(344, 38)
        Me.EditarDiagnosticoToolStripMenuItem.Text = "Editar Diagnostico"
        '
        'SintomasToolStripMenuItem
        '
        Me.SintomasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoSintomaToolStripMenuItem, Me.EditarSintomaToolStripMenuItem})
        Me.SintomasToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SintomasToolStripMenuItem.Name = "SintomasToolStripMenuItem"
        Me.SintomasToolStripMenuItem.Size = New System.Drawing.Size(146, 40)
        Me.SintomasToolStripMenuItem.Text = "Sintomas"
        '
        'NuevoSintomaToolStripMenuItem
        '
        Me.NuevoSintomaToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.add
        Me.NuevoSintomaToolStripMenuItem.Name = "NuevoSintomaToolStripMenuItem"
        Me.NuevoSintomaToolStripMenuItem.Size = New System.Drawing.Size(293, 38)
        Me.NuevoSintomaToolStripMenuItem.Text = "Nuevo Sintoma"
        '
        'EditarSintomaToolStripMenuItem
        '
        Me.EditarSintomaToolStripMenuItem.Image = Global.Veterinaria.My.Resources.Resources.edit2
        Me.EditarSintomaToolStripMenuItem.Name = "EditarSintomaToolStripMenuItem"
        Me.EditarSintomaToolStripMenuItem.Size = New System.Drawing.Size(293, 38)
        Me.EditarSintomaToolStripMenuItem.Text = "Editar Sintoma"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 40)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RazasMasAtendidasToolStripMenuItem, Me.EmpleadosMasActivosToolStripMenuItem, Me.EmpleadosPorSucursalToolStripMenuItem, Me.PerrosPorDueñoToolStripMenuItem})
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(144, 40)
        Me.ToolStripMenuItem2.Text = "Reportes"
        '
        'RazasMasAtendidasToolStripMenuItem
        '
        Me.RazasMasAtendidasToolStripMenuItem.Name = "RazasMasAtendidasToolStripMenuItem"
        Me.RazasMasAtendidasToolStripMenuItem.Size = New System.Drawing.Size(402, 38)
        Me.RazasMasAtendidasToolStripMenuItem.Text = "Razas mas atendidas"
        '
        'EmpleadosMasActivosToolStripMenuItem
        '
        Me.EmpleadosMasActivosToolStripMenuItem.Name = "EmpleadosMasActivosToolStripMenuItem"
        Me.EmpleadosMasActivosToolStripMenuItem.Size = New System.Drawing.Size(402, 38)
        Me.EmpleadosMasActivosToolStripMenuItem.Text = "Empleados mas activos"
        '
        'EmpleadosPorSucursalToolStripMenuItem
        '
        Me.EmpleadosPorSucursalToolStripMenuItem.Name = "EmpleadosPorSucursalToolStripMenuItem"
        Me.EmpleadosPorSucursalToolStripMenuItem.Size = New System.Drawing.Size(402, 38)
        Me.EmpleadosPorSucursalToolStripMenuItem.Text = "Empleados por sucursal"
        '
        'PerrosPorDueñoToolStripMenuItem
        '
        Me.PerrosPorDueñoToolStripMenuItem.Name = "PerrosPorDueñoToolStripMenuItem"
        Me.PerrosPorDueñoToolStripMenuItem.Size = New System.Drawing.Size(402, 38)
        Me.PerrosPorDueñoToolStripMenuItem.Text = "Perros por Raza"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(153, 40)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(12, 40)
        '
        'pcb_atencion
        '
        Me.pcb_atencion.BackColor = System.Drawing.Color.Transparent
        Me.pcb_atencion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcb_atencion.Image = Global.Veterinaria.My.Resources.Resources.atencioon
        Me.pcb_atencion.Location = New System.Drawing.Point(474, 269)
        Me.pcb_atencion.Margin = New System.Windows.Forms.Padding(7)
        Me.pcb_atencion.Name = "pcb_atencion"
        Me.pcb_atencion.Size = New System.Drawing.Size(1527, 653)
        Me.pcb_atencion.TabIndex = 1
        Me.pcb_atencion.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 704)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 38)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(163, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(1008, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desarrollado por Calderón Luciano Ariel y Salguero Juan Pablo"
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 38.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.panel_principal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pcb_atencion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "frm_principal"
        Me.Text = "frm_principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pcb_atencion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DueñosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoDueñoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarDueñoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoMedicamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarMedicamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaboratoriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoLaboratorioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarLaboratorioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoPerroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarPerroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiagnosticosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoDiagnosticoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarDiagnosticoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SintomasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoSintomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarSintomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pcb_atencion As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RazasMasAtendidasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosMasActivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosPorSucursalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerrosPorDueñoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
