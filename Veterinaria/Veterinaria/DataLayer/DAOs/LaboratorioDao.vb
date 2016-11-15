Public Class LaboratorioDao
    Public Function getAll() As List(Of Laboratorio)
        Dim oLaboratorio As Laboratorio
        Dim laboratorios As New List(Of Laboratorio)
        Dim strSQL = "SELECT L.* FROM Laboratorios L"



        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oLaboratorio = New Laboratorio()
            With oLaboratorio
                .id_laboratorio = (row.Item("id_laboratorio").ToString)
                .razonSocial = (row.Item("razon_social").ToString)
                .direccion = (row.Item("direccion").ToString)
                
            End With
            laboratorios.Add(oLaboratorio)
        Next

        Return laboratorios
    End Function

    Public Function buscarLaboratorios(ByVal nombre As String) As List(Of Laboratorio)
        Dim oLaboratorio As Laboratorio
        Dim laboratorios As New List(Of Laboratorio)
        Dim strSQL = ("SELECT * FROM Laboratorios WHERE razon_social='" + nombre.ToString + "'")
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(strSQL).Rows
            oLaboratorio = New Laboratorio()
            With oLaboratorio
                .id_laboratorio = (row.Item("id_laboratorio"))
                .razonSocial = (row.Item("razon_social").ToString)
                .direccion = (row.Item("direccion").ToString)
            End With
            laboratorios.Add(oLaboratorio)
        Next
        Return laboratorios
    End Function

    Public Function modificarLaboratorios(ByVal oLaboratorio As Laboratorio)
        Try


            Dim strSQL As String = "UPDATE Laboratorios SET  razon_social='" & oLaboratorio.razonSocial.ToString & "'" & ", direccion='" & oLaboratorio.direccion & "' WHERE id_laboratorio=" & oLaboratorio.id_laboratorio
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El laboratorio se modifico correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            Throw ex
        End Try

        Return True
    End Function
    Public Function eliminarLaboratorios(ByVal razonSocial As String)
        Try

            Dim strSQL As String = "DELETE FROM Laboratorios WHERE  razon_social='" & razonSocial & "'"
            BDHelper.getDBHelper.EjecutarSQL(strSQL)
            MessageBox.Show("El laboratorio se elimino correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function
    Public Function guardarLaboratorios(ByVal oLaboratorio As Laboratorio)
        Dim str = "INSERT INTO Laboratorios VALUES("
        str += oLaboratorio.id_laboratorio & " ,"
        str += "'" & oLaboratorio.razonSocial & "' ,"
        str += "'" & oLaboratorio.direccion & "' )"
        Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)

    End Function
    Public Function autoincrementarID(ByVal str As String, ByVal text As TextBox)
        BDHelper.getDBHelper.autoIncrementarID(str, text)
        Return Nothing
    End Function
End Class
