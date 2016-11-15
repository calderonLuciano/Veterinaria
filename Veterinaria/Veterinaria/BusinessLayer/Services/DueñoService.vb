Public Class DueñoService
    Private oDueñoDao As DueñoDao
    Public Sub New()
        oDueñoDao = New DueñoDao()
    End Sub

    Public Function listarDueños() As List(Of Dueño)
        Return oDueñoDao.getAll
    End Function

    Public Function buscarDueños(ByVal nombre As String) As List(Of Dueño)
        Return oDueñoDao.buscarDueños(nombre)
    End Function
    Public Function modificarDueños(ByVal dueño As Dueño)
        Return oDueñoDao.modificarDueños(dueño)
    End Function
    Public Function eliminarDueños(ByVal id As Integer)
        Return oDueñoDao.eliminarDueños(id)
    End Function
    Public Function guardarDueños(ByVal oDueño As Dueño)
        Return oDueñoDao.guardarDueños(oDueño)
    End Function

    Public Function autoIncrementarID(ByVal str As String, ByVal text As TextBox) As Integer
        Return oDueñoDao.autoincrementarID(str, text)
    End Function

End Class
