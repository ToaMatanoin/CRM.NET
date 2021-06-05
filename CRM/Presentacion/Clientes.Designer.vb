<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Cmb_Buscar = New System.Windows.Forms.ComboBox()
        Me.Lb_Buscar = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtIDCliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtEmailCli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTelCli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNomCli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtRTN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEmailEmpresa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTelEmpresa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNomEmpresa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Dgv_Listado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Chk_Eliminar = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnIngresar)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 132)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(720, 106)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnNuevo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(19, 18)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(164, 74)
        Me.BtnNuevo.TabIndex = 27
        Me.BtnNuevo.Text = "Nuevo Cliente"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(537, 20)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(172, 73)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.Text = "Eliminar Cliente"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnModificar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(365, 20)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(164, 73)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar Cliente"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnIngresar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(193, 20)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(164, 73)
        Me.BtnIngresar.TabIndex = 0
        Me.BtnIngresar.Text = "Ingresar Cliente"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(365, 34)
        Me.Txt_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Buscar.Multiline = True
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(381, 34)
        Me.Txt_Buscar.TabIndex = 12
        '
        'Cmb_Buscar
        '
        Me.Cmb_Buscar.FormattingEnabled = True
        Me.Cmb_Buscar.Location = New System.Drawing.Point(121, 34)
        Me.Cmb_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmb_Buscar.Name = "Cmb_Buscar"
        Me.Cmb_Buscar.Size = New System.Drawing.Size(196, 33)
        Me.Cmb_Buscar.TabIndex = 11
        '
        'Lb_Buscar
        '
        Me.Lb_Buscar.AutoSize = True
        Me.Lb_Buscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Buscar.Location = New System.Drawing.Point(37, 39)
        Me.Lb_Buscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_Buscar.Name = "Lb_Buscar"
        Me.Lb_Buscar.Size = New System.Drawing.Size(71, 23)
        Me.Lb_Buscar.TabIndex = 10
        Me.Lb_Buscar.Text = "Buscar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BtnRegresar)
        Me.GroupBox2.Controls.Add(Me.BtnCerrar)
        Me.GroupBox2.Location = New System.Drawing.Point(1584, 132)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(184, 106)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnRegresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(8, 16)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(164, 39)
        Me.BtnRegresar.TabIndex = 2
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCerrar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(8, 59)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(164, 38)
        Me.BtnCerrar.TabIndex = 26
        Me.BtnCerrar.Text = "Cancelar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TxtIDCliente)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtEmailCli)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtTelCli)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtNomCli)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(59, 265)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(487, 193)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Persona a Cargo"
        '
        'TxtIDCliente
        '
        Me.TxtIDCliente.Enabled = False
        Me.TxtIDCliente.Location = New System.Drawing.Point(356, 31)
        Me.TxtIDCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIDCliente.Name = "TxtIDCliente"
        Me.TxtIDCliente.Size = New System.Drawing.Size(112, 30)
        Me.TxtIDCliente.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 36)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Codigo: "
        '
        'TxtEmailCli
        '
        Me.TxtEmailCli.Enabled = False
        Me.TxtEmailCli.Location = New System.Drawing.Point(193, 149)
        Me.TxtEmailCli.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmailCli.MaxLength = 45
        Me.TxtEmailCli.Name = "TxtEmailCli"
        Me.TxtEmailCli.Size = New System.Drawing.Size(275, 30)
        Me.TxtEmailCli.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "E-mail Cliente:"
        '
        'TxtTelCli
        '
        Me.TxtTelCli.Enabled = False
        Me.TxtTelCli.Location = New System.Drawing.Point(193, 110)
        Me.TxtTelCli.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelCli.MaxLength = 8
        Me.TxtTelCli.Name = "TxtTelCli"
        Me.TxtTelCli.Size = New System.Drawing.Size(275, 30)
        Me.TxtTelCli.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono Cliente:"
        '
        'TxtNomCli
        '
        Me.TxtNomCli.Enabled = False
        Me.TxtNomCli.Location = New System.Drawing.Point(193, 70)
        Me.TxtNomCli.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNomCli.MaxLength = 45
        Me.TxtNomCli.Name = "TxtNomCli"
        Me.TxtNomCli.Size = New System.Drawing.Size(275, 30)
        Me.TxtNomCli.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre Cliente:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.TxtRTN)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TxtEmailEmpresa)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TxtTelEmpresa)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TxtNomEmpresa)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(59, 485)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(487, 194)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Empresa"
        '
        'TxtRTN
        '
        Me.TxtRTN.Enabled = False
        Me.TxtRTN.Location = New System.Drawing.Point(203, 149)
        Me.TxtRTN.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRTN.MaxLength = 14
        Me.TxtRTN.Name = "TxtRTN"
        Me.TxtRTN.Size = New System.Drawing.Size(265, 30)
        Me.TxtRTN.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 154)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "RTN:"
        '
        'TxtEmailEmpresa
        '
        Me.TxtEmailEmpresa.Enabled = False
        Me.TxtEmailEmpresa.Location = New System.Drawing.Point(203, 110)
        Me.TxtEmailEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmailEmpresa.MaxLength = 45
        Me.TxtEmailEmpresa.Name = "TxtEmailEmpresa"
        Me.TxtEmailEmpresa.Size = New System.Drawing.Size(265, 30)
        Me.TxtEmailEmpresa.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 114)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "E-mail Empresa:"
        '
        'TxtTelEmpresa
        '
        Me.TxtTelEmpresa.Enabled = False
        Me.TxtTelEmpresa.Location = New System.Drawing.Point(203, 70)
        Me.TxtTelEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelEmpresa.MaxLength = 8
        Me.TxtTelEmpresa.Name = "TxtTelEmpresa"
        Me.TxtTelEmpresa.Size = New System.Drawing.Size(265, 30)
        Me.TxtTelEmpresa.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 75)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Telefono Empresa:"
        '
        'TxtNomEmpresa
        '
        Me.TxtNomEmpresa.Enabled = False
        Me.TxtNomEmpresa.Location = New System.Drawing.Point(203, 31)
        Me.TxtNomEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNomEmpresa.MaxLength = 45
        Me.TxtNomEmpresa.Name = "TxtNomEmpresa"
        Me.TxtNomEmpresa.Size = New System.Drawing.Size(265, 30)
        Me.TxtNomEmpresa.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 36)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nombre Empresa:"
        '
        'Dgv_Listado
        '
        Me.Dgv_Listado.AllowUserToAddRows = False
        Me.Dgv_Listado.AllowUserToDeleteRows = False
        Me.Dgv_Listado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_Listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.Dgv_Listado.Location = New System.Drawing.Point(596, 284)
        Me.Dgv_Listado.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_Listado.Name = "Dgv_Listado"
        Me.Dgv_Listado.ReadOnly = True
        Me.Dgv_Listado.RowHeadersWidth = 51
        Me.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Listado.Size = New System.Drawing.Size(1172, 395)
        Me.Dgv_Listado.TabIndex = 7
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 125
        '
        'Chk_Eliminar
        '
        Me.Chk_Eliminar.AutoSize = True
        Me.Chk_Eliminar.Location = New System.Drawing.Point(596, 256)
        Me.Chk_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.Chk_Eliminar.Name = "Chk_Eliminar"
        Me.Chk_Eliminar.Size = New System.Drawing.Size(80, 21)
        Me.Chk_Eliminar.TabIndex = 11
        Me.Chk_Eliminar.Text = "Eliminar"
        Me.Chk_Eliminar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1843, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Lb_Buscar)
        Me.GroupBox5.Controls.Add(Me.Cmb_Buscar)
        Me.GroupBox5.Controls.Add(Me.Txt_Buscar)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(787, 132)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(789, 106)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1827, 730)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Chk_Eliminar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Dgv_Listado)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtEmailCli As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTelCli As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNomCli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtRTN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEmailEmpresa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTelEmpresa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNomEmpresa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtIDCliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Cmb_Buscar As ComboBox
    Friend WithEvents Lb_Buscar As Label
    Friend WithEvents Dgv_Listado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Chk_Eliminar As CheckBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
End Class
