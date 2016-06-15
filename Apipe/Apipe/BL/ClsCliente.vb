Public Class ClsClientes
    Inherits ClsMain
#Region "Clientes"
    Private _cliente As cliente
    Public Property cliente() As cliente
        Get
            If _cliente Is Nothing Then
                _cliente = New cliente
            End If
            Return _cliente
        End Get
        Set(ByVal value As cliente)
            _cliente = value
        End Set
    End Property

    Private _LstCliente As List(Of cliente)
    Public Property LstCliente As List(Of cliente)
        Get
            If _LstCliente Is Nothing Then
                _LstCliente = New List(Of cliente)
            End If
            Return _LstCliente
        End Get
        Set(ByVal value As List(Of cliente))
            _LstCliente = value
        End Set
    End Property

    Public Sub FillListCliente()
        LstCliente = cliente.FillList(getConn)
    End Sub
    Public Sub FillListClienteByEntidad(ByVal id As Integer)
        If id <> 0 Then
            LstCliente = cliente.FillListByEntidad(id, getConn)
        End If
    End Sub

    Public Sub FillByCliente(ByVal id As Integer)
        cliente.StoreFillBycliente(id, getConn)

    End Sub

    Public Sub PreservarCliente(ByVal entidadid As Integer, ByVal categoriaid As Integer)
        'cliente.Insert(getConn, gettrn)
        cliente.ClienteNuevo(entidadid, categoriaid, getConn, gettrn)
    End Sub
    Public Sub ModificarCliente()
        cliente.Update(getConn, gettrn)
    End Sub

#End Region

#Region "Entidad"
    Private _ultimaEntidad As Integer
    Public Property ultimaEntidad As Integer
        Get
            Return _ultimaEntidad
        End Get
        Set(value As Integer)
            _ultimaEntidad = value
        End Set
    End Property
    Private _entidad As entidad
    Public Property entidad() As entidad
        Get
            If _entidad Is Nothing Then
                _entidad = New entidad
            End If
            Return _entidad
        End Get
        Set(ByVal value As entidad)
            _entidad = value
        End Set
    End Property

    Private _LstEntidad As List(Of entidad)
    Public Property LstEntidad As List(Of entidad)
        Get
            If _LstEntidad Is Nothing Then
                _LstEntidad = New List(Of entidad)
            End If
            Return _LstEntidad
        End Get
        Set(ByVal value As List(Of entidad))
            _LstEntidad = value
        End Set
    End Property

    Public Sub FillEntidadByEntidad(ByVal id As Integer)
        If id <> 0 Then
            entidad.StoreFillByentidad(id, getConn)
        End If
    End Sub

    Public Sub FillListEntidad()
        LstEntidad = entidad.FillList(getConn)
    End Sub
    Public Sub FillListLastEntidad()
        LstEntidad = entidad.StoreFillListLast(getConn)
    End Sub

    Public Function BuscarEntidad(ByVal apellido As String) As List(Of entidad)
        Return entidad.FillListByApellido(apellido, getConn)
    End Function

    Public Sub PreservarEntidad(ByVal apellido As String, ByVal nombre As String, ByVal obserrvacion As String)
        'entidad.Insert(getConn, gettrn)
        entidad.EntidadNueva(apellido, nombre, observacion, getConn, gettrn)
    End Sub

    Public Sub ModificarEntidad()
        entidad.Update(getConn, gettrn)
    End Sub

#End Region

