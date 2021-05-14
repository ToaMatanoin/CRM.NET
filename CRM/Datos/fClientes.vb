Imports System.Data.SqlClient
Public Class fClientes

    Inherits Conexion
    Dim ComandoSQL As New SqlCommand

    Public Function Mostrar() As DataTable  'Funcion Mostrar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("MostrarCliente")
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

    Public Function Insertar(TablaDatos As eClientes) As Boolean 'Funcion Insertar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("InsertarCliente")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@Cli_Nombre", TablaDatos.pCli_Nombre)
            ComandoSQL.Parameters.AddWithValue("@Cli_Telefono", TablaDatos.pCli_Telefono)
            ComandoSQL.Parameters.AddWithValue("@Cli_Email", TablaDatos.pCli_Email)
            ComandoSQL.Parameters.AddWithValue("@Cli_NombreEmpresa", TablaDatos.pCli_NombreEmpresa)
            ComandoSQL.Parameters.AddWithValue("@Cli_TelEmpresa", TablaDatos.pCli_TelEmpresa)
            ComandoSQL.Parameters.AddWithValue("@Cli_EmailEmpresa", TablaDatos.pCli_EmailEmpresa)
            ComandoSQL.Parameters.AddWithValue("@RTN", TablaDatos.pRTN)
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

    Public Function Actualizar(TablaDatos As eClientes) As Boolean 'Funcion Actualizar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("ActualizarCliente")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Cliente", TablaDatos.pID_Cliente)
            ComandoSQL.Parameters.AddWithValue("@Cli_Nombre", TablaDatos.pCli_Nombre)
            ComandoSQL.Parameters.AddWithValue("@Cli_Telefono", TablaDatos.pCli_Telefono)
            ComandoSQL.Parameters.AddWithValue("@Cli_Email", TablaDatos.pCli_Email)
            ComandoSQL.Parameters.AddWithValue("@Cli_NombreEmpresa", TablaDatos.pCli_NombreEmpresa)
            ComandoSQL.Parameters.AddWithValue("@Cli_TelEmpresa", TablaDatos.pCli_TelEmpresa)
            ComandoSQL.Parameters.AddWithValue("@Cli_EmailEmpresa", TablaDatos.pCli_EmailEmpresa)
            ComandoSQL.Parameters.AddWithValue("@RTN", TablaDatos.pRTN)
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

    Public Function Eliminar(TablaDatos As eClientes) As Boolean 'Funcion Eliminar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("EliminarCliente")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect 'Conecta DB
            ComandoSQL.Parameters.AddWithValue("@ID_Cliente", TablaDatos.pID_Cliente)
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