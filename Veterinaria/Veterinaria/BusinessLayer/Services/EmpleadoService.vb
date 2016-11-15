Public Class EmpleadoService
    Private oEmpleadoDao As EmpleadoDao

    Public Sub New()
        oEmpleadoDao = New EmpleadoDao()
    End Sub

    Public Function listarEmpleados() As List(Of Empleado)
        Return oEmpleadoDao.getAll
    End Function

    Public Function buscarEmpleados(ByVal nombre As String) As List(Of Empleado)
        Return oEmpleadoDao.buscarEmpleado(nombre.ToString)
    End Function
    Public Function modificarEmpleados(ByVal empleado As Empleado)
        Return oEmpleadoDao.modificarEmpleados(empleado)
    End Function
    Public Function eliminarEmpleados(ByVal nro_doc As String)
        Return oEmpleadoDao.eliminarEmpleados(nro_doc)
    End Function
    Public Function guardarEmpleados(ByVal oEmpleado As Empleado)
        Return oEmpleadoDao.guardarEmpleados(oEmpleado)
    End Function

End Class
