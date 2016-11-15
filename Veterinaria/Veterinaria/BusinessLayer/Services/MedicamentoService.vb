Public Class MedicamentoService
    Private oMedicamentoDao As MedicamentoDao
    Public Sub New()
        oMedicamentoDao = New MedicamentoDao()
    End Sub

    Public Function listarMedicamentos() As List(Of Medicamento)
        Return oMedicamentoDao.getAll
    End Function

    Public Function buscarMedicamentos(ByVal desc As String) As List(Of Medicamento)
        Return oMedicamentoDao.buscarMedicamentos(desc)
    End Function
    Public Function modificarMedicamentos(ByVal medicamento As Medicamento)
        Return oMedicamentoDao.modificarMedicamentos(medicamento)
    End Function
    Public Function eliminarMedicamentos(ByVal id As Integer)
        Return oMedicamentoDao.eliminarMedicamentos(id)
    End Function
    Public Function guardarMedicamentos(ByVal oMedicamento As Medicamento)
        Return oMedicamentoDao.guardarMedicamentos(oMedicamento)
    End Function

    Public Function autoIncrementarID(ByVal str As String, ByVal text As TextBox) As Integer
        Return oMedicamentoDao.autoincrementarID(str, text)
    End Function

End Class
