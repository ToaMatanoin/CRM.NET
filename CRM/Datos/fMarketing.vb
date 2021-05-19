Imports System.Data.SqlClient
Public Class fMarketing

    Inherits Conexion
    Dim ComandoSQL As New SqlCommand

    Public Function Mostrar() As DataTable  'Funcion Mostrar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("MostrarMarketing")
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


    Public Function Insertar(TablaDatos As eMarketing) As Boolean 'Funcion Insertar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("InsertarMarketing")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Usuario", TablaDatos.pID_Usuario)
            ComandoSQL.Parameters.AddWithValue("@ID_Producto", TablaDatos.pID_Producto)
            ComandoSQL.Parameters.AddWithValue("@ID_Cliente", TablaDatos.pID_Cliente)
            ComandoSQL.Parameters.AddWithValue("@Estrategia", TablaDatos.pEstrategia)
            ComandoSQL.Parameters.AddWithValue("@Descripcion", TablaDatos.pDescripcion)
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

    Public Function Actualizar(TablaDatos As eMarketing) As Boolean 'Funcion Actualizar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("ActualizarMarketing")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Marketing", TablaDatos.pID_Marketing)
            ComandoSQL.Parameters.AddWithValue("@ID_Usuario", TablaDatos.pID_Usuario)
            ComandoSQL.Parameters.AddWithValue("@ID_Producto", TablaDatos.pID_Producto)
            ComandoSQL.Parameters.AddWithValue("@ID_Cliente", TablaDatos.pID_Cliente)
            ComandoSQL.Parameters.AddWithValue("@Estrategia", TablaDatos.pEstrategia)
            ComandoSQL.Parameters.AddWithValue("@Descripcion", TablaDatos.pDescripcion)
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

    Public Function Eliminar(TablaDatos As eMarketing) As Boolean 'Funcion Eliminar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("EliminarMarketing")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect 'Conecta DB
            ComandoSQL.Parameters.AddWithValue("@ID_Marketing", TablaDatos.pID_Marketing)
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
