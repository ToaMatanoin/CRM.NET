Imports System.Data.SqlClient

Public Class fVentas


    Inherits Conexion
    Dim ComandoSQL As New SqlCommand

    Public Function Mostrar() As DataTable  'Funcion Mostrar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("MostrarVentas")
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

    Public Function Insertar(TablaDatos As eVentas) As Boolean 'Funcion Insertar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("InsertarVenta")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Usuario", TablaDatos.pID_Usuario)
            ComandoSQL.Parameters.AddWithValue("@ID_Cliente", TablaDatos.pID_Cliente)
            ComandoSQL.Parameters.AddWithValue("@ID_Producto", TablaDatos.pID_Producto)
            ComandoSQL.Parameters.AddWithValue("@Ven_Fecha", TablaDatos.pVen_Fecha)
            ComandoSQL.Parameters.AddWithValue("@Ven_CantVendida", TablaDatos.pVen_CantVendida)
            ComandoSQL.Parameters.AddWithValue("@Ven_Subtotal", TablaDatos.pVen_subtotal)
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

    Public Function Actualizar(TablaDatos As eVentas) As Boolean 'Funcion Actualizar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("ActualizarVenta")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Usuario", TablaDatos.pID_Usuario)
            ComandoSQL.Parameters.AddWithValue("@ID_Cliente", TablaDatos.pID_Cliente)
            ComandoSQL.Parameters.AddWithValue("@ID_Producto", TablaDatos.pID_Producto)
            ComandoSQL.Parameters.AddWithValue("@Ven_Fecha", TablaDatos.pVen_Fecha)
            ComandoSQL.Parameters.AddWithValue("@Ven_CantVendida", TablaDatos.pVen_CantVendida)
            ComandoSQL.Parameters.AddWithValue("@Ven_Subtotal", TablaDatos.pVen_subtotal)
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

    Public Function Eliminar(TablaDatos As eVentas) As Boolean 'Funcion Eliminar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("EliminarVentas")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect 'Conecta DB
            ComandoSQL.Parameters.AddWithValue("@ID_Venta", TablaDatos.pID_Ventas)
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
