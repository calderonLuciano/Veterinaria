Imports Microsoft.Reporting.WinForms

Public Class InformePerrosPorRaza

    Private Sub InformePerrosPorRaza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Razas' Puede moverla o quitarla según sea necesario.
        Me.RazasTableAdapter.Fill(Me.DataSet1.Razas)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.InformePerrosPorRaza' Puede moverla o quitarla según sea necesario.


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_rAceptar_Click(sender As Object, e As EventArgs) Handles btn_rAceptar.Click

        Me.InformePerrosPorRazaTableAdapter.FillInformePerrosPorRaza(Me.DataSet1.InformePerrosPorRaza, cbo_PerrosRaza.SelectedValue)
        With ReportViewer1
            Dim param As New ReportParameter("paramRaza", cbo_PerrosRaza.Text)
            .LocalReport.SetParameters(param)
            .LocalReport.Refresh()
            .RefreshReport()
        End With
    End Sub
End Class