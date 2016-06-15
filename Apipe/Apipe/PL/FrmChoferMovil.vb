Public Class FrmChoferMovil
    Dim cls As New ClsMovil
    Dim bgsChoferMovil As New BindingSource


#Region "Inicializar"
    Public Sub New(Optional ByVal soloSeleccion As Boolean = False, Optional ByVal soloVigentes As Boolean = True, Optional ByVal filtrarActivos As String = "TODOS")
        InitializeComponent()
        If soloSeleccion Then spcTodo.Panel2Collapsed = True
        chkSoloVigentes.Checked = soloSeleccion
        cbxActivos.ComboBox.DataSource = ClsEnumerados.Instancia.lst_EstadoChoferMovil
        cbxActivos.ComboBox.Text = filtrarActivos.ToUpper
    End Sub
    Private Sub FrmChoferMovil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvChoferMovil.AutoGenerateColumns = False
        dgvChoferMovil.DataSource = bgsChoferMovil
        btnBuscar_Click(Nothing, Nothing)
    End Sub
#End Region
#Region "Navegación"
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        cls.CargarChoferMovil(chkSoloVigentes.Checked, cbxActivos.Text)
        bgsChoferMovil.DataSource = cls.lst_ChoferMovil
    End Sub
    Private Sub chkFin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFin.CheckedChanged
        dtpFin.Visible = chkFin.Checked
    End Sub
    Private Sub dgvChoferMovil_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvChoferMovil.SelectionChanged
        If bgsChoferMovil.Position > -1 Then
            cls.ChoferMovil = bgsChoferMovil.Item(bgsChoferMovil.Position)
            CargarDatos()
        Else
            cls.ChoferMovil = Nothing
            LimpiarDatos()
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        LimpiarDatos()
        cls.ChoferMovil.EstadoFila = "N"
        Habilitar(True)
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If bgsChoferMovil.Position > -1 Then
            cls.ChoferMovil.EstadoFila = "U"
            Habilitar(True)
        End If
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren Then
            With cls.ChoferMovil 'chofer_id y movil_id ya están cargados
                .inicio = dtpInicio.Value
                If chkFin.Checked Then
                    .fin = dtpFin.Value
                Else : .fin = "1900-01-01 00:00:00"
                End If
                .observacion = txtObservaciones.Text
                Dim exito As Boolean = False
                cls.IniciarTrn()
                Try
                    cls.PersistirChoferMovil()
                    cls.gettrn.Commit()
                    exito = True
                    MessageBox.Show("Los datos se han guardado con éxito.", "Éxito")
                Catch ex As Exception
                    cls.gettrn.Rollback()
                    MessageBox.Show("Ha ocurrido un error al intentar guardar los datos." & vbNewLine & ex.Message)
                End Try
                If exito Then
                    btnCancelar_Click(Nothing, Nothing)
                End If
            End With
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        cls.ChoferMovil = Nothing
        Habilitar(False)
        dgvChoferMovil_SelectionChanged(Nothing, Nothing)
    End Sub
#End Region
#Region "Procedimientos"
    Private Sub Habilitar(ByVal valor As Boolean)
        cbxActivos.Enabled = valor
        btnGuardar.Enabled = valor
        btnCancelar.Enabled = valor
        btnNuevo.Enabled = Not valor
        btnModificar.Enabled = Not valor
    End Sub
    Private Sub CargarDatos()
        With cls.ChoferMovil
            lblChofer.Text = .v_chofer_AyN
            lblMovil.Text = .v_Movil
            dtpInicio.Value = .inicio
            dtpFin.Value = .fin
            chkFin.Checked = (.fin <> "1900-01-01 00:00:00")
            txtObservaciones.Text = .observacion
        End With
    End Sub
    Private Sub LimpiarDatos()
        cls.ChoferMovil = Nothing
        lblChofer.Text = "(Seleccione un chofer...)"
        lblMovil.Text = "(Seleccione un móvil...)"
        dtpInicio.Value = cls.FechaHoy
        dtpFin.Value = "1900-01-01 00:00:00"
        chkFin.Checked = False
        txtObservaciones.Text = ""
    End Sub
#End Region
#Region "Guardar/Cancelar/Seleccionar"
    Private Sub dgvChoferMovil_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvChoferMovil.DoubleClick
        If bgsChoferMovil.Position > -1 Then
            Me.Tag = cls.ChoferMovil
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
#End Region

End Class