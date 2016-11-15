Public Class SintomaService
    Private oSintomaDao As SintomaDao
    Public Sub New()
        oSintomaDao = New SintomaDao()
    End Sub

    Public Function listarSintomas() As List(Of Sintoma)
        Return oSintomaDao.getAll
    End Function

    Public Function buscarSintoma(ByVal nro As Integer) As List(Of Sintoma)
        Return oSintomaDao.buscarSintomas(nro)
    End Function
    Public Function modificarSintomas(ByVal sin As Sintoma)
        Return oSintomaDao.modificarSintoma(sin)
    End Function
    Public Function eliminarSintomas(ByVal id As Integer)
        Return oSintomaDao.eliminarSintomas(id)
    End Function
    Public Function guardarSintomas(ByVal oSint As Sintoma)
        Return oSintomaDao.guardarSintoma(oSint)
    End Function

    Public Function autoIncrementarID(ByVal str As String, ByVal text As TextBox) As Integer
        Return oSintomaDao.autoincrementarID(str, text)
    End Function
End Class
