Public Class MedicamentoDao
    Public Function getAll() As List(Of Medicamento)
        Dim oMedicamento As Medicamento
        Dim medicamentos As New List(Of Medicamento)
        Dim strSQL = "SELECT M.* FROM Medicamentos M"



        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oMedicamento = New Medicamento()
            With oMedicamento
                .id_medicamento = (row.Item("id_medicamento").ToString)
                .descripcion = (row.Item("descripcion").ToString)
                .id_laboratorio = (row.Item("id_laboratorio").ToString)
                    .fecha_ultCompra = (row.Item("fecha_ultima_compra"))
            End With
            medicamentos.Add(oMedicamento)
        Next

        Return medicamentos
    End Function

    Public Function buscarMedicamentos(ByVal desc As String) As List(Of Medicamento)
        Dim oMedicamento As Medicamento
        Dim medicamentos As New List(Of Medicamento)
        Dim strSQL = ("SELECT * FROM Medicamentos WHERE descripcion='" & desc & "'")
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(strSQL).Rows
            oMedicamento = New Medicamento()
            With oMedicamento
                .id_medicamento = (row.Item("id_medicamento").ToString)
                .descripcion = (row.Item("descripcion").ToString)
                .id_laboratorio = (row.Item("id_laboratorio"))
                .fecha_ultCompra = (row.Item("fecha_ultima_compra"))
            End With
            medicamentos.Add(oMedicamento)
        Next
        Return medicamentos
    End Function

    Public Function modificarMedicamentos(ByVal oMedicamento As Medicamento)
        Try


            Dim strSQL As String = "UPDATE Medicamentos SET  descripcion='" & oMedicamento.descripcion & "'" & ", id_laboratorio=" & oMedicamento.id_laboratorio & ", fecha_ultima_compra='" & oMedicamento.fecha_ultCompra & "' WHERE id_medicamento=" & oMedicamento.id_medicamento
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El medicamento se modifico correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw ex
        End Try

        Return True
    End Function
    Public Function eliminarMedicamentos(ByVal id As Integer)
        Try

            Dim strSQL As String = "DELETE FROM Medicamentos WHERE  id_medicamento=" & id
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El medicamento se elimino correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function
    
    Public Function guardarMedicamentos(ByVal oMedicamento As Medicamento)
        Dim str = "INSERT INTO Medicamentos VALUES("
        str += oMedicamento.id_medicamento & ","
        str += "'" & oMedicamento.descripcion & "' ,"
        str += oMedicamento.id_laboratorio & ","
        str += "'" & oMedicamento.fecha_ultCompra & "' )"
        Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)
    End Function
    Public Function autoincrementarID(ByVal str As String, ByVal text As TextBox)
        BDHelper.getDBHelper.autoIncrementarID(str, text)
        Return Nothing
    End Function
End Class
