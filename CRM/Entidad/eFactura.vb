Public Class eFactura

    Dim ID_Factura, ID_Venta, Cli_TelEmpresa, Num_venta As Integer
    Dim Fac_Descuento, Fac_Impuesto, Fac_Total As Double
    Dim Fac_RTN, Tp_Venta As String


    Public Property pNum_venta
        Get
            Return Num_venta
        End Get
        Set(value)
            Num_venta = value
        End Set
    End Property
    Public Property pTP_Venta
        Get
            Return Tp_Venta
        End Get
        Set(value)
            Tp_Venta = value
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

    Public Property pID_Venta
        Get
            Return ID_Venta
        End Get
        Set(value)
            ID_Venta = value
        End Set
    End Property

    Public Property pCli_TelEmpresa
        Get
            Return Cli_TelEmpresa
        End Get
        Set(value)
            Cli_TelEmpresa = value
        End Set
    End Property

    Public Property pFac_Descuento
        Get
            Return Fac_Descuento
        End Get
        Set(value)
            Fac_Descuento = value
        End Set
    End Property

    Public Property pFac_Impuesto
        Get
            Return Fac_Impuesto
        End Get
        Set(value)
            Fac_Impuesto = value
        End Set
    End Property

    Public Property pFac_Total
        Get
            Return Fac_Total
        End Get
        Set(value)
            Fac_Total = value
        End Set
    End Property

    Public Property pFac_RTN
        Get
            Return Fac_RTN
        End Get
        Set(value)
            Fac_RTN = value
        End Set
    End Property

    Public Sub New() 'Constructor Vacio
    End Sub



    Public Sub New(ID_Factura As Integer, ID_Venta As Integer, Tp_Venta As String,
                   Fac_Descuento As Double, Fac_Impuesto As Double,
                   Fac_RTN As String, Fac_Total As Double, Num_venta As Integer) 'Constructor Full

        pID_Factura = ID_Factura
        pID_Venta = ID_Venta
        pTP_Venta = Tp_Venta
        pFac_Descuento = Fac_Descuento
        pFac_Impuesto = Fac_Impuesto
        pFac_RTN = Fac_RTN
        pFac_Total = Fac_Total
        pNum_venta = Num_venta

    End Sub




End Class
