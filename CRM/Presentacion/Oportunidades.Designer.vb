﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Oportunidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Oportunidades))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPosibilidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtIDClientePot = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmailCli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTelCli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNomCli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Cmb_Buscar = New System.Windows.Forms.ComboBox()
        Me.Lb_Buscar = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Chk_Eliminar = New System.Windows.Forms.CheckBox()
        Me.Dgv_Listado = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Chk_Convertir = New System.Windows.Forms.CheckBox()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Convertir = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(302, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "%"
        '
        'TxtPosibilidad
        '
        Me.TxtPosibilidad.Enabled = False
        Me.TxtPosibilidad.Location = New System.Drawing.Point(214, 300)
        Me.TxtPosibilidad.Name = "TxtPosibilidad"
        Me.TxtPosibilidad.Size = New System.Drawing.Size(82, 26)
        Me.TxtPosibilidad.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Posibilidad de Exito:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TxtIDClientePot)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtEmailCli)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtTelCli)
        Me.GroupBox3.Controls.Add(Me.TxtPosibilidad)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtNomCli)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(50, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 345)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Persona a Cargo"
        '
        'TxtIDClientePot
        '
        Me.TxtIDClientePot.Enabled = False
        Me.TxtIDClientePot.Location = New System.Drawing.Point(239, 25)
        Me.TxtIDClientePot.Name = "TxtIDClientePot"
        Me.TxtIDClientePot.Size = New System.Drawing.Size(90, 26)
        Me.TxtIDClientePot.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "ID Cliente Pot:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(114, 153)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(215, 141)
        Me.TxtDescripcion.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Descripción:"
        '
        'TxtEmailCli
        '
        Me.TxtEmailCli.Enabled = False
        Me.TxtEmailCli.Location = New System.Drawing.Point(159, 121)
        Me.TxtEmailCli.Name = "TxtEmailCli"
        Me.TxtEmailCli.Size = New System.Drawing.Size(170, 26)
        Me.TxtEmailCli.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "E-mail Cliente:"
        '
        'TxtTelCli
        '
        Me.TxtTelCli.Enabled = False
        Me.TxtTelCli.Location = New System.Drawing.Point(159, 89)
        Me.TxtTelCli.Name = "TxtTelCli"
        Me.TxtTelCli.Size = New System.Drawing.Size(170, 26)
        Me.TxtTelCli.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono Cliente:"
        '
        'TxtNomCli
        '
        Me.TxtNomCli.Enabled = False
        Me.TxtNomCli.Location = New System.Drawing.Point(159, 57)
        Me.TxtNomCli.Name = "TxtNomCli"
        Me.TxtNomCli.Size = New System.Drawing.Size(170, 26)
        Me.TxtNomCli.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnConvertir)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnIngresar)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 86)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'btnConvertir
        '
        Me.btnConvertir.BackColor = System.Drawing.Color.Silver
        Me.btnConvertir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnConvertir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(530, 16)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(123, 61)
        Me.btnConvertir.TabIndex = 4
        Me.btnConvertir.Text = "Convertir Cliente"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Silver
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnNuevo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(14, 16)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(123, 61)
        Me.BtnNuevo.TabIndex = 3
        Me.BtnNuevo.Text = "Nuevo Cliente"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Silver
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnModificar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(272, 16)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(123, 61)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar Cliente"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Silver
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(401, 16)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(123, 61)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.Text = "Eliminar Cliente"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.Silver
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnIngresar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(143, 16)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(123, 61)
        Me.BtnIngresar.TabIndex = 0
        Me.BtnIngresar.Text = "Ingresar Cliente"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(229, 32)
        Me.Txt_Buscar.Multiline = True
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(187, 26)
        Me.Txt_Buscar.TabIndex = 23
        '
        'Cmb_Buscar
        '
        Me.Cmb_Buscar.FormattingEnabled = True
        Me.Cmb_Buscar.Location = New System.Drawing.Point(75, 32)
        Me.Cmb_Buscar.Name = "Cmb_Buscar"
        Me.Cmb_Buscar.Size = New System.Drawing.Size(148, 26)
        Me.Cmb_Buscar.TabIndex = 22
        '
        'Lb_Buscar
        '
        Me.Lb_Buscar.AutoSize = True
        Me.Lb_Buscar.Location = New System.Drawing.Point(12, 36)
        Me.Lb_Buscar.Name = "Lb_Buscar"
        Me.Lb_Buscar.Size = New System.Drawing.Size(57, 18)
        Me.Lb_Buscar.TabIndex = 21
        Me.Lb_Buscar.Text = "Buscar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BtnRegresar)
        Me.GroupBox2.Location = New System.Drawing.Point(1174, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 86)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Silver
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
        'Chk_Eliminar
        '
        Me.Chk_Eliminar.AutoSize = True
        Me.Chk_Eliminar.Location = New System.Drawing.Point(451, 185)
        Me.Chk_Eliminar.Name = "Chk_Eliminar"
        Me.Chk_Eliminar.Size = New System.Drawing.Size(62, 17)
        Me.Chk_Eliminar.TabIndex = 20
        Me.Chk_Eliminar.Text = "Eliminar"
        Me.Chk_Eliminar.UseVisualStyleBackColor = True
        '
        'Dgv_Listado
        '
        Me.Dgv_Listado.AllowUserToAddRows = False
        Me.Dgv_Listado.AllowUserToDeleteRows = False
        Me.Dgv_Listado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar, Me.Convertir})
        Me.Dgv_Listado.Location = New System.Drawing.Point(451, 208)
        Me.Dgv_Listado.Name = "Dgv_Listado"
        Me.Dgv_Listado.ReadOnly = True
        Me.Dgv_Listado.RowHeadersWidth = 51
        Me.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Listado.Size = New System.Drawing.Size(852, 342)
        Me.Dgv_Listado.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1374, 90)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Cmb_Buscar)
        Me.GroupBox4.Controls.Add(Me.Lb_Buscar)
        Me.GroupBox4.Controls.Add(Me.Txt_Buscar)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(726, 93)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(442, 86)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'Chk_Convertir
        '
        Me.Chk_Convertir.AutoSize = True
        Me.Chk_Convertir.Location = New System.Drawing.Point(519, 185)
        Me.Chk_Convertir.Name = "Chk_Convertir"
        Me.Chk_Convertir.Size = New System.Drawing.Size(112, 17)
        Me.Chk_Convertir.TabIndex = 26
        Me.Chk_Convertir.Text = "Convertir a Cliente"
        Me.Chk_Convertir.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 125
        '
        'Convertir
        '
        Me.Convertir.HeaderText = "Convertir"
        Me.Convertir.MinimumWidth = 6
        Me.Convertir.Name = "Convertir"
        Me.Convertir.ReadOnly = True
        Me.Convertir.Width = 125
        '
        'Oportunidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1370, 574)
        Me.Controls.Add(Me.Chk_Convertir)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Dgv_Listado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Chk_Eliminar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Oportunidades"
        Me.Text = "Oportunidades"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPosibilidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEmailCli As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTelCli As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNomCli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents TxtIDClientePot As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Chk_Eliminar As CheckBox
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Cmb_Buscar As ComboBox
    Friend WithEvents Lb_Buscar As Label
    Friend WithEvents Dgv_Listado As DataGridView
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents Chk_Convertir As CheckBox
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Convertir As DataGridViewCheckBoxColumn
End Class
