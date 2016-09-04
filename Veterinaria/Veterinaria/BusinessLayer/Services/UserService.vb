Public Class UserService
    Private oUserDao As UserDao
    Public Sub New()
        oUserDao = New UserDao()
    End Sub

    Public Function validarUsuario(ByVal n_user As String, ByVal pass As String) As Boolean
        Return Not IsNothing(oUserDao.getUser(n_user, pass))
    End Function
End Class
