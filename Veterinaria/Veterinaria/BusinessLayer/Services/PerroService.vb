Public Class PerroService
    Private oPerroDao = New PerroDao
    Public Sub New()
        oPerroDao = New PerroDao()
    End Sub

    Public Function listarPerros() As List(Of Perro)
        Return oPerroDao.getAll
    End Function

    Public Function buscarPerros(ByVal desc As String) As List(Of Perro)
        Return oPerroDao.buscarPerros(desc)
    End Function
    Public Function modificarPerros(ByVal oPerro As Perro)
        Return oPerroDao.modificarPerros(oPerro)
    End Function
    Public Function eliminarPerros(ByVal nro As Integer, ByVal nro2 As Integer)
        Return oPerroDao.eliminarPerros(nro, nro2)
    End Function
    Public Function guardarPerros(ByVal oPerro As Perro)
        Return oPerroDao.guardarPerros(oPerro)
    End Function
    Public Function autoIncrementarID(ByVal str As String, ByVal text As TextBox) As Integer
        Return oPerroDao.autoincrementarID(str, text)
    End Function
End Class
