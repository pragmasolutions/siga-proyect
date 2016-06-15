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
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports System.Reflection
Imports System.IO

Imports ALAZ.SystemEx
Imports ALAZ.SystemEx.WindowsEx.FormEx
Imports ALAZ.SystemEx.RunTimeEx.InteropServicesEx

Imports ALAZ.TelephonyEx.Voip.IAX
Imports ALAZ.MicrosoftEx.Win32Ex

Namespace Voip.IAX

	Public Class IAXAudioDevice

		#Region "Fields"

		Private FId As Integer
		Private FName As String
		Private FCapabilities As AudioCapability

		#End Region

		#Region "Constructor"

		Friend Sub New()
		End Sub
		Friend Sub New(id As Integer, name As String, capabilities As AudioCapability)

			FId = id
			FName = name

			FCapabilities = capabilities
		End Sub

		#End Region

		#Region "Methods"

		Public Overrides Function ToString() As String
			Return FName
		End Function

		#End Region

		#Region "Properties"

		Public ReadOnly Property Id() As Integer
			Get
				Return FId
			End Get
		End Property

		Public ReadOnly Property Name() As String
			Get
				Return FName
			End Get
		End Property

		Public ReadOnly Property Capabilities() As AudioCapability
			Get
				Return FCapabilities
			End Get
		End Property

		#End Region

	End Class

	Public Class IAXAudioDevices
		Inherits ReadOnlyCollection(Of IAXAudioDevice)

		#Region "Fields"

		Private FInputDevice As Integer
		Private FOutputDevice As Integer
		Private FRingDevice As Integer

		#End Region

		#Region "Constructor"

		Public Sub New(list As IList(Of IAXAudioDevice))

				'-----            

			MyBase.New(list)
		End Sub

		#End Region

		#Region "Methods"

		Private Sub SetAudioDevices()

			If IAXFunctions.iaxc_audio_devices_set(FInputDevice, FOutputDevice, FRingDevice) <> 0 Then
				Throw New IAXMethodException("Set device error!")
			End If

		End Sub

		Public Sub SelectInputAudioDevice(deviceId As Integer)
			FInputDevice = deviceId
			SetAudioDevices()
		End Sub

		Public Sub SelectOutPutAudioDevice(deviceId As Integer)
			FOutputDevice = deviceId
			SetAudioDevices()
		End Sub

		Public Sub SelectRingAudioDevice(deviceId As Integer)
			FRingDevice = deviceId
			SetAudioDevices()
		End Sub

		#End Region

		#Region "Properties"

		Public Property SelectedInputAudioDevice() As Integer
			Get
				Return FInputDevice
			End Get
			Friend Set
				FInputDevice = value
			End Set
		End Property

		Public Property SelectedOutputAudioDevice() As Integer
			Get
				Return FOutputDevice
			End Get
			Friend Set
				FOutputDevice = value
			End Set
		End Property

		Public Property SelectedRingAudioDevice() As Integer
			Get
				Return FRingDevice
			End Get
			Friend Set
				FRingDevice = value
			End Set
		End Property

		#End Region

	End Class

	Public Class IAXLine

		#Region "Consts"

		Public Const CALLFORMAT As String = "{0}:{1}@{2}/{3}"

		#End Region

		#Region "Fields"

		Private FLineNumber As Integer
		Private FActive As Boolean
		Private FDirection As CallDirection
		Private FStatus As CallStatus
		Private FRemote As String
		Private FRemoteName As String
		Private FLocal As String
		Private FLocalContext As String

		Private FCollection As IAXLines

		Private FCallTime As Integer
		Private FCallStartTime As Integer

		#End Region

		#Region "Constructor"

		Public Sub New(collection As IAXLines, lineNumber As Integer)

			FLineNumber = lineNumber
			FActive = False
			FRemote = [String].Empty
			FRemoteName = [String].Empty

			FLocal = [String].Empty
			FLocalContext = [String].Empty
			FStatus = CallStatus.csNone

			FCollection = collection

			FCallTime = 0
		End Sub

		#End Region

		#Region "Methods"

		Public Sub MakeCall(number As String)
			Dim callMessage As String = [String].Format(CALLFORMAT, FCollection.Host.User, FCollection.Host.Password, FCollection.Host.Server, number)
			IAXFunctions.iaxc_call(callMessage)
		End Sub

		Public Sub DropCall()
			IAXFunctions.iaxc_dump_call()
		End Sub

		Public Sub AnswerCall()
			IAXFunctions.iaxc_answer_call(FLineNumber)
		End Sub

		Public Sub SendDTMF(digit As Byte)
			IAXFunctions.iaxc_send_dtmf(digit)
		End Sub

		Public Sub TransferCall(number As String)
			IAXFunctions.iaxc_blind_transfer_call(FLineNumber, number)
		End Sub

		#End Region

		#Region "Properties"

		Friend Property CallStartTime() As Integer
			Get
				Return FCallStartTime
			End Get
			Set
				FCallStartTime = value
			End Set
		End Property

		Public Property CallTime() As Integer
			Get
				Return FCallTime
			End Get
			Friend Set
				FCallTime = value
			End Set
		End Property

		Public ReadOnly Property Id() As Integer
			Get
				Return FLineNumber
			End Get
		End Property

		Public Property CallStatus() As CallStatus
			Get
				Return FStatus
			End Get
			Friend Set
				FStatus = value
			End Set
		End Property

		Public Property Active() As Boolean
			Get
				Return FActive
			End Get
			Friend Set
				FActive = value
			End Set
		End Property

		Public Property CallDirection() As CallDirection
			Get
				Return FDirection
			End Get
			Friend Set
				FDirection = value
			End Set
		End Property

		Public Property Remote() As String
			Get
				Return FRemote
			End Get
			Friend Set
				FRemote = value
			End Set
		End Property

		Public Property RemoteName() As String
			Get
				Return FRemoteName
			End Get
			Friend Set
				FRemoteName = value
			End Set
		End Property

		Public Property Local() As String
			Get
				Return FLocal
			End Get
			Friend Set
				FLocal = value
			End Set
		End Property

		Public Property LocalContext() As String
			Get
				Return FLocalContext
			End Get
			Friend Set
				FLocalContext = value
			End Set
		End Property

		#End Region

	End Class

	Public Class IAXLines
		Inherits ReadOnlyCollection(Of IAXLine)

		#Region "Fields"

		Private FHost As IAXClientClass
		Private FSelected As Integer

		#End Region

		#Region "Constructor"

		Public Sub New(list As IList(Of IAXLine), host As IAXClientClass)
			MyBase.New(list)
			FHost = host
			FSelected = 0
		End Sub

		#End Region

		#Region "Methods"

		Public Sub SelectLine(line As Integer)

			FSelected = line
			If IAXFunctions.iaxc_select_call(line) < 0 Then
				Throw New IAXMethodException("Line select error!")
			End If

		End Sub

		#End Region

		#Region "Properties"

		Friend ReadOnly Property Host() As IAXClientClass

			Get
				Return FHost
			End Get
		End Property


		Public Property SelectedLine() As Integer
			Get
				Return FSelected
			End Get
			Friend Set
				FSelected = value
			End Set
		End Property

		#End Region

	End Class

	Public Class IAXClientClass
        Inherits BaseClass

		#Region "Fields"

		Private FUser As String
		Private FPass As String
		Private FServer As String

		Private FRegistrationStatus As RegistrationStatus
		Private FRegistrationRequired As Boolean
		Private FRegistrationId As Integer

		Private FCallerIdName As String
		Private FCallerIdNumber As String

		Private FPreferredFormat As AudioFormat
		Private FAllowedFormats As AudioFormat

		Private FSilenceThreshold As Integer

		Private FAudioType As AudioType
		Private FWindow As NativeWindowEx
		Private FMessageId As Integer
		Private FLines As Integer

		Private FSoundId As Integer
		Private FRingId As Integer
		Private FBusyId As Integer

		Private FLinesCollection As IAXLines
		Private FLinesList As List(Of IAXLine)

		Private FAudioDevicesCollection As IAXAudioDevices
		Private FAudioDevicesList As List(Of IAXAudioDevice)

		Private Event FOnRegistrationEvent As OnRegistrationDelegate
		Private Event FOnAudioLevelEvent As OnAudioLevelDelegate
		Private Event FOnLineStateEvent As OnLineStateDelegate
		Private Event FOnTextStateEvent As OnTextStateDelegate

		#End Region

		#Region "Constructor"

		Public Sub New(audioType As AudioType, lines As Integer)

			FCallerIdName = "SharpIAX"
			FCallerIdNumber = "(Not Specified)"

			FAudioType = audioType

			FLinesList = New List(Of IAXLine)()
			FLinesCollection = New IAXLines(FLinesList, Me)

			FAudioDevicesList = New List(Of IAXAudioDevice)()
			FAudioDevicesCollection = New IAXAudioDevices(FAudioDevicesList)

			FSilenceThreshold = -99
			FRegistrationRequired = True
			FLines = lines

			'----- Initialize!
			If IAXFunctions.iaxc_initialize(CInt(FAudioType), FLines) <> 0 Then
				Throw New IAXMethodException("Initialize error!")
			End If

			'----- Devices
			Dim pdevs As IntPtr = IntPtr.Zero
			Dim nDevs As Integer = 0
			Dim input As Integer = 0
			Dim output As Integer = 0
			Dim ring As Integer = 0

			If IAXFunctions.iaxc_audio_devices_get(pdevs, nDevs, input, output, ring) <> 0 Then
				Throw New IAXMethodException("Initialize error!")
			End If

			FAudioDevicesCollection.SelectedInputAudioDevice = input
			FAudioDevicesCollection.SelectedOutputAudioDevice = output
			FAudioDevicesCollection.SelectedRingAudioDevice = ring

			Dim devs As Object() = MarshalEx.PtrToStructureArray(pdevs, GetType(iaxc_audio_device), nDevs)

			For Each o As Object In devs
				Dim d As iaxc_audio_device = CType(o, iaxc_audio_device)
				Dim iaxd As New IAXAudioDevice(d.devID, d.name, d.capabilities)
				FAudioDevicesList.Add(iaxd)

			Next
		End Sub

		#End Region

		#Region "Methods"

		Public Sub Initialize(user As String, password As String, server As String, register__1 As Boolean)

			If Not Disposed Then
				'----- Account!
				FUser = user
				FPass = password
				FServer = server
				FRegistrationRequired = register__1

				'---- Caller Id!
				IAXFunctions.iaxc_set_callerid(FCallerIdName, FCallerIdNumber)

				'----- Silence Threshold !
				IAXFunctions.iaxc_set_silence_threshold(FSilenceThreshold)

				'----- Formats!
				FPreferredFormat = AudioFormat.afIAXC_FORMAT_GSM
				FAllowedFormats = FPreferredFormat

				IAXFunctions.iaxc_set_formats(CInt(FPreferredFormat), CInt(FAllowedFormats))

				'----- Message Event!

				'----- Magic number!
				FMessageId = 123456

				FWindow = New NativeWindowEx(New CreateParams(), True)
				AddHandler FWindow.OnMessage, New OnMessageDelegate(AddressOf FWindow_OnMessage)

				If IAXFunctions.iaxc_set_event_callpost(FWindow.Handle, FMessageId) <> 0 Then
					Throw New IAXMethodException("Event handler initialize error!")
				End If

				If IAXFunctions.iaxc_start_processing_thread() <> 0 Then
					Throw New IAXMethodException("Event handler start error!")
				End If

				For i As Integer = 1 To FLines
					FLinesList.Add(New IAXLine(FLinesCollection, i - 1))
				Next

				FLinesCollection.SelectLine(0)

				If FRegistrationRequired Then
					Register()
				End If
			End If
		End Sub

		Private Sub PlaySound(resourceName As String, repeat As Integer, ByRef Id As Integer)

			If Not Disposed Then

				Dim fs As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
				fs.Position = 44

				Dim arr As Byte() = New Byte(fs.Length - fs.Position - 1) {}

				fs.Read(arr, 0, arr.Length)
				fs.Close()

				Dim h As GCHandle = GCHandle.Alloc(arr, GCHandleType.Pinned)

				Dim s As New iaxc_sound()

				s.len = arr.Length \ 2
				s.data = h.AddrOfPinnedObject()
				s.malloced = 0
				s.channel = 0
				s.repeat = repeat

				Id = IAXFunctions.iaxc_play_sound(s, 0)


				h.Free()
			End If

		End Sub

		Public Sub PlayRing()
			If Not Disposed Then
				StopRing()
				PlaySound("ALAZ.TelephonyEx.ring.wav", -1, FRingId)
			End If
		End Sub

		Public Sub StopRing()
			If Not Disposed Then
				IAXFunctions.iaxc_stop_sound(FSoundId)
			End If
		End Sub

		Public Sub PlayBusy()
			StopRing()
			PlaySound("ALAZ.TelephonyEx.busy.wav", -1, FBusyId)
		End Sub

		Public Sub StopBusy()
			If Not Disposed Then
				IAXFunctions.iaxc_stop_sound(FSoundId)
			End If
		End Sub

		Public Sub PlayEnd()
			If Not Disposed Then
				PlaySound("ALAZ.TelephonyEx.beep.wav", 0, FSoundId)
			End If
		End Sub

		Public Sub PlayDigit(digit As Byte)

			If Not Disposed Then

				Dim resourceName As String = "ALAZ.TelephonyEx."

				Select Case digit

					Case 48
						resourceName += "0.wav"
						Exit Select

					Case 49
						resourceName += "1.wav"
						Exit Select

					Case 50
						resourceName += "2.wav"
						Exit Select

					Case 51
						resourceName += "3.wav"
						Exit Select

					Case 52
						resourceName += "4.wav"
						Exit Select

					Case 53
						resourceName += "5.wav"
						Exit Select

					Case 54
						resourceName += "6.wav"
						Exit Select

					Case 55
						resourceName += "7.wav"
						Exit Select

					Case 56
						resourceName += "8.wav"
						Exit Select

					Case 57
						resourceName += "9.wav"
						Exit Select

					Case 42
						resourceName += "asterisk.wav"
						Exit Select

					Case 35
						resourceName += "sharp.wav"
						Exit Select

				End Select


				PlaySound(resourceName, 0, FSoundId)
			End If

		End Sub

		Public Sub Register()

			If Not Disposed Then
				FRegistrationId = IAXFunctions.iaxc_register(FUser, FPass, FServer)

				If FRegistrationId < 0 Then
					Throw New IAXMethodException("Registration error!")
				End If
			End If

		End Sub

		Public Sub ShutDown()

			If Not Disposed Then

				IAXFunctions.iaxc_dump_all_calls()

				If FRegistrationId > 0 Then
					IAXFunctions.iaxc_unregister(FRegistrationId)
				End If

				If IAXFunctions.iaxc_stop_processing_thread() <> 0 Then
					Throw New IAXMethodException("Event handler stop error!")
				End If

				IAXFunctions.iaxc_shutdown()
			End If
		End Sub

		#End Region

		#Region "Message Callback"

		Private Sub FWindow_OnMessage(ByRef m As System.Windows.Forms.Message)

			If Not Disposed Then

				'----- Check messageId!
				If m.Msg = FMessageId Then

					'----- Get event data!
					Dim eventPointer As New IntPtr(m.LParam.ToInt32() + 8)
					Dim e As iaxc_event = CType(Marshal.PtrToStructure(m.LParam, GetType(iaxc_event)), iaxc_event)

					Select Case e.type

						Case EventType.etIAXC_EVENT_LEVELS
							If True Then

								'----- Meter Level!
								Dim ev As iaxc_ev_levels = CType(Marshal.PtrToStructure(eventPointer, GetType(iaxc_ev_levels)), iaxc_ev_levels)

								'----- Update Calltime!
								For Each l As IAXLine In FLinesList
									If l.Active Then
										l.CallTime = Environment.TickCount - l.CallStartTime

									End If
								Next

								'----- Fire Event!
								RaiseEvent FOnAudioLevelEvent(Math.Max(Convert.ToInt32(99 - Math.Abs(ev.input)), 0), Math.Max(Convert.ToInt32(99 - Math.Abs(ev.output)), 0))

								Exit Select

							End If

						Case EventType.etIAXC_EVENT_REGISTRATION
							If True Then

								'----- Registration!
								Dim ev As iaxc_ev_registration = CType(Marshal.PtrToStructure(eventPointer, GetType(iaxc_ev_registration)), iaxc_ev_registration)

								Select Case ev.reply

									Case RegistrationEvent.reIAXC_REGISTRATION_REPLY_ACK
										If True Then

											FRegistrationStatus = RegistrationStatus.rsCompleted
											Exit Select
										End If

									Case RegistrationEvent.reIAXC_REGISTRATION_REPLY_REJ
										If True Then

											FRegistrationStatus = RegistrationStatus.rsRejected
											Exit Select
										End If

									Case RegistrationEvent.reIAXC_REGISTRATION_REPLY_TIMEOUT
										If True Then

											FRegistrationStatus = RegistrationStatus.rsTimeOut
											Exit Select
										End If

								End Select
								RaiseEvent FOnRegistrationEvent()

								'----- Fire event!

								Exit Select

							End If

						Case EventType.etIAXC_EVENT_STATE
							If True Then

								'----- Call State!
								Dim ev As iaxc_ev_call_state = CType(Marshal.PtrToStructure(eventPointer, GetType(iaxc_ev_call_state)), iaxc_ev_call_state)

								If ev.state = CallState.csIAXC_CALL_STATE_FREE Then

									'----- Update line state data!
									StopBusy()
									StopRing()
									PlayEnd()

									FLinesList(ev.callNo).Active = False
									FLinesList(ev.callNo).CallTime = 0
									FLinesList(ev.callNo).CallStartTime = 0

									FLinesList(ev.callNo).CallStatus = CallStatus.csNone

									FLinesList(ev.callNo).Local = [String].Empty
									FLinesList(ev.callNo).LocalContext = [String].Empty
									FLinesList(ev.callNo).Remote = [String].Empty


									FLinesList(ev.callNo).RemoteName = [String].Empty
								End If

								If (ev.state And CallState.csIAXC_CALL_STATE_ACTIVE) = CallState.csIAXC_CALL_STATE_ACTIVE Then

									If Not FLinesList(ev.callNo).Active Then
										FLinesList(ev.callNo).CallStartTime = Environment.TickCount
									End If

									'----- Update line state data!
									FLinesList(ev.callNo).Active = True

									FLinesList(ev.callNo).Local = ev.local
									FLinesList(ev.callNo).LocalContext = ev.local_context
									FLinesList(ev.callNo).Remote = ev.remote

									FLinesList(ev.callNo).RemoteName = ev.remote_name
								End If

								If (ev.state And CallState.csIAXC_CALL_STATE_SELECTED) = CallState.csIAXC_CALL_STATE_SELECTED Then

									FLinesCollection.SelectedLine = ev.callNo

									If FLinesList(ev.callNo).CallStatus = CallStatus.csRinging Then

										If FLinesList(ev.callNo).CallDirection = CallDirection.cdIncoming Then
											PlayRing()

										End If
									End If

									If FLinesList(ev.callNo).CallStatus = CallStatus.csBusy Then
										PlayBusy()
									End If

									If FLinesList(ev.callNo).CallStatus = CallStatus.csNone Then
										StopBusy()
										StopRing()

									End If
								End If

								If (ev.state And CallState.csIAXC_CALL_STATE_OUTGOING) = CallState.csIAXC_CALL_STATE_OUTGOING Then
									FLinesList(ev.callNo).CallDirection = CallDirection.cdOutgoing
									FLinesList(ev.callNo).CallStatus = CallStatus.csCalling
								End If

								If (ev.state And CallState.csIAXC_CALL_STATE_TRANSFER) = CallState.csIAXC_CALL_STATE_TRANSFER Then
									FLinesList(ev.callNo).CallStatus = CallStatus.csTransfer
								End If

								If (ev.state And CallState.csIAXC_CALL_STATE_RINGING) = CallState.csIAXC_CALL_STATE_RINGING Then

									If (ev.state And CallState.csIAXC_CALL_STATE_OUTGOING) = CallState.csIAXC_CALL_STATE_OUTGOING Then
										FLinesList(ev.callNo).CallDirection = CallDirection.cdOutgoing
									Else
										PlayRing()
										FLinesList(ev.callNo).CallDirection = CallDirection.cdIncoming
									End If


									FLinesList(ev.callNo).CallStatus = CallStatus.csRinging
								End If

								If (ev.state And CallState.csIAXC_CALL_STATE_COMPLETE) = CallState.csIAXC_CALL_STATE_COMPLETE Then

									FLinesList(ev.callNo).CallStatus = CallStatus.csComplete

									StopBusy()

									StopRing()
								End If

								If (ev.state And CallState.csIAXC_CALL_STATE_BUSY) = CallState.csIAXC_CALL_STATE_BUSY Then
									FLinesList(ev.callNo).CallStatus = CallStatus.csBusy
									PlayBusy()
								End If

								'----- Fire Event!
								RaiseEvent FOnLineStateEvent(ev.callNo)

								Exit Select

							End If

						Case EventType.etIAXC_EVENT_NETSTAT
							If True Then
								'----- Discarding NETSTAT events!
								Exit Select
							End If

						Case EventType.etIAXC_EVENT_TEXT
							If True Then

								'----- Text!
								Dim ev As iaxc_ev_text = CType(Marshal.PtrToStructure(eventPointer, GetType(iaxc_ev_text)), iaxc_ev_text)

								'----- Fire Event!
								RaiseEvent FOnTextStateEvent(ev.callNo, ev.type, ev.message)

								Exit Select

							End If

					End Select

					eventPointer = IntPtr.Zero

					IAXFunctions.iaxc_free_event(m.LParam)
				End If
			End If
		End Sub

		#End Region

		#Region "Properties"

        Public Custom Event OnTextState As OnTextStateDelegate
            AddHandler(ByVal value As OnTextStateDelegate)
                AddHandler FOnTextStateEvent, value
            End AddHandler

            RemoveHandler(ByVal value As OnTextStateDelegate)
                RemoveHandler FOnTextStateEvent, value
            End RemoveHandler

            RaiseEvent(ByVal lineNumber As Integer, ByVal textType As TextType, ByVal text As String)

            End RaiseEvent
        End Event

        Public Custom Event OnLineState As OnLineStateDelegate
            AddHandler(ByVal value As OnLineStateDelegate)
                AddHandler FOnLineStateEvent, value
            End AddHandler

            RemoveHandler(ByVal value As OnLineStateDelegate)
                RemoveHandler FOnLineStateEvent, value
            End RemoveHandler

            RaiseEvent(ByVal lineNumber As Integer)

            End RaiseEvent
        End Event

        Public Custom Event OnAudioLevel As OnAudioLevelDelegate
            AddHandler(ByVal value As OnAudioLevelDelegate)
                AddHandler FOnAudioLevelEvent, value
            End AddHandler

            RemoveHandler(ByVal value As OnAudioLevelDelegate)
                RemoveHandler FOnAudioLevelEvent, value
            End RemoveHandler

            RaiseEvent(ByVal input As Integer, ByVal output As Integer)

            End RaiseEvent
        End Event
        Public Custom Event OnRegistration As OnRegistrationDelegate
            AddHandler(ByVal value As OnRegistrationDelegate)
                AddHandler FOnRegistrationEvent, value
            End AddHandler

            RemoveHandler(ByVal value As OnRegistrationDelegate)
                RemoveHandler FOnRegistrationEvent, value
            End RemoveHandler

            RaiseEvent()

            End RaiseEvent
        End Event
        Public Property PreferredFormat() As AudioFormat

            Get
                Return FPreferredFormat
            End Get

            Set(ByVal value As AudioFormat)
                FPreferredFormat = Value
                IAXFunctions.iaxc_set_formats(CInt(FPreferredFormat), CInt(FAllowedFormats))
            End Set
        End Property


		Public Property AllowedFormats() As AudioFormat

			Get
				Return FAllowedFormats
			End Get

			Set
				FAllowedFormats = value
				IAXFunctions.iaxc_set_formats(CInt(FPreferredFormat), CInt(FAllowedFormats))
			End Set
		End Property


		Public Property SilenceThreshold() As Integer

			Get
				Return FSilenceThreshold
			End Get

			Set
				FSilenceThreshold = value
				IAXFunctions.iaxc_set_silence_threshold(FSilenceThreshold)
			End Set
		End Property


		Public ReadOnly Property User() As String
			Get
				Return FUser
			End Get
		End Property

		Public ReadOnly Property Password() As String
			Get
				Return FPass
			End Get
		End Property

		Public ReadOnly Property Server() As String
			Get
				Return FServer
			End Get
		End Property

		Public ReadOnly Property RegistrationRequired() As Boolean
			Get
				Return FRegistrationRequired
			End Get
		End Property

		Public ReadOnly Property Lines() As IAXLines
			Get
				Return FLinesCollection
			End Get
		End Property

		Public ReadOnly Property AudioDevices() As IAXAudioDevices
			Get
				Return FAudioDevicesCollection
			End Get
		End Property

		Public ReadOnly Property RegistrationStatus() As RegistrationStatus
			Get
				Return FRegistrationStatus
			End Get
		End Property

		Public ReadOnly Property Version() As String

			Get

				'----- Allocate memory!
				Dim pVersion As IntPtr = Marshal.AllocHGlobal(256)

				'----- Pass allocated parameter!
				IAXFunctions.iaxc_version(pVersion)

				'----- Cast the pointer to string!
				Dim version__1 As String = Marshal.PtrToStringAnsi(pVersion)

				'----- Don't forget to free memory allocation!
				Marshal.FreeHGlobal(pVersion)

				Return version__1
			End Get
		End Property


		Public Property CallerIdName() As String

			Get
				Return FCallerIdName
			End Get

			Set
				FCallerIdName = value
				IAXFunctions.iaxc_set_callerid(FCallerIdName, FCallerIdNumber)
			End Set
		End Property


		Public Property CallerIdNumber() As String

			Get
				Return FCallerIdNumber
			End Get

			Set
				FCallerIdNumber = value
				IAXFunctions.iaxc_set_callerid(FCallerIdName, FCallerIdNumber)
			End Set
		End Property



		#End Region

	End Class

End Namespace
