Public Class FrmMovil
    Dim Cls As New ClsClientes
    Dim movil As movil
    Dim NuevoRegistro As Boolean 'esta variable se setea a TRUE si es un nuevo registro, en una edicion se setea en FALSE
#Region "Inicializar"


    Public Sub New(ByVal movi As movil)
        'INICIALIZA EL FORM PARA EDITAR. RECIBE EL MOVIL DEL DATAGRID ANTERIOR
        InitializeComponent()
        movil = movi
        TxtNumero.Enabled = False
        CargarComponentes()
        NuevoRegistro = False
    End Sub
    Public Sub New()
        InitializeComponent()
        NuevoRegistro = True
    End Sub

    Private Sub FrmMovil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNumero.Focus()
    End Sub
#End Region
#Region "Guardar Movil"
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim mensaje As String
        If ControlarError() = False Then
            mensaje = "Existen errores en el formulario, verifiquelos y vuelva a intentar"
            Dim frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
            frm.ShowDialog()
        Else
            mensaje = "Desea guardar los datos del móvil"
            Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
            If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If NuevoRegistro = True Then
                    NuevoMovil()
                Else
                    EditarMovil()
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            End If
    End Sub
    Private Sub EditarMovil()
        If Me.ValidateChildren Then
            Cls.movil = movil
            With Cls.movil
                .numero = TxtNumero.Text
                .color = TxtColor.Text
                .chapa = TxtPatente.Text
                .marca = CbxMarca.Text
                .modelo = CbxModelo.Text
                .aire = ChbAire.CheckState

                If RdbChico.Checked Then
                    .baul = "CHICO"
                ElseIf RdbGrande.Checked Then
                    .baul = "GRANDE"
                Else
                    .baul = "NORMAL"
                End If
                .habilitacion = DtpHabilitacion.Text
                .seguro = DtpSeguro.Text
                .observacion = TxtObservacion.Text
                .telefono = TxtTelefono.Text
                .alta = DtpAlta.Text
                .baja = DtpBaja.Text
                .habilitado = ChbHabilitado.CheckState
                .titular_id = 1
                .responsable_id = 1
                .zona_id = 1
            End With
            Cls.IniciarTrn()
            Try
                Cls.GuardarEdicion()
                Cls.gettrn.Commit()
                Me.Close()
            Catch ex As Exception
                Cls.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub NuevoMovil()
        If Me.ValidateChildren Then
            With Cls.movil
                .numero = TxtNumero.Text
                .color = TxtColor.Text
                .chapa = TxtPatente.Text
                .marca = CbxMarca.Text
                .modelo = CbxModelo.Text
                .aire = ChbAire.CheckState

                If RdbChico.Checked Then
                    .baul = "CHICO"
                ElseIf RdbGrande.Checked Then
                    .baul = "GRANDE"
                Else
                    .baul = "NORMAL"
                End If
                .habilitacion = DtpHabilitacion.Text
                .seguro = DtpSeguro.Text
                .observacion = TxtObservacion.Text
                .telefono = TxtTelefono.Text
                .alta = DtpAlta.Text
                .baja = DtpBaja.Text
                .habilitado = ChbHabilitado.CheckState
                .titular_id = 1
                .responsable_id = 1
                .zona_id = 1
            End With
            Cls.IniciarTrn()
            Try
                Cls.PreservarMovil()
                Cls.gettrn.Commit()
                Me.Close()
            Catch ex As Exception
                Cls.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
#End Region
#Region "Botones"
    Private Sub btnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.Click
        Me.Close()
    End Sub

#End Region
#Region "Control de errores"
    Private Function ControlarError() As Boolean
        Dim val As Integer = 0
        If NuevoRegistro = True Then
            Try
                Cls.EncontrarDuplicado(TxtNumero.Text)
            Catch ex As Exception
            End Try
        End If
        ControlarError = False

        If TxtNumero.Text = "" Then
            ErpMovil.SetError(TxtNumero, "Debe ingresar valor")
            ControlarError = False
        ElseIf ControlarError = False Then
            ErpMovil.SetError(TxtNumero, Nothing)
            ControlarError = True
        End If

        If Not Int32.TryParse(TxtNumero.Text, val) Then
            ErpMovil.SetError(TxtNumero, "Debe ingresar valor numérico")
            ControlarError = False
        ElseIf Not ControlarError = False Then
            ErpMovil.SetError(TxtNumero, Nothing)
            ControlarError = True
        End If

        If TxtNumero.Text <> "" And Cls.LstMovil.Count > 0 And NuevoRegistro = True Then
            ErpMovil.SetError(TxtNumero, "Numero de movil existente")
            ControlarError = False
        ElseIf Not ControlarError = False Then
            ErpMovil.SetError(TxtNumero, Nothing)
            ControlarError = True
        End If
        Return ControlarError
    End Function
    Private Sub TxtNumero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNumero.LostFocus
        Try
            Cls.EncontrarDuplicado(TxtNumero.Text)
        Catch ex As Exception

        End Try
        Dim val As Integer = 0

        If TxtNumero.Text = "" Then
            ErpMovil.SetError(TxtNumero, "Debe ingresar valor")
        ElseIf Not Int32.TryParse(TxtNumero.Text, val) Then
            ErpMovil.SetError(TxtNumero, "Debe ingresar valor numérico")
        ElseIf TxtNumero.Text <> "" And Cls.LstMovil.Count > 0 Then
            ErpMovil.SetError(TxtNumero, "Numero de movil existente")
        Else
            ErpMovil.SetError(TxtNumero, Nothing)
        End If

    End Sub
#End Region
#Region "Funciones"
    Private Sub CargarComponentes()
        With movil
            TxtNumero.Text = .numero
            TxtColor.Text = .color
            TxtPatente.Text = .chapa
            CbxMarca.Text = .marca
            CbxModelo.Text = .marca
            If .aire = True Then
                ChbAire.Checked = True
            End If
            If .baul = "CHICO" Then

                RdbChico.Checked = True
            ElseIf .baul = "GRANDE" Then

                RdbGrande.Checked = True
            Else
                RdbNormal.Checked = True
            End If
            DtpHabilitacion.Text = .habilitacion
            DtpSeguro.Text = .seguro
            TxtObservacion.Text = .observacion
            DtpAlta.Text = .alta
            DtpBaja.Text = .baja
            TxtTelefono.Text = .telefono
            If .habilitado = True Then
                ChbHabilitado.Checked = True
            End If
        End With
    End Sub
#End Region
End Class