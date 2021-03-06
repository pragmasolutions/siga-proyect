﻿Imports MySql.Data.MySqlClient
Public Class pedidoBitacora
#Region "Miembros"
    Private _autonumerico As Integer
    Private _id As Integer
    Private _cliente As String
    Private _fechahora As DateTime
    Private _fechahora_viaje As DateTime
    Private _asignado As DateTime
    Private _completado As DateTime
    Private _cancelado As DateTime
    Private _observacion As String
    Private _chofer_id As Integer
    Private _movil_id As Integer
    Private _usuario_id As Integer
    Private _operador_id As Integer
    Private _pedido_categoria_id As Integer
    Private _domicilio_id As Integer
    Private _telefono_id As Integer
    Private _EstadoFila As Char
    'Definicion de Entidades
    Private _Pedido As pedido
    Private _TelefonoDomicilio As telefono_domicilio
    Private _ChoferMovil As chofer_movil
    Private _Operador As operador
    Private _Pedido_categoria As pedido_categoria
    Private _Usuario As usuario
    Private _lst_Reclamo As List(Of reclamo)
    Private _Movil As movil
#End Region
#Region "Propiedades"
    Public Property autonumerico As Integer
        Get
            Return _autonumerico
        End Get
        Set(ByVal Value As Integer)
            _autonumerico = Value
        End Set
    End Property

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property
    Public Property cliente As String
        Get
            Return _cliente
        End Get
        Set(ByVal Value As String)
            _cliente = Value
        End Set
    End Property
    Public Property fechahora As DateTime
        Get
            Return _fechahora
        End Get
        Set(ByVal Value As DateTime)
            _fechahora = Value
        End Set
    End Property
    Public Property fechahora_viaje As DateTime
        Get
            Return _fechahora_viaje
        End Get
        Set(ByVal Value As DateTime)
            _fechahora_viaje = Value
        End Set
    End Property
    Public Property asignado As DateTime
        Get
            Return _asignado
        End Get
        Set(ByVal Value As DateTime)
            _asignado = Value
        End Set
    End Property
    Public Property completado As DateTime
        Get
            Return _completado
        End Get
        Set(ByVal Value As DateTime)
            _completado = Value
        End Set
    End Property
    Public Property cancelado As DateTime
        Get
            Return _cancelado
        End Get
        Set(ByVal Value As DateTime)
            _cancelado = Value
        End Set
    End Property
    Public Property observacion As String
        Get
            Return _observacion
        End Get
        Set(ByVal Value As String)
            _observacion = Value
        End Set
    End Property
    Public Property chofer_id As Integer
        Get
            Return _chofer_id
        End Get
        Set(ByVal Value As Integer)
            _chofer_id = Value
        End Set
    End Property
    Public Property movil_id As Integer
        Get
            Return _movil_id
        End Get
        Set(ByVal Value As Integer)
            _movil_id = Value
        End Set
    End Property
    Public Property usuario_id As Integer
        Get
            Return _usuario_id
        End Get
        Set(ByVal Value As Integer)
            _usuario_id = Value
        End Set
    End Property
    Public Property operador_id As Integer
        Get
            Return _operador_id
        End Get
        Set(ByVal Value As Integer)
            _operador_id = Value
        End Set
    End Property
    Public Property pedido_categoria_id As Integer
        Get
            Return _pedido_categoria_id
        End Get
        Set(ByVal Value As Integer)
            _pedido_categoria_id = Value
        End Set
    End Property
    Public Property domicilio_id As Integer
        Get
            Return _domicilio_id
        End Get
        Set(ByVal Value As Integer)
            _domicilio_id = Value
        End Set
    End Property
    Public Property telefono_id As Integer
        Get
            Return _telefono_id
        End Get
        Set(ByVal Value As Integer)
            _telefono_id = Value
        End Set
    End Property
    Public Property EstadoFila As Char
        Get
            Return _EstadoFila
        End Get
        Set(ByVal Value As Char)
            _EstadoFila = Value
        End Set
    End Property
    'Encapsulamiento de Entidades
    Public Property Pedido As pedido
        Get
            If Me._Pedido Is Nothing Then
                _Pedido = New pedido
                If Me._id > 0 Then
                    _Pedido.StoreFillBypedido(Me._id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Pedido
        End Get
        Set(ByVal Value As pedido)
            _Pedido = Value
        End Set
    End Property

    Public Property TelefonoDomicilio As telefono_domicilio
        Get
            If Me._TelefonoDomicilio Is Nothing Then
                _TelefonoDomicilio = New telefono_domicilio
                If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                    _TelefonoDomicilio.FillBytelefono_domicilio(Me.domicilio_id, Me.telefono_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _TelefonoDomicilio
        End Get
        Set(ByVal Value As telefono_domicilio)
            _TelefonoDomicilio = Value
        End Set
    End Property
    Public Property ChoferMovil As chofer_movil
        Get
            If Me._ChoferMovil Is Nothing Then
                _ChoferMovil = New chofer_movil
                If Me.chofer_id > 0 And movil_id > 0 Then
                    _ChoferMovil.FillBychofer_movil(Me.chofer_id, Me.movil_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _ChoferMovil
        End Get
        Set(ByVal Value As chofer_movil)
            _ChoferMovil = Value
        End Set
    End Property


    Public Property Operador As operador
        Get
            If Me._Operador Is Nothing Then
                _Operador = New operador
                If Me._operador_id > 0 Then
                    _Operador.FillByoperador(Me._operador_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Operador
        End Get
        Set(ByVal Value As operador)
            _Operador = Value
        End Set
    End Property

    Public Property Movil As movil
        Get
            If Me._Movil Is Nothing Then
                _Movil = New movil
                If Me._movil_id > 0 Then
                    _Movil.FillBymovil(Me.movil_id, ClsVariableSesion.Instancia.getConn)
                    '_Operador.FillByoperador(Me._operador_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Movil
        End Get
        Set(ByVal Value As movil)
            _Movil = Value
        End Set
    End Property
    Public Property Pedido_categoria As pedido_categoria
        Get
            If Me._Pedido_categoria Is Nothing Then
                _Pedido_categoria = New pedido_categoria
                If Me._pedido_categoria_id > 0 Then
                    _Pedido_categoria.FillBypedido_categoria(Me._pedido_categoria_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Pedido_categoria
        End Get
        Set(ByVal Value As pedido_categoria)
            _Pedido_categoria = Value
        End Set
    End Property
    Public Property Usuario As usuario
        Get
            If Me._Usuario Is Nothing Then
                _Usuario = New usuario
                If Me._usuario_id > 0 Then
                    _Usuario.FillByusuario(Me._usuario_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Usuario
        End Get
        Set(ByVal Value As usuario)
            _Usuario = Value
        End Set
    End Property
    Public Property lst_Reclamo As List(Of reclamo)
        Get
            If Me._lst_Reclamo Is Nothing Then
                _lst_Reclamo = New List(Of reclamo)
                _lst_Reclamo = reclamo.FillListByPedido(Me.id, ClsVariableSesion.Instancia.getConn)
            End If
            Return _lst_Reclamo
        End Get
        Set(ByVal Value As List(Of reclamo))
            _lst_Reclamo = Value
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "p.autonumerico,p.id,p.cliente,p.fechahora,p.fechahora_viaje,p.asignado,p.completado,p.cancelado,p.observacion,p.chofer_id,p.movil_id,p.usuario_id,p.operador_id,p.pedido_categoria_id,p.domicilio_id,p.telefono_id"
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .autonumerico = 0
            .id = 0
            .cliente = ""
            .fechahora = "1900-01-01 00:00:00"
            .fechahora_viaje = "1900-01-01 00:00:00"
            .asignado = "1900-01-01 00:00:00"
            .completado = "1900-01-01 00:00:00"
            .cancelado = "1900-01-01 00:00:00"
            .observacion = ""
            .chofer_id = 0
            .movil_id = 0
            .usuario_id = 0
            .operador_id = 0
            .pedido_categoria_id = 0
            .domicilio_id = 0
            .telefono_id = 0
        End With
    End Sub
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of pedidoBitacora)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of pedidoBitacora)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM pedidoBitacora p"
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)

                Dt.Dispose()
                Ta.Dispose()
            End With
            Return Lista
        End Using
    End Function

    
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of pedidoBitacora))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New pedidoBitacora
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As pedidoBitacora)
        If Fila.Item("autonumerico") IsNot DBNull.Value Then O.autonumerico = Fila.Item("autonumerico") Else O.autonumerico = 0
        If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
        If Fila.Item("cliente") IsNot DBNull.Value Then O.cliente = Fila.Item("cliente") Else O.cliente = ""
        If Fila.Item("fechahora") IsNot DBNull.Value Then O.fechahora = DateTime.Parse(Fila.Item("fechahora").ToString) Else O.fechahora = "1900-01-01 00:00:00"
        If Fila.Item("fechahora_viaje") IsNot DBNull.Value Then O.fechahora_viaje = DateTime.Parse(Fila.Item("fechahora_viaje").ToString) Else O.fechahora_viaje = "1900-01-01 00:00:00"
        If Fila.Item("asignado") IsNot DBNull.Value Then O.asignado = DateTime.Parse(Fila.Item("asignado").ToString) Else O.asignado = "1900-01-01 00:00:00"
        If Fila.Item("completado") IsNot DBNull.Value Then O.completado = DateTime.Parse(Fila.Item("completado").ToString) Else O.completado = "1900-01-01 00:00:00"
        If Fila.Item("cancelado") IsNot DBNull.Value Then O.cancelado = DateTime.Parse(Fila.Item("cancelado").ToString) Else O.cancelado = "1900-01-01 00:00:00"
        If Fila.Item("observacion") IsNot DBNull.Value Then O.observacion = Fila.Item("observacion") Else O.observacion = ""
        If Fila.Item("chofer_id") IsNot DBNull.Value Then O.chofer_id = Fila.Item("chofer_id") Else O.chofer_id = 0
        If Fila.Item("movil_id") IsNot DBNull.Value Then O.movil_id = Fila.Item("movil_id") Else O.movil_id = 0
        If Fila.Item("usuario_id") IsNot DBNull.Value Then O.usuario_id = Fila.Item("usuario_id") Else O.usuario_id = 0
        If Fila.Item("operador_id") IsNot DBNull.Value Then O.operador_id = Fila.Item("operador_id") Else O.operador_id = 0
        If Fila.Item("pedido_categoria_id") IsNot DBNull.Value Then O.pedido_categoria_id = Fila.Item("pedido_categoria_id") Else O.pedido_categoria_id = 0
        If Fila.Item("domicilio_id") IsNot DBNull.Value Then O.domicilio_id = Fila.Item("domicilio_id") Else O.domicilio_id = 0
        If Fila.Item("telefono_id") IsNot DBNull.Value Then O.telefono_id = Fila.Item("telefono_id") Else O.telefono_id = 0
    End Sub
    Public Sub FillBypedido(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM pedidoBitacora p WHERE id=?id"

                .Connection = _Conexion
                .Parameters.AddWithValue("id", Id)
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    Dim Fila As DataRow = Dt.Rows(0)
                    CargarFila(Fila, Me)
                End If

                Dt.Dispose()
                Ta.Dispose()
            End With
        End Using
    End Sub
    Public Function Insert(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer
        Dim sqlParam As New MySqlParameter
        Dim transaction As MySqlTransaction
        Using cmd As New MySqlCommand
            If _Conexion Is Nothing Then
                _Conexion.Open()
            End If
            If _tran Is Nothing Then
                transaction = _Conexion.BeginTransaction()
            Else
                transaction = _tran
            End If
            cmd.Transaction = transaction
            cmd.Connection = _Conexion
            Try
                cmd.CommandText = "INSERT INTO pedidoBitacora (id,cliente,fechahora,fechahora_viaje,asignado,completado,cancelado,observacion,chofer_id,movil_id,usuario_id,operador_id,pedido_categoria_id,domicilio_id,telefono_id) VALUES (?id,?cliente,?fechahora,?fechahora_viaje,?asignado,?completado,?cancelado,?observacion,?chofer_id,?movil_id,?usuario_id,?operador_id,?pedido_categoria_id,?domicilio_id,?telefono_id)"

                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.Int32, 10)
                sqlParam.Value = id

                sqlParam = cmd.Parameters.Add("?cliente", MySqlDbType.VarChar, 250)
                sqlParam.Value = cliente
                sqlParam = cmd.Parameters.Add("?fechahora", MySqlDbType.DateTime, 0)
                sqlParam.Value = fechahora
                sqlParam = cmd.Parameters.Add("?fechahora_viaje", MySqlDbType.DateTime, 0)
                sqlParam.Value = fechahora_viaje
                sqlParam = cmd.Parameters.Add("?asignado", MySqlDbType.DateTime, 0)
                If asignado = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = asignado
                End If
                sqlParam = cmd.Parameters.Add("?completado", MySqlDbType.DateTime, 0)
                If completado = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = completado
                End If
                sqlParam = cmd.Parameters.Add("?cancelado", MySqlDbType.DateTime, 0)
                If cancelado = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = cancelado
                End If
                sqlParam = cmd.Parameters.Add("?observacion", MySqlDbType.VarChar, 240)
                If observacion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observacion
                End If
                sqlParam = cmd.Parameters.Add("?chofer_id", MySqlDbType.UInt32, 10)
                If chofer_id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = chofer_id
                End If
                sqlParam = cmd.Parameters.Add("?movil_id", MySqlDbType.UInt32, 10)
                If movil_id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = movil_id
                End If
                sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = usuario_id
                sqlParam = cmd.Parameters.Add("?operador_id", MySqlDbType.UInt32, 10)
                If operador_id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = operador_id
                End If
                sqlParam = cmd.Parameters.Add("?pedido_categoria_id", MySqlDbType.UInt24, 5)
                sqlParam.Value = pedido_categoria_id
                sqlParam = cmd.Parameters.Add("?domicilio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = domicilio_id
                sqlParam = cmd.Parameters.Add("?telefono_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = telefono_id
                cmd.ExecuteNonQuery()
                If _tran Is Nothing Then
                    transaction.Commit()
                End If

                cmd.Dispose()
            Catch ex As Exception
                If _tran Is Nothing Then
                    transaction.Rollback()
                End If
                Throw New Exception(ex.Message)
            End Try
            Me.id = cmd.LastInsertedId
            Return cmd.LastInsertedId
        End Using
    End Function
    
#End Region
End Class
