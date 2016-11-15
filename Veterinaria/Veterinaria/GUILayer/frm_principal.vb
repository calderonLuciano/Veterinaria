Public Class frm_principal

    
    Private Sub NuevoEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoEmpleadoToolStripMenuItem.Click
        frm_cargaEmpleado.ShowDialog()
    End Sub

    Private Sub EditarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarEmpleadoToolStripMenuItem.Click
        frm_cargaEmpleado.limpiar_componentes(frm_editarEmpleado.gro_datosEmpleadoEditar)
        frm_editarEmpleado.ShowDialog()
    End Sub

    Private Sub NuevoDueñoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoDueñoToolStripMenuItem.Click
        frm_cargaDueño.ShowDialog()
    End Sub

    Private Sub EditarDueñoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarDueñoToolStripMenuItem.Click
        frm_cargaEmpleado.limpiar_componentes(frm_editarDueño.gro_datosDueñoEditar)
        frm_editarDueño.ShowDialog()
    End Sub

    Private Sub NuevoMedicamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoMedicamentoToolStripMenuItem.Click
        frm_cargaMedicamento.ShowDialog()
        frm_cargaMedicamento.action = frm_cargaMedicamento.carga.esteForm
    End Sub

    Private Sub EditarMedicamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarMedicamentoToolStripMenuItem.Click
        frm_cargaEmpleado.limpiar_componentes(frm_editarMedicamento.gro_datosMedicamentosEditar)
        frm_editarMedicamento.ShowDialog()
    End Sub

    Private Sub NuevoLaboratorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoLaboratorioToolStripMenuItem.Click
        frm_cargaLaboratorio.ShowDialog()
    End Sub

    Private Sub EditarLaboratorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarLaboratorioToolStripMenuItem.Click
        frm_cargaEmpleado.limpiar_componentes(frm_editarLaboratorio.gro_datosLaboratorioEditar)
        frm_editarLaboratorio.ShowDialog()
    End Sub

    Private Sub NuevoPerroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPerroToolStripMenuItem.Click
        frm_cargaPerro.ShowDialog()
    End Sub

    Private Sub EditarPerroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarPerroToolStripMenuItem.Click
        frm_cargaEmpleado.limpiar_componentes(frm_editarPerro.gro_datosPerroEditar)
        frm_editarPerro.ShowDialog()
    End Sub

    Private Sub NuevoDiagnosticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoDiagnosticoToolStripMenuItem.Click
        frm_cargaDiagnostico.ShowDialog()
        frm_cargaDiagnostico.action = frm_cargaDiagnostico.cargaDiagnostico.esteForm
    End Sub

    Private Sub EditarDiagnosticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarDiagnosticoToolStripMenuItem.Click
        frm_cargaEmpleado.limpiar_componentes(frm_editarDiagnostico.gro_datosDiagnosticoEditar)
        frm_editarDiagnostico.ShowDialog()
    End Sub

    Private Sub NuevoSintomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoSintomaToolStripMenuItem.Click
        frm_cargaSintoma.ShowDialog()
        frm_cargaDiagnostico.action = frm_cargaDiagnostico.cargaDiagnostico.esteForm
    End Sub

    Private Sub EditarSintomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarSintomaToolStripMenuItem.Click
        frm_cargaEmpleado.limpiar_componentes(frm_editarSintoma.gro_datosSintomaEditar)
        frm_editarSintoma.ShowDialog()
    End Sub

    
    Private Sub pcb_atencion_Click(sender As Object, e As EventArgs) Handles pcb_atencion.Click
        frm_Consulta.ShowDialog()
    End Sub

   
    
    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub EmpleadosPorSucursalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosPorSucursalToolStripMenuItem.Click
        Dim objeto As New InformeEmpleadosPorSucursal
        objeto.ShowDialog()
    End Sub

    Private Sub PerrosPorDueñoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerrosPorDueñoToolStripMenuItem.Click
        Dim objeto As New InformePerrosPorRaza
        objeto.ShowDialog()
    End Sub

    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class