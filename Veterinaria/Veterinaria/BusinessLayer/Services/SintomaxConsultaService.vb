Public Class SintomaxConsultaService
    Private oSintomaxConsultaDao As SintomaxConsultaDao
    Public Sub New()
        oSintomaxConsultaDao = New SintomaxConsultaDao()
    End Sub
    Public Function listarSintomasxConsulta() As List(Of SintomaxConsulta)
        Return oSintomaxConsultaDao.getAll
    End Function

    Public Function buscarSintomaxConsulta(ByVal desc As String) As List(Of SintomaxConsulta)
        Return oSintomaxConsultaDao.buscarSintomasxConsulta(desc)
    End Function
    Public Function guardarSintomasxConsulta(ByVal oSintomaxConsulta As SintomaxConsulta)
        Return oSintomaxConsultaDao.guardarSintomaxConsulta(oSintomaxConsulta)
    End Function
End Class
