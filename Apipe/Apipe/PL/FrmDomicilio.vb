Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Public Class FrmDomicilio
    Dim DomicilioRecibido As domicilio
    Dim telefono_id As Integer
    Dim ClsCD As New ClsClientes
    Dim clsZonas As New ClsZonas
    Dim bgsbarrio, bgscalle, bgsinterseccion As New BindingSource
    Dim barrio As String = ""
    Dim Calle As String = ""

#Region "Inicializar"
    Public Sub New(ByVal Domici As domicilio)
        InitializeComponent()
        DomicilioRecibido = Domici
    End Sub

    Public Sub New(ByVal telefono As Integer)
        InitializeComponent()
        telefono_id = telefono
    End Sub

    Private Sub FrmDomicilio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DomicilioRecibido Is Nothing Then
            CargarProvincia()
            CbxProvincia.SelectedIndex = 5
            btnEdicion.Visible = False
            btnGuardarNuevo.Visible = True
            ClsCD.FillByTelefono(telefono_id)
        Else
            btnGuardarNuevo.Visible = False
            btnEdicion.Visible = True
            ClsCD.domicilio = DomicilioRecibido
            CargarTextBoxs()
            CargarCamposDescripcion()
            ClsCD.FillByTelefono(DomicilioRecibido.lst_TelefonoDomicilio.First.telefono_id)
        End If
        CbxCalle.Focus()
        cbxTipo.SelectedIndex = 0
        If ClsCD.Telefono.cod_area = "" Then
            lblTelefono.Text = "Número de Teléfono: " & ClsCD.Telefono.numero
        Else
            lblTelefono.Text = "Número de Teléfono: " & ClsCD.Telefono.cod_area & ClsCD.Telefono.numero
        End If
        If ClsCD.Telefono.numero = 9999999 Then
            lblTelefono.Text = lblTelefono.Text & " - Número PRIVADO - "
        End If

    End Sub

#End Region

#Region "Modificar Domicilio"

    Private Sub btnEdicion_Click(sender As System.Object, e As System.EventArgs) Handles btnEdicion.Click
        ModificarDomicilio()
    End Sub

    Private Sub ModificarDomicilio()
        Dim mensaje As String
        mensaje = "¿Desea guardar las modificaciones?"
        If ControlarError() = True Then
            Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
            If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Me.ValidateChildren Then
                    With ClsCD.domicilio
                        .calle = CbxCalle.Text
                        If TxtNumero.Text <> "" Then
                            .numero = TxtNumero.Text
                        Else
                            .numero = 0
                        End If
                        .tipo = cbxTipo.Text
                        .descripcion = TxtDescripcion.Text
                        .interseccion = cbxInterseccion.Text
                        .observacion = TxtObservaciones.Text
                        ' .voz_calle_id = CbxCalle.SelectedValue
                        ' .voz_interseccion_id = cbxInterseccion.SelectedValue

                        'If CbxBarrio.SelectedValue = 0 Then
                        '    If Trim(CbxBarrio.Text) <> "" Then
                        '        With clsZonas.Barrio
                        '            .nombre = CbxBarrio.Text
                        '            .localidad_id = 5693
                        '        End With
                        '        clsZonas.IniciarTrn()
                        '        Try
                        '            clsZonas.PreservarBarrio()
                        '            clsZonas.gettrn.Commit()
                        '        Catch ex As Exception
                        '            clsZonas.gettrn.Rollback()
                        '            MessageBox.Show(ex.Message)
                        '        End Try
                        '        .barrio_id = clsZonas.Barrio.id
                        '    Else
                        '        CbxBarrio.SelectedValue = 1
                        '        .barrio_id = 1
                        '    End If
                        'Else
                        '    .barrio_id = CbxBarrio.SelectedValue
                        'End If
                        .barrio_id = CbxBarrio.SelectedValue
                    End With
                    ClsCD.IniciarTrn()

                    Try
                        ClsCD.ActualizarDomicilio(ClsCD.domicilio.id, ClsCD.domicilio.calle, ClsCD.domicilio.numero, ClsCD.domicilio.tipo, ClsCD.domicilio.descripcion, ClsCD.domicilio.interseccion, ClsCD.domicilio.observacion, ClsCD.domicilio.barrio_id, ClsCD.domicilio.zona_id)
                        ClsCD.gettrn.Commit()
                    Catch ex As Exception
                        ClsCD.gettrn.Rollback()
                        MessageBox.Show(ex.Message)
                    End Try

                Else
                    MsgBox("Controle los campos")
                End If
            End If
            DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