#Region "Telefono"
    Private _Telefono As telefono
    Public Property Telefono() As telefono
        Get
            If _Telefono Is Nothing Then
                _Telefono = New telefono
            End If
            Return _Telefono
        End Get
        Set(ByVal value As telefono)
            _Telefono = value
        End Set
    End Property

    Private _LstTelefono As List(Of telefono)
    Public Property LstTelefono As List(Of telefono)
        Get
            If _LstTelefono Is Nothing Then
                _LstTelefono = New List(Of telefono)
            End If
            Return _LstTelefono
        End Get
        Set(ByVal value As List(Of telefono))
            _LstTelefono = value
        End Set
    End Property

    Public Sub FillTelefonoByNumeroYCarac(ByVal numero As String, ByVal caracteristica As String)
        If numero <> 0 Then
            Telefono.StoreFillByNumeroYCaracteristica(numero, caracteristica, getConn)
        End If
    End Sub

    Public Sub FillBytelefono(ByVal id As Integer)
        If id <> 0 Then
            Telefono.StoreFillBytelefono(id, getConn)
        End If
    End Sub

    Public Sub FillTelefonobyEntidad(ByVal id As Integer)
        LstTelefono = Telefono.StoreFillListByEntidad(id, getConn)
    End Sub
    Public Sub FillTelefonobyEntidad1(ByVal id As Integer)
        Telefono = Telefono.StoreFillListByEntidad(id, getConn).First
    End Sub
    Public Sub FillListTelefono()
        LstTelefono = Telefono.FillList(getConn)
    End Sub

    Public Sub FillListTelefonoNombre()
        LstTelefono = Telefono.FillListNombre(getConn)
    End Sub
    Public Sub PreservarTelefono(ByVal tipo As String, ByVal codarea As String, ByVal numero As String, ByVal entidadid As Integer)
        'Telefono.Insert(getConn, gettrn)
        Telefono.TelefonoNuevo(tipo, codarea, numero, entidadid, getConn, gettrn)
    End Sub

    Sub FillByTelefono()
        Throw New NotImplementedException
    End Sub

    Public Function BuscarTelefonos(ByVal nroTel As String, ByVal codArea As String) As List(Of telefono)
        Return Telefono.FillListByFilter(ClsVariableSesion.Instancia.getConn, nroTel, codArea)
    End Function


    Public Sub BuscarTelefonosPorEntidad(ByVal entidad As Integer)
        LstTelefono = Telefono.StoreFillListByEntidad(entidad, getConn)
    End Sub

#End Region

#Region "Categoria de Cliente"

    Private _Categoria As cliente_categoria
    Public Property Categoria() As cliente_categoria
        Get
            If _Categoria Is Nothing Then
                _Categoria = New cliente_categoria
            End If
            Return _Categoria
        End Get
        Set(ByVal value As cliente_categoria)
            _Categoria = value
        End Set
    End Property

    Private _Lstcategoria As List(Of cliente_categoria)
    Public Property Lstcategoria As List(Of cliente_categoria)
        Get
            If _Lstcategoria Is Nothing Then
                _Lstcategoria = New List(Of cliente_categoria)
            End If
            Return _Lstcategoria
        End Get
        Set(ByVal value As List(Of cliente_categoria))
            _Lstcategoria = value
        End Set
    End Property

    Public Sub FillByCliente_Categoria(ByVal id As Integer)
        If id <> 0 Then
            Categoria.StoreFillByclientecategoria(id, getConn)
        End If
    End Sub

    Public Sub FillListCategoriaCliente()
        Lstcategoria = cliente_categoria.StoreFillList(getConn)
    End Sub
#End Region

#Region "Domicilio"
    Private _domicilio As domicilio
    Public Property domicilio() As domicilio
        Get
            If _domicilio Is Nothing Then
                _domicilio = New domicilio
            End If
            Return _domicilio
        End Get
        Set(ByVal value As domicilio)
            _domicilio = value
        End Set
    End Property

    Private _Lstdomicilio As List(Of domicilio)
    Public Property Lstdomicilio As List(Of domicilio)
        Get
            If _Lstdomicilio Is Nothing Then
                _Lstdomicilio = New List(Of domicilio)
            End If
            Return _Lstdomicilio
        End Get
        Set(ByVal value As List(Of domicilio))
            _Lstdomicilio = value
        End Set
    End Property

    Sub FillListdomicilio()
        ' Throw New NotImplementedException
        Lstdomicilio = domicilio.FillList(getConn)
    End Sub

    Public Sub FillDomicilioBydomicilio(ByVal id As Integer)
        'llena un lst con un domicilio y recibe un id como parametro
        If id = 0 Then
            Lstdomicilio = domicilio.FillList(getConn)
        Else
            '(From b As domicilio In domicilio.fillbydomicilio(getConn) Where b.id = id).ToList
            domicilio.FillBydomicilio(id, getConn)
        End If
    End Sub

    Public Sub FillUltimoDomicilio()
        domicilio = domicilio.UltimoDomicilio(getConn)
        End Sub

    Public Sub Preservardomicilio(ByVal calle As String, ByVal numero As Integer, ByVal tipo As String,
                                   ByVal descripcion As String, ByVal interseccion As String, ByVal observacion As String,
                                   ByVal barrioId As Integer, ByVal zona As Integer, ByVal telefono As Integer)
        'domicilio.Insert(getConn, gettrn)
        domicilio.id = domicilio.DomicilioNuevo(calle, numero, tipo, descripcion, interseccion, observacion, barrioId, zona, telefono, getConn, gettrn)
    End Sub

    Public Sub ActualizarDomicilio(ByVal id As Integer, ByVal calle As String, ByVal numero As Integer, ByVal tipo As String,
                                   ByVal descripcion As String, ByVal interseccion As String, ByVal observacion As String,
                                   ByVal barrioId As Integer, ByVal zona As Integer)
        domicilio.ModificarDomicilio(id, calle, numero, tipo, descripcion, interseccion, observacion, barrioId, zona, getConn, gettrn)
    End Sub

    Public Sub ActualizarEstadoDomicilio(ByVal id As Integer, ByVal estado As Integer)
        domicilio.ModificarEstadoDomicilio(id, estado, getConn, gettrn)
    End Sub

