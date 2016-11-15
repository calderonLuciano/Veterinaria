Public Class DiagnosticoDao
    Public Function getAll() As List(Of Diagnostico)
        Dim oDiagnostico As Diagnostico
        Dim diagnosticos As New List(Of Diagnostico)
        Dim strSQL = "SELECT D.* FROM Diagnosticos D"



        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oDiagnostico = New Diagnostico()
            With oDiagnostico
                .id_diagnostico = (row.Item("id_diagnostico").ToString)
                .descripcion = (row.Item("descripcion").ToString)
            End With
            diagnosticos.Add(oDiagnostico)
        Next

        Return diagnosticos

    End Function
    Public Function buscarDiagnosticos(ByVal buscar As String) As List(Of Diagnostico)
        Dim oDiagnostico As Diagnostico
        Dim diagnosticos As New List(Of Diagnostico)
        Dim strSQL = ("SELECT * FROM Diagnosticos WHERE (id_diagnostico LIKE('%" + buscar.ToString + "%') OR descripcion LIKE('%" + buscar.ToString + "%' )) ")
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(strSQL).Rows
            oDiagnostico = New Diagnostico()
            With oDiagnostico
                .id_diagnostico = (row.Item("id_diagnostico").ToString)
                .descripcion = (row.Item("descripcion").ToString)
            End With
            diagnosticos.Add(oDiagnostico)
        Next
        Return diagnosticos
    End Function

    Public Function modificarDiagnostico(ByVal oDiagnostico As Diagnostico)
        Try
            Dim strSQL As String = "UPDATE Diagnosticos SET  descripcion='" & oDiagnostico.descripcion & "' WHERE id_diagnostico=" & oDiagnostico.id_diagnostico
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El diagnostico se modifico correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw ex
        End Try

        Return True

    End Function
    Public Function eliminarDiagnosticos(ByVal id As Integer)
        Try
            Dim strSQL As String = "DELETE FROM Diagnosticos WHERE  id_diagnostico=" & id
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El diagnostico se elimino correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function
    Public Function guardarDiagnostico(ByVal oDiagnostico As Diagnostico)
        Dim str = "INSERT INTO Diagnosticos VALUES("
        str += oDiagnostico.id_diagnostico & ","
        str += "'" & oDiagnostico.descripcion & "' )"
       
        Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)

    End Function
    Public Function autoincrementarID(ByVal str As String, ByVal text As TextBox)
        BDHelper.getDBHelper.autoIncrementarID(str, text)
        Return Nothing
    End Function
End Class
