Public Class eEmpleados
    Dim ID_Empleado, Emp_Telefono As Integer
    Dim Emp_Nombre, Emp_Email, Emp_Direccion, Emp_Cargo As String

    Public Property pID_Empleado
        Get
            Return ID_Empleado
        End Get
        Set(value)
            ID_Empleado = value
        End Set
    End Property

    Public Property pEmp_Nombre
        Get
            Return Emp_Nombre
        End Get
        Set(value)
            Emp_Nombre = value
        End Set
    End Property

    Public Property pEmp_Telefono
        Get
            Return Emp_Telefono
        End Get
        Set(value)
            Emp_Telefono = value
        End Set
    End Property

    Public Property pEmp_Email
        Get
            Return Emp_Email
        End Get
        Set(value)
            Emp_Email = value
        End Set
    End Property

    Public Property pEmp_Direccion
        Get
            Return Emp_Direccion
        End Get
        Set(value)
            Emp_Direccion = value
        End Set
    End Property

    Public Property pEmp_Cargo
        Get
            Return Emp_Cargo
        End Get
        Set(value)
            Emp_Cargo = value
        End Set
    End Property

    Public Sub New() 'Constructor Vacio
    End Sub

    Public Sub New(ID_Empleado As Integer, Emp_Nombre As String,
                   Emp_Email As String, Emp_Direccion As String,
                   Emp_Cargo As String, Emp_Telefono As Integer) 'Constructor Full

        pID_Empleado = ID_Empleado
        pEmp_Nombre = Emp_Nombre
        pEmp_Telefono = Emp_Telefono
        pEmp_Email = Emp_Email
        pEmp_Direccion = Emp_Direccion
        pEmp_Cargo = Emp_Cargo
    End Sub
End Class
