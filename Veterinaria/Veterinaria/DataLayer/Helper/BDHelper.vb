Imports System.Data.SqlClient

Public Class BDHelper
    Private string_conexion As String
    Private Shared instance As BDHelper 'Unica instancia de la clase

    Private Sub New()
        string_conexion = "Data Source=EQUIPO-LU\LUCIANO;Initial Catalog=Veterinaria;Integrated Security=True"
    End Sub

    Public Shared Function getDBHelper() As BDHelper
        If IsNothing(instance) Then
            instance = New BDHelper()
        End If
        Return instance
    End Function
   

    Public Function EjecutarSQL(ByVal strSql As String) As Integer
        ' La función EjecutarSQL es una función compartida y puede ser invocada desde cualquier componente del proyecto
        ' Establece la conexión con la base de datos usando la clase SqlConnection
        ' Dimensiona los objetos conexion y sqlcomand 

        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand

        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            ' Establece que conexión usar
            conexion.ConnectionString = string_conexion
            ' Abre la conexión
            conexion.Open()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            ' Establece la instrucción a ejecutar
            cmd.CommandText = strSql
            ' Retorna el resultado de ejecutar la consulta
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            ' Cierra la conexión
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        ' La función ConsultaSQL es una función compartida y puede ser invocada desde cualquier componente del proyecto
        ' Se utiliza para sentencias SQL del tipo “Select”
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function


    Public Function EjecutarSQLBajoTransaccion(ByVal strSql As String) As Integer

        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim transaccion As SqlTransaction = Nothing
        Dim status As Integer = 0
        Try

            conexion.ConnectionString = string_conexion
            conexion.Open()
            transaccion = conexion.BeginTransaction()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.Transaction = transaccion
            cmd.CommandText = strSql
            transaccion.Commit()
            status = 1
            'MsgBox("Ejecutando Commit")
            MessageBox.Show("Se cargo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return cmd.ExecuteNonQuery()
        Catch ex As SqlException
            transaccion.Rollback()
            status = 0
            ' MsgBox("EjecutandoRollback")
            MessageBox.Show("Algo ocurrio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return status
    End Function

    Public Function autoIncrementarID(ByVal strSQL As String, campo As TextBox) As Integer
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            Dim numero As Integer
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSQL
            If IsDBNull(cmd.ExecuteScalar) Then
                numero = 1
                campo.Text = numero
                Return numero
            Else
                numero = cmd.ExecuteScalar + 1
                campo.Text = numero
                Return numero
            End If

        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function
    Public Function generarReporte(ByVal fecDesde As String, ByVal fecHasta As String) As DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM EMPLEADOS GROUP BY sucursal"
            'SELECT T1.n_usuario as tester, T2.n_estado as estado, COUNT(T.id_bug)as ctd " & _
            '"FROM Bugs T, Users T1, Estados T2 " & _
            '"WHERE(T.id_estado = T2.id_estado And T.asignado_a = T1.id_usuario) " & _
            '"AND (T.fecha>='" + Convert.ToDateTime(fecDesde).ToString("yyyy-MM-dd") + "' " & _
            '"AND T.fecha<='" + Convert.ToDateTime(fecHasta).ToString("yyyy-MM-dd") + "') " & _
            '"GROUP BY T1.n_usuario ,T2.n_estado"
            tabla.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try

        Return tabla
    End Function
End Class

