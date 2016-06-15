Imports System.Runtime.InteropServices

Namespace Win32Ex

	#Region "Delegates"

	Public Delegate Function WndProcDelegate(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr

	#End Region

	#Region "Structs"

	<StructLayout(LayoutKind.Sequential)> _
	Public Structure WNDCLASS
		Public style As Integer
		Public lpfnWndProc As IntPtr
		Public cbClsExtra As Integer
		Public cbWndExtra As Integer
		Public hInstance As IntPtr
		Public hIcon As IntPtr
		Public hCursor As IntPtr
		Public hbrBackground As IntPtr
		Public lpszMenuName As String
		Public lpszClassName As String
	End Structure

	#End Region

	Public Class NativeMessages
		Public Shared ReadOnly GWL_WNDPROC As Integer = -4
		Public Shared ReadOnly WS_EX_TOOLWINDOW As UInteger = &H80
		Public Shared ReadOnly WS_POPUP As UInteger = &H80000000UI
	End Class

	Public Class NativeMethods

		<DllImport("kernel32")> _
		Public Shared Function GetModuleHandle(modName As String) As IntPtr
		End Function

		<DllImport("kernel32")> _
		Public Shared Function GetProcAddress(hModule As IntPtr, lpProcName As String) As IntPtr
		End Function

		<DllImport("user32")> _
		Public Shared Function SetWindowLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As IntPtr) As IntPtr
		End Function

		<DllImport("user32")> _
		Public Shared Function CallWindowProc(lpPrevWndFunc As IntPtr, hWnd As IntPtr, Msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
		End Function

		<DllImport("user32")> _
		Public Shared Function GetWindowLong(hWnd As IntPtr, nIndex As Integer) As IntPtr
		End Function

		<DllImport("user32")> _
		Public Shared Function DefWindowProc(hWnd As IntPtr, Msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
		End Function

		<DllImport("user32")> _
		Public Shared Function CreateWindowEx(dwExStyle As UInteger, lpClassName As String, lpWindowName As String, dwStyle As UInteger, X As Integer, Y As Integer, _
			nWidth As Integer, nHeight As Integer, hWndParent As Integer, hMenu As Integer, hInstance As Integer, lpParam As IntPtr) As IntPtr
		End Function

		<DllImport("user32")> _
		Public Shared Function DestroyWindow(hWnd As IntPtr) As Integer
		End Function

		<DllImport("user32")> _
		Public Shared Function RegisterClass(ByRef wndcls As WNDCLASS) As Integer
		End Function


	End Class
End Namespace
