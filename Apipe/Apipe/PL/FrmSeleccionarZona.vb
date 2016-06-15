
Public Class FrmSeleccionarZona
    Dim zonaDef As zona
    Dim cambiarZ As Boolean

#Region "Inicializar"
    Public Sub New(Optional ByVal posicion As Point = Nothing, Optional ByVal porDefecto As zona = Nothing, Optional ByVal cambiarZona As Boolean = False)
        InitializeComponent()
        If posicion = Nothing Then
            Me.StartPosition = FormStartPosition.CenterScreen
        Else
            Dim izq As Integer = 0
            If Me.Parent IsNot Nothing Then izq = Me.Parent.Left
            Me.Left = IIf(izq > posicion.X - Me.Width, izq, posicion.X - Me.Width)
            Me.Top = posicion.Y
            'Me.Location = posicion
        End If
        zonaDef = porDefecto
        cambiarZ = cambiarZona
    End Sub
    Private Sub FrmSeleccionarZona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lst As New List(Of zona)
        If cambiarZ Then
            lklConfirmar.Text = "Confirmar"
            Dim z As New zona
            z.nombre = "(Fuera de base)"
            lst.Add(z)
        End If
        lst.AddRange(ClsEnumerados.Instancia.lstZonas)
        With cbxZona
            .DisplayMember = "nombre"
            .ValueMember = "id"
            .DataSource = lst
            If zonaDef.id > 0 Then .SelectedValue = zonaDef.id
        End With
    End Sub
#End Region
#Region "Confirmar/Cancelar"
    Private Sub lklConfirmar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklConfirmar.LinkClicked
        If cbxZona.SelectedItem IsNot Nothing Then
            Me.Tag = cbxZona.SelectedItem
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
    Private Sub lklCancelar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklCancelar.LinkClicked
        Me.Close()
    End Sub
#End Region

    'Private Sub btnVerFrecuencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerFrecuencia.Click
    '    Me.Tag = Nothing
    '    Me.DialogResult = Windows.Forms.DialogResult.OK
    '    Me.Close()
    'End Sub
End Class