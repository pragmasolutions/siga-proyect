Imports System.Windows.Forms
Imports modEntities
Public Class DlgEntidad
    Dim Cls As New ClsEntidades
    Dim EntidadBindingSource As New BindingSource
    ' Dim conDep As Boolean = False
#Region "Inicializar"
    Public Sub New() 'Optional ByVal conDeposito As Boolean = False)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dgvEntidad.AutoGenerateColumns = False
        '  conDep = conDeposito
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="LstEnti"></param>
    ''' <param name="blacklist">si es true toma la lista que le pasamos como parametro como una blacklist</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal LstEnti As List(Of entidad), ByVal blacklist As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dgvEntidad.AutoGenerateColumns = False

        If blacklist Then
            Cls.BlackListEntidad = LstEnti
        Else
            Cls.lstEntidad = LstEnti
            EntidadBindingSource.DataSource = Cls.lstEntidad
        End If
    
        'si llamo a esta pantalla desde otra saco el click derecho si no se podria hacer un bucle
        '  DGVEntidad.ContextMenuStrip = Nothing
        'ContextMenuStrip1.Enabled = False
    End Sub
    Private Sub DlgEntidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        dgvEntidad.DataSource = EntidadBindingSource
        Me.txtApellido.Control.Select()
    End Sub
#End Region
#Region "Aceptar Cancel"
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If dgvEntidad.SelectedRows.Count = 1 Then
            Cls.Entidad = EntidadSeleccionada()
            'If conDep And Cls.Entidad.lst_DepositoEntidad.Count = 0 Then
            '    Cls.CrearDepositoEntidad()
            '    MessageBox.Show("Se ha creado un depósito de Salida para la entidad.", "Nuevo Depósito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
            Me.Tag = Cls.Entidad
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region
#Region "Context"
    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        Dim Frm As Form
        Frm = ClsPermisos.loadForm(New FrmEntidad)
        Frm.MdiParent = Nothing
        Frm.ShowDialog()
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If dgvEntidad.SelectedRows.Count > 0 Then
            Dim Dlg As New FrmEntidad(EntidadSeleccionada)
            If Dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                EntidadBindingSource.ResetBindings(False)
            End If
        End If
    End Sub
#End Region
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim dni As Integer
        If txtDNI.Text = "" Then
            dni = 0
        Else
            dni = CInt(txtDNI.Text.Trim)
        End If

        If Cls.BlackListEntidad.Count = 0 Then
            Cls.BuscarEntidades(txtApellido.Text.Trim, txtNombre.Text.Trim, dni)
        Else
            Cls.BuscarEntidades(txtApellido.Text.Trim, txtNombre.Text.Trim, dni, Cls.BlackListEntidad)
        End If
        EntidadBindingSource.DataSource = Cls.lstEntidad
        If EntidadBindingSource.List.Count > 0 Then
            EntidadBindingSource.ResetBindings(False)
        Else
            MsgBox("No se encontraron resultados para la busqueda")
            txtApellido.SelectAll()
            txtNombre.SelectAll()
            txtDNI.SelectAll()
        End If
    End Sub
  
#Region "Navegacion"
    Private Sub txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress, txtNombre.KeyPress
        If e.KeyChar = Chr(13) Then
            btnBuscar_Click(sender, e)
        End If
    End Sub
    Private Function EntidadSeleccionada() As entidad
        If EntidadBindingSource.Position <> -1 Then
            Dim e As New entidad
            e = EntidadBindingSource.Item(EntidadBindingSource.Position)
            Return EntidadBindingSource.Item(EntidadBindingSource.Position)
        Else : Return Nothing
        End If
    End Function
    Private Sub dgvEntidad_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEntidad.CellDoubleClick
        Cls.Entidad = EntidadSeleccionada()
        btnAceptar_Click(sender, e)
    End Sub
#End Region

End Class
