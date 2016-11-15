Public Class DiagnosticoxConsultaService
    Private oDiagnosticoxConsultaDao As DiagnosticoxConsultaDao
    Public Sub New()
        oDiagnosticoxConsultaDao = New DiagnosticoxConsultaDao()
    End Sub
    Public Function listarDiagnosticosxConsulta() As List(Of DiagnosticoxConsulta)
        Return oDiagnosticoxConsultaDao.getAll
    End Function

    Public Function buscarDiagnosticosxConsulta(ByVal desc As String) As List(Of DiagnosticoxConsulta)
        Return oDiagnosticoxConsultaDao.buscarDiagnosticos(desc)
    End Function
    Public Function guardarDiagnosticosxConsulta(ByVal oDiagnosticoxConsulta As DiagnosticoxConsulta)
        Return oDiagnosticoxConsultaDao.guardarDiagnosticosxConsultas(oDiagnosticoxConsulta)
    End Function
End Class
