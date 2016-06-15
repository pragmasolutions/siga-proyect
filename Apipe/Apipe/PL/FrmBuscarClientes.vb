Public Class FrmBuscarClientes
    Dim clscliente As New ClsClientes

#Region "Inicializar"
    Private Sub FrmBuscarClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Inicializacion()
    End Sub

    Private Sub btnBorrarTodo_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrarTodo.Click
        Inicializacion()
        desHabilitarColumnas()
    End Sub
    Private Sub Inicializacion()
        dgvClientes.AutoGenerateColumns = False
        DgvEntidades.AutoGenerateColumns = False
        dgvDom.AutoGenerateColumns = False
        dgvClientes.CurrentCell = Nothing
        DgvEntidades.CurrentCell = Nothing
        dgvDom.CurrentCell = Nothing

        'Carga todos los clientes
        clscliente.FillListTelefono()
        bgsCliente.DataSource = clscliente.LstTelefono
        dgvClientes.DataSource = bgsCliente

        'carga todas las entidades
        clscliente.FillListEntidad()
        bgsEntidades.DataSource = clscliente.LstEntidad
        DgvEntidades.DataSource = bgsEntidades

        'carga todos los domicilios
        clscliente.FillListdomicilio()
        bgsDom.DataSource = clscliente.Lstdomicilio
        dgvDom.DataSource = bgsDom


    End Sub
#End Region

#Region "Busqueda"
    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub
    Private Sub txtTelefono_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTelefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            Buscar()
        End If
    End Sub

    Private Sub Buscar()

        Dim val As Integer = 0

        ' buusqueda de telefono
        If Int32.TryParse(txtTelefono.Text, val) Then
            clscliente.FillListTelefono()
            bgsEntidades.DataSource = ""
            bgsDom.DataSource = ""
            Dim a = (From cm In clscliente.LstTelefono Where cm.numero.Contains(txtTelefono.Text) Select cm)
            If a.Count = 0 Then
                bgsCliente.DataSource = ""
            Else
                bgsCliente.DataSource = a
                bgsCliente.Position = bgsCliente.List.IndexOf(a.First)
                bgsCliente.ResetCurrentItem()
            End If
        Else

            'busqueda de apellido
            ' clscliente.FillListEntidad()
            bgsCliente.DataSource = ""
            clscliente.FillListEntidad()
            Dim b = (From cm In clscliente.LstEntidad Where cm.v_AyN.ToUpper.Contains(txtTelefono.Text.ToUpper) Select cm)

            If b.Count = 0 Then
                bgsEntidades.DataSource = ""
            Else
                bgsEntidades.DataSource = b
                bgsEntidades.Position = bgsEntidades.List.IndexOf(b.First)
                bgsEntidades.ResetCurrentItem()
            End If

            'busqueda de domicilio
            clscliente.FillListdomicilio()
            Dim c = (From cm In clscliente.Lstdomicilio Where cm.calle.ToUpper.Contains(txtTelefono.Text.ToUpper) Select cm)

            If c.Count = 0 Then
                bgsDom.DataSource = ""
            Else
                bgsDom.DataSource = c
                bgsDom.Position = bgsDom.List.IndexOf(c.First)
                bgsDom.ResetCurrentItem()

            End If
        End If

    End Sub

#Region "Buscar Numeracion de domicilio"
    Private Sub dgvDom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dgvDom.KeyPress
        If Not pnlBuscarNro.Visible Then
            pnlBuscarNro.Visible = True
            If IsNumeric(e.KeyChar) Then
                txtBuscarNro_KeyPress(txtBuscarNro, e)
                txtBuscarNro.Text = e.KeyChar
                txtBuscarNro.Focus()
                txtBuscarNro.Select(txtBuscarNro.TextLength, 0)
            End If
        End If
    End Sub

    Private Sub txtBuscarNro_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarNro.KeyPress
        ' Busca un numero en la numeracion elegida  
        pnlBuscarNro.Visible = True
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim lista = (From cm In clscliente.Lstdomicilio Where cm.calle.ToUpper.Contains(txtTelefono.Text.ToUpper) Select cm)
            Dim d = (From cm In lista Where cm.numero.ToString.Contains(txtBuscarNro.Text) Select cm)
            If d.Count = 0 Then
                bgsDom.Position = -1
                dgvDom.CurrentCell = Nothing
                txtTelefono.SelectAll()
                ' bgsDom.DataSource = ""
            Else
                bgsDom.DataSource = d
                bgsDom.Position = bgsDom.List.IndexOf(d.First)
                bgsDom.ResetCurrentItem()
                pnlBuscarNro.Visible = False
                txtBuscarNro.Text = ""
            End If

        Else
            If Not (IsNumeric(e.KeyChar) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete)) Then
                e.KeyChar = Nothing
            End If
        End If
    End Sub

