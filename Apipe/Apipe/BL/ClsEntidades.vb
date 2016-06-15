Imports MySql.Data.MySqlClient
Public Class ClsEntidades
    Inherits ClsMain
    Public NoFrmHijo As Boolean = True
#Region "Objetos"
    Private _Cliente As cliente
    Private _Entidad As entidad
    Private _ClienteCategoria As cliente_categoria
    Private _Usuario As usuario
    Private _Mail As mail
    Private _Operador As operador

    Public Property Mail() As mail
        Get
            If _Mail Is Nothing Then
                _Mail = New mail
            End If
            Return _Mail
        End Get
        Set(ByVal value As mail)
            _Mail = value
        End Set
    End Property
    Public Property Usuario() As usuario
        Get
            If _Usuario Is Nothing Then
                _Usuario = New usuario
            End If
            Return _Usuario
        End Get
        Set(ByVal value As usuario)
            _Usuario = value
        End Set
    End Property
    Public Property Entidad As entidad
        Get
            If _Entidad Is Nothing Then
                _Entidad = New entidad
            End If
            Return _Entidad
        End Get
        Set(ByVal value As entidad)
            _Entidad = value
        End Set
    End Property
    Public Property Cliente As cliente
        Get
            If _Cliente Is Nothing Then
                _Cliente = New cliente

            End If
            Return _Cliente
        End Get
        Set(ByVal value As cliente)
            _Cliente = value
        End Set
    End Property
    Public Property ClienteCategoria As cliente_categoria
        Get
            If _ClienteCategoria Is Nothing Then
                _ClienteCategoria = New cliente_categoria

            End If
            Return _ClienteCategoria
        End Get
        Set(ByVal value As cliente_categoria)
            _ClienteCategoria = value
        End Set
    End Property
  
#End Region

#Region "Listas"
    Private _lstLocalidadUsadaExt As List(Of localidad)
    Private _lstProvinciaUsadaExt As List(Of provincia)
    Private _lstClienteCategoria As List(Of cliente_categoria)
    Private _lstCliente As List(Of cliente)
    Private _lstEntidad As List(Of entidad)
    Private _lstUsuario As List(Of usuario)
    Dim _BlackListCliente As New List(Of cliente)
    Dim _BlackListEntidad As New List(Of entidad)
    Public Property BlackListCliente As List(Of cliente)
        Get
            If _BlackListCliente Is Nothing Then
                _BlackListCliente = New List(Of cliente)
            End If
            Return _BlackListCliente
        End Get
        Set(ByVal value As List(Of cliente))
            _BlackListCliente = value
        End Set
    End Property
    Public Property BlackListEntidad As List(Of entidad)
        Get
            If _BlackListEntidad Is Nothing Then
                _BlackListEntidad = New List(Of entidad)
            End If
            Return _BlackListEntidad
        End Get
        Set(ByVal value As List(Of entidad))
            _BlackListEntidad = value
        End Set
    End Property
    'Public ReadOnly Property lstProvinciaUsadaExt As List(Of provincia)
    '    Get
    '        If _lstProvinciaUsadaExt Is Nothing Then
    '            _lstProvinciaUsadaExt = New List(Of provincia)
    '            Dim l As New provincia
    '            l.nombre = "TODAS"
    '            l.id = 0
    '            _lstProvinciaUsadaExt.Add(l)
    '            _lstProvinciaUsadaExt.AddRange(ClsEnumerados.Instancia.lstProvinciaUsada)
    '        End If
    '        Return (From p As provincia In _lstProvinciaUsadaExt Order By p.id).ToList
    '    End Get
    'End Property
    'Public ReadOnly Property lstLocalidadUsadaExt As List(Of localidad)
    '    Get
    '        If _lstLocalidadUsadaExt Is Nothing Then
    '            _lstLocalidadUsadaExt = New List(Of localidad)
    '            Dim l As New localidad
    '            l.nombre = "TODAS"
    '            l.id = 0
    '            _lstLocalidadUsadaExt.Add(l)
    '            _lstLocalidadUsadaExt.AddRange(ClsEnumerados.Instancia.lstLocalidadUsada)
    '        End If
    '        Return _lstLocalidadUsadaExt
    '    End Get
    'End Property
    Public Property lstUsuario() As List(Of usuario)
        Get
            If _lstUsuario Is Nothing Then
                _lstUsuario = New List(Of usuario)
            End If
            Return _lstUsuario
        End Get
        Set(ByVal value As List(Of usuario))
            _lstUsuario = value
        End Set
    End Property
    Public Property lstCliente As List(Of cliente)
        Get
            If _lstCliente Is Nothing Then
                _lstCliente = New List(Of cliente)
            End If
            Return _lstCliente
        End Get
        Set(ByVal value As List(Of cliente))
            _lstCliente = value
        End Set
    End Property
    Public Property lstClienteCategoria As List(Of cliente_categoria)
        Get
            If _lstClienteCategoria Is Nothing Then
                _lstClienteCategoria = New List(Of cliente_categoria)
            End If
            Return _lstClienteCategoria
        End Get
        Set(ByVal value As List(Of cliente_categoria))
            _lstClienteCategoria = value
        End Set
    End Property
    Public Property lstEntidad As List(Of entidad)
        Get
            If _lstEntidad Is Nothing Then
                _lstEntidad = New List(Of entidad)
            End If
            Return _lstEntidad
        End Get
        Set(ByVal value As List(Of entidad))
            _lstEntidad = value
        End Set
    End Property
