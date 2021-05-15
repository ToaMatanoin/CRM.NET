Public Class eUsuarios
    Dim ID_Usuario, ID_Empleado As Integer
    Dim Usu_Nombre, Usu_Contrasenha, Usu_Cargo As String

    Public Property pID_Usuario
        Get
            Return ID_Usuario
        End Get
        Set(value)
            ID_Usuario = value
        End Set
    End Property

    Public Property pUsu_Nombre
        Get
            Return Usu_Nombre
        End Get
        Set(value)
            Usu_Nombre = value
        End Set
    End Property

    Public Property pUsu_Contrasenha
        Get
            Return Usu_Contrasenha
        End Get
        Set(value)
            Usu_Contrasenha = value
        End Set
    End Property

    Public Property pUsu_Cargo
        Get
            Return Usu_Cargo
        End Get
        Set(value)
            Usu_Cargo = value
        End Set
    End Property
    Public Property pID_Empleado
        Get
            Return ID_Empleado
        End Get
        Set(value)
            ID_Empleado = value
        End Set
    End Property
    Public Sub New() 'Constructor Vacio
    End Sub

    Public Sub New(ID_Usuario As Integer, Usu_Nombre As String,
                   Usu_Contrasenha As String, Usu_Cargo As String,
                   ID_Empleado As Integer) 'Constructor Full

        pID_Usuario = ID_Usuario
        pUsu_Nombre = Usu_Nombre
        pUsu_Contrasenha = Usu_Contrasenha
        pUsu_Cargo = Usu_Cargo
        pID_Empleado = ID_Empleado

    End Sub
End Class
