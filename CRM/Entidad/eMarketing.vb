Public Class eMarketing

    Dim ID_Marketing, ID_Usuario, ID_Producto, ID_Cliente As Integer
    Dim Estrategia, Descripcion As String

    Public Property pID_Marketing
        Get
            Return ID_Marketing
        End Get
        Set(value)
            ID_Marketing = value
        End Set
    End Property

    Public Property pID_Usuario
        Get
            Return ID_Usuario
        End Get
        Set(value)
            ID_Usuario = value
        End Set
    End Property

    Public Property pID_Producto
        Get
            Return ID_Producto
        End Get
        Set(value)
            ID_Producto = value
        End Set
    End Property

    Public Property pID_Cliente
        Get
            Return ID_Cliente
        End Get
        Set(value)
            ID_Cliente = value
        End Set
    End Property

    Public Property pEstrategia
        Get
            Return Estrategia
        End Get
        Set(value)
            Estrategia = value
        End Set
    End Property

    Public Property pDescripcion
        Get
            Return Descripcion
        End Get
        Set(value)
            Descripcion = value
        End Set
    End Property


    Public Sub New() 'Constructor Vacio
    End Sub




    Public Sub New(ID_Marketing As Integer, ID_Usuario As Integer, ID_Producto As Integer, ID_Cliente As Integer,
                   Estrategia As String, Descripcion As String) 'Constructor Full

        pID_Marketing = ID_Marketing
        pID_Usuario = ID_Usuario
        pID_Producto = ID_Producto
        pID_Cliente = ID_Cliente
        pEstrategia = Estrategia
        pDescripcion = Descripcion


    End Sub

End Class
