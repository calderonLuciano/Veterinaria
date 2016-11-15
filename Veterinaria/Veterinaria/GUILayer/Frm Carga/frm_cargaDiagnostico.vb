Public Class frm_cargaDiagnostico
    Private listaDiagnostico As List(Of Diagnostico)
    Enum cargaDiagnostico
        esteForm
        otroForm
    End Enum
    Public action As cargaDiagnostico
    Private Sub btn_agregarDiagnosticobtn_agregarDiagnosticobtn_agregarDiagnostico_Click(sender As Object, e As EventArgs) Handles btn_agregarDiagnostico.Click
        Try
            If frm_cargaEmpleado.validar_componentes_completos(gro_datosDiagnostico) = True Then

            Else
                Dim oDiagnostico = New Diagnostico
                Dim numero As Integer
                oDiagnostico.id_diagnostico = txt_idDiagnostico.Text
                oDiagnostico.descripcion = txt_descripcionDiagnostico.Text
                listaDiagnostico.Add(oDiagnostico)
                numero = txt_idDiagnostico.Text
                dgv_listaDiagnosticos.Rows.Add(New Object() {oDiagnostico.id_diagnostico, oDiagnostico.descripcion})
                frm_cargaEmpleado.limpiar_componentes(gro_datosDiagnostico)

                txt_idDiagnostico.Text = numero + 1

            End If
            btn_guardarDiagnostico.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_guardarDiagnostico_Click(sender As Object, e As EventArgs) Handles btn_guardarDiagnostico.Click
        If action = cargaDiagnostico.esteForm Then
            Try
                Dim numero = txt_idDiagnostico.Text
                txt_idDiagnostico.Text = numero
                For Each row As DataGridViewRow In dgv_listaDiagnosticos.Rows
                    Dim oDiagnosticoService = New DiagnosticoService
                    Dim oDiagnostico = New Diagnostico()
                    oDiagnostico.id_diagnostico = row.Cells.Item("col_idDiagnostico").Value
                    oDiagnostico.descripcion = row.Cells.Item("col_descripcionDiagnostico").Value
                    oDiagnosticoService.guardarDiagnosticos(oDiagnostico)
                    MessageBox.Show("El diagnostico " & oDiagnostico.descripcion & " se ha guardado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Next
            Catch ex As Exception
                Throw ex
            End Try
            frm_cargaEmpleado.limpiar_componentes(gro_datosDiagnostico)
            frm_cargaEmpleado.limpiar_componentes(gro_listaDiagnosticos)
        ElseIf action = cargaDiagnostico.otroForm Then
            Try
                Dim numero = txt_idDiagnostico.Text
                txt_idDiagnostico.Text = numero
                For Each row As DataGridViewRow In dgv_listaDiagnosticos.Rows
                    Dim oDiagnosticoService = New DiagnosticoService
                    Dim oDiagnostico = New Diagnostico()
                    oDiagnostico.id_diagnostico = row.Cells.Item("col_idDiagnostico").Value
                    oDiagnostico.descripcion = row.Cells.Item("col_descripcionDiagnostico").Value
                    oDiagnosticoService.guardarDiagnosticos(oDiagnostico)

                    MessageBox.Show("El diagnostico " & oDiagnostico.descripcion & " se ha guardado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Next
                frm_Consulta.load_cbo(frm_Consulta.cbo_diagnosticosDisponibles, "Diagnosticos", "id_diagnostico", "descripcion")
            Catch ex As Exception
                Throw ex
            End Try
            frm_cargaEmpleado.limpiar_componentes(gro_datosDiagnostico)
            frm_cargaEmpleado.limpiar_componentes(gro_listaDiagnosticos)
        End If
    End Sub

    Private Sub btn_salirDiagnostico_Click(sender As Object, e As EventArgs) Handles btn_salirDiagnostico.Click
        Me.Close()
    End Sub

    Private Sub frm_cargaDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaDiagnostico = New List(Of Diagnostico)()
        btn_guardarDiagnostico.Enabled = False
        txt_idDiagnostico.Enabled = False
        Dim oDiagnosticoService As DiagnosticoService = New DiagnosticoService
        Dim str = "SELECT MAX(id_diagnostico) FROM Diagnosticos"
        oDiagnosticoService.autoIncrementarID(str, txt_idDiagnostico)
        dgv_listaDiagnosticos.Rows.Clear()
    End Sub
End Class