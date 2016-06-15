Imports System.Reflection


Public Class AboutForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub AboutForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        labelVersion.Text = String.Format("Version {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString(3))
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Process.Start("http://www.voip-sip-sdk.com/")
        Catch exception As Exception
            Debug.WriteLine(exception)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Process.Start("mailto:" + "info@voip-sip-sdk.com")
        Catch exception As Exception
            Debug.WriteLine(exception)
        End Try
    End Sub
End Class