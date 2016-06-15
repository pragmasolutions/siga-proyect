Imports MySql.Data.MySqlClient
Partial Public Class mail
    Public ReadOnly Property v_email As String
        Get
            Return Me.direccion & "@" & Me.dominio
        End Get
    End Property
    Public Shared Function getDominios() As List(Of String)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of String)
            With exe
                .Connection = ClsVariableSesion.Instancia.getConn
                .CommandText = "SELECT DISTINCT dominio FROM mail WHERE TRIM(dominio)<>''" & vbCrLf
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    For Each Fila As DataRow In Dt.Rows
                        Dim dominio As String
                        If Fila.Item("dominio") IsNot DBNull.Value Then dominio = Fila.Item("dominio") Else dominio = ""
                        Lista.Add(dominio)
                    Next
                End If
                Ta.Dispose()
                Dt.Dispose()
            End With
            Return Lista
        End Using
    End Function
End Class