#End Region

#Region "Funciones"
    Public Sub FindClientes(ByVal apellido As String, ByVal nombre As String, ByVal nrodocumento As Integer)
        lstCliente = Cliente.FillListByFilter(getConn, apellido, nombre, nrodocumento).ToList()
    End Sub
    Public Function FindDominios() As AutoCompleteStringCollection
        Dim MySource As New AutoCompleteStringCollection()
        Dim lista As List(Of String)
        lista = Mail.getDominios
        For Each m In lista
            MySource.Add(m)
        Next
        Return MySource
    End Function
#End Region

#Region "Entidad"
    Public Sub BuscarEntidades(ByVal apellido As String, ByVal nombre As String, ByVal dni As Integer, Optional ByVal blacklist_Entidad As List(Of entidad) = Nothing)
        Dim BlackList As String = ""
        If blacklist_Entidad IsNot Nothing Then
            For Each e As entidad In blacklist_Entidad
                BlackList &= e.id & ","
            Next
            If BlackList IsNot Nothing Then
                BlackList = BlackList.Remove(BlackList.Length - 1, 1)
            End If
        End If
        lstEntidad  = Entidad.FillListByFilter(getConn, apellido, nombre, dni, BlackList)
    End Sub
    Public Function CUITValido(ByVal CUIT As String) As Boolean
        CUIT = Replace(CUIT, "-", "")
        Dim Valido As Boolean
        Valido = (CUIT.Length = 11)
        If Valido Then
            Dim Verificador As Integer = CalcularDigitoCuit(CUIT)
            Valido = (CUIT(10) = Verificador.ToString)
        End If
        Return Valido
    End Function
    Public Shared Function CalcularDigitoCuit(ByVal cuit As String) As Integer
        Dim mult As Integer() = {5, 4, 3, 2, 7, 6, 5, 4, 3, 2}
        Dim nums As Char() = cuit.ToCharArray()
        Dim total As Integer = 0
        For i As Integer = 0 To mult.Length - 1
            total += Integer.Parse(nums(i).ToString()) * mult(i)
        Next
        Dim resto = total Mod 11
        Return If(resto = 0, 0, If(resto = 1, 9, 11 - resto))
    End Function
#End Region

