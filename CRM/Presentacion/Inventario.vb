﻿Public Class Inventario
    Private TablaDatos As New DataTable
    Public Bandera As New Boolean

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Bandera Then
            BtnRegresar.Visible = False
        Else
            BtnRegresar.Visible = True
        End If
        TxtIDProd.Enabled = False
        Mostrar()
        Limpiar()
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
            VistaDatos.RowFilter = TxtNomPro.Text
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
        TxtIDProd.Text = ""
        TxtCantPro.Text = ""
        TxtNomPro.Text = ""
        TxtNomProveedor.Text = ""
        TxtPrecioComp.Text = ""
        TxtPrecioVent.Text = ""

        BtnIngresar.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False

    End Sub

    Private Sub Dgv_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellClick
        TrasladoInformacion()
        If Bandera Then
            BtnModificar.Visible = False
        Else
            BtnModificar.Visible = True
        End If
        BtnIngresar.Visible = False
    End Sub

    Private Sub TrasladoInformacion()
        TxtIDProd.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtCantPro.Text = Dgv_Listado.SelectedCells.Item(3).Value
        TxtNomPro.Text = Dgv_Listado.SelectedCells.Item(2).Value
        TxtNomProveedor.Text = Dgv_Listado.SelectedCells.Item(6).Value
        TxtPrecioComp.Text = Dgv_Listado.SelectedCells.Item(5).Value
        TxtPrecioVent.Text = Dgv_Listado.SelectedCells.Item(4).Value
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Inicio.Visible = True
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtCantPro.Text <> "" And TxtNomPro.Text <> "" And TxtNomProveedor.Text <> "" And
            TxtPrecioComp.Text <> "" And TxtPrecioVent.Text <> "" Then

            Try
                Dim TablaDatos As New eInventario
                Dim Funcion As New fInventario
                TablaDatos.pPro_Nombre = TxtNomPro.Text
                TablaDatos.pPro_Cantidad = TxtCantPro.Text
                TablaDatos.pPro_preventa = TxtPrecioVent.Text
                TablaDatos.pPro_precompra = TxtPrecioComp.Text
                TablaDatos.pNombre_Proveedor = TxtNomProveedor.Text

                TablaDatos.pPro_disponible = 1


                'El uno es para el entero de disponibilidad (1/si  0/no) '


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
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)
        Buscar()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If TxtCantPro.Text <> "" And TxtNomPro.Text <> "" And TxtNomProveedor.Text <> "" And
            TxtPrecioComp.Text <> "" And TxtPrecioVent.Text <> "" Then

            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Desea Modificar los datos",
            "Actualizando Registro", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question)
            If Resultado = Windows.Forms.DialogResult.OK Then
                Try

                    Dim TablaDatos As New eInventario
                    Dim Funcion As New fInventario
                    TablaDatos.pID_Producto = TxtIDProd.Text
                    TablaDatos.pPro_Nombre = TxtNomPro.Text
                    TablaDatos.pPro_Cantidad = TxtCantPro.Text
                    TablaDatos.pPro_preventa = TxtPrecioVent.Text
                    TablaDatos.pPro_precompra = TxtPrecioComp.Text
                    TablaDatos.pNombre_Proveedor = TxtNomProveedor.Text

                    TablaDatos.pPro_disponible = 1

                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("Producto fue actualizado correctamente",
                     "Actualizando Registro", MessageBoxButtons.OK,
                      MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Producto no fue actualizado correctamente",
                     "Actualizando Registro", MessageBoxButtons.OK,
                      MessageBoxIcon.Information)
                    End If
                    Mostrar()
                    Limpiar()
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Else
                MessageBox.Show("Cancelado por el Producto",
                      "Guardando Registro", MessageBoxButtons.OK,
                       MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar",
                      "Guardando Registro", MessageBoxButtons.OK,
                       MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Desea Eliminar el producto",
        "Eliminando Registro", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question)
        If Resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Dgv_Listado.Rows
                    Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If LineaMarca Then
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Producto").Value)
                        Dim TablaDatos As New eInventario
                        Dim Funcion As New fInventario
                        TablaDatos.pID_Producto = LlavePrimaria
                        If Funcion.Eliminar(TablaDatos) Then
                            MessageBox.Show("Producto fue eliminado correctamente",
                    "Eliminando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Cancelado por el Usuario",
                    "Guardando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call Mostrar()
                Call Limpiar()
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Cancelado por el Usuario",
                    "Guardando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information)
            Call Mostrar()
            Call Limpiar()
        End If
    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Eliminar.CheckedChanged
        If Chk_Eliminar.CheckState = CheckState.Unchecked Then
            Dgv_Listado.Columns.Item("Eliminar").Visible = False
            Limpiar()

        Else
            Dgv_Listado.Columns.Item("Eliminar").Visible = True
            BtnEliminar.Visible = True
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