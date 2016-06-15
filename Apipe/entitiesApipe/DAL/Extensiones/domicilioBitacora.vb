Imports MySql.Data.MySqlClient
Public Class domicilioBitacora

#Region "Miembros"
    Private _autonumerico As Integer
    Private _id As Integer
    Private _calle As String
    Private _numero As Integer
    Private _tipo As String
    Private _descripcion As String
    Private _interseccion As String
    Private _observacion As String
    Private _barrio_id As Integer
    Private _voz_calle_id As Integer
    Private _voz_interseccion_id As Integer
    Private _EstadoFila As Char
    'Definicion de Entidades
    Private _Domicilio As domicilio
    Private _Barrio As barrio
    Private _VozCalle As voz
    Private _VozInterseccion As voz
    Private _lst_Agenda As List(Of agenda)
    Private _lst_TelefonoDomicilio As List(Of telefono_domicilio)
#End Region
#Region "Propiedades"
    Public Property autonumerico As Integer
        Get
            Return _autonumerico
        End Get
        Set(ByVal value As Integer)
            _autonumerico = value
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
    Public Property calle As String
        Get
            Return _calle
        End Get
        Set(ByVal Value As String)
            _calle = Value
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
    Public Property tipo As String
        Get
            Return _tipo
        End Get
        Set(ByVal Value As String)
            _tipo = Value
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
    Public Property interseccion As String
        Get
            Return _interseccion
        End Get
        Set(ByVal Value As String)
            _interseccion = Value
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
    Public Property barrio_id As Integer
        Get
            Return _barrio_id
        End Get
        Set(ByVal Value As Integer)
            _barrio_id = Value
        End Set
    End Property
    Public Property voz_calle_id As Integer
        Get
            Return _voz_calle_id
        End Get
        Set(ByVal Value As Integer)
            _voz_calle_id = Value
        End Set
    End Property
    Public Property voz_interseccion_id As Integer
        Get
            Return _voz_interseccion_id
        End Get
        Set(ByVal Value As Integer)
            _voz_interseccion_id = Value
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
    Public Property Domicilio As domicilio
        Get
            If Me._Domicilio Is Nothing Then
                _Domicilio = New domicilio
                If Me._id > 0 Then
                    _Domicilio.FillBydomicilio(Me._id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Domicilio
        End Get
        Set(ByVal Value As domicilio)
            _Domicilio = Value
        End Set
    End Property

    Public Property Barrio As barrio
        Get
            If Me._Barrio Is Nothing Then
                _Barrio = New barrio
                If Me._barrio_id > 0 Then
                    _Barrio.StoreFillBybarrio(Me._barrio_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Barrio
        End Get
        Set(ByVal Value As barrio)
            _Barrio = Value
        End Set
    End Property
    Public Property VozCalle As voz
        Get
            If Me._VozCalle Is Nothing Then
                _VozCalle = New voz
                If Me.voz_calle_id > 0 Then
                    _VozCalle.FillByvoz(Me.voz_calle_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _VozCalle
        End Get
        Set(ByVal Value As voz)
            _VozCalle = Value
        End Set
    End Property
    Public Property VozInterseccion As voz
        Get
            If Me._VozInterseccion Is Nothing Then
                _VozInterseccion = New voz
                If Me.voz_interseccion_id > 0 Then
                    _VozInterseccion.FillByvoz(Me.voz_interseccion_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _VozInterseccion
        End Get
        Set(ByVal Value As voz)
            _VozInterseccion = Value
        End Set
    End Property
    Public Property lst_Agenda As List(Of agenda)
        Get
            If Me._lst_Agenda Is Nothing Then
                _lst_Agenda = New List(Of agenda)
                _lst_Agenda = agenda.FillListByDomicilio(Me.id, ClsVariableSesion.Instancia.getConn)
            End If
            Return _lst_Agenda
        End Get
        Set(ByVal Value As List(Of agenda))
            _lst_Agenda = Value
        End Set
    End Property
    Public Property lst_TelefonoDomicilio As List(Of telefono_domicilio)
        Get
            If Me._lst_TelefonoDomicilio Is Nothing Then
                _lst_TelefonoDomicilio = New List(Of telefono_domicilio)
                _lst_TelefonoDomicilio = telefono_domicilio.FillListByDomicilio(Me.id, ClsVariableSesion.Instancia.getConn)
            End If
            Return _lst_TelefonoDomicilio
        End Get
        Set(ByVal Value As List(Of telefono_domicilio))
            _lst_TelefonoDomicilio = Value
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "d.id,d.calle,d.numero,d.tipo,d.descripcion,d.interseccion,d.observacion,d.barrio_id,d.voz_calle_id,d.voz_interseccion_id,d.autonumerico"
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .autonumerico = 0
            .id = 0
            .calle = ""
            .numero = 0
            .tipo = ""
            .descripcion = ""
            .interseccion = ""
            .observacion = ""
            .barrio_id = 0
            .voz_calle_id = 0
            .voz_interseccion_id = 0
        End With
    End Sub
    Public Sub FillByDomiclio(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM DomicilioBitacora p WHERE id=?id"
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
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of domicilioBitacora)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of domicilioBitacora)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM domicilioBitacora d"
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
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of domicilioBitacora))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New domicilioBitacora
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As domicilioBitacora)
        Try
            If Fila.Item("autonumerico") IsNot DBNull.Value Then O.autonumerico = Fila.Item("autonumerico") Else O.autonumerico = 0
            If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
            If Fila.Item("calle") IsNot DBNull.Value Then O.calle = Fila.Item("calle") Else O.calle = ""
            If Fila.Item("numero") IsNot DBNull.Value Then O.numero = Fila.Item("numero") Else O.numero = 0
            If Fila.Item("tipo") IsNot DBNull.Value Then O.tipo = Fila.Item("tipo") Else O.tipo = ""
            If Fila.Item("descripcion") IsNot DBNull.Value Then O.descripcion = Fila.Item("descripcion") Else O.descripcion = ""
            If Fila.Item("interseccion") IsNot DBNull.Value Then O.interseccion = Fila.Item("interseccion") Else O.interseccion = ""
            If Fila.Item("observacion") IsNot DBNull.Value Then O.observacion = Fila.Item("observacion") Else O.observacion = ""
            If Fila.Item("barrio_id") IsNot DBNull.Value Then O.barrio_id = Fila.Item("barrio_id") Else O.barrio_id = 0
            If Fila.Item("voz_calle_id") IsNot DBNull.Value Then O.voz_calle_id = Fila.Item("voz_calle_id") Else O.voz_calle_id = 0
            If Fila.Item("voz_interseccion_id") IsNot DBNull.Value Then O.voz_interseccion_id = Fila.Item("voz_interseccion_id") Else O.voz_interseccion_id = 0
        Catch ex As Exception
            MsgBox("cargar fila")
        End Try
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
                cmd.CommandText = "INSERT INTO domicilioBitacora (id,calle,numero,tipo,descripcion,interseccion,observacion,barrio_id,voz_calle_id,voz_interseccion_id) VALUES (?id,?calle,?numero,?tipo,?descripcion,?interseccion,?observacion,?barrio_id,?voz_calle_id,?voz_interseccion_id)"

                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.Int32, 10)
                sqlParam.Value = id

                sqlParam = cmd.Parameters.Add("?calle", MySqlDbType.VarChar, 80)
                sqlParam.Value = calle
                sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.UInt32, 10)
                sqlParam.Value = numero
                sqlParam = cmd.Parameters.Add("?tipo", MySqlDbType.Enum, 0)
                sqlParam.Value = tipo
                sqlParam = cmd.Parameters.Add("?descripcion", MySqlDbType.VarChar, 250)
                If descripcion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = descripcion
                End If
                sqlParam = cmd.Parameters.Add("?interseccion", MySqlDbType.VarChar, 200)
                If interseccion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = interseccion
                End If
                sqlParam = cmd.Parameters.Add("?observacion", MySqlDbType.VarChar, 250)
                If observacion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observacion
                End If
                sqlParam = cmd.Parameters.Add("?barrio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = barrio_id
                sqlParam = cmd.Parameters.Add("?voz_calle_id", MySqlDbType.UInt32, 10)
                If voz_calle_id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = voz_calle_id
                End If
                sqlParam = cmd.Parameters.Add("?voz_interseccion_id", MySqlDbType.UInt32, 10)
                If voz_interseccion_id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = voz_interseccion_id
                End If
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
