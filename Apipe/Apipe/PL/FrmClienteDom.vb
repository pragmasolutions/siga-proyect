Public Class FrmClienteDom
    Dim Cls As New ClsClientes
    Dim Telefono_Numero As String
    Dim Cod_Area As Integer
    Dim clsZonas As New ClsZonas
    Dim bgsbarrio, bgscalle, bgsInterseccion As New BindingSource
#Region "Inicializar"
    Public Sub New(ByVal telefono As String, ByVal caracteristica As Integer)
        InitializeComponent()
        Telefono_Numero = telefono
        Cod_Area = caracteristica
    End Sub
    Private Sub FrmClienteDom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '   CARGAMOS TODOS LOS DATOS A PARTIR DEL TELEFONO RECIBIDO
        CargarCbxTipo()
        Cls.FillTelefonoByNumeroYCarac(Telefono_Numero, Cod_Area) ' aca cargo el cls.telefono
        CargarProvincia()
        CbxProvincia.SelectedIndex = 5
        'If Cls.Telefono.id <> 0 Then
        '    CargarEntidad()
        'End If
        CbxCalle.Focus()
        cbxTipoDom.SelectedIndex = 0
        If Cod_Area = 0 Then
            lblTelefono.Text = "Número de Teléfono: " & Telefono_Numero
        Else
            lblTelefono.Text = "Número de Teléfono: " & Cod_Area & Telefono_Numero
        End If

    End Sub
    Private Sub CargarCbxTipo()

        With CbxTipo
            .DisplayMember = "descripcion"
            .ValueMember = "id"
        End With
        Cls.FillListCategoriaCliente()
        CbxTipo.DataSource = Cls.Lstcategoria
        CbxTipo.SelectedValue = 1
    End Sub
#End Region

#Region "Guardar"

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Guardar()
   End Sub

    Private Sub Guardar()
        If ControlarError() = True And ControlarErrorDom() = True Then
            Dim mensaje As String
            mensaje = "¿Desea guardar el nuevo cliente?"
            Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
            If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Guarda el Cliente

                If Cls.Telefono.id = 0 Then
                    GuardarEntidad()
                    Cls.FillListLastEntidad() ' aca cargo el cls.entidad
                    GuardarTelefono()
                    GuardarCliente()
                    GuardarDomiclio()
                Else
                    'ModificarEntidad()
                    ' ModificarTipoCliente()
                End If

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Else
           
        End If
    End Sub

#Region "Nuevo"
    Private Sub GuardarEntidad()
        If Me.ValidateChildren Then
            With Cls.entidad
                .apellido = TxtApellido.Text
                .nombre = TxtNombre.Text
                'CARGAR TIPO DE CLIENTE
                .observacion = TxtObservaciones.Text
            End With
            Cls.IniciarTrn()

            Try
                Cls.PreservarEntidad(Cls.entidad.apellido, Cls.entidad.nombre, Cls.entidad.observacion)
                Cls.gettrn.Commit()
            Catch ex As Exception
                Cls.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub GuardarTelefono()
        If Me.ValidateChildren Then
            With Cls.Telefono
                .tipo = CbxTipo.SelectedValue
                .cod_area = Cod_Area
                .numero = Telefono_Numero
                .entidad_id = Cls.LstEntidad.First().id

            End With
            Cls.IniciarTrn()

            Try
                Cls.PreservarTelefono(Cls.Telefono.tipo, Cls.Telefono.cod_area, Cls.Telefono.numero, Cls.Telefono.entidad_id)
                Cls.gettrn.Commit()
            Catch ex As Exception
                Cls.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub GuardarCliente()
        With Cls.cliente
            .entidad_id = Cls.LstEntidad.First().id
            .cliente_categoria_id = CbxTipo.SelectedValue
        End With
        Cls.IniciarTrn()

        Try
            Cls.PreservarCliente(Cls.cliente.entidad_id, Cls.cliente.cliente_categoria_id)
            Cls.gettrn.Commit()
        Catch ex As Exception
            Cls.gettrn.Rollback()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#Region "Domicilios"

    Private Sub GuardarDomiclio()
        'agregado: Cargar id de telefono guardado de acuerdo a la entidad
        Cls.FillTelefonobyEntidad(Cls.LstEntidad.First().id)

        If ControlarErrorDom() = True Then

            If Me.ValidateChildren Then
                With Cls.domicilio
                    .calle = CbxCalle.Text
                    If TxtNumero.Text <> "" Then
                        .numero = TxtNumero.Text
                    End If

                    .tipo = cbxTipoDom.Text
                    .descripcion = TxtDescripcion.Text
                    .interseccion = cbxInterseccion.Text
                    .observacion = txtDomObs.Text
                    .barrio_id = CbxBarrio.SelectedValue
                    'End If


                End With
                Cls.IniciarTrn()

                Try
                    'CONTROLARR
                    Cls.Preservardomicilio(Cls.domicilio.calle, Cls.domicilio.numero, Cls.domicilio.tipo, Cls.domicilio.descripcion, Cls.domicilio.interseccion, Cls.domicilio.observacion, Cls.domicilio.barrio_id, Cls.domicilio.zona_id, Cls.LstTelefono.First().id)
                    Cls.gettrn.Commit()
                Catch ex As Exception
                    Cls.gettrn.Rollback()
                    MessageBox.Show(ex.Message)
                End Try
            End If

          DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

