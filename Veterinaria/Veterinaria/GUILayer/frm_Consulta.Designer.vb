<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Consulta
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gro_listaConsulta = New System.Windows.Forms.GroupBox()
        Me.dgv_listaConsultas = New System.Windows.Forms.DataGridView()
        Me.col_nroHistoriaClinicaCons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipoDocCons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroDocCons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gro_listaSintomasDisponibles = New System.Windows.Forms.GroupBox()
        Me.dgv_sintomasDisponibles = New System.Windows.Forms.DataGridView()
        Me.col_idSintomaT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcionSintomaT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gro_listaDeDiagnosticosDisponibles = New System.Windows.Forms.GroupBox()
        Me.dgv_diagnosticosDisponibles = New System.Windows.Forms.DataGridView()
        Me.col_idDiagnosticoT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gro_listaMedicamentosT = New System.Windows.Forms.GroupBox()
        Me.dgv_medicamentosDisponibles = New System.Windows.Forms.DataGridView()
        Me.col_idMedicamentoT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcionMedicamentoT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_dosis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_periodicidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gro_datosConsulta = New System.Windows.Forms.GroupBox()
        Me.btn_nuevoPerro = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_quitarDiagnostico = New System.Windows.Forms.Button()
        Me.cbo_diagnosticosDisponibles = New System.Windows.Forms.ComboBox()
        Me.btn_nuevoDiagnostico = New System.Windows.Forms.Button()
        Me.lbl_dispDiag = New System.Windows.Forms.Label()
        Me.btn_agregarDiagnostico = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_quitarSintoma = New System.Windows.Forms.Button()
        Me.cbo_cargaSintomasDisponibles = New System.Windows.Forms.ComboBox()
        Me.btn_nuevoSintoma = New System.Windows.Forms.Button()
        Me.lbl_dispSint = New System.Windows.Forms.Label()
        Me.btn_agregarSintoma = New System.Windows.Forms.Button()
        Me.gro_medicamentosDispCarg = New System.Windows.Forms.GroupBox()
        Me.btn_quitarMedicamento = New System.Windows.Forms.Button()
        Me.cbo_medicamentosDisponibles = New System.Windows.Forms.ComboBox()
        Me.txt_periodicidad = New System.Windows.Forms.TextBox()
        Me.txt_dosis = New System.Windows.Forms.TextBox()
        Me.lbl_periodicidad = New System.Windows.Forms.Label()
        Me.lbl_dosis = New System.Windows.Forms.Label()
        Me.btn_nuevoMedicamento = New System.Windows.Forms.Button()
        Me.lbl_dispMed = New System.Windows.Forms.Label()
        Me.btn_agregarMedicamento = New System.Windows.Forms.Button()
        Me.mkb_fechaSalida = New System.Windows.Forms.MaskedTextBox()
        Me.mkb_fechaEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txt_idConsulta = New System.Windows.Forms.TextBox()
        Me.lbl_fechaSalida = New System.Windows.Forms.Label()
        Me.lbl_fechaEntrada = New System.Windows.Forms.Label()
        Me.lbl_idConsulta = New System.Windows.Forms.Label()
        Me.lbl_numeroDocumento = New System.Windows.Forms.Label()
        Me.lbl_tipoDocumento = New System.Windows.Forms.Label()
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.lbl_nroHistClinicaCons = New System.Windows.Forms.Label()
        Me.cbo_nroDocCons = New System.Windows.Forms.ComboBox()
        Me.cbo_tipoDocCons = New System.Windows.Forms.ComboBox()
        Me.cbo_sucursalCons = New System.Windows.Forms.ComboBox()
        Me.cbo_nroHistClinicaCons = New System.Windows.Forms.ComboBox()
        Me.gro_buscarAtencionFechaDesdeHasta = New System.Windows.Forms.GroupBox()
        Me.lbl_buscarHasta = New System.Windows.Forms.Label()
        Me.mkb_buscarDesde = New System.Windows.Forms.MaskedTextBox()
        Me.btn_buscarAtencionFechaDesdeHasta = New System.Windows.Forms.Button()
        Me.mkb_buscarHasta = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_buscarDesde = New System.Windows.Forms.Label()
        Me.lbl_buscar = New System.Windows.Forms.Label()
        Me.txt_bucarAtencion = New System.Windows.Forms.TextBox()
        Me.btn_buscarConsulta = New System.Windows.Forms.Button()
        Me.chk_habilitarDesdeHasta = New System.Windows.Forms.CheckBox()
        Me.gro_buscarAtencion = New System.Windows.Forms.GroupBox()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_guardarConsulta = New System.Windows.Forms.Button()
        Me.gro_listaConsulta.SuspendLayout()
        CType(Me.dgv_listaConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gro_listaSintomasDisponibles.SuspendLayout()
        CType(Me.dgv_sintomasDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gro_listaDeDiagnosticosDisponibles.SuspendLayout()
        CType(Me.dgv_diagnosticosDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gro_listaMedicamentosT.SuspendLayout()
        CType(Me.dgv_medicamentosDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gro_datosConsulta.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gro_medicamentosDispCarg.SuspendLayout()
        Me.gro_buscarAtencionFechaDesdeHasta.SuspendLayout()
        Me.gro_buscarAtencion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gro_listaConsulta
        '
        Me.gro_listaConsulta.BackColor = System.Drawing.Color.Transparent
        Me.gro_listaConsulta.Controls.Add(Me.dgv_listaConsultas)
        Me.gro_listaConsulta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_listaConsulta.ForeColor = System.Drawing.Color.White
        Me.gro_listaConsulta.Location = New System.Drawing.Point(12, 559)
        Me.gro_listaConsulta.Name = "gro_listaConsulta"
        Me.gro_listaConsulta.Size = New System.Drawing.Size(1303, 151)
        Me.gro_listaConsulta.TabIndex = 25
        Me.gro_listaConsulta.TabStop = False
        Me.gro_listaConsulta.Text = "Lista Consultas"
        '
        'dgv_listaConsultas
        '
        Me.dgv_listaConsultas.AllowUserToAddRows = False
        Me.dgv_listaConsultas.AllowUserToDeleteRows = False
        Me.dgv_listaConsultas.AllowUserToResizeColumns = False
        Me.dgv_listaConsultas.AllowUserToResizeRows = False
        Me.dgv_listaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaConsultas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nroHistoriaClinicaCons, Me.col_idConsulta, Me.col_tipoDocCons, Me.col_nroDocCons, Me.col_fechaEntrada, Me.col_fechaSalida})
        Me.dgv_listaConsultas.Location = New System.Drawing.Point(34, 19)
        Me.dgv_listaConsultas.MultiSelect = False
        Me.dgv_listaConsultas.Name = "dgv_listaConsultas"
        Me.dgv_listaConsultas.ReadOnly = True
        Me.dgv_listaConsultas.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgv_listaConsultas.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listaConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaConsultas.Size = New System.Drawing.Size(1231, 130)
        Me.dgv_listaConsultas.TabIndex = 0
        '
        'col_nroHistoriaClinicaCons
        '
        Me.col_nroHistoriaClinicaCons.HeaderText = "Número de Historia Clinica"
        Me.col_nroHistoriaClinicaCons.Name = "col_nroHistoriaClinicaCons"
        Me.col_nroHistoriaClinicaCons.ReadOnly = True
        Me.col_nroHistoriaClinicaCons.Width = 240
        '
        'col_idConsulta
        '
        Me.col_idConsulta.HeaderText = "ID Consulta"
        Me.col_idConsulta.Name = "col_idConsulta"
        Me.col_idConsulta.ReadOnly = True
        Me.col_idConsulta.Visible = False
        '
        'col_tipoDocCons
        '
        Me.col_tipoDocCons.HeaderText = "Tipo Documento Empleado"
        Me.col_tipoDocCons.Name = "col_tipoDocCons"
        Me.col_tipoDocCons.ReadOnly = True
        Me.col_tipoDocCons.Width = 240
        '
        'col_nroDocCons
        '
        Me.col_nroDocCons.HeaderText = "Número de Documento Empleado"
        Me.col_nroDocCons.Name = "col_nroDocCons"
        Me.col_nroDocCons.ReadOnly = True
        Me.col_nroDocCons.Width = 260
        '
        'col_fechaEntrada
        '
        Me.col_fechaEntrada.HeaderText = "Fecha de Entrada"
        Me.col_fechaEntrada.Name = "col_fechaEntrada"
        Me.col_fechaEntrada.ReadOnly = True
        Me.col_fechaEntrada.Width = 240
        '
        'col_fechaSalida
        '
        Me.col_fechaSalida.HeaderText = "Fecha de Salida"
        Me.col_fechaSalida.Name = "col_fechaSalida"
        Me.col_fechaSalida.ReadOnly = True
        Me.col_fechaSalida.Width = 240
        '
        'gro_listaSintomasDisponibles
        '
        Me.gro_listaSintomasDisponibles.Controls.Add(Me.dgv_sintomasDisponibles)
        Me.gro_listaSintomasDisponibles.ForeColor = System.Drawing.Color.White
        Me.gro_listaSintomasDisponibles.Location = New System.Drawing.Point(6, 100)
        Me.gro_listaSintomasDisponibles.Name = "gro_listaSintomasDisponibles"
        Me.gro_listaSintomasDisponibles.Size = New System.Drawing.Size(358, 195)
        Me.gro_listaSintomasDisponibles.TabIndex = 28
        Me.gro_listaSintomasDisponibles.TabStop = False
        Me.gro_listaSintomasDisponibles.Text = "Lista de sintomas"
        '
        'dgv_sintomasDisponibles
        '
        Me.dgv_sintomasDisponibles.AllowUserToAddRows = False
        Me.dgv_sintomasDisponibles.AllowUserToDeleteRows = False
        Me.dgv_sintomasDisponibles.AllowUserToResizeColumns = False
        Me.dgv_sintomasDisponibles.AllowUserToResizeRows = False
        Me.dgv_sintomasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sintomasDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idSintomaT, Me.col_descripcionSintomaT})
        Me.dgv_sintomasDisponibles.Location = New System.Drawing.Point(0, 18)
        Me.dgv_sintomasDisponibles.MultiSelect = False
        Me.dgv_sintomasDisponibles.Name = "dgv_sintomasDisponibles"
        Me.dgv_sintomasDisponibles.ReadOnly = True
        Me.dgv_sintomasDisponibles.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgv_sintomasDisponibles.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_sintomasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_sintomasDisponibles.Size = New System.Drawing.Size(352, 171)
        Me.dgv_sintomasDisponibles.TabIndex = 2
        '
        'col_idSintomaT
        '
        Me.col_idSintomaT.HeaderText = "ID Sintoma"
        Me.col_idSintomaT.Name = "col_idSintomaT"
        Me.col_idSintomaT.ReadOnly = True
        Me.col_idSintomaT.Visible = False
        '
        'col_descripcionSintomaT
        '
        Me.col_descripcionSintomaT.HeaderText = "Descripcion"
        Me.col_descripcionSintomaT.Name = "col_descripcionSintomaT"
        Me.col_descripcionSintomaT.ReadOnly = True
        Me.col_descripcionSintomaT.Width = 345
        '
        'gro_listaDeDiagnosticosDisponibles
        '
        Me.gro_listaDeDiagnosticosDisponibles.Controls.Add(Me.dgv_diagnosticosDisponibles)
        Me.gro_listaDeDiagnosticosDisponibles.ForeColor = System.Drawing.Color.White
        Me.gro_listaDeDiagnosticosDisponibles.Location = New System.Drawing.Point(3, 101)
        Me.gro_listaDeDiagnosticosDisponibles.Name = "gro_listaDeDiagnosticosDisponibles"
        Me.gro_listaDeDiagnosticosDisponibles.Size = New System.Drawing.Size(377, 195)
        Me.gro_listaDeDiagnosticosDisponibles.TabIndex = 5
        Me.gro_listaDeDiagnosticosDisponibles.TabStop = False
        Me.gro_listaDeDiagnosticosDisponibles.Text = "Lista de diagnosticos"
        '
        'dgv_diagnosticosDisponibles
        '
        Me.dgv_diagnosticosDisponibles.AllowUserToAddRows = False
        Me.dgv_diagnosticosDisponibles.AllowUserToDeleteRows = False
        Me.dgv_diagnosticosDisponibles.AllowUserToResizeColumns = False
        Me.dgv_diagnosticosDisponibles.AllowUserToResizeRows = False
        Me.dgv_diagnosticosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_diagnosticosDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idDiagnosticoT, Me.DataGridViewTextBoxColumn4})
        Me.dgv_diagnosticosDisponibles.Location = New System.Drawing.Point(7, 18)
        Me.dgv_diagnosticosDisponibles.Name = "dgv_diagnosticosDisponibles"
        Me.dgv_diagnosticosDisponibles.ReadOnly = True
        Me.dgv_diagnosticosDisponibles.RowHeadersVisible = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgv_diagnosticosDisponibles.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_diagnosticosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_diagnosticosDisponibles.Size = New System.Drawing.Size(364, 170)
        Me.dgv_diagnosticosDisponibles.TabIndex = 2
        '
        'col_idDiagnosticoT
        '
        Me.col_idDiagnosticoT.HeaderText = "ID Diagnostico"
        Me.col_idDiagnosticoT.Name = "col_idDiagnosticoT"
        Me.col_idDiagnosticoT.ReadOnly = True
        Me.col_idDiagnosticoT.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 360
        '
        'gro_listaMedicamentosT
        '
        Me.gro_listaMedicamentosT.Controls.Add(Me.dgv_medicamentosDisponibles)
        Me.gro_listaMedicamentosT.ForeColor = System.Drawing.Color.White
        Me.gro_listaMedicamentosT.Location = New System.Drawing.Point(9, 100)
        Me.gro_listaMedicamentosT.Name = "gro_listaMedicamentosT"
        Me.gro_listaMedicamentosT.Size = New System.Drawing.Size(428, 196)
        Me.gro_listaMedicamentosT.TabIndex = 4
        Me.gro_listaMedicamentosT.TabStop = False
        Me.gro_listaMedicamentosT.Text = "Lista de medicamentos"
        '
        'dgv_medicamentosDisponibles
        '
        Me.dgv_medicamentosDisponibles.AllowUserToAddRows = False
        Me.dgv_medicamentosDisponibles.AllowUserToDeleteRows = False
        Me.dgv_medicamentosDisponibles.AllowUserToResizeColumns = False
        Me.dgv_medicamentosDisponibles.AllowUserToResizeRows = False
        Me.dgv_medicamentosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_medicamentosDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idMedicamentoT, Me.col_descripcionMedicamentoT, Me.col_dosis, Me.col_periodicidad})
        Me.dgv_medicamentosDisponibles.Location = New System.Drawing.Point(6, 19)
        Me.dgv_medicamentosDisponibles.MultiSelect = False
        Me.dgv_medicamentosDisponibles.Name = "dgv_medicamentosDisponibles"
        Me.dgv_medicamentosDisponibles.ReadOnly = True
        Me.dgv_medicamentosDisponibles.RowHeadersVisible = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgv_medicamentosDisponibles.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_medicamentosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_medicamentosDisponibles.Size = New System.Drawing.Size(416, 171)
        Me.dgv_medicamentosDisponibles.TabIndex = 1
        '
        'col_idMedicamentoT
        '
        Me.col_idMedicamentoT.HeaderText = "ID Medicamento"
        Me.col_idMedicamentoT.Name = "col_idMedicamentoT"
        Me.col_idMedicamentoT.ReadOnly = True
        Me.col_idMedicamentoT.Visible = False
        '
        'col_descripcionMedicamentoT
        '
        Me.col_descripcionMedicamentoT.HeaderText = "Nombre"
        Me.col_descripcionMedicamentoT.Name = "col_descripcionMedicamentoT"
        Me.col_descripcionMedicamentoT.ReadOnly = True
        Me.col_descripcionMedicamentoT.Width = 200
        '
        'col_dosis
        '
        Me.col_dosis.HeaderText = "Dosis"
        Me.col_dosis.Name = "col_dosis"
        Me.col_dosis.ReadOnly = True
        '
        'col_periodicidad
        '
        Me.col_periodicidad.HeaderText = "Periodicidad"
        Me.col_periodicidad.Name = "col_periodicidad"
        Me.col_periodicidad.ReadOnly = True
        Me.col_periodicidad.Width = 110
        '
        'gro_datosConsulta
        '
        Me.gro_datosConsulta.BackColor = System.Drawing.Color.Transparent
        Me.gro_datosConsulta.Controls.Add(Me.btn_nuevoPerro)
        Me.gro_datosConsulta.Controls.Add(Me.GroupBox2)
        Me.gro_datosConsulta.Controls.Add(Me.GroupBox1)
        Me.gro_datosConsulta.Controls.Add(Me.gro_medicamentosDispCarg)
        Me.gro_datosConsulta.Controls.Add(Me.mkb_fechaSalida)
        Me.gro_datosConsulta.Controls.Add(Me.mkb_fechaEntrada)
        Me.gro_datosConsulta.Controls.Add(Me.txt_idConsulta)
        Me.gro_datosConsulta.Controls.Add(Me.lbl_fechaSalida)
        Me.gro_datosConsulta.Controls.Add(Me.lbl_fechaEntrada)
        Me.gro_datosConsulta.Controls.Add(Me.lbl_idConsulta)
        Me.gro_datosConsulta.Controls.Add(Me.lbl_numeroDocumento)
        Me.gro_datosConsulta.Controls.Add(Me.lbl_tipoDocumento)
        Me.gro_datosConsulta.Controls.Add(Me.lbl_sucursal)
        Me.gro_datosConsulta.Controls.Add(Me.lbl_nroHistClinicaCons)
        Me.gro_datosConsulta.Controls.Add(Me.cbo_nroDocCons)
        Me.gro_datosConsulta.Controls.Add(Me.cbo_tipoDocCons)
        Me.gro_datosConsulta.Controls.Add(Me.cbo_sucursalCons)
        Me.gro_datosConsulta.Controls.Add(Me.cbo_nroHistClinicaCons)
        Me.gro_datosConsulta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_datosConsulta.ForeColor = System.Drawing.Color.White
        Me.gro_datosConsulta.Location = New System.Drawing.Point(12, 148)
        Me.gro_datosConsulta.Name = "gro_datosConsulta"
        Me.gro_datosConsulta.Size = New System.Drawing.Size(1303, 405)
        Me.gro_datosConsulta.TabIndex = 24
        Me.gro_datosConsulta.TabStop = False
        Me.gro_datosConsulta.Text = "Datos Consulta"
        '
        'btn_nuevoPerro
        '
        Me.btn_nuevoPerro.BackgroundImage = Global.Veterinaria.My.Resources.Resources.add
        Me.btn_nuevoPerro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_nuevoPerro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevoPerro.Location = New System.Drawing.Point(296, 18)
        Me.btn_nuevoPerro.Name = "btn_nuevoPerro"
        Me.btn_nuevoPerro.Size = New System.Drawing.Size(32, 30)
        Me.btn_nuevoPerro.TabIndex = 42
        Me.btn_nuevoPerro.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_quitarDiagnostico)
        Me.GroupBox2.Controls.Add(Me.gro_listaDeDiagnosticosDisponibles)
        Me.GroupBox2.Controls.Add(Me.cbo_diagnosticosDisponibles)
        Me.GroupBox2.Controls.Add(Me.btn_nuevoDiagnostico)
        Me.GroupBox2.Controls.Add(Me.lbl_dispDiag)
        Me.GroupBox2.Controls.Add(Me.btn_agregarDiagnostico)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(885, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(389, 303)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Diagnosticos"
        '
        'btn_quitarDiagnostico
        '
        Me.btn_quitarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_quitarDiagnostico.Image = Global.Veterinaria.My.Resources.Resources.remove
        Me.btn_quitarDiagnostico.Location = New System.Drawing.Point(322, 72)
        Me.btn_quitarDiagnostico.Name = "btn_quitarDiagnostico"
        Me.btn_quitarDiagnostico.Size = New System.Drawing.Size(38, 23)
        Me.btn_quitarDiagnostico.TabIndex = 55
        Me.btn_quitarDiagnostico.UseVisualStyleBackColor = True
        '
        'cbo_diagnosticosDisponibles
        '
        Me.cbo_diagnosticosDisponibles.FormattingEnabled = True
        Me.cbo_diagnosticosDisponibles.Location = New System.Drawing.Point(93, 18)
        Me.cbo_diagnosticosDisponibles.Name = "cbo_diagnosticosDisponibles"
        Me.cbo_diagnosticosDisponibles.Size = New System.Drawing.Size(121, 24)
        Me.cbo_diagnosticosDisponibles.TabIndex = 54
        '
        'btn_nuevoDiagnostico
        '
        Me.btn_nuevoDiagnostico.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevoDiagnostico.Location = New System.Drawing.Point(139, 71)
        Me.btn_nuevoDiagnostico.Name = "btn_nuevoDiagnostico"
        Me.btn_nuevoDiagnostico.Size = New System.Drawing.Size(145, 23)
        Me.btn_nuevoDiagnostico.TabIndex = 47
        Me.btn_nuevoDiagnostico.Text = "Nuevo Diagnostico"
        Me.btn_nuevoDiagnostico.UseVisualStyleBackColor = True
        '
        'lbl_dispDiag
        '
        Me.lbl_dispDiag.AutoSize = True
        Me.lbl_dispDiag.Location = New System.Drawing.Point(3, 22)
        Me.lbl_dispDiag.Name = "lbl_dispDiag"
        Me.lbl_dispDiag.Size = New System.Drawing.Size(84, 16)
        Me.lbl_dispDiag.TabIndex = 53
        Me.lbl_dispDiag.Text = "Disponibles:"
        '
        'btn_agregarDiagnostico
        '
        Me.btn_agregarDiagnostico.BackgroundImage = Global.Veterinaria.My.Resources.Resources.add
        Me.btn_agregarDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregarDiagnostico.Location = New System.Drawing.Point(322, 19)
        Me.btn_agregarDiagnostico.Name = "btn_agregarDiagnostico"
        Me.btn_agregarDiagnostico.Size = New System.Drawing.Size(38, 37)
        Me.btn_agregarDiagnostico.TabIndex = 51
        Me.btn_agregarDiagnostico.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_quitarSintoma)
        Me.GroupBox1.Controls.Add(Me.gro_listaSintomasDisponibles)
        Me.GroupBox1.Controls.Add(Me.cbo_cargaSintomasDisponibles)
        Me.GroupBox1.Controls.Add(Me.btn_nuevoSintoma)
        Me.GroupBox1.Controls.Add(Me.lbl_dispSint)
        Me.GroupBox1.Controls.Add(Me.btn_agregarSintoma)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(509, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 303)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sintomas"
        '
        'btn_quitarSintoma
        '
        Me.btn_quitarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_quitarSintoma.Image = Global.Veterinaria.My.Resources.Resources.remove
        Me.btn_quitarSintoma.Location = New System.Drawing.Point(292, 71)
        Me.btn_quitarSintoma.Name = "btn_quitarSintoma"
        Me.btn_quitarSintoma.Size = New System.Drawing.Size(43, 23)
        Me.btn_quitarSintoma.TabIndex = 52
        Me.btn_quitarSintoma.UseVisualStyleBackColor = True
        '
        'cbo_cargaSintomasDisponibles
        '
        Me.cbo_cargaSintomasDisponibles.FormattingEnabled = True
        Me.cbo_cargaSintomasDisponibles.Location = New System.Drawing.Point(82, 19)
        Me.cbo_cargaSintomasDisponibles.Name = "cbo_cargaSintomasDisponibles"
        Me.cbo_cargaSintomasDisponibles.Size = New System.Drawing.Size(121, 24)
        Me.cbo_cargaSintomasDisponibles.TabIndex = 47
        '
        'btn_nuevoSintoma
        '
        Me.btn_nuevoSintoma.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevoSintoma.Location = New System.Drawing.Point(146, 73)
        Me.btn_nuevoSintoma.Name = "btn_nuevoSintoma"
        Me.btn_nuevoSintoma.Size = New System.Drawing.Size(120, 23)
        Me.btn_nuevoSintoma.TabIndex = 46
        Me.btn_nuevoSintoma.Text = "Nuevo Sintoma"
        Me.btn_nuevoSintoma.UseVisualStyleBackColor = True
        '
        'lbl_dispSint
        '
        Me.lbl_dispSint.AutoSize = True
        Me.lbl_dispSint.Location = New System.Drawing.Point(3, 21)
        Me.lbl_dispSint.Name = "lbl_dispSint"
        Me.lbl_dispSint.Size = New System.Drawing.Size(84, 16)
        Me.lbl_dispSint.TabIndex = 45
        Me.lbl_dispSint.Text = "Disponibles:"
        '
        'btn_agregarSintoma
        '
        Me.btn_agregarSintoma.BackgroundImage = Global.Veterinaria.My.Resources.Resources.add
        Me.btn_agregarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregarSintoma.Location = New System.Drawing.Point(292, 18)
        Me.btn_agregarSintoma.Name = "btn_agregarSintoma"
        Me.btn_agregarSintoma.Size = New System.Drawing.Size(43, 37)
        Me.btn_agregarSintoma.TabIndex = 43
        Me.btn_agregarSintoma.UseVisualStyleBackColor = True
        '
        'gro_medicamentosDispCarg
        '
        Me.gro_medicamentosDispCarg.Controls.Add(Me.btn_quitarMedicamento)
        Me.gro_medicamentosDispCarg.Controls.Add(Me.cbo_medicamentosDisponibles)
        Me.gro_medicamentosDispCarg.Controls.Add(Me.txt_periodicidad)
        Me.gro_medicamentosDispCarg.Controls.Add(Me.txt_dosis)
        Me.gro_medicamentosDispCarg.Controls.Add(Me.lbl_periodicidad)
        Me.gro_medicamentosDispCarg.Controls.Add(Me.gro_listaMedicamentosT)
        Me.gro_medicamentosDispCarg.Controls.Add(Me.lbl_dosis)
        Me.gro_medicamentosDispCarg.Controls.Add(Me.btn_nuevoMedicamento)
        Me.gro_medicamentosDispCarg.Controls.Add(Me.lbl_dispMed)
        Me.gro_medicamentosDispCarg.Controls.Add(Me.btn_agregarMedicamento)
        Me.gro_medicamentosDispCarg.ForeColor = System.Drawing.Color.White
        Me.gro_medicamentosDispCarg.Location = New System.Drawing.Point(37, 96)
        Me.gro_medicamentosDispCarg.Name = "gro_medicamentosDispCarg"
        Me.gro_medicamentosDispCarg.Size = New System.Drawing.Size(445, 303)
        Me.gro_medicamentosDispCarg.TabIndex = 43
        Me.gro_medicamentosDispCarg.TabStop = False
        Me.gro_medicamentosDispCarg.Text = "Medicamentos"
        '
        'btn_quitarMedicamento
        '
        Me.btn_quitarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_quitarMedicamento.Image = Global.Veterinaria.My.Resources.Resources.remove
        Me.btn_quitarMedicamento.Location = New System.Drawing.Point(397, 71)
        Me.btn_quitarMedicamento.Name = "btn_quitarMedicamento"
        Me.btn_quitarMedicamento.Size = New System.Drawing.Size(42, 23)
        Me.btn_quitarMedicamento.TabIndex = 51
        Me.btn_quitarMedicamento.UseVisualStyleBackColor = True
        '
        'cbo_medicamentosDisponibles
        '
        Me.cbo_medicamentosDisponibles.FormattingEnabled = True
        Me.cbo_medicamentosDisponibles.Location = New System.Drawing.Point(86, 18)
        Me.cbo_medicamentosDisponibles.Name = "cbo_medicamentosDisponibles"
        Me.cbo_medicamentosDisponibles.Size = New System.Drawing.Size(121, 24)
        Me.cbo_medicamentosDisponibles.TabIndex = 50
        '
        'txt_periodicidad
        '
        Me.txt_periodicidad.Location = New System.Drawing.Point(288, 44)
        Me.txt_periodicidad.Name = "txt_periodicidad"
        Me.txt_periodicidad.Size = New System.Drawing.Size(90, 23)
        Me.txt_periodicidad.TabIndex = 49
        '
        'txt_dosis
        '
        Me.txt_dosis.Location = New System.Drawing.Point(288, 19)
        Me.txt_dosis.Name = "txt_dosis"
        Me.txt_dosis.Size = New System.Drawing.Size(90, 23)
        Me.txt_dosis.TabIndex = 48
        '
        'lbl_periodicidad
        '
        Me.lbl_periodicidad.AutoSize = True
        Me.lbl_periodicidad.Location = New System.Drawing.Point(199, 47)
        Me.lbl_periodicidad.Name = "lbl_periodicidad"
        Me.lbl_periodicidad.Size = New System.Drawing.Size(94, 16)
        Me.lbl_periodicidad.TabIndex = 47
        Me.lbl_periodicidad.Text = "Periodicidad:"
        '
        'lbl_dosis
        '
        Me.lbl_dosis.AutoSize = True
        Me.lbl_dosis.Location = New System.Drawing.Point(213, 22)
        Me.lbl_dosis.Name = "lbl_dosis"
        Me.lbl_dosis.Size = New System.Drawing.Size(78, 16)
        Me.lbl_dosis.TabIndex = 46
        Me.lbl_dosis.Text = "Dosis (Mg):"
        '
        'btn_nuevoMedicamento
        '
        Me.btn_nuevoMedicamento.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevoMedicamento.Location = New System.Drawing.Point(216, 73)
        Me.btn_nuevoMedicamento.Name = "btn_nuevoMedicamento"
        Me.btn_nuevoMedicamento.Size = New System.Drawing.Size(162, 23)
        Me.btn_nuevoMedicamento.TabIndex = 45
        Me.btn_nuevoMedicamento.Text = "Nuevo Medicamento"
        Me.btn_nuevoMedicamento.UseVisualStyleBackColor = True
        '
        'lbl_dispMed
        '
        Me.lbl_dispMed.AutoSize = True
        Me.lbl_dispMed.Location = New System.Drawing.Point(6, 22)
        Me.lbl_dispMed.Name = "lbl_dispMed"
        Me.lbl_dispMed.Size = New System.Drawing.Size(84, 16)
        Me.lbl_dispMed.TabIndex = 43
        Me.lbl_dispMed.Text = "Disponibles:"
        '
        'btn_agregarMedicamento
        '
        Me.btn_agregarMedicamento.BackgroundImage = Global.Veterinaria.My.Resources.Resources.add
        Me.btn_agregarMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregarMedicamento.Location = New System.Drawing.Point(397, 21)
        Me.btn_agregarMedicamento.Name = "btn_agregarMedicamento"
        Me.btn_agregarMedicamento.Size = New System.Drawing.Size(40, 40)
        Me.btn_agregarMedicamento.TabIndex = 41
        Me.btn_agregarMedicamento.UseVisualStyleBackColor = True
        '
        'mkb_fechaSalida
        '
        Me.mkb_fechaSalida.Location = New System.Drawing.Point(797, 50)
        Me.mkb_fechaSalida.Mask = "00/00/0000"
        Me.mkb_fechaSalida.Name = "mkb_fechaSalida"
        Me.mkb_fechaSalida.Size = New System.Drawing.Size(76, 23)
        Me.mkb_fechaSalida.TabIndex = 13
        Me.mkb_fechaSalida.ValidatingType = GetType(Date)
        '
        'mkb_fechaEntrada
        '
        Me.mkb_fechaEntrada.Location = New System.Drawing.Point(797, 27)
        Me.mkb_fechaEntrada.Mask = "00/00/0000"
        Me.mkb_fechaEntrada.Name = "mkb_fechaEntrada"
        Me.mkb_fechaEntrada.Size = New System.Drawing.Size(76, 23)
        Me.mkb_fechaEntrada.TabIndex = 12
        Me.mkb_fechaEntrada.ValidatingType = GetType(Date)
        '
        'txt_idConsulta
        '
        Me.txt_idConsulta.Enabled = False
        Me.txt_idConsulta.Location = New System.Drawing.Point(1037, 27)
        Me.txt_idConsulta.Name = "txt_idConsulta"
        Me.txt_idConsulta.Size = New System.Drawing.Size(76, 23)
        Me.txt_idConsulta.TabIndex = 11
        '
        'lbl_fechaSalida
        '
        Me.lbl_fechaSalida.AutoSize = True
        Me.lbl_fechaSalida.Location = New System.Drawing.Point(664, 55)
        Me.lbl_fechaSalida.Name = "lbl_fechaSalida"
        Me.lbl_fechaSalida.Size = New System.Drawing.Size(115, 16)
        Me.lbl_fechaSalida.TabIndex = 10
        Me.lbl_fechaSalida.Text = "Fecha de Salida:"
        '
        'lbl_fechaEntrada
        '
        Me.lbl_fechaEntrada.AutoSize = True
        Me.lbl_fechaEntrada.Location = New System.Drawing.Point(652, 30)
        Me.lbl_fechaEntrada.Name = "lbl_fechaEntrada"
        Me.lbl_fechaEntrada.Size = New System.Drawing.Size(127, 16)
        Me.lbl_fechaEntrada.TabIndex = 9
        Me.lbl_fechaEntrada.Text = "Fecha de Entrada:"
        '
        'lbl_idConsulta
        '
        Me.lbl_idConsulta.AutoSize = True
        Me.lbl_idConsulta.Location = New System.Drawing.Point(929, 30)
        Me.lbl_idConsulta.Name = "lbl_idConsulta"
        Me.lbl_idConsulta.Size = New System.Drawing.Size(87, 16)
        Me.lbl_idConsulta.TabIndex = 8
        Me.lbl_idConsulta.Text = "ID Consulta:"
        '
        'lbl_numeroDocumento
        '
        Me.lbl_numeroDocumento.AutoSize = True
        Me.lbl_numeroDocumento.Location = New System.Drawing.Point(316, 55)
        Me.lbl_numeroDocumento.Name = "lbl_numeroDocumento"
        Me.lbl_numeroDocumento.Size = New System.Drawing.Size(238, 16)
        Me.lbl_numeroDocumento.TabIndex = 7
        Me.lbl_numeroDocumento.Text = "Número de Documento Empleado:"
        '
        'lbl_tipoDocumento
        '
        Me.lbl_tipoDocumento.AutoSize = True
        Me.lbl_tipoDocumento.Location = New System.Drawing.Point(342, 30)
        Me.lbl_tipoDocumento.Name = "lbl_tipoDocumento"
        Me.lbl_tipoDocumento.Size = New System.Drawing.Size(212, 16)
        Me.lbl_tipoDocumento.TabIndex = 6
        Me.lbl_tipoDocumento.Text = "Tipo de Documento Empleado:"
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Location = New System.Drawing.Point(111, 55)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(63, 16)
        Me.lbl_sucursal.TabIndex = 5
        Me.lbl_sucursal.Text = "Sucursal:"
        '
        'lbl_nroHistClinicaCons
        '
        Me.lbl_nroHistClinicaCons.AutoSize = True
        Me.lbl_nroHistClinicaCons.Location = New System.Drawing.Point(20, 30)
        Me.lbl_nroHistClinicaCons.Name = "lbl_nroHistClinicaCons"
        Me.lbl_nroHistClinicaCons.Size = New System.Drawing.Size(164, 16)
        Me.lbl_nroHistClinicaCons.TabIndex = 4
        Me.lbl_nroHistClinicaCons.Text = "Número Historia Clinica:"
        '
        'cbo_nroDocCons
        '
        Me.cbo_nroDocCons.FormattingEnabled = True
        Me.cbo_nroDocCons.Location = New System.Drawing.Point(560, 47)
        Me.cbo_nroDocCons.Name = "cbo_nroDocCons"
        Me.cbo_nroDocCons.Size = New System.Drawing.Size(77, 24)
        Me.cbo_nroDocCons.TabIndex = 3
        '
        'cbo_tipoDocCons
        '
        Me.cbo_tipoDocCons.FormattingEnabled = True
        Me.cbo_tipoDocCons.Location = New System.Drawing.Point(560, 22)
        Me.cbo_tipoDocCons.Name = "cbo_tipoDocCons"
        Me.cbo_tipoDocCons.Size = New System.Drawing.Size(77, 24)
        Me.cbo_tipoDocCons.TabIndex = 2
        '
        'cbo_sucursalCons
        '
        Me.cbo_sucursalCons.FormattingEnabled = True
        Me.cbo_sucursalCons.Location = New System.Drawing.Point(190, 50)
        Me.cbo_sucursalCons.Name = "cbo_sucursalCons"
        Me.cbo_sucursalCons.Size = New System.Drawing.Size(101, 24)
        Me.cbo_sucursalCons.TabIndex = 1
        '
        'cbo_nroHistClinicaCons
        '
        Me.cbo_nroHistClinicaCons.FormattingEnabled = True
        Me.cbo_nroHistClinicaCons.Location = New System.Drawing.Point(190, 24)
        Me.cbo_nroHistClinicaCons.Name = "cbo_nroHistClinicaCons"
        Me.cbo_nroHistClinicaCons.Size = New System.Drawing.Size(101, 24)
        Me.cbo_nroHistClinicaCons.TabIndex = 0
        '
        'gro_buscarAtencionFechaDesdeHasta
        '
        Me.gro_buscarAtencionFechaDesdeHasta.Controls.Add(Me.lbl_buscarHasta)
        Me.gro_buscarAtencionFechaDesdeHasta.Controls.Add(Me.mkb_buscarDesde)
        Me.gro_buscarAtencionFechaDesdeHasta.Controls.Add(Me.btn_buscarAtencionFechaDesdeHasta)
        Me.gro_buscarAtencionFechaDesdeHasta.Controls.Add(Me.mkb_buscarHasta)
        Me.gro_buscarAtencionFechaDesdeHasta.Controls.Add(Me.lbl_buscarDesde)
        Me.gro_buscarAtencionFechaDesdeHasta.ForeColor = System.Drawing.Color.White
        Me.gro_buscarAtencionFechaDesdeHasta.Location = New System.Drawing.Point(905, 21)
        Me.gro_buscarAtencionFechaDesdeHasta.Name = "gro_buscarAtencionFechaDesdeHasta"
        Me.gro_buscarAtencionFechaDesdeHasta.Size = New System.Drawing.Size(371, 74)
        Me.gro_buscarAtencionFechaDesdeHasta.TabIndex = 23
        Me.gro_buscarAtencionFechaDesdeHasta.TabStop = False
        Me.gro_buscarAtencionFechaDesdeHasta.Text = "Buscar Por Fecha"
        '
        'lbl_buscarHasta
        '
        Me.lbl_buscarHasta.AutoSize = True
        Me.lbl_buscarHasta.Location = New System.Drawing.Point(6, 44)
        Me.lbl_buscarHasta.Name = "lbl_buscarHasta"
        Me.lbl_buscarHasta.Size = New System.Drawing.Size(92, 16)
        Me.lbl_buscarHasta.TabIndex = 22
        Me.lbl_buscarHasta.Text = "Fecha Hasta:"
        '
        'mkb_buscarDesde
        '
        Me.mkb_buscarDesde.Location = New System.Drawing.Point(106, 15)
        Me.mkb_buscarDesde.Mask = "00/00/0000"
        Me.mkb_buscarDesde.Name = "mkb_buscarDesde"
        Me.mkb_buscarDesde.Size = New System.Drawing.Size(89, 23)
        Me.mkb_buscarDesde.TabIndex = 19
        Me.mkb_buscarDesde.ValidatingType = GetType(Date)
        '
        'btn_buscarAtencionFechaDesdeHasta
        '
        Me.btn_buscarAtencionFechaDesdeHasta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarAtencionFechaDesdeHasta.Image = Global.Veterinaria.My.Resources.Resources.find
        Me.btn_buscarAtencionFechaDesdeHasta.Location = New System.Drawing.Point(209, 22)
        Me.btn_buscarAtencionFechaDesdeHasta.Name = "btn_buscarAtencionFechaDesdeHasta"
        Me.btn_buscarAtencionFechaDesdeHasta.Size = New System.Drawing.Size(57, 35)
        Me.btn_buscarAtencionFechaDesdeHasta.TabIndex = 18
        Me.btn_buscarAtencionFechaDesdeHasta.UseVisualStyleBackColor = True
        '
        'mkb_buscarHasta
        '
        Me.mkb_buscarHasta.Location = New System.Drawing.Point(104, 44)
        Me.mkb_buscarHasta.Mask = "00/00/0000"
        Me.mkb_buscarHasta.Name = "mkb_buscarHasta"
        Me.mkb_buscarHasta.Size = New System.Drawing.Size(88, 23)
        Me.mkb_buscarHasta.TabIndex = 20
        Me.mkb_buscarHasta.ValidatingType = GetType(Date)
        '
        'lbl_buscarDesde
        '
        Me.lbl_buscarDesde.AutoSize = True
        Me.lbl_buscarDesde.Location = New System.Drawing.Point(5, 18)
        Me.lbl_buscarDesde.Name = "lbl_buscarDesde"
        Me.lbl_buscarDesde.Size = New System.Drawing.Size(95, 16)
        Me.lbl_buscarDesde.TabIndex = 21
        Me.lbl_buscarDesde.Text = "Fecha Desde:"
        '
        'lbl_buscar
        '
        Me.lbl_buscar.AutoSize = True
        Me.lbl_buscar.Location = New System.Drawing.Point(13, 37)
        Me.lbl_buscar.Name = "lbl_buscar"
        Me.lbl_buscar.Size = New System.Drawing.Size(53, 16)
        Me.lbl_buscar.TabIndex = 24
        Me.lbl_buscar.Text = "Buscar:"
        '
        'txt_bucarAtencion
        '
        Me.txt_bucarAtencion.Location = New System.Drawing.Point(63, 34)
        Me.txt_bucarAtencion.Name = "txt_bucarAtencion"
        Me.txt_bucarAtencion.Size = New System.Drawing.Size(150, 23)
        Me.txt_bucarAtencion.TabIndex = 25
        '
        'btn_buscarConsulta
        '
        Me.btn_buscarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarConsulta.Image = Global.Veterinaria.My.Resources.Resources.find
        Me.btn_buscarConsulta.Location = New System.Drawing.Point(233, 28)
        Me.btn_buscarConsulta.Name = "btn_buscarConsulta"
        Me.btn_buscarConsulta.Size = New System.Drawing.Size(50, 39)
        Me.btn_buscarConsulta.TabIndex = 26
        Me.btn_buscarConsulta.UseVisualStyleBackColor = True
        '
        'chk_habilitarDesdeHasta
        '
        Me.chk_habilitarDesdeHasta.AutoSize = True
        Me.chk_habilitarDesdeHasta.Location = New System.Drawing.Point(16, 63)
        Me.chk_habilitarDesdeHasta.Name = "chk_habilitarDesdeHasta"
        Me.chk_habilitarDesdeHasta.Size = New System.Drawing.Size(136, 20)
        Me.chk_habilitarDesdeHasta.TabIndex = 27
        Me.chk_habilitarDesdeHasta.Text = "Buscar Por Fecha"
        Me.chk_habilitarDesdeHasta.UseVisualStyleBackColor = True
        '
        'gro_buscarAtencion
        '
        Me.gro_buscarAtencion.BackColor = System.Drawing.Color.Transparent
        Me.gro_buscarAtencion.Controls.Add(Me.chk_habilitarDesdeHasta)
        Me.gro_buscarAtencion.Controls.Add(Me.btn_buscarConsulta)
        Me.gro_buscarAtencion.Controls.Add(Me.txt_bucarAtencion)
        Me.gro_buscarAtencion.Controls.Add(Me.lbl_buscar)
        Me.gro_buscarAtencion.Controls.Add(Me.gro_buscarAtencionFechaDesdeHasta)
        Me.gro_buscarAtencion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gro_buscarAtencion.ForeColor = System.Drawing.Color.White
        Me.gro_buscarAtencion.Location = New System.Drawing.Point(10, 41)
        Me.gro_buscarAtencion.Name = "gro_buscarAtencion"
        Me.gro_buscarAtencion.Size = New System.Drawing.Size(1305, 101)
        Me.gro_buscarAtencion.TabIndex = 28
        Me.gro_buscarAtencion.TabStop = False
        Me.gro_buscarAtencion.Text = "Buscar Atenciones"
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_actualizar.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Atyourservice_Service_Categories_Cleaning
        Me.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_actualizar.Location = New System.Drawing.Point(1001, 714)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(54, 45)
        Me.btn_actualizar.TabIndex = 28
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_salir.BackgroundImage = Global.Veterinaria.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Location = New System.Drawing.Point(1171, 714)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(57, 45)
        Me.btn_salir.TabIndex = 27
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_guardarConsulta
        '
        Me.btn_guardarConsulta.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardarConsulta.BackgroundImage = Global.Veterinaria.My.Resources.Resources.save
        Me.btn_guardarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_guardarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarConsulta.Location = New System.Drawing.Point(1086, 714)
        Me.btn_guardarConsulta.Name = "btn_guardarConsulta"
        Me.btn_guardarConsulta.Size = New System.Drawing.Size(53, 45)
        Me.btn_guardarConsulta.TabIndex = 26
        Me.btn_guardarConsulta.UseVisualStyleBackColor = False
        '
        'frm_Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.frmAtencion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1327, 762)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardarConsulta)
        Me.Controls.Add(Me.gro_buscarAtencion)
        Me.Controls.Add(Me.gro_listaConsulta)
        Me.Controls.Add(Me.gro_datosConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Consulta"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gro_listaConsulta.ResumeLayout(False)
        CType(Me.dgv_listaConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gro_listaSintomasDisponibles.ResumeLayout(False)
        CType(Me.dgv_sintomasDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gro_listaDeDiagnosticosDisponibles.ResumeLayout(False)
        CType(Me.dgv_diagnosticosDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gro_listaMedicamentosT.ResumeLayout(False)
        CType(Me.dgv_medicamentosDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gro_datosConsulta.ResumeLayout(False)
        Me.gro_datosConsulta.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gro_medicamentosDispCarg.ResumeLayout(False)
        Me.gro_medicamentosDispCarg.PerformLayout()
        Me.gro_buscarAtencionFechaDesdeHasta.ResumeLayout(False)
        Me.gro_buscarAtencionFechaDesdeHasta.PerformLayout()
        Me.gro_buscarAtencion.ResumeLayout(False)
        Me.gro_buscarAtencion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gro_listaConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_listaConsultas As System.Windows.Forms.DataGridView
    Friend WithEvents gro_datosConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents mkb_fechaSalida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkb_fechaEntrada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_idConsulta As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fechaSalida As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaEntrada As System.Windows.Forms.Label
    Friend WithEvents lbl_idConsulta As System.Windows.Forms.Label
    Friend WithEvents lbl_numeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lbl_sucursal As System.Windows.Forms.Label
    Friend WithEvents lbl_nroHistClinicaCons As System.Windows.Forms.Label
    Friend WithEvents cbo_nroDocCons As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_tipoDocCons As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_sucursalCons As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_nroHistClinicaCons As System.Windows.Forms.ComboBox
    Friend WithEvents gro_buscarAtencionFechaDesdeHasta As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_buscarHasta As System.Windows.Forms.Label
    Friend WithEvents mkb_buscarDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_buscarAtencionFechaDesdeHasta As System.Windows.Forms.Button
    Friend WithEvents mkb_buscarHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_buscarDesde As System.Windows.Forms.Label
    Friend WithEvents lbl_buscar As System.Windows.Forms.Label
    Friend WithEvents txt_bucarAtencion As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscarConsulta As System.Windows.Forms.Button
    Friend WithEvents chk_habilitarDesdeHasta As System.Windows.Forms.CheckBox
    Friend WithEvents gro_buscarAtencion As System.Windows.Forms.GroupBox
    Friend WithEvents gro_medicamentosDispCarg As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_dispMed As System.Windows.Forms.Label
    Friend WithEvents btn_agregarMedicamento As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_dispDiag As System.Windows.Forms.Label
    Friend WithEvents btn_agregarDiagnostico As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_dispSint As System.Windows.Forms.Label
    Friend WithEvents btn_agregarSintoma As System.Windows.Forms.Button
    Friend WithEvents btn_nuevoMedicamento As System.Windows.Forms.Button
    Friend WithEvents btn_nuevoDiagnostico As System.Windows.Forms.Button
    Friend WithEvents btn_nuevoSintoma As System.Windows.Forms.Button
    Friend WithEvents txt_periodicidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_dosis As System.Windows.Forms.TextBox
    Friend WithEvents lbl_periodicidad As System.Windows.Forms.Label
    Friend WithEvents lbl_dosis As System.Windows.Forms.Label
    Friend WithEvents dgv_medicamentosDisponibles As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_medicamentosDisponibles As System.Windows.Forms.ComboBox
    Friend WithEvents gro_listaSintomasDisponibles As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_sintomasDisponibles As System.Windows.Forms.DataGridView
    Friend WithEvents gro_listaDeDiagnosticosDisponibles As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_diagnosticosDisponibles As System.Windows.Forms.DataGridView
    Friend WithEvents gro_listaMedicamentosT As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_diagnosticosDisponibles As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cargaSintomasDisponibles As System.Windows.Forms.ComboBox
    Friend WithEvents col_nroHistoriaClinicaCons As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idConsulta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipoDocCons As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroDocCons As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaEntrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaSalida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevoPerro As System.Windows.Forms.Button
    Friend WithEvents col_idSintomaT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcionSintomaT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idDiagnosticoT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idMedicamentoT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcionMedicamentoT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_dosis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_periodicidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_quitarDiagnostico As System.Windows.Forms.Button
    Friend WithEvents btn_quitarSintoma As System.Windows.Forms.Button
    Friend WithEvents btn_quitarMedicamento As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_guardarConsulta As System.Windows.Forms.Button
End Class