#Region "Cliente"
    Public Function SaveCliente() As Boolean
        Try
            If Cliente.entidad_id = 0 Or Cliente.EstadoFila_cliente = "N" Then
                Cliente.Insert(getConn, getTrn)
                PersistirTelefonosCliente()
                PersistirMailsCliente()

                lstCliente.Add(Cliente)
            Else
                Cliente.Update(getConn, getTrn)
                PersistirTelefonosCliente()
                PersistirMailsCliente()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Public Sub PersistirTelefonosCliente()
        For Each ObjTel As telefono In Cliente.lst_Telefono
            ObjTel.entidad_id = Cliente.entidad_id
            If ObjTel.EstadoFila = "N" Then
                ObjTel.id = ObjTel.Insert(getConn, gettrn)
            ElseIf ObjTel.EstadoFila = "U" Then
                ObjTel.Update(getConn, gettrn)
            ElseIf ObjTel.EstadoFila = "D" Then
                ObjTel.Delete(getConn, gettrn)
            End If
        Next
    End Sub
    Public Sub PersistirMailsCliente()
        For Each m As mail In Mail.FillListByEntidad(Cliente.entidad_id, getConn)
            m.Delete(getConn, gettrn)
        Next
        For Each m As mail In Cliente.lst_Mail
            m.entidad_id = Cliente.entidad_id
            m.Insert(getConn, gettrn)
        Next

    End Sub
    Public Sub cargarEntidadEnCliente(ByVal ent As entidad)
        With Cliente
            .entidad_id = ent.id
            .cuil = ent.cuil
            .apellido = ent.apellido
            .nombre = ent.nombre
            .estado_civil = ent.estado_civil
            .sexo = ent.sexo
            .fecha_nacimiento = ent.fecha_nacimiento
            .tipo_documento = ent.tipo_documento
            .nro_documento = ent.nro_documento
            .lst_Mail = ent.lst_Mail
            .observacion = ent.observacion
            .iva = ent.iva
            .foto = ent.foto
            .baja = ent.baja
            .lst_Telefono = ent.lst_Telefono
        End With
    End Sub
    Public Function BajaCliente() As Boolean
        IniciarTrn()
        Try
            With Cliente
                .baja = 1
                .Update(getConn, gettrn)
            End With
            gettrn.Commit()
            Return True
        Catch ex As Exception
            gettrn.Rollback()
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region "Usuario"
    Public Function SaveUsuario() As Boolean
        With Usuario 'esto lo hago para mantener la compratibilidad con los demas proyectos
            .Entidad.nro_documento = .nro_documento
            .Entidad.tipo_documento = .tipo_documento
            .Entidad.apellido = .apellido
            .Entidad.nombre = .nombre
            .Entidad.cuil = .cuil
            .Entidad.sexo = .sexo
            .Entidad.fecha_nacimiento = .fecha_nacimiento
            .Entidad.observacion = .observacion
            .Entidad.baja = .baja
        End With
        Try
            If Usuario.entidad_id = 0 Or Usuario.EstadoFila_usuario = "N" Then
                Usuario.Insert(getConn, getTrn)
                PersistirTelefonosUsuario()
                PersistirMailsUsuario()
                ClsEnumerados.Instancia.lst_Usuario.Add(Usuario)
            Else
                Usuario.Update(getConn, getTrn)
                PersistirTelefonosUsuario()
                PersistirMailsUsuario()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Public Function PersistirUsuario() As Boolean
        With Usuario
            If .EstadoFila_usuario = "N" Then
                .Insert(getConn, gettrn)
                ClsEnumerados.Instancia.lst_Usuario.Add(Usuario)
            Else
                If .EstadoFila_usuario = "U" Then
                    .Update(getConn, gettrn)
                End If
            End If
        End With
    End Function
    Public Sub PersistirTelefonosUsuario()
        For Each ObjTel As telefono In Usuario.lst_Telefono
            ObjTel.entidad_id = Usuario.entidad_id
            If ObjTel.EstadoFila = "N" Then
                ObjTel.id = ObjTel.Insert(getConn, getTrn)
            ElseIf ObjTel.EstadoFila = "U" Then
                ObjTel.Update(getConn, getTrn)
            ElseIf ObjTel.EstadoFila = "D" Then
                ObjTel.Delete(getConn, getTrn)
            End If
        Next
    End Sub
    Public Sub PersistirMailsUsuario()
        For Each m As mail In Mail.FillListByEntidad(Usuario.Entidad.id, getConn)
            m.Delete(getConn, getTrn)
        Next
        For Each m As mail In Usuario.lst_Mail
            m.entidad_id = Usuario.entidad_id
            m.Insert(getConn, getTrn)
        Next
    End Sub
    Public Sub cargarEntidadEnUsuario(ByVal ent As entidad)
        With Usuario
            .entidad_id = ent.id
            .cuil = ent.cuil
            .apellido = ent.apellido
            .nombre = ent.nombre
            .estado_civil = ent.estado_civil
            .sexo = ent.sexo
            .fecha_nacimiento = ent.fecha_nacimiento
            .tipo_documento = ent.tipo_documento
            .nro_documento = ent.nro_documento
            .lst_Mail = ent.lst_Mail
            .observacion = ent.observacion
            .iva = ent.iva
            .foto = ent.foto
            .baja = ent.baja
            .lst_Telefono = ent.lst_Telefono
        End With
    End Sub
    Public Sub PersistirOperador()
        IniciarTrn()
        Try
            Usuario.Operador.InsertUpdate(getConn, gettrn)
            gettrn.Commit()
        Catch ex As Exception
            gettrn.Rollback()
            Throw New Exception("Ha ocurrido un error al intentar guardar la frecuencia del operador." & vbNewLine & ex.Message)
        End Try
    End Sub
