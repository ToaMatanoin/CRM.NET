Public Class eEncargo

    Dim ID_Encargo, ID_Factura As Integer
    Dim Enc_Entregado, Descripcion, Fecha_Encargo, Fecha_Entrega As String

    Public Property pID_Encargo
        Get
            Return ID_Encargo
        End Get
        Set(value)
            ID_Encargo = value
        End Set
    End Property

    Public Property pID_Factura
        Get
            Return ID_Factura
        End Get
        Set(value)
            ID_Factura = value
        End Set
    End Property

    Public Property pEnc_Entregado
        Get
            Return Enc_Entregado
        End Get
        Set(value)
            Enc_Entregado = value
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

    Public Property pFecha_Encargo
        Get
            Return Fecha_Encargo
        End Get
        Set(value)
            Fecha_Encargo = value
        End Set
    End Property

    Public Property pFecha_Entrega
        Get
            Return Fecha_Entrega
        End Get
        Set(value)
            Fecha_Entrega = value
        End Set
    End Property

    Public Sub New() 'Constructor Vacio
    End Sub



    Public Sub New(ID_Encargo As Integer, ID_Factura As Integer, Enc_Entregado As String,
                   Descripcion As String, Fecha_Encargo As String, Fecha_Entrega As String) 'Constructor Full

        pID_Encargo = ID_Encargo
        pID_Factura = ID_Factura
        pEnc_Entregado = Enc_Entregado
        pDescripcion = Descripcion
        pFecha_Encargo = Fecha_Encargo
        pFecha_Entrega = Fecha_Entrega


    End Sub

End Class
