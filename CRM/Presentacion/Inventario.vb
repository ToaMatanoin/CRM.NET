Public Class Inventario

    Private TablaDatos As New DataTable
    Public Restriccion As New Conexion

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Buscar.Items.Add("Pro_Nombre")
        Cmb_Buscar.Items.Add("Nombre_Compuesto")
        Cmb_Buscar.Text = "Pro_Nombre"

        Mostrar()
        Limpiar()
        BtnIngresar.Enabled = False
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
            VistaDatos.RowFilter = Cmb_Buscar.Text & " like '" & Txt_Buscar.Text & "%'"
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
        Dgv_Listado.Columns(7).Visible = False
    End Sub

    Private Sub Activar()
        TxtCantPro.Enabled = True
        TxtNomPro.Enabled = True
        TxtNomProveedor.Enabled = True
        TxtPrecioComp.Enabled = True
        TxtPrecioVent.Enabled = True
    End Sub

    Private Sub Desactivar()
        TxtCantPro.Enabled = False
        TxtNomPro.Enabled = False
        TxtNomProveedor.Enabled = False
        TxtPrecioComp.Enabled = False
        TxtPrecioVent.Enabled = False
    End Sub

    Private Sub Limpiar()
        TxtIDProd.Text = ""
        TxtCantPro.Text = ""
        TxtNomPro.Text = ""
        TxtNomProveedor.Text = ""
        TxtPrecioComp.Text = ""
        TxtPrecioVent.Text = ""

        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        BtnNuevo.Enabled = True
    End Sub

    Private Sub Dgv_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellClick
        TrasladoInformacion()
        BtnModificar.Enabled = False
        If Chk_Eliminar.Checked Then
                'no mostrar modificar con el chek eliminar activo'
            Else
                BtnModificar.Enabled = True
                Activar()
            End If

        BtnIngresar.Enabled = False
    End Sub

    Private Sub TrasladoInformacion()
        TxtIDProd.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtCantPro.Text = Dgv_Listado.SelectedCells.Item(3).Value
        TxtNomPro.Text = Dgv_Listado.SelectedCells.Item(2).Value
        TxtNomProveedor.Text = Dgv_Listado.SelectedCells.Item(6).Value
        TxtPrecioComp.Text = Dgv_Listado.SelectedCells.Item(5).Value
        TxtPrecioVent.Text = Dgv_Listado.SelectedCells.Item(4).Value
    End Sub


    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtCantPro.Text <> "" And TxtNomPro.Text <> "" And TxtNomProveedor.Text <> "" And TxtPrecioComp.Text <> "" And TxtPrecioVent.Text <> "" Then

            Restriccion.ConexionDB()
            Dim comprobar As Boolean = Restriccion.ExistenciaTxt(TxtNomPro.Text, "Pro_Nombre", "Inventario")
            If comprobar = True Then
                MessageBox.Show("Nombre de producto ya existe", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
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
                        MessageBox.Show("Inventario fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Inventario no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Mostrar()
                    Limpiar()
                    Desactivar()
                    BtnIngresar.Enabled = False
                    BtnNuevo.Text = "Nuevo Producto"
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If TxtCantPro.Text <> "" And TxtNomPro.Text <> "" And TxtNomProveedor.Text <> "" And TxtPrecioComp.Text <> "" And TxtPrecioVent.Text <> "" Then

            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Desea Modificar los datos", "Actualizando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
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
                        MessageBox.Show("Producto fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Producto no fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Mostrar()
                    Limpiar()
                    Desactivar()
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Else
                MessageBox.Show("Cancelado por el Producto", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Desea Eliminar el producto", "Eliminando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If Resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Dgv_Listado.Rows
                    Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If LineaMarca Then
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Producto").Value)
                        Dim TablaDatos As New eInventario
                        Dim Funcion As New fInventario
                        TablaDatos.pID_Producto = LlavePrimaria

                        Restriccion.ConexionDB()
                        Dim IDM, IDV As String
                        IDM = Restriccion.Buscar_info(LlavePrimaria, "ID_Producto", "ID_Marketing", "Marketing")
                        IDV = Restriccion.Buscar_info(LlavePrimaria, "ID_Producto", "ID_Venta", "Ventas")
                        If IDM <> "" Or IDV <> "" Then
                            If IDM <> "" And IDV <> "" Then
                                MessageBox.Show("ERROR, No se puede Eliminar PRODUCTO porque sus datos estan siendo utilizadas en MARKETING y VENTAS",
                                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ElseIf IDV <> "" Then
                                MessageBox.Show("ERROR, No se puede Eliminar PRODUCTO porque sus datos estan siendo utilizadas en VENTAS",
                                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ElseIf IDM <> "" Then
                                MessageBox.Show("ERROR, No se puede Eliminar PRODUCTO porque sus datos estan siendo utilizadas en MARKETING",
                                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            If Funcion.Eliminar(TablaDatos) Then
                                MessageBox.Show("Producto fue eliminado correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Else
                                MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                        Chk_Eliminar.Checked = False
                    End If
                Next
                Call Mostrar()
                Call Limpiar()
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Mostrar()
            Call Limpiar()
        End If

        'eliminar de marketing

    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Eliminar.CheckedChanged
        Desactivar()

        If Chk_Eliminar.CheckState = CheckState.Unchecked Then
            Dgv_Listado.Columns.Item("Eliminar").Visible = False
            Limpiar()
        Else
            Dgv_Listado.Columns.Item("Eliminar").Visible = True
            BtnEliminar.Enabled = True
            BtnNuevo.Enabled = False
            BtnModificar.Enabled = False
        End If
    End Sub
    Private Sub Dgv_Listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellContentClick
        If e.ColumnIndex = Me.Dgv_Listado.Columns.Item("Eliminar").Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgv_Listado.Rows(e.RowIndex).Cells("Eliminar")
            ChkCell.Value = Not ChkCell.Value
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If BtnNuevo.Text = "Nuevo Producto" Then
            Activar()
            BtnIngresar.Enabled = True
            BtnNuevo.Text = "Cancelar"
            Limpiar()
        ElseIf BtnNuevo.Text = "Cancelar" Then
            Desactivar()
            BtnIngresar.Enabled = False
            Limpiar()
            BtnNuevo.Text = "Nuevo Producto"
        End If
    End Sub

    Private Sub TxtNomPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNomPro.KeyPress
        Restriccion.RestringirLetras(e)
    End Sub
    Private Sub TxtCantPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantPro.KeyPress
        Restriccion.RestringirNumero(e)
    End Sub
    Private Sub TxtPrecioComp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecioComp.KeyPress
        Restriccion.RestringirNumero(e)
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub
    Private Sub TxtPrecioVent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecioVent.KeyPress
        Restriccion.RestringirNumero(e)
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub
    Private Sub TxtNomProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNomProveedor.KeyPress
        Restriccion.RestringirLetras(e)
    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        Buscar()
    End Sub
End Class