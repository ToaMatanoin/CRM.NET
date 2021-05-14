Imports System.Data.SqlClient

Public Class Conexion
    Protected Connect As New SqlConnection

    Protected Function ConexionDB() As Boolean
        Try
            Connect = New SqlConnection("data source=.\sqlexpress;initial catalog=ASOFARMA;integrated security=true")
            Connect.Open()
            Return True
        Catch Evento As Exception
            MsgBox(Evento.Message)
            Return False
        End Try
    End Function

    Protected Function DesconexionDB() As Boolean
        Try
            If Connect.State = ConnectionState.Open Then
                Connect.Close()
                Return True
            Else
                Return False
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
            Return False
        End Try

    End Function

End Class
