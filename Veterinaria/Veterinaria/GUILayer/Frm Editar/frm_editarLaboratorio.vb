Public Class frm_editarLaboratorio

    Private Sub frm_editarLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        btn_eliminar.Enabled = False
        btn_buscarLaboratorio.Enabled = False
        gro_datosLaboratorioEditar.Enabled = False
    End Sub
   
    Friend Sub llenarGrid(Optional ByVal lst As List(Of Laboratorio) = Nothing)
        Dim oLaboratorioService As New LaboratorioService
        dgv_listaLaboratoriosEditar.Rows.Clear()

        If IsNothing(lst) Then
            lst = oLaboratorioService.listarLaboratorios()
        End If

        dgv_listaLaboratoriosEditar.Rows.Clear()
        For Each oLaboratorio In lst
            With oLaboratorio
                'cargar filas del datagridview a partir de un array de strings
                dgv_listaLaboratoriosEditar.Rows.Add(New String() {.id_laboratorio.ToString, .razonSocial.ToString, .direccion.ToString})
            End With
        Next
    End Sub
    Private Sub btn_buscarLaboratorio_Click(sender As Object, e As EventArgs) Handles btn_buscarLaboratorio.Click
        Try
            btn_eliminar.Enabled = True
            Dim oLaboratorioService As New LaboratorioService
            dgv_listaLaboratoriosEditar.Rows.Clear()
            For Each oLaboratorio In oLaboratorioService.buscarLaboratorios(txt_buscarLaboratorioEditar.Text)
                With oLaboratorio
                    dgv_listaLaboratoriosEditar.Rows.Add(New String() {.id_laboratorio.ToString, .razonSocial.ToString, .direccion.ToString})
                End With

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub btn_guardarLaboratorioEditar_Click(sender As Object, e As EventArgs) Handles btn_guardarLaboratorioEditar.Click
        Dim oLaboratorioService = New LaboratorioService
        Dim oLaboratorio = New Laboratorio
        oLaboratorio.razonSocial = txt_razonSocialEditar.Text
        oLaboratorio.direccion = txt_direccionEditar.Text
        oLaboratorio.id_laboratorio = txt_idLaboratorioEditar.Text
        oLaboratorioService.modificarLaboratorios(oLaboratorio)
        llenarGrid()
        frm_cargaEmpleado.limpiar_componentes(gro_datosLaboratorioEditar)
        gro_datosLaboratorioEditar.Enabled = False
        txt_buscarLaboratorioEditar.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If MessageBox.Show("¿Esta seguro que desea eliminar al Laboratorio seleccionado?",
                          "Aviso", MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Dim oLaboratorioService = New LaboratorioService
                oLaboratorioService.eliminarLaboratorios(dgv_listaLaboratoriosEditar.CurrentRow.Cells.Item("col_razonSocial").Value)
                llenarGrid()
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub btn_salirEditar_Click(sender As Object, e As EventArgs) Handles btn_salirEditar.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir",
                           "Importante", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub dgv_listaLaboratoriosEditar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaLaboratoriosEditar.CellContentDoubleClick
        txt_idLaboratorioEditar.Text = dgv_listaLaboratoriosEditar.CurrentRow.Cells.Item("col_idLaboratorio").Value.ToString
        txt_razonSocialEditar.Text = dgv_listaLaboratoriosEditar.CurrentRow.Cells("col_razonSocial").Value.ToString
        txt_direccionEditar.Text = dgv_listaLaboratoriosEditar.CurrentRow.Cells("col_direccion").Value.ToString
        btn_salirEditar.Enabled = True
        gro_datosLaboratorioEditar.Enabled = True
        txt_idLaboratorioEditar.Enabled = False
        btn_eliminar.Enabled = True
    End Sub

    Private Sub txt_buscarLaboratorioEditar_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscarLaboratorioEditar.KeyUp
        If txt_buscarLaboratorioEditar.Text = String.Empty Then
            btn_buscarLaboratorio.Enabled = False
            llenarGrid()
        End If

    End Sub

    Private Sub txt_buscarLaboratorioEditar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarLaboratorioEditar.TextChanged
        If txt_buscarLaboratorioEditar.Text = String.Empty Then
        Else
            btn_buscarLaboratorio.Enabled = True
        End If
    End Sub

    Private Sub txt_razonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_razonSocialEditar.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub
End Class