#End Region

#Region "Telefono_domicilio"
    Private _telefono_domicilio As telefono_domicilio
    Public Property Telefono_Domicilio() As telefono_domicilio
        Get
            If _telefono_domicilio Is Nothing Then
                _telefono_domicilio = New telefono_domicilio
            End If
            Return _telefono_domicilio
        End Get
        Set(ByVal value As telefono_domicilio)
            _telefono_domicilio = value
        End Set
    End Property

    Private _LstdomicilioXTelefono As List(Of telefono_domicilio)
    Public Property LstDomicilioXTelefono As List(Of telefono_domicilio)
        Get
            If _LstdomicilioXTelefono Is Nothing Then
                _LstdomicilioXTelefono = New List(Of telefono_domicilio)
            End If
            Return _LstdomicilioXTelefono
        End Get
        Set(ByVal value As List(Of telefono_domicilio))
            _LstdomicilioXTelefono = value
        End Set
    End Property

    Public Sub FillDomiciliobyTelefono(ByVal id As Integer)
        If id = 0 Then
            LstDomicilioXTelefono = Telefono_Domicilio.FillListByTelefono(id, getConn)
        Else
            LstDomicilioXTelefono = (From t As telefono_domicilio In Telefono_Domicilio.FillListByTelefono(id, getConn) Where t.telefono_id = id Order By t.prioridad Descending).ToList
        End If
    End Sub
    Public Sub FillDomiciliobyTelefonoBaja(ByVal id As Integer)
        If id = 0 Then
            LstDomicilioXTelefono = New List(Of telefono_domicilio)() ' Telefono_Domicilio.FillListByTelefonoBaja(id, getConn)
        Else
            LstDomicilioXTelefono = Telefono_Domicilio.StoreFillListByTelefonoBaja(id, getConn) ' (From t As telefono_domicilio In Telefono_Domicilio.FillListByTelefonoBaja(id, getConn) Where t.telefono_id = id Order By t.prioridad Descending).ToList
        End If
    End Sub
    Public Sub FillTelefonobyDomicilio(ByVal id As Integer)
        If id = 0 Then
            LstDomicilioXTelefono = Telefono_Domicilio.FillListByDomicilio(id, getConn)
        Else
            LstDomicilioXTelefono = (From t As telefono_domicilio In Telefono_Domicilio.FillListByDomicilio(id, getConn) Where t.telefono_id = id Order By t.prioridad Descending).ToList
        End If
    End Sub

    Public Sub FillListDomxTel()
        LstDomicilioXTelefono = Telefono_Domicilio.FillList(getConn)
    End Sub

    Public Sub PreservarTelefonoXDomicilio()
        Telefono_Domicilio.Insert(getConn, gettrn)
    End Sub
    Public Sub ModificarTelefonoXDomicilio(ByVal domicilio As Integer, ByVal telefono As Integer, ByVal telefonista As Integer)
        ' Telefono_Domicilio.UpdateBaja(getConn, gettrn)
        Telefono_Domicilio.StoreBajaTelefonoDomicilio(domicilio, telefono, telefonista, getConn, gettrn)
    End Sub
