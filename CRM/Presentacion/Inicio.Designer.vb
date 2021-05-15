<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnMarketing = New System.Windows.Forms.Button()
        Me.BtnOportunidades = New System.Windows.Forms.Button()
        Me.BtnInventario = New System.Windows.Forms.Button()
        Me.BtnComunicacion = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Aquamarine
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1397, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HËKIN CRM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnEmpleados)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnUsuarios)
        Me.GroupBox1.Controls.Add(Me.BtnVentas)
        Me.GroupBox1.Controls.Add(Me.BtnMarketing)
        Me.GroupBox1.Controls.Add(Me.BtnOportunidades)
        Me.GroupBox1.Controls.Add(Me.BtnInventario)
        Me.GroupBox1.Controls.Add(Me.BtnComunicacion)
        Me.GroupBox1.Controls.Add(Me.BtnClientes)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 73)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1397, 188)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnCerrarSesion)
        Me.GroupBox2.Location = New System.Drawing.Point(1213, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(184, 106)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(8, 23)
        Me.BtnCerrarSesion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(164, 63)
        Me.BtnCerrarSesion.TabIndex = 2
        Me.BtnCerrarSesion.Text = "Cerrar Sesion"
        Me.BtnCerrarSesion.UseVisualStyleBackColor = True
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.Location = New System.Drawing.Point(697, 23)
        Me.BtnUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(164, 63)
        Me.BtnUsuarios.TabIndex = 2
        Me.BtnUsuarios.Text = "Usuarios"
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        '
        'BtnVentas
        '
        Me.BtnVentas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.Location = New System.Drawing.Point(525, 23)
        Me.BtnVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(164, 63)
        Me.BtnVentas.TabIndex = 3
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'BtnMarketing
        '
        Me.BtnMarketing.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMarketing.Location = New System.Drawing.Point(869, 23)
        Me.BtnMarketing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMarketing.Name = "BtnMarketing"
        Me.BtnMarketing.Size = New System.Drawing.Size(164, 63)
        Me.BtnMarketing.TabIndex = 2
        Me.BtnMarketing.Text = "Marketing"
        Me.BtnMarketing.UseVisualStyleBackColor = True
        '
        'BtnOportunidades
        '
        Me.BtnOportunidades.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOportunidades.Location = New System.Drawing.Point(181, 23)
        Me.BtnOportunidades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnOportunidades.Name = "BtnOportunidades"
        Me.BtnOportunidades.Size = New System.Drawing.Size(164, 63)
        Me.BtnOportunidades.TabIndex = 2
        Me.BtnOportunidades.Text = "Oportunidades"
        Me.BtnOportunidades.UseVisualStyleBackColor = True
        '
        'BtnInventario
        '
        Me.BtnInventario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventario.Location = New System.Drawing.Point(353, 23)
        Me.BtnInventario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(164, 63)
        Me.BtnInventario.TabIndex = 2
        Me.BtnInventario.Text = "Inventario"
        Me.BtnInventario.UseVisualStyleBackColor = True
        '
        'BtnComunicacion
        '
        Me.BtnComunicacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComunicacion.Location = New System.Drawing.Point(1041, 23)
        Me.BtnComunicacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnComunicacion.Name = "BtnComunicacion"
        Me.BtnComunicacion.Size = New System.Drawing.Size(164, 63)
        Me.BtnComunicacion.TabIndex = 1
        Me.BtnComunicacion.Text = "Comunicacion Clientes"
        Me.BtnComunicacion.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Location = New System.Drawing.Point(9, 23)
        Me.BtnClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(164, 63)
        Me.BtnClientes.TabIndex = 0
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(16, 269)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(1397, 270)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.Location = New System.Drawing.Point(9, 94)
        Me.BtnEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(164, 63)
        Me.BtnEmpleados.TabIndex = 4
        Me.BtnEmpleados.Text = "Empleados"
        Me.BtnEmpleados.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1421, 554)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnVentas As Button
    Friend WithEvents BtnMarketing As Button
    Friend WithEvents BtnOportunidades As Button
    Friend WithEvents BtnInventario As Button
    Friend WithEvents BtnComunicacion As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnEmpleados As Button
End Class
