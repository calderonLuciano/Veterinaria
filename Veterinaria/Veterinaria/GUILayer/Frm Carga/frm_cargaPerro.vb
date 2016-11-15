Public Class frm_cargaPerro
    Private listaPerros As List(Of Perro)
    Enum cargaPerro
        esteForm
        otroForm
    End Enum
    Public action As cargaPerro
    Private Sub frm_cargaPerro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaPerros = New List(Of Perro)()
        Dim oPerroService As PerroService = New PerroService
        Dim str = "SELECT MAX(nro_historia_clinica) FROM Perros"
        oPerroService.autoIncrementarID(str, txt_nroHistoriaClinica)
        load_cbo(cbo_idDueño, "Dueños", "id_dueño", "nombre")
        load_cbo(cbo_idRaza, "Razas", "id_raza", "denominacion")
        load_cbo(cbo_idSucursal, "Sucursales", "id_sucursal", "nombre")
        dgv_listaPerros.Rows.Clear()
        btn_guardarPerro.Enabled = False
    End Sub

    Private Sub btn_agregarPerro_Click(sender As Object, e As EventArgs) Handles btn_agregarPerro.Click
        Try
            If frm_cargaEmpleado.validar_componentes_completos(gro_datosPerros) = True Then

            Else
                If frm_cargaEmpleado.validarFechaActual(mkb_fechaNacimiento) = False Then
                    mkb_fechaNacimiento.Focus()
                    Exit Sub
                End If

                Dim oPerro = New Perro
                Dim oPerroService = New PerroService
                Dim numero As Integer
                oPerro.nro_historiaClinica = txt_nroHistoriaClinica.Text
                oPerro.id_sucursal = cbo_idSucursal.SelectedValue
                oPerro.nombre = txt_nombrePerro.Text
                oPerro.fecha_nacimiento = mkb_fechaNacimiento.Text
                oPerro.id_raza = cbo_idRaza.SelectedValue
                oPerro.peso = txt_peso.Text
                oPerro.altura = txt_altura.Text
                oPerro.id_dueño = cbo_idDueño.SelectedValue
                listaPerros.Add(oPerro)
                numero = txt_nroHistoriaClinica.Text
                dgv_listaPerros.Rows.Add(New Object() {oPerro.nro_historiaClinica, oPerro.id_sucursal, oPerro.nombre, oPerro.fecha_nacimiento, oPerro.id_raza, oPerro.id_dueño, oPerro.peso, oPerro.altura})
                frm_cargaEmpleado.limpiar_componentes(gro_datosPerros)
                txt_nroHistoriaClinica.Enabled = False
                txt_nroHistoriaClinica.Text = numero + 1
                btn_guardarPerro.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_guardarPerro_Click(sender As Object, e As EventArgs) Handles btn_guardarPerro.Click

        If action = cargaPerro.esteForm Then
            Try
                Dim numero = txt_nroHistoriaClinica.Text
                txt_nroHistoriaClinica.Text = numero
                For Each row As DataGridViewRow In dgv_listaPerros.Rows
                    Dim oPerroService = New PerroService
                    Dim oPerro = New Perro()
                    oPerro.nro_historiaClinica = row.Cells("col_nroHistoriaClinica").Value
                    oPerro.id_sucursal = row.Cells("col_idSucursal").Value
                    oPerro.nombre = row.Cells("col_nombrePerro").Value
                    oPerro.fecha_nacimiento = row.Cells("col_fechaNacimientoPerro").Value
                    oPerro.id_raza = row.Cells("col_idRaza").Value
                    oPerro.id_dueño = row.Cells("col_idDueño").Value
                    oPerro.peso = row.Cells("col_peso").Value
                    oPerro.altura = row.Cells("col_altura").Value

                    oPerroService.guardarPerros(oPerro)



                    MessageBox.Show("El Perro " & oPerro.nombre & " se ha guardado correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Next
                dgv_listaPerros.Rows.Clear()


            Catch ex As Exception
                Throw ex
            End Try
            frm_cargaEmpleado.limpiar_componentes(gro_datosPerros)
            frm_cargaEmpleado.limpiar_componentes(gro_listaPerros)
        ElseIf action = cargaPerro.otroForm Then
            Try
                Dim numero = txt_nroHistoriaClinica.Text
                txt_nroHistoriaClinica.Text = numero
                For Each row As DataGridViewRow In dgv_listaPerros.Rows
                    Dim oPerroService = New PerroService
                    Dim oPerro = New Perro()


                    oPerro.nro_historiaClinica = row.Cells("col_nroHistoriaClinica").Value
                    oPerro.id_sucursal = row.Cells("col_idSucursal").Value
                    oPerro.nombre = row.Cells("col_nombrePerro").Value
                    oPerro.fecha_nacimiento = row.Cells("col_fechaNacimientoPerro").Value
                    oPerro.id_raza = row.Cells("col_idRaza").Value
                    oPerro.id_dueño = row.Cells("col_idDueño").Value
                    oPerro.peso = row.Cells("col_peso").Value
                    oPerro.altura = row.Cells("col_altura").Value

                    oPerroService.guardarPerros(oPerro)



                    MessageBox.Show("El Perro " & oPerro.nombre & " se ha guardado correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Next
                dgv_listaPerros.Rows.Clear()
                frm_Consulta.load_cbo(frm_Consulta.cbo_nroHistClinicaCons, "Perros", "nro_historia_clinica", "nro_historia_clinica")

            Catch ex As Exception
                Throw ex
            End Try
            frm_cargaEmpleado.limpiar_componentes(gro_datosPerros)
            frm_cargaEmpleado.limpiar_componentes(gro_listaPerros)
        End If
       
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MessageBox.Show("¿Seguro que desea salir?",
                          "Importante", MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then Me.Close()
    End Sub



    Friend Sub load_cbo(ByVal cbo As ComboBox, ByVal table_name As String, ByVal pk As String, ByVal desc As String) '
        Dim table As DataTable = BDHelper.getDBHelper.ConsultaSQL("SELECT " + pk + "," + desc + " FROM " + table_name) '
        cbo.DataSource = table
        cbo.DisplayMember = desc
        cbo.ValueMember = pk
    End Sub

    

    Private Sub txt_nombrePerro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombrePerro.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_peso.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_altura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_altura.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_nroHistoriaClinica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nroHistoriaClinica.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

End Class