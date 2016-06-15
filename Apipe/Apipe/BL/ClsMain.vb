Imports MySql.Data.MySqlClient
Public Class ClsMain
    Private _FechaHoy As Date = "1900-01-01 00:00:00"
    Public ReadOnly Property getConn As MySqlConnection
        Get
            Return ClsVariableSesion.Instancia.getConn
        End Get
    End Property
    Public ReadOnly Property gettrn As MySqlTransaction
        Get
            Return ClsVariableSesion.Instancia.getTrn
        End Get
    End Property
    Public Sub IniciarTrn()
        ClsVariableSesion.Instancia.IniciarTrn()
    End Sub
    Public ReadOnly Property FechaHoy() As Date
        Get
            If _FechaHoy = "1900-01-01 00:00:00" Then
                Using exe As New MySqlCommand
                    With exe
                        .Connection = getConn
                        .CommandText = "SELECT CURRENT_DATE()"
                        _FechaHoy = Date.Parse(.ExecuteScalar.ToString)
                    End With
                End Using
            End If
            Return _FechaHoy
        End Get
    End Property
    Public ReadOnly Property LastDay(Optional ByVal Fecha As Date = Nothing) As Date
        Get
            If Fecha = Nothing Then
                Fecha = FechaHoy
            End If
            Return DateSerial(Fecha.Year, Fecha.Month + 1, 0)
        End Get
    End Property
    Public ReadOnly Property FirstDay(Optional ByVal Fecha As Date = Nothing) As Date
        Get
            If Fecha = Nothing Then
                Fecha = FechaHoy
            End If
            Return DateSerial(Fecha.Year, Fecha.Month, 1)
        End Get
    End Property
    Private WriteOnly Property setUserIdVar() As Integer
        Set(ByVal value As Integer)
            If value > 0 Then
                Using exe As New MySqlCommand
                    With exe
                        .Connection = getConn
                        .CommandText = "SET @user_id=?userid"
                        .Parameters.AddWithValue("userid", value)
                        .ExecuteNonQuery()
                    End With
                End Using
            End If
        End Set
    End Property
    Public ReadOnly Property FechaHora() As Date
        Get
            Using exe As New MySqlCommand
                With exe
                    .Connection = getConn
                    .CommandText = "SELECT NOW()"
                    Return Date.Parse(.ExecuteScalar.ToString)
                End With
            End Using
        End Get
    End Property
    
End Class
