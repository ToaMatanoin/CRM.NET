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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Aquamarine
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1048, 43)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1048, 139)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.Location = New System.Drawing.Point(136, 76)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(123, 51)
        Me.BtnEmpleados.TabIndex = 4
        Me.BtnEmpleados.Text = "Empleados"
        Me.BtnEmpleados.UseVisualStyleBackColor = True
        Me.BtnEmpleados.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnCerrarSesion)
        Me.GroupBox2.Location = New System.Drawing.Point(910, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 86)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(6, 19)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(123, 51)
        Me.BtnCerrarSesion.TabIndex = 2
        Me.BtnCerrarSesion.Text = "Cerrar Sesion"
        Me.BtnCerrarSesion.UseVisualStyleBackColor = True
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.Location = New System.Drawing.Point(6, 76)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(123, 51)
        Me.BtnUsuarios.TabIndex = 2
        Me.BtnUsuarios.Text = "Usuarios"
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        Me.BtnUsuarios.Visible = False
        '
        'BtnVentas
        '
        Me.BtnVentas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.Location = New System.Drawing.Point(394, 19)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(123, 51)
        Me.BtnVentas.TabIndex = 3
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'BtnMarketing
        '
        Me.BtnMarketing.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMarketing.Location = New System.Drawing.Point(523, 19)
        Me.BtnMarketing.Name = "BtnMarketing"
        Me.BtnMarketing.Size = New System.Drawing.Size(123, 51)
        Me.BtnMarketing.TabIndex = 2
        Me.BtnMarketing.Text = "Marketing"
        Me.BtnMarketing.UseVisualStyleBackColor = True
        '
        'BtnOportunidades
        '
        Me.BtnOportunidades.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOportunidades.Location = New System.Drawing.Point(136, 19)
        Me.BtnOportunidades.Name = "BtnOportunidades"
        Me.BtnOportunidades.Size = New System.Drawing.Size(123, 51)
        Me.BtnOportunidades.TabIndex = 2
        Me.BtnOportunidades.Text = "Oportunidades"
        Me.BtnOportunidades.UseVisualStyleBackColor = True
        '
        'BtnInventario
        '
        Me.BtnInventario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventario.Location = New System.Drawing.Point(265, 19)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(123, 51)
        Me.BtnInventario.TabIndex = 2
        Me.BtnInventario.Text = "Inventario"
        Me.BtnInventario.UseVisualStyleBackColor = True
        '
        'BtnComunicacion
        '
        Me.BtnComunicacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComunicacion.Location = New System.Drawing.Point(652, 19)
        Me.BtnComunicacion.Name = "BtnComunicacion"
        Me.BtnComunicacion.Size = New System.Drawing.Size(123, 51)
        Me.BtnComunicacion.TabIndex = 1
        Me.BtnComunicacion.Text = "Comunicacion Clientes"
        Me.BtnComunicacion.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Location = New System.Drawing.Point(7, 19)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(123, 51)
        Me.BtnClientes.TabIndex = 0
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(12, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1048, 234)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
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
