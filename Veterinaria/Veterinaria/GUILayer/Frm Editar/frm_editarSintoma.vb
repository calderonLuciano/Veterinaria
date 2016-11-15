Public Class frm_editarSintoma

    Private Sub btn_buscarSintoma_Click(sender As Object, e As EventArgs) Handles btn_buscarSintoma.Click
        Try
            btn_eliminar.Enabled = True
            Dim oSintomaService As New SintomaService
            dgv_listaSintomasEditar.Rows.Clear()
            For Each oSintoma In oSintomaService.buscarSintoma(txt_buscarSintoma.Text)
                With oSintoma
                    dgv_listaSintomasEditar.Rows.Add(New String() {.id_sintoma, .descripcion})
                End With

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Friend Sub llenarGrid(Optional ByVal lst As List(Of Sintoma) = Nothing)
        Dim oSintomaService As New SintomaService
        dgv_listaSintomasEditar.Rows.Clear()

        If IsNothing(lst) Then
            lst = oSintomaService.listarSintomas()
        End If

        dgv_listaSintomasEditar.Rows.Clear()
        For Each oSintoma In lst
            With oSintoma
                'cargar filas del datagridview a partir de un array de strings
                dgv_listaSintomasEditar.Rows.Add(New String() {.id_sintoma, .descripcion})
            End With
        Next
    End Sub

    Private Sub btn_guardarSintomaEditar_Click(sender As Object, e As EventArgs) Handles btn_guardarSintomaEditar.Click
        Dim oSintomaService = New SintomaService
        Dim oSintoma = New Sintoma
        oSintoma.id_sintoma = txt_idSintomaEditar.Text
        oSintoma.descripcion = txt_descripcionSintomaEditar.Text

        oSintomaService.modificarSintomas(oSintoma)
        llenarGrid()
        txt_buscarSintoma.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If MessageBox.Show("¿Esta seguro que desea eliminarlo?",
                       "Aviso", MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim oSintomaService = New SintomaService
            oSintomaService.eliminarSintomas(dgv_listaSintomasEditar.CurrentRow.Cells.Item("col_idSintomaEditar").Value)
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

    Private Sub frm_editarSintoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        gro_datosSintomaEditar.Enabled = False
        btn_buscarSintoma.Enabled = False
        btn_eliminar.Enabled = False
    End Sub

    Private Sub dgv_listaSintomasEditar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaSintomasEditar.CellContentDoubleClick
        txt_idSintomaEditar.Text = dgv_listaSintomasEditar.CurrentRow.Cells.Item("col_idSintomaEditar").Value
        txt_descripcionSintomaEditar.Text = dgv_listaSintomasEditar.CurrentRow.Cells.Item("col_descripcionSintomaEditar").Value

        btn_eliminar.Enabled = True
        gro_datosSintomaEditar.Enabled = True
    End Sub

    Private Sub txt_buscarSintoma_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscarSintoma.KeyUp
        If txt_buscarSintoma.Text = String.Empty Then
            llenarGrid()
            btn_buscarSintoma.Enabled = False
        End If
    End Sub

    Private Sub txt_buscarSintoma_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarSintoma.TextChanged
        If txt_buscarSintoma.Text = String.Empty Then
        Else
            btn_buscarSintoma.Enabled = True
        End If
    End Sub

End Class