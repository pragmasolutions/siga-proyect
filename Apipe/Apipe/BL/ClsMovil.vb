Public Class ClsMovil
    Inherits ClsMain

#Region "Objetos"
    Private _Movil As movil
    Private _Chofer As chofer
    Private _ChoferMovil As chofer_movil

    Public Property Movil As movil
        Get
            If _Movil Is Nothing Then
                _Movil = New movil
            End If
            Return _Movil
        End Get
        Set(ByVal value As movil)
            _Movil = value
        End Set
    End Property
    Public Property Chofer As chofer
        Get
            If _Chofer Is Nothing Then
                _Chofer = New chofer
            End If
            Return _Chofer
        End Get
        Set(ByVal value As chofer)
            _Chofer = value
        End Set
    End Property
    Public Property ChoferMovil As chofer_movil
        Get
            If _ChoferMovil Is Nothing Then
                _ChoferMovil = New chofer_movil
            End If
            Return _ChoferMovil
        End Get
        Set(ByVal value As chofer_movil)
            _ChoferMovil = value
        End Set
    End Property

#End Region
#Region "Listas"
    Private _lst_ChoferMovil As List(Of chofer_movil)

    Public Property lst_ChoferMovil As List(Of chofer_movil)
        Get
            If _lst_ChoferMovil Is Nothing Then
                _lst_ChoferMovil = New List(Of chofer_movil)
            End If
            Return _lst_ChoferMovil
        End Get
        Set(ByVal value As List(Of chofer_movil))
            _lst_ChoferMovil = value
        End Set
    End Property
#End Region
#Region "Funciones"
#Region "Movil"

#End Region
#Region "Chofer"

#End Region
#Region "Chofer_Movil"
    Public Sub CargarChoferMovil(ByVal soloVigentes As Boolean, ByVal filtrarActivos As String)
        lst_ChoferMovil = chofer_movil.FillListByFilter(getConn, soloVigentes, filtrarActivos)
    End Sub
    Public Sub PersistirChoferMovil()
        With ChoferMovil
            If .EstadoFila = "D" Then
                .Delete(getConn, gettrn)
            Else
                .InsertUpdate(getConn, gettrn)
            End If
        End With
    End Sub
#End Region
#End Region
End Class