#Region "Generacion de descipcion"

    Private Sub CargarDescripcion()
        ' Carga en descripcion los campos "Agregados" para mantener un estandar en el IVR
        TxtDescripcion.Text = ""

        If TxtPiso.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; piso " + TxtPiso.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Piso " + TxtPiso.Text
            End If
        End If

        If TxtDepartamento.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; departamento " + TxtDepartamento.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Departamento " + TxtDepartamento.Text
            End If
        End If

        If TxtVivienda.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; vivienda " + TxtVivienda.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Vivienda " + TxtVivienda.Text
            End If
        End If

        If TxtManzana.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; manzana " + TxtManzana.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Manzana " + TxtManzana.Text
            End If
        End If

        If TxtSector.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; sector " + TxtSector.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Sector " + TxtSector.Text
            End If
        End If

        If TxtGrupo.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; grupo " + TxtGrupo.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Grupo " + TxtGrupo.Text
            End If
        End If

        If TxtMonoblock.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; monoblock " + TxtMonoblock.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Monoblock " + TxtMonoblock.Text
            End If
        End If

        If TxtCasa.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; casa " + TxtCasa.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Casa " + TxtCasa.Text
            End If
        End If

        If TxtLocal.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; local " + TxtLocal.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Local " + TxtLocal.Text
            End If
        End If

        If TxtOficina.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; oficina " + TxtOficina.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Oficina " + TxtOficina.Text
            End If
        End If

        If txthabitacion.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; habitación " + txthabitacion.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Habitación " + txthabitacion.Text
            End If
        End If
    End Sub

    

    Private Sub TxtPiso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPiso.TextChanged
        CargarDescripcion()
    End Sub

    
    Private Sub TxtDepartamento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDepartamento.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtVivienda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVivienda.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtManzana_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtManzana.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtSector_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSector.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtGrupo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtGrupo.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtMonoblock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMonoblock.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtCasa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCasa.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtLocal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLocal.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtOficina_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOficina.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub txthabitacion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txthabitacion.TextChanged
        CargarDescripcion()
    End Sub
#End Region

