Imports System.Data.SqlClient

Public Class fEncargo

    Inherits Conexion
    Dim ComandoSQL As New SqlCommand

    Public Function Mostrar() As DataTable  'Funcion Mostrar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("MostrarEncargos")
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


    Public Function Insertar(TablaDatos As eEncargo) As Boolean 'Funcion Insertar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("InsertarEncargo")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Factura", TablaDatos.pID_Factura)
            ComandoSQL.Parameters.AddWithValue("@Enc_Entregado", TablaDatos.pEnc_Entregado)
            ComandoSQL.Parameters.AddWithValue("@Descripcion", TablaDatos.pDescripcion)
            ComandoSQL.Parameters.AddWithValue("@Fecha_Encargo", TablaDatos.pFecha_Encargo)
            ComandoSQL.Parameters.AddWithValue("@Fecha_Entrega", TablaDatos.pFecha_Entrega)
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

    Public Function Actualizar(TablaDatos As eEncargo) As Boolean 'Funcion Actualizar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("ActualizarEncargo")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Factura", TablaDatos.pID_Factura)
            ComandoSQL.Parameters.AddWithValue("@Enc_Entregado", TablaDatos.pEnc_Entregado)
            ComandoSQL.Parameters.AddWithValue("@Descripcion", TablaDatos.pDescripcion)
            ComandoSQL.Parameters.AddWithValue("@Fecha_Encargo", TablaDatos.pFecha_Encargo)
            ComandoSQL.Parameters.AddWithValue("@Fecha_Entrega", TablaDatos.pFecha_Entrega)
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

    Public Function Eliminar(TablaDatos As eTareas_Marketing) As Boolean 'Funcion Eliminar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("EliminarEncargo")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect 'Conecta DB
            ComandoSQL.Parameters.AddWithValue("@ID_Encargo", TablaDatos.pID_Encargo)
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
