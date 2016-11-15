Public Class LaboratorioService
    Private oLaboratorioDao As LaboratorioDao
    Public Sub New()
        oLaboratorioDao = New LaboratorioDao()
    End Sub

    Public Function listarLaboratorios() As List(Of Laboratorio)
        Return oLaboratorioDao.getAll
    End Function

    Public Function buscarLaboratorios(ByVal nombre As String) As List(Of Laboratorio)
        Return oLaboratorioDao.buscarLaboratorios(nombre.ToString)
    End Function
    Public Function modificarLaboratorios(ByVal laboratorio As Laboratorio)
        Return oLaboratorioDao.modificarLaboratorios(laboratorio)
    End Function
    Public Function eliminarLaboratorios(ByVal razonSocial As String)
        Return oLaboratorioDao.eliminarLaboratorios(razonSocial)
    End Function
    Public Function guardarLaboratorios(ByVal oLaboratorio As Laboratorio)
        Return oLaboratorioDao.guardarLaboratorios(oLaboratorio)
    End Function
    Public Function autoIncrementarID(ByVal str As String, ByVal text As TextBox) As Integer
        Return oLaboratorioDao.autoincrementarID(str, text)
    End Function
End Class
