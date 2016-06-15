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


Imports System.Runtime.InteropServices

Namespace Voip.IAX

	#Region "Exceptions"

	Public Class IAXMethodException
		Inherits Exception
		Public Sub New(message As String)
			MyBase.New(message)
		End Sub
	End Class

	#End Region

	#Region "Delegates"

	Public Delegate Sub OnRegistrationDelegate()
	Public Delegate Sub OnAudioLevelDelegate(input As Integer, output As Integer)
	Public Delegate Sub OnLineStateDelegate(lineNumber As Integer)
	Public Delegate Sub OnTextStateDelegate(lineNumber As Integer, textType As TextType, text As String)

	#End Region

	#Region "Enums"

	Public Enum DTMFSounds
		dsZero
		dsOne
		dsTwo
		dsThree
		dsFour
		dsFive
		dsSix
		dsSeven
		dsEight
		dsNine
		dsAsterisk
		dsSharp
	End Enum

	Public Enum RegistrationStatus
		rsNotRequired = 0
		rsCompleted = 1
		rsRejected = 2
		rsTimeOut = 3
	End Enum

	Public Enum CallStatus
		csRinging = 0
		csBusy = 1
		csComplete = 2
		csCalling = 3
		csNone = 4
		csTransfer = 5
	End Enum

	Public Enum CallDirection
		cdIncoming = 0
		cdOutgoing = 1
	End Enum

	Public Enum AudioType
		atAUDIO_INTERNAL = 0
		atAUDIO_INTERNAL_PA = 1
		atAUDIO_INTERNAL_FILE = 2
		atAUDIO_INTERNAL_ALSA = 3
		atAUDIO_EXTERNAL = 99
	End Enum

	<Flags> _
	Public Enum AudioCapability

		acIAXC_AD_INPUT = (1 << 0)
		acIAXC_AD_OUTPUT = (1 << 1)
		axIAXC_AD_RING = (1 << 2)
		acIAXC_AD_INPUT_DEFAULT = (1 << 3)
		acIAXC_AD_OUTPUT_DEFAULT = (1 << 4)
		acIAXC_AD_RING_DEFAULT = (1 << 5)
	End Enum

	<Flags> _
	Public Enum AudioFormat
		afIAXC_FORMAT_G723_1 = (1 << 0)
		' G.723.1 compression 
		afIAXC_FORMAT_GSM = (1 << 1)
		' GSM compression 
		afIAXC_FORMAT_ULAW = (1 << 2)
		' Raw mu-law data (G.711) 
		afIAXC_FORMAT_ALAW = (1 << 3)
		' Raw A-law data (G.711) 
		afIAXC_FORMAT_G726 = (1 << 4)
		' ADPCM, 32kbps  
		afIAXC_FORMAT_ADPCM = (1 << 5)
		' ADPCM IMA 
		afIAXC_FORMAT_SLINEAR = (1 << 6)
		' Raw 16-bit Signed Linear (8000 Hz) PCM 
		afIAXC_FORMAT_LPC10 = (1 << 7)
		' LPC10, 180 samples/frame 
		afIAXC_FORMAT_G729A = (1 << 8)
		' G.729a Audio 
		afIAXC_FORMAT_SPEEX = (1 << 9)
		' Speex Audio 
		afIAXC_FORMAT_ILBC = (1 << 10)
		' iLBC Audio 
		afIAXC_FORMAT_MAX_AUDIO = (1 << 15)
		' Maximum audio format 
		afIAXC_FORMAT_JPEG = (1 << 16)
		' JPEG Images 
		afIAXC_FORMAT_PNG = (1 << 17)
		' PNG Images 
		afIAXC_FORMAT_H261 = (1 << 18)
		' H.261 Video 
		afIAXC_FORMAT_H263 = (1 << 19)
		' H.263 Video 
		afIAXC_FORMAT_H263_PLUS = (1 << 20)
		' H.263+ Video 
		afIAXC_FORMAT_MPEG4 = (1 << 21)
		' MPEG4 Video 
		afIAXC_FORMAT_H264 = (1 << 23)
		' H264 Video 
		afIAXC_FORMAT_THEORA = (1 << 24)
		' Theora Video 
	End Enum

	Public Enum EventType
		etIAXC_EVENT_TEXT = 1
		etIAXC_EVENT_LEVELS = 2
		etIAXC_EVENT_STATE = 3
		etIAXC_EVENT_NETSTAT = 4
		etIAXC_EVENT_URL = 5
		' URL push via IAX(2) 
		etIAXC_EVENT_VIDEO = 6
		' video data (pointer) 
		etIAXC_EVENT_REGISTRATION = 7
	End Enum

	Public Enum RegistrationEvent
		reIAXC_REGISTRATION_REPLY_ACK = 18
		' IAX_EVENT_REGACC  
		reIAXC_REGISTRATION_REPLY_REJ = 30
		' IAX_EVENT_REGREJ  
		reIAXC_REGISTRATION_REPLY_TIMEOUT = 6
		' IAX_EVENT_TIMEOUT 
	End Enum

	<Flags> _
	Public Enum CallState
		csIAXC_CALL_STATE_FREE = 0
		csIAXC_CALL_STATE_ACTIVE = (1 << 1)
		csIAXC_CALL_STATE_OUTGOING = (1 << 2)
		csIAXC_CALL_STATE_RINGING = (1 << 3)
		csIAXC_CALL_STATE_COMPLETE = (1 << 4)
		csIAXC_CALL_STATE_SELECTED = (1 << 5)
		csIAXC_CALL_STATE_BUSY = (1 << 6)
		csIAXC_CALL_STATE_TRANSFER = (1 << 7)
	End Enum

	Public Enum TextType
		ttIAXC_TEXT_TYPE_STATUS = 1
		ttIAXC_TEXT_TYPE_NOTICE = 2
		ttIAXC_TEXT_TYPE_ERROR = 3
		ttIAXC_TEXT_TYPE_FATALERROR = 4
		' FATAL ERROR: User Agent should probably display error, then die. 
		ttIAXC_TEXT_TYPE_IAX = 5
	End Enum

	#End Region

	#Region "Structs"

	Friend Structure iaxc_sound

		Public data As IntPtr
		Public len As Integer
		Public malloced As Integer
		Public channel As Integer
		Public repeat As Integer
		Public pos As Integer
		Public id As Integer
		Public [next] As IntPtr
	End Structure

	Friend Structure iaxc_ev_text
		Public type As TextType
		Public callNo As Integer
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)> _
		Public message As String
	End Structure

	Friend Structure iaxc_audio_device
		Public name As String
		Public capabilities As AudioCapability
		Public devID As Integer
	End Structure

	Friend Structure iaxc_ev_levels
		Public input As Single
		Public output As Single
	End Structure

	Friend Structure iaxc_ev_registration
		Public id As Integer
		Public reply As RegistrationEvent
		Public msgcount As Integer
	End Structure

	Friend Structure iaxc_ev_call_state
		Public callNo As Integer
		Public state As CallState
		Public format As AudioFormat
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)> _
		Public remote As String
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)> _
		Public remote_name As String
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)> _
		Public local As String
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)> _
		Public local_context As String
	End Structure

	'
