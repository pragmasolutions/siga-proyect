Public Class ClsAdministrarPedidos
    Inherits ClsMain
#Region "Propiedades"
    Private _Pedido As pedido
    Private _PedidoACompletar As pedido
    Private _PedidoCompletado As pedido
    Private _ChoferMovil As chofer_movil
    Private _Operador As operador
    Private _Zona As zona
    Private _lstPedido As List(Of pedido)
    Private _lstPedidoCQV As List(Of pedido)
    Private _lstInfoPedidoCQV As List(Of pedido)
    Private _lstPedidoApipe As List(Of pedido)
    Private _lstPedidoACompletar As List(Of pedido)
    Private _lstPedidoCompletado As List(Of pedido)
    Private _lstPedidosCancelados As List(Of pedido)
    Private _lstChoferMovil As List(Of chofer_movil)
    Private _lstChoferMovilZonai As List(Of chofer_movil)
    Private _Movil As movil
    Private _lstMovil As List(Of movil)
    Private _LstReclamo_Linea As List(Of reclamo_linea)
    Private _ReclamoLinea As reclamo_linea

#Region "Categoria de Pedido"
    Private _pedidoCat As pedido_categoria
    Public Property PedidoCat() As pedido_categoria
        Get
            If _pedidoCat Is Nothing Then
                _pedidoCat = New pedido_categoria
            End If
            Return _pedidoCat
        End Get
        Set(ByVal value As pedido_categoria)
            _pedidoCat = value
        End Set
    End Property

    Private _lstPedidoCat As List(Of pedido_categoria)
    Public Property LstPedidoCategoria() As List(Of pedido_categoria)
        Get
            If _lstPedidoCat Is Nothing Then
                _lstPedidoCat = New List(Of pedido_categoria)
            End If
            Return _lstPedidoCat
        End Get
        Set(ByVal value As List(Of pedido_categoria))
            _lstPedidoCat = value
        End Set
    End Property

