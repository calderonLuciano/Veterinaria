Public Class SintomaDao
    Public Function getAll() As List(Of Sintoma)
        Dim oSintoma As Sintoma
        Dim sintomas As New List(Of Sintoma)
        Dim strSQL = "SELECT S.* FROM Sintomas S"



        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oSintoma = New Sintoma()
            With oSintoma
                .id_sintoma = (row.Item("id_sintoma").ToString)
                .descripcion = (row.Item("descripcion").ToString)
            End With
            sintomas.Add(oSintoma)
        Next

        Return sintomas

    End Function
    Public Function buscarSintomas(ByVal nro As Integer) As List(Of Sintoma)
        Dim oSintoma As Sintoma
        Dim sintomas As New List(Of Sintoma)
        Dim strSQL = ("SELECT * FROM Sintomas WHERE id_sintoma=" & nro)
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(strSQL).Rows
            oSintoma = New Sintoma()
            With oSintoma
                .id_sintoma = (row.Item("id_sintoma").ToString)
                .descripcion = (row.Item("descripcion").ToString)
            End With
            sintomas.Add(oSintoma)
        Next
        Return sintomas
    End Function

    Public Function modificarSintoma(ByVal oSintoma As Sintoma)
        Try


            Dim strSQL As String = "UPDATE Sintomas SET  descripcion='" & oSintoma.descripcion & "' WHERE id_sintoma=" & oSintoma.id_sintoma
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El sintoma se modifico correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw ex
        End Try

        Return True

    End Function
    Public Function eliminarSintomas(ByVal id As Integer)
        Try

            Dim strSQL As String = "DELETE FROM Sintomas WHERE  id_sintoma=" & id
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El sintoma se elimino correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function
    Public Function guardarSintoma(ByVal oSintoma As Sintoma)
        Dim str = "INSERT INTO Sintomas VALUES("
        str += oSintoma.id_sintoma & ","
        str += "'" & oSintoma.descripcion & "' )"

        Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)

    End Function
    Public Function autoincrementarID(ByVal str As String, ByVal text As TextBox)
        BDHelper.getDBHelper.autoIncrementarID(str, text)
        Return Nothing
    End Function
End Class
