Public Class frm_cargaMedicamento
    Enum carga
        esteForm

        otroForm
    End Enum
    Public action As carga

    Private listaMedicamentos As List(Of Medicamento)
    Private Sub frm_cargaMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaMedicamentos = New List(Of Medicamento)()
        Dim oMedicamentoService As MedicamentoService = New MedicamentoService
        Dim str = "SELECT MAX(id_medicamento) FROM Medicamentos"
        oMedicamentoService.autoIncrementarID(str, txt_idMedicamento)
        load_cbo(cbo_idLaboratorio, "Laboratorios", "id_laboratorio", "razon_social")
        dgv_cargaMedicamentos.Rows.Clear()
        btn_guardarMedicamento.Enabled = False




    End Sub

    Private Sub btn_agregarMedicamento_Click(sender As Object, e As EventArgs) Handles btn_agregarMedicamento.Click
        Try
            If frm_cargaEmpleado.validar_componentes_completos(gro_datosMedicamento) = True Then

            Else
                If frm_cargaEmpleado.validarFechaActual(mkb_fechaUltimaCompra) = False Then
                    mkb_fechaUltimaCompra.Focus()
                    Exit Sub
                End If
                Dim oMedicamento = New Medicamento
                Dim oMedicamentoService = New MedicamentoService
                Dim numero As Integer
                oMedicamento.id_medicamento = txt_idMedicamento.Text
                oMedicamento.descripcion = txt_descripcion.Text
                oMedicamento.id_laboratorio = cbo_idLaboratorio.SelectedValue
                oMedicamento.fecha_ultCompra = mkb_fechaUltimaCompra.Text
                listaMedicamentos.Add(oMedicamento)
                numero = txt_idMedicamento.Text
                dgv_cargaMedicamentos.Rows.Add(New Object() {oMedicamento.id_medicamento, oMedicamento.descripcion, oMedicamento.id_laboratorio, oMedicamento.fecha_ultCompra})
                ' frm_cargaEmpleado.limpiar_componentes(gro_datosMedicamento)
                txt_idMedicamento.Enabled = False
                txt_idMedicamento.Text = numero + 1
                btn_guardarMedicamento.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_guardarMedicamento_Click(sender As Object, e As EventArgs) Handles btn_guardarMedicamento.Click
        If action = carga.esteForm Then
            Try
                Dim numero = txt_idMedicamento.Text
                txt_idMedicamento.Text = numero
                For Each row As DataGridViewRow In dgv_cargaMedicamentos.Rows
                    Dim oMedicamentoService = New MedicamentoService
                    Dim oMedicamento = New Medicamento()
                    oMedicamento.id_medicamento = row.Cells("col_idMedicamento").Value
                    oMedicamento.descripcion = row.Cells("col_descripcion").Value
                    oMedicamento.id_laboratorio = row.Cells("col_idLaboratorio").Value
                    oMedicamento.fecha_ultCompra = row.Cells("col_fechaUltCompra").Value
                    oMedicamentoService.guardarMedicamentos(oMedicamento)
                    MessageBox.Show("El Medicamento " & oMedicamento.descripcion & " se ha guardado correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Next

            Catch ex As Exception
                Throw ex
            End Try
            dgv_cargaMedicamentos.Rows.Clear()
        ElseIf action = carga.otroForm Then
            Try
                Dim numero = txt_idMedicamento.Text
                txt_idMedicamento.Text = numero
                For Each row As DataGridViewRow In dgv_cargaMedicamentos.Rows
                    Dim oMedicamentoService = New MedicamentoService
                    Dim oMedicamento = New Medicamento()
                    oMedicamento.id_medicamento = row.Cells("col_idMedicamento").Value
                    oMedicamento.descripcion = row.Cells("col_descripcion").Value
                    oMedicamento.id_laboratorio = row.Cells("col_idLaboratorio").Value
                    oMedicamento.fecha_ultCompra = row.Cells("col_fechaUltCompra").Value
                    oMedicamentoService.guardarMedicamentos(oMedicamento)

                    MessageBox.Show("El Medicamento " & oMedicamento.descripcion & " guardado correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Next
                frm_Consulta.load_cbo(frm_Consulta.cbo_medicamentosDisponibles, "Medicamentos", "id_medicamento", "descripcion")


            Catch ex As Exception
                Throw ex
            End Try
            dgv_cargaMedicamentos.Rows.Clear()

            txt_idMedicamento.Enabled = False
        End If
    End Sub
    Friend Sub load_cbo(ByVal cbo As ComboBox, ByVal table_name As String, ByVal pk As String, ByVal desc As String) '
        Dim table As DataTable = BDHelper.getDBHelper.ConsultaSQL("SELECT " + pk + "," + desc + " FROM " + table_name) '
        cbo.DataSource = table
        cbo.DisplayMember = desc
        cbo.ValueMember = pk
    End Sub

    Private Sub btn_salirLaboratorio_Click(sender As Object, e As EventArgs) Handles btn_salirLaboratorio.Click
        'Confirmación de salida.
        If MessageBox.Show("¿Seguro que desea salir?",
                           "Importante", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then Me.Close()
    End Sub

    Private Sub txt_descripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descripcion.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub mkb_fechaUltimaCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mkb_fechaUltimaCompra.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub
End Class