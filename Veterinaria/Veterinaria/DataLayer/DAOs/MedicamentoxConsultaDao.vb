Public Class MedicamentoxConsultaDao
        Public Function getAll() As List(Of MedicamentoxConsulta)
            Dim oMedicamentoxConsulta As MedicamentoxConsulta
            Dim medicamentosxConsuta As New List(Of MedicamentoxConsulta)
            Dim strSQL = "SELECT E.* FROM MedicamentoxConsulta E"

            For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
                oMedicamentoxConsulta = New MedicamentoxConsulta()
                With oMedicamentoxConsulta
                    .nro_historia_clinica = row.Item("nro_historia_clinica").ToString
                    .id_sucursal = row.Item("id_sucursal").ToString
                    .id_medicamento = row.Item("id_medicamento").ToString
                    .dosis = row.Item("dosis").ToString
                    .periodicidad = row.Item("periocidad").ToString
                End With
                medicamentosxConsuta.Add(oMedicamentoxConsulta)
            Next
            Return medicamentosxConsuta
        End Function

        Public Function buscarMedicamentosxConsulta(ByVal buscar As String) As List(Of MedicamentoxConsulta)
            Dim oMedicamentoxConsulta As MedicamentoxConsulta
            Dim medicamentosxConsulta As New List(Of MedicamentoxConsulta)
        Dim strSQL = ("SELECT * FROM MedicamentoxConsulta WHERE id_consulta = " + buscar)
        'nro_historia_clinica LIKE('%" + buscar.ToString + "%') OR id_sucursal LIKE('%" + buscar.ToString + "%') OR id_medicamento LIKE('%" + buscar.ToString + "%') OR dosis LIKE('%" + buscar.ToString + "%') OR periodicidad LIKE('%" + buscar.ToString + "%') ) ")

            For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(strSQL).Rows
                oMedicamentoxConsulta = New MedicamentoxConsulta
                With oMedicamentoxConsulta
                    .nro_historia_clinica = row.Item("nro_historia_clinica").ToString
                    .id_sucursal = row.Item("id_sucursal").ToString
                    .id_medicamento = row.Item("id_medicamento").ToString
                    .dosis = row.Item("dosis").ToString
                .periodicidad = row.Item("periodicidad").ToString
                End With
                medicamentosxConsulta.Add(oMedicamentoxConsulta)
            Next
            Return medicamentosxConsulta
        End Function

        'Ver como vamos a hacer que esto funcione deberia recibir una lista y recorrerla
        Public Function guardarMedicamentoxConsulta(ByVal oMedicamentoxConsulta As MedicamentoxConsulta)
        Dim str As String = "INSERT INTO MedicamentoxConsulta VALUES("
        str += oMedicamentoxConsulta.nro_historia_clinica & " , "
        str += oMedicamentoxConsulta.id_sucursal & ", "
        str += oMedicamentoxConsulta.id_medicamento & " , "
        str += "'" & oMedicamentoxConsulta.dosis & "' , "
        str += "'" & oMedicamentoxConsulta.periodicidad & "' , "
            Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)
    End Function
    Public Function autoincrementarID(ByVal str As String, ByVal text As TextBox)
        BDHelper.getDBHelper.autoIncrementarID(str, text)
        Return Nothing
    End Function

    End Class

