Public Class frm_editarPerro

    Private Sub frm_editarPerro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_cbo(cbo_idDueñoEditar, "Dueños", "id_dueño", "nombre")
        load_cbo(cbo_idRazaEditar, "Razas", "id_raza", "denominacion")
        load_cbo(cbo_idSucursalEditar, "Sucursales", "id_sucursal", "nombre")
        llenarGrid()
        btn_eliminarPerro.Enabled = False
        btn_buscarPerro.Enabled = False
        gro_datosPerroEditar.Enabled = False
    End Sub
    Friend Sub load_cbo(ByVal cbo As ComboBox, ByVal table_name As String, ByVal pk As String, ByVal desc As String) '
        Dim table As DataTable = BDHelper.getDBHelper.ConsultaSQL("SELECT " + pk + "," + desc + " FROM " + table_name) '
        cbo.DataSource = table
        cbo.DisplayMember = desc
        cbo.ValueMember = pk
        cbo.SelectedIndex = -1
    End Sub
    Private Sub btn_buscarPerro_Click(sender As Object, e As EventArgs) Handles btn_buscarPerro.Click
        Try
            btn_eliminarPerro.Enabled = True
            Dim oPerroService = New PerroService
            dgv_listaPerrosEditar.Rows.Clear()
            For Each oPerro In oPerroService.buscarPerros(txt_buscarPerro.Text)
                With oPerro
                    dgv_listaPerrosEditar.Rows.Add(New String() {.nro_historiaClinica, .id_sucursal, .nombre, .fecha_nacimiento, .id_raza, .id_dueño, .peso, .altura})
                End With

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Friend Sub llenarGrid(Optional ByVal lst As List(Of Perro) = Nothing)
        Dim oPerroService As New PerroService
        dgv_listaPerrosEditar.Rows.Clear()

        If IsNothing(lst) Then
            lst = oPerroService.listarPerros()
        End If

        dgv_listaPerrosEditar.Rows.Clear()
        For Each oPerro In lst
            With oPerro
                dgv_listaPerrosEditar.Rows.Add(New String() {.nro_historiaClinica, .id_sucursal, .nombre, .fecha_nacimiento, .id_raza, .id_dueño, .peso, .altura})
            End With
        Next

    End Sub

    Private Sub btn_eliminarPerro_Click(sender As Object, e As EventArgs) Handles btn_eliminarPerro.Click
        Try
            If MessageBox.Show("¿Esta seguro que desea eliminar al Perro seleccionado?",
                          "Aviso", MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Dim oPerroService = New PerroService
                oPerroService.eliminarPerros(dgv_listaPerrosEditar.CurrentRow.Cells.Item("col_nroHistoriaClinicaEditar").Value, dgv_listaPerrosEditar.CurrentRow.Cells.Item("col_idSucursalEditar").Value)
                llenarGrid()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btn_SalirEditar_Click(sender As Object, e As EventArgs) Handles btn_SalirEditar.Click
        If MessageBox.Show("Seguro que desea salir",
                          "Importante", MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub
    Private Sub btn_guardarPerroEditar_Click(sender As Object, e As EventArgs) Handles btn_guardarPerroEditar.Click
        Try
            If frm_cargaEmpleado.validar_componentes_completos(gro_datosPerroEditar) = True Then

            Else
                If frm_cargaEmpleado.validarFechaActual(mkb_fechaNacimientoEditar) = False Then
                    mkb_fechaNacimientoEditar.Focus()
                    Exit Sub
                End If

                Dim oPerroService = New PerroService
                Dim oPerro = New Perro
                oPerro.nro_historiaClinica = txt_nroHistoriaClinicaEditar.Text
                oPerro.id_sucursal = cbo_idSucursalEditar.SelectedValue
                oPerro.nombre = txt_nombrePerroEditar.Text
                oPerro.fecha_nacimiento = mkb_fechaNacimientoEditar.Text
                oPerro.id_raza = cbo_idRazaEditar.SelectedValue
                oPerro.peso = txt_pesoEditar.Text
                oPerro.altura = txt_alturaEditar.Text
                oPerro.id_dueño = cbo_idDueñoEditar.SelectedValue
                oPerroService.modificarPerros(oPerro)
                llenarGrid()
                frm_cargaEmpleado.limpiar_componentes(gro_datosPerroEditar)
                gro_datosPerroEditar.Enabled = False
            End If
Catch ex As Exception
            Throw ex
        End Try
        
    End Sub

    

    Private Sub dgv_listaPerrosEditar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaPerrosEditar.CellContentDoubleClick
        txt_nroHistoriaClinicaEditar.Enabled = False
        cbo_idSucursalEditar.Enabled = True
        cbo_idSucursalEditar.SelectedIndex = dgv_listaPerrosEditar.CurrentRow.Cells.Item("col_idSucursalEditar").Value - 1
        txt_nroHistoriaClinicaEditar.Text = dgv_listaPerrosEditar.CurrentRow.Cells.Item("col_nroHistoriaClinicaEditar").Value
        txt_nombrePerroEditar.Text = dgv_listaPerrosEditar.CurrentRow.Cells.Item("col_nombrePerroEditar").Value.ToString
        mkb_fechaNacimientoEditar.Text = dgv_listaPerrosEditar.CurrentRow.Cells("col_fechaNacimientoPerroEditar").Value.ToString
        cbo_idRazaEditar.SelectedIndex = dgv_listaPerrosEditar.CurrentRow.Cells("col_idRazaEditar").Value - 1
        cbo_idDueñoEditar.SelectedIndex = dgv_listaPerrosEditar.CurrentRow.Cells("col_idDueñoEditar").Value - 1
        txt_pesoEditar.Text = dgv_listaPerrosEditar.CurrentRow.Cells("col_pesoEditar").Value
        txt_alturaEditar.Text = dgv_listaPerrosEditar.CurrentRow.Cells("col_alturaEditar").Value

        btn_SalirEditar.Enabled = True
        gro_datosPerroEditar.Enabled = True
        btn_eliminarPerro.Enabled = True
    End Sub
    Private Sub txt_buscarPerro_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscarPerro.KeyUp
        If txt_buscarPerro.Text = String.Empty Then
            btn_buscarPerro.Enabled = False
            llenarGrid()
        End If

    End Sub

    Private Sub txt_buscarPerro_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarPerro.TextChanged
        If txt_buscarPerro.Text = String.Empty Then
        Else
            btn_buscarPerro.Enabled = True
        End If
    End Sub
    Private Sub txt_nombrePerro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombrePerroEditar.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pesoEditar.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_altura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_alturaEditar.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_nroHistoriaClinica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nroHistoriaClinicaEditar.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

End Class