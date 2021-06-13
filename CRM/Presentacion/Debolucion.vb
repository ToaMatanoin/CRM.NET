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
            VistaDatos.RowFilter = "Num_venta = '" & idventa & "'"
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


    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
        Ventas.Show()
    End Sub

End Class