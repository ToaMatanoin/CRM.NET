Imports System.Data.SqlClient
Public Class fOportunides

    Inherits Conexion
    Dim ComandoSQL As New SqlCommand

    Public Function Mostrar() As DataTable  'Funcion Mostrar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("MostrarOportunidad")
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

    Public Function Insertar(TablaDatos As eOportunidades) As Boolean 'Funcion Insertar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("InsertarOportunidad")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Usuario", TablaDatos.pID_Usuario)
            ComandoSQL.Parameters.AddWithValue("@Nombre_CliPoten", TablaDatos.pCliPot_Nombre)
            ComandoSQL.Parameters.AddWithValue("@Descripcion", TablaDatos.pDescrip)
            ComandoSQL.Parameters.AddWithValue("@Posibi_Nego", TablaDatos.pPosibilidad)
            ComandoSQL.Parameters.AddWithValue("@Tel_CliPoten", TablaDatos.pCliPot_Telefono)
            ComandoSQL.Parameters.AddWithValue("@Email_CliPoten", TablaDatos.pCliPot_Email)
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

    Public Function Actualizar(TablaDatos As eOportunidades) As Boolean 'Funcion Actualizar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("ActualizarOportunidad")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Oport", TablaDatos.pID_ClientePot)
            ComandoSQL.Parameters.AddWithValue("@ID_Usuario", TablaDatos.pID_Usuario)
            ComandoSQL.Parameters.AddWithValue("@Nombre_CliPoten", TablaDatos.pCliPot_Nombre)
            ComandoSQL.Parameters.AddWithValue("@Descripcion", TablaDatos.pDescrip)
            ComandoSQL.Parameters.AddWithValue("@Posibi_Nego", TablaDatos.pPosibilidad)
            ComandoSQL.Parameters.AddWithValue("@Tel_CliPoten", TablaDatos.pCliPot_Telefono)
            ComandoSQL.Parameters.AddWithValue("@Email_CliPoten", TablaDatos.pCliPot_Email)
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

    Public Function Eliminar(TablaDatos As eOportunidades) As Boolean 'Funcion Eliminar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("EliminarOportunidad")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect 'Conecta DB
            ComandoSQL.Parameters.AddWithValue("@ID_Oport", TablaDatos.pID_ClientePot)
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