#End Region

#Region "Buscar relaciones"
    Public Sub BuscarEntidadesRelacionadas(ByVal apellido As String, ByVal nombre As String, ByVal dni As Integer, ByVal Formulario As String)
        lstEntidad = Entidad.FillListByFilter(getConn, apellido, nombre, dni)
        Select Case Formulario
            Case "cliente"
                If lstEntidad.Count > 0 Then
                    ClienteExistente(lstEntidad)
                Else
                    Cliente.EstadoFila_cliente = "N"
                    Cliente.EstadoFila = "N"
                End If
            Case "usuario"
                If lstEntidad.Count > 0 Then
                    UsuarioExistente(lstEntidad)
                Else
                    Usuario.EstadoFila_usuario = "N"
                    Usuario.EstadoFila = "N"
                End If
        End Select
    End Sub
    Public Sub ClienteExistente(ByVal listent As List(Of entidad))
        If MostrarMensaje(listent) Then
            If listent.Count = 1 Then
                Cliente = New cliente
                Cliente.StoreFillBycliente(listent(0).id, getConn)
                If Cliente.entidad_id <> 0 Then
                    Cliente.EstadoFila_cliente = "U"
                Else
                    Cliente.EstadoFila_cliente = "N"
                End If
                cargarEntidadEnCliente(listent(0))
            Else
                Dim Dlg As New DlgEntidad(listent, False)
                Dlg.MdiParent = Nothing
                If Dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Cliente = New cliente
                    Cliente.StoreFillByentidad(Dlg.Tag.id, getConn)
                    If Cliente.entidad_id <> 0 Then
                        Cliente.EstadoFila_cliente = "U"
                    Else
                        Cliente.EstadoFila_cliente = "N"
                    End If
                    cargarEntidadEnCliente(Dlg.Tag)
                End If
            End If
            Cliente.EstadoFila = "U"
        Else
            Cliente.EstadoFila_cliente = "N"
            Cliente.EstadoFila = "N"
        End If
    End Sub
    Public Sub UsuarioExistente(ByVal listent As List(Of entidad))
        If MostrarMensaje(listent) Then
            If listent.Count = 1 Then
                Usuario = New usuario
                Usuario.FillByusuario(listent(0).id, getConn)
                If Usuario.entidad_id <> 0 Then
                    Usuario.EstadoFila_usuario = "U"
                Else
                    Usuario.EstadoFila_usuario = "N"
                End If
                cargarEntidadEnUsuario(listent(0))
            Else
                Dim Dlg As New DlgEntidad(listent, False)
                Dlg.MdiParent = Nothing
                If Dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Usuario = New usuario
                    Usuario.FillByusuario(Dlg.Tag.id, getConn)
                    If Usuario.entidad_id <> 0 Then
                        Usuario.EstadoFila_usuario = "U"
                    Else
                        Usuario.EstadoFila_usuario = "N"
                    End If
                    cargarEntidadEnUsuario(Dlg.Tag)
                End If
            End If
            Usuario.EstadoFila = "U"
        Else
            Usuario.EstadoFila_usuario = "N"
            Usuario.EstadoFila = "N"
        End If
    End Sub
    Private Function MostrarMensaje(ByVal listent As List(Of entidad))
        Dim txt As String = ""
        Dim count As Integer
        If listent.Count > 10 Then
            count = 10
        Else
            count = listent.Count
        End If
        For i As Integer = 0 To count - 1
            txt &= listent.Item(i).v_AyN.ToString & vbCrLf
        Next
        If count = 10 Then
            txt &= "..."
        End If
        If MessageBox.Show("Se encontraron los siguientes registros con datos similares." & vbCrLf & "Desea usar alguno de ellos en vez de crear uno nuevo?" _
                        & vbCrLf & vbCrLf & txt & "...", "Registros similares", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

End Class
