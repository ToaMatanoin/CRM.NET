Imports System.Data.SqlClient
Public Class fInventario

    Inherits Conexion
    Dim ComandoSQL As New SqlCommand

    Public Function Mostrar() As DataTable  'Funcion Mostrar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("MostrarInventario")
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

    Public Function Insertar(TablaDatos As eInventario) As Boolean 'Funcion Insertar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("InsertarProducto")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@Pro_Nombre", TablaDatos.pPro_Nombre)
            ComandoSQL.Parameters.AddWithValue("@Pro_Cantidad", TablaDatos.pPro_Cantidad)
            ComandoSQL.Parameters.AddWithValue("@Pro_PreVenta", TablaDatos.pPro_preventa)
            ComandoSQL.Parameters.AddWithValue("@Pro_PreCompra", TablaDatos.pPro_precompra)
            ComandoSQL.Parameters.AddWithValue("@Nombre_Proveedor", TablaDatos.pNombre_Proveedor)
            ComandoSQL.Parameters.AddWithValue("@Pro_Disponible", TablaDatos.pPro_disponible)
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

    Public Function Actualizar(TablaDatos As eInventario) As Boolean 'Funcion Actualizar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("ActualizarInventario")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@Pro_Nombre", TablaDatos.pPro_Nombre)
            ComandoSQL.Parameters.AddWithValue("@Pro_Cantidad", TablaDatos.pPro_Cantidad)
            ComandoSQL.Parameters.AddWithValue("@Pro_PreVenta", TablaDatos.pPro_preventa)
            ComandoSQL.Parameters.AddWithValue("@Pro_PreCompra", TablaDatos.pPro_precompra)
            ComandoSQL.Parameters.AddWithValue("@Nombre_Proveedor", TablaDatos.pNombre_Proveedor)
            ComandoSQL.Parameters.AddWithValue("@Pro_Disponible", TablaDatos.pPro_disponible)
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

    Public Function Eliminar(TablaDatos As eInventario) As Boolean 'Funcion Eliminar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("EliminarInventario")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect 'Conecta DB
            ComandoSQL.Parameters.AddWithValue("@ID_Producto", TablaDatos.pID_Producto)
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