#End Region

#Region "Nuevo Domicilio"

    Private Sub btnGuardarNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarNuevo.Click
        NuevoDomicilio()
    End Sub

    Private Sub NuevoDomicilio()
        Dim mensaje As String
        mensaje = "¿Desea guardar el nuevo domicilio?"

        If ControlarError() = True Then
            Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
            If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Me.ValidateChildren Then
                    With ClsCD.domicilio
                        .calle = CbxCalle.Text
                        If TxtNumero.Text <> "" Then
                            .numero = TxtNumero.Text
                        End If

                        .tipo = cbxTipo.Text
                        .descripcion = TxtDescripcion.Text
                        .interseccion = cbxInterseccion.Text
                        .observacion = TxtObservaciones.Text
                        ' .voz_calle_id = CbxCalle.SelectedValue
                        '.voz_interseccion_id = cbxInterseccion.SelectedValue

                        'If CbxBarrio.SelectedValue = 0 Then
                        '    If Trim(CbxBarrio.Text) <> "" Then
                        '        With clsZonas.Barrio
                        '            .nombre = CbxBarrio.Text
                        '            .localidad_id = 5693
                        '        End With
                        '        clsZonas.IniciarTrn()
                        '        Try
                        '            clsZonas.PreservarBarrio()
                        '            clsZonas.gettrn.Commit()
                        '        Catch ex As Exception
                        '            clsZonas.gettrn.Rollback()
                        '            MessageBox.Show(ex.Message)
                        '        End Try
                        '        .barrio_id = clsZonas.Barrio.id
                        '    Else
                        '        CbxBarrio.SelectedValue = 1
                        '        .barrio_id = 1
                        '    End If
                        'Else
                        '    .barrio_id = CbxBarrio.SelectedValue
                        'End If
                        .barrio_id = CbxBarrio.SelectedValue

                    End With
                    ClsCD.IniciarTrn()

                    Try
                        ClsCD.Preservardomicilio(ClsCD.domicilio.calle, ClsCD.domicilio.numero, ClsCD.domicilio.tipo, ClsCD.domicilio.descripcion, ClsCD.domicilio.interseccion, ClsCD.domicilio.observacion, ClsCD.domicilio.barrio_id, ClsCD.domicilio.zona_id, telefono_id)
                        ClsCD.gettrn.Commit()
                        'MsgBox("Domicilio Agregado")
                    Catch ex As Exception
                        ClsCD.gettrn.Rollback()
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    MsgBox("Controle los campos")
                End If


                'If Me.ValidateChildren Then
                '    With ClsCD.Telefono_Domicilio
                '        .telefono_id = telefono_id
                '        .domicilio_id = ClsCD.domicilio.id
                '        .prioridad = 0
                '    End With
                '    ClsCD.IniciarTrn()

                '    Try
                '        ClsCD.PreservarTelefonoXDomicilio()
                '        ClsCD.gettrn.Commit()
                '    Catch ex As Exception
                '        ClsCD.gettrn.Rollback()
                '        MessageBox.Show(ex.Message)
                '    End Try
                'End If
                DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()

            Else

            End If
        End If

    End Sub

#End Region

#Region "Cargar Combos"

    Private Sub CargarProvincia()
        With CbxProvincia
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
        'FillProvincia()
        clsZonas.FillByProvincia("")
        CbxProvincia.DataSource = clsZonas.LstProvincia


    End Sub

    Private Sub CbxProvincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxProvincia.SelectedIndexChanged
        'cada vez que se modifica el CbxProvincia volvemos a cargar las Localidades.. por defecto Corrientes
        'FillLocalidadByProvincia(provincia int)

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
            'CbxLocalidad.SelectedValue = 141
        Else
            CbxLocalidad.SelectedIndex = 1
            'CbxLocalidad.SelectedValue = 1
        End If
    End Sub

    Private Sub CbxLocalidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxLocalidad.SelectedIndexChanged
        ' Se rellena el CbxCalle cada vez que se cambia el CbxLocalidad, con las calles de la localidad seleccionada
        VaciarCbxs()
        With CbxBarrio
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
        'FillBarrioByLocalidad(localidad int)
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

        clsZonas.FillListCalle()
        bgscalle.DataSource = clsZonas.Lstcalle
        bgsinterseccion.DataSource = clsZonas.Lstcalle
        CbxCalle.DataSource = bgscalle
        cbxInterseccion.DataSource = bgsinterseccion
    End Sub

    Private Sub VaciarCbxs()
        'Funcion que vacia los CBX calle y barrio cuando se hace un cambio de localidad
        'CbxCalle.Items.Clear()
        'CbxBarrio.Items.Clear()
        CbxCalle.Text = ""
        cbxInterseccion.Text = ""
        CbxBarrio.Text = ""
    End Sub