#Region "Cargar Combos"

    Private Sub CargarProvincia()
        With CbxProvincia
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
        clsZonas.FillByProvincia("")
        CbxProvincia.DataSource = clsZonas.LstProvincia


    End Sub

    Private Sub CbxProvincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxProvincia.SelectedIndexChanged
        'cada vez que se modifica el CbxProvincia volvemos a cargar las Localidades.. por defecto Corrientes
        clsZonas.FillListByProvincia(CbxProvincia.SelectedValue)
        With CbxLocalidad
            .DisplayMember = "nombre"
            .ValueMember = "id"
            '.DataSource = 
        End With
        CbxLocalidad.DataSource = clsZonas.Lstlocalidad
        'verrrrr
        If CbxProvincia.SelectedValue = 6 Then
            CbxLocalidad.SelectedIndex = 141
        Else
            CbxLocalidad.SelectedIndex = 1
        End If
    End Sub

    Private Sub CbxLocalidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxLocalidad.SelectedIndexChanged
        ' Se rellena el CbxCalle cada vez que se cambia el CbxLocalidad, con las calles de la localidad seleccionada
        VaciarCbxs()
        With CbxBarrio
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With

        clsZonas.FillBarrioByLocalidad(CbxLocalidad.SelectedValue)
        bgsbarrio.DataSource = clsZonas.LstBarrio
        CbxBarrio.DataSource = bgsbarrio
        CbxBarrio.SelectedValue = 1

        With CbxCalle
            .DisplayMember = "calle"
            .ValueMember = "id"
        End With

        With cbxInterseccion
            .DisplayMember = "calle"
            .ValueMember = "id"
        End With

        cbxInterseccion.SelectedValue = 1150
        clsZonas.FillListCalle()
        bgscalle.DataSource = clsZonas.Lstcalle
        bgsInterseccion.DataSource = clsZonas.Lstcalle
        CbxCalle.DataSource = bgscalle
        cbxInterseccion.DataSource = bgsInterseccion

    End Sub

    Private Sub VaciarCbxs()
        'Funcion que vacia los CBX calle y barrio cuando se hace un cambio de localidad
        CbxCalle.Text = ""
        CbxBarrio.Text = ""
        cbxInterseccion.Text = ""
    End Sub

#End Region

#End Region
#End Region

#End Region

#Region "Control de errores"

    
    Private Sub TxtApellido_LostFocus(sender As Object, e As System.EventArgs) Handles TxtApellido.LostFocus
        If TxtApellido.Text = "" Then
            ErrorProvider.SetError(TxtApellido, "Debe ingresar valor")
        Else
            ErrorProvider.SetError(TxtApellido, Nothing)
        End If
    End Sub

    Private Function ControlarError() As Boolean
        ' Antes de guardar se llama a esta fúnción que devuelve verdadero si no existe error
        ControlarError = False
        If TxtApellido.Text = "" Then
            ErrorProvider.SetError(TxtApellido, "Debe ingresar valor")
            ControlarError = False
        Else
            ErrorProvider.SetError(TxtApellido, Nothing)
            ControlarError = True
        End If
        Return ControlarError
    End Function

    Private Function ControlarErrorDom() As Boolean
        ' Antes de guardar se llama a esta fúnción que devuelve verdadero si no existe error
        Dim val As Integer = 0
        ControlarErrorDom = False
        If cbxTipoDom.Text = "" Then
            ErrorProviderDom.SetError(cbxTipoDom, "Debe ingresar valor")
            ControlarErrorDom = False
        ElseIf ControlarErrorDom = False Then
            ErrorProviderDom.SetError(cbxTipoDom, Nothing)
            ControlarErrorDom = True
        End If

        If TxtNumero.Text <> "" Then
            If Not Int32.TryParse(TxtNumero.Text, val) Then
                ErrorProviderDom.SetError(TxtNumero, "Debe ingresar valor numérico")
                ControlarErrorDom = False
            ElseIf Not ControlarErrorDom = False Then
                ErrorProviderDom.SetError(TxtNumero, Nothing)
                ControlarErrorDom = True
            End If
        End If

        If CbxBarrio.SelectedValue = 0 Then
            ErrorProviderDom.SetError(CbxBarrio, "Seleccionar de la lista")
            ControlarErrorDom = False
        ElseIf CbxBarrio.SelectedValue <> 0 Then
            ErrorProviderDom.SetError(CbxBarrio, Nothing)
        ElseIf Not ControlarErrorDom = False Then
            ErrorProviderDom.SetError(CbxBarrio, Nothing)
            ControlarErrorDom = True
        End If

        If CbxCalle.SelectedValue = 0 Then
            ErrorProviderDom.SetError(CbxCalle, "Seleccionar de la lista")
            ControlarErrorDom = False
        ElseIf Not ControlarErrorDom = False Then
            ErrorProviderDom.SetError(CbxCalle, Nothing)
            ControlarErrorDom = True
        End If

        If cbxInterseccion.SelectedValue = 0 Then
            ErrorProviderDom.SetError(cbxInterseccion, "Seleccionar de la lista")
            ControlarErrorDom = False
        ElseIf Not ControlarErrorDom = False Then
            ErrorProviderDom.SetError(cbxInterseccion, Nothing)
            ControlarErrorDom = True
        End If

        Return ControlarErrorDom

    End Function

    Private Sub cbxTipoDom_LostFocus(sender As Object, e As System.EventArgs) Handles cbxTipoDom.LostFocus
        'If CbxTipo.SelectedValue = "" Then
        '    ErrorProviderDom.SetError(cbxTipoDom, "Debe ingresar un tipo")
        'Else
        '    ErrorProviderDom.SetError(cbxTipoDom, Nothing)
        'End If
    End Sub

