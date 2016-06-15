Imports MySql.Data.MySqlClient
Public Class contador
#Region "Miembros"
    Private _id As Integer
    Private _fechainicio As DateTime
    Private _fechafin As DateTime
    Private _contador As Integer
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
    Public Property fechainicio As DateTime
        Get
            Return _fechainicio
        End Get
        Set(ByVal Value As DateTime)
            _fechainicio = Value
        End Set
    End Property
    Public Property fechafin As DateTime
        Get
            Return _fechafin
        End Get
        Set(ByVal Value As DateTime)
            _fechafin = Value
        End Set
    End Property
    Public Property contador As Integer
        Get
            Return _contador
        End Get
        Set(ByVal Value As Integer)
            _contador = Value
        End Set
    End Property
#End Region

#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .fechainicio = "1900-01-01 00:00:00"
            .fechafin = "1900-01-01 00:00:00"
            .contador = 0
        End With
    End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As contador)
        If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
        If Fila.Item("fechainicio") IsNot DBNull.Value Then O.fechainicio = DateTime.Parse(Fila.Item("fechainicio").ToString) Else O.fechainicio = "1900-01-01 00:00:00"
        If Fila.Item("fechafin") IsNot DBNull.Value Then O.fechafin = DateTime.Parse(Fila.Item("fechafin").ToString) Else O.fechafin = "1900-01-01 00:00:00"
        If Fila.Item("contador") IsNot DBNull.Value Then O.contador = Fila.Item("contador") Else O.contador = 0
    End Sub
    Public Sub FillUltimoContador(ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                'Dim Lista As New List(Of cliente)
                With exe
                    .CommandText = "UltimoContador"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    If Dt.Rows.Count > 0 Then
                        Dim Fila As DataRow = Dt.Rows(0)
                        CargarFila(Fila, Me)
                    End If

                End With
                ' Return Lista
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Nuevo(ByVal fechainicio As DateTime, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "NuevoContador"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    .Parameters.AddWithValue("fechainicio", fechainicio)
                    exe.ExecuteNonQuery()
                    'Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    'Ta.Fill(Dt)
                    'If Dt.Rows.Count > 0 Then
                    '    Dim Fila As DataRow = Dt.Rows(0)
                    '    CargarFila(Fila, Me)
                    'End If

                End With
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Actualizar(ByVal idparam As Integer,ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "ActualizarContador"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    .Parameters.AddWithValue("idparam", idparam)
                    exe.ExecuteNonQuery()
                   
                End With
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Cerrar(ByVal idparam As Integer, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "CerrarContador"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    .Parameters.AddWithValue("idparam", idparam)
                    exe.ExecuteNonQuery()

                End With
            End Using
        Catch ex As Exception
        End Try
    End Sub
#End Region
   
End Class
