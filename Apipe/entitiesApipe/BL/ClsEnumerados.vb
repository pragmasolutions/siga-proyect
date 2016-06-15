Public Class ClsEnumerados
    Private Shared _Instancia As ClsEnumerados
    Public Shared Property Instancia() As ClsEnumerados
        Get
            If _Instancia Is Nothing Then
                _Instancia = New ClsEnumerados
            End If
            Return _Instancia
        End Get
        Set(ByVal value As ClsEnumerados)
            _Instancia = value
        End Set
    End Property

#Region "Estáticos"
    Private _lst_Estado_Civil As List(Of String)
    Private _lst_Sexo As List(Of String)
    Private _lst_Tipo_Doc As List(Of String)
    Private _lst_EstadoChoferMovil As List(Of String)

    Public ReadOnly Property lst_Estado_Civil As List(Of String)
        Get
            If _lst_Estado_Civil Is Nothing Then
                _lst_Estado_Civil = New List(Of String)
                With _lst_Estado_Civil
                    ''Casado','Soltero','Viudo','Divorciado','Concuvinato'
                    .Add("Soltero")
                    .Add("Casado")
                    .Add("Viudo")
                    .Add("Divorciado")
                    .Add("Concuvinato")
                End With
            End If
            Return _lst_Estado_Civil
        End Get
    End Property
    Public ReadOnly Property lst_Sexo As List(Of String)
        Get
            If _lst_Sexo Is Nothing Then
                _lst_Sexo = New List(Of String)
                With _lst_Sexo
                    .Add("Masculino")
                    .Add("Femenino")
                End With
            End If
            Return _lst_Sexo
        End Get
    End Property
    Public ReadOnly Property lst_Tipo_Doc As List(Of String)
        Get
            If _lst_Tipo_Doc Is Nothing Then
                _lst_Tipo_Doc = New List(Of String)
                With _lst_Tipo_Doc
                    .Add("D.N.I.")
                    .Add("L.E.")
                    .Add("L.C.")
                    .Add("Pasaporte")
                    .Add("Cédula Federal")
                    .Add("Cédula Provincial")
                End With
            End If
            Return _lst_Tipo_Doc
        End Get
    End Property
    Public ReadOnly Property lst_EstadoChoferMovil As List(Of String)
        Get
            If _lst_EstadoChoferMovil Is Nothing Then
                _lst_EstadoChoferMovil = New List(Of String)
                With _lst_EstadoChoferMovil
                    .Add("TODOS")
                    .Add("ACTIVOS")
                    .Add("INACTIVOS")
                End With
            End If
            Return _lst_EstadoChoferMovil
        End Get
    End Property
#End Region
#Region "Cargados de la BD"
    Private _lstOperadores As List(Of operador)
    Private _lstPedidoCategoria As List(Of pedido_categoria)
    Private _lstReclamoCategoria As List(Of reclamo_categoria)
    Private _lstFormularioRol As List(Of formulario_rol)
    Private _lstFormulario As List(Of formulario)
    Private _lstFrecuencia As List(Of frecuencia)
    Private _lstUsuarioRol As List(Of usuario_rol)
    Private _lstZonas As List(Of zona)
    Private _lst_Usuario As List(Of usuario)
    Private _usuario_roles As List(Of usuario_rol)
    Public Property Usuario_Roles As List(Of usuario_rol)
        Get
            If _usuario_roles Is Nothing Then
                _usuario_roles = New List(Of usuario_rol)
                _usuario_roles = usuario_rol.FillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _usuario_roles
        End Get
        Set(ByVal value As List(Of usuario_rol))
            _usuario_roles = value
        End Set
    End Property
    Public Property lst_Usuario As List(Of usuario)
        Get
            If _lst_Usuario Is Nothing Then
                _lst_Usuario = New List(Of usuario)
                _lst_Usuario = usuario.FillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _lst_Usuario
        End Get
        Set(ByVal value As List(Of usuario))
            _lst_Usuario = value
        End Set
    End Property
    Public Property lstOperadores As List(Of operador)
        Get
            If _lstOperadores Is Nothing Then
                _lstOperadores = New List(Of operador)
                _lstOperadores = operador.FillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _lstOperadores
        End Get
        Set(ByVal value As List(Of operador))
            _lstOperadores = value
        End Set
    End Property
    Public Property lstPedidoCategoria As List(Of pedido_categoria)
        Get
            If _lstPedidoCategoria Is Nothing Then
                _lstPedidoCategoria = New List(Of pedido_categoria)
                _lstPedidoCategoria = pedido_categoria.StoreFillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _lstPedidoCategoria
        End Get
        Set(ByVal value As List(Of pedido_categoria))
            _lstPedidoCategoria = value
        End Set
    End Property
    Public Property lstReclamoCategoria As List(Of reclamo_categoria)
        Get
            If _lstReclamoCategoria Is Nothing Then
                _lstReclamoCategoria = New List(Of reclamo_categoria)
                _lstReclamoCategoria = reclamo_categoria.FillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _lstReclamoCategoria
        End Get
        Set(ByVal value As List(Of reclamo_categoria))
            _lstReclamoCategoria = value
        End Set
    End Property
    Public Property lstFormularioRol As List(Of formulario_rol)
        Get
            If _lstFormularioRol Is Nothing Then
                _lstFormularioRol = New List(Of formulario_rol)
                _lstFormularioRol = formulario_rol.FillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _lstFormularioRol
        End Get
        Set(ByVal value As List(Of formulario_rol))
            _lstFormularioRol = value
        End Set
    End Property
    Public Property lstFormulario As List(Of formulario)
        Get
            If _lstFormulario Is Nothing Then
                _lstFormulario = New List(Of formulario)
                _lstFormulario = formulario.FillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _lstFormulario
        End Get
        Set(ByVal value As List(Of formulario))
            _lstFormulario = value
        End Set
    End Property
    Public Property lstUsuarioRol As List(Of usuario_rol)
        Get
            If _lstUsuarioRol Is Nothing Then
                _lstUsuarioRol = New List(Of usuario_rol)
                _lstUsuarioRol = usuario_rol.FillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _lstUsuarioRol
        End Get
        Set(ByVal value As List(Of usuario_rol))
            _lstUsuarioRol = value
        End Set
    End Property
    Public Property lstZonas As List(Of zona)
        Get
            If _lstZonas Is Nothing Then
                _lstZonas = New List(Of zona)
                _lstZonas = zona.FillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _lstZonas
        End Get
        Set(ByVal value As List(Of zona))
            _lstZonas = value
        End Set
    End Property
    Public Property lstFrecuencia As List(Of frecuencia)
        Get
            If _lstFrecuencia Is Nothing Then
                _lstFrecuencia = New List(Of frecuencia)
                _lstFrecuencia = frecuencia.FillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _lstFrecuencia
        End Get
        Set(ByVal value As List(Of frecuencia))
            _lstFrecuencia = value
        End Set
    End Property
#End Region

End Class
