Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public NotInheritable Class CompleteEvents

    Private Sub New()
    End Sub

    Public Delegate Sub CompleteHandler(ByVal args As CompleteEventArgs)
    Public Shared Event Complete As CompleteHandler

    'Public Shared Sub RaiseCompleteEvent(ByVal calculo As Integer)
    '    RaiseEvent Complete(New CompleteEventArgs(calculo))
    'End Sub
    Public Shared Sub RaiseCompleteEvent()
        RaiseEvent Complete(New CompleteEventArgs())
    End Sub
End Class

Public Class CompleteEventArgs
    Inherits EventArgs

    'Public Sub New(calculo As Integer)
    '	Me.Calculo = calculo
    'End Sub

    'Public Property Calculo() As Integer
    '	Get
    '		Return m_Calculo
    '	End Get
    '	Set
    '		m_Calculo = Value
    '	End Set
    'End Property
    '   Private m_Calculo As Integer

End Class
