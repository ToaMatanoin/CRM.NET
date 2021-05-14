Public Class Clientes
    Private TablaDatos As New DataTable
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        TxtIDCliente.Enabled = False

    End Sub

    Private Sub Mostrar()
        Try
            Dim Funcion As New fClientes
            TablaDatos = Funcion.Mostrar
            If TablaDatos.Rows.Count <> 0 Then
                DataGridView1.DataSource = TablaDatos
                DataGridView1.ColumnHeadersVisible = True
            Else
                DataGridView1.DataSource = Nothing
                DataGridView1.ColumnHeadersVisible = False
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        TxtIDCliente.Text = ""
        TxtNomCli.Text = ""
        TxtTelCli.Text = ""
        TxtEmailCli.Text = ""
        TxtNomEmpresa.Text = ""
        TxtTelEmpresa.Text = ""
        TxtEmailEmpresa.Text = ""
        TxtRTN.Text = ""
    End Sub

    'Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    '  TrasladoInformacion()
    'End Sub
    ' Private Sub TrasladoInformacion()
    '   TxtIDCliente.Text = DataGridView1.SelectedCells.Item(0).Value
    '  TxtNomCli.Text = DataGridView1.SelectedCells.Item(1).Value
    ' TxtTelCli.Text = DataGridView1.SelectedCells.Item(2).Value
    'TxtEmailCli.Text = DataGridView1.SelectedCells.Item(3).Value
    'TxtNomEmpresa.Text = DataGridView1.SelectedCells.Item(4).Value
    'TxtTelEmpresa.Text = DataGridView1.SelectedCells.Item(5).Value
    'TxtEmailEmpresa.Text = DataGridView1.SelectedCells.Item(6).Value
    'TxtRTN.Text = DataGridView1.SelectedCells.Item(7).Value

    'End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtNomCli.Text <> "" And TxtTelCli.Text <> "" And TxtEmailCli.Text <> "" And
            TxtNomEmpresa.Text <> "" And TxtTelEmpresa.Text <> "" And TxtEmailEmpresa.Text <> "" And
            TxtRTN.Text <> "" Then
            Try
                Dim TablaDatos As New eClientes
                Dim Funcion As New fClientes
                TablaDatos.pCli_Nombre = TxtNomCli.Text
                TablaDatos.pCli_Telefono = TxtTelCli.Text
                TablaDatos.pCli_Email = TxtEmailCli.Text
                TablaDatos.pCli_NombreEmpresa = TxtNomEmpresa.Text
                TablaDatos.pCli_TelEmpresa = TxtTelEmpresa.Text
                TablaDatos.pCli_EmailEmpresa = TxtEmailEmpresa.Text
                TablaDatos.pRTN = TxtRTN.Text

                If Funcion.Insertar(TablaDatos) Then
                    MessageBox.Show("Cliente fue registrado correctamente",
            "Guardando Registro", MessageBoxButtons.OK,
             MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cliente no fue registrado correctamente",
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


    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Inicio.Visible = True
        Me.Close()
    End Sub



End Class