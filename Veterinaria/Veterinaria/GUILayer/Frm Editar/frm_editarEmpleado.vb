Public Class frm_editarEmpleado

    Private Sub frm_EliminarConsultarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        load_cbo(cbo_tipodocumentoEditar, "TipoDocumento", "id_tipo", "descripcion")
        load_cbo(cbo_sucursalEditar, "Sucursales", "id_sucursal", "nombre")
        llenarGrid()


    End Sub
    Friend Sub llenarGrid(Optional ByVal lst As List(Of Empleado) = Nothing)
        Dim oEmpleadoService As New EmpleadoService
        dgv_datosEmpleados.Rows.Clear()

        If IsNothing(lst) Then
            lst = oEmpleadoService.listarEmpleados()
        End If

        dgv_datosEmpleados.Rows.Clear()
        For Each oEmpleado In lst
            With oEmpleado
                'cargar filas del datagridview a partir de un array de strings
                dgv_datosEmpleados.Rows.Add(New String() {.tipo_doc.ToString, .nro_doc, .nombre, .apellido, .fecha_nacimiento, .fecha_ingreso, .matricula, .sucursal})
            End With
        Next
    End Sub

    Private Sub btn_buscarEmpleado_Click(sender As Object, e As EventArgs) Handles btn_buscarEmpleado.Click
        Try
            btn_eliminar.Enabled = True
            Dim oEmpleadoService As New EmpleadoService
            
                dgv_datosEmpleados.Rows.Clear()
        
            For Each oEmpleado In oEmpleadoService.buscarEmpleados(txt_nombre_buscar.Text)
                With oEmpleado
                    dgv_datosEmpleados.Rows.Add(New String() {.tipo_doc.ToString, .nro_doc, .nombre, .apellido, .fecha_nacimiento, .fecha_ingreso, .matricula, .sucursal})
                End With

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub dgv_datosEmpleados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosEmpleados.CellContentDoubleClick
        gro_datosEmpleadoEditar.Enabled = True
        btn_eliminar.Enabled = True
        txt_nombreempleadoEditar.Text = dgv_datosEmpleados.CurrentRow.Cells.Item("col_nombreEditar").Value.ToString
        txt_apellidoempleadoEditar.Text = dgv_datosEmpleados.CurrentRow.Cells.Item("col_apellidoEditar").Value.ToString
        txt_nrodocumentoEditar.Text = dgv_datosEmpleados.CurrentRow.Cells.Item("col_num_docEditar").Value.ToString
        mkb_fechanacimientoEditar.Text = dgv_datosEmpleados.CurrentRow.Cells("col_fechaNacEditar").Value.ToString
        mkb_fechaingresoEditar.Text = dgv_datosEmpleados.CurrentRow.Cells.Item("col_fechaIngresoEditar").Value.ToString
        txt_matriculaEditar.Text = dgv_datosEmpleados.CurrentRow.Cells.Item("col_matriculaEditar").Value.ToString
        cbo_sucursalEditar.Text = dgv_datosEmpleados.CurrentRow.Cells.Item("col_sucursalEditar").Value
    End Sub

    Private Sub btn_guardarCambios_Click(sender As Object, e As EventArgs) Handles btn_guardarCambios.Click
        Try
            If frm_cargaEmpleado.validar_componentes_completos(gro_datosEmpleadoEditar) = True Then

            Else
                If frm_cargaEmpleado.validarFechaActual(mkb_fechaingresoEditar) = False Then
                    mkb_fechaingresoEditar.Focus()
                    Exit Sub
                End If
                If frm_cargaEmpleado.validarFechaActual(mkb_fechanacimientoEditar) = False Then
                    mkb_fechanacimientoEditar.Focus()
                    Exit Sub
                End If
                If mkb_fechanacimientoEditar.Text > mkb_fechaingresoEditar.Text Then
                    MessageBox.Show("La fecha de ingreso no puede ser menor a la fecha de nacimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mkb_fechaingresoEditar.Focus()
                    Exit Sub
                End If
                If cbo_tipodocumentoEditar.Text = "DNI" And txt_nrodocumentoEditar.TextLength < 8 Then
                    MessageBox.Show("Numero de DNI incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_nrodocumentoEditar.Focus()
                    Exit Sub
                End If
                Dim oEmpleadoService = New EmpleadoService
                Dim oEmpleado = New Empleado
                oEmpleado.tipo_doc = cbo_tipodocumentoEditar.Text
                oEmpleado.nro_doc = txt_nrodocumentoEditar.Text
                oEmpleado.nombre = txt_nombreempleadoEditar.Text
                oEmpleado.apellido = txt_apellidoempleadoEditar.Text
                oEmpleado.fecha_nacimiento = mkb_fechanacimientoEditar.Text
                oEmpleado.fecha_ingreso = mkb_fechaingresoEditar.Text
                oEmpleado.matricula = txt_matriculaEditar.Text
                oEmpleado.sucursal = cbo_sucursalEditar.SelectedValue

                oEmpleadoService.modificarEmpleados(oEmpleado)
                llenarGrid()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub load_cbo(ByVal cbo As ComboBox, ByVal table_name As String, ByVal pk As String, ByVal desc As String) '
        gro_datosEmpleadoEditar.Enabled = False
        Dim table As DataTable = BDHelper.getDBHelper.ConsultaSQL("SELECT " + pk + "," + desc + " FROM " + table_name) '
        cbo.DataSource = table '
        cbo.DisplayMember = desc '
        cbo.ValueMember = pk '
    End Sub '

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir",
                           "Importante", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub


    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If MessageBox.Show("¿Esta seguro que desea eliminarlo?",
                           "Aviso", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim oEmpleadoService = New EmpleadoService
            oEmpleadoService.eliminarEmpleados(txt_nrodocumentoEditar.Text)
        End If
        llenarGrid()

    End Sub

    Private Sub txt_nombre_buscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_nombre_buscar.KeyUp
        If txt_nombre_buscar.Text = String.Empty Then
            llenarGrid()
            btn_buscarEmpleado.Enabled = False
        End If
    End Sub

    Private Sub txt_nombre_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre_buscar.TextChanged
        If txt_nombre_buscar.Text = String.Empty Then
        Else
            btn_buscarEmpleado.Enabled = True
        End If
    End Sub

    Private Sub mkb_fechanacimientoEditar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mkb_fechanacimientoEditar.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub mkb_fechaingresoEditar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mkb_fechaingresoEditar.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_nombreempleadoEditar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombreempleadoEditar.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_apellidoempleadoEditar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellidoempleadoEditar.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_nrodocumentoEditar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nrodocumentoEditar.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_matriculaEditar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_matriculaEditar.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub
End Class