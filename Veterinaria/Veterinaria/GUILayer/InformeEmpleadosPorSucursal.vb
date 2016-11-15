Imports Microsoft.Reporting.WinForms

Public Class InformeEmpleadosPorSucursal

    Private Sub InformeEmpleadosPorSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.InformeEmleadosPorSucursal' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.DataSet1.Sucursales)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click



        Me.InformeEmleadosPorSucursalTableAdapter.FillInformeEmpleadosPorSucursal(Me.DataSet1.InformeEmleadosPorSucursal, cbo_Rsucursal.SelectedValue)

        With ReportViewer1
            Dim parametro As New ReportParameter("ReportParameter1", cbo_Rsucursal.Text)
            .LocalReport.SetParameters(parametro)
            .LocalReport.Refresh()
            .RefreshReport()
        End With
    End Sub
End Class