' ====================================================================
' * Copyright (c) 2006 Andre Luis Azevedo (az.andrel@yahoo.com.br)
' * All rights reserved.
' *                       
' * Redistribution and use in source and binary forms, with or without
' * modification, are permitted provided that the following conditions
' * are met:
' *
' * 1. Redistributions of source code must retain the above copyright
' *    notice, this list of conditions and the following disclaimer. 
' *
' * 2. Redistributions in binary form must reproduce the above copyright
' *    notice, this list of conditions and the following disclaimer in
' *    the documentation and/or other materials provided with the
' *    distribution.
' * 
' * 3. The name "ALAZ Library" must not be used to endorse or promote 
' *    products derived from this software without prior written permission.
' *
' * 4. Products derived from this software may not be called "ALAZ" nor 
' *    may "ALAZ Library" appear in their names without prior written 
' *    permission of the author.
' * 
' * THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY
' * EXPRESSED OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
' * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR
' * PURPOSE ARE DISCLAIMED.  IN NO EVENT SHALL THE AUTHOR OR
' * ITS CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
' * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
' * NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
' * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
' * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
' * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
' * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
' * OF THE POSSIBILITY OF SUCH DAMAGE. 
' 


Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports ALAZ.MicrosoftEx.Win32Ex
Imports Microsoft.Win32

Namespace WindowsEx.FormEx

	#Region "Delegates"

	Public Delegate Sub OnMessageDelegate(ByRef m As Message)

	#End Region

	Public Class SubClassing

		#Region "Fields"

		Private FHandle As IntPtr
		Private FHandlePinned As GCHandle

		Private FNewProc As WndProcDelegate
		Private Event FOnMessageEvent As OnMessageDelegate
		Private FNewProcPinned As GCHandle

		Private FOldProc As IntPtr
		Private FMsgNumber As Integer

		#End Region

		#Region "Constructor"

		Public Sub New(msgNumber As Integer)
			FMsgNumber = msgNumber
		End Sub

		#End Region

		#Region "Methods"

		Public Sub AllocWindow()

			FNewProc = New WndProcDelegate(AddressOf WndProc)
			FNewProcPinned = GCHandle.Alloc(FNewProc)

			Dim wndclass As New WNDCLASS()
			wndclass.style = 0
			wndclass.lpfnWndProc = NativeMethods.GetProcAddress(NativeMethods.GetModuleHandle("user32.dll"), "DefWindowProcA")
			wndclass.hIcon = IntPtr.Zero
			wndclass.hCursor = IntPtr.Zero
			wndclass.hbrBackground = IntPtr.Zero
			wndclass.lpszMenuName = [String].Empty
			wndclass.lpszClassName = "ALAZSubClassingWindows"
			wndclass.hInstance = Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly().GetModules()(0))

			Dim res As Integer = NativeMethods.RegisterClass(wndclass)

			FHandle = NativeMethods.CreateWindowEx(NativeMessages.WS_EX_TOOLWINDOW, wndclass.lpszClassName, [String].Empty, NativeMessages.WS_POPUP, 0, 0, _
				0, 0, 0, 0, 0, IntPtr.Zero)

			FHandlePinned = GCHandle.Alloc(FHandle, GCHandleType.Pinned)

			If FHandle.ToInt32() > 0 Then
				FOldProc = NativeMethods.SetWindowLong(FHandle, NativeMessages.GWL_WNDPROC, Marshal.GetFunctionPointerForDelegate(FNewProc))
			End If

		End Sub

		Public Sub DeallocateWindow()
			NativeMethods.DestroyWindow(FHandle)
			FHandle = IntPtr.Zero
		End Sub

		Private Function WndProc(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr

			Dim m As New Message()
			m.HWnd = hWnd
			m.Msg = CInt(msg)
			m.LParam = lParam
			m.WParam = wParam

			If msg = FMsgNumber Then
				RaiseEvent FOnMessageEvent(m)


				m.Result = New IntPtr(1)
			Else
				m.Result = NativeMethods.CallWindowProc(FOldProc, hWnd, msg, wParam, lParam)
			End If

			Return m.Result

		End Function

		#End Region

		#Region "Properties"

        Public Custom Event OnMessage As OnMessageDelegate
            AddHandler(ByVal value As OnMessageDelegate)
                AddHandler FOnMessageEvent, value
            End AddHandler

            RemoveHandler(ByVal value As OnMessageDelegate)
                RemoveHandler FOnMessageEvent, value
            End RemoveHandler

            RaiseEvent(ByRef m As System.Windows.Forms.Message)

            End RaiseEvent
        End Event

		Public ReadOnly Property Handle() As IntPtr
			Get
				Return FHandle
			End Get
		End Property

		#End Region

	End Class

	''' <summary>
	''' NativeWindow with GCHandle implementation!
	''' </summary>
	Public Class NativeWindowEx
		Inherits NativeWindow

		#Region "Fields"

		Private Event FOnMessageEvent As OnMessageDelegate
		Private FPinnedHandle As GCHandle

		#End Region

		#Region "Constructor"

		Public Sub New(createParam As CreateParams, pinned As Boolean)

			Me.CreateHandle(createParam)

			If pinned Then
				FPinnedHandle = GCHandle.Alloc(Me.Handle, GCHandleType.Pinned)

			End If
		End Sub

		Public Sub New(handle As IntPtr, pinned As Boolean)
			Me.AssignHandle(handle)

			If pinned Then
				FPinnedHandle = GCHandle.Alloc(handle, GCHandleType.Pinned)

			End If
		End Sub

		#End Region

		#Region "Methods"

		Protected Overrides Sub WndProc(ByRef m As Message)

			MyBase.WndProc(m)

			RaiseEvent FOnMessageEvent(m)

		End Sub

		#End Region

		#Region "Properties"

		Public ReadOnly Property PinnedHandle() As GCHandle
			Get
				Return FPinnedHandle
			End Get
		End Property

        Public Custom Event OnMessage As OnMessageDelegate
            AddHandler(ByVal value As OnMessageDelegate)
                AddHandler FOnMessageEvent, value
            End AddHandler

            RemoveHandler(ByVal value As OnMessageDelegate)
                RemoveHandler FOnMessageEvent, value
            End RemoveHandler

            RaiseEvent(ByRef m As System.Windows.Forms.Message)

            End RaiseEvent
        End Event

		#End Region

	End Class

End Namespace
