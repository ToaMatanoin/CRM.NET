Public Class Debolucion

    Public nuevo As New Conexion
    Private TablaDatos As New DataTable
    Public idventa As New Integer
    Dim productos(1), ventacant(1) As String

    Private Sub Debolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarV()
        Mostrar()
        recoger_id()
    End Sub

    Private Sub MostrarV()
        Try
            Dim Funcion As New fVentas
            TablaDatos = Funcion.Mostrar
            DGVVentas.Columns.Item("eliminar").Visible = False
            If TablaDatos.Rows.Count <> 0 Then
                DGVVentas.DataSource = TablaDatos
                DGVVentas.ColumnHeadersVisible = True
            Else
                DGVVentas.DataSource = Nothing
                DGVVentas.ColumnHeadersVisible = False
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
        BuscarV()

    End Sub

    Private Sub BuscarV()
        Try
            Dim ConjuntoDatos As New DataSet
            ConjuntoDatos.Tables.Add(TablaDatos.Copy)
            Dim VistaDatos As New DataView(ConjuntoDatos.Tables(0))
            VistaDatos.RowFilter = "ID_Venta = '" & idventa & "'"
            If VistaDatos.Count <> 0 Then
                DGVVentas.DataSource = VistaDatos
            Else
                DGVVentas.DataSource = Nothing
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            Dim Funcion As New fInventario
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
        filtrar()
    End Sub

    Private Sub filtrar()
        Dim k As Integer = 1
        For i = 0 To Dgv_Listado.Rows.Count Step 1
            For j = 0 To DGVVentas.Rows.Count Step 1
                If Dgv_Listado.Item(1, (i + 1)).Equals(productos(j)) Then
                    dgvproductos(1, k).Value = Dgv_Listado(1, (i + 1)).Value
                    dgvproductos(2, k).Value = Dgv_Listado(2, (i + 1)).Value
                    dgvproductos(3, k).Value = Dgv_Listado(3, (i + 1)).Value
                    dgvproductos(4, k).Value = Dgv_Listado(4, (i + 1)).Value
                    dgvproductos(5, k).Value = Dgv_Listado(5, (i + 1)).Value
                    dgvproductos(6, k).Value = Dgv_Listado(6, (i + 1)).Value
                    dgvproductos(7, k).Value = Dgv_Listado(7, (i + 1)).Value
                    k = k + 1
                End If
            Next j
        Next i
    End Sub

    Private Sub OcultarColumna()
        Dgv_Listado.Columns(1).Visible = False
        Dgv_Listado.Columns(7).Visible = False
    End Sub

    Private Sub recoger_id()
        ReDim productos(DGVVentas.Rows.Count)
        ReDim ventacant(DGVVentas.Rows.Count)
        For i = 0 To DGVVentas.Rows.Count Step 1
            productos(i) = DGVVentas.Item(6, (i + 1)).Value.ToString
            ventacant(i) = DGVVentas.Item(9, (i + 1)).Value.ToString
        Next i
    End Sub

    Private Sub BtnDevolucion_Click(sender As Object, e As EventArgs) Handles BtnDevolucion.Click

        'devolver inventario

        Dim Resultad As DialogResult
        Resultad = MessageBox.Show("Desea Devolver una compra", "Devolucion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If Resultad = Windows.Forms.DialogResult.OK Then
            Try

                Dim TablaDatos As New eInventario
                Dim Funcion As New fInventario
                For i = 1 To dgvproductos.Rows.Count Step 1
                    For j = 1 To DGVVentas.Rows.Count Step 1
                        If productos(j).Equals(dgvproductos(1, i).Value) Then
                            Dim suma As Integer = Convert.ToInt32(ventacant(j)) + Convert.ToInt32(dgvproductos(3, i).Value)

                            TablaDatos.pID_Producto = dgvproductos(1, i).Value
                            TablaDatos.pPro_Nombre = dgvproductos(2, i).Value
                            TablaDatos.pPro_Cantidad = suma
                            TablaDatos.pPro_preventa = Convert.ToDouble(dgvproductos(4, i).Value)
                            TablaDatos.pPro_precompra = Convert.ToDouble(dgvproductos(5, i).Value)
                            TablaDatos.pNombre_Proveedor = dgvproductos(6, i).Value
                            TablaDatos.pPro_disponible = dgvproductos(7, i).Value
                        End If
                    Next j
                Next i

                If Funcion.Actualizar(TablaDatos) Then
                    MessageBox.Show("prueba de devolver producto a inventario exito", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("prueba de devolver producto a inventario fallo", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Cancelado por el usuario", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        'eliminar venta
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Desea hacer una devolucion", "Eliminando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If Resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Dgv_Listado.Rows
                    Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If LineaMarca Then
                        Dim LlavePrimaria As Integer = idventa
                        Dim TablaDatos As New eVentas
                        Dim Funcion As New fVentas
                        TablaDatos.pID_Ventas = LlavePrimaria
                        If Funcion.Eliminar(TablaDatos) Then
                            MessageBox.Show("Devolucion  fue Realizada correctamente", "Devolucion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Cancelado por el Usuario", "Devolucion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Cancelado por el Usuario", "Devolucion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
        Ventas.Show()
    End Sub

End Class