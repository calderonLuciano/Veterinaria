Public Class DiagnosticoService
    Private oDiagnosticoDao As DiagnosticoDao
    Public Sub New()
        oDiagnosticoDao = New DiagnosticoDao()
    End Sub

    Public Function listarDiagnosticos() As List(Of Diagnostico)
        Return oDiagnosticoDao.getAll
    End Function

    Public Function buscarDiagnosticos(ByVal desc As String) As List(Of Diagnostico)
        Return oDiagnosticoDao.buscarDiagnosticos(desc)
    End Function
    Public Function modificarDiagnosticos(ByVal diag As Diagnostico)
        Return oDiagnosticoDao.modificarDiagnostico(diag)
    End Function
    Public Function eliminarDiagnosticos(ByVal id As Integer)
        Return oDiagnosticoDao.eliminarDiagnosticos(id)
    End Function
    Public Function guardarDiagnosticos(ByVal oDiag As Diagnostico)
        Return oDiagnosticoDao.guardarDiagnostico(oDiag)
    End Function

    Public Function autoIncrementarID(ByVal str As String, ByVal text As TextBox) As Integer
        Return oDiagnosticoDao.autoincrementarID(str, text)
    End Function
End Class
