Imports System.Data.SqlClient

Public Class Conexion
    Protected Connect As New SqlConnection
    Public Sentencia As SqlCommand
    Public Ejecucion As SqlDataReader
    Public Resultado As New Boolean

    Public Function ConexionDB() As Boolean
        Try
            'Conexion Manuel'
            'Connect = New SqlConnection("data source=.\sqlexpress;initial catalog=ASOFARMA;integrated security=true") '

            'Conexion Julio'
            'Connect = New SqlConnection("data source=localhost\SQLEXPRESS;initial catalog=ASOFARMA;integrated security=true")

            'Conexion Josue'
            'Connect = New SqlConnection("data source=LAPTOP-J5B9UU98\SQLEXPRESS;initial catalog=ASOFARMA;integrated security=true") '


            Connect.Open()
            Return True
        Catch Evento As Exception
            MsgBox(Evento.Message)
            Return False
        End Try
    End Function



    Public Function DesconexionDB() As Boolean
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
    Function Usuario(ByVal UsuNom As String) As Boolean
        Dim resulta As Boolean = False
        Try
            Sentencia = New SqlCommand("Select * from Usuarios where Usu_Nombre='" & UsuNom & "'", Connect)
            Ejecucion = Sentencia.ExecuteReader
            If Ejecucion.Read Then
                Resultado = True
            End If
            Ejecucion.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Resultado
    End Function

    Function Contrasenha(ByVal UsuNom As String) As String
        Dim resultado As String = ""
        Try
            Sentencia = New SqlCommand("Select Usu_Contrasenha from Usuarios where Usu_Nombre='" & UsuNom & "'", Connect)
            Ejecucion = Sentencia.ExecuteReader

            If Ejecucion.Read Then
                resultado = Ejecucion.Item("Usu_Contrasenha")
            End If
            Ejecucion.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function llenado_cb(cb As ComboBox, nombrep As String, nombret As String)

        Try
            Sentencia = New SqlCommand("Select " & nombrep & " from " & nombret & " ", Connect)
            Ejecucion = Sentencia.ExecuteReader
            While Ejecucion.Read

                cb.Items.Add(Ejecucion.Item(nombrep))
            End While
            Ejecucion.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Function Buscar_info(comparar As String, nombrep As String, nombrepre As String, nombret As String) As String
        Dim info As String
        Try
            Sentencia = New SqlCommand("Select " & nombrep & "," & nombrepre & " from " & nombret & " ", Connect)
            Ejecucion = Sentencia.ExecuteReader
            While Ejecucion.Read
                If comparar = Ejecucion.Item(nombrep) Then
                    info = Convert.ToString(Ejecucion.Item(nombrepre))
                End If
            End While
            Ejecucion.Close()
            Return info
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return info
    End Function



End Class
