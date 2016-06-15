Imports MySql.Data.MySqlClient
Public Class Operacion
#Region "Miembros"
    Private _id As Integer
    Private _descripcion As String
    'Definicion de Entidades
    Private _lst_PedidoBitacora As List(Of pedidoBitacora)
    Private _lst_DomicilioBitacora As List(Of domicilioBitacora)

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
    Public Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set(ByVal Value As String)
            _descripcion = Value
        End Set
    End Property
    
    'Encapsulamiento de Entidades
    Public Property lst_PedidoBitacora As List(Of pedidoBitacora)
        Get
            If Me._lst_PedidoBitacora Is Nothing Then
                _lst_PedidoBitacora = New List(Of pedidoBitacora)
                '_lst_Pedido=pedido.FillListByPedido_categoria(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_PedidoBitacora
        End Get
        Set(ByVal Value As List(Of pedidoBitacora))
            _lst_PedidoBitacora = Value
        End Set
    End Property
    Public Property lst_DomicilioBitacora As List(Of domicilioBitacora)
        Get
            If Me._lst_DomicilioBitacora Is Nothing Then
                _lst_DomicilioBitacora = New List(Of domicilioBitacora)
                '_lst_Pedido=pedido.FillListByPedido_categoria(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_DomicilioBitacora
        End Get
        Set(ByVal Value As List(Of domicilioBitacora))
            _lst_DomicilioBitacora = Value
        End Set
    End Property

    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "p.id,p.descripcion"
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .id = 0
            .descripcion = ""
        End With
    End Sub
    Public Sub FillByID(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM Operacion p WHERE id=?id"
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
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of Operacion)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of Operacion)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM Operacion p"
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
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of Operacion))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New Operacion
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As Operacion)
        If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
        If Fila.Item("descripcion") IsNot DBNull.Value Then O.descripcion = Fila.Item("descripcion") Else O.descripcion = ""
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
                cmd.CommandText = "INSERT INTO Operacion (descripcion) VALUES (?descripcion)"
                sqlParam = cmd.Parameters.Add("?descripcion", MySqlDbType.VarChar, 80)
                sqlParam.Value = descripcion
                cmd.ExecuteNonQuery()
                If _tran Is Nothing Then
                    transaction.Commit()
                End If
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
