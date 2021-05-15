Imports System.Data.SqlClient
Public Class fUsuarios

    Inherits Conexion
    Dim ComandoSQL As New SqlCommand

    Public Function Mostrar() As DataTable  'Funcion Mostrar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("MostrarUsuario")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            If ComandoSQL.ExecuteNonQuery Then
                Dim TablaDatos As New DataTable
                Dim AdaptadorDatos As New SqlDataAdapter(ComandoSQL)
                AdaptadorDatos.Fill(TablaDatos)
                Return TablaDatos
            Else
                Return Nothing
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
            Return Nothing
        Finally
            DesconexionDB()
        End Try
    End Function

    Public Function Insertar(TablaDatos As eUsuarios) As Boolean 'Funcion Insertar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("InsertarUsuario")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@Usu_Nombre", TablaDatos.pUsu_Nombre)
            ComandoSQL.Parameters.AddWithValue("@Usu_Contrasenha", TablaDatos.pUsu_Contrasenha)
            ComandoSQL.Parameters.AddWithValue("@Usu_Cargo", TablaDatos.pUsu_Cargo)
            ComandoSQL.Parameters.AddWithValue("@ID_Empleado", TablaDatos.pID_Empleado)

            If ComandoSQL.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
            Return False
        Finally
            DesconexionDB()
        End Try
    End Function

    Public Function Actualizar(TablaDatos As eUsuarios) As Boolean 'Funcion Actualizar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("ActualizarUsuario")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Usuario", TablaDatos.pID_Usuario)
            ComandoSQL.Parameters.AddWithValue("@Usu_Nombre", TablaDatos.pUsu_Nombre)
            ComandoSQL.Parameters.AddWithValue("@Usu_Contrasenha", TablaDatos.pUsu_Contrasenha)
            ComandoSQL.Parameters.AddWithValue("@Usu_Cargo", TablaDatos.pUsu_Cargo)
            ComandoSQL.Parameters.AddWithValue("@ID_Empleado", TablaDatos.pID_Empleado)
            If ComandoSQL.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
            Return False
        Finally
            DesconexionDB()
        End Try
    End Function

    Public Function Eliminar(TablaDatos As eUsuarios) As Boolean 'Funcion Eliminar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("EliminarUsuario")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect 'Conecta DB
            ComandoSQL.Parameters.AddWithValue("@ID_Usuario", TablaDatos.pID_Usuario)
            If ComandoSQL.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
            Return False
        Finally
            DesconexionDB()
        End Try
    End Function
End Class