#End Region

#Region "Pedidos"
    Private _Pedido As pedido
    Public Property Pedido() As pedido
        Get
            If _Pedido Is Nothing Then
                _Pedido = New pedido
            End If
            Return _Pedido
        End Get
        Set(ByVal value As pedido)
            _Pedido = value
        End Set
    End Property

    Private _LstPedido As List(Of pedido)
    Public Property LstPedido As List(Of pedido)
        Get
            If _LstPedido Is Nothing Then
                _LstPedido = New List(Of pedido)
            End If
            Return _LstPedido
        End Get
        Set(ByVal value As List(Of pedido))
            _LstPedido = value
        End Set
    End Property

    Public Sub CargarPedidosxTelefono(ByVal id_telefono As Integer)
        If id_telefono = 0 Then
            '  LstPedido = Pedido.FillListByTelefono(id_telefono, getConn)
            LstPedido = New List(Of pedido)()
        Else
            LstPedido = Pedido.StoreFillListByTelefono5(id_telefono, getConn)
        End If
    End Sub
    Public Sub CargarPedidosxTelefono50(ByVal id_telefono As Integer)
        If id_telefono = 0 Then
            LstPedido = New List(Of pedido)
        Else
            LstPedido = Pedido.StoreFillListByTelefono50(id_telefono, getConn)
        End If
    End Sub

    Public Sub FillPedidoByPedido(ByVal id As Integer)
        If id <> 0 Then
            Pedido.StoreFillBypedido(id, getConn)
        End If
    End Sub

    'Public Sub PreservarPedidoNormal()
    '    Pedido.Insert(getConn, gettrn)
    'End Sub
    Public Sub GenerarPedido(ByVal clientenya As String, ByVal fechahoraviaje As DateTime, ByVal obs As String,
                             ByVal usuarioid As Integer, ByVal categoriaid As Integer, ByVal dom As Integer,
                             ByVal tel As Integer)
        Pedido.GenerarPedido(clientenya, fechahoraviaje, obs, usuarioid, categoriaid, dom, tel, getConn, gettrn)
    End Sub
    Public Sub GenerarPedidoCQV(ByVal clientenya As String, ByVal fechahoraviaje As DateTime, ByVal obs As String,
                            ByVal usuarioid As Integer, ByVal categoriaid As Integer, ByVal dom As Integer,
                            ByVal tel As Integer, ByVal idCQV As Integer, ByVal Estado As String, ByVal movil As Integer)
        Pedido.GenerarPedidoCQV(clientenya, fechahoraviaje, obs, usuarioid, categoriaid, dom, tel, idCQV, Estado, movil, getConn, gettrn)
    End Sub
    Public Sub CancelarPedido(ByVal pedido_id As Integer, ByVal telefonista As Integer)
        Pedido.CancelarPedido(getConn, gettrn, pedido_id, telefonista)
    End Sub
    Public Sub CancelarPedidoCQV(ByVal pedido_id As Integer, ByVal telefonista As Integer, ByVal movilNro As Integer)
        Pedido.CancelarPedidoCQV(getConn, gettrn, pedido_id, telefonista, movilNro)
    End Sub
    Public Sub ModificarPedido(ByVal fechahoraviaje As DateTime, ByVal pedido_id As Integer, ByVal telefonista As Integer)
        'Pedido.Update(getConn, gettrn)
        Pedido.ModificarPedido(fechahoraviaje, getConn, gettrn, pedido_id, telefonista)
    End Sub

    Public Sub ModificarPedidoObservaciones(ByVal observaciones As String, ByVal pedido_id As Integer, ByVal telefonista As Integer)
        ' Pedido.UpdateObservaciones(getConn, gettrn)
        Pedido.ModificarPedidoObservaciones(observaciones, getConn, gettrn, pedido_id, telefonista)
    End Sub
    Public Sub FillListPedido()
        LstPedido = Pedido.FillList(getConn)
    End Sub

#End Region

