Public Interface IEntidad
#Region "Propiedades"
    Property id As Integer
    Property cuil As String
    Property apellido As String
    Property nombre As String
    Property estado_civil As String
    Property sexo As String
    Property fecha_nacimiento As Date
    Property tipo_documento As String
    Property nro_documento As Integer
    Property observacion As String
    Property iva As String
    Property foto As Byte()
    Property baja As Boolean
    Property EstadoFila As Char
    'Definicion de Entidades
    Property Cliente As cliente
    Property lstMail As List(Of mail)
    Property lstTelefono As List(Of telefono)
    'VISTAS
    ReadOnly Property vAyN As String
    ReadOnly Property vTelefonos As String
    ReadOnly Property vEmails As String
#End Region

#Region "Funciones"

    Property lst_Chofer As List(Of chofer)

    Property lst_Aseguradora As List(Of aseguradora)

    Property Operador As operador

    Function Insert(ByRef _Conexion As MySql.Data.MySqlClient.MySqlConnection, Optional ByRef _tran As MySql.Data.MySqlClient.MySqlTransaction = Nothing) As Integer
    Function Update(ByRef _Conexion As MySql.Data.MySqlClient.MySqlConnection, Optional ByRef _tran As MySql.Data.MySqlClient.MySqlTransaction = Nothing) As Boolean
    ' Function InsertUpdate(ByRef _Conexion As MySql.Data.MySqlClient.MySqlConnection, Optional ByRef _tran As MySql.Data.MySqlClient.MySqlTransaction = Nothing) As Integer
    Sub CargarFila(ByRef Fila As DataRow, ByRef O As entidad)
    Function Clone() As entidad
#End Region



End Interface
