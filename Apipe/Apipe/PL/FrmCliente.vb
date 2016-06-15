Public Class FrmCliente
    Dim Cls As New ClsClientes
    Dim Telefono_Numero As Integer
    Dim Cod_Area As Integer
#Region "Inicializar"
    Public Sub New(ByVal telefono As Integer, ByVal caracteristica As Integer)
        InitializeComponent()
        Telefono_Numero = telefono
        Cod_Area = caracteristica
    End Sub
    Private Sub FrmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '   CARGAMOS TODOS LOS DATOS A PARTIR DEL TELEFONO RECIBIDO
        CargarCbxTipo()
        Cls.FillTelefonoByNumeroYCarac(Telefono_Numero, Cod_Area)
        If Cls.Telefono.id <> 0 Then
            CargarEntidad()
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
        Dim mensaje As String
        mensaje = "¿Desea guardar el nuevo cliente?"
        Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
        If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            If ControlarError() = True Then
                If Cls.Telefono.id = 0 Then
                    GuardarEntidad()
                    Cls.FillListLastEntidad()
                    GuardarTelefono()
                    GuardarCliente()
                Else
                    ModificarEntidad()
                    ModificarTipoCliente()
                End If

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

#Region "Nuevo"
    Private Sub GuardarEntidad()
        If Me.ValidateChildren Then
            With Cls.entidad
                .apellido = TxtApellido.Text
                .nombre = TxtNombre.Text
                'CARGAR TIPO DE CLIENTE
                .estado_civil = TxtEstado.Text
                .sexo = TxtSexo.Text
                '.fecha_nacimiento = DTPNac.Text
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
                .entidad_id = Cls.entidad.id ' corregir
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
            .entidad_id = Cls.entidad.id
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
#End Region

#Region "Actualizar"
    Private Sub CargarEntidad()
        Cls.FillEntidadByEntidad(Cls.Telefono.entidad_id)
        TxtApellido.Text = Cls.entidad.apellido
        TxtNombre.Text = Cls.entidad.nombre
        TxtEstado.Text = Cls.entidad.estado_civil
        TxtSexo.Text = Cls.entidad.sexo
        TxtObservaciones.Text = Cls.entidad.observacion
        Cls.FillByCliente(Cls.entidad.id)
        CbxTipo.Text = Cls.cliente.Cliente_categoria.descripcion
    End Sub

    Private Sub ModificarEntidad()
        If Me.ValidateChildren Then
            With Cls.entidad
                .apellido = TxtApellido.Text
                .nombre = TxtNombre.Text
                Cls.FillByCliente(Cls.entidad.id)
                Cls.cliente.cliente_categoria_id = CbxTipo.SelectedValue
                .estado_civil = TxtEstado.Text
                .sexo = TxtSexo.Text
                '.fecha_nacimiento = DTPNac.Text
                .observacion = TxtObservaciones.Text
            End With
            Cls.IniciarTrn()

            Try
                Cls.ModificarEntidad()
                Cls.gettrn.Commit()
            Catch ex As Exception
                Cls.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ModificarTipoCliente()
        With Cls.cliente
            .entidad_id = Cls.entidad.id
            .cliente_categoria_id = CbxTipo.SelectedValue 'aca tambien se tiene que traer el id del tipo de categoria!!!
        End With
        Cls.IniciarTrn()

        Try
            Cls.ModificarCliente()
            Cls.gettrn.Commit()
        Catch ex As Exception
            Cls.gettrn.Rollback()
            MessageBox.Show(ex.Message)
        End Try

    End Sub
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

#End Region

    Private Sub btnCancela_Click(sender As System.Object, e As System.EventArgs) Handles btnCancela.Click
        Dim mensaje As String
        mensaje = "¿Desea cancelar?"

        Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
        If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtApellido_Enter(sender As System.Object, e As System.EventArgs) Handles TxtApellido.Enter
        TxtApellido.BackColor = Color.Orange
    End Sub

    Private Sub TxtApellido_Leave(sender As System.Object, e As System.EventArgs) Handles TxtApellido.Leave
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

    Private Sub TxtObservaciones_Leave(sender As System.Object, e As System.EventArgs) Handles TxtObservaciones.Leave
        TxtObservaciones.BackColor = Color.White
    End Sub
End Class