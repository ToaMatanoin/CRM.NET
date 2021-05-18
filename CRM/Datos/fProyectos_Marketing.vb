Imports System.Data.SqlClient
Public Class fProyectos_Marketing

    Inherits Conexion
    Dim ComandoSQL As New SqlCommand

    Public Function Mostrar() As DataTable  'Funcion Mostrar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("MostrarProyectos")
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


    Public Function Insertar(TablaDatos As eProyectos_Marketing) As Boolean 'Funcion Insertar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("InsertarProyecto")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Marketing", TablaDatos.pID_Marketing)
            ComandoSQL.Parameters.AddWithValue("@Nombre_Proyecto", TablaDatos.pNombre_Proyecto)
            ComandoSQL.Parameters.AddWithValue("@Descripcion", TablaDatos.pDescripcion)
            ComandoSQL.Parameters.AddWithValue("@Fecha_Inicial", TablaDatos.pFecha_Inicial)
            ComandoSQL.Parameters.AddWithValue("@Fecha_Conclusion", TablaDatos.pFecha_Conclusion)
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

    Public Function Actualizar(TablaDatos As eProyectos_Marketing) As Boolean 'Funcion Actualizar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("ActualizarProyecto")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Marketing", TablaDatos.pID_Marketing)
            ComandoSQL.Parameters.AddWithValue("@Nombre_Proyecto", TablaDatos.pNombre_Proyecto)
            ComandoSQL.Parameters.AddWithValue("@Descripcion", TablaDatos.pDescripcion)
            ComandoSQL.Parameters.AddWithValue("@Fecha_Inicial", TablaDatos.pFecha_Inicial)
            ComandoSQL.Parameters.AddWithValue("@Fecha_Conclusion", TablaDatos.pFecha_Conclusion)
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

    Public Function Eliminar(TablaDatos As eProyectos_Marketing) As Boolean 'Funcion Eliminar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("EliminarProyecto")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect 'Conecta DB
            ComandoSQL.Parameters.AddWithValue("@ID_Proyecto", TablaDatos.pID_Proyecto)
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
