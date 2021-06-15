<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Debolucion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Debolucion))
        Me.Dgv_Listado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnDevolucion = New System.Windows.Forms.Button()
        Me.DGVVentas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvproductos = New System.Windows.Forms.DataGridView()
        Me.ID_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pro_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pro_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pro_PreVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pro_PreCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pro_Disponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Listado
        '
        Me.Dgv_Listado.AllowUserToAddRows = False
        Me.Dgv_Listado.AllowUserToDeleteRows = False
        Me.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.Dgv_Listado.Enabled = False
        Me.Dgv_Listado.Location = New System.Drawing.Point(12, 69)
        Me.Dgv_Listado.Name = "Dgv_Listado"
        Me.Dgv_Listado.ReadOnly = True
        Me.Dgv_Listado.RowHeadersWidth = 51
        Me.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Listado.Size = New System.Drawing.Size(978, 369)
        Me.Dgv_Listado.TabIndex = 14
        Me.Dgv_Listado.Visible = False
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 125
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnRegresar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(867, 12)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(123, 51)
        Me.BtnRegresar.TabIndex = 15
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnDevolucion
        '
        Me.BtnDevolucion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnDevolucion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDevolucion.Location = New System.Drawing.Point(738, 12)
        Me.BtnDevolucion.Name = "BtnDevolucion"
        Me.BtnDevolucion.Size = New System.Drawing.Size(123, 51)
        Me.BtnDevolucion.TabIndex = 16
        Me.BtnDevolucion.Text = "Devolver"
        Me.BtnDevolucion.UseVisualStyleBackColor = True
        '
        'DGVVentas
        '
        Me.DGVVentas.AllowUserToAddRows = False
        Me.DGVVentas.AllowUserToDeleteRows = False
        Me.DGVVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        Me.DGVVentas.Enabled = False
        Me.DGVVentas.Location = New System.Drawing.Point(12, 12)
        Me.DGVVentas.Name = "DGVVentas"
        Me.DGVVentas.ReadOnly = True
        Me.DGVVentas.RowHeadersWidth = 51
        Me.DGVVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVVentas.Size = New System.Drawing.Size(696, 41)
        Me.DGVVentas.TabIndex = 17
        Me.DGVVentas.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Eliminar"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'dgvproductos
        '
        Me.dgvproductos.AllowUserToAddRows = False
        Me.dgvproductos.AllowUserToDeleteRows = False
        Me.dgvproductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Producto, Me.Pro_Nombre, Me.Pro_Cantidad, Me.Pro_PreVenta, Me.Pro_PreCompra, Me.Nombre_Proveedor, Me.Pro_Disponible})
        Me.dgvproductos.Location = New System.Drawing.Point(12, 219)
        Me.dgvproductos.Name = "dgvproductos"
        Me.dgvproductos.ReadOnly = True
        Me.dgvproductos.RowHeadersWidth = 51
        Me.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvproductos.Size = New System.Drawing.Size(978, 219)
        Me.dgvproductos.TabIndex = 18
        '
        'ID_Producto
        '
        Me.ID_Producto.HeaderText = "ID_Producto"
        Me.ID_Producto.Name = "ID_Producto"
        Me.ID_Producto.ReadOnly = True
        '
        'Pro_Nombre
        '
        Me.Pro_Nombre.HeaderText = "Pro_Nombre"
        Me.Pro_Nombre.Name = "Pro_Nombre"
        Me.Pro_Nombre.ReadOnly = True
        '
        'Pro_Cantidad
        '
        Me.Pro_Cantidad.HeaderText = "Pro_Cantidad"
        Me.Pro_Cantidad.Name = "Pro_Cantidad"
        Me.Pro_Cantidad.ReadOnly = True
        '
        'Pro_PreVenta
        '
        Me.Pro_PreVenta.HeaderText = "Pro_PreVenta"
        Me.Pro_PreVenta.Name = "Pro_PreVenta"
        Me.Pro_PreVenta.ReadOnly = True
        '
        'Pro_PreCompra
        '
        Me.Pro_PreCompra.HeaderText = "Pro_PreCompra"
        Me.Pro_PreCompra.Name = "Pro_PreCompra"
        Me.Pro_PreCompra.ReadOnly = True
        '
        'Nombre_Proveedor
        '
        Me.Nombre_Proveedor.HeaderText = "Nombre_Proveedor"
        Me.Nombre_Proveedor.Name = "Nombre_Proveedor"
        Me.Nombre_Proveedor.ReadOnly = True
        '
        'Pro_Disponible
        '
        Me.Pro_Disponible.HeaderText = "Pro_Disponible"
        Me.Pro_Disponible.Name = "Pro_Disponible"
        Me.Pro_Disponible.ReadOnly = True
        '
        'Debolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1004, 450)
        Me.Controls.Add(Me.dgvproductos)
        Me.Controls.Add(Me.DGVVentas)
        Me.Controls.Add(Me.BtnDevolucion)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Dgv_Listado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Debolucion"
        Me.Text = "Devolucion"
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Dgv_Listado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnDevolucion As Button
    Friend WithEvents DGVVentas As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents dgvproductos As DataGridView
    Friend WithEvents ID_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Pro_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Pro_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Pro_PreVenta As DataGridViewTextBoxColumn
    Friend WithEvents Pro_PreCompra As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Pro_Disponible As DataGridViewTextBoxColumn
End Class
