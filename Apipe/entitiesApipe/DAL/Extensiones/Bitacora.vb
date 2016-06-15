Imports MySql.Data.MySqlClient
Public Class bitacora
#Region "Miembros"
    Private _id As Integer
    Private _pedido_id_bitacora As Integer
    Private _domicilio_id_bitacora As Integer
    Private _usuario_id As Integer
    Private _operacion_id As Integer
    Private _fechahora As DateTime

    
    'Definicion de Entidades
    Private _PedidoBitacora As pedidoBitacora
    Private _DomicilioBitacora As domicilioBitacora
    Private _Usuario As usuario
    Private _Operacion As Operacion
#End Region
#Region "Propiedades"
    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property
    Public Property pedido_id_bitacora As String
        Get
            Return _pedido_id_bitacora
        End Get
        Set(ByVal Value As String)
            _pedido_id_bitacora = Value
        End Set
    End Property
    Public Property domicilio_id_bitacora As String
        Get
            Return _domicilio_id_bitacora
        End Get
        Set(ByVal Value As String)
            _domicilio_id_bitacora = Value
        End Set
    End Property
    Public Property usuario_id As String
        Get
            Return _usuario_id
        End Get
        Set(ByVal Value As String)
            _usuario_id = Value
        End Set
    End Property
    Public Property operacion_id As String
        Get
            Return _operacion_id
        End Get
        Set(ByVal Value As String)
            _operacion_id = Value
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
    
    'Encapsulamiento de Entidades
    Public Property PedidoBitacora As pedidoBitacora
        Get
            If Me._PedidoBitacora Is Nothing Then
                _PedidoBitacora = New pedidoBitacora
                If Me.pedido_id_bitacora > 0 Then
                    _PedidoBitacora.FillBypedido(Me.pedido_id_bitacora, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _PedidoBitacora
        End Get
        Set(ByVal Value As pedidoBitacora)
            _PedidoBitacora = Value
        End Set
    End Property
    Public Property DomicilioBitacora As domicilioBitacora
        Get
            If Me._DomicilioBitacora Is Nothing Then
                _DomicilioBitacora = New domicilioBitacora
                If Me.domicilio_id_bitacora > 0 Then
                    _DomicilioBitacora.FillByDomiclio(Me.domicilio_id_bitacora, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _DomicilioBitacora
        End Get
        Set(ByVal Value As domicilioBitacora)
            _DomicilioBitacora = Value
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

    Public Property Operacion As Operacion
        Get
            If Me._Operacion Is Nothing Then
                _Operacion = New Operacion
                If Me._operacion_id > 0 Then
                    _Operacion.FillByID(Me._operacion_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Operacion
        End Get
        Set(ByVal Value As Operacion)
            _Operacion = Value
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "p.id,p."
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .id = 0
            .pedido_id_bitacora = 0
            .domicilio_id_bitacora = 0
            .usuario_id = 0
            .operacion_id = 0
            .fechahora = "1900-01-01 00:00:00"
        End With
    End Sub
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of bitacora)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of bitacora)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM bitacora p"
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
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of bitacora))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New bitacora
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As bitacora)
        If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
        If Fila.Item("pedido_id_bitacora") IsNot DBNull.Value Then O.pedido_id_bitacora = Fila.Item("pedido_id_bitacora") Else O.pedido_id_bitacora = 0
        If Fila.Item("domicilio_id_bitacora") IsNot DBNull.Value Then O.domicilio_id_bitacora = Fila.Item("domicilio_id_bitacora") Else O.domicilio_id_bitacora = 0
        If Fila.Item("fechahora") IsNot DBNull.Value Then O.fechahora = DateTime.Parse(Fila.Item("fechahora").ToString) Else O.fechahora = "1900-01-01 00:00:00"
        If Fila.Item("usuario_id") IsNot DBNull.Value Then O.usuario_id = Fila.Item("usuario_id") Else O.usuario_id = 0
        If Fila.Item("operacion_id") IsNot DBNull.Value Then O.operacion_id = Fila.Item("operacion_id") Else O.operacion_id = 0
       
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
                cmd.CommandText = "INSERT INTO bitacora (pedido_id_bitacora, domicilio_id_bitacora, usuario_id, operacion_id,fechahora) VALUES (?pedido_id_bitacora, ?domicilio_id_bitacora, ?usuario_id, ?operacion_id,?fechahora)"

                sqlParam = cmd.Parameters.Add("?pedido_id_bitacora", MySqlDbType.Int32)
                sqlParam.Value = pedido_id_bitacora

                sqlParam = cmd.Parameters.Add("?domicilio_id_bitacora", MySqlDbType.Int32)
                sqlParam.Value = domicilio_id_bitacora

                sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.Int32)
                sqlParam.Value = usuario_id

                sqlParam = cmd.Parameters.Add("?operacion_id", MySqlDbType.Int32)
                sqlParam.Value = operacion_id

                sqlParam = cmd.Parameters.Add("?fechahora", MySqlDbType.DateTime, 0)
                sqlParam.Value = fechahora
                
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
