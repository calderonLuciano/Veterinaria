Public Class frm_cargaSintoma
    Private listaSintoma As List(Of Sintoma)
    Enum cargaSintoma
        esteForm
        otroForm
    End Enum
    Public action As cargaSintoma
    Private Sub frm_cargaSintoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaSintoma = New List(Of Sintoma)()
        btn_guardarSintoma.Enabled = False
        Dim oSintomaService As SintomaService = New SintomaService
        Dim str = "SELECT MAX(id_sintoma) FROM Sintomas"
        oSintomaService.autoIncrementarID(str, txt_idSintoma)
        dgv_listaSintomas.Rows.Clear()
    End Sub

    Private Sub btn_agregarSintoma_Click(sender As Object, e As EventArgs) Handles btn_agregarSintoma.Click
        Try
            If frm_cargaEmpleado.validar_componentes_completos(gro_datosSintoma) = True Then

            Else
                Dim oSintoma = New Sintoma
                Dim numero As Integer
                oSintoma.id_sintoma = txt_idSintoma.Text
                oSintoma.descripcion = txt_descripcionSintoma.Text
                listaSintoma.Add(oSintoma)
                numero = txt_idSintoma.Text
                dgv_listaSintomas.Rows.Add(New Object() {oSintoma.id_sintoma, oSintoma.descripcion})
                frm_cargaEmpleado.limpiar_componentes(gro_datosSintoma)

                txt_idSintoma.Text = numero + 1

            End If
            btn_guardarSintoma.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_guardarSintoma_Click(sender As Object, e As EventArgs) Handles btn_guardarSintoma.Click
        If action = cargaSintoma.esteForm Then
            Try
                Dim numero = txt_idSintoma.Text
                txt_idSintoma.Text = numero
                For Each row As DataGridViewRow In dgv_listaSintomas.Rows
                    Dim oSintomaService = New SintomaService
                    Dim oSintoma = New Sintoma()
                    oSintoma.id_sintoma = row.Cells.Item("col_idSintoma").Value
                    oSintoma.descripcion = row.Cells.Item("col_descripcionSintoma").Value
                    oSintomaService.guardarSintomas(oSintoma)
                    MessageBox.Show("El sintoma " & oSintoma.descripcion & " se ha guardado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Next
            Catch ex As Exception
                Throw ex
            End Try
            frm_cargaEmpleado.limpiar_componentes(gro_datosSintoma)
            frm_cargaEmpleado.limpiar_componentes(gro_listaSintomas)
        ElseIf action = cargaSintoma.otroForm Then
            Try
                Dim numero = txt_idSintoma.Text
                txt_idSintoma.Text = numero
                For Each row As DataGridViewRow In dgv_listaSintomas.Rows
                    Dim oSintomaService = New SintomaService
                    Dim oSintoma = New Sintoma()
                    oSintoma.id_sintoma = row.Cells.Item("col_idSintoma").Value
                    oSintoma.descripcion = row.Cells.Item("col_descripcionSintoma").Value
                    oSintomaService.guardarSintomas(oSintoma)

                    MessageBox.Show("El sintoma " & oSintoma.descripcion & " se ha guardado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Next
                frm_Consulta.load_cbo(frm_Consulta.cbo_cargaSintomasDisponibles, "Sintomas", "id_sintoma", "descripcion")
            Catch ex As Exception
                Throw ex
            End Try
            frm_cargaEmpleado.limpiar_componentes(gro_datosSintoma)
            frm_cargaEmpleado.limpiar_componentes(gro_listaSintomas)
        End If
    End Sub

    Private Sub btn_salirSintoma_Click(sender As Object, e As EventArgs) Handles btn_salirSintoma.Click
        'Confirmación de salida.
        If MessageBox.Show("¿Seguro que desea salir?",
                           "Importante", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class