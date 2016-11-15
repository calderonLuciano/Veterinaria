Public Class frm_editarMedicamento

    Private Sub frm_editarMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        gro_datosMedicamentosEditar.Enabled = False
        btn_buscarMedicamento.Enabled = False
        btn_eliminarMedicamento.Enabled = False
    End Sub
    Friend Sub llenarGrid(Optional ByVal lst As List(Of Medicamento) = Nothing)
        Dim oMedicamentoService As New MedicamentoService
        dgv_editarMedicamentos.Rows.Clear()

        If IsNothing(lst) Then
            lst = oMedicamentoService.listarMedicamentos()
        End If

        dgv_editarMedicamentos.Rows.Clear()
        For Each oMedicamento In lst
            With oMedicamento
                'cargar filas del datagridview a partir de un array de strings
                dgv_editarMedicamentos.Rows.Add(New String() {.id_medicamento, .descripcion, .id_laboratorio, .fecha_ultCompra})
            End With
        Next
    End Sub
    Public Function buscarNombreMedicamento(ByVal id As Integer) As DataTable
        Dim str = "SELECT descripcion FROM Medicamentos WHERE id_medicamento=" & id
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Private Sub btn_buscarMedicamento_Click(sender As Object, e As EventArgs) Handles btn_buscarMedicamento.Click
        Try
            btn_eliminarMedicamento.Enabled = True
            Dim oMedicamentoService As New MedicamentoService
            dgv_editarMedicamentos.Rows.Clear()
            For Each oMedicamento In oMedicamentoService.buscarMedicamentos(txt_buscarMedicamento.Text)
                With oMedicamento
                    dgv_editarMedicamentos.Rows.Add(New String() {.id_medicamento, .descripcion, .id_laboratorio, .fecha_ultCompra})
                End With

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btn_guardarMedicamentoEditar_Click(sender As Object, e As EventArgs) Handles btn_guardarMedicamentoEditar.Click
        Try
            If frm_cargaEmpleado.validar_componentes_completos(gro_datosMedicamentosEditar) = True Then

            Else
                If frm_cargaEmpleado.validarFechaActual(mkb_fechaUltCompraEditar) = False Then
                    mkb_fechaUltCompraEditar.Focus()
                    Exit Sub
                End If

                Dim oMedicamentoService = New MedicamentoService
                Dim oMedicamento = New Medicamento
                oMedicamento.id_medicamento = txt_idMedicamentoEditar.Text
                oMedicamento.descripcion = txt_descripcionEditar.Text
                oMedicamento.id_laboratorio = cbo_idLaboratorioEditar.SelectedValue
                oMedicamento.fecha_ultCompra = mkb_fechaUltCompraEditar.Text
                oMedicamentoService.modificarMedicamentos(oMedicamento)
                llenarGrid()
                frm_cargaEmpleado.limpiar_componentes(gro_datosMedicamentosEditar)
                gro_datosMedicamentosEditar.Enabled = False
                txt_buscarMedicamento.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
        
    End Sub

    Private Sub btn_eliminarMedicamento_Click(sender As Object, e As EventArgs) Handles btn_eliminarMedicamento.Click
        If MessageBox.Show("¿Esta seguro que desea eliminarlo?",
                        "Aviso", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim oMedicamentoService = New MedicamentoService
            oMedicamentoService.eliminarMedicamentos(dgv_editarMedicamentos.CurrentRow.Cells.Item("col_idMedicamentoEditar").Value)
            llenarGrid()
        End If
    End Sub

    Private Sub btn_salirEditar_Click(sender As Object, e As EventArgs) Handles btn_salirEditar.Click
        If MessageBox.Show("¿Seguro que desea salir?",
                          "Importante", MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    

    Private Sub dgv_editarMedicamentos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_editarMedicamentos.CellContentDoubleClick
        txt_idMedicamentoEditar.Text = dgv_editarMedicamentos.CurrentRow.Cells.Item("col_idMedicamentoEditar").Value
        txt_descripcionEditar.Text = dgv_editarMedicamentos.CurrentRow.Cells.Item("col_descripcionEditar").Value
        cbo_idLaboratorioEditar.Text = dgv_editarMedicamentos.CurrentRow.Cells.Item("col_idLaboratorioEditar").Value.ToString
        mkb_fechaUltCompraEditar.Text = dgv_editarMedicamentos.CurrentRow.Cells.Item("col_fechaUltCompraEditar").Value
        frm_cargaMedicamento.load_cbo(cbo_idLaboratorioEditar, "Laboratorios", "id_laboratorio", "id_laboratorio")
        btn_eliminarMedicamento.Enabled = True
        gro_datosMedicamentosEditar.Enabled = True
        txt_idMedicamentoEditar.Enabled = False
    End Sub

    Private Sub txt_buscarMedicamento_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscarMedicamento.KeyUp
        If txt_buscarMedicamento.Text = String.Empty Then
            llenarGrid()
            btn_buscarMedicamento.Enabled = False
        End If
    End Sub

    Private Sub txt_buscarMedicamento_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarMedicamento.TextChanged
        If txt_buscarMedicamento.Text = String.Empty Then
        Else
            btn_buscarMedicamento.Enabled = True
        End If
    End Sub
    Private Sub txt_descripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descripcionEditar.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub mkb_fechaUltimaCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mkb_fechaUltCompraEditar.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub
End Class