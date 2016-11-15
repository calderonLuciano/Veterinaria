Public Class DueñoDao
    Public Function getAll() As List(Of Dueño)
        Dim oDueño As Dueño
        Dim dueños As New List(Of Dueño)
        Dim strSQL = "SELECT D.* FROM Dueños D"



        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oDueño = New Dueño()
            With oDueño
                .id_dueño = (row.Item("id_dueño").ToString)
                .nombre = (row.Item("nombre").ToString)
                .apellido = (row.Item("apellido").ToString)
                .telefono = (row.Item("telefono"))


            End With
            dueños.Add(oDueño)
        Next

        Return dueños
    End Function

    Public Function buscarDueños(ByVal desc As String) As List(Of Dueño)
        Dim oDueño As Dueño
        Dim dueños As New List(Of Dueño)
        Dim strSQL = ("SELECT * FROM Dueños WHERE nombre='" & desc & "'")
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(strSQL).Rows
            oDueño = New Dueño()
            With oDueño
                .id_dueño = (row.Item("id_dueño").ToString)
                .nombre = (row.Item("nombre").ToString)
                .apellido = (row.Item("apellido"))
                .telefono = (row.Item("telefono"))
            End With
            dueños.Add(oDueño)
        Next
        Return dueños
    End Function

    Public Function modificarDueños(ByVal oDueño As Dueño)
        Try


            Dim strSQL As String = "UPDATE Dueños SET  nombre='" & oDueño.nombre & "'" & ", apellido='" & oDueño.apellido & "', telefono='" & oDueño.telefono & "' WHERE id_dueño=" & oDueño.id_dueño
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El dueño se modifico correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw ex
        End Try

        Return True
    End Function
    Public Function eliminarDueños(ByVal id As Integer)
        Try

            Dim strSQL As String = "DELETE FROM Dueños WHERE  id_dueño=" & id
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El dueño se elimino correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Public Function guardarDueños(ByVal oDueño As Dueño)
        Dim str = "INSERT INTO Dueños VALUES("
        str += oDueño.id_dueño & ","
        str += "'" & oDueño.nombre & "' ,"
        str += "'" & oDueño.apellido & "',"
        str += "'" & oDueño.telefono & "' )"
        Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)

    End Function
    Public Function autoincrementarID(ByVal str As String, ByVal text As TextBox)
        BDHelper.getDBHelper.autoIncrementarID(str, text)
        Return Nothing
    End Function
End Class
