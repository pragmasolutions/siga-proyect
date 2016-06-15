
Public Class FrmSeleccionarZonabtns
    Dim zonaDef As zona
    Dim cambiarZ As Boolean
    Dim cls As ClsClientes

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
#Region "Botones de subbases"
    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        cbxZona.SelectedValue = 1
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        cbxZona.SelectedValue = 2
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub

    Private Sub BtnSinBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSinBase.Click
        cbxZona.SelectedValue = 0
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        cbxZona.SelectedValue = 3
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub
    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        cbxZona.SelectedValue = 4
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub
    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        cbxZona.SelectedValue = 5
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub
    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        cbxZona.SelectedValue = 6
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub
    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        cbxZona.SelectedValue = 7
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub
    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click
        cbxZona.SelectedValue = 8
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub
    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click
        cbxZona.SelectedValue = 9
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub
    Private Sub Btn10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn10.Click
        cbxZona.SelectedValue = 10
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub
    Private Sub Btnterminal_Clic(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTerminal.Click
        cbxZona.SelectedValue = 12
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub
    Private Sub BtnBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBase.Click
        cbxZona.SelectedValue = 11
        lklConfirmar_LinkClicked(Nothing, Nothing)
    End Sub
#End Region
   
    Private Sub cbxZona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxZona.SelectedIndexChanged
        LblBase.Text = cbxZona.Text
    End Sub
End Class