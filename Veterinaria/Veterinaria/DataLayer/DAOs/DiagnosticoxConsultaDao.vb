Public Class DiagnosticoxConsultaDao
    Public Function getAll() As List(Of DiagnosticoxConsulta)
        Dim oDiagnosticoxConsulta As DiagnosticoxConsulta
        Dim DiagnosticoxConsulta As New List(Of DiagnosticoxConsulta)
        Dim strSQL = "SELECT DxC.* FROM DiagnosticoxConsulta DxC"



        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oDiagnosticoxConsulta = New DiagnosticoxConsulta()
            With oDiagnosticoxConsulta
                .nro_historia_clinica = row.Item("nro_historia_clinica").ToString
                .id_sucursal = row.Item("id_sucursal")
                .id_consulta = row.Item("id_consulta")
                .id_diagnostico = row.Item("id_diagnostico")
            End With
            DiagnosticoxConsulta.Add(oDiagnosticoxConsulta)
        Next

        Return DiagnosticoxConsulta
    End Function

    Public Function buscarDiagnosticos(ByVal buscar As String) As List(Of DiagnosticoxConsulta)
        Dim oDiagnosticoxConsulta As DiagnosticoxConsulta
        Dim diagnosticosxConsulta As New List(Of DiagnosticoxConsulta)
        Dim strSQL = ("SELECT * FROM DiagnosticoxConsulta WHERE id_consulta = " + buscar)
        '(nro_historia_clinica LIKE('%" + buscar.ToString + "%') OR id_sucursal LIKE('%" + buscar.ToString + "%' ) OR id_consulta LIKE ('%" + buscar.ToString + "%') OR id_diagnostico LIKE ('%" + buscar.ToString + "%') ) ")
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(strSQL).Rows
            oDiagnosticoxConsulta = New DiagnosticoxConsulta()
            With oDiagnosticoxConsulta
                .nro_historia_clinica = row.Item("nro_historia_clinica").ToString
                .id_sucursal = row.Item("id_sucursal")
                .id_consulta = row.Item("id_consulta")
                .id_diagnostico = row.Item("id_diagnostico")
            End With
            diagnosticosxConsulta.Add(oDiagnosticoxConsulta)
        Next
        Return diagnosticosxConsulta
    End Function
    Public Function guardarDiagnosticosxConsultas(ByVal oDiagnosticoxConsulta As DiagnosticoxConsulta)
        Dim str = "INSERT INTO DiagnosticoxConsulta VALUES("
        str += oDiagnosticoxConsulta.nro_historia_clinica & " ,"
        str += oDiagnosticoxConsulta.id_sucursal & ","
        str += oDiagnosticoxConsulta.id_consulta & " ,"
        str += oDiagnosticoxConsulta.id_diagnostico & " )"
       
        Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)


    End Function
    Public Function autoincrementarID(ByVal str As String, ByVal text As TextBox)
        BDHelper.getDBHelper.autoIncrementarID(str, text)
        Return Nothing
    End Function
End Class


