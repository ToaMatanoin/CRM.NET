<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnMarketing = New System.Windows.Forms.Button()
        Me.BtnInventario = New System.Windows.Forms.Button()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnOportunidades = New System.Windows.Forms.Button()
        Me.BtnComunicacion = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnVentas
        '
        Me.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.Image = CType(resources.GetObject("BtnVentas.Image"), System.Drawing.Image)
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.Location = New System.Drawing.Point(12, 340)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(286, 51)
        Me.BtnVentas.TabIndex = 3
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'BtnMarketing
        '
        Me.BtnMarketing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMarketing.FlatAppearance.BorderSize = 0
        Me.BtnMarketing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMarketing.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMarketing.Image = CType(resources.GetObject("BtnMarketing.Image"), System.Drawing.Image)
        Me.BtnMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMarketing.Location = New System.Drawing.Point(12, 397)
        Me.BtnMarketing.Name = "BtnMarketing"
        Me.BtnMarketing.Size = New System.Drawing.Size(286, 51)
        Me.BtnMarketing.TabIndex = 2
        Me.BtnMarketing.Text = "Marketing"
        Me.BtnMarketing.UseVisualStyleBackColor = True
        '
        'BtnInventario
        '
        Me.BtnInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInventario.FlatAppearance.BorderSize = 0
        Me.BtnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInventario.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventario.Image = CType(resources.GetObject("BtnInventario.Image"), System.Drawing.Image)
        Me.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInventario.Location = New System.Drawing.Point(12, 283)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(286, 51)
        Me.BtnInventario.TabIndex = 2
        Me.BtnInventario.Text = "Inventario"
        Me.BtnInventario.UseVisualStyleBackColor = True
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmpleados.FlatAppearance.BorderSize = 0
        Me.BtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleados.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.Image = CType(resources.GetObject("BtnEmpleados.Image"), System.Drawing.Image)
        Me.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpleados.Location = New System.Drawing.Point(12, 511)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(286, 51)
        Me.BtnEmpleados.TabIndex = 4
        Me.BtnEmpleados.Text = "Empleados"
        Me.BtnEmpleados.UseVisualStyleBackColor = True
        '
        'BtnOportunidades
        '
        Me.BtnOportunidades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOportunidades.FlatAppearance.BorderSize = 0
        Me.BtnOportunidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnOportunidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOportunidades.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOportunidades.Image = CType(resources.GetObject("BtnOportunidades.Image"), System.Drawing.Image)
        Me.BtnOportunidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOportunidades.Location = New System.Drawing.Point(12, 169)
        Me.BtnOportunidades.Name = "BtnOportunidades"
        Me.BtnOportunidades.Size = New System.Drawing.Size(286, 51)
        Me.BtnOportunidades.TabIndex = 2
        Me.BtnOportunidades.Text = "Oportunidades"
        Me.BtnOportunidades.UseVisualStyleBackColor = True
        '
        'BtnComunicacion
        '
        Me.BtnComunicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnComunicacion.FlatAppearance.BorderSize = 0
        Me.BtnComunicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnComunicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComunicacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComunicacion.Image = CType(resources.GetObject("BtnComunicacion.Image"), System.Drawing.Image)
        Me.BtnComunicacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComunicacion.Location = New System.Drawing.Point(12, 226)
        Me.BtnComunicacion.Name = "BtnComunicacion"
        Me.BtnComunicacion.Size = New System.Drawing.Size(286, 51)
        Me.BtnComunicacion.TabIndex = 1
        Me.BtnComunicacion.Text = "Comunicaciones"
        Me.BtnComunicacion.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), System.Drawing.Image)
        Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.Location = New System.Drawing.Point(12, 112)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(286, 51)
        Me.BtnClientes.TabIndex = 0
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.Image = CType(resources.GetObject("BtnUsuarios.Image"), System.Drawing.Image)
        Me.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuarios.Location = New System.Drawing.Point(12, 454)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(286, 51)
        Me.BtnUsuarios.TabIndex = 2
        Me.BtnUsuarios.Text = "Usuarios"
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1385, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.BtnEmpleados)
        Me.Panel1.Controls.Add(Me.BtnUsuarios)
        Me.Panel1.Controls.Add(Me.BtnMarketing)
        Me.Panel1.Controls.Add(Me.BtnVentas)
        Me.Panel1.Controls.Add(Me.BtnComunicacion)
        Me.Panel1.Controls.Add(Me.BtnOportunidades)
        Me.Panel1.Controls.Add(Me.BtnInventario)
        Me.Panel1.Controls.Add(Me.BtnClientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 667)
        Me.Panel1.TabIndex = 6
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1370, 667)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnVentas As Button
    Friend WithEvents BtnMarketing As Button
    Friend WithEvents BtnOportunidades As Button
    Friend WithEvents BtnInventario As Button
    Friend WithEvents BtnComunicacion As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnEmpleados As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
