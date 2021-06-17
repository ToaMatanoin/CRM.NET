<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Marketing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Marketing))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtIDProducto = New System.Windows.Forms.TextBox()
        Me.TxtIDCliente = New System.Windows.Forms.TextBox()
        Me.TxtID_Mark = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_Estrategia = New System.Windows.Forms.TextBox()
        Me.Cb_ID_prod = New System.Windows.Forms.ComboBox()
        Me.Cb_ID_Cli = New System.Windows.Forms.ComboBox()
        Me.TxtDescripMarke = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chk_Eliminar = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Rb_tarea = New System.Windows.Forms.RadioButton()
        Me.txt_idproy = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Rb_Proyecto = New System.Windows.Forms.RadioButton()
        Me.DTPFechaFinalProyecto = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechaInicioProyecto = New System.Windows.Forms.DateTimePicker()
        Me.TxtDescripProyecto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtNom_proyec = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Dgv_Listado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Btn_EliminarPT = New System.Windows.Forms.Button()
        Me.Btn_ingresarPT = New System.Windows.Forms.Button()
        Me.Btn_NuevoPT = New System.Windows.Forms.Button()
        Me.Btn_ModificarPT = New System.Windows.Forms.Button()
        Me.BtnMinimizate = New System.Windows.Forms.Button()
        Me.Chb_eliminarPT = New System.Windows.Forms.CheckBox()
        Me.Dgvtp = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Dgvtp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TxtIDProducto)
        Me.GroupBox3.Controls.Add(Me.TxtIDCliente)
        Me.GroupBox3.Controls.Add(Me.TxtID_Mark)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Txt_Estrategia)
        Me.GroupBox3.Controls.Add(Me.Cb_ID_prod)
        Me.GroupBox3.Controls.Add(Me.Cb_ID_Cli)
        Me.GroupBox3.Controls.Add(Me.TxtDescripMarke)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 375)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informacion Marketing"
        '
        'TxtIDProducto
        '
        Me.TxtIDProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIDProducto.Enabled = False
        Me.TxtIDProducto.Location = New System.Drawing.Point(109, 91)
        Me.TxtIDProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIDProducto.Name = "TxtIDProducto"
        Me.TxtIDProducto.Size = New System.Drawing.Size(22, 19)
        Me.TxtIDProducto.TabIndex = 19
        Me.TxtIDProducto.Visible = False
        '
        'TxtIDCliente
        '
        Me.TxtIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIDCliente.Enabled = False
        Me.TxtIDCliente.Location = New System.Drawing.Point(109, 55)
        Me.TxtIDCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIDCliente.Name = "TxtIDCliente"
        Me.TxtIDCliente.Size = New System.Drawing.Size(22, 19)
        Me.TxtIDCliente.TabIndex = 18
        Me.TxtIDCliente.Visible = False
        '
        'TxtID_Mark
        '
        Me.TxtID_Mark.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtID_Mark.Enabled = False
        Me.TxtID_Mark.Location = New System.Drawing.Point(162, 23)
        Me.TxtID_Mark.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtID_Mark.Name = "TxtID_Mark"
        Me.TxtID_Mark.Size = New System.Drawing.Size(69, 19)
        Me.TxtID_Mark.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 18)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "ID Marketing:"
        '
        'Txt_Estrategia
        '
        Me.Txt_Estrategia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Estrategia.Enabled = False
        Me.Txt_Estrategia.Location = New System.Drawing.Point(109, 123)
        Me.Txt_Estrategia.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_Estrategia.MaxLength = 50
        Me.Txt_Estrategia.Name = "Txt_Estrategia"
        Me.Txt_Estrategia.Size = New System.Drawing.Size(122, 19)
        Me.Txt_Estrategia.TabIndex = 15
        '
        'Cb_ID_prod
        '
        Me.Cb_ID_prod.Enabled = False
        Me.Cb_ID_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cb_ID_prod.FormattingEnabled = True
        Me.Cb_ID_prod.Location = New System.Drawing.Point(109, 87)
        Me.Cb_ID_prod.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_ID_prod.Name = "Cb_ID_prod"
        Me.Cb_ID_prod.Size = New System.Drawing.Size(122, 28)
        Me.Cb_ID_prod.TabIndex = 14
        '
        'Cb_ID_Cli
        '
        Me.Cb_ID_Cli.Enabled = False
        Me.Cb_ID_Cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cb_ID_Cli.FormattingEnabled = True
        Me.Cb_ID_Cli.Location = New System.Drawing.Point(109, 52)
        Me.Cb_ID_Cli.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_ID_Cli.Name = "Cb_ID_Cli"
        Me.Cb_ID_Cli.Size = New System.Drawing.Size(122, 28)
        Me.Cb_ID_Cli.TabIndex = 13
        '
        'TxtDescripMarke
        '
        Me.TxtDescripMarke.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripMarke.Enabled = False
        Me.TxtDescripMarke.Location = New System.Drawing.Point(7, 181)
        Me.TxtDescripMarke.MaxLength = 100
        Me.TxtDescripMarke.Multiline = True
        Me.TxtDescripMarke.Name = "TxtDescripMarke"
        Me.TxtDescripMarke.Size = New System.Drawing.Size(223, 180)
        Me.TxtDescripMarke.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Descripción:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Estrategia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente:"
        '
        'Chk_Eliminar
        '
        Me.Chk_Eliminar.AutoSize = True
        Me.Chk_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chk_Eliminar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Eliminar.Location = New System.Drawing.Point(256, 187)
        Me.Chk_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Chk_Eliminar.Name = "Chk_Eliminar"
        Me.Chk_Eliminar.Size = New System.Drawing.Size(132, 20)
        Me.Chk_Eliminar.TabIndex = 14
        Me.Chk_Eliminar.Text = "Eliminar Marketing"
        Me.Chk_Eliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.BtnIngresar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 86)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Silver
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(578, 15)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(156, 61)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.Text = "Eliminar Marketing"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Silver
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(41, 15)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(154, 61)
        Me.BtnNuevo.TabIndex = 2
        Me.BtnNuevo.Text = "Nuevo Marketing"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.Silver
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.FlatAppearance.BorderSize = 0
        Me.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Image = CType(resources.GetObject("BtnIngresar.Image"), System.Drawing.Image)
        Me.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngresar.Location = New System.Drawing.Point(222, 15)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(154, 61)
        Me.BtnIngresar.TabIndex = 0
        Me.BtnIngresar.Text = "Ingresar Marketing"
        Me.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Silver
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(402, 15)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(156, 61)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar Marketing"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegresar.FlatAppearance.BorderSize = 0
        Me.BtnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Image = CType(resources.GetObject("BtnRegresar.Image"), System.Drawing.Image)
        Me.BtnRegresar.Location = New System.Drawing.Point(1299, 11)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(59, 51)
        Me.BtnRegresar.TabIndex = 2
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Rb_tarea)
        Me.GroupBox5.Controls.Add(Me.txt_idproy)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.DTPFechaFinalProyecto)
        Me.GroupBox5.Controls.Add(Me.DTPFechaInicioProyecto)
        Me.GroupBox5.Controls.Add(Me.TxtDescripProyecto)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.TxtNom_proyec)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(830, 208)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(528, 226)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        '
        'Rb_tarea
        '
        Me.Rb_tarea.AutoSize = True
        Me.Rb_tarea.Enabled = False
        Me.Rb_tarea.Location = New System.Drawing.Point(329, 16)
        Me.Rb_tarea.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb_tarea.Name = "Rb_tarea"
        Me.Rb_tarea.Size = New System.Drawing.Size(61, 24)
        Me.Rb_tarea.TabIndex = 1
        Me.Rb_tarea.TabStop = True
        Me.Rb_tarea.Text = "Tarea"
        Me.Rb_tarea.UseVisualStyleBackColor = True
        '
        'txt_idproy
        '
        Me.txt_idproy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_idproy.Enabled = False
        Me.txt_idproy.Location = New System.Drawing.Point(9, 17)
        Me.txt_idproy.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_idproy.Name = "txt_idproy"
        Me.txt_idproy.Size = New System.Drawing.Size(76, 19)
        Me.txt_idproy.TabIndex = 12
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Rb_Proyecto)
        Me.GroupBox4.Location = New System.Drawing.Point(105, 10)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(197, 34)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'Rb_Proyecto
        '
        Me.Rb_Proyecto.AutoSize = True
        Me.Rb_Proyecto.Enabled = False
        Me.Rb_Proyecto.Location = New System.Drawing.Point(77, 6)
        Me.Rb_Proyecto.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb_Proyecto.Name = "Rb_Proyecto"
        Me.Rb_Proyecto.Size = New System.Drawing.Size(82, 24)
        Me.Rb_Proyecto.TabIndex = 0
        Me.Rb_Proyecto.TabStop = True
        Me.Rb_Proyecto.Text = "Proyecto"
        Me.Rb_Proyecto.UseVisualStyleBackColor = True
        '
        'DTPFechaFinalProyecto
        '
        Me.DTPFechaFinalProyecto.CustomFormat = "dd-MM-yyyy"
        Me.DTPFechaFinalProyecto.Enabled = False
        Me.DTPFechaFinalProyecto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaFinalProyecto.Location = New System.Drawing.Point(384, 80)
        Me.DTPFechaFinalProyecto.Name = "DTPFechaFinalProyecto"
        Me.DTPFechaFinalProyecto.Size = New System.Drawing.Size(108, 26)
        Me.DTPFechaFinalProyecto.TabIndex = 9
        '
        'DTPFechaInicioProyecto
        '
        Me.DTPFechaInicioProyecto.CustomFormat = "dd-MM-yyyy"
        Me.DTPFechaInicioProyecto.Enabled = False
        Me.DTPFechaInicioProyecto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaInicioProyecto.Location = New System.Drawing.Point(119, 80)
        Me.DTPFechaInicioProyecto.Name = "DTPFechaInicioProyecto"
        Me.DTPFechaInicioProyecto.Size = New System.Drawing.Size(108, 26)
        Me.DTPFechaInicioProyecto.TabIndex = 8
        '
        'TxtDescripProyecto
        '
        Me.TxtDescripProyecto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripProyecto.Enabled = False
        Me.TxtDescripProyecto.Location = New System.Drawing.Point(107, 121)
        Me.TxtDescripProyecto.MaxLength = 100
        Me.TxtDescripProyecto.Multiline = True
        Me.TxtDescripProyecto.Name = "TxtDescripProyecto"
        Me.TxtDescripProyecto.Size = New System.Drawing.Size(402, 95)
        Me.TxtDescripProyecto.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 18)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Descripción:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(284, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 18)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Fecha Final:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Fecha Inicio:"
        '
        'TxtNom_proyec
        '
        Me.TxtNom_proyec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNom_proyec.Enabled = False
        Me.TxtNom_proyec.Location = New System.Drawing.Point(107, 48)
        Me.TxtNom_proyec.MaxLength = 30
        Me.TxtNom_proyec.Name = "TxtNom_proyec"
        Me.TxtNom_proyec.Size = New System.Drawing.Size(402, 19)
        Me.TxtNom_proyec.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Nombre :"
        '
        'Dgv_Listado
        '
        Me.Dgv_Listado.AllowUserToAddRows = False
        Me.Dgv_Listado.AllowUserToDeleteRows = False
        Me.Dgv_Listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_Listado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_Listado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_Listado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_Listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgv_Listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Listado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Listado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_Listado.EnableHeadersVisualStyles = False
        Me.Dgv_Listado.GridColor = System.Drawing.Color.Red
        Me.Dgv_Listado.Location = New System.Drawing.Point(257, 208)
        Me.Dgv_Listado.Name = "Dgv_Listado"
        Me.Dgv_Listado.ReadOnly = True
        Me.Dgv_Listado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Dgv_Listado.RowHeadersVisible = False
        Me.Dgv_Listado.RowHeadersWidth = 51
        Me.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Listado.Size = New System.Drawing.Size(544, 375)
        Me.Dgv_Listado.TabIndex = 13
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 59
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1379, 90)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.Btn_EliminarPT)
        Me.GroupBox6.Controls.Add(Me.Btn_ingresarPT)
        Me.GroupBox6.Controls.Add(Me.Btn_NuevoPT)
        Me.GroupBox6.Controls.Add(Me.Btn_ModificarPT)
        Me.GroupBox6.Location = New System.Drawing.Point(830, 96)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(528, 86)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        '
        'Btn_EliminarPT
        '
        Me.Btn_EliminarPT.BackColor = System.Drawing.Color.Silver
        Me.Btn_EliminarPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EliminarPT.FlatAppearance.BorderSize = 0
        Me.Btn_EliminarPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Btn_EliminarPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EliminarPT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EliminarPT.Image = CType(resources.GetObject("Btn_EliminarPT.Image"), System.Drawing.Image)
        Me.Btn_EliminarPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_EliminarPT.Location = New System.Drawing.Point(395, 16)
        Me.Btn_EliminarPT.Name = "Btn_EliminarPT"
        Me.Btn_EliminarPT.Size = New System.Drawing.Size(121, 61)
        Me.Btn_EliminarPT.TabIndex = 1
        Me.Btn_EliminarPT.Text = "Eliminar "
        Me.Btn_EliminarPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_EliminarPT.UseVisualStyleBackColor = False
        '
        'Btn_ingresarPT
        '
        Me.Btn_ingresarPT.BackColor = System.Drawing.Color.Silver
        Me.Btn_ingresarPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ingresarPT.FlatAppearance.BorderSize = 0
        Me.Btn_ingresarPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Btn_ingresarPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ingresarPT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ingresarPT.Image = CType(resources.GetObject("Btn_ingresarPT.Image"), System.Drawing.Image)
        Me.Btn_ingresarPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ingresarPT.Location = New System.Drawing.Point(141, 16)
        Me.Btn_ingresarPT.Name = "Btn_ingresarPT"
        Me.Btn_ingresarPT.Size = New System.Drawing.Size(121, 61)
        Me.Btn_ingresarPT.TabIndex = 0
        Me.Btn_ingresarPT.Text = "Ingresar"
        Me.Btn_ingresarPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ingresarPT.UseVisualStyleBackColor = False
        '
        'Btn_NuevoPT
        '
        Me.Btn_NuevoPT.BackColor = System.Drawing.Color.Silver
        Me.Btn_NuevoPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_NuevoPT.Enabled = False
        Me.Btn_NuevoPT.FlatAppearance.BorderSize = 0
        Me.Btn_NuevoPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Btn_NuevoPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_NuevoPT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NuevoPT.Image = CType(resources.GetObject("Btn_NuevoPT.Image"), System.Drawing.Image)
        Me.Btn_NuevoPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_NuevoPT.Location = New System.Drawing.Point(14, 15)
        Me.Btn_NuevoPT.Name = "Btn_NuevoPT"
        Me.Btn_NuevoPT.Size = New System.Drawing.Size(121, 61)
        Me.Btn_NuevoPT.TabIndex = 2
        Me.Btn_NuevoPT.Text = "Nuevo"
        Me.Btn_NuevoPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_NuevoPT.UseVisualStyleBackColor = False
        '
        'Btn_ModificarPT
        '
        Me.Btn_ModificarPT.BackColor = System.Drawing.Color.Silver
        Me.Btn_ModificarPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ModificarPT.FlatAppearance.BorderSize = 0
        Me.Btn_ModificarPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Btn_ModificarPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ModificarPT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ModificarPT.Image = CType(resources.GetObject("Btn_ModificarPT.Image"), System.Drawing.Image)
        Me.Btn_ModificarPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ModificarPT.Location = New System.Drawing.Point(268, 16)
        Me.Btn_ModificarPT.Name = "Btn_ModificarPT"
        Me.Btn_ModificarPT.Size = New System.Drawing.Size(121, 61)
        Me.Btn_ModificarPT.TabIndex = 2
        Me.Btn_ModificarPT.Text = "Modificar "
        Me.Btn_ModificarPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ModificarPT.UseVisualStyleBackColor = False
        '
        'BtnMinimizate
        '
        Me.BtnMinimizate.AutoSize = True
        Me.BtnMinimizate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMinimizate.FlatAppearance.BorderSize = 0
        Me.BtnMinimizate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnMinimizate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizate.Image = CType(resources.GetObject("BtnMinimizate.Image"), System.Drawing.Image)
        Me.BtnMinimizate.Location = New System.Drawing.Point(1234, 12)
        Me.BtnMinimizate.Name = "BtnMinimizate"
        Me.BtnMinimizate.Size = New System.Drawing.Size(59, 51)
        Me.BtnMinimizate.TabIndex = 35
        Me.BtnMinimizate.UseVisualStyleBackColor = False
        '
        'Chb_eliminarPT
        '
        Me.Chb_eliminarPT.AutoSize = True
        Me.Chb_eliminarPT.Enabled = False
        Me.Chb_eliminarPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chb_eliminarPT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_eliminarPT.Location = New System.Drawing.Point(1287, 187)
        Me.Chb_eliminarPT.Margin = New System.Windows.Forms.Padding(2)
        Me.Chb_eliminarPT.Name = "Chb_eliminarPT"
        Me.Chb_eliminarPT.Size = New System.Drawing.Size(71, 20)
        Me.Chb_eliminarPT.TabIndex = 36
        Me.Chb_eliminarPT.Text = "Eliminar"
        Me.Chb_eliminarPT.UseVisualStyleBackColor = True
        '
        'Dgvtp
        '
        Me.Dgvtp.AllowUserToAddRows = False
        Me.Dgvtp.AllowUserToDeleteRows = False
        Me.Dgvtp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgvtp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgvtp.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgvtp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgvtp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgvtp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvtp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgvtp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvtp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgvtp.DefaultCellStyle = DataGridViewCellStyle4
        Me.Dgvtp.EnableHeadersVisualStyles = False
        Me.Dgvtp.GridColor = System.Drawing.Color.Red
        Me.Dgvtp.Location = New System.Drawing.Point(830, 440)
        Me.Dgvtp.Name = "Dgvtp"
        Me.Dgvtp.ReadOnly = True
        Me.Dgvtp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Dgvtp.RowHeadersVisible = False
        Me.Dgvtp.RowHeadersWidth = 51
        Me.Dgvtp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgvtp.Size = New System.Drawing.Size(528, 143)
        Me.Dgvtp.TabIndex = 37
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Eliminar"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 59
        '
        'Marketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1379, 640)
        Me.Controls.Add(Me.Dgvtp)
        Me.Controls.Add(Me.Chb_eliminarPT)
        Me.Controls.Add(Me.BtnMinimizate)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Chk_Eliminar)
        Me.Controls.Add(Me.Dgv_Listado)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Marketing"
        Me.Text = "Marketing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.Dgvtp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents TxtDescripMarke As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DTPFechaFinalProyecto As DateTimePicker
    Friend WithEvents DTPFechaInicioProyecto As DateTimePicker
    Friend WithEvents TxtDescripProyecto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtNom_proyec As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Dgv_Listado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Txt_Estrategia As TextBox
    Friend WithEvents Cb_ID_prod As ComboBox
    Friend WithEvents Cb_ID_Cli As ComboBox
    Friend WithEvents Chk_Eliminar As CheckBox
    Friend WithEvents TxtID_Mark As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Rb_tarea As RadioButton
    Friend WithEvents Rb_Proyecto As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Btn_ModificarPT As Button
    Friend WithEvents Btn_NuevoPT As Button
    Friend WithEvents Btn_EliminarPT As Button
    Friend WithEvents Btn_ingresarPT As Button
    Friend WithEvents BtnMinimizate As Button
    Friend WithEvents txt_idproy As TextBox
    Friend WithEvents Chb_eliminarPT As CheckBox
    Friend WithEvents Dgvtp As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents TxtIDProducto As TextBox
    Friend WithEvents TxtIDCliente As TextBox
End Class
