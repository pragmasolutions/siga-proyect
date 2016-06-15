Imports MySql.Data.MySqlClient

Partial Public Class usuario
    Inherits entidad
#Region "Funciones"
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of usuario)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of usuario)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM usuario u " & vbCrLf _
                             & " JOIN entidad e ON e.id=u.entidad_id" & vbCrLf _
                & " ORDER BY u.usuario"
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

    Public Shared Function FillListByEntidad(ByVal id As Integer, ByRef _Conexion As MySqlConnection) As List(Of usuario)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of usuario)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM usuario u " & vbCrLf _
                             & " JOIN entidad e ON e.id=u.entidad_id" & vbCrLf _
                             & " WHERE u.entidad_id=?id"
                .Parameters.AddWithValue("?id", id)
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
    Public Sub FillByusuario(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM usuario u" & vbCrLf _
                                 & " JOIN entidad e ON e.id=u.entidad_id" & vbCrLf _
                                 & " WHERE u.entidad_id=?id"
                    .Connection = _Conexion
                    .Parameters.AddWithValue("id", Id)
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    If Dt.Rows.Count > 0 Then
                        Dim Fila As DataRow = Dt.Rows(0)
                        CargarFila(Fila, Me)
                    End If
                    Ta.Dispose()
                    Dt.Dispose()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, "Fillbyusuario")
        End Try
    End Sub
    Private Sub CargarFila(ByRef Fila As DataRow, ByRef O As usuario)
        Dim iEnt As IEntidad
        iEnt = Me
        iEnt.CargarFila(Fila, O)
        If Fila.Item("entidad_id") IsNot DBNull.Value Then O.entidad_id = Fila.Item("entidad_id")
        If Fila.Item("usuario") IsNot DBNull.Value Then O.usuario = Fila.Item("usuario")
        If Fila.Item("password") IsNot DBNull.Value Then O.password = Fila.Item("password")
        If Fila.Item("activo") IsNot DBNull.Value Then O.activo = Fila.Item("activo")
    End Sub
    Public Sub setUsuarioIdMysqlSession()
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SET @usuario_id=?entidad_id"
                .Parameters.AddWithValue("?entidad_id", Me.entidad_id)
                .Connection = ClsVariableSesion.Instancia.getConn
                .ExecuteNonQuery()
            End With
        End Using
    End Sub
    Public Shared Function FillListByRol(ByVal rol_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of usuario)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of usuario)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM usuario u " & vbCrLf _
                            & "JOIN entidad e ON e.id=u.entidad_id" & vbCrLf _
                            & "JOIN usuario_rol ur ON u.entidad_id = ur.usuario_id" & vbCrLf _
                            & "JOIN rol r ON ur.rol_id = r.id " & vbCrLf _
                            & "where(r.id = ?rol_id)" & vbCrLf
                .Parameters.AddWithValue("rol_id", rol_id)
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
    Public Shared Function FillListBySucursal(ByVal sucursal_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of usuario)
        'Try
        Using exe As New MySqlCommand
            Dim Lista As New List(Of usuario)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM usuario u " & vbCrLf _
                            & " JOIN entidad e ON e.id=u.entidad_id" & vbCrLf _
                            & " JOIN usuario_sucursal us ON us.usuario_id=u.entidad_id" & vbCrLf _
                            & " WHERE us.sucursal_id = ?sucursal_id"
                .Parameters.AddWithValue("sucursal_id", sucursal_id)
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
    Public Overloads Function FillListByFilter(ByRef _Conexion As MySqlConnection, Optional ByVal apellido As String = "", _
                                      Optional ByVal nombre As String = "", Optional ByVal sucursal As String = "") _
                                  As List(Of usuario)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of usuario)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM usuario u " & vbCrLf _
                             & " JOIN entidad e ON e.id=u.entidad_id" & vbCrLf _
                             & " JOIN usuario_sucursal us ON us.usuario_id=u.entidad_id" & vbCrLf _
                             & " JOIN sucursal s ON us.sucursal_id=s.id" & vbCrLf _
                             & "WHERE 1=1"
                If apellido.Length > 0 Then
                    .CommandText &= " AND e.apellido LIKE ?apellido"
                    .Parameters.AddWithValue("apellido", "%" & apellido & "%")
                End If
                If nombre.Length > 0 Then
                    .CommandText &= " AND e.nombre LIKE ?nombre"
                    .Parameters.AddWithValue("nombre", "%" & nombre & "%")
                End If
                If sucursal.Length > 0 Then
                    .CommandText &= " AND  s.nombre LIKE ?sucursal"
                    .Parameters.AddWithValue("sucursal", "%" & sucursal & "%")
                End If

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
    Public Overloads Function UpdateWhitoutPassword(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean

        Dim cmd As New MySqlCommand
        Dim sqlParam As New MySqlParameter
        Dim transaction As MySqlTransaction

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
            cmd.CommandText = "UPDATE usuario SET " _
               & " usuario = ?usuario" _
               & " WHERE " _
            & " entidad_id = ?entidad_id "
            sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 5)
            sqlParam.Value = entidad_id

            sqlParam = cmd.Parameters.Add("?usuario", MySqlDbType.VarChar, 16)
            sqlParam.Value = usuario

            cmd.ExecuteNonQuery()
            If _tran Is Nothing Then
                transaction.Commit()
            End If
            _tran.Dispose()
        Catch ex As Exception
            If _tran Is Nothing Then
                transaction.Rollback()
            End If
            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function
    Public Overloads Function Clone() As usuario
        Clone = New usuario
        Dim Ie As IEntidad
        Ie = Me
        Ie.Clone()
        With Clone
            .id = Me.id
            .usuario = Me.usuario
            .password = Me.password
            .activo = Me.activo
        End With
    End Function
#End Region
End Class
