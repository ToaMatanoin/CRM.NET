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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtIDUsuario = New System.Windows.Forms.TextBox()
        Me.Chk_Eliminar = New System.Windows.Forms.CheckBox()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Rb_tarea = New System.Windows.Forms.RadioButton()
        Me.Rb_Proyecto = New System.Windows.Forms.RadioButton()
        Me.Btn_Guardar_proy = New System.Windows.Forms.Button()
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
        Me.Dgvtp = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Cmb_Buscar = New System.Windows.Forms.ComboBox()
        Me.Lb_Buscar = New System.Windows.Forms.Label()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgvtp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TxtIDUsuario)
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
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 375)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informacion Marketing"
        '
        'TxtIDUsuario
        '
        Me.TxtIDUsuario.Enabled = False
        Me.TxtIDUsuario.Location = New System.Drawing.Point(162, 54)
        Me.TxtIDUsuario.Name = "TxtIDUsuario"
        Me.TxtIDUsuario.Size = New System.Drawing.Size(68, 26)
        Me.TxtIDUsuario.TabIndex = 12
        '
        'Chk_Eliminar
        '
        Me.Chk_Eliminar.AutoSize = True
        Me.Chk_Eliminar.Location = New System.Drawing.Point(257, 183)
        Me.Chk_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Chk_Eliminar.Name = "Chk_Eliminar"
        Me.Chk_Eliminar.Size = New System.Drawing.Size(62, 17)
        Me.Chk_Eliminar.TabIndex = 14
        Me.Chk_Eliminar.Text = "Eliminar"
        Me.Chk_Eliminar.UseVisualStyleBackColor = True
        '
        'TxtID_Mark
        '
        Me.TxtID_Mark.Enabled = False
        Me.TxtID_Mark.Location = New System.Drawing.Point(162, 23)
        Me.TxtID_Mark.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtID_Mark.Name = "TxtID_Mark"
        Me.TxtID_Mark.Size = New System.Drawing.Size(69, 26)
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
        Me.Txt_Estrategia.Location = New System.Drawing.Point(95, 151)
        Me.Txt_Estrategia.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_Estrategia.Name = "Txt_Estrategia"
        Me.Txt_Estrategia.Size = New System.Drawing.Size(136, 26)
        Me.Txt_Estrategia.TabIndex = 15
        '
        'Cb_ID_prod
        '
        Me.Cb_ID_prod.FormattingEnabled = True
        Me.Cb_ID_prod.Location = New System.Drawing.Point(162, 117)
        Me.Cb_ID_prod.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_ID_prod.Name = "Cb_ID_prod"
        Me.Cb_ID_prod.Size = New System.Drawing.Size(69, 28)
        Me.Cb_ID_prod.TabIndex = 14
        '
        'Cb_ID_Cli
        '
        Me.Cb_ID_Cli.FormattingEnabled = True
        Me.Cb_ID_Cli.Location = New System.Drawing.Point(162, 85)
        Me.Cb_ID_Cli.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_ID_Cli.Name = "Cb_ID_Cli"
        Me.Cb_ID_Cli.Size = New System.Drawing.Size(69, 28)
        Me.Cb_ID_Cli.TabIndex = 13
        '
        'TxtDescripMarke
        '
        Me.TxtDescripMarke.Location = New System.Drawing.Point(7, 207)
        Me.TxtDescripMarke.Multiline = True
        Me.TxtDescripMarke.Name = "TxtDescripMarke"
        Me.TxtDescripMarke.Size = New System.Drawing.Size(223, 154)
        Me.TxtDescripMarke.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Descripción:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Estrategia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID Producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Usuario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnIngresar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 86)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BtnRegresar)
        Me.GroupBox2.Location = New System.Drawing.Point(1220, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 86)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnRegresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(6, 19)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(123, 51)
        Me.BtnRegresar.TabIndex = 2
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnModificar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(267, 15)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(123, 61)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar Marketing"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnBuscar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(9, 15)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(123, 61)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Nuevo Marketing"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(396, 15)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(123, 61)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.Text = "Eliminar Marketing"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnIngresar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(138, 15)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(123, 61)
        Me.BtnIngresar.TabIndex = 0
        Me.BtnIngresar.Text = "Ingresar Marketing"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.Btn_Guardar_proy)
        Me.GroupBox5.Controls.Add(Me.DTPFechaFinalProyecto)
        Me.GroupBox5.Controls.Add(Me.DTPFechaInicioProyecto)
        Me.GroupBox5.Controls.Add(Me.TxtDescripProyecto)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.TxtNom_proyec)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(893, 188)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(465, 226)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Rb_tarea)
        Me.GroupBox4.Controls.Add(Me.Rb_Proyecto)
        Me.GroupBox4.Location = New System.Drawing.Point(105, 10)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(197, 34)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'Rb_tarea
        '
        Me.Rb_tarea.AutoSize = True
        Me.Rb_tarea.Location = New System.Drawing.Point(125, 6)
        Me.Rb_tarea.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb_tarea.Name = "Rb_tarea"
        Me.Rb_tarea.Size = New System.Drawing.Size(61, 24)
        Me.Rb_tarea.TabIndex = 1
        Me.Rb_tarea.TabStop = True
        Me.Rb_tarea.Text = "Tarea"
        Me.Rb_tarea.UseVisualStyleBackColor = True
        '
        'Rb_Proyecto
        '
        Me.Rb_Proyecto.AutoSize = True
        Me.Rb_Proyecto.Location = New System.Drawing.Point(15, 6)
        Me.Rb_Proyecto.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb_Proyecto.Name = "Rb_Proyecto"
        Me.Rb_Proyecto.Size = New System.Drawing.Size(82, 24)
        Me.Rb_Proyecto.TabIndex = 0
        Me.Rb_Proyecto.TabStop = True
        Me.Rb_Proyecto.Text = "Proyecto"
        Me.Rb_Proyecto.UseVisualStyleBackColor = True
        '
        'Btn_Guardar_proy
        '
        Me.Btn_Guardar_proy.BackColor = System.Drawing.Color.Silver
        Me.Btn_Guardar_proy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Guardar_proy.Enabled = False
        Me.Btn_Guardar_proy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guardar_proy.Location = New System.Drawing.Point(9, 181)
        Me.Btn_Guardar_proy.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Guardar_proy.Name = "Btn_Guardar_proy"
        Me.Btn_Guardar_proy.Size = New System.Drawing.Size(72, 33)
        Me.Btn_Guardar_proy.TabIndex = 10
        Me.Btn_Guardar_proy.Text = "Guardar"
        Me.Btn_Guardar_proy.UseVisualStyleBackColor = False
        '
        'DTPFechaFinalProyecto
        '
        Me.DTPFechaFinalProyecto.Location = New System.Drawing.Point(119, 112)
        Me.DTPFechaFinalProyecto.Name = "DTPFechaFinalProyecto"
        Me.DTPFechaFinalProyecto.Size = New System.Drawing.Size(337, 26)
        Me.DTPFechaFinalProyecto.TabIndex = 9
        '
        'DTPFechaInicioProyecto
        '
        Me.DTPFechaInicioProyecto.Location = New System.Drawing.Point(119, 80)
        Me.DTPFechaInicioProyecto.Name = "DTPFechaInicioProyecto"
        Me.DTPFechaInicioProyecto.Size = New System.Drawing.Size(337, 26)
        Me.DTPFechaInicioProyecto.TabIndex = 8
        '
        'TxtDescripProyecto
        '
        Me.TxtDescripProyecto.Location = New System.Drawing.Point(107, 144)
        Me.TxtDescripProyecto.Multiline = True
        Me.TxtDescripProyecto.Name = "TxtDescripProyecto"
        Me.TxtDescripProyecto.Size = New System.Drawing.Size(349, 72)
        Me.TxtDescripProyecto.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 18)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Descripción:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 18)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Fecha Final:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Fecha Inicio:"
        '
        'TxtNom_proyec
        '
        Me.TxtNom_proyec.Location = New System.Drawing.Point(119, 48)
        Me.TxtNom_proyec.Name = "TxtNom_proyec"
        Me.TxtNom_proyec.Size = New System.Drawing.Size(337, 26)
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
        Me.Dgv_Listado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.Dgv_Listado.Location = New System.Drawing.Point(257, 208)
        Me.Dgv_Listado.Name = "Dgv_Listado"
        Me.Dgv_Listado.ReadOnly = True
        Me.Dgv_Listado.RowHeadersWidth = 51
        Me.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Listado.Size = New System.Drawing.Size(597, 375)
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
        'Dgvtp
        '
        Me.Dgvtp.AllowUserToAddRows = False
        Me.Dgvtp.AllowUserToDeleteRows = False
        Me.Dgvtp.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgvtp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvtp.Location = New System.Drawing.Point(893, 426)
        Me.Dgvtp.Name = "Dgvtp"
        Me.Dgvtp.ReadOnly = True
        Me.Dgvtp.RowHeadersWidth = 51
        Me.Dgvtp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgvtp.Size = New System.Drawing.Size(465, 157)
        Me.Dgvtp.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1374, 90)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Location = New System.Drawing.Point(893, 91)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(321, 86)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(159, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 61)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Modificar Proyecto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(84, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 61)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Nuevo Proyecto"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(234, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 61)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Eliminar Proyecto"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(9, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 61)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Ingresar Proyecto"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.Cmb_Buscar)
        Me.GroupBox7.Controls.Add(Me.Lb_Buscar)
        Me.GroupBox7.Controls.Add(Me.Txt_Buscar)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(547, 91)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(307, 86)
        Me.GroupBox7.TabIndex = 26
        Me.GroupBox7.TabStop = False
        '
        'Cmb_Buscar
        '
        Me.Cmb_Buscar.FormattingEnabled = True
        Me.Cmb_Buscar.Location = New System.Drawing.Point(159, 15)
        Me.Cmb_Buscar.Name = "Cmb_Buscar"
        Me.Cmb_Buscar.Size = New System.Drawing.Size(116, 26)
        Me.Cmb_Buscar.TabIndex = 22
        '
        'Lb_Buscar
        '
        Me.Lb_Buscar.AutoSize = True
        Me.Lb_Buscar.Location = New System.Drawing.Point(23, 18)
        Me.Lb_Buscar.Name = "Lb_Buscar"
        Me.Lb_Buscar.Size = New System.Drawing.Size(130, 18)
        Me.Lb_Buscar.TabIndex = 21
        Me.Lb_Buscar.Text = "Buscar Marketing"
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(19, 47)
        Me.Txt_Buscar.Multiline = True
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(256, 26)
        Me.Txt_Buscar.TabIndex = 23
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Silver
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(9, 12)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 33)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Completar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Marketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1370, 678)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Chk_Eliminar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Dgvtp)
        Me.Controls.Add(Me.Dgv_Listado)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Marketing"
        Me.Text = "Marketing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgvtp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnBuscar As Button
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
    Friend WithEvents Btn_Guardar_proy As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Rb_tarea As RadioButton
    Friend WithEvents Rb_Proyecto As RadioButton
    Friend WithEvents Dgvtp As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIDUsuario As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Cmb_Buscar As ComboBox
    Friend WithEvents Lb_Buscar As Label
    Friend WithEvents Txt_Buscar As TextBox
End Class
