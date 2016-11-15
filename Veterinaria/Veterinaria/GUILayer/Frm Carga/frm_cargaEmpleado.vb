Public Class frm_cargaEmpleado
    Private listaEmpleado As List(Of Empleado)
   
    Private Sub frm_cargaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaEmpleado = New List(Of Empleado)()
        load_cbo(cbo_tipodocumento, "TipoDocumento", "id_tipo", "descripcion")
        load_cbo(cbo_sucursal, "Sucursales", "id_sucursal", "nombre")
        btn_guardar.Enabled = False
        dgv_cargarEmpleado.Rows.Clear()
    End Sub
    Private Sub load_cbo(ByVal cbo As ComboBox, ByVal table_name As String, ByVal pk As String, ByVal desc As String) '
        Dim table As DataTable = BDHelper.getDBHelper.ConsultaSQL("SELECT " + pk + "," + desc + " FROM " + table_name) '
        cbo.DataSource = table
        cbo.DisplayMember = desc
        cbo.ValueMember = pk
    End Sub
    Friend Function validarFechaActual(ByVal mkb As MaskedTextBox) As Boolean
        Dim fec = CType(mkb.Text, System.DateTime)
        Dim hoy = CType(DateTime.Now.ToString("dd/MM/yyyy"), System.DateTime)
        If fec > hoy Then
            MessageBox.Show("La fehca ingresada: " + mkb.Text + " no puede ser posterior a la fecha del día", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (hoy.Year - 100) > fec.Year Then
            MessageBox.Show("La fecha ingresada: " + mkb.Text + " Tiene que ser mayor al año" + (hoy.Year - 100).ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Try
            If validar_componentes_completos(grb_datosempleado) = True Then

            Else
                If validarFechaActual(mkb_fechaIngreso) = False Then
                    mkb_fechaIngreso.Focus()
                    Exit Sub
                End If
                If validarFechaActual(mkb_fechaNac) = False Then
                    mkb_fechaNac.Focus()
                    Exit Sub
                End If
                If mkb_fechaNac.Text > mkb_fechaIngreso.Text Then
                    MessageBox.Show("La fecha de ingreso no puede ser menor a la fecha de nacimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mkb_fechaIngreso.Focus()
                    Exit Sub
                End If
                If cbo_tipodocumento.Text = "DNI" And txt_nrodocumento.TextLength < 8 Then
                    MessageBox.Show("Numero de DNI incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_nrodocumento.Focus()
                    Exit Sub
                End If
                Dim oEmpleado = New Empleado()
                oEmpleado.tipo_doc = cbo_tipodocumento.Text
                oEmpleado.nro_doc = txt_nrodocumento.Text
                oEmpleado.nombre = txt_nombreempleado.Text
                oEmpleado.apellido = txt_apellidoempleado.Text
                oEmpleado.fecha_nacimiento = mkb_fechaNac.Text
                oEmpleado.fecha_ingreso = mkb_fechaIngreso.Text
                oEmpleado.matricula = txt_matricula.Text
                oEmpleado.sucursal = cbo_sucursal.SelectedValue
                listaEmpleado.Add(oEmpleado)
                dgv_cargarEmpleado.Rows.Add(New Object() {oEmpleado.tipo_doc.ToString,
                                                          oEmpleado.nro_doc,
                                                          oEmpleado.nombre.ToString,
                                                          oEmpleado.apellido.ToString,
                                                          oEmpleado.fecha_nacimiento,
                                                          oEmpleado.fecha_ingreso,
                                                          oEmpleado.matricula,
                                                          oEmpleado.sucursal})
                limpiar_componentes(grb_datosempleado)
                btn_guardar.Enabled = True
                txt_nombreempleado.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            For Each row As DataGridViewRow In dgv_cargarEmpleado.Rows
                Dim oEmpleado = New Empleado()
                Dim oEmpleadoService = New EmpleadoService
                oEmpleado.tipo_doc = row.Cells("col_tipoDoc").Value
                oEmpleado.nro_doc = row.Cells("col_nroDoc").Value
                oEmpleado.nombre = row.Cells("col_nombre").Value
                oEmpleado.apellido = row.Cells("col_apellido").Value
                oEmpleado.fecha_nacimiento = row.Cells("col_fechaNacimiento").Value
                oEmpleado.fecha_ingreso = row.Cells("col_fechaIngreso").Value
                oEmpleado.matricula = row.Cells("col_matricula").Value
                oEmpleado.sucursal = row.Cells("col_sucursal").Value

                oEmpleadoService.guardarEmpleados(oEmpleado)
                MessageBox.Show("El empleado " & oEmpleado.nombre & " se ha guardado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Next
        Catch ex As Exception
            Throw ex
        End Try
        limpiar_componentes(grb_datosempleado)
        limpiar_componentes(grb_listaempleados)
    End Sub

    Friend Function limpiar_componentes(ByVal box As GroupBox)
        'Funcion limpiar_componentes: Permite limpiar todos los campos de un formulario, independientemente del 
        'tipo de control

        For Each ctrl As Control In box.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = ctrl
                chk.Checked = False
            ElseIf TypeOf ctrl Is DataGridView Then
                Dim dgv As DataGridView = ctrl
                dgv.Rows.Clear()
            ElseIf TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = ctrl
                rb.Checked = False
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cbo As ComboBox = ctrl
                cbo.SelectedIndex = -1
            ElseIf (Not TypeOf ctrl Is Label) And (Not TypeOf ctrl Is Button) Then

                ctrl.Text = String.Empty

            End If
            ctrl.Enabled = True
        Next
        Return Nothing
    End Function

    Friend Function validar_componentes_completos(ByVal box As GroupBox)
        Dim flag As Boolean = False
        For Each ctrl As Control In box.Controls

            If TypeOf ctrl Is MaskedTextBox Then
                Dim mkb As MaskedTextBox = ctrl
                If mkb.MaskCompleted = False Then
                    MessageBox.Show("Este campo es obligatorio",
                                   "Atencion",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information)
                    ctrl.Focus()
                    flag = True
                    Return flag
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                If ctrl.Text = String.Empty Then
                    MessageBox.Show("Este campo es obligatorio",
                                 "Atencion",
                                 MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                    ctrl.Focus()
                    flag = True
                    Return flag
                End If


            ElseIf TypeOf ctrl Is TextBox Then
                If ctrl.Text = String.Empty Then
                    MessageBox.Show("Este campo es obligatorio",
                                  "Atencion",
                                 MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                    ctrl.Focus()
                    flag = True
                    Return flag
                End If
            End If
        Next
        Return flag
    End Function
    Private Sub txt_matricula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nrodocumento.KeyPress
        If Not validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub
    'valida solo numeros en el campo numero de documento
    Private Sub txt_documento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_matricula.KeyPress
        If Not validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Friend Function validate_number(ByVal c As Char) As Boolean
        Dim flag As Boolean = True
        Select Case Asc(c)
            Case 4, 24, 19, 127, 13, 9, 15
                flag = False
        End Select
        If Not IsNumeric(c) Then
            flag = False
        End If
        Return flag
    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        'Confirmación de salida.
        If MessageBox.Show("¿Seguro que desea salir?",
                           "Importante", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub mkb_fechaNac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mkb_fechaNac.KeyPress
        If Not validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub mkb_fechaIngreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mkb_fechaIngreso.KeyPress
        If Not validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_nombreempleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombreempleado.KeyPress
        If validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_apellidoempleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellidoempleado.KeyPress
        If validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub
End Class