#End Region

    Private Sub btnCancela_Click(sender As System.Object, e As System.EventArgs) Handles btnCancela.Click
        Dim mensaje As String
        mensaje = "¿Desea cancelar?"

        Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
        If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Close()
        Else

        End If
    End Sub

    '#Region "Actualizar"
    '    Private Sub CargarEntidad()
    '        Cls.FillEntidadByEntidad(Cls.Telefono.entidad_id)
    '        TxtApellido.Text = Cls.entidad.apellido
    '        TxtNombre.Text = Cls.entidad.nombre
    '        TxtObservaciones.Text = Cls.entidad.observacion
    '        Cls.FillByCliente(Cls.entidad.id)
    '        CbxTipo.Text = Cls.cliente.Cliente_categoria.descripcion
    '    End Sub

    '    Private Sub ModificarEntidad()
    '        If Me.ValidateChildren Then
    '            With Cls.entidad
    '                .apellido = TxtApellido.Text
    '                .nombre = TxtNombre.Text
    '                Cls.FillByCliente(Cls.entidad.id)
    '                Cls.cliente.cliente_categoria_id = CbxTipo.SelectedValue
    '                .observacion = TxtObservaciones.Text
    '            End With
    '            Cls.IniciarTrn()

    '            Try
    '                Cls.ModificarEntidad()
    '                Cls.gettrn.Commit()
    '            Catch ex As Exception
    '                Cls.gettrn.Rollback()
    '                MessageBox.Show(ex.Message)
    '            End Try
    '        End If
    '    End Sub

    '    Private Sub ModificarTipoCliente()
    '        With Cls.cliente
    '            .entidad_id = Cls.entidad.id
    '            .cliente_categoria_id = CbxTipo.SelectedValue 'aca tambien se tiene que traer el id del tipo de categoria!!!
    '        End With
    '        Cls.IniciarTrn()

    '        Try
    '            Cls.ModificarCliente()
    '            Cls.gettrn.Commit()
    '        Catch ex As Exception
    '            Cls.gettrn.Rollback()
    '            MessageBox.Show(ex.Message)
    '        End Try

    '    End Sub
    '#End Region comentado porque no realizo actualizaciones en este formulario


    Private Sub cbxTipoDom_Leave(sender As System.Object, e As System.EventArgs) Handles cbxTipoDom.Leave
        'cbxTipoDom.BackColor = Color.White
        'If cbxTipoDom.Text.ToUpper = "casa".ToUpper Then
        '    TxtApellido.Focus()
        'ElseIf cbxTipoDom.Text.ToUpper = "departamento".ToUpper Then
        '    TxtPiso.Focus()
        'End If
        DirectCast(sender, ComboBox).BackColor = Color.White
    End Sub