#End Region

#Region "Descripcion"

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

        If txtViviendas.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; viviendas " + txtViviendas.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Viviendas " + txtViviendas.Text
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

        If txtGrupo.Text <> "" Then
            If TxtDescripcion.Text <> "" Then
                TxtDescripcion.Text = TxtDescripcion.Text + "; grupo " + txtGrupo.Text
            Else
                TxtDescripcion.Text = TxtDescripcion.Text + "Grupo " + txtGrupo.Text
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
    Private Sub TxtManzana_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtManzana.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtSector_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSector.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtPiso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPiso.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtMonoblock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMonoblock.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtCasa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCasa.TextChanged
        CargarDescripcion()
    End Sub
    Private Sub TxtDepartamento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDepartamento.TextChanged
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
    Private Sub txtViviendas_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtViviendas.TextChanged
        CargarDescripcion()
    End Sub

    Private Sub txtGrupo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtGrupo.TextChanged
        CargarDescripcion()
    End Sub
#End Region

#Region "Recuperacion de descripcion"

    Private Sub CargarCamposDescripcion()
        'Esta sub carga los campos individuales de descripcion. solo para cuando se esta modificando un domicilio

        Dim cadena As String
        Dim tabla() As String
        Dim n As Integer

        cadena = TxtDescripcion.Text
        tabla = Split(cadena, ";")
        cadena = ""
        For n = 0 To UBound(tabla, 1)
            cadena = cadena + tabla(n)
        Next
        ' cadena = TxtDescripcion.Text
        tabla = Split(cadena, " ")
        For n = 0 To UBound(tabla, 1)
            'MessageBox.Show(tabla(n))
            If tabla(n).Contains("iso") Then
                TxtPiso.Text = (tabla(n + 1))

            End If

            If tabla(n).Contains("partamento") Then
                TxtDepartamento.Text = (tabla(n + 1))

            End If

            If tabla(n).Contains("zana") Then
                TxtManzana.Text = (tabla(n + 1))

            End If

            If tabla(n).Contains("viendas") Then
                txtViviendas.Text = tabla(n + 1)

            End If

            If tabla(n).Contains("ector") Then
                TxtSector.Text = tabla(n + 1)

            End If

            If tabla(n).Contains("rupo") Then
                txtGrupo.Text = tabla(n + 1)

            End If

            If tabla(n).Contains("block") Then
                TxtMonoblock.Text = (tabla(n + 1))

            End If

            If tabla(n).Contains("asa") Then
                TxtCasa.Text = (tabla(n + 1))

            End If

            If tabla(n).Contains("ocal") Then
                TxtLocal.Text = (tabla(n + 1))

            End If

            If tabla(n).Contains("cina") Then
                TxtOficina.Text = (tabla(n + 1))

            End If

            If tabla(n).Contains("bita") Then
                txthabitacion.Text = (tabla(n + 1))

            End If
        Next
    End Sub
#End Region

#End Region

