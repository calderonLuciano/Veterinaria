Public Class ConsultaService
    Private oConsultaDao As ConsultaDao

    Public Sub New()
        oConsultaDao = New ConsultaDao()
    End Sub
    Public Function listarConsulta() As List(Of Consulta)
        Return oConsultaDao.getAll
    End Function
    Public Function buscarConsultaFecha(ByVal fechaDesde As String, ByVal fechaHasta As String) As List(Of Consulta)
        Return oConsultaDao.buscarConsultaFecha(fechaDesde, fechaHasta)
    End Function
    Public Function buscarConsulta(ByVal buscar As String) As List(Of Consulta)
        Return oConsultaDao.buscarConsulta(buscar)
    End Function
    Public Function autoIncrementarID(ByVal str As String, ByVal text As TextBox) As Integer
        Return oConsultaDao.autoincrementarID(str, text)
    End Function
    Public Function guardarConsulta(ByVal oConsulta As Consulta, ByVal lstMedicamentoxConsulta As List(Of MedicamentoxConsulta), ByVal lstSintomaxConsulta As List(Of SintomaxConsulta), ByVal lstDiagnosticoxConsulta As List(Of DiagnosticoxConsulta))
        Return oConsultaDao.guardarConsulta(oConsulta, lstMedicamentoxConsulta, lstSintomaxConsulta, lstDiagnosticoxConsulta)
    End Function
    Public Function buscarDiagxCons(ByVal id As Integer) As List(Of DiagnosticoxConsulta)
        Return oConsultaDao.buscarDiagnosticosxConsulta(id)
    End Function
    Public Function buscarSintxCons(ByVal id As Integer) As List(Of SintomaxConsulta)
        Return oConsultaDao.buscarSintomasxConsulta(id)
    End Function
    Public Function buscarMedxCons(ByVal id As Integer) As List(Of MedicamentoxConsulta)
        Return oConsultaDao.buscarMedicamentosxConsulta(id)
    End Function
End Class
