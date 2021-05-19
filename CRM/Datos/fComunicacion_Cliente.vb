Imports System.Data.SqlClient
Public Class fComunicacion_Cliente
    Inherits Conexion
    Dim ComandoSQL As New SqlCommand

    Public Function Mostrar() As DataTable  'Funcion Mostrar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("MostrarEmail")
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

    Public Function Insertar(TablaDatos As eComunicacion_Cliente) As Boolean 'Funcion Insertar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("InsertarEmail")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Empleado", TablaDatos.pID_Empleado)
            ComandoSQL.Parameters.AddWithValue("@ID_Cliente", TablaDatos.pID_Cliente)
            ComandoSQL.Parameters.AddWithValue("@Email_Asunto", TablaDatos.pEmail_Asunto)
            ComandoSQL.Parameters.AddWithValue("@Email_Mensaje", TablaDatos.pEmail_Mensaje)
            ComandoSQL.Parameters.AddWithValue("@Email_Fecha", TablaDatos.pEmail_Fecha)
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

    Public Function Eliminar(TablaDatos As eComunicacion_Cliente) As Boolean 'Funcion Eliminar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("EliminarEmail")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect 'Conecta DB
            ComandoSQL.Parameters.AddWithValue("@ID_Email", TablaDatos.pID_Email)
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