#End Region
#End Region

#Region "Asociar tablas"

    Private Sub dgvClientes_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvClientes.CellMouseClick
        'Seleccion de un registro de telefono

        'busqueda de la entidad
        bgsEntidades.DataSource = ""
        clscliente.FillEntidadByEntidad(CType(dgvClientes.CurrentRow.DataBoundItem, telefono).entidad_id)
        bgsEntidades.DataSource = clscliente.entidad
        DgvEntidades.DataSource = bgsEntidades

        'busqueda del domiclio
        BuscarDomicilio()

    End Sub
    
    Private Sub DgvEntidades_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvEntidades.CellContentClick
        'Seleecion de un registro de entidad
        bgsCliente.DataSource = ""
        clscliente.FillTelefonobyEntidad(CType(DgvEntidades.CurrentRow.DataBoundItem, entidad).id)
        bgsCliente.DataSource = clscliente.LstTelefono
        dgvClientes.DataSource = bgsCliente
        BuscarDomicilio()
    End Sub

    Private Sub dgvDom_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDom.CellContentClick
        'selecciono registro domicilio
        If dgvDom.Columns(domtelCalle.Name).Visible = True Then
            clscliente.FillByTelefono(CType(dgvDom.CurrentRow.DataBoundItem, telefono_domicilio).telefono_id)
        Else
            clscliente.FillTelefonobyDomicilio(CType(dgvDom.CurrentRow.DataBoundItem, domicilio).id)
            clscliente.FillByTelefono(clscliente.LstDomicilioXTelefono.First.telefono_id)
        End If

        bgsCliente.DataSource = clscliente.Telefono
        dgvClientes.DataSource = bgsCliente

        clscliente.FillEntidadByEntidad(clscliente.Telefono.entidad_id)
        bgsEntidades.DataSource = clscliente.entidad
        DgvEntidades.DataSource = bgsEntidades
    End Sub

    Private Sub BuscarDomicilio()
        bgsDom.DataSource = ""
        If CType(dgvClientes.CurrentRow.DataBoundItem, telefono).id <> 0 Then
            clscliente.FillDomiciliobyTelefono(CType(dgvClientes.CurrentRow.DataBoundItem, telefono).id)
            bgsDom.DataSource = clscliente.LstDomicilioXTelefono
            dgvDom.DataSource = bgsDom
            HabilitarColumnas()
        End If

    End Sub

    Private Sub HabilitarColumnas()
        'elegir que columnas mostrar
        dgvDom.Columns(domtelCalle.Name).Visible = True
        dgvDom.Columns(domCalle.Name).Visible = False
        dgvDom.Columns(domtelNumero.Name).Visible = True
        dgvDom.Columns(domnumero.Name).Visible = False
        dgvDom.Columns(teldomDescripcion.Name).Visible = True
        dgvDom.Columns(domDescripcion.Name).Visible = False
        dgvDom.Columns(coldomtelInterseccion.Name).Visible = True
        dgvDom.Columns(domInterseccion.Name).Visible = False
        dgvDom.Columns(coldomtelObservacion.Name).Visible = True
        dgvDom.Columns(domObservaciones.Name).Visible = False
        dgvDom.Columns(coldomtelTipo.Name).Visible = True
        dgvDom.Columns(domTipo.Name).Visible = False
    End Sub

    Private Sub desHabilitarColumnas()
        'elegir que columnas mostrar
        dgvDom.Columns(domtelCalle.Name).Visible = False
        dgvDom.Columns(domCalle.Name).Visible = True
        dgvDom.Columns(domtelNumero.Name).Visible = False
        dgvDom.Columns(domnumero.Name).Visible = True
        dgvDom.Columns(teldomDescripcion.Name).Visible = False
        dgvDom.Columns(domDescripcion.Name).Visible = True
        dgvDom.Columns(coldomtelInterseccion.Name).Visible = False
        dgvDom.Columns(domInterseccion.Name).Visible = True
        dgvDom.Columns(coldomtelObservacion.Name).Visible = False
        dgvDom.Columns(domObservaciones.Name).Visible = True
        dgvDom.Columns(coldomtelTipo.Name).Visible = False
        dgvDom.Columns(domTipo.Name).Visible = True
    End Sub
#End Region

   
   
    Private Sub txtTelefono_Click(sender As System.Object, e As System.EventArgs) Handles txtTelefono.Click

    End Sub
End Class