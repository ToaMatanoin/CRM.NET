Public Class Ventas

    Public nuevo As New Conexion
    Private TablaDatos As New DataTable
    Public Bandera As New Boolean


    Public random As Integer

    Public ProdCant, preventa, precompra, proveed, rtncli As String

    Public subtotal, total As Double
    Public Tventa, Desc, IDProd As String

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Bandera Then
            BtnRegresar.Visible = False
        Else
            BtnRegresar.Visible = True
        End If
        'bloqueo al iniciar la ventana
        desactivar()

        Mostrar()

        nuevo.ConexionDB()
        nuevo.llenado_cb(Cb_producto, "Pro_Nombre", "Inventario")
        nuevo.llenado_cb(CB_Cliente, "Cli_NombreEmpresa", "Cliente")

        Limpiar()

        random = CInt((100000 - 1) * Rnd() + 1)

        Dim comprobar As Boolean = nuevo.Existencia(Convert.ToString(random), "Num_venta", "Ventas")

        Do While comprobar = True
            random = CInt((100000 - 1) * Rnd() + 1)
            comprobar = nuevo.Existencia(Convert.ToString(random), "Num_venta", "Ventas")
        Loop
        Lb_IDFactura.Text = "Numero Venta # " + Convert.ToString(random)

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
            VistaDatos.RowFilter = "Num_venta = '" & random & "'"
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
        Dgv_Listado.Columns(2).Visible = False
        Dgv_Listado.Columns(6).Visible = False
        Dgv_Listado.Columns(4).Visible = False

    End Sub

    Private Sub Limpiar()
        Txtcantidad.Text = ""
        Txtpreciounidad.Text = ""
        TxtImpuesto.Text = ""
        TxtDescuento.Text = ""
        TxtSubTotal.Text = ""
        TxtTotal.Text = ""

        Cb_producto.Text = ""
        CB_Cliente.Text = ""

        Rd_contado.Checked = False
        Rd_credito.Checked = False
        Rd_tercera_no.Checked = False
        Rd_tercera_si.Checked = False

        Chk_Eliminar.Checked = False

        Btn_NuevaVenta.Visible = True
        BtnIngresar.Visible = False
        BtnDevolucion.Visible = False



    End Sub

    Private Sub Limpiar2()
        Txtcantidad.Text = ""
        Txtpreciounidad.Text = ""

        Cb_producto.Text = ""

        Chk_Eliminar.Checked = False

        Btn_NuevaVenta.Visible = True
        BtnIngresar.Visible = False
        BtnDevolucion.Visible = False
    End Sub

    Private Sub Activar()
        Rd_contado.Enabled = True
        Rd_credito.Enabled = True
        Rd_tercera_no.Enabled = True
        Rd_tercera_si.Enabled = True
        Cb_producto.Enabled = True
        CB_Cliente.Enabled = True
        Txtcantidad.Enabled = True
    End Sub

    Private Sub desactivar()
        Rd_contado.Enabled = False
        Rd_credito.Enabled = False
        Rd_tercera_no.Enabled = False
        Rd_tercera_si.Enabled = False
        Cb_producto.Enabled = False
        CB_Cliente.Enabled = False
        Txtcantidad.Enabled = False
    End Sub

    Private Sub TrasladoInformacion()
        Txt_ID_Venta.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtIdclli.Text = Dgv_Listado.SelectedCells.Item(4).Value
        nuevo.ConexionDB()
        CB_Cliente.Text = nuevo.Buscar_info(TxtIdclli.Text, "ID_Cliente", "Cli_NombreEmpresa", "Cliente")
        Txtcantidad.Text = Dgv_Listado.SelectedCells.Item(9).Value
        Cb_producto.Text = Dgv_Listado.SelectedCells.Item(7).Value
        nuevo.ConexionDB()

    End Sub

    Private Sub Dgv_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellClick
        TrasladoInformacion()
        'If Bandera Then
        '    BtnDevolucion.Visible = False
        'Else
        '    BtnDevolucion.Visible = True
        'End If
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
        precompra = nuevo.Buscar_info(Cb_producto.Text, "Pro_Nombre", "Pro_PreFabricacion", "Inventario")
        proveed = nuevo.Buscar_info(Cb_producto.Text, "Pro_Nombre", "Nombre_Compuesto", "Inventario")

        IDProd = nuevo.Buscar_info(Cb_producto.Text, "Pro_Nombre", "ID_Producto", "Inventario")

        Txt_Cantmaxima.Text = nuevo.Buscar_info(Cb_producto.Text, "Pro_Nombre", "Pro_Cantidad", "Inventario")
        Txtpreciounidad.Text = nuevo.Buscar_info(Cb_producto.Text, "Pro_Nombre", "Pro_PreVenta", "Inventario")
    End Sub

    'Private Sub Rd_credito_CheckedChanged(sender As Object, e As EventArgs) Handles Rd_credito.CheckedChanged

    'End Sub

    'Private Sub Rd_contado_CheckedChanged(sender As Object, e As EventArgs) Handles Rd_contado.CheckedChanged

    'End Sub

    'Private Sub Rd_tercera_si_CheckedChanged(sender As Object, e As EventArgs)

    'End Sub

    Private Sub Btn_nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        nuevo.ConexionDB()

        rtncli = nuevo.Buscar_info(TxtIdclli.Text, "ID_Cliente", "RTN", "Cliente")

        Try
            Dim TablaDatos As New eFactura
            Dim Funcion As New fFactura
            Dim descuentos, impuestos As Double

            TablaDatos.pID_Venta = Txt_ID_Venta.Text

            If Rd_credito.Checked Then
                TablaDatos.pTP_Venta = "credito"
            ElseIf Rd_contado.Checked Then
                TablaDatos.pTP_Venta = "contado"
            End If

            TablaDatos.pFac_Descuento = TxtDescuento.Text

            TablaDatos.pFac_Impuesto = TxtImpuesto.Text


            TablaDatos.pFac_RTN = rtncli

            TablaDatos.pFac_Total = TxtTotal.Text
            TablaDatos.pNum_venta = random

            random = CInt((100000 - 1) * Rnd() + 1)
            Dim comprobar As Boolean = nuevo.Existencia(Convert.ToString(random), "ID_Venta", "Ventas")

            Do While comprobar = True
                random = CInt((100000 - 1) * Rnd() + 1)
                comprobar = nuevo.Existencia(Convert.ToString(random), "ID_Venta", "Ventas")
            Loop
            Lb_IDFactura.Text = "ID Venta # " + Convert.ToString(random)

            If Funcion.Insertar(TablaDatos) Then
            Else
                MessageBox.Show("factura no fue registrado correctamente", "Guardado Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try

        Dgv_Listado.DataSource = Nothing
        Call Limpiar()
        Btn_Limpiar.Visible = False
    End Sub

    Private Sub BtnMinimizate_Click(sender As Object, e As EventArgs) Handles BtnMinimizate.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btnfactura_Click(sender As Object, e As EventArgs) Handles Btnfactura.Click
        Facturas.ShowDialog()
    End Sub

    Private Sub CB_Cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Cliente.SelectedIndexChanged
        nuevo.ConexionDB()
        TxtIdclli.Text = nuevo.Buscar_info(CB_Cliente.Text, "Cli_NombreEmpresa", "ID_Cliente", "Cliente")
    End Sub

    Private Sub Btn_NuevaVenta_Click(sender As Object, e As EventArgs) Handles Btn_NuevaVenta.Click
        Activar()
        Call Limpiar2()
        BtnIngresar.Visible = True
        Btn_Limpiar.Visible = True
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnDevolucion.Click
        'devolver inventario

        Dim Resultad As DialogResult
        Resultad = MessageBox.Show("Desea Devolver una compra", "Devolucion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If Resultad = Windows.Forms.DialogResult.OK Then
            Try

                Dim TablaDatos As New eInventario
                Dim Funcion As New fInventario
                Dim Suma As Integer = Convert.ToInt32(ProdCant) + Convert.ToInt32(Txtcantidad.Text)

                TablaDatos.pID_Producto = IDProd
                TablaDatos.pPro_Nombre = Cb_producto.Text
                TablaDatos.pPro_Cantidad = Suma
                TablaDatos.pPro_preventa = Convert.ToDouble(preventa)
                TablaDatos.pPro_precompra = Convert.ToDouble(precompra)
                TablaDatos.pNombre_Proveedor = proveed
                TablaDatos.pPro_disponible = 1

                If Funcion.Actualizar(TablaDatos) Then
                    MessageBox.Show("Producto Restado del inventario", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Fallo La resta de inventario", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Try
                    For Each row As DataGridViewRow In Dgv_Listado.Rows
                        Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                        If LineaMarca Then
                            Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Venta").Value)
                            Dim TablaDatos2 As New eVentas
                            Dim Funcion2 As New fVentas
                            TablaDatos2.pID_Venta = LlavePrimaria
                            If Funcion2.Eliminar(TablaDatos2) Then
                                MessageBox.Show("Estrategia fue eliminado correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Next
                    Call Mostrar()
                    Call Limpiar()
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Cancelado por el usuario", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        'eliminar venta
        'Dim Resultado As DialogResult
        'Resultado = MessageBox.Show("Desea Eliminar la Estrategia",
        '"Eliminando Registro", MessageBoxButtons.OKCancel,
        'MessageBoxIcon.Question)
        'If Resultado = Windows.Forms.DialogResult.OK Then

        'Else
        '    MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Call Mostrar()
        '    Call Limpiar()
        'End If




    End Sub

    Private Sub Rd_tercera_no_CheckedChanged(sender As Object, e As EventArgs)
        Desc = "No"
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click


        If Txtcantidad.Text <> "" And TxtIdclli.Text <> "" And Txtpreciounidad.Text <> "" And
            Cb_producto.SelectedIndex >= 0 Then

            Dim probarcant As Boolean = nuevo.comparar_enteros(Convert.ToInt32(Txtcantidad.Text), Cb_producto.Text, "Pro_Cantidad", "Pro_Nombre", "Inventario")
            If probarcant = True Then


                'Registra la venta

                Try
                        Dim TablaDatos As New eVentas
                        Dim Funcion As New fVentas
                        TablaDatos.pID_Usuario = IniciarSesion.IDUSU
                        TablaDatos.pID_Cliente = TxtIdclli.Text
                        TablaDatos.pID_Producto = IDProd
                        TablaDatos.pVen_Fecha = Dtp_fecha.Text
                        TablaDatos.pVen_CantVendida = Txtcantidad.Text
                        TablaDatos.pVen_subtotal = Convert.ToInt32(Txtcantidad.Text) * Convert.ToInt32(Txtpreciounidad.Text)
                        TablaDatos.pNum_venta = random

                        If Funcion.Insertar(TablaDatos) Then
                            MessageBox.Show("Venta registrada", "Guardado Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Venta no fue registrado correctamente", "Guardado Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    'restar inventario

                    Try

                        Dim TablaDatos2 As New eInventario
                        Dim Funcion2 As New fInventario
                        Dim resta As Integer = Convert.ToInt32(ProdCant) - Convert.ToInt32(Txtcantidad.Text)

                        TablaDatos2.pID_Producto = IDProd
                        TablaDatos2.pPro_Nombre = Cb_producto.Text
                        TablaDatos2.pPro_Cantidad = resta
                        TablaDatos2.pPro_preventa = Convert.ToDouble(preventa)
                        TablaDatos2.pPro_precompra = Convert.ToDouble(precompra)
                        TablaDatos2.pNombre_Proveedor = proveed
                        TablaDatos2.pPro_disponible = 1

                        If Funcion2.Actualizar(TablaDatos2) Then
                        Else
                            MessageBox.Show("Fallo La resta de inventario", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Catch Evento As Exception
                        MsgBox(Evento.Message)
                    End Try

                    Dim descuentos, impuestos As Double


                        subtotal = subtotal + (Txtcantidad.Text * Txtpreciounidad.Text)

                        TxtSubTotal.Text = subtotal

                        impuestos = (subtotal * 0.15)
                        TxtImpuesto.Text = impuestos

                        If Rd_tercera_si.Checked Then

                            descuentos = (subtotal * 0.085)
                            TxtDescuento.Text = descuentos
                        Else
                            descuentos = 0
                            TxtDescuento.Text = descuentos
                        End If

                        total = subtotal + impuestos - descuentos
                        TxtTotal.Text = total

                    Catch Evento As Exception
                        MsgBox(Evento.Message)
                    End Try




            ElseIf probarcant = False Then
                MessageBox.Show("No tenemos esa cantidad de unidades de producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If






        Call Limpiar2()
        Mostrar()
    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Eliminar.CheckedChanged
        If Chk_Eliminar.CheckState = CheckState.Unchecked Then
            Dgv_Listado.Columns.Item("Eliminar").Visible = False
            Limpiar2()
        Else
            Dgv_Listado.Columns.Item("Eliminar").Visible = True
            BtnDevolucion.Visible = True
            BtnIngresar.Visible = False
            Btn_NuevaVenta.Visible = False
            Activar()
        End If
    End Sub
    Private Sub Dgv_Listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellContentClick
        If e.ColumnIndex = Me.Dgv_Listado.Columns.Item("Eliminar").Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgv_Listado.Rows(e.RowIndex).Cells("Eliminar")
            ChkCell.Value = Not ChkCell.Value
            Activar()
        End If
    End Sub

    Private Sub Txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcantidad.KeyPress
        nuevo.RestringirNumero(e)
    End Sub

End Class