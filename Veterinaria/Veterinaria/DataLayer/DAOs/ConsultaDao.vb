Public Class ConsultaDao

    Function getAll() As List(Of Consulta)
        Dim oConsulta As Consulta
        Dim consultas As New List(Of Consulta)
        Dim str = "SELECT * FROM Consulta"

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(str).Rows
            oConsulta = New Consulta

            With oConsulta
                .nro_historiaClinica = (row.Item("nro_historia_clinica").ToString)
                .id_sucursal = (row.Item("id_sucursal").ToString)
                .id_consulta = (row.Item("id_consulta").ToString)
                .tipoDocEmpleado = (row.Item("tipo_documento_empl").ToString)
                .nroDocEmpleado = (row.Item("nro_documento_empl"))
                .fechaEntrada = (row.Item("fecha_entrada"))
                .fechaSalida = (row.Item("fecha_salida"))
            End With
            consultas.Add(oConsulta)
        Next

        Return consultas

    End Function

    Function buscarConsultaFecha(fechaDesde As String, fechaHasta As String) As List(Of Consulta)
        Dim oConsulta As Consulta
        Dim consultas As List(Of Consulta) = New List(Of Consulta)

        Dim Str = "SELECT  * FROM Consultas WHERE fecha_entrada >=" + "'" + fechaDesde.ToString + "' AND fecha_salida <= '" + fechaHasta.ToString + "'"
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(Str).Rows
            oConsulta = New Consulta
            With oConsulta
                .nro_historiaClinica = row.Item("nro_historia_clinica")
                .id_sucursal = row.Item("id_sucursal")
                .id_consulta = row.Item("id_consulta")
                .tipoDocEmpleado = row.Item("tipo_documento_empl")
                .nroDocEmpleado = row.Item("nro_documento_empl")
                .fechaEntrada = row.Item("fecha_entrada")
                .fechaSalida = row.Item("fecha_salida")
            End With
            consultas.Add(oConsulta)
        Next

        Return consultas

    End Function
    Public Function buscarConsulta(ByVal buscar As String) As List(Of Consulta)
        Dim oConsulta As Consulta
        Dim consultas As New List(Of Consulta)
        Dim str = ("SELECT * FROM Consultas WHERE (nro_historia_clinica LIKE('%" + buscar.ToString + "%') OR id_consulta LIKE('%" + buscar.ToString + "%') OR nro_documento_empl LIKE('%" + buscar.ToString + "%'))")
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
            oConsulta = New Consulta
            With oConsulta
                .tipoDocEmpleado = (row.Item("tipo_documento_empl").ToString)
                .nroDocEmpleado = (row.Item("nro_documento_empl").ToString)
                .id_consulta = (row.Item("id_consulta").ToString)
                .id_sucursal = (row.Item("id_sucursal").ToString)
                .nro_historiaClinica = (row.Item("nro_historia_clinica").ToString)
                .fechaEntrada = (row.Item("fecha_entrada").ToString)
                .fechaSalida = (row.Item("fecha_salida").ToString)
            End With
            consultas.Add(oConsulta)
        Next
        Return consultas
    End Function
    Public Function buscarMedicamentosxConsulta(ByVal idConsulta As Integer) As List(Of MedicamentoxConsulta)
        Dim oMedicamentoxConsulta As MedicamentoxConsulta
        Dim medicamentosxConsultas As New List(Of MedicamentoxConsulta)
        Dim str = "SELECT * FROM MedicamentoxConsulta WHERE id_consulta= " & idConsulta
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
            oMedicamentoxConsulta = New MedicamentoxConsulta
            With oMedicamentoxConsulta
                .dosis = (row.Item("dosis").ToString)
                .id_consulta = (row.Item("id_consulta").ToString)
                .id_medicamento = (row.Item("id_medicamento").ToString)
                .id_sucursal = (row.Item("id_sucursal").ToString)
                .nro_historia_clinica = (row.Item("nro_historia_clinica").ToString)
                .periodicidad = (row.Item("periodicidad").ToString)
            End With
            medicamentosxConsultas.Add(oMedicamentoxConsulta)
        Next
        Return medicamentosxConsultas
    End Function
    Public Function buscarSintomasxConsulta(ByVal idConsulta As Integer)
        Dim oSintomaxConsulta As SintomaxConsulta
        Dim sintomasxConsulta = New List(Of SintomaxConsulta)
        Dim str = "SELECT * FROM SintomaxConsulta WHERE id_consulta= " & idConsulta
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
            oSintomaxConsulta = New SintomaxConsulta
            With oSintomaxConsulta
                .id_sucursal = (row.Item("id_sucursal").ToString)
                .id_sintoma = (row.Item("id_sintoma").ToString)
                .nro_historia_clinica = (row.Item("nro_historia_clinica").ToString)
                .id_consulta = (row.Item("id_consulta").ToString)
            End With
            sintomasxConsulta.Add(oSintomaxConsulta)
        Next
        Return sintomasxConsulta
    End Function
    Public Function buscarDiagnosticosxConsulta(ByVal idConsulta As Integer)
        Dim oDiagnosticoxConsulta As DiagnosticoxConsulta
        Dim diagnosticoxConsulta = New List(Of DiagnosticoxConsulta)
        Dim str = "SELECT * FROM DiagnosticoxConsulta WHERE id_consulta= " & idConsulta
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
            oDiagnosticoxConsulta = New DiagnosticoxConsulta
            With oDiagnosticoxConsulta
                .id_sucursal = (row.Item("id_sucursal").ToString)
                .id_diagnostico = (row.Item("id_diagnostico").ToString)
                .nro_historia_clinica = (row.Item("nro_historia_clinica").ToString)
                .id_consulta = (row.Item("id_consulta").ToString)
            End With
            diagnosticoxConsulta.Add(oDiagnosticoxConsulta)
        Next
        Return diagnosticoxConsulta
    End Function

    Public Function autoincrementarID(ByVal str As String, ByVal text As TextBox)
        BDHelper.getDBHelper.autoIncrementarID(str, text)
        Return Nothing
    End Function

    Public Function guardarConsulta(ByVal oConsulta As Consulta, ByVal lst_medicamentosxConsulta As List(Of MedicamentoxConsulta), ByVal lst_sintomasxConsulta As List(Of SintomaxConsulta), ByVal lst_diagnosticosxConsulta As List(Of DiagnosticoxConsulta))


        Dim str As String = "INSERT INTO Consultas VALUES("
        str += oConsulta.nro_historiaClinica.ToString & ", "
        str += oConsulta.id_sucursal.ToString & ", "
        str += oConsulta.id_consulta & ", "
        str += "'" & oConsulta.tipoDocEmpleado.ToString & "', "
        str += oConsulta.nroDocEmpleado.ToString & " , "
        str += "'" & oConsulta.fechaEntrada & "' , "
        str += "'" & oConsulta.fechaSalida & "' ); "

        For Each oMedicamento As MedicamentoxConsulta In lst_medicamentosxConsulta
            str += " " & " INSERT INTO MedicamentoxConsulta VALUES ("
            str += oMedicamento.nro_historia_clinica.ToString & ","
            str += oMedicamento.id_sucursal.ToString & ","
            str += oMedicamento.id_consulta.ToString & ","
            str += oMedicamento.id_medicamento.ToString & ","
            str += "'" & oMedicamento.dosis & "' ,"
            str += "'" & oMedicamento.periodicidad & "');"
        Next

        For Each oSintomaxConsulta As SintomaxConsulta In lst_sintomasxConsulta
            str += " " & "INSERT INTO SintomaxConsulta VALUES ("
            str += oSintomaxConsulta.nro_historia_clinica.ToString & ","
            str += oSintomaxConsulta.id_sucursal.ToString & ","
            str += oSintomaxConsulta.id_consulta.ToString & ","
            str += oSintomaxConsulta.id_sintoma.ToString & ");"
        Next

        For Each oDiagnosticoxConsulta As DiagnosticoxConsulta In lst_diagnosticosxConsulta
            str += " " & " INSERT INTO DiagnosticoxConsulta VALUES ("
            str += oDiagnosticoxConsulta.nro_historia_clinica.ToString & ","
            str += oDiagnosticoxConsulta.id_sucursal.ToString & ","
            str += oDiagnosticoxConsulta.id_consulta.ToString & ","
            str += oDiagnosticoxConsulta.id_diagnostico.ToString & ");"
        Next
        Return (BDHelper.getDBHelper.EjecutarSQLBajoTransaccion(str)) = 1

    End Function


End Class
