Public Class eVentas

    Dim ID_Venta, ID_Usuario, ID_Cliente, ID_Producto, Ven_CantVendida, Num_venta As Integer
    Dim Ven_Fecha As String
    Dim Ven_subtotal As Double

    Public Property pID_Venta
        Get
            Return ID_Venta
        End Get
        Set(value)
            ID_Venta = value
        End Set
    End Property

    Public Property pNum_venta
        Get
            Return Num_venta
        End Get
        Set(value)
            Num_venta = value
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

    Public Property pID_Cliente
        Get
            Return ID_Cliente
        End Get
        Set(value)
            ID_Cliente = value
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

    Public Property pVen_CantVendida
        Get
            Return Ven_CantVendida
        End Get
        Set(value)
            Ven_CantVendida = value
        End Set
    End Property

    Public Property pVen_Fecha
        Get
            Return Ven_Fecha
        End Get
        Set(value)
            Ven_Fecha = value
        End Set
    End Property

    Public Property pVen_subtotal
        Get
            Return Ven_subtotal
        End Get
        Set(value)
            Ven_subtotal = value
        End Set
    End Property

    Public Sub New() 'Constructor Vacio
    End Sub


    Public Sub New(ID_Venta As Integer, ID_Usuario As Integer,
                   ID_Cliente As Integer, ID_Producto As Integer,
                   Ven_CantVendida As Integer, Ven_Fecha As String,
                   Ven_subtotal As Double, Num_venta As Integer
                   ) 'Constructor Full

        pID_Venta = ID_Venta
        pID_Usuario = ID_Usuario
        pID_Cliente = ID_Cliente
        pID_Producto = ID_Producto
        pVen_CantVendida = Ven_CantVendida
        pVen_Fecha = Ven_Fecha
        pVen_subtotal = Ven_subtotal
        pNum_venta = Num_venta

    End Sub

End Class
