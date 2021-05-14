Imports System.Data.SqlClient
Public Class fEmpleados

    Inherits Conexion
    Dim ComandoSQL As New SqlCommand

    Public Function Mostrar() As DataTable  'Funcion Mostrar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("MostrarEmpleado")
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

    Public Function Insertar(TablaDatos As eEmpleados) As Boolean 'Funcion Insertar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("InsertarEmpleado")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@Emp_Nombre", TablaDatos.pEmp_Nombre)
            ComandoSQL.Parameters.AddWithValue("@Emp_Telefono", TablaDatos.pEmp_Telefono)
            ComandoSQL.Parameters.AddWithValue("@Emp_Email", TablaDatos.pEmp_Email)
            ComandoSQL.Parameters.AddWithValue("@Emp_Direccion", TablaDatos.pEmp_Direccion)
            ComandoSQL.Parameters.AddWithValue("@Emp_Cargo", TablaDatos.pEmp_Cargo)

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

    Public Function Actualizar(TablaDatos As eEmpleados) As Boolean 'Funcion Actualizar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("ActualizarEmpleado")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            ComandoSQL.Parameters.AddWithValue("@ID_Empleado", TablaDatos.pID_Empleado)
            ComandoSQL.Parameters.AddWithValue("@Emp_Nombre", TablaDatos.pEmp_Nombre)
            ComandoSQL.Parameters.AddWithValue("@Emp_Telefono", TablaDatos.pEmp_Telefono)
            ComandoSQL.Parameters.AddWithValue("@Emp_Email", TablaDatos.pEmp_Email)
            ComandoSQL.Parameters.AddWithValue("@Emp_Direccion", TablaDatos.pEmp_Direccion)
            ComandoSQL.Parameters.AddWithValue("@Emp_Cargo", TablaDatos.pEmp_Cargo)
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

    Public Function Eliminar(TablaDatos As eEmpleados) As Boolean 'Funcion Eliminar
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("EliminarEmpleado")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect 'Conecta DB
            ComandoSQL.Parameters.AddWithValue("@ID_Empleado", TablaDatos.pID_Empleado)
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