#Region "Pedido Categoria"

    Private _PedidoCategoria As pedido_categoria
    Public Property PedidoCategoria() As pedido_categoria
        Get
            If _PedidoCategoria Is Nothing Then
                _PedidoCategoria = New pedido_categoria
            End If
            Return _PedidoCategoria
        End Get
        Set(ByVal value As pedido_categoria)
            _PedidoCategoria = value
        End Set
    End Property

    Private _LstPedidoCategoria As List(Of pedido_categoria)
    Public Property LstPedidoCategoria() As List(Of pedido_categoria)
        Get
            If _LstPedidoCategoria Is Nothing Then
                _LstPedidoCategoria = New List(Of pedido_categoria)
            End If
            Return _LstPedidoCategoria
        End Get
        Set(ByVal value As List(Of pedido_categoria))
            _LstPedidoCategoria = value
        End Set
    End Property

    Public Sub FillListPedidoCategoria()
        LstPedidoCategoria = pedido_categoria.StoreFillList(getConn)
    End Sub
#End Region

#Region "Reclamos"
    Private _Reclamo As reclamo
    Public Property Reclamo() As reclamo
        Get
            If _Reclamo Is Nothing Then
                _Reclamo = New reclamo
            End If
            Return _Reclamo
        End Get
        Set(ByVal value As reclamo)
            _Reclamo = value
        End Set
    End Property

    Private _LstReclamo As List(Of reclamo)
    Public Property LstReclamo As List(Of reclamo)
        Get
            If _LstReclamo Is Nothing Then
                _LstReclamo = New List(Of reclamo)
            End If
            Return _LstReclamo
        End Get
        Set(ByVal value As List(Of reclamo))
            _LstReclamo = value
        End Set
    End Property

    Public Sub FilllistReclamoByPedido(ByVal pedido As Integer)
        If pedido <> 0 Then
            LstReclamo = Reclamo.FillListByPedido(pedido, getConn)
        End If
    End Sub

    Public Sub FillReclamobyPedido(ByVal pedido As Integer)
        If pedido <> 0 Then
            Reclamo = Reclamo.StoreFillByPedido(pedido, getConn)
        End If
    End Sub

    Public Sub FillListReclamoByCliente(id As Integer)
        LstReclamo = Reclamo.FillListByCliente(id, getConn)
    End Sub

    Public Sub FinalizarReclamo()
        Reclamo.Update(getConn, gettrn)
    End Sub
    Public Sub PreservarReclamo(ByVal cliente As Integer, ByVal pedido As Integer, ByVal asunto As String, ByVal categoria As Integer)
        '  Reclamo.Insert(getConn, gettrn)
        Reclamo.ReclamoNuevo(cliente, pedido, asunto, categoria, getConn, gettrn)
    End Sub

#End Region

#Region "Categoria_reclamo"
    Private _ReclamoCat As reclamo_categoria
    Public Property Reclamocat() As reclamo_categoria
        Get
            If _ReclamoCat Is Nothing Then
                _ReclamoCat = New reclamo_categoria
            End If
            Return _ReclamoCat
        End Get
        Set(ByVal value As reclamo_categoria)
            _ReclamoCat = value
        End Set
    End Property

    Private _LstReclamoCat As List(Of reclamo_categoria)
    Public Property LstReclamoCat As List(Of reclamo_categoria)
        Get
            If _LstReclamoCat Is Nothing Then
                _LstReclamoCat = New List(Of reclamo_categoria)
            End If
            Return _LstReclamoCat
        End Get
        Set(ByVal value As List(Of reclamo_categoria))
            _LstReclamoCat = value
        End Set
    End Property

    Public Sub FillListCategoriaReclamo()
        LstReclamoCat = reclamo_categoria.FillList(getConn)
    End Sub
#End Region

