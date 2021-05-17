Public Class eInventario

    Dim ID_Producto, Pro_Cantidad, Pro_disponible As Integer
    Dim Pro_Nombre, Nombre_Proveedor As String
    Dim Pro_preventa, Pro_precompra As Double

    Public Property pID_Producto
        Get
            Return ID_Producto
        End Get
        Set(value)
            ID_Producto = value
        End Set
    End Property

    Public Property pPro_Cantidad
        Get
            Return Pro_Cantidad
        End Get
        Set(value)
            Pro_Cantidad = value
        End Set
    End Property

    Public Property pPro_disponible
        Get
            Return Pro_disponible
        End Get
        Set(value)
            Pro_disponible = value
        End Set
    End Property

    Public Property pPro_Nombre
        Get
            Return Pro_Nombre
        End Get
        Set(value)
            Pro_Nombre = value
        End Set
    End Property

    Public Property pNombre_Proveedor
        Get
            Return Nombre_Proveedor
        End Get
        Set(value)
            Nombre_Proveedor = value
        End Set
    End Property

    Public Property pPro_preventa
        Get
            Return Pro_preventa
        End Get
        Set(value)
            Pro_preventa = value
        End Set
    End Property

    Public Property pPro_precompra
        Get
            Return Pro_precompra
        End Get
        Set(value)
            Pro_precompra = value
        End Set
    End Property


    Public Sub New() 'Constructor Vacio
    End Sub




    Public Sub New(ID_Producto As Integer, Pro_Cantidad As Integer,
                   Pro_disponible As Integer, Pro_Nombre As String,
                   Nombre_Proveedor As String, Pro_preventa As Double,
                   Pro_precompra As Double
                   ) 'Constructor Full

        pID_Producto = ID_Producto
        pPro_Cantidad = Pro_Cantidad
        pPro_disponible = Pro_disponible
        pPro_Nombre = Pro_Nombre
        pNombre_Proveedor = Nombre_Proveedor
        pPro_preventa = Pro_preventa
        pPro_precompra = Pro_precompra

    End Sub

End Class
