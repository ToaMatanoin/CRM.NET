<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_Cantmaxima = New System.Windows.Forms.TextBox()
        Me.Cb_producto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtpreciounidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lb_IDFactura = New System.Windows.Forms.Label()
        Me.Dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdclli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Btn_NuevaVenta = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_ID_Venta = New System.Windows.Forms.TextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnDevolucion = New System.Windows.Forms.Button()
        Me.Chk_Eliminar = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Rd_contado = New System.Windows.Forms.RadioButton()
        Me.Rd_credito = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Rd_tercera_no = New System.Windows.Forms.RadioButton()
        Me.Rd_tercera_si = New System.Windows.Forms.RadioButton()
        Me.Dgv_Listado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Txt_Cantmaxima)
        Me.GroupBox4.Controls.Add(Me.Cb_producto)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Txtcantidad)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Txtpreciounidad)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(943, 107)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(373, 130)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Información Compra"
        '
        'Txt_Cantmaxima
        '
        Me.Txt_Cantmaxima.Enabled = False
        Me.Txt_Cantmaxima.Location = New System.Drawing.Point(314, 59)
        Me.Txt_Cantmaxima.Name = "Txt_Cantmaxima"
        Me.Txt_Cantmaxima.Size = New System.Drawing.Size(44, 26)
        Me.Txt_Cantmaxima.TabIndex = 8
        '
        'Cb_producto
        '
        Me.Cb_producto.FormattingEnabled = True
        Me.Cb_producto.Location = New System.Drawing.Point(132, 25)
        Me.Cb_producto.Name = "Cb_producto"
        Me.Cb_producto.Size = New System.Drawing.Size(226, 28)
        Me.Cb_producto.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "En inventario:"
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Location = New System.Drawing.Point(178, 91)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(101, 26)
        Me.Txtcantidad.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad a comprar:"
        '
        'Txtpreciounidad
        '
        Me.Txtpreciounidad.Enabled = False
        Me.Txtpreciounidad.Location = New System.Drawing.Point(132, 59)
        Me.Txtpreciounidad.Name = "Txtpreciounidad"
        Me.Txtpreciounidad.Size = New System.Drawing.Size(58, 26)
        Me.Txtpreciounidad.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Precio unidad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Producto:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Lb_IDFactura)
        Me.GroupBox3.Controls.Add(Me.Dtp_fecha)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtIdclli)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(338, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 94)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información Cliente"
        '
        'Lb_IDFactura
        '
        Me.Lb_IDFactura.AutoSize = True
        Me.Lb_IDFactura.Location = New System.Drawing.Point(144, 0)
        Me.Lb_IDFactura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_IDFactura.Name = "Lb_IDFactura"
        Me.Lb_IDFactura.Size = New System.Drawing.Size(16, 20)
        Me.Lb_IDFactura.TabIndex = 4
        Me.Lb_IDFactura.Text = "0"
        '
        'Dtp_fecha
        '
        Me.Dtp_fecha.Location = New System.Drawing.Point(68, 58)
        Me.Dtp_fecha.Name = "Dtp_fecha"
        Me.Dtp_fecha.Size = New System.Drawing.Size(200, 26)
        Me.Dtp_fecha.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'TxtIdclli
        '
        Me.TxtIdclli.Location = New System.Drawing.Point(92, 26)
        Me.TxtIdclli.Name = "TxtIdclli"
        Me.TxtIdclli.Size = New System.Drawing.Size(176, 26)
        Me.TxtIdclli.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(58, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 454)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Btn_NuevaVenta)
        Me.GroupBox5.Controls.Add(Me.Btn_Limpiar)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Txt_ID_Venta)
        Me.GroupBox5.Controls.Add(Me.BtnIngresar)
        Me.GroupBox5.Location = New System.Drawing.Point(27, 31)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(168, 254)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Transacción"
        '
        'Btn_NuevaVenta
        '
        Me.Btn_NuevaVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_NuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_NuevaVenta.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NuevaVenta.Location = New System.Drawing.Point(18, 134)
        Me.Btn_NuevaVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_NuevaVenta.Name = "Btn_NuevaVenta"
        Me.Btn_NuevaVenta.Size = New System.Drawing.Size(123, 50)
        Me.Btn_NuevaVenta.TabIndex = 6
        Me.Btn_NuevaVenta.Text = "Nueva Venta"
        Me.Btn_NuevaVenta.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Location = New System.Drawing.Point(18, 82)
        Me.Btn_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(123, 48)
        Me.Btn_Limpiar.TabIndex = 5
        Me.Btn_Limpiar.Text = "Finalizar Venta"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID Venta"
        '
        'Txt_ID_Venta
        '
        Me.Txt_ID_Venta.Enabled = False
        Me.Txt_ID_Venta.Location = New System.Drawing.Point(22, 216)
        Me.Txt_ID_Venta.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_ID_Venta.Name = "Txt_ID_Venta"
        Me.Txt_ID_Venta.Size = New System.Drawing.Size(123, 26)
        Me.Txt_ID_Venta.TabIndex = 4
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnIngresar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(18, 25)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(123, 48)
        Me.BtnIngresar.TabIndex = 3
        Me.BtnIngresar.Text = "Ingresar Venta"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.BtnRegresar)
        Me.GroupBox2.Controls.Add(Me.BtnDevolucion)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 149)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(-259, -146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 51)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(328, 268)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 26)
        Me.TextBox3.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(278, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Total:"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(135, 268)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 26)
        Me.TextBox4.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(54, 268)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Subtotal:"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnRegresar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(22, 82)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(123, 51)
        Me.BtnRegresar.TabIndex = 2
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnDevolucion
        '
        Me.BtnDevolucion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnDevolucion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDevolucion.Location = New System.Drawing.Point(22, 25)
        Me.BtnDevolucion.Name = "BtnDevolucion"
        Me.BtnDevolucion.Size = New System.Drawing.Size(123, 51)
        Me.BtnDevolucion.TabIndex = 2
        Me.BtnDevolucion.Text = "Cancelar Venta"
        Me.BtnDevolucion.UseVisualStyleBackColor = True
        '
        'Chk_Eliminar
        '
        Me.Chk_Eliminar.AutoSize = True
        Me.Chk_Eliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Eliminar.Location = New System.Drawing.Point(338, 220)
        Me.Chk_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Chk_Eliminar.Name = "Chk_Eliminar"
        Me.Chk_Eliminar.Size = New System.Drawing.Size(86, 22)
        Me.Chk_Eliminar.TabIndex = 12
        Me.Chk_Eliminar.Text = "cancelar"
        Me.Chk_Eliminar.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.Rd_contado)
        Me.GroupBox6.Controls.Add(Me.Rd_credito)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(651, 107)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(128, 94)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo de Venta"
        '
        'Rd_contado
        '
        Me.Rd_contado.AutoSize = True
        Me.Rd_contado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rd_contado.Location = New System.Drawing.Point(21, 62)
        Me.Rd_contado.Name = "Rd_contado"
        Me.Rd_contado.Size = New System.Drawing.Size(86, 22)
        Me.Rd_contado.TabIndex = 1
        Me.Rd_contado.TabStop = True
        Me.Rd_contado.Text = "Contado"
        Me.Rd_contado.UseVisualStyleBackColor = True
        '
        'Rd_credito
        '
        Me.Rd_credito.AutoSize = True
        Me.Rd_credito.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rd_credito.Location = New System.Drawing.Point(21, 30)
        Me.Rd_credito.Name = "Rd_credito"
        Me.Rd_credito.Size = New System.Drawing.Size(78, 22)
        Me.Rd_credito.TabIndex = 0
        Me.Rd_credito.TabStop = True
        Me.Rd_credito.Text = "Credito"
        Me.Rd_credito.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.Rd_tercera_no)
        Me.GroupBox7.Controls.Add(Me.Rd_tercera_si)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(815, 107)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(100, 94)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Descuento"
        '
        'Rd_tercera_no
        '
        Me.Rd_tercera_no.AutoSize = True
        Me.Rd_tercera_no.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rd_tercera_no.Location = New System.Drawing.Point(27, 58)
        Me.Rd_tercera_no.Name = "Rd_tercera_no"
        Me.Rd_tercera_no.Size = New System.Drawing.Size(49, 22)
        Me.Rd_tercera_no.TabIndex = 16
        Me.Rd_tercera_no.TabStop = True
        Me.Rd_tercera_no.Text = "NO"
        Me.Rd_tercera_no.UseVisualStyleBackColor = True
        '
        'Rd_tercera_si
        '
        Me.Rd_tercera_si.AutoSize = True
        Me.Rd_tercera_si.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rd_tercera_si.Location = New System.Drawing.Point(27, 30)
        Me.Rd_tercera_si.Name = "Rd_tercera_si"
        Me.Rd_tercera_si.Size = New System.Drawing.Size(40, 22)
        Me.Rd_tercera_si.TabIndex = 15
        Me.Rd_tercera_si.TabStop = True
        Me.Rd_tercera_si.Text = "SI"
        Me.Rd_tercera_si.UseVisualStyleBackColor = True
        '
        'Dgv_Listado
        '
        Me.Dgv_Listado.AllowUserToAddRows = False
        Me.Dgv_Listado.AllowUserToDeleteRows = False
        Me.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.Dgv_Listado.Location = New System.Drawing.Point(338, 259)
        Me.Dgv_Listado.Name = "Dgv_Listado"
        Me.Dgv_Listado.ReadOnly = True
        Me.Dgv_Listado.RowHeadersWidth = 51
        Me.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Listado.Size = New System.Drawing.Size(978, 271)
        Me.Dgv_Listado.TabIndex = 13
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 125
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1376, 90)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 540)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Impuesto:"
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Enabled = False
        Me.TxtImpuesto.Location = New System.Drawing.Point(418, 540)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpuesto.TabIndex = 16
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Enabled = False
        Me.TxtDescuento.Location = New System.Drawing.Point(654, 541)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TxtDescuento.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(561, 540)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Descuento:"
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(1066, 540)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1016, 540)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Total:"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Enabled = False
        Me.TxtSubTotal.Location = New System.Drawing.Point(873, 540)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtSubTotal.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(792, 540)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 18)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Subtotal:"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 594)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtSubTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtDescuento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtImpuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Chk_Eliminar)
        Me.Controls.Add(Me.Dgv_Listado)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Txtcantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtpreciounidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIdclli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnDevolucion As Button
    Friend WithEvents Cb_producto As ComboBox
    Friend WithEvents Dtp_fecha As DateTimePicker
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Rd_contado As RadioButton
    Friend WithEvents Rd_credito As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Dgv_Listado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_ID_Venta As TextBox
    Friend WithEvents Chk_Eliminar As CheckBox
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Btn_NuevaVenta As Button
    Friend WithEvents Txt_Cantmaxima As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Lb_IDFactura As Label
    Friend WithEvents Rd_tercera_no As RadioButton
    Friend WithEvents Rd_tercera_si As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label13 As Label
End Class
