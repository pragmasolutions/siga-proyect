Imports modEntities
Public Class ClsPermisos
    Inherits ClsMain
    Private Shared _instancia As ClsPermisos
    Private _UsuariosRoles As List(Of usuario_rol)
    Private _Usuarios As List(Of usuario)
    Private _FormulariosRoles As List(Of formulario_rol)
    Private _Formularios As List(Of formulario)
    Private _Roles As List(Of rol)
    Private _Forms_Permitidos As List(Of String)
    Private _Usuario As usuario
    Public Shared Property Instancia() As ClsPermisos
        Get
            If _instancia Is Nothing Then
                _instancia = New ClsPermisos
            End If
            Return _instancia
        End Get
        Set(ByVal value As ClsPermisos)
            _instancia = value
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
    ''' <summary>
    ''' Hace el reset de las listas para que se vuelta a hacer el fill
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Reset()
        _instancia = New ClsPermisos
    End Sub
    Public ReadOnly Property FormulariosPermitidos(Optional ByVal VS As ClsVariableSesion = Nothing) As List(Of String)
        Get
            If VS IsNot Nothing Then
                ClsVariableSesion.Instancia = VS
            End If
            Return (From FR As formulario_rol In FormulariosRoles
                                     Join F As formulario In Formularios On FR.formulario_id Equals F.id
                                     Join UR As usuario_rol In UsuariosRoles On UR.rol_id Equals FR.rol_id
                                     Where UR.usuario_id = ClsVariableSesion.Instancia.Usuario.id Select F.nombre_form).ToList
        End Get
    End Property
    Public Property UsuariosRoles As List(Of usuario_rol)
        Get
            If _UsuariosRoles Is Nothing Then
                _UsuariosRoles = New List(Of usuario_rol)
                _UsuariosRoles = usuario_rol.FillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _UsuariosRoles
        End Get
        Set(ByVal value As List(Of usuario_rol))
            _UsuariosRoles = value
        End Set
    End Property
    Public Property Usuarios As List(Of usuario)
        Get
            If _Usuarios Is Nothing Then
                _Usuarios = New List(Of usuario)
                _Usuarios = Usuario.FillList(ClsVariableSesion.Instancia.getConn)
            End If
            Return _Usuarios
        End Get
        Set(ByVal value As List(Of usuario))
            _Usuarios = value
        End Set
    End Property
    Public Property Roles As List(Of rol)
        Get
            If _Roles Is Nothing Then
                _Roles = New List(Of rol)
                _Roles = rol.FillList(getConn)
            End If
            Return _Roles
        End Get
        Set(ByVal value As List(Of rol))
            _Roles = value
        End Set
    End Property
    Public Property Formularios As List(Of formulario)
        Get
            If _Formularios Is Nothing Then
                _Formularios = New List(Of formulario)
                _Formularios = formulario.FillList(getConn)
            End If
            Return _Formularios
        End Get
        Set(ByVal value As List(Of formulario))
            _Formularios = value
        End Set
    End Property
    Public Property FormulariosRoles As List(Of formulario_rol)
        Get
            If _FormulariosRoles Is Nothing Then
                _FormulariosRoles = New List(Of formulario_rol)
                _FormulariosRoles = formulario_rol.FillList(getConn)
            End If
            Return _FormulariosRoles
        End Get
        Set(ByVal value As List(Of formulario_rol))
            _FormulariosRoles = value
        End Set
    End Property
    Public Sub AgregarForm2Rol(ByVal Frm As formulario, ByVal IdRol As Integer)
        Dim Frm2Rol As New formulario_rol
        With Frm2Rol
            .Formulario = Frm
            .rol_id = IdRol
            .formulario_id = Frm.id
            .Insert(getConn)
        End With
        FormulariosRoles.Add(Frm2Rol)
    End Sub
    Public Sub RemoveForm2Rol(ByVal Frm As formulario, ByVal IdRol As Integer)
        Dim Frm2Rol As formulario_rol = FormulariosRoles.Find(Function(c) c.rol_id = IdRol And c.formulario_id = Frm.id)
        If Frm2Rol IsNot Nothing Then
            With Frm2Rol
                .rol_id = IdRol
                .formulario_id = Frm.id
                .Delete(getConn)
            End With
            FormulariosRoles.Remove(Frm2Rol)
        Else
            MessageBox.Show("No se encontro el formulario buscado")
        End If
    End Sub
    Public Function getListaFrm4Rol(ByVal idRol As Integer) As List(Of formulario_rol)
        Return (From objeto As formulario_rol In FormulariosRoles Where objeto.rol_id = idRol Select objeto).ToList
    End Function
    ''' <summary>
    ''' Devuelve una lista de formularios que no estan dentro de la lista de formularios roles
    ''' </summary>
    ''' <param name="idRol">ID Rol</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FillListaDisponible(ByVal idRol As Integer) As List(Of formulario)
        Return (From f As formulario In Formularios
                Where Not (From fr As formulario_rol In FormulariosRoles Where fr.rol_id = idRol Select fr.formulario_id).Contains(f.id) Order By f.v_nombre_form).ToList
    End Function
    Public Function FillListaAsignados(ByVal idRol As Integer) As List(Of formulario)
        Return (From f As formulario In Formularios
               Where (From fr As formulario_rol In FormulariosRoles Where fr.rol_id = idRol Select fr.formulario_id).Contains(f.id) Order By f.v_nombre_form).ToList
    End Function
    Public Sub AltaRol(ByVal Nombre As String)
        Dim R As New rol
        With R
            .nombre = Nombre
            .id = .Insert(getConn)
        End With
        Roles.Add(R)
    End Sub
    ''' <summary>
    ''' Funcion que verifica si el usuario tiene permisos a el formulario 
    ''' </summary>
    ''' <param name="vs"> Variable de sesion</param>
    ''' <param name="formulario">Nombre del formulario que se quiere acceder (Me.name)</param>
    ''' <returns>true</returns>
    ''' <remarks>false</remarks>
    Public Function PermitirAcceso(ByVal vs As ClsVariableSesion, ByVal formulario As String) As Boolean
        ClsVariableSesion.Instancia = vs
        If (From fp In Me.FormulariosPermitidos(ClsVariableSesion.Instancia) Where fp = formulario).ToList.Count > 0 Then
            PermitirAcceso = True
        Else
            PermitirAcceso = False
        End If
    End Function
#Region "Extraido de funciones"
    ''' <summary>
    ''' Abre el formulario
    ''' </summary>
    ''' <param name="ChildForm">Formulario a abrir</param>
    ''' <param name="Modal">Si se quiere habrir en modo modal, es decir, abrir como dialogo </param>
    ''' <remarks></remarks>
    ''' <autor>Rodrigo Dominguez</autor>
    'Public Shared Function loadForm(ByVal ChildForm As Form, ByVal OpenForms As System.Windows.Forms.FormCollection, Optional ByVal Modal As Boolean = False) As Form
    '    Return loadForm(ChildForm, OpenForms, Modal)
    'End Function

    ''' <summary>
    ''' Abre Formulario unico
    ''' </summary>
    ''' <param name="ChildForm">Formulario a abrir</param>
    ''' <param name="Modal">Si se quiere habrir en modo modal, es decir, abrir como dialogo </param>
    ''' <remarks></remarks>
    Public Shared Function loadForm(ByVal ChildForm As Form, Optional ByVal Modal As Boolean = False) As Form
        Try
            If getPermisoForm(ChildForm) Then
                Dim frm As Form = Nothing, MdiPpal As Form
                MdiPpal = MdiPrincipal(ClsSettings.getSettings.OpenForms)
                For Each frm In MdiPpal.MdiChildren
                    If ChildForm.GetType.IsInstanceOfType(frm) Then
                        frm.Select()
                        ChildForm.Dispose()
                        Return frm
                    End If
                Next
                'Solo llegamos aqui si es la primera vez q se invoca una ventana no dialogo
                If Not Modal Then
                    ChildForm.MdiParent = MdiPpal
                End If
                Return ChildForm
            Else
                Return New FrmErrorPermisos(ChildForm.Name)
            End If
        Catch ex As Exception
            MessageBox.Show("My.Resources.ERROR_NEW_FORM & vbCrLf & My.Resources.DETAIL " & ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return New FrmErrorPermisos(ChildForm.Name)
        End Try
    End Function
    Public Shared Function loadMForm(ByVal ChildForm As Form, ByVal OpenForms As FormCollection) As Form
        Try
            If getPermisoForm(ChildForm) Then
                Dim frm As Form = Nothing, MdiPpal As Form
                MdiPpal = MdiPrincipal(OpenForms)
                'Solo llegamos aqui si es la primera vez q se invoca una ventana no dialogo
                ChildForm.MdiParent = MdiPpal
                Return ChildForm
            Else
                Return New FrmErrorPermisos(ChildForm.Name)
            End If
        Catch ex As Exception
            MessageBox.Show("My.Resources.ERROR_NEW_FORM & vbCrLf & My.Resources.DETAIL" & ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return New FrmErrorPermisos(ChildForm.Name)
        End Try
    End Function
    ''' <summary>
    ''' Devuelve el MDI desde el cual se estan cargando todos los formularios
    ''' </summary>
    ''' <returns>Mdi Principal</returns>
    ''' <remarks></remarks>
    ''' <autor>Rodrigo Dominguez</autor>
    Public Shared Function MdiPrincipal(ByVal OpenForms As FormCollection) As Form
        For Each frm As Form In OpenForms
            If frm.IsMdiContainer Then
                Return frm
            End If
        Next
        Return Nothing
    End Function
    Public Shared Function MdiPrincipal(ByVal OpenForms As List(Of Windows.Forms.Form)) As Form
        For Each frm As Form In OpenForms
            If frm.IsMdiContainer Then
                Return frm
            End If
        Next
        Return Nothing
    End Function
    ''' <summary>
    ''' Verifica si el usuario tiene permiso para un formulario
    ''' </summary>
    ''' <param name="Formulario">Formulario</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getPermisoForm(ByVal Formulario As Form) As Boolean
        If (From f In Instancia.FormulariosPermitidos() Where f = Formulario.Name).ToList.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
#Region "Permisos"
    Public Sub ArmarArbolUsuariosRoles(ByVal TrV As TreeView)
        Dim arbolPadre As TreeNode
        For Each objcat As usuario In Usuarios
            arbolPadre = New TreeNode
            arbolPadre.Tag = objcat
            arbolPadre.Text = objcat.v_AyN
            TrV.Nodes.Add(arbolPadre)
            crearHijosUsuariosRoles(arbolPadre)
        Next
    End Sub
    Private Sub crearHijosUsuariosRoles(ByVal nodoPadre As TreeNode)
        Dim arbolHijo As New TreeNode
        For Each R As rol In Roles
            Dim a As New TreeNode, IdRol As Integer
            IdRol = R.id
            a.Text = R.nombre
            a.Checked = IIf(UsuariosRoles.Find(Function(c) c.rol_id = IdRol And c.usuario_id = CType(nodoPadre.Tag, usuario).entidad_id) IsNot Nothing, True, False)
            a.Tag = R
            nodoPadre.Nodes.Add(a)
        Next
    End Sub
    Public Sub AddUsuarioRol(ByVal Usr As usuario, ByVal Rol As rol)
        Dim ur As New usuario_rol
        With ur
            .rol_id = Rol.id
            .usuario_id = Usr.entidad_id
            .Insert(getConn)
        End With
        UsuariosRoles.Add(ur)
    End Sub
    Public Sub DelUsuarioRol(ByVal Usr As usuario, ByVal Rol As rol)
        Dim ur As New usuario_rol
        ur = UsuariosRoles.Find(Function(c) c.rol_id = Rol.id And c.usuario_id = Usr.entidad_id)
        With ur
            .rol_id = Rol.id
            .usuario_id = Usr.entidad_id
            .Delete(getConn)
        End With
        UsuariosRoles.Remove(ur)
    End Sub
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
#End Region
End Class