#End Region
    Public Property LstMovil As List(Of movil)
        Get
            If _lstMovil Is Nothing Then
                _lstMovil = New List(Of movil)
            End If
            Return _lstMovil
        End Get
        Set(value As List(Of movil))
            _lstMovil = value
        End Set
    End Property
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

    'Private _lstChoferMovilZona2 As List(Of chofer_movil)

    Public Property LstReclamo_Linea As List(Of reclamo_linea)
        Get
            If _LstReclamo_Linea Is Nothing Then
                _LstReclamo_Linea = New List(Of reclamo_linea)
            End If
            Return _LstReclamo_Linea
        End Get
        Set(value As List(Of reclamo_linea))
            _LstReclamo_Linea = value
        End Set
    End Property

    Private _LstReclamo As List(Of reclamo)
    Public Property LStReclamo() As List(Of reclamo)
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

    Public Property Pedido As pedido
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
    Public Property LstPedidoCancelado As List(Of pedido)
        Get
            If _lstPedidosCancelados Is Nothing Then
                _lstPedidosCancelados = New List(Of pedido)
            End If
            Return _lstPedidosCancelados
        End Get
        Set(ByVal value As List(Of pedido))
            _lstPedidosCancelados = value
        End Set
    End Property

    Public Property PedidoACompletar As pedido
        Get
            If _PedidoACompletar Is Nothing Then
                _PedidoACompletar = New pedido
            End If
            Return _PedidoACompletar
        End Get
        Set(ByVal value As pedido)
            _PedidoACompletar = value
        End Set
    End Property
    Public Property PedidoCompletado As pedido
        Get
            If _PedidoCompletado Is Nothing Then
                _PedidoCompletado = New pedido
            End If
            Return _PedidoCompletado
        End Get
        Set(ByVal value As pedido)
            _PedidoCompletado = value
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
    Public Property Operador As operador
        Get
            If _Operador Is Nothing Then
                _Operador = New operador
            End If
            Return _Operador
        End Get
        Set(ByVal value As operador)
            _Operador = value
        End Set
    End Property
    Public Property Zona As zona
        Get
            If _Zona Is Nothing Then
                _Zona = New zona
            End If
            Return _Zona
        End Get
        Set(ByVal value As zona)
            _Zona = value
        End Set
    End Property
    Public Property lstPedido As List(Of pedido)
        Get
            If _lstPedido Is Nothing Then
                _lstPedido = New List(Of pedido)
            End If
            Return _lstPedido
        End Get
        Set(ByVal value As List(Of pedido))
            _lstPedido = value
        End Set
    End Property
    Public Property lstPedidoCQV As List(Of pedido)
        Get
            If _lstPedidoCQV Is Nothing Then
                _lstPedidoCQV = New List(Of pedido)
            End If
            Return _lstPedidoCQV
        End Get
        Set(ByVal value As List(Of pedido))
            _lstPedidoCQV = value
        End Set
    End Property
    Public Property lstPedidoApipe As List(Of pedido)
        Get
            If _lstPedidoApipe Is Nothing Then
                _lstPedidoApipe = New List(Of pedido)
            End If
            Return _lstPedidoApipe
        End Get
        Set(ByVal value As List(Of pedido))
            _lstPedidoApipe = value
        End Set
    End Property
    Public Property lstInfoPedidoCQV As List(Of pedido)
        Get
            If _lstInfoPedidoCQV Is Nothing Then
                _lstInfoPedidoCQV = New List(Of pedido)
            End If
            Return _lstinfoPedidoCQV
        End Get
        Set(ByVal value As List(Of pedido))
            _lstInfoPedidoCQV = value
        End Set
    End Property

    Public Property lstPedidoACompletar As List(Of pedido)
        Get
            If _lstPedidoACompletar Is Nothing Then
                _lstPedidoACompletar = New List(Of pedido)
            End If
            Return _lstPedidoACompletar
        End Get
        Set(ByVal value As List(Of pedido))
            _lstPedidoACompletar = value
        End Set
    End Property

    Public Property lstPedidoCompletado As List(Of pedido)
        Get
            If _lstPedidoCompletado Is Nothing Then
                _lstPedidoCompletado = New List(Of pedido)
            End If
            Return _lstPedidoCompletado
        End Get
        Set(ByVal value As List(Of pedido))
            _lstPedidoCompletado = value
        End Set
    End Property
    Public Property lstChoferMovil As List(Of chofer_movil)
        Get
            If _lstChoferMovil Is Nothing Then
                _lstChoferMovil = New List(Of chofer_movil)
            End If
            Return _lstChoferMovil
        End Get
        Set(ByVal value As List(Of chofer_movil))
            _lstChoferMovil = value
        End Set
    End Property
    Public Property lstChoferMovilZonai As List(Of chofer_movil)
        Get
            If _lstChoferMovilZonai Is Nothing Then
                _lstChoferMovilZonai = New List(Of chofer_movil)
            End If
            Return _lstChoferMovilZonai
        End Get
        Set(ByVal value As List(Of chofer_movil))
            _lstChoferMovilZonai = value
        End Set
    End Property
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

#End Region
#Region "Funciones"

#Region "Pedido Categoria"
    Public Sub FillListPedidoCat()
        LstPedidoCategoria = pedido_categoria.StoreFillList(getConn)
    End Sub
