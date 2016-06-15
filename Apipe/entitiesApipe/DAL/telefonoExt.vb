Imports MySql.Data.MySqlClient
Partial Public Class telefono

    Public ReadOnly Property v_AyNom As String
        Get
            Return Me.v_Apellido.Trim & ", " & Me.v_Nombre.Trim
        End Get
    End Property

#Region "Funciones"
    Public Function FillListByFilter(ByRef _Conexion As MySqlConnection, ByVal nroTel As String, Optional ByVal codArea As String = "") As List(Of telefono)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of telefono)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM telefono t" _
                    & " WHERE  numero=?nroTel"
                .Parameters.AddWithValue("?nroTel", nroTel)
                If codArea <> "" Then
                    .CommandText &= " AND cod_area= ?codArea"
                    .Parameters.AddWithValue("?codArea", codArea)
                End If
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
    Public Overloads Shared Function FillListNombre(ByRef _Conexion As MySqlConnection) As List(Of telefono)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of telefono)
            With exe
                .CommandText = "SELECT v_ayNom FROM telefono t"
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
#End Region

End Class
