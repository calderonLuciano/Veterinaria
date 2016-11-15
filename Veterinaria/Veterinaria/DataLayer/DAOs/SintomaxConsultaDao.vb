Public Class SintomaxConsultaDao
    Public Function getAll() As List(Of SintomaxConsulta)
        Dim oSintomaxConsulta As SintomaxConsulta
        Dim sintomasxConsuta As New List(Of SintomaxConsulta)
        Dim strSQL = "SELECT E.* FROM SintomaxConsulta E"

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oSintomaxConsulta = New SintomaxConsulta()
            With oSintomaxConsulta
                .nro_historia_clinica = row.Item("nro_historia_clinica").ToString
                .id_sucursal = row.Item("id_sucursal").ToString
                .id_consulta = row.Item("id_consulta").ToString
                .id_sintoma = row.Item("id_sintoma").ToString
            End With
            SintomasxConsuta.Add(oSintomaxConsulta)
        Next
        Return sintomasxConsuta
    End Function

    Public Function buscarSintomasxConsulta(ByVal buscar As String) As List(Of SintomaxConsulta)
        Dim oSintomaxConsulta As SintomaxConsulta
        Dim sintomasxConsulta As New List(Of SintomaxConsulta)
        Dim strSQL = ("SELECT * FROM SintomaxConsulta WHERE id_consulta = " + buscar)
        '(nro_historia_clinica LIKE('%" + buscar.ToString + "%') OR id_sucursal LIKE('%" + buscar.ToString + "%') OR id_consulta LIKE('%" + buscar.ToString + "%') OR id_sintoma LIKE('%" + buscar.ToString + "%')  ) ")

        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(strSQL).Rows
            oSintomaxConsulta = New SintomaxConsulta
            With oSintomaxConsulta
                .nro_historia_clinica = row.Item("nro_historia_clinica").ToString
                .id_sucursal = row.Item("id_sucursal").ToString
                .id_consulta = row.Item("id_consulta").ToString
                .id_sintoma = row.Item("id_sintoma").ToString
            End With
            sintomasxConsulta.Add(oSintomaxConsulta)
        Next
        Return sintomasxConsulta
    End Function

    'Ver como vamos a hacer que esto funcione deberia recibir una lista y recorrerla
    Public Function guardarSintomaxConsulta(ByVal oSintomaxConsulta As SintomaxConsulta)
        Dim str = "INSERT INTO SintomaxConsulta VALUES("
        str += "'" & oSintomaxConsulta.nro_historia_clinica & "' ,"
        str += oSintomaxConsulta.id_sucursal & ","
        str += oSintomaxConsulta.id_consulta & ","
        str += oSintomaxConsulta.id_sintoma & " ) "
        Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)
    End Function
    Public Function autoincrementarID(ByVal str As String, ByVal text As TextBox)
        BDHelper.getDBHelper.autoIncrementarID(str, text)
        Return Nothing
    End Function
End Class