#Region "Control de errores"

    Private Function ControlarError() As Boolean
        ' Antes de guardar se llama a esta fúnción que devuelve verdadero si no existe error
        Dim val As Integer = 0
        ControlarError = False
        'If TxtNumero.Text = "" Then
        '    ErrorProvider1.SetError(TxtNumero, "Debe ingresar valor")
        '    ControlarError = False
        'ElseIf ControlarError = False Then
        '    ErrorProvider1.SetError(TxtNumero, Nothing)
        '    ControlarError = True
        'End If


        ''If cbxTipo.Text = "" Then
        ''    ErrorProvider1.SetError(cbxTipo, "Debe ingresar valor")
        ''    ControlarError = False
        ''ElseIf Not ControlarError = False Then
        ''    ErrorProvider1.SetError(TxtNumero, Nothing)
        ''    ControlarError = True
        ''End If

        If cbxTipo.Text = "" Then
            ErrorProvider1.SetError(cbxTipo, "Debe ingresar valor")
            ControlarError = False
        ElseIf ControlarError = False Then
            ErrorProvider1.SetError(cbxTipo, Nothing)
            ControlarError = True
        End If


        ' clsZonas.FillBarriobyBarrio(CbxBarrio.SelectedValue)
        If CbxBarrio.SelectedValue = 0 Then
            ErrorProvider1.SetError(CbxBarrio, "Seleccionar de la lista")
            ControlarError = False
        ElseIf Not ControlarError = False Then
            ErrorProvider1.SetError(CbxBarrio, Nothing)
            ControlarError = True
        End If

        If CbxCalle.SelectedValue = 0 Then
            ErrorProvider1.SetError(CbxCalle, "Seleccionar de la lista")
            ControlarError = False
        ElseIf Not ControlarError = False Then
            ErrorProvider1.SetError(CbxCalle, Nothing)
            ControlarError = True
        End If

        If cbxInterseccion.SelectedValue = 0 Then
            ErrorProvider1.SetError(cbxInterseccion, "Seleccionar de la lista")
            ControlarError = False
        ElseIf Not ControlarError = False Then
            ErrorProvider1.SetError(cbxInterseccion, Nothing)
            ControlarError = True
        End If

        If TxtNumero.Text <> "" Then
            If Not Int32.TryParse(TxtNumero.Text, val) Then
                ErrorProvider1.SetError(TxtNumero, "Debe ingresar valor numérico")
                ControlarError = False
            ElseIf Not ControlarError = False Then
                ErrorProvider1.SetError(TxtNumero, Nothing)
                ControlarError = True
            End If
        End If
        Return ControlarError

    End Function

    Private Sub cbxTipo_LostFocus(sender As Object, e As System.EventArgs) Handles cbxTipo.LostFocus
        If cbxTipo.SelectedValue = "" Then
            ErrorProvider1.SetError(cbxTipo, "Debe ingresar un tipo")
        Else
            ErrorProvider1.SetError(cbxTipo, Nothing)
        End If
    End Sub
#End Region

    Private Sub CargarTextBoxs()

        CbxCalle.Text = DomicilioRecibido.calle
        TxtNumero.Text = DomicilioRecibido.numero
        TxtDescripcion.Text = DomicilioRecibido.descripcion
        'TxtInterseccion2.Text = DomicilioRecibido.interseccion
        cbxInterseccion.Text = DomicilioRecibido.interseccion
        TxtObservaciones.Text = DomicilioRecibido.observacion

        clsZonas.FillBarriobyBarrio(DomicilioRecibido.barrio_id)
        clsZonas.FillLocalidadByLocalidad(clsZonas.Barrio.localidad_id)
        clsZonas.FillProvinciaByProvincia(clsZonas.localidad.provincia_id)
        CargarProvincia()
        CbxProvincia.SelectedIndex = clsZonas.Provincia.id - 1
        'CbxBarrio.SelectedIndex = clsZonas.Barrio.id
        CbxBarrio.SelectedValue = DomicilioRecibido.barrio_id
        CbxCalle.Text = DomicilioRecibido.calle
        cbxInterseccion.Text = DomicilioRecibido.interseccion
        cbxTipo.Text = DomicilioRecibido.tipo
    End Sub



    Private Sub btnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.Click
        Dim mensaje As String
        mensaje = "¿Desea cancelar?"

        Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
        If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub
    '#Region "ver carga de cbx"
    '    Private Sub CbxBarrio_TextChanged(sender As System.Object, e As System.EventArgs) Handles CbxBarrio.TextChanged

    '        bgsbarrio.DataSource = ""
    '        ' clsZonas.FillBarrioByLocalidad(CbxLocalidad.SelectedValue)
    '        Dim b = (From br In clsZonas.LstBarrio Where br.nombre.ToUpper.Contains(barrio.ToUpper) Select br)
    '        If b.Count = 0 Then
    '            bgsbarrio.DataSource = clsZonas.LstBarrio
    '        Else
    '            bgsbarrio.DataSource = b
    '            bgsbarrio.Position = bgsbarrio.List.IndexOf(b.First)
    '            bgsbarrio.ResetCurrentItem()
    '        End If
    '    End Sub

    '    Private Sub CbxBarrio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CbxBarrio.KeyPress
    '        If e.KeyChar = Chr(Keys.Back) Then
    '            barrio = ""
    '        Else
    '            barrio = barrio & e.KeyChar
    '        End If


    '    End Sub

    '    Private Sub CbxCalle_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CbxCalle.KeyPress
    '        If e.KeyChar = Chr(Keys.Back) Then
    '            Calle = ""
    '        Else
    '            Calle = Calle & e.KeyChar
    '        End If
    '    End Sub

    '    Private Sub CbxCalle_TextChanged(sender As System.Object, e As System.EventArgs) Handles CbxCalle.TextChanged
    '        'If Calle <> "" Then
    '        ' MsgBox(Calle)
    '        bgscalle.DataSource = ""
    '        ' clsZonas.FillBarrioByLocalidad(CbxLocalidad.SelectedValue)
    '        Dim b = (From cl In clsZonas.Lstcalle Where cl.calle.ToUpper.Contains(Calle.ToUpper) Select cl)
    '        If b.Count = 0 Then
    '            bgscalle.DataSource = clsZonas.Lstcalle
    '        Else
    '            bgscalle.DataSource = b
    '            bgscalle.Position = bgscalle.List.IndexOf(b.First)
    '            bgscalle.ResetCurrentItem()
    '        End If
    '        '  End If
    '    End Sub
    '#End Region


