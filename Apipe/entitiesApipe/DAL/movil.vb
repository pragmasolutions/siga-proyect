Imports MySql.Data.MySqlClient
Public Class movil
#Region "Miembros"
    Private _id As Integer
    Private _numero As Integer
    Private _color As String
    Private _chapa As String
    Private _marca As String
    Private _modelo As String
    Private _aire As Boolean
    Private _baul As String
    Private _habilitacion As Date
    Private _seguro As Date
    Private _en_zona As DateTime
    Private _observacion As String
    Private _alta As Date
    Private _baja As Date
    Private _habilitado As Boolean
    Private _telefono As String
    Private _titular_id As Integer
    Private _responsable_id As Integer
    Private _frecuencia_id As Integer
    Private _zona_id As Integer
    Private _EstadoFila As Char
    'Definicion de Entidades
    Private _Zona As zona
    Private _EntidadTitular As entidad
    Private _EntidadResponsable As entidad
    Private _Frecuencia As frecuencia
    Private _lst_ChoferMovil As List(Of chofer_movil)
    Private _lst_Poliza As List(Of poliza)
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
    Public Property numero As Integer
        Get
            Return _numero
        End Get
        Set(ByVal Value As Integer)
            _numero = Value
        End Set
    End Property
    Public Property color As String
        Get
            Return _color
        End Get
        Set(ByVal Value As String)
            _color = Value
        End Set
    End Property
    Public Property chapa As String
        Get
            Return _chapa
        End Get
        Set(ByVal Value As String)
            _chapa = Value
        End Set
    End Property
    Public Property marca As String
        Get
            Return _marca
        End Get
        Set(ByVal Value As String)
            _marca = Value
        End Set
    End Property
    Public Property modelo As String
        Get
            Return _modelo
        End Get
        Set(ByVal Value As String)
            _modelo = Value
        End Set
    End Property
    Public Property aire As Boolean
        Get
            Return _aire
        End Get
        Set(ByVal Value As Boolean)
            _aire = Value
        End Set
    End Property
    Public Property baul As String
        Get
            Return _baul
        End Get
        Set(ByVal Value As String)
            _baul = Value
        End Set
    End Property
    Public Property habilitacion As Date
        Get
            Return _habilitacion
        End Get
        Set(ByVal Value As Date)
            _habilitacion = Value
        End Set
    End Property
    Public Property seguro As Date
        Get
            Return _seguro
        End Get
        Set(ByVal Value As Date)
            _seguro = Value
        End Set
    End Property
    Public Property en_zona As DateTime
        Get
            Return _en_zona
        End Get
        Set(ByVal value As DateTime)
            _en_zona = value
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
    Public Property alta As Date
        Get
            Return _alta
        End Get
        Set(ByVal Value As Date)
            _alta = Value
        End Set
    End Property
    Public Property baja As Date
        Get
            Return _baja
        End Get
        Set(ByVal Value As Date)
            _baja = Value
        End Set
    End Property
    Public Property habilitado As Boolean
        Get
            Return _habilitado
        End Get
        Set(ByVal Value As Boolean)
            _habilitado = Value
        End Set
    End Property
    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property
    Public Property titular_id As Integer
        Get
            Return _titular_id
        End Get
        Set(ByVal Value As Integer)
            _titular_id = Value
        End Set
    End Property
    Public Property responsable_id As Integer
        Get
            Return _responsable_id
        End Get
        Set(ByVal Value As Integer)
            _responsable_id = Value
        End Set
    End Property
    Public Property frecuencia_id As Integer
        Get
            Return _frecuencia_id
        End Get
        Set(ByVal Value As Integer)
            _frecuencia_id = Value
        End Set
    End Property
    Public Property zona_id As Integer
        Get
            Return _zona_id
        End Get
        Set(ByVal Value As Integer)
            _zona_id = Value
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
    Public Property Zona As zona
        Get
            If Me._zona Is Nothing Then
                _zona = New zona
                If Me._zona_id > 0 Then
                    _zona.FillByZona(Me._zona_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _zona
        End Get
        Set(ByVal Value As zona)
            _zona = Value
        End Set
    End Property
    Public Property EntidadTitular As entidad
        Get
            If Me._EntidadTitular Is Nothing Then
                _EntidadTitular = New entidad
                If Me._titular_id > 0 Then
                    _EntidadTitular.StoreFillByentidad(Me._titular_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _EntidadTitular
        End Get
        Set(ByVal Value As entidad)
            _EntidadTitular = Value
        End Set
    End Property
    Public Property EntidadResponsable As entidad
        Get
            If Me._EntidadResponsable Is Nothing Then
                _EntidadResponsable = New entidad
                If Me._responsable_id > 0 Then
                    _EntidadResponsable.StoreFillByentidad(Me._responsable_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _EntidadResponsable
        End Get
        Set(ByVal Value As entidad)
            _EntidadResponsable = Value
        End Set
    End Property
    Public Property Frecuencia As frecuencia
        Get
            If Me._frecuencia Is Nothing Then
                _frecuencia = New frecuencia
                If Me._frecuencia_id > 0 Then
                    _frecuencia.FillByFrecuencia(Me._frecuencia_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _frecuencia
        End Get
        Set(ByVal Value As frecuencia)
            _frecuencia = Value
        End Set
    End Property
    Public Property lst_ChoferMovil As List(Of chofer_movil)
        Get
            If Me._lst_ChoferMovil Is Nothing Then
                _lst_ChoferMovil = New List(Of chofer_movil)
                '_lst_ChoferMovil=chofer_movil.FillListByMovil(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_ChoferMovil
        End Get
        Set(ByVal Value As List(Of chofer_movil))
            _lst_ChoferMovil = Value
        End Set
    End Property
    Public Property lst_Poliza As List(Of poliza)
        Get
            If Me._lst_Poliza Is Nothing Then
                _lst_Poliza = New List(Of poliza)
                '_lst_Poliza=poliza.FillListByMovil(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Poliza
        End Get
        Set(ByVal Value As List(Of poliza))
            _lst_Poliza = Value
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "m.id,m.numero,m.color,m.chapa,m.marca,m.modelo,m.aire,m.baul,m.habilitacion,m.seguro,m.en_zona,m.observacion,m.alta,m.baja,m.habilitado,m.telefono,m.titular_id,m.responsable_id,m.frecuencia_id,m.zona_id"
        End Get
        'MODIFICAR LA BASE DE DATOS "AGREGAR TELEFONO"
        'Get
        '    Return "m.id,m.numero,m.color,m.chapa,m.marca,m.modelo,m.aire,m.baul,m.habilitacion,m.seguro,m.en_zona,m.observacion,m.alta,m.baja,m.habilitado,m.telefono,m.titular_id,m.responsable_id,m.frecuencia_id,m.zona_id"
        'End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .id = 0
            .numero = 0
            .color = ""
            .chapa = ""
            .marca = ""
            .modelo = ""
            .aire = False
            .baul = ""
            .habilitacion = "1900-01-01 00:00:00"
            .seguro = "1900-01-01 00:00:00"
            .en_zona = "1900-01-01 00:00:00"
            .observacion = ""
            .alta = "1900-01-01 00:00:00"
            .baja = "1900-01-01 00:00:00"
            .habilitado = False
            .telefono = ""
            .titular_id = 0
            .responsable_id = 0
            .frecuencia_id = 0
            .zona_id = 0
        End With
    End Sub
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of movil)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of movil)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM movil m ORDER BY numero"
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
                Ta.Dispose()
                Dt.Dispose()
            End With
            Return Lista
        End Using

    End Function
    Public Shared Function FillListByZona(ByVal zona_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of movil)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of movil)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM movil m" & vbCrLf
                .CommandText &= "WHERE zona_id = ?zona_id"
                .Parameters.AddWithValue("?zona_id", zona_id)
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
                Ta.Dispose()
                Dt.Dispose()
            End With
            Return Lista
        End Using
    End Function
    Public Shared Function FillListByEntidadTitular(ByVal titular_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of movil)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of movil)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM movil m" & vbCrLf
                .CommandText &= "WHERE titular_id = ?titular_id"
                .Parameters.AddWithValue("?titular_id", titular_id)
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
                Ta.Dispose()
                Dt.Dispose()
            End With
            Return Lista
        End Using
    End Function
    Public Shared Function FillListByEntidadResponsable(ByVal responsable_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of movil)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of movil)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM movil m" & vbCrLf
                .CommandText &= "WHERE responsable_id = ?responsable_id"
                .Parameters.AddWithValue("?responsable_id", responsable_id)
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
                Ta.Dispose()
                Dt.Dispose()
            End With
            Return Lista
        End Using
    End Function
    Public Shared Function FillListByFrecuencia(ByVal frecuencia_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of movil)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of movil)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM movil m" & vbCrLf
                .CommandText &= "WHERE frecuencia_id = ?frecuencia_id"
                .Parameters.AddWithValue("?frecuencia_id", frecuencia_id)
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
                Ta.Dispose()
                Dt.Dispose()
            End With
            Return Lista
        End Using
    End Function
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of movil))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New movil
                CargarFila(Fila, O)
                Lista.Add(O)

                Dt.Dispose()
            Next
        End If
    End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As movil)
        If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
        If Fila.Item("numero") IsNot DBNull.Value Then O.numero = Fila.Item("numero") Else O.numero = 0
        If Fila.Item("color") IsNot DBNull.Value Then O.color = Fila.Item("color") Else O.color = ""
        If Fila.Item("chapa") IsNot DBNull.Value Then O.chapa = Fila.Item("chapa") Else O.chapa = ""
        If Fila.Item("marca") IsNot DBNull.Value Then O.marca = Fila.Item("marca") Else O.marca = ""
        If Fila.Item("modelo") IsNot DBNull.Value Then O.modelo = Fila.Item("modelo") Else O.modelo = ""
        If Fila.Item("aire") IsNot DBNull.Value Then O.aire = Fila.Item("aire") Else O.aire = False
        If Fila.Item("baul") IsNot DBNull.Value Then O.baul = Fila.Item("baul") Else O.baul = ""
        If Fila.Item("habilitacion") IsNot DBNull.Value Then O.habilitacion = Date.Parse(Fila.Item("habilitacion").ToString) Else O.habilitacion = "1900-01-01 00:00:00"
        If Fila.Item("seguro") IsNot DBNull.Value Then O.seguro = Date.Parse(Fila.Item("seguro").ToString) Else O.seguro = "1900-01-01 00:00:00"
        If Fila.Item("en_zona") IsNot DBNull.Value Then O.en_zona = DateTime.Parse(Fila.Item("en_zona").ToString) Else O.en_zona = "1900-01-01 00:00:00"
        If Fila.Item("observacion") IsNot DBNull.Value Then O.observacion = Fila.Item("observacion") Else O.observacion = ""
        If Fila.Item("alta") IsNot DBNull.Value Then O.alta = Date.Parse(Fila.Item("alta").ToString) Else O.alta = "1900-01-01 00:00:00"
        If Fila.Item("baja") IsNot DBNull.Value Then O.baja = Date.Parse(Fila.Item("baja").ToString) Else O.baja = "1900-01-01 00:00:00"
        If Fila.Item("habilitado") IsNot DBNull.Value Then O.habilitado = Fila.Item("habilitado") Else O.habilitado = False
        If Fila.Item("telefono") IsNot DBNull.Value Then O.telefono = Fila.Item("telefono") Else O.telefono = ""
        If Fila.Item("titular_id") IsNot DBNull.Value Then O.titular_id = Fila.Item("titular_id") Else O.titular_id = 0
        If Fila.Item("responsable_id") IsNot DBNull.Value Then O.responsable_id = Fila.Item("responsable_id") Else O.responsable_id = 0
        If Fila.Item("frecuencia_id") IsNot DBNull.Value Then O.frecuencia_id = Fila.Item("frecuencia_id") Else O.frecuencia_id = 0
        If Fila.Item("zona_id") IsNot DBNull.Value Then O.zona_id = Fila.Item("zona_id") Else O.zona_id = 0
    End Sub
    Public Sub FillBymovil(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)

        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM movil m WHERE id=?id"

                .Connection = _Conexion
                .Parameters.AddWithValue("id", Id)
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Try
                    Ta.Fill(Dt)

                    If Dt.Rows.Count > 0 Then
                        Dim Fila As DataRow = Dt.Rows(0)
                        CargarFila(Fila, Me)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Ta.Dispose()
                Dt.Dispose()
            End With
        End Using
    End Sub
    Public Function Clone() As movil
        Clone = New movil
        With Clone
            .id = Me.id
            .numero = Me.numero
            .color = Me.color
            .chapa = Me.chapa
            .marca = Me.marca
            .modelo = Me.modelo
            .aire = Me.aire
            .baul = Me.baul
            .habilitacion = Me.habilitacion
            .seguro = Me.seguro
            .en_zona = Me.en_zona
            .observacion = Me.observacion
            .alta = Me.alta
            .baja = Me.baja
            .habilitado = Me.habilitado
            .telefono = Me.telefono
            .titular_id = Me.titular_id
            .responsable_id = Me.responsable_id
            .frecuencia_id = Me.frecuencia_id
            .zona_id = Me.zona_id
            .EstadoFila = Me.EstadoFila
        End With
    End Function
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
                cmd.CommandText = "INSERT INTO movil (numero,color,chapa,marca,modelo,aire,baul,habilitacion,seguro,en_zona,observacion,alta,baja,habilitado,telefono,titular_id,responsable_id,frecuencia_id,zona_id) VALUES (?numero,?color,?chapa,?marca,?modelo,?aire,?baul,?habilitacion,?seguro,?en_zona,?observacion,?alta,?baja,?habilitado,?telefono,?titular_id,?responsable_id,?frecuencia_id,?zona_id)"
                sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.UInt24, 5)
                sqlParam.Value = numero
                sqlParam = cmd.Parameters.Add("?color", MySqlDbType.VarChar, 30)
                sqlParam.Value = color
                sqlParam = cmd.Parameters.Add("?chapa", MySqlDbType.VarChar, 10)
                sqlParam.Value = chapa
                sqlParam = cmd.Parameters.Add("?marca", MySqlDbType.VarChar, 30)
                sqlParam.Value = marca
                sqlParam = cmd.Parameters.Add("?modelo", MySqlDbType.VarChar, 30)
                sqlParam.Value = modelo
                sqlParam = cmd.Parameters.Add("?aire", MySqlDbType.Bit, 1)
                sqlParam.Value = aire
                sqlParam = cmd.Parameters.Add("?baul", MySqlDbType.Enum, 0)
                sqlParam.Value = baul
                sqlParam = cmd.Parameters.Add("?habilitacion", MySqlDbType.Date, 0)
                sqlParam.Value = habilitacion
                sqlParam = cmd.Parameters.Add("?seguro", MySqlDbType.Date, 0)
                sqlParam.Value = seguro
                sqlParam = cmd.Parameters.Add("?en_zona", MySqlDbType.DateTime, 0)
                If en_zona = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = en_zona
                End If
                sqlParam = cmd.Parameters.Add("?observacion", MySqlDbType.VarChar, 250)
                If observacion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observacion
                End If
                sqlParam = cmd.Parameters.Add("?alta", MySqlDbType.Date, 0)
                sqlParam.Value = alta
                sqlParam = cmd.Parameters.Add("?baja", MySqlDbType.Date, 0)
                If baja = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = baja
                End If
                sqlParam = cmd.Parameters.Add("?habilitado", MySqlDbType.Bit, 1)
                sqlParam.Value = habilitado
                sqlParam = cmd.Parameters.Add("?telefono", MySqlDbType.VarChar, 18)
                If telefono = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = telefono
                End If
                sqlParam = cmd.Parameters.Add("?titular_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = titular_id
                sqlParam = cmd.Parameters.Add("?responsable_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = responsable_id
                sqlParam = cmd.Parameters.Add("?frecuencia_id", MySqlDbType.UInt16, 3)
                If frecuencia_id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = frecuencia_id
                End If
                sqlParam = cmd.Parameters.Add("?zona_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = zona_id
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
    Public Function Update(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean
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
                cmd.CommandText = "UPDATE movil SET numero=?numero,color=?color,chapa=?chapa,marca=?marca,modelo=?modelo,aire=?aire,baul=?baul,habilitacion=?habilitacion,seguro=?seguro,en_zona=?en_zona,observacion=?observacion,alta=?alta,baja=?baja,habilitado=?habilitado,telefono=?telefono,titular_id=?titular_id,responsable_id=?responsable_id,frecuencia_id=?frecuencia_id,zona_id=?zona_id WHERE id=?id"

                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
                sqlParam.Value = id
                sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.UInt24, 5)
                sqlParam.Value = numero
                sqlParam = cmd.Parameters.Add("?color", MySqlDbType.VarChar, 30)
                sqlParam.Value = color
                sqlParam = cmd.Parameters.Add("?chapa", MySqlDbType.VarChar, 10)
                sqlParam.Value = chapa
                sqlParam = cmd.Parameters.Add("?marca", MySqlDbType.VarChar, 30)
                sqlParam.Value = marca
                sqlParam = cmd.Parameters.Add("?modelo", MySqlDbType.VarChar, 30)
                sqlParam.Value = modelo
                sqlParam = cmd.Parameters.Add("?aire", MySqlDbType.Bit, 1)
                sqlParam.Value = aire
                sqlParam = cmd.Parameters.Add("?baul", MySqlDbType.Enum, 0)
                sqlParam.Value = baul
                sqlParam = cmd.Parameters.Add("?habilitacion", MySqlDbType.Date, 0)
                sqlParam.Value = habilitacion
                sqlParam = cmd.Parameters.Add("?seguro", MySqlDbType.Date, 0)
                sqlParam.Value = seguro
                sqlParam = cmd.Parameters.Add("?en_zona", MySqlDbType.DateTime, 0)
                If en_zona = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = en_zona
                End If
                sqlParam = cmd.Parameters.Add("?observacion", MySqlDbType.VarChar, 250)
                If observacion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observacion
                End If
                sqlParam = cmd.Parameters.Add("?alta", MySqlDbType.Date, 0)
                sqlParam.Value = alta
                sqlParam = cmd.Parameters.Add("?baja", MySqlDbType.Date, 0)
                If baja = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = baja
                End If
                sqlParam = cmd.Parameters.Add("?habilitado", MySqlDbType.Bit, 1)
                sqlParam.Value = habilitado
                sqlParam = cmd.Parameters.Add("?telefono", MySqlDbType.VarChar, 18)
                If telefono = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = telefono
                End If
                sqlParam = cmd.Parameters.Add("?titular_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = titular_id
                sqlParam = cmd.Parameters.Add("?responsable_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = responsable_id
                sqlParam = cmd.Parameters.Add("?frecuencia_id", MySqlDbType.UInt16, 3)
                If frecuencia_id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = frecuencia_id
                End If
                sqlParam = cmd.Parameters.Add("?zona_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = zona_id
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
            Return True
        End Using
    End Function
    Public Function InsertUpdate(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer
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
                cmd.CommandText = "INSERT INTO movil (id,numero,color,chapa,marca,modelo,aire,baul,habilitacion,seguro,en_zona,observacion,alta,baja,habilitado,telefono,titular_id,responsable_id,frecuencia_id,zona_id) VALUES (?id,?numero,?color,?chapa,?marca,?modelo,?aire,?baul,?habilitacion,?seguro,?en_zona,?observacion,?alta,?baja,?habilitado,?telefono,?titular_id,?responsable_id,?frecuencia_id,?zona_id)" & vbCrLf _
                & " ON DUPLICATE KEY UPDATE numero=?numero,color=?color,chapa=?chapa,marca=?marca,modelo=?modelo,aire=?aire,baul=?baul,habilitacion=?habilitacion,seguro=?seguro,en_zona=?en_zona,observacion=?observacion,alta=?alta,baja=?baja,habilitado=?habilitado,telefono=?telefono,titular_id=?titular_id,responsable_id=?responsable_id,frecuencia_id=?frecuencia_id,zona_id=?zona_id"
                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
                If id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = id
                End If
                sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.UInt24, 5)
                sqlParam.Value = numero
                sqlParam = cmd.Parameters.Add("?color", MySqlDbType.VarChar, 30)
                sqlParam.Value = color
                sqlParam = cmd.Parameters.Add("?chapa", MySqlDbType.VarChar, 10)
                sqlParam.Value = chapa
                sqlParam = cmd.Parameters.Add("?marca", MySqlDbType.VarChar, 30)
                sqlParam.Value = marca
                sqlParam = cmd.Parameters.Add("?modelo", MySqlDbType.VarChar, 30)
                sqlParam.Value = modelo
                sqlParam = cmd.Parameters.Add("?aire", MySqlDbType.Bit, 1)
                sqlParam.Value = aire
                sqlParam = cmd.Parameters.Add("?baul", MySqlDbType.Enum, 0)
                sqlParam.Value = baul
                sqlParam = cmd.Parameters.Add("?habilitacion", MySqlDbType.Date, 0)
                sqlParam.Value = habilitacion
                sqlParam = cmd.Parameters.Add("?seguro", MySqlDbType.Date, 0)
                sqlParam.Value = seguro
                sqlParam = cmd.Parameters.Add("?en_zona", MySqlDbType.DateTime, 0)
                If en_zona = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = en_zona
                End If
                sqlParam = cmd.Parameters.Add("?observacion", MySqlDbType.VarChar, 250)
                If observacion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observacion
                End If
                sqlParam = cmd.Parameters.Add("?alta", MySqlDbType.Date, 0)
                sqlParam.Value = alta
                sqlParam = cmd.Parameters.Add("?baja", MySqlDbType.Date, 0)
                If baja = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = baja
                End If
                sqlParam = cmd.Parameters.Add("?habilitado", MySqlDbType.Bit, 1)
                sqlParam.Value = habilitado
                sqlParam = cmd.Parameters.Add("?telefono", MySqlDbType.VarChar, 18)
                If telefono = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = telefono
                End If
                sqlParam = cmd.Parameters.Add("?titular_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = titular_id
                sqlParam = cmd.Parameters.Add("?responsable_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = responsable_id
                sqlParam = cmd.Parameters.Add("?frecuencia_id", MySqlDbType.UInt16, 3)
                If frecuencia_id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = frecuencia_id
                End If
                sqlParam = cmd.Parameters.Add("?zona_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = zona_id
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
            If cmd.LastInsertedId > 0 Then
                Me.id = cmd.LastInsertedId
            End If
            '_Conexion.Close()
            cmd.Dispose()
            Return cmd.LastInsertedId


        End Using
    End Function
    Public Function Delete(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean
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
                cmd.CommandText = "DELETE FROM movil WHERE id=?id"
                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
                sqlParam.Value = id
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
            Return True
        End Using
    End Function
#End Region
End Class
