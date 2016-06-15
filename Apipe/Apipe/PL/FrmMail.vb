Imports System.Windows.Forms
Public Class FrmMail
    Dim Cls As New ClsEntidades
#Region "Inicializar"
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Sub New(ByVal E As mail)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Cls.Mail = E
    End Sub
    Private Sub FrmMail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With Cls.Mail
            txtContacto.Text = .contacto
            txtDireccion.Text = .direccion
            txtDominio.Text = .dominio
        End With
        txtDominio.AutoCompleteCustomSource = Cls.FindDominios
    End Sub
#End Region
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            With Cls.Mail
                .EstadoFila = "N"
                .contacto = txtContacto.Text
                .direccion = txtDireccion.Text
                .dominio = txtDominio.Text
            End With
            Me.Tag = Cls.Mail
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
