Public Class Ventas

    Public nuevo As New Conexion
    Private TablaDatos As New DataTable
    Public Bandera As New Boolean

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Bandera Then
            BtnRegresar.Visible = False
        Else
            BtnRegresar.Visible = True
        End If

        Mostrar()

        nuevo.ConexionDB()
        nuevo.llenado_cb(Cb_producto, "Pro_Nombre", "Inventario")

        Limpiar()
    End Sub

    Private Sub Mostrar()
        Try
            Dim Funcion As New fVentas
            TablaDatos = Funcion.Mostrar
            Dgv_Listado.Columns.Item("eliminar").Visible = False
            If TablaDatos.Rows.Count <> 0 Then
                Dgv_Listado.DataSource = TablaDatos
                Dgv_Listado.ColumnHeadersVisible = True
            Else
                Dgv_Listado.DataSource = Nothing
                Dgv_Listado.ColumnHeadersVisible = False
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
        Buscar()

    End Sub

    Private Sub Buscar()
        Try
            Dim ConjuntoDatos As New DataSet
            ConjuntoDatos.Tables.Add(TablaDatos.Copy)
            Dim VistaDatos As New DataView(ConjuntoDatos.Tables(0))
            VistaDatos.RowFilter = TxtNomCli.Text
            If VistaDatos.Count <> 0 Then
                Dgv_Listado.DataSource = VistaDatos
                OcultarColumna()
            Else
                Dgv_Listado.DataSource = Nothing
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
    End Sub


    Private Sub OcultarColumna()
        Dgv_Listado.Columns(1).Visible = False
    End Sub

    Private Sub Limpiar()
        TxtNomCli.Text = ""
        TxtEmailEmpresa.Text = ""
        TxtTelEmpresa.Text = ""

        Rd_contado.Checked = False
        Rd_credito.Checked = False
        Rd_tercera_no.Checked = False
        Rd_tercera_si.Checked = False


        BtnIngresar.Visible = True

    End Sub


    Private Sub TrasladoInformacion()
        Txt_ID_Venta.Text = Dgv_Listado.SelectedCells.Item(1).Value

    End Sub



    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Inicio.Visible = True
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

    End Sub
End Class