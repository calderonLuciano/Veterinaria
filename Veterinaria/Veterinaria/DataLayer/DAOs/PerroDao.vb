Public Class PerroDao
    Public Function getAll() As List(Of Perro)
        Dim oPerro As Perro
        Dim perros As New List(Of Perro)
        Dim strSQL = "SELECT P.* FROM Perros P"



        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oPerro = New Perro()
            With oPerro
                .nro_historiaClinica = (row.Item("nro_historia_clinica").ToString)
                .id_sucursal = (row.Item("id_sucursal").ToString)
                .nombre = (row.Item("nombre").ToString)
                .fecha_nacimiento = (row.Item("fecha_nacimiento"))
                .id_raza = (row.Item("id_raza"))
                .id_dueño = (row.Item("id_dueño"))
                .peso = (row.Item("peso"))
                .altura = (row.Item("altura"))



            End With
            perros.Add(oPerro)
        Next

        Return perros
    End Function

    Public Function buscarPerros(ByVal desc As String) As List(Of Perro)
        Dim oPerro As Perro
        Dim perros As New List(Of Perro)
        Dim strSQL = ("SELECT * FROM Perros WHERE nombre='" & desc & "'")
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(strSQL).Rows
            oPerro = New Perro()
            With oPerro
                .nro_historiaClinica = (row.Item("nro_historia_clinica").ToString)
                .id_sucursal = (row.Item("id_sucursal").ToString)
                .nombre = (row.Item("nombre").ToString)
                .fecha_nacimiento = (row.Item("fecha_nacimiento"))
                .id_raza = (row.Item("id_raza"))
                .id_dueño = (row.Item("id_dueño"))
                .peso = (row.Item("peso"))
                .altura = (row.Item("altura"))


            End With
            perros.Add(oPerro)
        Next
        Return perros
    End Function

    Public Function modificarPerros(ByVal oPerro As Perro)
        Try


            Dim strSQL As String = "UPDATE Perros SET  nombre='" & oPerro.nombre & "'" & ", fecha_nacimiento='" & oPerro.fecha_nacimiento & "', id_raza=" & oPerro.id_raza & ", id_dueño=" & oPerro.id_dueño & ", peso=" & oPerro.peso & "," & "altura=" & oPerro.altura & " WHERE nro_historia_clinica=" & oPerro.nro_historiaClinica & " AND " & " id_sucursal =" & oPerro.id_sucursal
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El Perro se modifico correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw ex
        End Try

        Return True
    End Function
    Public Function eliminarPerros(ByVal nro As Integer, suc As Integer)
        Try

            Dim strSQL As String = "DELETE FROM Perros WHERE  nro_historia_clinica=" & nro & "AND" & "sucursal=" & suc
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El perro se elimino correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Public Function guardarPerros(ByVal oPerro As Perro)
        Dim str = "INSERT INTO Perros VALUES("
        str += oPerro.nro_historiaClinica & ","
        str += oPerro.id_sucursal & " ,"
        str += "'" & oPerro.nombre & "',"
        str += "'" & oPerro.fecha_nacimiento & "' ,"
        str += oPerro.id_raza & ","
        str += oPerro.id_dueño & ","
        str += oPerro.peso & ","
        str += oPerro.altura & ")"

        Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)

    End Function
    Public Function autoincrementarID(ByVal str As String, ByVal text As TextBox)
        BDHelper.getDBHelper.autoIncrementarID(str, text)
        Return Nothing
    End Function
End Class