'    [StructLayout(LayoutKind.Explicit)]
'    internal struct iaxc_event
'    {
'
'        [FieldOffset(0)]
'        public IntPtr next;
'
'        [FieldOffset(4)]
'        public EventType type;
'
'        [FieldOffset(8)]
'        public iaxc_ev_levels level;
'
'        [FieldOffset(8)]
'        public iaxc_ev_text text;
'
'        [FieldOffset(8)]
'        public iaxc_ev_call_state callState;
'
'        [FieldOffset(8)]
'        public iaxc_ev_registration registration;
'
'    }
'    


	Friend Structure iaxc_event
		Public [next] As IntPtr
		Public type As EventType
	End Structure

	#End Region

	#Region "Classes"

	Friend NotInheritable Class IAXFunctions
		Private Sub New()
		End Sub

		#Region "Consts"

		Private Const DllImportName As String = "iaxclient.dll"

		#End Region

		#Region "Methods"

		<DllImport(DllImportName, CallingConvention := CallingConvention.StdCall)> _
		Public Shared Function iaxc_initialize(audType As Integer, calls As Integer) As Integer
		End Function

		<DllImport(DllImportName, CallingConvention := CallingConvention.StdCall)> _
		Public Shared Sub iaxc_shutdown()
		End Sub

		<DllImport(DllImportName, CallingConvention := CallingConvention.StdCall)> _
		Public Shared Sub iaxc_set_formats(preferred As Integer, allowed As Integer)
		End Sub

		<DllImport(DllImportName, CallingConvention := CallingConvention.StdCall)> _
		Public Shared Sub iaxc_set_silence_threshold(thr As Double)
		End Sub

		<DllImport(DllImportName, CallingConvention := CallingConvention.StdCall)> _
		Public Shared Function iaxc_audio_devices_get(ByRef devs As IntPtr, ByRef nDevs As Integer, ByRef input As Integer, ByRef output As Integer, ByRef ring As Integer) As Integer
		End Function

		<DllImport(DllImportName)> _
		Public Shared Function iaxc_audio_devices_set(input As Integer, output As Integer, ring As Integer) As Integer
		End Function

		<DllImport(DllImportName)> _
		Public Shared Function iaxc_set_event_callpost(handle As IntPtr, id As Integer) As Integer
		End Function

		<DllImport(DllImportName)> _
		Public Shared Function iaxc_start_processing_thread() As Integer
		End Function

		<DllImport(DllImportName)> _
		Public Shared Function iaxc_stop_processing_thread() As Integer
		End Function

		<DllImport(DllImportName)> _
		Public Shared Function iaxc_register(<MarshalAs(UnmanagedType.LPStr)> user As String, <MarshalAs(UnmanagedType.LPStr)> pass As String, <MarshalAs(UnmanagedType.LPStr)> host As String) As Integer
		End Function

		<DllImport(DllImportName)> _
		Public Shared Function iaxc_unregister(id As Integer) As Integer
		End Function

		<DllImport(DllImportName)> _
		Public Shared Sub iaxc_call(<MarshalAs(UnmanagedType.LPStr)> number As String)
		End Sub

		<DllImport(DllImportName)> _
		Public Shared Function iaxc_select_call(callNo As Integer) As Integer
		End Function

		<DllImport(DllImportName)> _
		Public Shared Sub iaxc_free_event(e As IntPtr)
		End Sub

		<DllImport(DllImportName)> _
		Public Shared Sub iaxc_dump_call()
		End Sub

		<DllImport(DllImportName)> _
		Public Shared Sub iaxc_answer_call(callNo As Integer)
		End Sub

		<DllImport(DllImportName)> _
		Public Shared Sub iaxc_set_callerid(<MarshalAs(UnmanagedType.LPStr)> name As String, <MarshalAs(UnmanagedType.LPStr)> number As String)
		End Sub

		<DllImport(DllImportName)> _
		Public Shared Sub iaxc_dump_all_calls()
		End Sub

		<DllImport(DllImportName)> _
		Public Shared Sub iaxc_send_dtmf(digit As Byte)
		End Sub

		<DllImport(DllImportName)> _
		Public Shared Function iaxc_version(version As IntPtr) As IntPtr
		End Function

		<DllImport(DllImportName)> _
		Public Shared Sub iaxc_blind_transfer_call(callNo As Integer, <MarshalAs(UnmanagedType.LPStr)> number As String)
		End Sub

		<DllImport(DllImportName)> _
		Public Shared Function iaxc_play_sound(ByRef sound As iaxc_sound, ring As Integer) As Integer
		End Function

		<DllImport(DllImportName)> _
		Public Shared Function iaxc_stop_sound(id As Integer) As Integer
		End Function

		#End Region

	End Class

	#End Region

End Namespace