#Region "Linea_Reclamo"
    Private _ReclamoLinea As reclamo_linea
    Public Property ReclamoLinea() As reclamo_linea
        Get
            If _ReclamoLinea Is Nothing Then
                _ReclamoLinea = New reclamo_linea
            End If
            Return _ReclamoLinea
        End Get
        Set(ByVal value As reclamo_linea)
            _ReclamoLinea = value
        End Set
    End Property

    Private _LstReclamoLinea As List(Of reclamo_linea)
    Public Property LstReclamoLinea As List(Of reclamo_linea)
        Get
            If _LstReclamoLinea Is Nothing Then
                _LstReclamoLinea = New List(Of reclamo_linea)
            End If
            Return _LstReclamoLinea
        End Get
        Set(ByVal value As List(Of reclamo_linea))
            _LstReclamoLinea = value
        End Set
    End Property

    Public Sub FillListByReclamo(ByVal reclamo As Integer)
        LstReclamoLinea = reclamo_linea.FillListByReclamo(reclamo, getConn)
    End Sub

    Public Sub PreservarReclamoLinea(ByVal reclamo As Integer, ByVal telefonista As Integer, ByVal comentario As String,
                                     ByVal operador As Integer, ByVal movil As Integer)
        ' ReclamoLinea.Insert(getConn, gettrn)
        ReclamoLinea.NuevaLineaReclamo(reclamo, telefonista, comentario, operador, movil, getConn, gettrn)
    End Sub
#End Region

#Region "telefonista"
    Private _telefonista As telefonista
    Public Property telefonista() As telefonista
        Get
            If _telefonista Is Nothing Then
                _telefonista = New telefonista
            End If
            Return _telefonista
        End Get
        Set(ByVal value As telefonista)
            _telefonista = value
        End Set
    End Property

    Public Sub FillTelefonistabyUsuario(ByVal id As Integer)
        telefonista.FillBytelefonista(id, getConn)
    End Sub
#End Region

#Region "Movil"
    Private _movil As movil
    Public Property movil() As movil

        Get
            If _movil Is Nothing Then
                _movil = New movil
            End If
            Return _movil
        End Get
        Set(ByVal value As movil)
            _movil = value
        End Set
    End Property

    Private _LstMovil As List(Of movil)
    Public Property LstMovil As List(Of movil)
        Get
            If _LstMovil Is Nothing Then
                _LstMovil = New List(Of movil)
            End If
            Return _LstMovil
        End Get
        Set(ByVal value As List(Of movil))
            _LstMovil = value
        End Set
    End Property



    Public Sub PreservarMovil()
        movil.Insert(getConn, gettrn)
    End Sub
    Public Sub GuardarEdicion()
        movil.Update(getConn, gettrn)
    End Sub
    Public Sub FillListMovil()
        LstMovil = movil.FillList(getConn)
    End Sub
    Public Sub EncontrarDuplicado(ByVal numero As Integer)
        LstMovil = movil.ListaNumeroDuplicado(numero, getConn)
    End Sub
#End Region

#Region "Frecuencia"
    Private _frecuencia As frecuencia
    Public Property frecuencia() As frecuencia

        Get
            If _frecuencia Is Nothing Then
                _frecuencia = New frecuencia
            End If
            Return _frecuencia
        End Get
        Set(ByVal value As frecuencia)
            _frecuencia = value
        End Set
    End Property
    Private _LstFrecuencia As List(Of frecuencia)
    Public Property LstFrecuencia As List(Of frecuencia)
        Get
            If _LstFrecuencia Is Nothing Then
                _LstFrecuencia = New List(Of frecuencia)
            End If
            Return _LstFrecuencia
        End Get
        Set(ByVal value As List(Of frecuencia))
            _LstFrecuencia = value
        End Set
    End Property
    Public Function ControlarFrecuencia(ByVal numero As Integer) As Boolean
        Return (frecuencia.ControlarFrecuencia(numero, getConn))
    End Function
    Public Sub UpdateFrecuencia()
        frecuencia.Update(getConn)
    End Sub
    Public Sub FillFrecuenciabyID(ByVal id As Integer)
        frecuencia.FillByfrecuencia(id, getConn)

    End Sub

#End Region

#Region "Llamada"
    Private _llamada As llamada
    Public Property Llamada() As llamada
        Get
            If _llamada Is Nothing Then
                _llamada = New llamada
            End If
            Return _llamada
        End Get
        Set(ByVal value As llamada)
            _llamada = value
        End Set
    End Property

    Public Sub GuardarLlamada(ByVal usuario_id As Integer, ByVal telefono_id As Integer, ByVal numero As String)
        'Llamada.Insert(getConn, gettrn)
        Llamada.GuardarLlamada(getConn, gettrn, usuario_id, telefono_id, numero)
    End Sub
#End Region
End Class


