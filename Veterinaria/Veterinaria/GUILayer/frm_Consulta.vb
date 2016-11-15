Public Class frm_Consulta
    Private lst_medicamentosxConsulta As New List(Of MedicamentoxConsulta)
    Private lst_sintomaxConsulta As New List(Of SintomaxConsulta)
    Private lst_diagnosticoxConsulta As New List(Of DiagnosticoxConsulta)
    Private str = "SELECT MAX(id_consulta) FROM Consultas"
    Private Sub frm_cargaConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gro_buscarAtencionFechaDesdeHasta.Enabled = False
        Dim oConsultaService As ConsultaService = New ConsultaService
        dgv_listaConsultas.Rows.Clear()
        dgv_diagnosticosDisponibles.Rows.Clear()
        dgv_medicamentosDisponibles.Rows.Clear()
        dgv_sintomasDisponibles.Rows.Clear()
        gro_datosConsulta.Enabled = True
        txt_idConsulta.Enabled = False

        load_cbo(cbo_cargaSintomasDisponibles, "Sintomas", "id_sintoma", "descripcion")
        load_cbo(cbo_diagnosticosDisponibles, "Diagnosticos", "id_diagnostico", "descripcion")
        load_cbo(cbo_medicamentosDisponibles, "Medicamentos", "id_medicamento", "descripcion")
        load_cbo(cbo_tipoDocCons, "TipoDocumento", "id_tipo", "descripcion")
        load_cbo(cbo_nroHistClinicaCons, "Perros", "nro_historia_clinica", "nro_historia_clinica")
        load_cbo(cbo_sucursalCons, "Sucursales", "id_sucursal", "nombre")
        load_cbo(cbo_nroDocCons, "Empleados", "nro_doc", "nro_doc")
        oConsultaService.autoIncrementarID(Str, txt_idConsulta)
    End Sub
   


    Public Sub load_cbo(ByVal cbo As ComboBox, ByVal table_name As String, ByVal pk As String, ByVal desc As String)
        Dim table As DataTable = BDHelper.getDBHelper().ConsultaSQL("SELECT " + pk + "," + desc + " FROM " + table_name)
        cbo.DataSource = table
        cbo.DisplayMember = desc
        cbo.ValueMember = pk
        cbo.SelectedIndex = -1
    End Sub
    Private Sub btn_buscarConsulta_Click(sender As Object, e As EventArgs) Handles btn_buscarConsulta.Click
        Dim oConsultaService = New ConsultaService
        Try
            Dim oConsulta = New Consulta

            dgv_listaConsultas.Rows.Clear()
            For Each oConsulta In oConsultaService.buscarConsulta(txt_bucarAtencion.Text)
                With oConsulta
                    dgv_listaConsultas.Rows.Add(New String() {.nro_historiaClinica, .id_consulta, .tipoDocEmpleado, .nroDocEmpleado, .fechaEntrada, .fechaSalida})
                End With

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub






    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MessageBox.Show("¿Seguro que desea salir?",
                           "Importante", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            frm_cargaEmpleado.limpiar_componentes(gro_datosConsulta)
            frm_cargaEmpleado.limpiar_componentes(gro_listaDeDiagnosticosDisponibles)
            frm_cargaEmpleado.limpiar_componentes(gro_medicamentosDispCarg)
            frm_cargaEmpleado.limpiar_componentes(gro_listaSintomasDisponibles)
            Me.Close()
            End If


    End Sub

    Private Sub chk_habilitarDesdeHasta_CheckedChanged(sender As Object, e As EventArgs) Handles chk_habilitarDesdeHasta.CheckedChanged
        If chk_habilitarDesdeHasta.Checked = True Then
            gro_buscarAtencionFechaDesdeHasta.Enabled = True
        Else
            gro_buscarAtencionFechaDesdeHasta.Enabled = False
        End If

    End Sub


    Private Sub btn_nuevoMedicamento_Click(sender As Object, e As EventArgs) Handles btn_nuevoMedicamento.Click
        frm_cargaMedicamento.action = frm_cargaMedicamento.carga.otroForm
        MsgBox(frm_cargaMedicamento.action)
        frm_cargaMedicamento.ShowDialog()



    End Sub

    Private Sub btn_nuevoSintoma_Click(sender As Object, e As EventArgs) Handles btn_nuevoSintoma.Click
        frm_cargaSintoma.action = frm_cargaSintoma.cargaSintoma.otroForm
        frm_cargaSintoma.ShowDialog()


    End Sub

    Private Sub btn_nuevoDiagnostico_Click(sender As Object, e As EventArgs) Handles btn_nuevoDiagnostico.Click
        frm_cargaDiagnostico.ShowDialog()
        frm_cargaDiagnostico.action = frm_cargaDiagnostico.cargaDiagnostico.otroForm
    End Sub

    Public Function obtenerNombreMedicamentos(ByVal id As Integer) As String
        Dim str = "SELECT descripcion FROM Medicamentos WHERE id_medicamento=" & id
        Dim tabla As DataTable = BDHelper.getDBHelper.ConsultaSQL(str)
        Dim nombreMedicamento As String
        Dim oMedicamento As New Medicamento
        For Each row As DataRow In tabla.Rows
            oMedicamento.descripcion = row.Item("descripcion").ToString
        Next
        nombreMedicamento = oMedicamento.descripcion
        Return nombreMedicamento
    End Function

    Public Function obtenerNombreDiagnosticos(ByVal id As Integer) As String
        Dim str = "SELECT descripcion FROM Diagnosticos WHERE id_diagnostico=" & id
        Dim tabla As DataTable = BDHelper.getDBHelper.ConsultaSQL(str)
        Dim nombreDiagnostico As String
        Dim oDiagnostico As New Diagnostico
        For Each row As DataRow In tabla.Rows
            oDiagnostico.descripcion = row.Item("descripcion").ToString
        Next
        nombreDiagnostico = oDiagnostico.descripcion
        Return nombreDiagnostico
    End Function

    Public Function obtenerNombreSintomas(ByVal id As Integer) As String
        Dim str = "SELECT descripcion FROM Sintomas WHERE id_sintoma=" & id
        Dim tabla As DataTable = BDHelper.getDBHelper.ConsultaSQL(str)
        Dim nombreSintoma As String
        Dim oSintoma As New Sintoma
        For Each row As DataRow In tabla.Rows
            oSintoma.descripcion = row.Item("descripcion").ToString
        Next
        nombreSintoma = oSintoma.descripcion
        Return nombreSintoma
    End Function


    Private Sub btn_guardarConsulta_Click(sender As Object, e As EventArgs) Handles btn_guardarConsulta.Click
        Dim oConsultaService As New ConsultaService
        Dim oConsulta As New Consulta
        Dim oMedicamentoxConsulta As MedicamentoxConsulta
        Dim oDiagnosticoxConsulta As New DiagnosticoxConsulta
        Dim oSintomaxConsulta As SintomaxConsulta

        oConsulta.nro_historiaClinica = cbo_nroHistClinicaCons.SelectedValue
        oConsulta.id_sucursal = cbo_sucursalCons.SelectedValue
        oConsulta.id_consulta = txt_idConsulta.Text
        oConsulta.nroDocEmpleado = cbo_nroDocCons.Text
        oConsulta.tipoDocEmpleado = cbo_tipoDocCons.Text
        oConsulta.fechaSalida = mkb_fechaSalida.Text
        oConsulta.fechaEntrada = mkb_fechaEntrada.Text

        For Each row As DataGridViewRow In dgv_medicamentosDisponibles.Rows
            oMedicamentoxConsulta = New MedicamentoxConsulta
            With oMedicamentoxConsulta
                .id_consulta = txt_idConsulta.Text
                .id_sucursal = cbo_sucursalCons.SelectedValue
                .nro_historia_clinica = cbo_nroHistClinicaCons.SelectedValue
                .id_medicamento = row.Cells.Item("col_idMedicamentoT").Value
                .dosis = row.Cells.Item("col_dosis").Value
                .periodicidad = row.Cells.Item("col_periodicidad").Value

            End With
            lst_medicamentosxConsulta.Add(oMedicamentoxConsulta)
        Next

        For Each row As DataGridViewRow In dgv_sintomasDisponibles.Rows
            oSintomaxConsulta = New SintomaxConsulta
            With oSintomaxConsulta
                .nro_historia_clinica = cbo_nroHistClinicaCons.SelectedValue
                .id_sucursal = cbo_sucursalCons.SelectedValue
                .id_consulta = txt_idConsulta.Text
                .id_sintoma = row.Cells.Item("col_idSintomaT").Value
            End With
            lst_sintomaxConsulta.Add(oSintomaxConsulta)
        Next

        For Each row As DataGridViewRow In dgv_diagnosticosDisponibles.Rows
            oDiagnosticoxConsulta = New DiagnosticoxConsulta
            With oDiagnosticoxConsulta
                .nro_historia_clinica = cbo_nroHistClinicaCons.SelectedValue
                .id_sucursal = cbo_sucursalCons.SelectedValue
                .id_consulta = txt_idConsulta.Text
                .id_diagnostico = row.Cells.Item("col_idDiagnosticoT").Value
            End With
            lst_diagnosticoxConsulta.Add(oDiagnosticoxConsulta)
        Next
        oConsultaService.guardarConsulta(oConsulta, lst_medicamentosxConsulta, lst_sintomaxConsulta, lst_diagnosticoxConsulta)
        dgv_sintomasDisponibles.Rows.Clear()
        dgv_medicamentosDisponibles.Rows.Clear()
        dgv_diagnosticosDisponibles.Rows.Clear()
        oConsultaService.autoIncrementarID(Str, txt_idConsulta)
    End Sub


    Private Sub btn_agregarMedicamento_Click(sender As Object, e As EventArgs) Handles btn_agregarMedicamento.Click
        If frm_cargaEmpleado.validar_componentes_completos(gro_datosConsulta) = True Or frm_cargaEmpleado.validar_componentes_completos(gro_medicamentosDispCarg) = True Then
            Exit Sub
        Else
            Dim oMedicamentoxConsulta As New MedicamentoxConsulta
            oMedicamentoxConsulta.id_medicamento = cbo_medicamentosDisponibles.SelectedValue
            dgv_medicamentosDisponibles.Rows.Add(New String() {oMedicamentoxConsulta.id_medicamento, cbo_medicamentosDisponibles.Text, txt_dosis.Text, txt_periodicidad.Text})

        End If
        
    End Sub

    Private Sub btn_agregarSintoma_Click(sender As Object, e As EventArgs) Handles btn_agregarSintoma.Click
        If frm_cargaEmpleado.validar_componentes_completos(gro_datosConsulta) = True Then
            Exit Sub
        Else
            dgv_sintomasDisponibles.Rows.Add(New Object() {cbo_cargaSintomasDisponibles.SelectedValue, cbo_cargaSintomasDisponibles.Text})
        End If

    End Sub

    Private Sub btn_agregarDiagnostico_Click(sender As Object, e As EventArgs) Handles btn_agregarDiagnostico.Click
        If frm_cargaEmpleado.validar_componentes_completos(gro_datosConsulta) = True Then
            Exit Sub
        Else
            dgv_diagnosticosDisponibles.Rows.Add(cbo_diagnosticosDisponibles.SelectedValue, cbo_diagnosticosDisponibles.Text)
        End If

    End Sub


    Private Sub dgv_listaConsultas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaConsultas.CellClick
        gro_datosConsulta.Enabled = False
        gro_medicamentosDispCarg.Enabled = False
        gro_listaSintomasDisponibles.Enabled = False
        gro_listaDeDiagnosticosDisponibles.Enabled = False
        Dim oMedicamentoxConsultaService As New MedicamentoxConsultaService
        Dim oDiagnosticoxConsultaService As New DiagnosticoxConsultaService
        Dim oSintomaxConsultaService As New SintomaxConsultaService
        dgv_medicamentosDisponibles.Rows.Clear()
        dgv_diagnosticosDisponibles.Rows.Clear()
        dgv_sintomasDisponibles.Rows.Clear()
        For Each oMedicamentoxConsulta In oMedicamentoxConsultaService.buscarMedicamentosxConsultas(dgv_listaConsultas.CurrentRow.Cells.Item("col_idConsulta").Value)
            dgv_medicamentosDisponibles.Rows.Add(New String() {oMedicamentoxConsulta.id_medicamento, obtenerNombreMedicamentos(oMedicamentoxConsulta.id_medicamento), oMedicamentoxConsulta.dosis, oMedicamentoxConsulta.periodicidad})
        Next
        For Each oDiagnosticoxConsulta In oDiagnosticoxConsultaService.buscarDiagnosticosxConsulta(dgv_listaConsultas.CurrentRow.Cells.Item("col_idConsulta").Value)
            dgv_diagnosticosDisponibles.Rows.Add(New String() {oDiagnosticoxConsulta.id_diagnostico, obtenerNombreDiagnosticos(oDiagnosticoxConsulta.id_diagnostico)})
        Next
        For Each oSintomaxConsulta In oSintomaxConsultaService.buscarSintomaxConsulta(dgv_listaConsultas.CurrentRow.Cells.Item("col_idConsulta").Value)
            dgv_sintomasDisponibles.Rows.Add(New String() {oSintomaxConsulta.id_sintoma, obtenerNombreSintomas(oSintomaxConsulta.id_sintoma)})
        Next
        Dim strSQL As String = "select * from Consultas where id_consulta = " & dgv_listaConsultas.CurrentRow.Cells("col_idConsulta").Value
        Dim tabla As DataTable = BDHelper.getDBHelper().ConsultaSQL(strSQL)
        Dim oConsulta As New Consulta
        For Each row As DataRow In tabla.Rows
            With oConsulta
                .id_consulta = row.Item("id_consulta")
                .fechaEntrada = row.Item("fecha_entrada")
                .fechaSalida = row.Item("fecha_salida")
                .id_sucursal = row.Item("id_sucursal")
                .nroDocEmpleado = row.Item("nro_documento_empl")
                .tipoDocEmpleado = row.Item("tipo_documento_empl")
                .nro_historiaClinica = row.Item("nro_historia_clinica")
            End With
        Next
        cbo_tipoDocCons.Text = oConsulta.tipoDocEmpleado
        cbo_sucursalCons.SelectedValue = oConsulta.id_sucursal
        cbo_nroHistClinicaCons.SelectedValue = oConsulta.nro_historiaClinica
        cbo_nroDocCons.SelectedValue = oConsulta.nroDocEmpleado
        mkb_fechaEntrada.Text = oConsulta.fechaEntrada
        mkb_fechaSalida.Text = oConsulta.fechaSalida
        txt_idConsulta.Text = oConsulta.id_consulta
    End Sub

    Private Sub btn_buscarAtencionFechaDesdeHasta_Click(sender As Object, e As EventArgs) Handles btn_buscarAtencionFechaDesdeHasta.Click
        Dim oConsultaService = New ConsultaService
        Try
            Dim oConsulta = New Consulta

            dgv_listaConsultas.Rows.Clear()
            For Each oConsulta In oConsultaService.buscarConsultaFecha(mkb_buscarDesde.Text, mkb_buscarHasta.Text)
                With oConsulta
                    dgv_listaConsultas.Rows.Add(New String() {.nro_historiaClinica, .id_consulta, .tipoDocEmpleado, .nroDocEmpleado, .fechaEntrada, .fechaSalida})
                End With

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Friend Function limpiar_componentes(ByVal box As GroupBox)
        'Funcion limpiar_componentes: Permite limpiar todos los campos de un formulario, independientemente del 
        'tipo de control

        For Each ctrl As Control In box.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = ctrl
                chk.Checked = False
            ElseIf TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = ctrl
                rb.Checked = False
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cbo As ComboBox = ctrl
                cbo.SelectedIndex = -1
            ElseIf (Not TypeOf ctrl Is Label) And (Not TypeOf ctrl Is Button) Then
                If ctrl Is (txt_idConsulta) Then
                Else
                    ctrl.Text = String.Empty
                End If


            End If
            ctrl.Enabled = True
        Next
        Return Nothing
    End Function


    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        dgv_listaConsultas.Rows.Clear()
        dgv_diagnosticosDisponibles.Rows.Clear()
        dgv_sintomasDisponibles.Rows.Clear()
        dgv_medicamentosDisponibles.Rows.Clear()
        limpiar_componentes(gro_datosConsulta)
        txt_idConsulta.Enabled = False
        frm_cargaEmpleado.limpiar_componentes(gro_buscarAtencion)
        gro_datosConsulta.Enabled = True
        gro_medicamentosDispCarg.Enabled = True
        gro_listaDeDiagnosticosDisponibles.Enabled = True
        gro_listaSintomasDisponibles.Enabled = True
        gro_buscarAtencionFechaDesdeHasta.Enabled = False
    End Sub

    Private Sub btn_nuevoPerro_Click(sender As Object, e As EventArgs) Handles btn_nuevoPerro.Click
        frm_cargaPerro.ShowDialog()
        frm_cargaPerro.action = frm_cargaPerro.cargaPerro.otroForm
    End Sub

    Private Sub btn_quitarMedicamento_Click(sender As Object, e As EventArgs) Handles btn_quitarMedicamento.Click
        If dgv_medicamentosDisponibles.RowCount > 0 Then
            dgv_medicamentosDisponibles.Rows.RemoveAt(dgv_medicamentosDisponibles.CurrentRow.Index)
        Else
            btn_quitarMedicamento.Enabled = False
        End If

    End Sub

    Private Sub btn_quitarSintoma_Click(sender As Object, e As EventArgs) Handles btn_quitarSintoma.Click
        If dgv_sintomasDisponibles.RowCount > 0 Then
            dgv_sintomasDisponibles.Rows.RemoveAt(dgv_sintomasDisponibles.CurrentRow.Index)
        Else
            btn_quitarSintoma.Enabled = False
        End If
    End Sub

    Private Sub btn_quitarDiagnostico_Click(sender As Object, e As EventArgs) Handles btn_quitarDiagnostico.Click
        If dgv_diagnosticosDisponibles.RowCount > 0 Then
            dgv_diagnosticosDisponibles.Rows.RemoveAt(dgv_diagnosticosDisponibles.CurrentRow.Index)
        Else
            btn_quitarDiagnostico.Enabled = False
        End If
    End Sub

    Private Sub dgv_listaConsultas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaConsultas.CellContentClick

    End Sub
End Class