Imports System.Data.SqlClient
Public Class Dashboard
    Inherits Conexion
    Dim ComandoSQL As New SqlCommand
    Public dr As SqlDataReader
    Public nomprod(5) As String
    Public cantprod(5) As Integer

    Public Sub ProdPreferidos()
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("prodpreferidos")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect
            dr = ComandoSQL.ExecuteReader
            Dim i As Integer = 0
            While (dr.Read())
                nomprod(i) = dr.GetString(0)
                cantprod(i) = dr.GetInt32(1)
                i += 1
            End While
            Inicio.chartProdPreferidos.Series(0).Points.DataBindXY(nomprod, cantprod)
            dr.Close()
        Catch Evento As Exception
            MsgBox(Evento.Message)
        Finally
            DesconexionDB()
        End Try
    End Sub

    Public Sub Dashboard()
        Try
            ConexionDB()
            ComandoSQL = New SqlCommand("DashboardDatos")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            ComandoSQL.Connection = Connect

            Dim total As New SqlParameter("@totVentas", 0)
            total.Direction = ParameterDirection.Output
            Dim nprod As New SqlParameter("@nprod", 0)
            nprod.Direction = ParameterDirection.Output
            Dim nemp As New SqlParameter("@nemp", 0)
            nemp.Direction = ParameterDirection.Output
            Dim ncli As New SqlParameter("@ncli", 0)
            ncli.Direction = ParameterDirection.Output
            Dim nclipo As New SqlParameter("@nclipo", 0)
            nclipo.Direction = ParameterDirection.Output

            ComandoSQL.Parameters.Add(total)
            ComandoSQL.Parameters.Add(nprod)
            ComandoSQL.Parameters.Add(nemp)
            ComandoSQL.Parameters.Add(ncli)
            ComandoSQL.Parameters.Add(nclipo)

            If ComandoSQL.ExecuteNonQuery Then
                Inicio.lblventas.Text = ComandoSQL.Parameters("@totVentas").Value.ToString
                Inicio.lblproductos.Text = ComandoSQL.Parameters("@nprod").Value.ToString
                Inicio.lblempleados.Text = ComandoSQL.Parameters("@nemp").Value.ToString
                Inicio.lblclientes.Text = ComandoSQL.Parameters("@ncli").Value.ToString
                Inicio.lbloportunidades.Text = ComandoSQL.Parameters("@nclipo").Value.ToString
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        Finally
            DesconexionDB()
        End Try
    End Sub
End Class
