Public Class MedicamentoxConsultaService
    Private oMedicamentoxConsultaDao As MedicamentoxConsultaDao
    Public Sub New()
        oMedicamentoxConsultaDao = New MedicamentoxConsultaDao()
    End Sub
    Public Function listarMedicamentosxConsultas() As List(Of MedicamentoxConsulta)
        Return oMedicamentoxConsultaDao.getAll
    End Function

    Public Function buscarMedicamentosxConsultas(ByVal desc As String) As List(Of MedicamentoxConsulta)
        Return oMedicamentoxConsultaDao.buscarMedicamentosxConsulta(desc)
    End Function

    Public Function guardarMedicamentosxConsultas(ByVal oMedicamentoxConsulta As MedicamentoxConsulta)
        Return oMedicamentoxConsultaDao.guardarMedicamentoxConsulta(oMedicamentoxConsulta)
    End Function

End Class