#End Region

    Public Sub CargarPedidosBuscador(desde, hasta, pedCat)
        Me.lstPedido = Pedido.FillListBuscador(getConn, desde, hasta, pedCat)
        'If Me.lstPedido.Count = 0 Then
        '    Me.lstPedido = Pedido.FillListPendientes(getConn, Me.Operador.entidad_id)
        'End If
    End Sub

    Public Sub CargarPedidos()
        Try
            Me.lstPedido = Pedido.StoreFillListPendientes(getConn, Me.Operador.entidad_id)
            'Me.lstPedido = Pedido.StoreFillListPendientes(getConn, 1)
            If Me.lstPedido.Count = 0 Then
                Me.lstPedido = Pedido.StoreFillListPendientes(getConn, Me.Operador.entidad_id)
                'Me.lstPedido = Pedido.StoreFillListPendientes(getConn, 1)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub CargarPedidosIVR()
        Try
            Me.lstPedido = Pedido.StoreFillListPendientesIVR(getConn)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub CargarPedidosCQV()
        Try
            Me.lstPedidoCQV = Pedido.StoreFillListPendientesCQV(getConn)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub CargarPedidosApipe()
        Try
            Me.lstPedidoApipe = Pedido.StoreFillListPendientesApipe(getConn)
        Catch ex As Exception

        End Try

    End Sub
    Public Function CargarPedidosCount() As Integer
        Try
            'Return Pedido.FillListPendientesCount(getConn, Me.Operador.entidad_id)
            Return Pedido.StoreFillListPendientesCount(getConn)
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Sub CargarPedidosCancelados()
        Try
            'Me.LstPedidoCancelado = Pedido.FillListCancelados(getConn, Me.Operador.entidad_id)
            Me.LstPedidoCancelado = Pedido.StoreFillListCancelados(getConn, Me.Operador.entidad_id)
            If Me.LstPedidoCancelado.Count = 0 Then
                Me.LstPedidoCancelado = Pedido.StoreFillListCancelados(getConn, Me.Operador.entidad_id)
                'Me.LstPedidoCancelado = Pedido.FillListCancelados(getConn, Me.Operador.entidad_id)
            End If
        Catch ex As Exception
            'MsgBox("Problemas al cargar pedidos")
        End Try

    End Sub

    Public Function CargarPedidosCanceladosCount() As Integer
        Try
            'Return Pedido.FillListCanceladosCount(getConn, Me.Operador.entidad_id)
            Return Pedido.StoreFillListCanceladosCount(getConn, Me.Operador.entidad_id)
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Sub PedidobyId(ByVal id As Integer)
        Pedido.StoreFillBypedido(id, getConn)
    End Sub
    Public Sub FillPedidoByCQV(ByVal idCQV As Integer)
        Me.lstInfoPedidoCQV = Pedido.StoreFillPedidoByCQV(idCQV, getConn)
    End Sub
    Public Sub CargarMoviles()
        Me.lstChoferMovil = chofer_movil.StoreFillListByFrecuencia(getConn, Me.Operador.frecuencia_id, True)
    End Sub
    Public Sub CargarMovilesZona()
        Me.lstChoferMovil = chofer_movil.StoreFillListByZona(getConn, Me.Zona.id)
        'Me.lstChoferMovil = chofer_movil.FillListByZona(getConn, Me.Zona.id, True)
    End Sub
    Public Sub BuscarMovil(ByVal nro As Integer)
        LstMovil = Movil.StoreFillListByNumero(nro, getConn)
        If LstMovil.Count <> 0 Then
            Me.Movil = LstMovil.First
            If Movil IsNot Nothing Then
                Me.lstChoferMovil = chofer_movil.StoreFillListByMovil(Movil.id, getConn)
                Me.ChoferMovil = Me.lstChoferMovil.First
            End If
        Else
            Me.lstChoferMovil = Nothing
            Me.ChoferMovil = Nothing
        End If
    End Sub
    Public Sub BuscarMovilFrecuencia(ByVal nro As Integer)
        LstMovil = Movil.StoreFillListByNumeroFrecuencia(nro, Me.Operador.frecuencia_id, getConn)
        If LstMovil.Count <> 0 Then
            'Me.Movil = Movil.FillListByNumeroFrecuencia(nro, Me.Operador.frecuencia_id, getConn).First
            Me.Movil = LstMovil.First
            If Movil IsNot Nothing Then
                Me.lstChoferMovil = chofer_movil.StoreFillListByMovil(Movil.id, getConn)
                Me.ChoferMovil = Me.lstChoferMovil.First
            End If
        Else
            Me.Movil = Nothing
            Me.lstChoferMovil = Nothing
            Me.ChoferMovil = Nothing
        End If
    End Sub
    Public Sub BuscarChoferMovil(ByVal movil As Integer)
        'If chofer_movil.FillListByMovil(movil, getConn).Count <> 0 Then
        '    ChoferMovil = (chofer_movil.FillListByMovil(movil, getConn).First())
        '    If ChoferMovil IsNot Nothing Then
        '        Me.lstChoferMovil = chofer_movil.FillListByMovil(movil, getConn)
        '        Me.ChoferMovil = Me.lstChoferMovil.First
        '    End If
        'Else
        '    Me.lstChoferMovil = Nothing
        '    Me.ChoferMovil = Nothing
        'End If
        lstChoferMovil = chofer_movil.StoreFillListByMovil(movil, getConn)
        If lstChoferMovil.Count <> 0 Then
            ChoferMovil = lstChoferMovil.First
            If ChoferMovil IsNot Nothing Then
                'Me.lstChoferMovil = chofer_movil.FillListByMovil(movil, getConn)
                Me.ChoferMovil = Me.lstChoferMovil.First
            End If
        Else
            Me.lstChoferMovil = Nothing
            Me.ChoferMovil = Nothing
        End If
    End Sub
    Public Sub CargarMovilesZonaI(ByVal zona As Integer)
        'para grilla
        Try
            'Me.lstChoferMovilZonai = chofer_movil.FillListByZona(getConn, zona, True)
            Me.lstChoferMovilZonai = chofer_movil.StoreFillListByZona(getConn, zona)
            If Me.lstChoferMovilZonai.Count = 0 Then
                'Me.lstChoferMovilZonai = chofer_movil.FillListByZona(getConn, zona, True)
                Me.lstChoferMovilZonai = chofer_movil.StoreFillListByZona(getConn, zona)
            End If
        Catch ex As Exception
            MsgBox("problemas para cargar subbases")
        End Try
    End Sub
    Public Function ContarMovilesZonaI(ByVal zona As Integer) As Integer
        'para grilla
        Try
            'Return chofer_movil.FillListByZonaCount(getConn, zona, True)
            Return chofer_movil.StoreFillListByZonaCount(getConn, zona)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Sub CargarMovilesenZona()
        'para grilla
        Try
            Me.LstMovil = Movil.FillListZonas(getConn)
            If Me.LstMovil.Count = 0 Then
                Me.LstMovil = Movil.FillListZonas(getConn)
            End If
        Catch ex As Exception
            MsgBox("problemas para cargar moviles en zona")
        End Try

    End Sub
    Public Function ContarMovilesEnZona() As Integer
        'Return Movil.FillListZonasCount(getConn)
        Return Movil.StoreFillListZonasCount(getConn)
    End Function
    Public Sub QuitarDeZona(ByVal id As Integer)
        Movil.StoreQuitarDeZona(id, getConn)
     End Sub
    Public Sub PersistirMovil(Optional ByVal guardar As Boolean = True)
        If guardar Then IniciarTrn()
        Try
            Me.Movil.InsertUpdate(getConn, gettrn)
            If guardar Then gettrn.Commit()
        Catch ex As Exception
            If guardar Then
                gettrn.Rollback()
                MessageBox.Show("Ha ocurrido un error al intentar guardar el móvil." + vbNewLine + ex.Message)
            Else
                Throw New Exception("Ha ocurrido un error al intentar guardar el móvil." + vbNewLine + ex.Message)
            End If
        End Try
    End Sub
    Public Sub PersistirChoferMovil()
        IniciarTrn()
        Try
            Me.ChoferMovil.InsertUpdate(getConn, gettrn)
            gettrn.Commit()
        Catch ex As Exception
            gettrn.Rollback()
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub CargarPedidosACompletar()
        'Me.lstPedidoACompletar = Pedido.FillListACompletar(getConn, Me.Operador.entidad_id) 'ClsVariableSesion.Instancia.Usuario.entidad_id, getConn)
        Me.lstPedidoACompletar = Pedido.StoreFillListACompletar(getConn, Me.Operador.entidad_id) 'ClsVariableSesion.Instancia.Usuario.entidad_id, getConn)
    End Sub
    Public Sub CargarPedidosACompletarTodos()
        'Me.lstPedidoACompletar = Pedido.FillListACompletar(getConn, 0, 0)
        Me.lstPedidoACompletar = Pedido.StoreFillListACompletar(getConn, 0, 0)
    End Sub
    Public Sub CargarPedidosCompletados()
        Me.lstPedidoCompletado = Pedido.FillListCompletados(getConn, Me.Operador.entidad_id)
        'no sé si está bien el orden que tiene
    End Sub
    Public Sub CargarPedidosCompletadosUltimos()
        Try
            Me.lstPedidoCompletado = Pedido.StoreFillListCompletadosUltimos(getConn, Me.Operador.entidad_id, Me.Operador.frecuencia_id)
            If Me.lstPedidoCompletado.Count = 0 Then
                Me.lstPedidoCompletado = Pedido.StoreFillListCompletadosUltimos(getConn, Me.Operador.entidad_id, Me.Operador.frecuencia_id)
            End If
        Catch ex As Exception
            'MsgBox("Problemas al cargar pedidos completados")
        End Try

    End Sub
    Public Sub PersistirPedido(Optional ByVal Guardar As Boolean = True)
        If Guardar Then IniciarTrn()
        Try
            Pedido.Update(getConn, gettrn)
            If Guardar Then gettrn.Commit()
        Catch ex As Exception
            If Guardar Then
                gettrn.Rollback()
                MessageBox.Show("Ha ocurrido un error al intentar guardar el pedido." & vbNewLine & ex.Message)
            Else
                Throw New Exception("Error al intentar guardar el pedido " & Pedido.id.ToString & ": " & ex.Message)
            End If
        End Try
    End Sub
    Public Sub CompletarPedido(ByVal pedido_id As Integer, ByVal operador As Integer, Optional ByVal observaciones As String = "")
        Try
            Pedido.CompletarPedido(getConn, gettrn, pedido_id, operador, observaciones)
            'gettrn.Commit()
        Catch ex As Exception
            gettrn.Rollback()
            MessageBox.Show("Ha ocurrido un error al intentar guardar el pedido." & vbNewLine & ex.Message)

        End Try
    End Sub

    Public Sub CompletarPedidoCQV(ByVal pedido_id As Integer, ByVal operador As Integer, Optional ByVal observaciones As String = "")
        Try
            Pedido.CompletarPedidoCQV(getConn, gettrn, pedido_id, operador, observaciones)
            'gettrn.Commit()
        Catch ex As Exception
            gettrn.Rollback()
            MessageBox.Show("Ha ocurrido un error al intentar guardar el pedido." & vbNewLine & ex.Message)

        End Try
    End Sub

    Public Sub AsignarPedido(ByVal pedido_id As Integer, ByVal movil As Integer, ByVal chofer As Integer, ByVal operador As Integer)
        Try
            Pedido.AsignarPedido(getConn, gettrn, pedido_id, movil, chofer, operador)
            '  gettrn.Commit()
        Catch ex As Exception
            gettrn.Rollback()
            MessageBox.Show("Ha ocurrido un error al intentar guardar el pedido." & vbNewLine & ex.Message)

        End Try
    End Sub

    Public Sub AsignarPedidoCQV(ByVal pedido_id As Integer, ByVal movil As Integer)
        Try
            Pedido.AsignarPedidoCQV(getConn, gettrn, pedido_id, movil)
        Catch ex As Exception
            gettrn.Rollback()
            MessageBox.Show("Ha ocurrido un error al intentar guardar el pedido." & vbNewLine & ex.Message)

        End Try
    End Sub
    Public Sub ModificarEstadoPedido(ByVal pedido_id As Integer, ByVal idCQV As Integer, ByVal estado As String)
        Try
            Pedido.ModificarEstadoPedido(getConn, gettrn, pedido_id, idCQV, estado)
        Catch ex As Exception
            gettrn.Rollback()
            MessageBox.Show("Ha ocurrido un error al intentar guardar el pedido." & vbNewLine & ex.Message)

        End Try
    End Sub

    Public Sub TomarLiberarPedido(ByVal pedido_id As Integer, ByVal operador As Integer)
        Try
            Pedido.TomarLiberar(getConn, gettrn, pedido_id, operador)
            '  gettrn.Commit()
        Catch ex As Exception
            ' gettrn.Rollback()
            MessageBox.Show("Ha ocurrido un error al intentar guardar el pedido." & vbNewLine & ex.Message)

        End Try
    End Sub
    
    Public Sub LiberarPedido(ByVal pedido_id As Integer)
        Try
            Pedido.Liberar(getConn, gettrn, pedido_id)
            Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al intentar guardar el pedido." & vbNewLine & ex.Message)

        End Try
    End Sub

    Public Sub LiberarPedidoCQV(ByVal pedido_id As Integer)
        Try
            Pedido.LiberarCQV(getConn, gettrn, pedido_id)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al intentar guardar el pedido." & vbNewLine & ex.Message)

        End Try
    End Sub

    Public Sub Resetear(ByVal pedido_id As Integer, ByVal operador As Integer)
        Try
            Pedido.Resetear(getConn, gettrn, pedido_id, operador)
            ' gettrn.Commit()
        Catch ex As Exception
            gettrn.Rollback()
            MessageBox.Show("Ha ocurrido un error al intentar guardar el pedido." & vbNewLine & ex.Message)

        End Try
    End Sub
    Public Sub CargarACompletarTodos()
        'Me.lstPedidoACompletar = Pedido.FillListACompletar(getConn)
        Me.lstPedidoACompletar = Pedido.StoreFillListACompletar(getConn)
    End Sub
    Public Sub CargarCantACompletar(ByVal operador As operador)
        Try
            operador.v_CantACompletar = (From p In lstPedidoACompletar Where p.operador_id = operador.entidad_id).Count
        Catch ex As Exception

        End Try

    End Sub

    Public Sub CargarACompletarFrecuencia()
        ' Me.lstPedidoACompletar = Pedido.FillListACompletar(getConn, Me.Operador.entidad_id, Me.Operador.frecuencia_id)
        Me.lstPedidoACompletar = Pedido.StoreFillListACompletar(getConn, Me.Operador.entidad_id, Me.Operador.frecuencia_id)
        If Me.lstPedidoACompletar.Count = 0 Then
            'Me.lstPedidoACompletar = Pedido.FillListACompletar(getConn, Me.Operador.entidad_id, Me.Operador.frecuencia_id)
            Me.lstPedidoACompletar = Pedido.StoreFillListACompletar(getConn, Me.Operador.entidad_id, Me.Operador.frecuencia_id)
        End If
    End Sub


    Public Sub TraspasarPedidosFrecuencia(ByVal frecuencia As Integer, ByVal operador As Integer)
        Pedido.TraspasarPedidos(frecuencia, Operador, getConn)
    End Sub

    Public Sub FillZonaById(ByVal id As Integer)
        Zona = Zona.FillListByZona(id, getConn).First
    End Sub
    Public Sub FillReclamos()
        'LstReclamo_Linea = ReclamoLinea.FillListHora(getConn)
        LstReclamo_Linea = ReclamoLinea.StoreFillListHora(getConn)
    End Sub
    Public Function FillReclamosCount() As Integer
        'Return ReclamoLinea.FillListHoraCount(getConn)
        Return reclamo_linea.StoreFillListHoraCount(getConn)
    End Function
    Public Sub FillReclamoByPedido(ByVal id As Integer)
        ReclamoLinea.FillByreclamo_linea(id, getConn)
    End Sub

    Public Sub CambiarFrecuencias(ByVal desde As Integer, ByVal hasta As Integer, ByVal frecuencia As Integer)

        Try
            Me.Movil.CambiarFrecuencia(desde, hasta, frecuencia, getConn, gettrn)
        
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class
