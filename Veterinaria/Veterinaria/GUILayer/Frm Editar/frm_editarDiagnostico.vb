Public Class frm_editarDiagnostico

    Private Sub btn_buscarDiagnostico_Click(sender As Object, e As EventArgs) Handles btn_buscarDiagnostico.Click
        Try
            btn_eliminar.Enabled = True
            Dim oDiagnosticoService As New DiagnosticoService
            dgv_listaDiagnosticosEditar.Rows.Clear()
            For Each oDiagnostico In oDiagnosticoService.buscarDiagnosticos(txt_buscarDiagnostico.Text)
                With oDiagnostico
                    dgv_listaDiagnosticosEditar.Rows.Add(New String() {.id_diagnostico, .descripcion})
                End With

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Friend Sub llenarGrid(Optional ByVal lst As List(Of Diagnostico) = Nothing)
        Dim oDiagnosticoService As New DiagnosticoService
        dgv_listaDiagnosticosEditar.Rows.Clear()

        If IsNothing(lst) Then
            lst = oDiagnosticoService.listarDiagnosticos()
        End If

        dgv_listaDiagnosticosEditar.Rows.Clear()
        For Each oDiagnostico In lst
            With oDiagnostico
                'cargar filas del datagridview a partir de un array de strings
                dgv_listaDiagnosticosEditar.Rows.Add(New String() {.id_diagnostico, .descripcion})
            End With
        Next
    End Sub
    Private Sub btn_guardarDiagnosticoEditar_Click(sender As Object, e As EventArgs) Handles btn_guardarDiagnosticoEditar.Click
        Dim oDiagnosticoService = New DiagnosticoService
        Dim oDiagnostico = New Diagnostico
        oDiagnostico.id_diagnostico = txt_idDiagnosticoEditar.Text
        oDiagnostico.descripcion = txt_descripcionDiagnosticoEditar.Text
       
        oDiagnosticoService.modificarDiagnosticos(oDiagnostico)
        llenarGrid()
        txt_buscarDiagnostico.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If MessageBox.Show("¿Esta seguro que desea eliminarlo?",
                        "Aviso", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim oDiagnosticoService = New DiagnosticoService
            oDiagnosticoService.eliminarDiagnosticos(dgv_listaDiagnosticosEditar.CurrentRow.Cells.Item("col_idDiagnosticoEditar").Value)
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

    Private Sub frm_editarDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        gro_datosDiagnosticoEditar.Enabled = False
        btn_buscarDiagnostico.Enabled = False
        btn_eliminar.Enabled = False
    End Sub

   
    Private Sub dgv_listaDiagnosticosEditar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaDiagnosticosEditar.CellContentDoubleClick
        txt_idDiagnosticoEditar.Text = dgv_listaDiagnosticosEditar.CurrentRow.Cells.Item("col_idDiagnosticoEditar").Value
        txt_descripcionDiagnosticoEditar.Text = dgv_listaDiagnosticosEditar.CurrentRow.Cells.Item("col_descripcionDiagnosticoEditar").Value

        btn_eliminar.Enabled = True
        gro_datosDiagnosticoEditar.Enabled = True
        txt_idDiagnosticoEditar.Enabled = False
    End Sub

    Private Sub txt_buscarDiagnostico_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscarDiagnostico.KeyUp
        If txt_buscarDiagnostico.Text = String.Empty Then
            llenarGrid()
            btn_buscarDiagnostico.Enabled = False
        End If
    End Sub

    Private Sub txt_buscarDiagnostico_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarDiagnostico.TextChanged
        If txt_buscarDiagnostico.Text = String.Empty Then
        Else
            btn_buscarDiagnostico.Enabled = True
        End If
    End Sub

    Private Sub gro_datosDiagnosticoEditar_Enter(sender As Object, e As EventArgs) Handles gro_datosDiagnosticoEditar.Enter

    End Sub
End Class