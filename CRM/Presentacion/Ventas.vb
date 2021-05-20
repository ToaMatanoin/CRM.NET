Public Class Ventas

    Public nuevo As New Conexion
    Private TablaDatos As New DataTable
    Public Bandera As New Boolean
    Public Tventa, Desc, IDProd As String

    Public ProdCant, preventa, precompra, proveed As String

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
        TxtIdclli.Text = ""
        Txtcantidad.Text = ""
        Txtpreciounidad.Text = ""

        Rd_contado.Checked = False
        Rd_credito.Checked = False
        Rd_tercera_no.Checked = False
        Rd_tercera_si.Checked = False


        BtnIngresar.Visible = True


    End Sub


    Private Sub TrasladoInformacion()
        Txt_ID_Venta.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtIdclli.Text = Dgv_Listado.SelectedCells.Item(4).Value
        Txtcantidad.Text = Dgv_Listado.SelectedCells.Item(9).Value
        Cb_producto.Text = Dgv_Listado.SelectedCells.Item(7).Value

    End Sub

    Private Sub Dgv_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellClick
        TrasladoInformacion()
        If Bandera Then
            BtnDevolucion.Visible = False
        Else
            BtnDevolucion.Visible = True
        End If
        BtnIngresar.Visible = False
    End Sub



    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Inicio.Visible = True
        Me.Close()
    End Sub

    Private Sub Cb_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_producto.SelectedIndexChanged
        nuevo.ConexionDB()
        ProdCant = nuevo.Buscar_info(Cb_producto.Text, "Pro_Nombre", "Pro_Cantidad", "Inventario")
        preventa = nuevo.Buscar_info(Cb_producto.Text, "Pro_Nombre", "Pro_PreVenta", "Inventario")
        precompra = nuevo.Buscar_info(Cb_producto.Text, "Pro_Nombre", "Pro_PreCompra", "Inventario")
        proveed = nuevo.Buscar_info(Cb_producto.Text, "Pro_Nombre", "Nombre_Proveedor", "Inventario")


        IDProd = nuevo.Buscar_info(Cb_producto.Text, "Pro_Nombre", "ID_Producto", "Inventario")
        Txtpreciounidad.Text = nuevo.Buscar_info(Cb_producto.Text, "Pro_Nombre", "Pro_PreCompra", "Inventario")
    End Sub

    Private Sub Rd_credito_CheckedChanged(sender As Object, e As EventArgs) Handles Rd_credito.CheckedChanged
        Tventa = "Credito"
    End Sub

    Private Sub Rd_contado_CheckedChanged(sender As Object, e As EventArgs) Handles Rd_contado.CheckedChanged
        Tventa = "Contado"
    End Sub

    Private Sub Rd_tercera_si_CheckedChanged(sender As Object, e As EventArgs) Handles Rd_tercera_si.CheckedChanged
        Desc = "Si"
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnDevolucion.Click

        'devolver inventario
        If Txtcantidad.Text <> "" And TxtIdclli.Text <> "" And Txt_ID_Venta.Text <> "" And
            Txt_ID_Venta.Text <> "" And Cb_producto.SelectedIndex >= 0 Then

            Dim Resultad As DialogResult
            Resultad = MessageBox.Show("Desea Modificar los datos",
            "Actualizando Registro", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question)
            If Resultad = Windows.Forms.DialogResult.OK Then
                Try

                    Dim TablaDatos As New eInventario
                    Dim Funcion As New fInventario
                    Dim suma As Integer = Convert.ToInt32(ProdCant) + Convert.ToInt32(Txtcantidad.Text)


                    TablaDatos.pID_Producto = IDProd
                    TablaDatos.pPro_Nombre = Cb_producto.Text
                    TablaDatos.pPro_Cantidad = suma
                    TablaDatos.pPro_preventa = Convert.ToDouble(preventa)
                    TablaDatos.pPro_precompra = Convert.ToDouble(precompra)
                    TablaDatos.pNombre_Proveedor = proveed
                    TablaDatos.pPro_disponible = 1

                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("prueba de devolver producto a inventario exito",
                     "Actualizando Registro", MessageBoxButtons.OK,
                      MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("prueba de devolver producto a inventario fallo",
                     "Actualizando Registro", MessageBoxButtons.OK,
                      MessageBoxIcon.Information)
                    End If

                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Else
                MessageBox.Show("Cancelado por el usuario",
                      "Guardando Registro", MessageBoxButtons.OK,
                       MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar",
                      "Guardando Registro", MessageBoxButtons.OK,
                       MessageBoxIcon.Information)
        End If

        'eliminar venta
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Desea hacer una devolucion",
        "Eliminando Registro", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question)
        If Resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Dgv_Listado.Rows
                    Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If LineaMarca Then
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Venta").Value)
                        Dim TablaDatos As New eVentas
                        Dim Funcion As New fVentas
                        TablaDatos.pID_Ventas = LlavePrimaria
                        If Funcion.Eliminar(TablaDatos) Then
                            MessageBox.Show("Devolucion  fue Realizada correctamente",
                    "Eliminando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Cancelado por el Usuario",
                    "Guardando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information)
                        End If
                    End If
                Next
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Cancelado por el Usuario",
                    "Guardando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information)
        End If


        Call Mostrar()
        Call Limpiar()

    End Sub

    Private Sub Rd_tercera_no_CheckedChanged(sender As Object, e As EventArgs) Handles Rd_tercera_no.CheckedChanged
        Desc = "No"
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        Dim probarcant As Boolean = nuevo.comparar_enteros(Convert.ToInt32(Txtcantidad.Text),
                                                           Cb_producto.Text, "Pro_Cantidad", "Pro_Nombre", "Inventario")
        If probarcant = True Then

            If Txtcantidad.Text <> "" And TxtIdclli.Text <> "" And Txtpreciounidad.Text <> "" And
            Cb_producto.SelectedIndex >= 0 Then

                Dim Resultado1 As DialogResult
                Resultado1 = MessageBox.Show("Desea Modificar los datos",
                "Actualizando Registro", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question)
                If Resultado1 = Windows.Forms.DialogResult.OK Then
                    Try

                        Dim TablaDatos As New eInventario
                        Dim Funcion As New fInventario
                        Dim resta As Integer = Convert.ToInt32(ProdCant) - Convert.ToInt32(Txtcantidad.Text)

                        TablaDatos.pID_Producto = IDProd
                        TablaDatos.pPro_Nombre = Cb_producto.Text
                        TablaDatos.pPro_Cantidad = resta
                        TablaDatos.pPro_preventa = Convert.ToDouble(preventa)
                        TablaDatos.pPro_precompra = Convert.ToDouble(precompra)
                        TablaDatos.pNombre_Proveedor = proveed
                        TablaDatos.pPro_disponible = 1

                        If Funcion.Actualizar(TablaDatos) Then
                            MessageBox.Show("prueba de venta producto a inventario exito",
                         "Actualizando Registro", MessageBoxButtons.OK,
                          MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("prueba de venta producto a inventario fallo",
                         "Actualizando Registro", MessageBoxButtons.OK,
                          MessageBoxIcon.Information)
                        End If
                    Catch Evento As Exception
                        MsgBox(Evento.Message)
                    End Try
                Else
                    MessageBox.Show("Cancelado por el usuario",
                          "Guardando Registro", MessageBoxButtons.OK,
                           MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Falta Informacion para almacenar",
                          "Guardando Registro", MessageBoxButtons.OK,
                           MessageBoxIcon.Information)
            End If


            If Txtcantidad.Text <> "" And TxtIdclli.Text <> "" And Txtpreciounidad.Text <> "" And
                 Cb_producto.SelectedIndex >= 0 Then


                Try
                    Dim TablaDatos As New eVentas
                    Dim Funcion As New fVentas
                    TablaDatos.pID_Usuario = IniciarSesion.IDUSU
                    TablaDatos.pID_Cliente = TxtIdclli.Text
                    TablaDatos.pID_Producto = IDProd
                    TablaDatos.pVen_Fecha = Dtp_fecha.Text
                    TablaDatos.pVen_CantVendida = Txtcantidad.Text
                    TablaDatos.pVen_subtotal = Convert.ToInt32(Txtcantidad.Text) * Convert.ToInt32(Txtpreciounidad.Text)


                    If Funcion.Insertar(TablaDatos) Then
                        MessageBox.Show("Inventario fue registrado correctamente",
                "Guardando Registro", MessageBoxButtons.OK,
                 MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Inventario no fue registrado correctamente",
                "Guardando Registro", MessageBoxButtons.OK,
                 MessageBoxIcon.Error)
                    End If
                    Mostrar()
                    Limpiar()
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Else
                MessageBox.Show("Falta Informacion para almacenar",
                "Guardando Registro", MessageBoxButtons.OK,
                 MessageBoxIcon.Information)
            End If
        ElseIf probarcant = False Then
            MessageBox.Show("No tenemos es cantidad de productos",
                "Guardando Registro", MessageBoxButtons.OK,
                 MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Eliminar.CheckedChanged
        If Chk_Eliminar.CheckState = CheckState.Unchecked Then
            Dgv_Listado.Columns.Item("Eliminar").Visible = False
            Limpiar()

        Else
            Dgv_Listado.Columns.Item("Eliminar").Visible = True
            BtnDevolucion.Visible = True
            BtnIngresar.Visible = False
        End If
    End Sub
    Private Sub Dgv_Listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellContentClick
        If e.ColumnIndex = Me.Dgv_Listado.Columns.Item("Eliminar").Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgv_Listado.Rows(e.RowIndex).Cells("Eliminar")
            ChkCell.Value = Not ChkCell.Value
        End If
    End Sub


End Class