#Region "Colores navegacion"

    Private Sub TxtInterseccion_Enter(sender As System.Object, e As System.EventArgs) Handles TxtObservaciones.Enter, TxtNumero.Enter, TxtPiso.Enter, TxtDepartamento.Enter, txtViviendas.Enter, TxtManzana.Enter, TxtSector.Enter, txtGrupo.Enter, TxtMonoblock.Enter, TxtCasa.Enter, TxtLocal.Enter, TxtOficina.Enter, txthabitacion.Enter
        DirectCast(sender, TextBox).BackColor = Color.Orange
    End Sub
    Private Sub TxtInterseccion_Leave(sender As System.Object, e As System.EventArgs) Handles TxtObservaciones.Leave, TxtNumero.Leave, TxtPiso.Leave, TxtDepartamento.Leave, txtViviendas.Leave, TxtManzana.Leave, TxtSector.Leave, txtGrupo.Leave, TxtMonoblock.Leave, TxtCasa.Leave, TxtLocal.Leave, TxtOficina.Leave, txthabitacion.Leave
        DirectCast(sender, TextBox).BackColor = Color.White
    End Sub
    Private Sub CbxProvincia_Enter(sender As System.Object, e As System.EventArgs) Handles CbxProvincia.Enter, CbxBarrio.Enter, CbxCalle.Enter, cbxInterseccion.Enter, CbxLocalidad.Enter, cbxTipo.Enter
        DirectCast(sender, ComboBox).BackColor = Color.Orange
    End Sub

    Private Sub CbxProvincia_Leave(sender As System.Object, e As System.EventArgs) Handles CbxProvincia.Leave, CbxBarrio.Leave, CbxCalle.Leave, cbxInterseccion.Leave, CbxLocalidad.Leave, cbxTipo.Leave
        DirectCast(sender, ComboBox).BackColor = Color.White
    End Sub

#End Region

#Region "Accion Cerrar Frm con F2"
    Private Sub FrmDomicilio_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, CbxCalle.KeyDown, cbxTipo.KeyDown, CbxBarrio.KeyDown, cbxInterseccion.KeyDown, CbxLocalidad.KeyDown, CbxProvincia.KeyDown, cbxTipo.KeyDown, TxtObservaciones.KeyDown, txthabitacion.KeyDown, TxtCasa.KeyDown, TxtDepartamento.KeyDown, TxtDescripcion.KeyDown, txtGrupo.KeyDown, TxtLocal.KeyDown, TxtManzana.KeyDown, TxtMonoblock.KeyDown, TxtNumero.KeyDown, TxtObservaciones.KeyDown, TxtOficina.KeyDown, TxtPiso.KeyDown, TxtSector.KeyDown, txtViviendas.KeyDown, btnCancela.KeyDown, btnEdicion.KeyDown, btnGuardarNuevo.KeyDown
        If e.KeyValue = Keys.F2 Then
            Me.Close()
        End If
    End Sub
#End Region
    
End Class