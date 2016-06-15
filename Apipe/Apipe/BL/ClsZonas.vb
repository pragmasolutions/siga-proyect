Public Class ClsZonas
    Inherits ClsMain
#Region "Barrios"
    Private _barrio As barrio
    Public Property Barrio() As barrio
        Get
            If _barrio Is Nothing Then
                _barrio = New barrio
            End If
            Return _barrio
        End Get
        Set(ByVal value As barrio)
            _barrio = value
        End Set
    End Property

    Private _LstBarrio As List(Of barrio)
    Public Property LstBarrio As List(Of barrio)
        Get
            If _LstBarrio Is Nothing Then
                _LstBarrio = New List(Of barrio)
            End If
            Return _LstBarrio
        End Get
        Set(value As List(Of barrio))
            _LstBarrio = value
        End Set
    End Property

    Public Sub FillByBarrios(Nombre As String)
        If Nombre.Length = 0 Then
            LstBarrio = barrio.FillList(getConn)
        Else
            LstBarrio = (From b As barrio In barrio.FillList(getConn) Where b.nombre.ToLower.Contains(Nombre.ToLower)).ToList
        End If
    End Sub

    Public Sub FillBarriobyBarrio(ByVal id As Integer)
        '  If id <> 0 Then
        Barrio.StoreFillBybarrio(id, getConn)
        ' End If
    End Sub

    Public Sub FillBarrioByLocalidad(ByVal Id As Integer)
        If Id <> 0 Then
            LstBarrio = Barrio.StoreFillListByLocalidad(Id, getConn) ' b As barrio In Barrio.FillListByLocalidad(Id, getConn) Where b.localidad_id = Id).ToList
        End If
    End Sub

    Public Sub PreservarBarrio()
        Barrio.id = Barrio.Insert(getConn, gettrn)
    End Sub

    Sub FillByBarrios()
        Throw New NotImplementedException
    End Sub
#End Region

#Region "Provincia"
    Private _Provincia As provincia
    Public Property Provincia() As provincia
        Get
            If _Provincia Is Nothing Then
                _Provincia = New Provincia
            End If
            Return _Provincia
        End Get
        Set(ByVal value As provincia)
            _Provincia = value
        End Set
    End Property

    Private _LstProvincia As List(Of provincia)
    Public Property LstProvincia As List(Of provincia)
        Get
            If _LstProvincia Is Nothing Then
                _LstProvincia = New List(Of Provincia)
            End If
            Return _LstProvincia
        End Get
        Set(ByVal value As List(Of provincia))
            _LstProvincia = value
        End Set
    End Property

    Public Sub FillByProvincia(ByVal Nombre As String)
        If Nombre.Length = 0 Then
            LstProvincia = Provincia.StoreFillList(getConn)
        Else
            LstProvincia = Provincia.StoreFillList(getConn)
        End If
    End Sub

    Public Sub FillProvinciaByProvincia(ByVal id As Integer)
        If id <> 0 Then
            Provincia.StoreFillByprovincia(id, getConn)
        End If
    End Sub

    Public Sub PreservarProvincia()
        Provincia.Insert(getConn, gettrn)
    End Sub

    Sub FillByProvincia()
        Throw New NotImplementedException
    End Sub

#End Region

#Region "Localidad"
    Private _localidad As localidad
    Public Property localidad() As localidad
        Get
            If _localidad Is Nothing Then
                _localidad = New localidad
            End If
            Return _localidad
        End Get
        Set(ByVal value As localidad)
            _localidad = value
        End Set
    End Property

    Private _Lstlocalidad As List(Of localidad)
    Public Property Lstlocalidad As List(Of localidad)
        Get
            If _Lstlocalidad Is Nothing Then
                _Lstlocalidad = New List(Of localidad)
            End If
            Return _Lstlocalidad
        End Get
        Set(ByVal value As List(Of localidad))
            _Lstlocalidad = value
        End Set
    End Property

    Public Sub FillBylocalidad(ByVal Nombre As String)
        If Nombre.Length = 0 Then
            Lstlocalidad = localidad.FillList(getConn)
        Else
            Lstlocalidad = (From b As localidad In localidad.FillList(getConn) Where b.nombre.ToLower.Contains(Nombre.ToLower)).ToList
        End If
    End Sub

    Public Sub FillLocalidadByLocalidad(ByVal id As Integer)
        If id <> 0 Then
            localidad.StoreFillBylocalidad(id, getConn)
        End If
    End Sub

    Public Sub Preservarlocalidad()
        localidad.Insert(getConn, gettrn)
    End Sub

    Sub FillBylocalidad()
        Throw New NotImplementedException
    End Sub

    Public Sub FillListByProvincia(ByVal id As Integer)
        If id = 0 Then
            Lstlocalidad = New List(Of localidad) '() localidad.FillListByProvincia(id, getConn)
        Else
            Lstlocalidad = localidad.StoreFillListByProvincia(id, getConn)
        End If
    End Sub
#End Region

#Region "Calle"
    'Private _domicilio As domicilio
    'Public Property domicilio() As domicilio
    '    Get
    '        If _domicilio Is Nothing Then
    '            _domicilio = New domicilio
    '        End If
    '        Return _domicilio
    '    End Get
    '    Set(ByVal value As domicilio)
    '        _domicilio = value
    '    End Set
    'End Property


    Private _Lstcalle As List(Of calle)
    Public Property Lstcalle As List(Of calle)
        Get
            If _Lstcalle Is Nothing Then
                _Lstcalle = New List(Of calle)
            End If
            Return _Lstcalle
        End Get
        Set(ByVal value As List(Of calle))
            _Lstcalle = value
        End Set
    End Property

    Public Sub FillListCalle()
        Lstcalle = calle.FillList(getConn)
    End Sub

#End Region
End Class
