Public Class frm_cargaLaboratorio
    Private listaLaboratorio As List(Of Laboratorio)
    Private Sub frm_cargaLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaLaboratorio = New List(Of Laboratorio)()
        btn_guardarLaboratorio.Enabled = False
        Dim oMedicamentoService As MedicamentoService = New MedicamentoService
        Dim str = "SELECT MAX(id_laboratorio) FROM Laboratorios"
        oMedicamentoService.autoIncrementarID(str, txt_id_laboratorio)
        dgv_cargaLaboratorio.Rows.Clear()
    End Sub

    Private Sub btn_agregarLaboratorio_Click(sender As Object, e As EventArgs) Handles btn_agregarLaboratorio.Click
        Try
            If frm_cargaEmpleado.validar_componentes_completos(gro_datosLaboratorio) = True Then

            Else
                Dim oLaboratorio = New Laboratorio
                Dim numero As Integer
                oLaboratorio.id_laboratorio = txt_id_laboratorio.Text
                oLaboratorio.razonSocial = txt_razonSocial.Text
                oLaboratorio.direccion = txt_direccion.Text
                listaLaboratorio.Add(oLaboratorio)
                numero = txt_id_laboratorio.Text
                dgv_cargaLaboratorio.Rows.Add(New Object() {oLaboratorio.id_laboratorio, oLaboratorio.razonSocial.ToString, oLaboratorio.direccion.ToString})
                frm_cargaEmpleado.limpiar_componentes(gro_datosLaboratorio)
                txt_id_laboratorio.Enabled = False
                txt_id_laboratorio.Text = numero + 1

            End If
            btn_guardarLaboratorio.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_guardarLaboratorio_Click(sender As Object, e As EventArgs) Handles btn_guardarLaboratorio.Click
        Try
            Dim numero = txt_id_laboratorio.Text
            txt_id_laboratorio.Text = numero
            For Each row As DataGridViewRow In dgv_cargaLaboratorio.Rows
                Dim oLaboratorioService = New LaboratorioService
                Dim oLaboratorio = New Laboratorio()
                oLaboratorio.id_laboratorio = row.Cells("col_idLaboratorio").Value
                oLaboratorio.razonSocial = row.Cells("col_razonSocial").Value
                oLaboratorio.direccion = row.Cells("col_direccion").Value
                oLaboratorioService.guardarLaboratorios(oLaboratorio)
                MessageBox.Show("El laboratorio" & oLaboratorio.razonSocial & " se ha guardado correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Next
        Catch ex As Exception
            Throw ex
        End Try
        frm_cargaEmpleado.limpiar_componentes(gro_datosLaboratorio)
        frm_cargaEmpleado.limpiar_componentes(gro_listaLaboratios)
    End Sub


    Private Sub btn_salirLaboratorio_Click(sender As Object, e As EventArgs) Handles btn_salirLaboratorio.Click
        'Confirmación de salida.
        If MessageBox.Show("¿Seguro que desea salir?",
                           "Importante", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    
    Private Sub txt_razonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_razonSocial.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub
End Class