Imports System.Data.SqlClient
Public Class fFactura

    Inherits Conexion
    Dim ComandoSQL As New SqlCommand

    Public Function Mostrar() As DataTable  'Funcion Mostrar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("MostrarFactura")
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

    Public Function Insertar(TablaDatos As eFactura) As Boolean 'Funcion Insertar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("InsertarFactura")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Venta", TablaDatos.pID_Venta)
            ComandoSQL.Parameters.AddWithValue("@Tp_Venta", TablaDatos.pTp_Venta)
            ComandoSQL.Parameters.AddWithValue("@Fac_Descuento", TablaDatos.pFac_Descuento)
            ComandoSQL.Parameters.AddWithValue("@Fac_Impuesto", TablaDatos.pFac_Impuesto)
            ComandoSQL.Parameters.AddWithValue("@Fac_RTN", TablaDatos.pFac_RTN)
            ComandoSQL.Parameters.AddWithValue("@Fac_Total", TablaDatos.pFac_Total)

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

    'Public Function Actualizar(TablaDatos As eFactura) As Boolean 'Funcion Actualizar
    '    Try
    '        ConexionDB()
    '        ComandoSQL = New SqlCommand("ActualizarFactura")
    '        ComandoSQL.CommandType = CommandType.StoredProcedure
    '        ComandoSQL.Connection = Connect
    '        ComandoSQL.Parameters.AddWithValue("@ID_Factura", TablaDatos.pID_Factura)
    '        ComandoSQL.Parameters.AddWithValue("@ID_Venta", TablaDatos.pID_Venta)
    '        ComandoSQL.Parameters.AddWithValue("@Fac_Descuento", TablaDatos.pFac_Descuento)
    '        ComandoSQL.Parameters.AddWithValue("@Fac_Impuesto", TablaDatos.pFac_Impuesto)
    '        ComandoSQL.Parameters.AddWithValue("@Fac_RTN", TablaDatos.pFac_RTN)
    '        ComandoSQL.Parameters.AddWithValue("@Fac_Total", TablaDatos.pFac_Total)
    '        If ComandoSQL.ExecuteNonQuery Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch Evento As Exception
    '        MsgBox(Evento.Message)
    '        Return False
    '    Finally
    '        DesconexionDB()
    '    End Try
    'End Function

    Public Function Eliminar(TablaDatos As eFactura) As Boolean 'Funcion Eliminar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("EliminarFactura")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect 'Conecta DB
            ComandoSQL.Parameters.AddWithValue("@ID_Factura", TablaDatos.pID_Factura)
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