#Region "color navegacion"
    Private Sub txtDomObs_Enter(sender As System.Object, e As System.EventArgs) Handles txtDomObs.Enter
        txtDomObs.BackColor = Color.Orange
    End Sub

    Private Sub txtDomObs_Leave(sender As System.Object, e As System.EventArgs) Handles txtDomObs.Leave
        txtDomObs.BackColor = Color.White
    End Sub
    Private Sub CbxProvincia_Enter(sender As System.Object, e As System.EventArgs) Handles CbxProvincia.Enter
        CbxProvincia.BackColor = Color.Orange
    End Sub

    Private Sub CbxProvincia_Leave(sender As System.Object, e As System.EventArgs) Handles CbxProvincia.Leave
        CbxProvincia.BackColor = Color.White
    End Sub


    Private Sub CbxLocalidad_Enter(sender As System.Object, e As System.EventArgs) Handles CbxLocalidad.Enter
        CbxLocalidad.BackColor = Color.Orange
    End Sub

    Private Sub CbxLocalidad_Leave(sender As System.Object, e As System.EventArgs) Handles CbxLocalidad.Leave
        CbxLocalidad.BackColor = Color.White
    End Sub

    Private Sub CbxBarrio_Enter(sender As System.Object, e As System.EventArgs) Handles CbxBarrio.Enter
        CbxBarrio.BackColor = Color.Orange
    End Sub

    Private Sub CbxBarrio_Leave(sender As Object, e As System.EventArgs) Handles CbxBarrio.Leave
        CbxBarrio.BackColor = Color.White
        ControlarErrorDom()
    End Sub

    Private Sub CbxCalle_Enter(sender As System.Object, e As System.EventArgs) Handles CbxCalle.Enter, cbxInterseccion.Enter
        sender.BackColor = Color.Orange
    End Sub

    Private Sub CbxCalle_Leave(sender As Object, e As System.EventArgs) Handles CbxCalle.Leave, cbxInterseccion.Leave
        sender.BackColor = Color.White
        ControlarErrorDom()
    End Sub

    Private Sub TxtNumero_Enter(sender As System.Object, e As System.EventArgs) Handles TxtNumero.Enter
        TxtNumero.BackColor = Color.Orange
    End Sub

    Private Sub TxtNumero_Leave(sender As Object, e As System.EventArgs) Handles TxtNumero.Leave
        TxtNumero.BackColor = Color.White
    End Sub

    Private Sub cbxTipoDom_Enter(sender As System.Object, e As System.EventArgs) Handles cbxTipoDom.Enter
        cbxTipoDom.BackColor = Color.Orange
    End Sub

    Private Sub TxtPiso_Enter(sender As System.Object, e As System.EventArgs) Handles TxtPiso.Enter
        TxtPiso.BackColor = Color.Orange
    End Sub
    Private Sub TxtPiso_Leave(sender As Object, e As System.EventArgs) Handles TxtPiso.Leave
        TxtPiso.BackColor = Color.White
    End Sub

    Private Sub TxtDepartamento_Enter(sender As System.Object, e As System.EventArgs) Handles TxtDepartamento.Enter
        TxtDepartamento.BackColor = Color.Orange
    End Sub
    Private Sub TxtDepartamento_Leave(sender As Object, e As System.EventArgs) Handles TxtDepartamento.Leave
        TxtDepartamento.BackColor = Color.White
    End Sub

    Private Sub TxtVivienda_Enter(sender As System.Object, e As System.EventArgs) Handles TxtVivienda.Enter
        TxtVivienda.BackColor = Color.Orange
    End Sub

    Private Sub TxtVivienda_Leave(sender As System.Object, e As System.EventArgs) Handles TxtVivienda.Leave
        TxtVivienda.BackColor = Color.White
    End Sub

    Private Sub TxtManzana_Enter(sender As System.Object, e As System.EventArgs) Handles TxtManzana.Enter
        TxtManzana.BackColor = Color.Orange
    End Sub

    Private Sub TxtManzana_Leave(sender As System.Object, e As System.EventArgs) Handles TxtManzana.Leave
        TxtManzana.BackColor = Color.White
    End Sub

    Private Sub TxtSector_Enter(sender As System.Object, e As System.EventArgs) Handles TxtSector.Enter
        TxtSector.BackColor = Color.Orange
    End Sub

    Private Sub TxtSector_Leave(sender As System.Object, e As System.EventArgs) Handles TxtSector.Leave
        TxtSector.BackColor = Color.White
    End Sub

    Private Sub TxtGrupo_Enter(sender As System.Object, e As System.EventArgs) Handles TxtGrupo.Enter
        TxtGrupo.BackColor = Color.Orange
    End Sub

    Private Sub TxtGrupo_Leave(sender As System.Object, e As System.EventArgs) Handles TxtGrupo.Leave
        TxtGrupo.BackColor = Color.White
    End Sub

    Private Sub TxtMonoblock_Enter(sender As System.Object, e As System.EventArgs) Handles TxtMonoblock.Enter
        TxtMonoblock.BackColor = Color.Orange
    End Sub

    Private Sub TxtMonoblock_Leave(sender As System.Object, e As System.EventArgs) Handles TxtMonoblock.Leave
        TxtMonoblock.BackColor = Color.White
    End Sub

    Private Sub TxtCasa_Enter(sender As System.Object, e As System.EventArgs) Handles TxtCasa.Enter
        TxtCasa.BackColor = Color.Orange
    End Sub

    Private Sub TxtCasa_Leave(sender As System.Object, e As System.EventArgs) Handles TxtCasa.Leave
        TxtCasa.BackColor = Color.White
    End Sub

    Private Sub TxtLocal_Enter(sender As System.Object, e As System.EventArgs) Handles TxtLocal.Enter
        TxtLocal.BackColor = Color.Orange
    End Sub

    Private Sub TxtLocal_Leave(sender As System.Object, e As System.EventArgs) Handles TxtLocal.Leave
        TxtLocal.BackColor = Color.White
    End Sub

    Private Sub TxtOficina_Enter(sender As System.Object, e As System.EventArgs) Handles TxtOficina.Enter
        TxtOficina.BackColor = Color.Orange
    End Sub

    Private Sub TxtOficina_Leave(sender As System.Object, e As System.EventArgs) Handles TxtOficina.Leave
        TxtOficina.BackColor = Color.White
    End Sub

    Private Sub txthabitacion_Enter(sender As System.Object, e As System.EventArgs) Handles txthabitacion.Enter
        txthabitacion.BackColor = Color.Orange
    End Sub

    Private Sub txthabitacion_Leave(sender As System.Object, e As System.EventArgs) Handles txthabitacion.Leave
        txthabitacion.BackColor = Color.White
    End Sub

    Private Sub TxtApellido_Enter(sender As System.Object, e As System.EventArgs) Handles TxtApellido.Enter
        TxtApellido.BackColor = Color.Orange
    End Sub
    Private Sub TxtApellido_Leave(sender As Object, e As System.EventArgs) Handles TxtApellido.Leave
        TxtApellido.BackColor = Color.White
    End Sub

    Private Sub TxtNombre_Enter(sender As System.Object, e As System.EventArgs) Handles TxtNombre.Enter
        TxtNombre.BackColor = Color.Orange
    End Sub

    Private Sub TxtNombre_Leave(sender As System.Object, e As System.EventArgs) Handles TxtNombre.Leave
        TxtNombre.BackColor = Color.White
    End Sub

    Private Sub CbxTipo_Enter(sender As System.Object, e As System.EventArgs) Handles CbxTipo.Enter
        CbxTipo.BackColor = Color.Orange
    End Sub

    Private Sub CbxTipo_Leave(sender As System.Object, e As System.EventArgs) Handles CbxTipo.Leave
        CbxTipo.BackColor = Color.White
    End Sub

    Private Sub TxtObservaciones_Enter(sender As System.Object, e As System.EventArgs) Handles TxtObservaciones.Enter
        TxtObservaciones.BackColor = Color.Orange
    End Sub

    Private Sub TxtObservaciones_Leave(sender As Object, e As System.EventArgs) Handles TxtObservaciones.Leave
        TxtObservaciones.BackColor = Color.White
    End Sub
#End Region

#Region "Accion Cerrar Frm con F2"
    Private Sub FrmClienteDom_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, CbxCalle.KeyDown, cbxTipoDom.KeyDown, CbxBarrio.KeyDown, cbxInterseccion.KeyDown, CbxLocalidad.KeyDown, CbxProvincia.KeyDown, CbxTipo.KeyDown, txtDomObs.KeyDown, txthabitacion.KeyDown, TxtApellido.KeyDown, TxtCasa.KeyDown, TxtDepartamento.KeyDown, TxtDescripcion.KeyDown, TxtGrupo.KeyDown, TxtLocal.KeyDown, TxtManzana.KeyDown, TxtMonoblock.KeyDown, TxtNombre.KeyDown, TxtNumero.KeyDown, TxtObservaciones.KeyDown, TxtOficina.KeyDown, TxtPiso.KeyDown, TxtSector.KeyDown, TxtVivienda.KeyDown, btnCancela.KeyDown, btnGuardar.KeyDown
        If e.KeyValue = Keys.F2 Then
            Me.Close()
        End If
    End Sub
#End Region

    


End Class