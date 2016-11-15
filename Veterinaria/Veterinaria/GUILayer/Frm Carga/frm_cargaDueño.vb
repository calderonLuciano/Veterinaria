Public Class frm_cargaDueño
    Private listaDueños As List(Of Dueño)
    Private Sub frm_cargaDueño_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaDueños = New List(Of Dueño)()
        Dim oDueñoService As DueñoService = New DueñoService
        Dim str = "SELECT MAX(id_dueño) FROM Dueños"
        oDueñoService.autoIncrementarID(str, txt_idDueño)
        dgv_listaDueños.Rows.Clear()
        btn_guardarDueño.Enabled = False
    End Sub

    Private Sub btn_agregarDueño_Click(sender As Object, e As EventArgs) Handles btn_agregarDueño.Click
        Try
            If frm_cargaEmpleado.validar_componentes_completos(gro_datosDueños) = True Then

            Else
                Dim oDueño = New Dueño
                Dim oDueñoService = New DueñoService
                Dim numero As Integer
                oDueño.id_dueño = txt_idDueño.Text
                oDueño.nombre = txt_nombreDueño.Text
                oDueño.apellido = txt_apellidoDueño.Text
                oDueño.telefono = txt_telefonoDueño.Text
                listaDueños.Add(oDueño)
                numero = txt_idDueño.Text
                dgv_listaDueños.Rows.Add(New Object() {oDueño.id_dueño, oDueño.nombre, oDueño.apellido, oDueño.telefono})
                frm_cargaEmpleado.limpiar_componentes(gro_datosDueños)
                txt_idDueño.Enabled = False
                txt_idDueño.Text = numero + 1
                btn_guardarDueño.Enabled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btn_guardarDueño_Click(sender As Object, e As EventArgs) Handles btn_guardarDueño.Click
        Try
            Dim numero = txt_idDueño.Text
            txt_idDueño.Text = numero
            For Each row As DataGridViewRow In dgv_listaDueños.Rows
                Dim oDueñoService = New DueñoService
                Dim oDueño = New Dueño


                oDueño.id_dueño = row.Cells("col_idDueño").Value
                oDueño.nombre = row.Cells("col_nombreDueño").Value
                oDueño.apellido = row.Cells("col_apellidoDueño").Value
                oDueño.telefono = row.Cells("col_telefonoDueño").Value
                oDueñoService.guardarDueños(oDueño)

                MessageBox.Show("El Dueño " & oDueño.nombre & " se ha guardado correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Next
        Catch ex As Exception
            Throw ex
        End Try
        frm_cargaEmpleado.limpiar_componentes(gro_datosDueños)
        frm_cargaEmpleado.limpiar_componentes(gro_listaDueños)
    End Sub

    Private Sub btn_salirDueño_Click(sender As Object, e As EventArgs) Handles btn_salirDueño.Click
        If MessageBox.Show("¿Seguro que desea salir?",
                           "Importante", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then Me.Close()

    End Sub

    Private Sub txt_telefonoDueño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefonoDueño.KeyPress
        If Not frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("Solo se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_nombreDueño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombreDueño.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub

    Private Sub txt_apellidoDueño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellidoDueño.KeyPress
        If frm_cargaEmpleado.validate_number(e.KeyChar) Then
            MsgBox("No se permite ingresar numeros", MsgBoxStyle.Exclamation, "Validación de Datos")
            e.KeyChar = String.Empty
        End If
    End Sub
End Class