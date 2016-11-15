Public Class EmpleadoDao
    Public Function getAll() As List(Of Empleado)
        Dim oEmpleado As Empleado
        Dim empleados As New List(Of Empleado)
        Dim strSQL = "SELECT E.* FROM Empleados E"



        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oEmpleado = New Empleado()
            With oEmpleado
                .tipo_doc = (row.Item("tipo_doc").ToString)
                .nro_doc = Convert.ToInt32(row.Item("nro_doc").ToString)
                .nombre = (row.Item("nombre").ToString)
                .apellido = (row.Item("apellido").ToString)
                .fecha_nacimiento = (row.Item("fecha_nacimiento"))
                .fecha_ingreso = (row.Item("fecha_ingreso"))
                .matricula = row.Item("matricula").ToString
                .sucursal = Convert.ToInt32(row.Item("sucursal").ToString)
            End With
            empleados.Add(oEmpleado)
        Next

        Return empleados
    End Function

    Public Function buscarEmpleado(ByVal buscar As String) As List(Of Empleado)
        Dim oEmpleado As Empleado
        Dim empleados As New List(Of Empleado)
        Dim strSQL = ("SELECT * FROM Empleados WHERE (nombre LIKE('%" + buscar.ToString + "%') OR apellido LIKE('%" + buscar.ToString + "%' ) OR nro_doc LIKE ('%" + buscar.ToString + "%') ) ")
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(strSQL).Rows
            oEmpleado = New Empleado()
            With oEmpleado
                .tipo_doc = (row.Item("tipo_doc").ToString)
                .nro_doc = Convert.ToInt32(row.Item("nro_doc").ToString)
                .nombre = (row.Item("nombre").ToString)
                .apellido = (row.Item("apellido").ToString)
                .fecha_nacimiento = (row.Item("fecha_nacimiento"))
                .fecha_ingreso = (row.Item("fecha_ingreso"))
                .matricula = row.Item("matricula").ToString
                .sucursal = Convert.ToInt32(row.Item("sucursal").ToString)
            End With
            empleados.Add(oEmpleado)
        Next
        Return empleados
    End Function

    Public Function modificarEmpleados(ByVal oEmpleado As Empleado)
        Try


            Dim strSQL As String = "UPDATE Empleados SET tipo_doc='" & oEmpleado.tipo_doc.ToString & "'" & ",nro_doc=" & Convert.ToInt32(oEmpleado.nro_doc) & ", nombre='" & oEmpleado.nombre & "',apellido='" & oEmpleado.apellido & "',fecha_nacimiento='" & oEmpleado.fecha_nacimiento & "',fecha_ingreso='" & oEmpleado.fecha_ingreso & "',matricula='" & oEmpleado.matricula & "',sucursal=" & Convert.ToInt32(oEmpleado.sucursal) & " WHERE nro_doc=" & oEmpleado.nro_doc & "AND tipo_doc='" & oEmpleado.tipo_doc & "'"
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El empleado se modifico correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            Throw ex
        End Try

        Return True
    End Function
    Public Function eliminarEmpleados(ByVal nro_doc As String)
        Try
             
            Dim strSQL As String = "DELETE FROM Empleados WHERE  nro_doc=" & Convert.ToInt32(nro_doc)
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El empleado se elimino correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function
    Public Function guardarEmpleados(ByVal oEmpleado As Empleado)
        Dim str = "INSERT INTO Empleados VALUES("
        str += "'" & oEmpleado.tipo_doc & "' ,"
        str += oEmpleado.nro_doc & ","
        str += "'" & oEmpleado.nombre & "' ,"
        str += "'" & oEmpleado.apellido & "' ,"
        str += "'" & Convert.ToDateTime(oEmpleado.fecha_nacimiento) & "' ,"
        str += "'" & Convert.ToDateTime(oEmpleado.fecha_ingreso) & "' , "
        str += "'" & oEmpleado.matricula & "' ,"
        str += oEmpleado.sucursal & ")"
        Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)


    End Function
End Class




