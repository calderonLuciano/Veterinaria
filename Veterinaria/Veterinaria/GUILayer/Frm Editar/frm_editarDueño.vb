Public Class frm_editarDueño

    Private Sub frm_editarDueño_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        gro_datosDueñoEditar.Enabled = False
        btn_buscarDueño.Enabled = False
        btn_eliminar.Enabled = False
    End Sub

    Friend Sub llenarGrid(Optional ByVal lst As List(Of Dueño) = Nothing)
        Dim oDueñoService As New DueñoService
        dgv_listaDueñosEditar.Rows.Clear()

        If IsNothing(lst) Then
            lst = oDueñoService.listarDueños()
        End If

        dgv_listaDueñosEditar.Rows.Clear()
        For Each oDueño In lst
            With oDueño
                'cargar filas del datagridview a partir de un array de strings
                dgv_listaDueñosEditar.Rows.Add(New String() {.id_dueño, .nombre, .apellido, .telefono})
            End With
        Next
    End Sub

    Private Sub btn_buscarDueño_Click(sender As Object, e As EventArgs) Handles btn_buscarDueño.Click
        Try
            btn_eliminar.Enabled = True
            Dim oDueñoService As New DueñoService
            dgv_listaDueñosEditar.Rows.Clear()
            For Each oDueño In oDueñoService.buscarDueños(txt_buscarDueño.Text)
                With oDueño
                    dgv_listaDueñosEditar.Rows.Add(New String() {.id_dueño, .nombre, .apellido, .telefono})
                End With

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btn_guardarDueñoEditar_Click(sender As Object, e As EventArgs) Handles btn_guardarDueñoEditar.Click
        Dim oDueñoService = New DueñoService
        Dim oDueño = New Dueño
        oDueño.id_dueño = txt_idDueñoEditar.Text
        oDueño.nombre = txt_nombreDueñoEditar.Text
        oDueño.apellido = txt_apellidoDueñoEditar.Text
        oDueño.telefono = txt_telefonoDueñoEditar.Text
        oDueñoService.modificarDueños(oDueño)
        llenarGrid()
        frm_cargaEmpleado.limpiar_componentes(gro_datosDueñoEditar)
        txt_buscarDueño.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If MessageBox.Show("¿Esta seguro que desea eliminarlo?",
                       "Aviso", MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim oDueñoService = New DueñoService
            oDueñoService.eliminarDueños(dgv_listaDueñosEditar.CurrentRow.Cells.Item("col_idDueñoEditar").Value)
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



    Private Sub dgv_listaDueñosEditar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaDueñosEditar.CellContentDoubleClick
        txt_idDueñoEditar.Text = dgv_listaDueñosEditar.CurrentRow.Cells.Item("col_idDueñoEditar").Value
        txt_nombreDueñoEditar.Text = dgv_listaDueñosEditar.CurrentRow.Cells.Item("col_nombreDueñoEditar").Value
        txt_apellidoDueñoEditar.Text = dgv_listaDueñosEditar.CurrentRow.Cells.Item("col_apellidoDueñoEditar").Value.ToString
        txt_telefonoDueñoEditar.Text = dgv_listaDueñosEditar.CurrentRow.Cells.Item("col_telefonoDueñoEditar").Value
        btn_eliminar.Enabled = True
        gro_datosDueñoEditar.Enabled = True
        txt_idDueñoEditar.Enabled = False
    End Sub

    Private Sub txt_buscarDueño_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscarDueño.KeyUp
        If txt_buscarDueño.Text = String.Empty Then
            llenarGrid()
            btn_buscarDueño.Enabled = False
        End If
    End Sub

    
    Private Sub txt_buscarDueño_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarDueño.TextChanged
        If txt_buscarDueño.Text = String.Empty Then
        Else
            btn_buscarDueño.Enabled = True
        End If
    End Sub
    Private Sub txt_telefonoDueño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefonoDueñoEditar.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_nombreDueño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombreDueñoEditar.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_apellidoDueño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellidoDueñoEditar.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub
End Class