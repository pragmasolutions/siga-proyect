USE [LuzYFuerza1]
GO
/****** Object:  Table [dbo].[Nomenclador]    Script Date: 04/26/2012 10:42:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nomenclador](
	[IdNomenclador] [int] IDENTITY(1,1) NOT NULL,
	[CodigoNom] [varchar](50) NOT NULL,
	[Descripcion] [varchar](200) NULL,
	[Letra] [nchar](10) NULL,
	[Galeno] [nchar](10) NULL,
	[Especialista] [varchar](50) NULL,
	[Ayudante1] [varchar](50) NULL,
	[Ayudante2] [varchar](50) NULL,
	[Ayudante3] [varchar](50) NULL,
	[Anestesista] [varchar](50) NULL,
	[Gastos] [varchar](50) NULL,
	[CodigoAnt] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Nomenclador] PRIMARY KEY CLUSTERED 
(
	[IdNomenclador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Localidad_ObtenerPorId]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Localidad_ObtenerPorId]

@LocalidadId int

AS
	BEGIN		
		SELECT *
		FROM Localidades
		WHERE (@LocalidadId = IdLocalidades)
	END
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Especialidad](
	[IdEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](500) NULL,
 CONSTRAINT [PK_Especialidad] PRIMARY KEY CLUSTERED 
(
	[IdEspecialidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AntFisiologicos]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AntFisiologicos](
	[IdAntFisiologico] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [nvarchar](150) NULL,
 CONSTRAINT [PK_AntFisiologicos] PRIMARY KEY CLUSTERED 
(
	[IdAntFisiologico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AntecedentesPatologicos]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AntecedentesPatologicos](
	[IdAPatologico] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](40) NOT NULL,
	[Descripcion] [nchar](140) NULL,
 CONSTRAINT [PK_AntecedentesPatologicos] PRIMARY KEY CLUSTERED 
(
	[IdAPatologico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Controla]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Controla](
	[IdControladora] [int] NOT NULL,
	[IdControl] [int] NOT NULL,
 CONSTRAINT [PK_Controla] PRIMARY KEY CLUSTERED 
(
	[IdControladora] ASC,
	[IdControl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empresa](
	[IdEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[CUIT] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Estado] [nchar](10) NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Delegacion]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Delegacion](
	[IdDelegacion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Telefono] [varchar](50) NOT NULL,
	[TelefonoAux] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NULL,
	[Mail] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Delegacion] PRIMARY KEY CLUSTERED 
(
	[IdDelegacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstadoCivil]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoCivil](
	[IdEstadoCivil] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](10) NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [nchar](10) NULL,
 CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[IdEstadoCivil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstadisticaPatologias]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadisticaPatologias](
	[estadisticaPalogiaId] [int] IDENTITY(1,1) NOT NULL,
	[patologiaId] [int] NULL,
	[fecha] [date] NULL,
 CONSTRAINT [PK_EstadisticaPatologias] PRIMARY KEY CLUSTERED 
(
	[estadisticaPalogiaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vedemecun]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vedemecun](
	[IdMedicamento] [int] IDENTITY(1,1) NOT NULL,
	[Drogra] [varchar](100) NOT NULL,
	[Cantidad] [varchar](100) NULL,
	[Presencacion] [varchar](100) NULL,
	[Drogeria] [varchar](100) NULL,
	[Existencia] [int] NULL,
 CONSTRAINT [PK_Vedemecun] PRIMARY KEY CLUSTERED 
(
	[IdMedicamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoAntecedente]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoAntecedente](
	[tipoAntecedenteId] [int] NOT NULL,
	[nombre] [varchar](60) NOT NULL,
 CONSTRAINT [PK_TipoAntecedente] PRIMARY KEY CLUSTERED 
(
	[tipoAntecedenteId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoOrden]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoOrden](
	[IdTipoOrden] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](20) NULL,
	[PrecioOrden] [varchar](14) NULL,
 CONSTRAINT [PK_TipoOrden] PRIMARY KEY CLUSTERED 
(
	[IdTipoOrden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoPlan]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoPlan](
	[IdTipoPlan] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](max) NULL,
	[PrecioTipoPlan] [varchar](10) NULL,
 CONSTRAINT [PK_TipoPlan] PRIMARY KEY CLUSTERED 
(
	[IdTipoPlan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoHabitoToxico]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoHabitoToxico](
	[tipoHabitoId] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoHabitoToxico] PRIMARY KEY CLUSTERED 
(
	[tipoHabitoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Traumatologica]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traumatologica](
	[IdTraumato] [int] IDENTITY(1,1) NOT NULL,
	[IdConulmedica] [int] NOT NULL,
 CONSTRAINT [PK_Traumatologica] PRIMARY KEY CLUSTERED 
(
	[IdTraumato] ASC,
	[IdConulmedica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoVisita]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoVisita](
	[IdTipoVisita] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](20) NULL,
	[Descripcion] [nchar](30) NULL,
 CONSTRAINT [PK_TipoVisita] PRIMARY KEY CLUSTERED 
(
	[IdTipoVisita] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[IdProvincia] [int] NOT NULL,
	[Nombre] [nchar](20) NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[IdProvincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descipcion] [varchar](50) NULL,
	[Permisos] [varchar](50) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sintoma]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sintoma](
	[IdSintomas] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](max) NULL,
 CONSTRAINT [PK_Sintomas] PRIMARY KEY CLUSTERED 
(
	[IdSintomas] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Activar]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Activar] 
	-- Add the parameters for the stored procedure here
@Id int,
@Password varchar(200)
AS
BEGIN
Update Personal
	SET Contrasenia = @Password,
	Activo = 1
		WHERE IdPersonal = @Id
		SELECT 1 as result;
	END	
		
	return
GO
/****** Object:  Table [dbo].[ExamenFisico]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExamenFisico](
	[IdExamenFisico] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descipcion] [varchar](540) NULL,
 CONSTRAINT [PK_ExamenFisico] PRIMARY KEY CLUSTERED 
(
	[IdExamenFisico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Odontologica]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Odontologica](
	[IdOdonto] [int] IDENTITY(1,1) NOT NULL,
	[IdConsulMedica] [int] NOT NULL,
	[Resumenodontologico] [varchar](510) NULL,
 CONSTRAINT [PK_Odontologica] PRIMARY KEY CLUSTERED 
(
	[IdOdonto] ASC,
	[IdConsulMedica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrdenesPorTipoPlan]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenesPorTipoPlan](
	[IdTipoPlan] [int] NOT NULL,
	[idTipoOrden] [int] NOT NULL,
 CONSTRAINT [PK_OrdenesPorTipoPlan] PRIMARY KEY CLUSTERED 
(
	[IdTipoPlan] ASC,
	[idTipoOrden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parentesco]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Parentesco](
	[IdParentesco] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [varchar](20) NULL,
 CONSTRAINT [PK_Parentesco] PRIMARY KEY CLUSTERED 
(
	[IdParentesco] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patologias]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patologias](
	[PatologiaId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](500) NULL,
 CONSTRAINT [PK_Patologias] PRIMARY KEY CLUSTERED 
(
	[PatologiaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Patologia_Insertar]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Patologia_Insertar]

@Nombre varchar(50),
@Descripcion varchar(500)

AS
	BEGIN
		
			INSERT INTO Patologias
			(
				Nombre,
				Descripcion
			) VALUES (
				@Nombre,
				@Descripcion
			)				
			Select @@identity as patologia_id
			return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Parentesco_ObtenerPorId]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Parentesco_ObtenerPorId]

@ParentescoId int

AS
	BEGIN		
		SELECT *
		FROM Parentesco
		WHERE (@ParentescoId = IdParentesco)
	END
GO
/****** Object:  StoredProcedure [dbo].[Parentesco_Listado]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Parentesco_Listado]

AS
BEGIN
	SELECT
		*
	FROM
		Parentesco
	
END
GO
/****** Object:  StoredProcedure [dbo].[Orden_ObtenerPorPlanId]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Orden_ObtenerPorPlanId]

@TipoPlanId int

AS
	BEGIN		
		SELECT O.*
		FROM 
			OrdenesPorTipoPlan OTP
			left outer Join TipoOrden O on (OTP.idTipoOrden = O.IdTipoOrden)
				
		WHERE (@TipoPlanId = OTP.IdTipoPlan)
	END
GO
/****** Object:  StoredProcedure [dbo].[Nomenclador_Modificar]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Nomenclador_Modificar]
@IdNomenclador int, 
@CodigoNom varchar(50),
@Descripcion varchar(Max),
@Letra varchar(3),
@Especialista decimal, 
@Galeno decimal,
@Ayudante1 decimal,
@Ayudante2 decimal,
@Ayudante3 decimal,
@Anestesista decimal,
@Gastos decimal,
@CodigoAnte varchar(50)


AS
BEGIN

Update Nomenclador
SET 
CodigoNom = @CodigoNom ,
Descripcion=@Descripcion ,
Letra = @Letra,
Galeno=@Galeno ,
Especialista=@Especialista,
Ayudante1 = @Ayudante1,
Ayudante2 = @Ayudante2,
Ayudante3 = @Ayudante3,
Anestesista = @Anestesista,
Gastos = @Gastos,
CodigoAnt = @CodigoAnte

Where IdNomenclador = @IdNomenclador
END
GO
/****** Object:  StoredProcedure [dbo].[Nomenclador_Listado]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Nomenclador_Listado]
AS
BEGIN
	Select TOP 250 * from Nomenclador
	
	
	end
GO
/****** Object:  StoredProcedure [dbo].[Nomenclador_Insertar]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Nomenclador_Insertar]

@CodigoNom varchar(50),
@Descripcion varchar(Max),
@Letra varchar(3),
@Especialista varchar(50), 
@Galeno varchar(50),
@Ayudante1 varchar(50),
@Ayudante2 varchar(50),
@Ayudante3 varchar(50),
@Anestesista varchar(50),
@Gastos varchar(50),
@CodigoAnte varchar(50)
AS
BEGIN

Insert Into Nomenclador
(CodigoNom ,
Descripcion,
Letra ,
Galeno,
Especialista,
Ayudante1 ,
Ayudante2 ,
Ayudante3 ,
Anestesista ,
Gastos,
CodigoAnt 
)
Values 
(@CodigoNom ,
@Descripcion ,
@Letra,
@Galeno ,
@Especialista,
@Ayudante1,
@Ayudante2,
@Ayudante3,
@Anestesista,
@Gastos,
@CodigoAnte
)

Select @@identity as nom_id
	return
END
GO
/****** Object:  StoredProcedure [dbo].[Nomenclador_Eliminar]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Nomenclador_Eliminar]
@IdNomenclador int 

AS
BEGIN
Delete Nomenclador
where IdNomenclador = @IdNomenclador

END
GO
/****** Object:  StoredProcedure [dbo].[Nomenclador_Buscar]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Nomenclador_Buscar]
(
@Codigo varchar(60),
@Descripcion varchar(60)

)

AS

BEGIN
	Select TOP 200 * 
	From Nomenclador
	Where 
	(((@Codigo is null or @Codigo = '') or (@Codigo = CodigoNom))
	and ((@Descripcion is null or @Descripcion = '') or (Descripcion LIKE '%' + @Descripcion + '%')))
	

end
GO
/****** Object:  StoredProcedure [dbo].[Plan_BuscarPorNombre]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Plan_BuscarPorNombre]
@Nombre varchar(50)
AS
BEGIN
	Select IdTipoPlan, Nombre, Descripcion, PrecioTipoPlan from TipoPlan
	Where Nombre like '%' + @Nombre + '%'
	
	end
GO
/****** Object:  StoredProcedure [dbo].[EstadoCivil_Listado]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EstadoCivil_Listado]

AS
BEGIN
	SELECT
		*
	FROM
		EstadoCivil
	
END
GO
/****** Object:  StoredProcedure [dbo].[Patologias_Listado]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Patologias_Listado]

AS
BEGIN
	SELECT
		*
	FROM
		Patologias
	ORDER BY Nombre
	
END
GO
/****** Object:  StoredProcedure [dbo].[Practica_BuscarPorCodigo]    Script Date: 04/26/2012 10:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Practica_BuscarPorCodigo] 
	@Codingresado varchar(50)
	
AS
BEGIN
	  
	SELECT * from Nomenclador 
	where CodigoNom = @Codingresado  
END
GO
/****** Object:  StoredProcedure [dbo].[Rol_Listado]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Rol_Listado]

AS
BEGIN
	SELECT * FROM Rol
	
END
GO
/****** Object:  StoredProcedure [dbo].[Provincia_ObtenerPorId]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Provincia_ObtenerPorId]

@ProvinciaId int

AS
	BEGIN		
		SELECT *
		FROM Provincia
		WHERE (@ProvinciaId = IdProvincia)
	END
GO
/****** Object:  StoredProcedure [dbo].[Provincia_Listado]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Provincia_Listado]

AS
BEGIN
	SELECT
		*
	FROM
		Provincia
	
END
GO
/****** Object:  StoredProcedure [dbo].[TipoPlan_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TipoPlan_Modificar]
@Idplan int,
@Nombre varchar(50),
@Precio varchar(50),
@Descripcion varchar(max)
AS
BEGIN
	update TipoPlan 
	set 
	Nombre = @Nombre,
	PrecioTipoPlan = @Precio,
	Descripcion = @Descripcion
	
	where IdTipoPlan = @Idplan
	
	
	end
GO
/****** Object:  StoredProcedure [dbo].[TipoPlan_Listado]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TipoPlan_Listado]

AS

BEGIN
Select p.IdTipoPlan , P.Nombre, P.PrecioTipoPlan, P.Descripcion From TipoPlan P
end
GO
/****** Object:  StoredProcedure [dbo].[TipoPlan_Insertar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TipoPlan_Insertar]

@Nombre varchar(50),
@Descripcion varchar(Max),
@Precio varchar(20)

AS
BEGIN

Insert Into TipoPlan
(Nombre, Descripcion, PrecioTipoPlan) 
Values 
(@Nombre, @Descripcion, @Precio)

Select @@identity as plan_id
	return
END
GO
/****** Object:  StoredProcedure [dbo].[TipoPlan_Eliminar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TipoPlan_Eliminar]
@TipoPlanId int

AS
BEGIN
	Delete TipoPlan 
	
	where IdTipoPlan = @TipoPlanId
	
	end
GO
/****** Object:  StoredProcedure [dbo].[TipoAntecedente_Listado]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TipoAntecedente_Listado]
	
AS
BEGIN
	SELECT *
	FROM TipoAntecedente 
	
END
GO
/****** Object:  StoredProcedure [dbo].[TipoOrden_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TipoOrden_Modificar]
@IdTipoOrden int,
@Nombre nchar(20),
@Precio varchar(14)
AS
BEGIN
	update TipoOrden 
	set 
	Nombre = @Nombre,
	PrecioOrden = @Precio
	
	where IdTipoOrden = @IdTipoOrden
	
	end
GO
/****** Object:  StoredProcedure [dbo].[TipoOrden_Listado]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[TipoOrden_Listado]

AS
BEGIN
	SELECT
		*
	FROM
		TipoOrden
	
END
GO
/****** Object:  StoredProcedure [dbo].[TipoOrden_Insertar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TipoOrden_Insertar]
@Nombre varchar(50),
@Precio varchar(50)
AS
	BEGIN	
		Declare @Cant int
		
		set @Cant = (Select COUNT(Nombre)
					From TipoOrden
					Where Nombre = @Nombre)
		
		if @Cant = 0
		begin
			INSERT INTO TipoOrden
			(	
				Nombre,
				PrecioOrden
			) VALUES (			
				@Nombre,
				@Precio
			)		
			Select 'OK' as msj
			return
		end
		else
		begin
			Select 'Ya existe un tipo de orden con ese nombre.' as msj
			return
		end	
		
	END
GO
/****** Object:  StoredProcedure [dbo].[TipoOrden_Buscar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TipoOrden_Buscar](@Filtro varchar(50))

AS
BEGIN
	SELECT
		*
	FROM
		TipoOrden
	WHERE
		Nombre LIKE '%' + @Filtro + '%'
	
END
GO
/****** Object:  StoredProcedure [dbo].[TipoHabitoToxico_Listado]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TipoHabitoToxico_Listado]
	
AS
BEGIN
	SELECT *
	FROM TipoHabitoToxico 
	
END
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [nchar](10) NULL,
	[Telefono] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[IdRol] [int] NULL,
	[Usuario] [varchar](20) NULL,
	[Contrasenia] [varchar](200) NULL,
	[DNI] [int] NULL,
	[Activo] [int] NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[EstadisticaPatologia_Insertar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[EstadisticaPatologia_Insertar]

@PatologiaId int,
@Fecha date

AS
	BEGIN
		
			INSERT INTO EstadisticaPatologias
			(
				patologiaId,
				fecha
			) VALUES (
				@PatologiaId,
				@Fecha
			)				
			Select @@identity as estadistica_id
			return
		
	END
GO
/****** Object:  Table [dbo].[CubrePlan]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CubrePlan](
	[IdPlan] [int] NOT NULL,
	[IdNomenclador] [int] NOT NULL,
	[Descripcion] [varchar](500) NULL,
 CONSTRAINT [PK_CubrePlan] PRIMARY KEY CLUSTERED 
(
	[IdPlan] ASC,
	[IdNomenclador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Filial]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Filial](
	[IdFilial] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[DireccionExtandida] [varchar](50) NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NOT NULL,
	[TelefonoAux] [varchar](50) NOT NULL,
	[IdDelegacion] [int] NULL,
 CONSTRAINT [PK_Filial] PRIMARY KEY CLUSTERED 
(
	[IdFilial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExamenCLaboratorio]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExamenCLaboratorio](
	[IdNomenclador] [int] NOT NULL,
	[Nombre] [nchar](10) NULL,
	[Datos] [nvarchar](max) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[IdConsultaMedica] [int] NOT NULL,
 CONSTRAINT [PK_ExamenCLaboratorio] PRIMARY KEY CLUSTERED 
(
	[IdNomenclador] ASC,
	[IdConsultaMedica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Empresa_Listado]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Empresa_Listado]

AS
BEGIN
	SELECT
		*
	FROM
		Empresa
	
END
GO
/****** Object:  StoredProcedure [dbo].[Empresa_Insertar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Empresa_Insertar]

@EmpresaNombre varchar(100),
@EmpresaCuit varchar(100),
@EmpresaDireccion varchar(100),
@EmpresaTelefono varchar(100),
@EmpresaMail varchar(100)

AS
	BEGIN
		if @EmpresaCuit in (SELECT CUIT FROM Empresa)
		begin
			select -1 as empresa_id
			return
		end
		else
		begin
			INSERT INTO Empresa
			(
				Nombre,
				Direccion,
				CUIT,
				Telefono,
				Mail
			) VALUES (
				@EmpresaNombre,
				@EmpresaDireccion,
				@EmpresaCuit,
				@EmpresaTelefono,
				@EmpresaMail
			)				
			Select @@identity as empresa_id
			return
		end
	end
GO
/****** Object:  StoredProcedure [dbo].[Empresa_Buscar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Empresa_Buscar]

@EmpresaId int

AS
	BEGIN		
		SELECT *
		FROM Empresa
		WHERE (@EmpresaId = IdEmpresa)
	END
GO
/****** Object:  StoredProcedure [dbo].[Informe_CantidadPatologias]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Informe_CantidadPatologias]
( 
	@FechaInicio Date,
	@FechaFin Date
)

AS
BEGIN
	Select P.Nombre Nombre, COUNT(*) Cantidad
	FROM Patologias P LEFT OUTER JOIN EstadisticaPatologias EP ON P.PatologiaId = EP.patologiaId
	WHERE EP.Fecha BETWEEN @FechaInicio and @FechaFin
	GROUP BY EP.patologiaId, P.Nombre
END
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[IdLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[IdProvincia] [int] NULL,
	[CodigoPostal] [int] NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[IdLocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Localidad_ObtenerPorProvinciaId]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Localidad_ObtenerPorProvinciaId]

@ProvinciaId int

AS
	BEGIN		
		SELECT *
		FROM Localidad
		WHERE (@ProvinciaId = IdProvincia)
	END
GO
/****** Object:  Table [dbo].[Afiliado]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Afiliado](
	[IdAfiliado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[NumeroInternoTitular] [varchar](40) NULL,
	[NumeroInternoFamiliar] [varchar](30) NULL,
	[FechaHoraCarga] [datetime] NOT NULL,
	[NumeroAfiliado] [varchar](50) NULL,
	[NumeroFamiliar] [varchar](50) NULL,
	[FechaNac] [date] NOT NULL,
	[CUIL] [varchar](50) NULL,
	[Sexo] [varchar](50) NULL,
	[Discapacitado] [varchar](50) NULL,
	[NivelDiscapacidad] [varchar](50) NULL,
	[Estudia] [varchar](5) NULL,
	[NivelEstudio] [varchar](50) NULL,
	[Trabaja] [varchar](50) NULL,
	[Censado] [varchar](50) NULL,
	[FechaExcepcion] [date] NULL,
	[MotivoExcepcion] [varchar](500) NULL,
	[Calle] [varchar](50) NOT NULL,
	[NumeroCalle] [varchar](10) NOT NULL,
	[Piso] [varchar](10) NULL,
	[Dpto] [varchar](20) NULL,
	[Pallier] [varchar](50) NULL,
	[Telefono] [varchar](50) NOT NULL,
	[TelefonoAux] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NULL,
	[CodigoPostal] [varchar](10) NOT NULL,
	[DocumentoTipo] [varchar](50) NULL,
	[NumeroDocumento] [varchar](50) NULL,
	[EntidadEmisora] [varchar](50) NULL,
	[Categoria] [varchar](50) NULL,
	[IdEmpresa] [int] NULL,
	[IdParentesco] [int] NULL,
	[IdEstadoCivil] [int] NULL,
	[IdFial] [int] NULL,
	[IdLocalidad] [int] NULL,
	[IdTipoPlan] [int] NULL,
	[Transferido] [varchar](50) NULL,
	[FechaIngreso] [date] NULL,
	[Filial] [varchar](100) NULL,
	[Delegacion] [varchar](100) NULL,
 CONSTRAINT [PK_Afiliado_1] PRIMARY KEY CLUSTERED 
(
	[IdAfiliado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Es el numero de Carnet del Afiliad ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Afiliado', @level2type=N'COLUMN',@level2name=N'NumeroAfiliado'
GO
/****** Object:  StoredProcedure [dbo].[CubrePlan_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CubrePlan_Modificar]
@Idplan int,
@IdNomanclador int,
@IdNomencladorNuevo int,
@Descipcion varchar(50)
AS
BEGIN
	update CubrePlan
	set 
	IdPlan = @Idplan,
	IdNomenclador = @IdNomencladorNuevo,
	Descripcion = @Descipcion
	
	where IdNomenclador = @IdNomanclador
	end
GO
/****** Object:  StoredProcedure [dbo].[CubrePlan_Insertar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CubrePlan_Insertar]
@IdPlan int,
@IdNomenc int, 
@Descripcion varchar(max)

as 
Begin 
Insert into CubrePlan
	(IdPlan,
	IdNomenclador,
	Descripcion)
Values 
(
	@IdPlan,
	@IdNomenc,
	@Descripcion
)
end
GO
/****** Object:  StoredProcedure [dbo].[Usuario_ObtenerPorId]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_ObtenerPorId]
(
@UsuarioId int
)

AS

BEGIN
			Select U.*, R.Nombre RolNombre
			From Usuario U LEFT OUTER JOIN Rol R on R.IdRol = U.IdRol
			WHERE
				U.IdUsuario = @UsuarioId
		END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_ObtenerPorCredenciales]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Usuario_ObtenerPorCredenciales]

@UserName varchar(100),
@Password varchar(200)

AS
	BEGIN		
		SELECT U.*, R.Nombre RolNombre
		FROM Usuario U LEFT OUTER JOIN Rol R on R.IdRol = U.IdRol
		WHERE (@UserName = U.Usuario) and (@Password = U.Contrasenia)
	END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Modificar]
@Id int,
@Nombre varchar(50),
@Apellido varchar(50),
@Usuario varchar(50),
@Rol int

AS
BEGIN
	update Usuario
	set 
	Nombre = @Nombre,
	Apellido = @Apellido,
	Usuario = @Usuario,
	IdRol = @Rol
	
	where IdUsuario = @Id
	end
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Insertar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Insertar]

@Nombre varchar(50),
@Apellido varchar(50),
@Rol int,
@Usuario varchar(50),
@Password varchar(50)

	AS 
	
BEGIN		
		INSERT INTO Usuario
		(
			Nombre,
			Apellido,
			IdRol,
			Usuario,
			Contrasenia,
			Activo
		)
		 VALUES (
			@Nombre,
			@Apellido,
			@Rol,
			@Usuario,
			@Password,
			1
		)
		
	Select @@identity as usuario_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Eliminar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Eliminar]
@Id int

AS
BEGIN
	delete from Usuario
	where IdUsuario = @Id
	end
GO
/****** Object:  StoredProcedure [dbo].[Usuario_CambiarPassword]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Usuario_CambiarPassword]

@Id int,
@PasswordAnterior varchar(200),
@PasswordNuevo varchar(200)

AS
	BEGIN
		declare @hola varchar(200)
		
		SELECT @hola = Contrasenia FROM Usuario
		WHERE @Id = IdUsuario
		if (@PasswordAnterior = @hola)
			BEGIN
				Update Usuario
				SET Contrasenia = @PasswordNuevo,
					Activo = 1
				WHERE IdUsuario = @Id
				SELECT 1 as result;
			END
		ELSE
			BEGIN
				SELECT 0 as result;
			END
		
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Buscar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Buscar]
(
@Nombre varchar(60),
@Apellido varchar(60),
@NombreUsuario varchar(20),
@Rol int
)

AS

BEGIN
			Select U.*, R.Nombre RolNombre
			From Usuario U LEFT OUTER JOIN Rol R on R.IdRol = U.IdRol
			WHERE
				((@Nombre is null or @Nombre = '') or (U.Nombre like '%' + @Nombre + '%'))
				and ((@Apellido is null or @Apellido = '') or (U.Apellido like '%' + @Apellido + '%'))
				and ((@NombreUsuario is null or @NombreUsuario = '') or (U.Usuario like '%' + @NombreUsuario + '%'))
				and ((@Rol = 0) or (U.IdRol = @Rol))
			ORDER BY
 				Apellido
		END
GO
/****** Object:  Table [dbo].[Profesional]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profesional](
	[IdProfesionales] [int] IDENTITY(1,1) NOT NULL,
	[Mail] [varchar](50) NULL,
	[Celular] [int] NULL,
	[Calle] [varchar](50) NULL,
	[NumeroCalle] [int] NULL,
	[Piso] [nchar](10) NULL,
	[Dpto] [nchar](10) NULL,
	[Matricula] [int] NULL,
	[Telefono] [int] NULL,
	[IdEspecialidad] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[ConsultorioNro] [nchar](10) NOT NULL,
	[HorariosAtencion] [datetime] NULL,
 CONSTRAINT [PK_Profesionales] PRIMARY KEY CLUSTERED 
(
	[IdProfesionales] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orden]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orden](
	[IdOrden] [int] IDENTITY(1,1) NOT NULL,
	[IdTipo] [int] NULL,
	[Fecha] [date] NULL,
	[IdAfiliado] [int] NULL,
 CONSTRAINT [PK_Orden] PRIMARY KEY CLUSTERED 
(
	[IdOrden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConsultaMedica]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConsultaMedica](
	[IdconsultaMedica] [int] IDENTITY(1,1) NOT NULL,
	[MotivoConsulta] [nchar](10) NULL,
	[AntecedenteEnfActual] [nchar](10) NULL,
	[Fecha] [nchar](10) NULL,
	[IdLineaHC] [int] NULL,
	[IdProfesional] [int] NULL,
 CONSTRAINT [PK_ConsultaMedica] PRIMARY KEY CLUSTERED 
(
	[IdconsultaMedica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Afiliado_ObtenerPorId]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Afiliado_ObtenerPorId]
(
	@AfiliadoId int
)

AS

BEGIN
			SELECT A.*,	EC.Nombre EstadoCivil, L.Nombre Localidad, P.IdProvincia ProvinciaId,
					P.Nombre Provincia, TP.Nombre TipoPlan, E.Nombre Empresa, 
					E.CUIT EmpresaCuit, PA.Nombre Parentesco
			FROM
				Afiliado A 
				left outer Join EstadoCivil EC on (A.IdEstadoCivil = EC.IdEstadoCivil)
				left outer Join Empresa E on (A.IdEmpresa = E.IdEmpresa)
				left outer join Localidad L on (A.IdLocalidad = L.IdLocalidad)
				left outer join Provincia P on (L.IdProvincia = P.IdProvincia)
				left outer join TipoPlan TP on (A.IdTipoPlan = TP.IdTipoPlan)
				left outer join Parentesco PA on (A.IdParentesco = PA.IdParentesco)
			WHERE
				A.IdAfiliado = @AfiliadoId
		END
GO
/****** Object:  StoredProcedure [dbo].[Afiliado_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Afiliado_Modificar]
@IdAfiliado int,
@Nombre varchar(50),
@Apellido varchar(50),
@NroInternoTitular varchar(40),
@NroInternoFamiliar varchar(30),
@NroAfiliadoTitular varchar(30),
@NroAfiliadoFamiliar varchar(30),
@FechaNacimiento date,
@Cuil varchar(20),
@Sexo varchar(50),
@Discapacitado varchar(50),
@NivelDiscapacidad varchar(40),
@Estudia varchar(50),
@NivelEstudio varchar(150),
@Trabaja varchar(50),
@Censado varchar(50),
@Calle varchar(50),
@CalleNumero varchar(10),
@Piso varchar(10),
@Departamento varchar(8),
@Pallier varchar(20),
@Telefono varchar(16),
@TelefonoAuxiliar varchar(16),
@CodigoPostal varchar(10),
@TipoDocumento varchar(30),
@NumeroDocumento varchar(50),
@EntidadEmisora varchar(100),
@CategoriaTitular varchar(100),
@EmpresaId int,
@Parentesco int,
@EstadoCivil int,
@Filial varchar(100),
@Delegacion varchar(100),
@Localidad int,
@Transferido varchar(10),
@FechaIngreso varchar(50),
@TipoPlan int,
@FechaExcepcion date,
@MotivoExcepcion varchar(600)

AS
	BEGIN		
		
		if @FechaExcepcion = '1900-01-01'
			set @FechaExcepcion = null
	
		Update Afiliado
		SET
			
			Nombre = @Nombre ,
			Apellido = @Apellido,
			NumeroInternoTitular = @NroInternoTitular, 
			NumeroInternoFamiliar = @NroInternoFamiliar ,
			NumeroAfiliado = @NroAfiliadoTitular ,
			NumeroFamiliar = @nroAfiliadoFamiliar ,
			FechaNac = @FechaNacimiento ,
			CUIL=@Cuil ,
			Sexo=@Sexo ,
			Discapacitado=@Discapacitado,
			NivelDiscapacidad=@NivelDiscapacidad ,
			Estudia=@Estudia ,
			NivelEstudio=@NivelEstudio ,
			Trabaja=@Trabaja ,
			Censado=@Censado ,
			FechaExcepcion = @FechaExcepcion,
			MotivoExcepcion=@MotivoExcepcion ,
			Calle=@Calle ,
			NumeroCalle=@CalleNumero ,
			Piso=@Piso ,
			Dpto=@Departamento ,
			Pallier=@Pallier ,
			Telefono=@Telefono ,
			TelefonoAux=@TelefonoAuxiliar,
			CodigoPostal=@CodigoPostal ,
			DocumentoTipo=@TipoDocumento ,
			NumeroDocumento=@NumeroDocumento ,
			EntidadEmisora=@EntidadEmisora ,
			Categoria=@CategoriaTitular,
			IdEmpresa=@EmpresaId ,
			IdParentesco=@Parentesco ,
			IdEstadoCivil=@EstadoCivil ,
			Filial=@Filial ,
			Delegacion=@Delegacion,
			IdLocalidad=@Localidad ,
			Transferido=@Transferido,
			FechaIngreso = @FechaIngreso,
			IdTipoPlan = @TipoPlan
			
			Where IdAfiliado = @IdAfiliado 
		
Select @IdAfiliado as af_id
	return
		
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Afiliado_Insertar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Afiliado_Insertar]
@Nombre varchar(50),
@Apellido varchar(50),
@NroInternoTitular varchar(40),
@NroInternoFamiliar varchar(30),
@FechaHora datetime,
@NroAfiliadoTitular varchar(30),
@NroAfiliadoFamiliar varchar(30),
@FechaNacimiento date,
@Cuil varchar(20),
@Sexo varchar(50),
@Discapacitado varchar(50),
@NivelDiscapacidad varchar(40),
@Estudia varchar(50),
@NivelEstudio varchar(150),
@Trabaja varchar(50),
@Censado varchar(50),
@Calle varchar(50),
@CalleNumero varchar(10),
@Piso varchar(10),
@Departamento varchar(8),
@Pallier varchar(20),
@Telefono varchar(16),
@TelefonoAuxiliar varchar(16),
@CodigoPostal varchar(10),
@TipoDocumento varchar(30),
@NumeroDocumento varchar(50),
@EntidadEmisora varchar(100),
@CategoriaTitular varchar(100),
@EmpresaId int,
@Parentesco int,
@EstadoCivil int,
@Filial varchar(100),
@Delegacion varchar(100),
@Localidad int,
@Transferido varchar(10),
@FechaIngreso varchar(50),
@TipoPlan int

AS
	BEGIN		
		INSERT INTO Afiliado
		(	
			Nombre,
			Apellido,
			NumeroInternoTitular,
			NumeroInternoFamiliar,
			FechaHoraCarga,
			NumeroAfiliado,
			NumeroFamiliar,
			FechaNac,
			CUIL,
			Sexo,
			Discapacitado,
			NivelDiscapacidad,
			Estudia,
			NivelEstudio,
			Trabaja,
			Censado,
			Calle,
			NumeroCalle,
			Piso,
			Dpto,
			Pallier,
			Telefono,
			TelefonoAux,
			CodigoPostal,
			DocumentoTipo,
			NumeroDocumento,
			EntidadEmisora,
			Categoria,
			IdEmpresa,
			IdParentesco,
			IdEstadoCivil,
			Filial,
			Delegacion,
			IdLocalidad,
			Transferido,
			FechaIngreso,
			IdTipoPlan
		) VALUES (			
			@Nombre,
			@Apellido,
			@NroInternoTitular ,
			@NroInternoFamiliar ,
			@FechaHora ,
			@NroAfiliadoTitular ,
			@nroAfiliadoFamiliar,
			@FechaNacimiento,
			@Cuil,
			@Sexo,
			@Discapacitado,
			@NivelDiscapacidad ,
			@Estudia ,
			@NivelEstudio ,
			@Trabaja ,
			@Censado ,
			@Calle ,
			@CalleNumero ,
			@Piso ,
			@Departamento ,
			@Pallier ,
			@Telefono ,
			@TelefonoAuxiliar ,
			@CodigoPostal ,
			@TipoDocumento ,
			@NumeroDocumento ,
			@EntidadEmisora ,
			@CategoriaTitular,
			@EmpresaId,
			@Parentesco ,
			@EstadoCivil,
			@Filial ,
			@Delegacion,
			@Localidad,
			@Transferido,
			@FechaIngreso,
			@TipoPlan
		)
		
	Select @@identity as af_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Afiliado_Desactivar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Afiliado_Desactivar]
@AfiliadoId int,
@FechaExcepcion date,
@MotivoExcepcion varchar(600)

AS
	BEGIN		
		Update Afiliado
		SET
			FechaExcepcion = @FechaExcepcion,
			MotivoExcepcion=@MotivoExcepcion
		Where 
			IdAfiliado = @AfiliadoId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Afiliado_Buscar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Afiliado_Buscar]
(
@Nombre varchar(60),
@Apellido varchar(60),
@NroDNI varchar(20),
@NroInterno varchar(30)
)

AS

BEGIN
			SELECT A.*,	EC.Nombre EstadoCivil, L.Nombre Localidad, P.IdProvincia ProvinciaId,
					P.Nombre Provincia, TP.Nombre TipoPlan, E.Nombre Empresa, 
					E.CUIT EmpresaCuit, PA.Nombre Parentesco
			FROM
				Afiliado A 
				left outer Join EstadoCivil EC on (A.IdEstadoCivil = EC.IdEstadoCivil)
				left outer Join Empresa E on (A.IdEmpresa = E.IdEmpresa)
				left outer join Localidad L on (A.IdLocalidad = L.IdLocalidad)
				left outer join Provincia P on (L.IdProvincia = P.IdProvincia)
				left outer join TipoPlan TP on (A.IdTipoPlan = TP.IdTipoPlan)
				left outer join Parentesco PA on (A.IdParentesco = PA.IdParentesco)
			WHERE
				((@Nombre is null) or (A.Nombre like '%' + @Nombre + '%'))
				and ((@Apellido is null) or (A.Apellido like '%' + @Apellido + '%'))
				and ((@NroDNI is null) or (A.NumeroDocumento like '%' + @NroDNI + '%'))
				and ((@NroInterno is null) or (A.NumeroInternoTitular like '%' + @NroInterno + '%'))
			ORDER BY
 				A.Apellido
		END
GO
/****** Object:  StoredProcedure [dbo].[Afiliado_Activar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Afiliado_Activar]
@AfiliadoId int

AS
	BEGIN		
		Update Afiliado
		SET
			FechaExcepcion = null,
			MotivoExcepcion= null
		Where 
			IdAfiliado = @AfiliadoId
		
	END
GO
/****** Object:  Table [dbo].[HistoriaClinica]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistoriaClinica](
	[historiaId] [int] IDENTITY(1,1) NOT NULL,
	[diagnosticoPresuntivo] [varchar](max) NULL,
	[metodosComplementarios] [varchar](max) NULL,
	[tratamiento] [varchar](max) NULL,
	[afiliadoId] [int] NULL,
	[patologiaId] [int] NULL,
 CONSTRAINT [PK_HistoriaClinica] PRIMARY KEY CLUSTERED 
(
	[historiaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EvolucionClinica]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EvolucionClinica](
	[evolucionId] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[contenido] [varchar](max) NULL,
	[historiaId] [int] NULL,
 CONSTRAINT [PK_EvolucionClinica] PRIMARY KEY CLUSTERED 
(
	[evolucionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExamenVarios]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExamenVarios](
	[examenVariosId] [int] IDENTITY(1,1) NOT NULL,
	[craneo] [varchar](200) NULL,
	[ojo] [varchar](200) NULL,
	[oido] [varchar](200) NULL,
	[pcfg] [varchar](600) NULL,
	[toraxForma] [varchar](200) NULL,
	[toraxMamas] [varchar](200) NULL,
	[auscultacionMV] [varchar](200) NULL,
	[auscultacionVV] [varchar](200) NULL,
	[rales] [varchar](200) NULL,
	[excursion] [varchar](600) NULL,
	[acvR1] [varchar](200) NULL,
	[acvR2] [varchar](200) NULL,
	[soplos] [varchar](200) NULL,
	[carotideo] [varchar](200) NULL,
	[radial] [varchar](200) NULL,
	[femoral] [varchar](200) NULL,
	[pedio] [varchar](200) NULL,
	[ppRenalDerecha] [varchar](200) NULL,
	[ppRenalIzquierda] [varchar](200) NULL,
	[mamas] [varchar](200) NULL,
	[historiaId] [int] NULL,
 CONSTRAINT [PK_ExamenVarios] PRIMARY KEY CLUSTERED 
(
	[examenVariosId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HabitosToxicos]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HabitosToxicos](
	[tipoHabitoId] [int] NOT NULL,
	[historiaId] [int] NOT NULL,
 CONSTRAINT [PK_HabitosToxicos] PRIMARY KEY CLUSTERED 
(
	[tipoHabitoId] ASC,
	[historiaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Historia_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Historia_Modificar]
	@Diagnostico varchar(max),
	@Metodos varchar(max),
	@Tratamiento varchar(max),
	@HistoriaId int,
	@PatologiaId int
AS
BEGIN
	
	Update HistoriaClinica
		Set	
			[diagnosticoPresuntivo] = @Diagnostico
           ,[metodosComplementarios] = @Metodos
           ,[tratamiento] = @Tratamiento
           ,[patologiaId] = @PatologiaId
		where
			historiaId = @HistoriaId
		
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Historia_Guardar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Historia_Guardar]
	@Diagnostico varchar(max),
	@Metodos varchar(max),
	@Tratamiento varchar(max),
	@AfiliadoId int,
	@PatologiaId int
AS
BEGIN
	
	INSERT INTO HistoriaClinica
		(	
			[diagnosticoPresuntivo]
           ,[metodosComplementarios]
           ,[tratamiento]
           ,[afiliadoId]
           ,[patologiaId]
		) VALUES (			
			@Diagnostico,
			@Metodos,
			@Tratamiento,
			@AfiliadoId,
			@PatologiaId
		)
		
	Select @@identity as historia_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Historia_Eliminar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Historia_Eliminar]
	@HistoriaId int
AS
BEGIN
	
	DELETE FROM HistoriaClinica
	WHERE historiaId = @HistoriaId
		
	END
GO
/****** Object:  Table [dbo].[Kinesica]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kinesica](
	[IdKinesica] [int] IDENTITY(1,1) NOT NULL,
	[IdConsuMedica] [int] NOT NULL,
	[Resumen] [varbinary](max) NULL,
	[Indicacionkinesica] [varchar](max) NULL,
 CONSTRAINT [PK_Kinesica_1] PRIMARY KEY CLUSTERED 
(
	[IdKinesica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Informe_OrdenesVendidas]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Informe_OrdenesVendidas]
( 
	@FechaInicio Date,
	@FechaFin Date
)

AS
BEGIN
	SELECT
		TOR.Nombre Nombre,
		Cantidad =(Select COUNT(*) 
		 from Orden O 
		 where TOR.IdTipoOrden = O.IdTipo
		 and (O.Fecha BETWEEN @FechaInicio and @FechaFin)),
		 Total =((Select COUNT(*) 
		  from Orden O
		  where TOR.IdTipoOrden = O.IdTipo
		  and (O.Fecha BETWEEN @FechaInicio and @FechaFin)) * 
		  (SELECT CAST(TOR.PrecioOrden AS INT)))
		 
	FROM
		TipoOrden TOR
	
END
GO
/****** Object:  Table [dbo].[Abdomen]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Abdomen](
	[abdomenId] [int] IDENTITY(1,1) NOT NULL,
	[inspeccion] [varchar](100) NULL,
	[palpacion] [varchar](100) NULL,
	[auscultacion] [varchar](300) NULL,
	[historiaId] [int] NULL,
 CONSTRAINT [PK_Abdomen] PRIMARY KEY CLUSTERED 
(
	[abdomenId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ConsultaInicial]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConsultaInicial](
	[consultaId] [int] IDENTITY(1,1) NOT NULL,
	[autoValidoTotal] [varchar](max) NULL,
	[autoValidoParcial] [varchar](max) NULL,
	[dependiente] [varchar](max) NULL,
	[motivoConsulta] [varchar](max) NULL,
	[antecedentesEnfermedad] [varchar](max) NULL,
	[historiaId] [int] NULL,
 CONSTRAINT [PK_ConsultaInicial] PRIMARY KEY CLUSTERED 
(
	[consultaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clinica]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clinica](
	[IdCLinica] [int] IDENTITY(1,1) NOT NULL,
	[ResumenClinico] [varchar](50) NULL,
	[IdConsulMedica] [int] NOT NULL,
	[ObjetivosTerapeuticos] [nvarchar](50) NULL,
 CONSTRAINT [PK_Clinica_1] PRIMARY KEY CLUSTERED 
(
	[IdCLinica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Antecedente]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Antecedente](
	[tipoAntecedenteId] [int] NOT NULL,
	[historiaId] [int] NOT NULL,
	[descripcion] [varchar](max) NULL,
	[fechaInicio] [varchar](50) NULL,
	[medicacion] [varchar](500) NULL,
	[resolucion] [varchar](max) NULL,
 CONSTRAINT [PK_Antecedente] PRIMARY KEY CLUSTERED 
(
	[tipoAntecedenteId] ASC,
	[historiaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cuello]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cuello](
	[cuelloId] [int] IDENTITY(1,1) NOT NULL,
	[palpacion] [varchar](100) NULL,
	[tamanio] [varchar](100) NULL,
	[auscultacion] [varchar](max) NULL,
	[historiaId] [int] NULL,
 CONSTRAINT [PK_Cuello] PRIMARY KEY CLUSTERED 
(
	[cuelloId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OsteoMuscular]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OsteoMuscular](
	[osteoMuscularId] [int] IDENTITY(1,1) NOT NULL,
	[columnaCervical] [varchar](200) NULL,
	[dorsal] [varchar](200) NULL,
	[lumbar] [varchar](200) NULL,
	[articulaciones] [varchar](200) NULL,
	[movilidad] [varchar](200) NULL,
	[dolor] [varchar](200) NULL,
	[tumefaccion] [varchar](200) NULL,
	[historiaId] [int] NULL,
 CONSTRAINT [PK_OsteoMuscular] PRIMARY KEY CLUSTERED 
(
	[osteoMuscularId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Orden_Insertar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Orden_Insertar]

@Fecha varchar(50),
@AfiliadoId int,
@TipoOrdenId int

	AS 
	
BEGIN		
		INSERT INTO Orden
		(
			Fecha,
			IdAfiliado,
			IdTipo
		)
		 VALUES (
			@Fecha,
			@AfiliadoId,
			@TipoOrdenId
		)
		
	Select @@identity as orden_id
	return
		
	END
GO
/****** Object:  Table [dbo].[ExamenCRayos]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExamenCRayos](
	[IdNomenclador] [int] NOT NULL,
	[Imangen] [image] NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](505) NULL,
	[IdConsultaMedica] [int] NOT NULL,
 CONSTRAINT [PK_ExamenCRayos] PRIMARY KEY CLUSTERED 
(
	[IdNomenclador] ASC,
	[IdConsultaMedica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Presento]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Presento](
	[IdConsultaMedica] [int] NOT NULL,
	[IdSintomas] [int] NOT NULL,
	[Descipcion] [varchar](510) NOT NULL,
 CONSTRAINT [PK_Presento] PRIMARY KEY CLUSTERED 
(
	[IdConsultaMedica] ASC,
	[IdSintomas] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Presenta]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Presenta](
	[IdConsultaMedica] [int] NOT NULL,
	[IdExFisicio] [int] NOT NULL,
	[Descipcion] [varchar](510) NOT NULL,
 CONSTRAINT [PK_Presenta] PRIMARY KEY CLUSTERED 
(
	[IdConsultaMedica] ASC,
	[IdExFisicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Prescripcion]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prescripcion](
	[IdConsultaMedica] [int] NOT NULL,
	[IdVademecun] [int] NOT NULL,
	[Descipcion] [varchar](500) NULL,
 CONSTRAINT [PK_Prescripcion] PRIMARY KEY CLUSTERED 
(
	[IdConsultaMedica] ASC,
	[IdVademecun] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PlanEstudios]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PlanEstudios](
	[IdNomenclador] [int] NOT NULL,
	[IdConsulMedica] [int] NOT NULL,
	[Descripcon] [varchar](max) NULL,
 CONSTRAINT [PK_PlanEstudios] PRIMARY KEY CLUSTERED 
(
	[IdNomenclador] ASC,
	[IdConsulMedica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SignosVitales]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SignosVitales](
	[signosVitalesId] [int] IDENTITY(1,1) NOT NULL,
	[frecuenciaCardiaca] [varchar](100) NULL,
	[pulsoRadial] [varchar](100) NULL,
	[ritmo] [varchar](100) NULL,
	[presionArterial] [varchar](100) NULL,
	[frecuenciaRespiratoria] [varchar](100) NULL,
	[pesoActual] [varchar](100) NULL,
	[pesoHabitual] [varchar](100) NULL,
	[estatura] [varchar](100) NULL,
	[temperatura] [varchar](100) NULL,
	[historiaId] [int] NULL,
 CONSTRAINT [PK_SignosVitales] PRIMARY KEY CLUSTERED 
(
	[signosVitalesId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SistemaNervioso]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SistemaNervioso](
	[sistemaNerviosoId] [int] IDENTITY(1,1) NOT NULL,
	[sensorio] [varchar](200) NULL,
	[lenguaje] [varchar](200) NULL,
	[marcha] [varchar](200) NULL,
	[temblor] [varchar](200) NULL,
	[taxia] [varchar](200) NULL,
	[reflejosFotomotor] [varchar](200) NULL,
	[reflejosAcomodacion] [varchar](200) NULL,
	[osteotendinosos] [varchar](200) NULL,
	[sensibilidad] [varchar](200) NULL,
	[historiaId] [int] NULL,
 CONSTRAINT [PK_SistemaNervioso] PRIMARY KEY CLUSTERED 
(
	[sistemaNerviosoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SistemaNervioso_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SistemaNervioso_Modificar]
	@Sensorio varchar(200),
    @Lenguaje varchar(200),
    @Marcha varchar(200),
    @Temblor varchar(200),
    @Taxia varchar(200),
    @ReflejosFotomotor varchar(200),
    @ReflejosAcomodacion varchar(200),
    @Osteotendinosos varchar(200),
    @Sensibilidad varchar(200),
    @HistoriaId int
AS
BEGIN
	
	Update SistemaNervioso
		SET	
			[sensorio] = @Sensorio
           ,[lenguaje] = @Lenguaje
           ,[marcha] = @Marcha
           ,[temblor] = @Temblor
           ,[taxia] = @Taxia
           ,[reflejosFotomotor] = @ReflejosFotomotor
           ,[reflejosAcomodacion] = @ReflejosAcomodacion
           ,[osteotendinosos] = @Osteotendinosos
           ,[sensibilidad] = @Sensibilidad
        where
           [historiaId] = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[SistemaNervioso_Guardar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SistemaNervioso_Guardar]
	@Sensorio varchar(200),
    @Lenguaje varchar(200),
    @Marcha varchar(200),
    @Temblor varchar(200),
    @Taxia varchar(200),
    @ReflejosFotomotor varchar(200),
    @ReflejosAcomodacion varchar(200),
    @Osteotendinosos varchar(200),
    @Sensibilidad varchar(200),
    @HistoriaId int
AS
BEGIN
	
	INSERT INTO SistemaNervioso
		(	
			[sensorio]
           ,[lenguaje]
           ,[marcha]
           ,[temblor]
           ,[taxia]
           ,[reflejosFotomotor]
           ,[reflejosAcomodacion]
           ,[osteotendinosos]
           ,[sensibilidad]
           ,[historiaId]
		) VALUES (			
			@Sensorio,
			@Lenguaje,
			@Marcha,
			@Temblor,
			@Taxia,
			@ReflejosFotomotor,
			@ReflejosAcomodacion,
			@Osteotendinosos,
			@Sensibilidad,
			@HistoriaId
		)
		
	Select @@identity as sistemaNervioso_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[SistemaNervioso_Eliminar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SistemaNervioso_Eliminar]
	@HistoriaId int
AS
BEGIN
	
	DELETE FROM SistemaNervioso
	WHERE historiaId = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[SignosVitales_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SignosVitales_Modificar]
	@FrecuenciaCardiaca varchar(100),
    @PulsoRadial varchar(100),
    @Ritmo varchar(100),
    @PresionArterial varchar(100),
    @FrecuenciaRespiratoria varchar(100),
    @PesoActual varchar(100),
    @PesoHabitual varchar(100),
    @Estatura varchar(100),
    @Temperatura varchar(100),
    @HistoriaId int
AS
BEGIN
	
	UPDATE SignosVitales
		SET	
			[frecuenciaCardiaca] = @FrecuenciaCardiaca
           ,[pulsoRadial] = @PulsoRadial
           ,[ritmo] = @Ritmo
           ,[presionArterial] = @PresionArterial
           ,[frecuenciaRespiratoria] = @FrecuenciaRespiratoria
           ,[pesoActual] = @PesoActual
           ,[pesoHabitual] = @PesoHabitual
           ,[estatura] = @Estatura
           ,[temperatura] = @Temperatura
        where
           [historiaId] = @HistoriaId
           
	END
GO
/****** Object:  StoredProcedure [dbo].[SignosVitales_Guardar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SignosVitales_Guardar]
	@FrecuenciaCardiaca varchar(100),
    @PulsoRadial varchar(100),
    @Ritmo varchar(100),
    @PresionArterial varchar(100),
    @FrecuenciaRespiratoria varchar(100),
    @PesoActual varchar(100),
    @PesoHabitual varchar(100),
    @Estatura varchar(100),
    @Temperatura varchar(100),
    @HistoriaId int
AS
BEGIN
	
	INSERT INTO SignosVitales
		(	
			[frecuenciaCardiaca]
           ,[pulsoRadial]
           ,[ritmo]
           ,[presionArterial]
           ,[frecuenciaRespiratoria]
           ,[pesoActual]
           ,[pesoHabitual]
           ,[estatura]
           ,[temperatura]
           ,[historiaId]
		) VALUES (			
			@FrecuenciaCardiaca,
			@PulsoRadial,
			@Ritmo,
			@PresionArterial,
			@FrecuenciaRespiratoria,
			@PesoActual,
			@PesoHabitual,
			@Estatura,
			@Temperatura,
			@HistoriaId
		)
		
	Select @@identity as signosVitales_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[SignosVitales_Eliminar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SignosVitales_Eliminar]
	@HistoriaId int
AS
BEGIN
	
	DELETE FROM SignosVitales
	WHERE historiaId = @HistoriaId
		
	END
GO
/****** Object:  Table [dbo].[PlanKinesico]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanKinesico](
	[IdPlan] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[IdKinesica] [int] NOT NULL,
	[DescripcionControl] [nvarchar](200) NULL,
	[IdNomenclador] [int] NOT NULL,
 CONSTRAINT [PK_PlanKinesico_1] PRIMARY KEY CLUSTERED 
(
	[IdPlan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[OsteoMuscular_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OsteoMuscular_Modificar]
	@ColumnaCervical varchar(200),
    @Dorsal varchar(200),
    @Lumbar varchar(200),
    @Movilidad varchar(200),
    @Dolor varchar(200),
    @Tumefaccion varchar(200),
    @HistoriaId int
AS
BEGIN
	
	Update OsteoMuscular
		Set	
			[columnaCervical] = @ColumnaCervical
           ,[dorsal] = @Dorsal
           ,[lumbar] = @Lumbar
           ,[movilidad] = @Movilidad
           ,[dolor] = @Dolor
           ,[tumefaccion] = @Tumefaccion
        where   
           [historiaId] = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[OsteoMuscular_Guardar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OsteoMuscular_Guardar]
	@ColumnaCervical varchar(200),
    @Dorsal varchar(200),
    @Lumbar varchar(200),
    @Movilidad varchar(200),
    @Dolor varchar(200),
    @Tumefaccion varchar(200),
    @HistoriaId int
AS
BEGIN
	
	INSERT INTO OsteoMuscular
		(	
			[columnaCervical]
           ,[dorsal]
           ,[lumbar]
           ,[movilidad]
           ,[dolor]
           ,[tumefaccion]
           ,[historiaId]
		) VALUES (			
			@ColumnaCervical,
			@Dorsal,
			@Lumbar,
			@Movilidad,
			@Dolor,
			@Tumefaccion,
			@HistoriaId
		)
		
	Select @@identity as osteoMuscular_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[OsteoMuscular_Eliminar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OsteoMuscular_Eliminar]
	@HistoriaId int
AS
BEGIN
	
	DELETE FROM OsteoMuscular
	WHERE historiaId = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Cuello_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cuello_Modificar]
	@Palpacion varchar(100),
	@Tamanio varchar(100),
	@Auscultacion varchar(max),
	@HistoriaId int
AS
BEGIN
	
	Update Cuello
		SET
			palpacion = @Palpacion,
			tamanio = @Tamanio,
			auscultacion = @Auscultacion
		where
			historiaId = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Cuello_Guardar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cuello_Guardar]
	@Palpacion varchar(100),
	@Tamanio varchar(100),
	@Auscultacion varchar(max),
	@HistoriaId int
AS
BEGIN
	
	INSERT INTO Cuello
		(	
			palpacion,
			tamanio,
			auscultacion,
			historiaId
		) VALUES (			
			@Palpacion,
			@Tamanio,
			@Auscultacion,
			@HistoriaId
		)
		
	Select @@identity as cuello_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Cuello_Eliminar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cuello_Eliminar]
	@HistoriaId int
AS
BEGIN
	
	DELETE FROM Cuello
	WHERE historiaId = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[ConsultaInicial_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultaInicial_Modificar]
	@Total varchar(max),
	@Parcial varchar(max),
	@Dependiente varchar(max),
	@Motivo varchar(max),
	@AntecedentesEnfermedad varchar(max),
	@HistoriaId int
AS
BEGIN
	
	Update ConsultaInicial
		Set	
			autoValidoTotal = @Total,
			autoValidoParcial = @Parcial,
			dependiente = @Dependiente,
			motivoConsulta = @Motivo,
			antecedentesEnfermedad = @AntecedentesEnfermedad
		where
			historiaId = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[ConsultaInicial_Guardar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultaInicial_Guardar]
	@Total varchar(max),
	@Parcial varchar(max),
	@Dependiente varchar(max),
	@Motivo varchar(max),
	@AntecedentesEnfermedad varchar(max),
	@HistoriaId int
AS
BEGIN
	
	INSERT INTO ConsultaInicial
		(	
			autoValidoTotal,
			autoValidoParcial,
			dependiente,
			motivoConsulta,
			antecedentesEnfermedad,
			historiaId
		) VALUES (			
			@Total,
			@Parcial,
			@Dependiente,
			@Motivo,
			@AntecedentesEnfermedad,
			@HistoriaId
		)
		
	Select @@identity as consulta_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[ConsultaInicial_Eliminar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultaInicial_Eliminar]
	@HistoriaId int
AS
BEGIN
	
	DELETE FROM ConsultaInicial
	WHERE historiaId = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Antecedente_ObtenerPorHistoriaId]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Antecedente_ObtenerPorHistoriaId]

@HistoriaId int

AS
	BEGIN		
		SELECT *
		FROM 
			Antecedente
		WHERE 
		(@HistoriaId = historiaId)
	END
GO
/****** Object:  StoredProcedure [dbo].[Antecedente_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Antecedente_Modificar]
	@TipoAntecedenteId int,
	@HistoriaId int,
	@Descripcion varchar(max),
	@FechaInicio varchar(50),
	@Medicacion  varchar(500),
	@Resolucion varchar(max)
AS
BEGIN
	Update Antecedente
	set
			descripcion = @Descripcion,
			fechaInicio = @FechaInicio,
			medicacion = @Medicacion,
			resolucion = @Resolucion
				
			where tipoAntecedenteId = @TipoAntecedenteId and historiaId = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Antecedente_Guardar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Antecedente_Guardar]
	@TipoAntecedenteId int,
	@HistoriaId int,
	@Descripcion varchar(max),
	@FechaInicio varchar(50),
	@Medicacion  varchar(500),
	@Resolucion varchar(max)
AS
BEGIN
	
	INSERT INTO Antecedente
		(	
			tipoAntecedenteId,
			historiaId,
			descripcion,
			fechaInicio,
			medicacion,
			resolucion
		) VALUES (			
			@TipoAntecedenteId,
			@HistoriaId,
			@Descripcion,
			@FechaInicio,
			@Medicacion,
			@Resolucion
		)
		
	Select @@identity as antecedente_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Antecedente_EliminarPorHistoriaId]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Antecedente_EliminarPorHistoriaId]
	@HistoriaId int
AS
BEGIN
	
	Delete from Antecedente
	where historiaId = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Abdomen_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Abdomen_Modificar]
	@Inspeccion varchar(100),
	@Palpacion varchar(100),
	@Auscultacion varchar(300),
	@HistoriaId int
AS
BEGIN
	update Abdomen 
	set 
	inspeccion = @Inspeccion,
	palpacion = @Palpacion,
	auscultacion = @Auscultacion
	
	where historiaId = @HistoriaId
	END
GO
/****** Object:  StoredProcedure [dbo].[Abdomen_Guardar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Abdomen_Guardar]
	@Inspeccion varchar(100),
	@Palpacion varchar(100),
	@Auscultacion varchar(300),
	@HistoriaId int
AS
BEGIN
	
	INSERT INTO Abdomen
		(	
			inspeccion,
			palpacion,
			auscultacion,
			historiaId
		) VALUES (			
			@Inspeccion,
			@Palpacion,
			@Auscultacion,
			@HistoriaId
		)
		
	Select @@identity as abdomen_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Abdomen_Eliminar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Abdomen_Eliminar]
	@HistoriaId int
AS
BEGIN
	
	DELETE FROM Abdomen
	WHERE historiaId = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[Historia_ObtenerPorId]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Historia_ObtenerPorId]

@HistoriaId int

AS
	BEGIN		
		SELECT HC.*, 
		AB.abdomenId, AB.inspeccion, AB.palpacion, AB.auscultacion,
		CI.consultaId, CI.autoValidoTotal, CI.autoValidoParcial, CI.dependiente,CI.motivoConsulta, CI.antecedentesEnfermedad,
		C.cuelloId, C.palpacion, C.tamanio, C.auscultacion,
		DP.datosId, DP.nombreYApellido, DP.edad, DP.sexo, DP.nroDocumento, DP.obraSocial, DP.obraSocialNro, DP.nacionalidad, DP.profesion, DP.fechaNacimiento, DP.estadoCivilId, DP.domicilio, DP.telefono, DP.contactoEmergencia, DP.telefonoEmergencia,
		OM.osteoMuscularId, OM.columnaCervical, OM.dorsal, OM.lumbar, OM.movilidad, OM.dolor, OM.tumefaccion,
		SV.signosVitalesId, SV.frecuenciaCardiaca, SV.pulsoRadial, SV.ritmo, SV.presionArterial, SV.frecuenciaRespiratoria, SV.pesoActual, SV.pesoHabitual, SV.estatura, SV.temperatura,
		SN.sistemaNerviosoId, SN.sensorio, SN.lenguaje, SN.marcha, SN.temblor, SN.taxia, SN.reflejosFotomotor, SN.reflejosAcomodacion, SN.osteotendinosos, SN.sensibilidad,
		EV.craneo, EV.ojo, EV.oido, EV.pcfg, EV.toraxForma, EV.toraxMamas, EV.auscultacionMV, EV.auscultacionVV, EV.rales, EV.excursion, EV.acvR1, EV.acvR2, EV.soplos, EV.carotideo, EV.radial, EV.femoral, EV.pedio, EV.ppRenalDerecha, EV.ppRenalIzquierda, EV.mamas,
		EC.nombre estadoCivil,
		P.PatologiaId patologiaId, P.Nombre patologiaNombre, P.Descripcion patologiaDescripcion
		
		FROM 
			HistoriaClinica HC
			left outer Join ConsultaInicial CI on (CI.historiaId = HC.historiaId)
			left outer Join DatosPersonales DP on (DP.historiaId = HC.historiaId)
			left outer Join Abdomen AB on (AB.historiaId = HC.historiaId)
			left outer Join Cuello C on (C.historiaId = HC.historiaId)
			left outer Join ExamenVarios EV on (EV.historiaId = HC.historiaId)
			left outer Join OsteoMuscular OM on (OM.historiaId = HC.historiaId)
			left outer Join SignosVitales SV on (SV.historiaId = HC.historiaId)
			left outer Join SistemaNervioso SN on (SN.historiaId = HC.historiaId)
			left outer join EstadoCivil EC on (DP.estadoCivilId = EC.estadoCivilId)
			left outer Join Patologias P on (P.PatologiaId = HC.patologiaId)
			
		WHERE (@HistoriaId = HC.historiaId)
	END
GO
/****** Object:  StoredProcedure [dbo].[Historia_BusquedaRapida]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Historia_BusquedaRapida]

@Parametro varchar(150)

AS
	BEGIN		
		SELECT HC.*, 
		AB.abdomenId, AB.inspeccion, AB.palpacion, AB.auscultacion,
		CI.consultaId, CI.autoValidoTotal, CI.autoValidoParcial, CI.dependiente,CI.motivoConsulta, CI.antecedentesEnfermedad,
		C.cuelloId, C.palpacion, C.tamanio, C.auscultacion,
		DP.datosId, DP.nombreYApellido, DP.edad, DP.sexo, DP.nroDocumento, DP.obraSocial, DP.obraSocialNro, DP.nacionalidad, DP.profesion, DP.fechaNacimiento, DP.estadoCivilId, DP.domicilio, DP.telefono, DP.contactoEmergencia, DP.telefonoEmergencia,
		OM.osteoMuscularId, OM.columnaCervical, OM.dorsal, OM.lumbar, OM.movilidad, OM.dolor, OM.tumefaccion,
		SV.signosVitalesId, SV.frecuenciaCardiaca, SV.pulsoRadial, SV.ritmo, SV.presionArterial, SV.frecuenciaRespiratoria, SV.pesoActual, SV.pesoHabitual, SV.estatura, SV.temperatura,
		SN.sistemaNerviosoId, SN.sensorio, SN.lenguaje, SN.marcha, SN.temblor, SN.taxia, SN.reflejosFotomotor, SN.reflejosAcomodacion, SN.osteotendinosos, SN.sensibilidad,
		EV.craneo, EV.ojo, EV.oido, EV.pcfg, EV.toraxForma, EV.toraxMamas, EV.auscultacionMV, EV.auscultacionVV, EV.rales, EV.excursion, EV.acvR1, EV.acvR2, EV.soplos, EV.carotideo, EV.radial, EV.femoral, EV.pedio, EV.ppRenalDerecha, EV.ppRenalIzquierda, EV.mamas,
		EC.nombre estadoCivil,
		P.PatologiaId patologiaId, P.Nombre patologiaNombre, P.Descripcion patologiaDescripcion
		
		FROM 
			HistoriaClinica HC
			left outer Join ConsultaInicial CI on (CI.historiaId = HC.historiaId)
			left outer Join DatosPersonales DP on (DP.historiaId = HC.historiaId)
			left outer Join Abdomen AB on (AB.historiaId = HC.historiaId)
			left outer Join Cuello C on (C.historiaId = HC.historiaId)
			left outer Join ExamenVarios EV on (EV.historiaId = HC.historiaId)
			left outer Join OsteoMuscular OM on (OM.historiaId = HC.historiaId)
			left outer Join SignosVitales SV on (SV.historiaId = HC.historiaId)
			left outer Join SistemaNervioso SN on (SN.historiaId = HC.historiaId)
			left outer join EstadoCivil EC on (DP.estadoCivilId = EC.estadoCivilId)
			left outer Join Patologias P on (P.PatologiaId = HC.patologiaId)
				
		WHERE 
		(DP.nombreYApellido LIKE '%' + @Parametro + '%')
		OR (DP.nroDocumento = @Parametro)
		OR (DP.obraSocialNro = @Parametro)
	END
GO
/****** Object:  StoredProcedure [dbo].[Historia_Buscar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[Historia_Buscar]

@AfiliadoId int = NULL

AS
	BEGIN		
		SELECT HC.*, 
		AB.abdomenId, AB.inspeccion, AB.palpacion, AB.auscultacion,
		CI.consultaId, CI.autoValidoTotal, CI.autoValidoParcial, CI.dependiente,CI.motivoConsulta, CI.antecedentesEnfermedad,
		C.cuelloId, C.palpacion, C.tamanio, C.auscultacion,
		OM.osteoMuscularId, OM.columnaCervical, OM.dorsal, OM.lumbar, OM.movilidad, OM.dolor, OM.tumefaccion,
		SV.signosVitalesId, SV.frecuenciaCardiaca, SV.pulsoRadial, SV.ritmo, SV.presionArterial, SV.frecuenciaRespiratoria, SV.pesoActual, SV.pesoHabitual, SV.estatura, SV.temperatura,
		SN.sistemaNerviosoId, SN.sensorio, SN.lenguaje, SN.marcha, SN.temblor, SN.taxia, SN.reflejosFotomotor, SN.reflejosAcomodacion, SN.osteotendinosos, SN.sensibilidad,
		EV.craneo, EV.ojo, EV.oido, EV.pcfg, EV.toraxForma, EV.toraxMamas, EV.auscultacionMV, EV.auscultacionVV, EV.rales, EV.excursion, EV.acvR1, EV.acvR2, EV.soplos, EV.carotideo, EV.radial, EV.femoral, EV.pedio, EV.ppRenalDerecha, EV.ppRenalIzquierda, EV.mamas,
		P.PatologiaId patologiaId, P.Nombre patologiaNombre, P.Descripcion patologiaDescripcion
		
		
		FROM 
			HistoriaClinica HC
			left outer Join ConsultaInicial CI on (CI.historiaId = HC.historiaId)
			left outer Join Abdomen AB on (AB.historiaId = HC.historiaId)
			left outer Join Cuello C on (C.historiaId = HC.historiaId)
			left outer Join ExamenVarios EV on (EV.historiaId = HC.historiaId)
			left outer Join OsteoMuscular OM on (OM.historiaId = HC.historiaId)
			left outer Join SignosVitales SV on (SV.historiaId = HC.historiaId)
			left outer Join SistemaNervioso SN on (SN.historiaId = HC.historiaId)
			left outer Join Patologias P on (P.PatologiaId = HC.patologiaId)
				
		WHERE 
			(@AfiliadoId is null or HC.afiliadoId = @AfiliadoId)
			
		
	END
GO
/****** Object:  StoredProcedure [dbo].[HabitoToxico_ObtenerPorHistoriaId]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[HabitoToxico_ObtenerPorHistoriaId]

@HistoriaId int

AS
	BEGIN		
		SELECT HT.*, THT.Nombre nombre
		FROM 
			HabitosToxicos HT
			left outer Join TipoHabitoToxico THT on (THT.tipoHabitoId = HT.tipoHabitoId)
		WHERE 
		(@HistoriaId = historiaId)
	END
GO
/****** Object:  StoredProcedure [dbo].[HabitoToxico_Guardar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HabitoToxico_Guardar]
	@TipoHabitoId int,
	@HistoriaId int
AS
BEGIN
	
	INSERT INTO HabitosToxicos
		(	
			tipoHabitoId,
			historiaId
		) VALUES (			
			@TipoHabitoId,
			@HistoriaId
		)
		
	
		
	END
GO
/****** Object:  StoredProcedure [dbo].[HabitoToxico_EliminarPorHistoriaId]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HabitoToxico_EliminarPorHistoriaId]
	@HistoriaId int
AS
BEGIN
	
	Delete From HabitosToxicos
	Where historiaId = @HistoriaId
		
	
		
	END
GO
/****** Object:  StoredProcedure [dbo].[ExamenVarios_Modificar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExamenVarios_Modificar]
	@Craneo varchar(200),
	@Ojo varchar(200),
	@Oido varchar(200),
	@PCFG varchar(600),
	@ToraxForma varchar(200),
	@ToraxMamas varchar(200),
	@AuscultacionMV  varchar(200),
	@AuscultacionVV  varchar(200),
	@Rales  varchar(200),
	@Excursion varchar(600),
	@R1 varchar (200),
	@R2  varchar(200),
	@Soplos varchar(200),
	@Carotideo varchar(200),
	@Radial varchar(200),
	@Femoral varchar(200),
	@Pedio varchar(200),
	@PPRenalDerecha varchar(200),
	@PPRenalIzquierda varchar(200),
	@PPRenalMamas varchar(200),
	@HistoriaId int
AS
BEGIN
	
	Update ExamenVarios
		SET	
			craneo = @Craneo,
			ojo = @Ojo,
			oido = @Oido,
			pcfg = @PCFG,
			toraxForma = @ToraxForma,
			toraxMamas = @ToraxMamas,
			auscultacionMV = @AuscultacionMV,
			auscultacionVV = @AuscultacionVV,
			rales = @Rales,
			excursion = @Excursion,
			acvR1 = @R1,
			acvR2 = @R2,
			soplos = @Soplos,
			carotideo = @Carotideo,
			radial = @Radial,
			femoral = @Femoral,
			pedio = @Pedio,
			ppRenalDerecha = @PPRenalDerecha,
			ppRenalIzquierda = @PPRenalIzquierda,
			mamas = @PPRenalMamas
		where
			historiaId = @HistoriaId
	END
GO
/****** Object:  StoredProcedure [dbo].[ExamenVarios_Guardar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExamenVarios_Guardar]
	@Craneo varchar(200),
	@Ojo varchar(200),
	@Oido varchar(200),
	@PCFG varchar(600),
	@ToraxForma varchar(200),
	@ToraxMamas varchar(200),
	@AuscultacionMV  varchar(200),
	@AuscultacionVV  varchar(200),
	@Rales  varchar(200),
	@Excursion varchar(600),
	@R1 varchar (200),
	@R2  varchar(200),
	@Soplos varchar(200),
	@Carotideo varchar(200),
	@Radial varchar(200),
	@Femoral varchar(200),
	@Pedio varchar(200),
	@PPRenalDerecha varchar(200),
	@PPRenalIzquierda varchar(200),
	@PPRenalMamas varchar(200),
	@HistoriaId int
AS
BEGIN
	
	INSERT INTO ExamenVarios
		(	
			craneo,
			ojo,
			oido,
			pcfg,
			toraxForma,
			toraxMamas,
			auscultacionMV,
			auscultacionVV,
			rales,
			excursion,
			acvR1,
			acvR2,
			soplos,
			carotideo,
			radial,
			femoral,
			pedio,
			ppRenalDerecha,
			ppRenalIzquierda,
			mamas,
			historiaId
		) VALUES (			
			@Craneo,
			@Ojo,
			@Oido,
			@PCFG,
			@ToraxForma,
			@ToraxMamas,
			@AuscultacionMV,
			@AuscultacionVV,
			@Rales,
			@Excursion,
			@R1,
			@R2,
			@Soplos,
			@Carotideo,
			@Radial,
			@Femoral,
			@Pedio,
			@PPRenalDerecha,
			@PPRenalIzquierda,
			@PPRenalMamas,
			@HistoriaId
		)
		
	Select @@identity as examenVarios_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[ExamenVarios_Eliminar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExamenVarios_Eliminar]
	@HistoriaId int
AS
BEGIN
	
	DELETE FROM ExamenVarios
	WHERE historiaId = @HistoriaId
		
	END
GO
/****** Object:  StoredProcedure [dbo].[EvolucionClinica_ObtenerPorHistoriaId]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[EvolucionClinica_ObtenerPorHistoriaId]

@HistoriaId int

AS
	BEGIN		
		SELECT *
		FROM 
			EvolucionClinica
		WHERE 
		(@HistoriaId = historiaId)
	END
GO
/****** Object:  StoredProcedure [dbo].[EvolucionClinica_Guardar]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EvolucionClinica_Guardar]
	@Fecha date,
	@Contenido varchar(max),
	@HistoriaId int
AS
BEGIN
	
	INSERT INTO EvolucionClinica
		(	
			fecha,
			contenido,
			historiaId
		) VALUES (			
			@Fecha,
			@Contenido,
			@HistoriaId
		)
		
	Select @@identity as evolucion_id
	return
		
	END
GO
/****** Object:  StoredProcedure [dbo].[EvolucionClinica_EliminarPorHistoriaId]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[EvolucionClinica_EliminarPorHistoriaId]

@HistoriaId int

AS
	BEGIN		
		DELETE FROM EvolucionClinica
		WHERE 
		(@HistoriaId = historiaId)
	END
GO
/****** Object:  Table [dbo].[Evolucion]    Script Date: 04/26/2012 10:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evolucion](
	[IdEvolucion] [int] IDENTITY(1,1) NOT NULL,
	[IdPlan] [int] NOT NULL,
	[Descripcion] [varchar](max) NULL,
	[Datos] [varchar](max) NULL,
 CONSTRAINT [PK_Evolucion] PRIMARY KEY CLUSTERED 
(
	[IdEvolucion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Personal_Rol]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Personal_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Personal_Rol]
GO
/****** Object:  ForeignKey [Cubre]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[CubrePlan]  WITH CHECK ADD  CONSTRAINT [Cubre] FOREIGN KEY([IdPlan])
REFERENCES [dbo].[TipoPlan] ([IdTipoPlan])
GO
ALTER TABLE [dbo].[CubrePlan] CHECK CONSTRAINT [Cubre]
GO
/****** Object:  ForeignKey [FK_CubrePlan_Nomenclador]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[CubrePlan]  WITH CHECK ADD  CONSTRAINT [FK_CubrePlan_Nomenclador] FOREIGN KEY([IdNomenclador])
REFERENCES [dbo].[Nomenclador] ([IdNomenclador])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CubrePlan] CHECK CONSTRAINT [FK_CubrePlan_Nomenclador]
GO
/****** Object:  ForeignKey [Pertenece2]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Filial]  WITH CHECK ADD  CONSTRAINT [Pertenece2] FOREIGN KEY([IdDelegacion])
REFERENCES [dbo].[Delegacion] ([IdDelegacion])
GO
ALTER TABLE [dbo].[Filial] CHECK CONSTRAINT [Pertenece2]
GO
/****** Object:  ForeignKey [FK_ExamenCLaboratorio_Nomenclador]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[ExamenCLaboratorio]  WITH CHECK ADD  CONSTRAINT [FK_ExamenCLaboratorio_Nomenclador] FOREIGN KEY([IdNomenclador])
REFERENCES [dbo].[Nomenclador] ([IdNomenclador])
GO
ALTER TABLE [dbo].[ExamenCLaboratorio] CHECK CONSTRAINT [FK_ExamenCLaboratorio_Nomenclador]
GO
/****** Object:  ForeignKey [Pertenece]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Localidad]  WITH NOCHECK ADD  CONSTRAINT [Pertenece] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincia] ([IdProvincia])
ON UPDATE SET DEFAULT
ON DELETE CASCADE
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [Pertenece]
GO
/****** Object:  ForeignKey [FK_Afiliado_Empresa]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_Empresa] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_Empresa]
GO
/****** Object:  ForeignKey [FK_Afiliado_EstadoCivil]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_EstadoCivil] FOREIGN KEY([IdEstadoCivil])
REFERENCES [dbo].[EstadoCivil] ([IdEstadoCivil])
GO
ALTER TABLE [dbo].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_EstadoCivil]
GO
/****** Object:  ForeignKey [FK_Afiliado_Filial]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_Filial] FOREIGN KEY([IdFial])
REFERENCES [dbo].[Filial] ([IdFilial])
GO
ALTER TABLE [dbo].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_Filial]
GO
/****** Object:  ForeignKey [FK_Afiliado_Localidades]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_Localidades] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidad] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_Localidades]
GO
/****** Object:  ForeignKey [FK_Afiliado_Parentesco]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_Parentesco] FOREIGN KEY([IdParentesco])
REFERENCES [dbo].[Parentesco] ([IdParentesco])
GO
ALTER TABLE [dbo].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_Parentesco]
GO
/****** Object:  ForeignKey [TipoDePlanAfiliado]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Afiliado]  WITH CHECK ADD  CONSTRAINT [TipoDePlanAfiliado] FOREIGN KEY([IdTipoPlan])
REFERENCES [dbo].[TipoPlan] ([IdTipoPlan])
GO
ALTER TABLE [dbo].[Afiliado] CHECK CONSTRAINT [TipoDePlanAfiliado]
GO
/****** Object:  ForeignKey [FK_Profesionales_Personal]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesionales_Personal] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Profesional] CHECK CONSTRAINT [FK_Profesionales_Personal]
GO
/****** Object:  ForeignKey [Se Especializo]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Profesional]  WITH CHECK ADD  CONSTRAINT [Se Especializo] FOREIGN KEY([IdEspecialidad])
REFERENCES [dbo].[Especialidad] ([IdEspecialidad])
GO
ALTER TABLE [dbo].[Profesional] CHECK CONSTRAINT [Se Especializo]
GO
/****** Object:  ForeignKey [FK_Orden_Afiliado]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD  CONSTRAINT [FK_Orden_Afiliado] FOREIGN KEY([IdAfiliado])
REFERENCES [dbo].[Afiliado] ([IdAfiliado])
GO
ALTER TABLE [dbo].[Orden] CHECK CONSTRAINT [FK_Orden_Afiliado]
GO
/****** Object:  ForeignKey [FK_Orden_TipoOrden]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD  CONSTRAINT [FK_Orden_TipoOrden] FOREIGN KEY([IdTipo])
REFERENCES [dbo].[TipoOrden] ([IdTipoOrden])
GO
ALTER TABLE [dbo].[Orden] CHECK CONSTRAINT [FK_Orden_TipoOrden]
GO
/****** Object:  ForeignKey [FK_ConsultaMedica_Profesionales]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[ConsultaMedica]  WITH CHECK ADD  CONSTRAINT [FK_ConsultaMedica_Profesionales] FOREIGN KEY([IdProfesional])
REFERENCES [dbo].[Profesional] ([IdProfesionales])
GO
ALTER TABLE [dbo].[ConsultaMedica] CHECK CONSTRAINT [FK_ConsultaMedica_Profesionales]
GO
/****** Object:  ForeignKey [FK_HistoriaClinica_Afiliado]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaClinica_Afiliado] FOREIGN KEY([afiliadoId])
REFERENCES [dbo].[Afiliado] ([IdAfiliado])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_HistoriaClinica_Afiliado]
GO
/****** Object:  ForeignKey [FK_HistoriaClinica_Patologias]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaClinica_Patologias] FOREIGN KEY([patologiaId])
REFERENCES [dbo].[Patologias] ([PatologiaId])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_HistoriaClinica_Patologias]
GO
/****** Object:  ForeignKey [FK_EvolucionClinica_HistoriaClinica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[EvolucionClinica]  WITH CHECK ADD  CONSTRAINT [FK_EvolucionClinica_HistoriaClinica] FOREIGN KEY([historiaId])
REFERENCES [dbo].[HistoriaClinica] ([historiaId])
GO
ALTER TABLE [dbo].[EvolucionClinica] CHECK CONSTRAINT [FK_EvolucionClinica_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_ExamenVarios_HistoriaClinica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[ExamenVarios]  WITH CHECK ADD  CONSTRAINT [FK_ExamenVarios_HistoriaClinica] FOREIGN KEY([historiaId])
REFERENCES [dbo].[HistoriaClinica] ([historiaId])
GO
ALTER TABLE [dbo].[ExamenVarios] CHECK CONSTRAINT [FK_ExamenVarios_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_HabitosToxicos_HistoriaClinica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[HabitosToxicos]  WITH CHECK ADD  CONSTRAINT [FK_HabitosToxicos_HistoriaClinica] FOREIGN KEY([historiaId])
REFERENCES [dbo].[HistoriaClinica] ([historiaId])
GO
ALTER TABLE [dbo].[HabitosToxicos] CHECK CONSTRAINT [FK_HabitosToxicos_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_HabitosToxicos_TipoHabitoToxico]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[HabitosToxicos]  WITH CHECK ADD  CONSTRAINT [FK_HabitosToxicos_TipoHabitoToxico] FOREIGN KEY([tipoHabitoId])
REFERENCES [dbo].[TipoHabitoToxico] ([tipoHabitoId])
GO
ALTER TABLE [dbo].[HabitosToxicos] CHECK CONSTRAINT [FK_HabitosToxicos_TipoHabitoToxico]
GO
/****** Object:  ForeignKey [FK_Kinesica_ConsultaMedica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Kinesica]  WITH CHECK ADD  CONSTRAINT [FK_Kinesica_ConsultaMedica] FOREIGN KEY([IdConsuMedica])
REFERENCES [dbo].[ConsultaMedica] ([IdconsultaMedica])
GO
ALTER TABLE [dbo].[Kinesica] CHECK CONSTRAINT [FK_Kinesica_ConsultaMedica]
GO
/****** Object:  ForeignKey [FK_Abdomen_HistoriaClinica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Abdomen]  WITH CHECK ADD  CONSTRAINT [FK_Abdomen_HistoriaClinica] FOREIGN KEY([historiaId])
REFERENCES [dbo].[HistoriaClinica] ([historiaId])
GO
ALTER TABLE [dbo].[Abdomen] CHECK CONSTRAINT [FK_Abdomen_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_ConsultaInicial_HistoriaClinica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[ConsultaInicial]  WITH CHECK ADD  CONSTRAINT [FK_ConsultaInicial_HistoriaClinica] FOREIGN KEY([historiaId])
REFERENCES [dbo].[HistoriaClinica] ([historiaId])
GO
ALTER TABLE [dbo].[ConsultaInicial] CHECK CONSTRAINT [FK_ConsultaInicial_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_Clinica_ConsultaMedica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Clinica]  WITH CHECK ADD  CONSTRAINT [FK_Clinica_ConsultaMedica] FOREIGN KEY([IdConsulMedica])
REFERENCES [dbo].[ConsultaMedica] ([IdconsultaMedica])
GO
ALTER TABLE [dbo].[Clinica] CHECK CONSTRAINT [FK_Clinica_ConsultaMedica]
GO
/****** Object:  ForeignKey [FK_Antecedente_HistoriaClinica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Antecedente]  WITH CHECK ADD  CONSTRAINT [FK_Antecedente_HistoriaClinica] FOREIGN KEY([historiaId])
REFERENCES [dbo].[HistoriaClinica] ([historiaId])
GO
ALTER TABLE [dbo].[Antecedente] CHECK CONSTRAINT [FK_Antecedente_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_Antecedente_TipoAntecedente]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Antecedente]  WITH CHECK ADD  CONSTRAINT [FK_Antecedente_TipoAntecedente] FOREIGN KEY([tipoAntecedenteId])
REFERENCES [dbo].[TipoAntecedente] ([tipoAntecedenteId])
GO
ALTER TABLE [dbo].[Antecedente] CHECK CONSTRAINT [FK_Antecedente_TipoAntecedente]
GO
/****** Object:  ForeignKey [FK_Cuello_HistoriaClinica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Cuello]  WITH CHECK ADD  CONSTRAINT [FK_Cuello_HistoriaClinica] FOREIGN KEY([historiaId])
REFERENCES [dbo].[HistoriaClinica] ([historiaId])
GO
ALTER TABLE [dbo].[Cuello] CHECK CONSTRAINT [FK_Cuello_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_OsteoMuscular_HistoriaClinica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[OsteoMuscular]  WITH CHECK ADD  CONSTRAINT [FK_OsteoMuscular_HistoriaClinica] FOREIGN KEY([historiaId])
REFERENCES [dbo].[HistoriaClinica] ([historiaId])
GO
ALTER TABLE [dbo].[OsteoMuscular] CHECK CONSTRAINT [FK_OsteoMuscular_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_ExamenCRayos_ConsultaMedica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[ExamenCRayos]  WITH CHECK ADD  CONSTRAINT [FK_ExamenCRayos_ConsultaMedica] FOREIGN KEY([IdConsultaMedica])
REFERENCES [dbo].[ConsultaMedica] ([IdconsultaMedica])
GO
ALTER TABLE [dbo].[ExamenCRayos] CHECK CONSTRAINT [FK_ExamenCRayos_ConsultaMedica]
GO
/****** Object:  ForeignKey [FK_ExamenCRayos_Nomenclador]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[ExamenCRayos]  WITH CHECK ADD  CONSTRAINT [FK_ExamenCRayos_Nomenclador] FOREIGN KEY([IdNomenclador])
REFERENCES [dbo].[Nomenclador] ([IdNomenclador])
GO
ALTER TABLE [dbo].[ExamenCRayos] CHECK CONSTRAINT [FK_ExamenCRayos_Nomenclador]
GO
/****** Object:  ForeignKey [FK_Presento_ConsultaMedica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Presento]  WITH CHECK ADD  CONSTRAINT [FK_Presento_ConsultaMedica] FOREIGN KEY([IdConsultaMedica])
REFERENCES [dbo].[ConsultaMedica] ([IdconsultaMedica])
GO
ALTER TABLE [dbo].[Presento] CHECK CONSTRAINT [FK_Presento_ConsultaMedica]
GO
/****** Object:  ForeignKey [FK_Presento_Sintomas]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Presento]  WITH CHECK ADD  CONSTRAINT [FK_Presento_Sintomas] FOREIGN KEY([IdSintomas])
REFERENCES [dbo].[Sintoma] ([IdSintomas])
GO
ALTER TABLE [dbo].[Presento] CHECK CONSTRAINT [FK_Presento_Sintomas]
GO
/****** Object:  ForeignKey [FK_Presenta_ConsultaMedica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Presenta]  WITH CHECK ADD  CONSTRAINT [FK_Presenta_ConsultaMedica] FOREIGN KEY([IdConsultaMedica])
REFERENCES [dbo].[ConsultaMedica] ([IdconsultaMedica])
GO
ALTER TABLE [dbo].[Presenta] CHECK CONSTRAINT [FK_Presenta_ConsultaMedica]
GO
/****** Object:  ForeignKey [FK_Presenta_ExamenFisico]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Presenta]  WITH CHECK ADD  CONSTRAINT [FK_Presenta_ExamenFisico] FOREIGN KEY([IdExFisicio])
REFERENCES [dbo].[ExamenFisico] ([IdExamenFisico])
GO
ALTER TABLE [dbo].[Presenta] CHECK CONSTRAINT [FK_Presenta_ExamenFisico]
GO
/****** Object:  ForeignKey [FK_Prescripcion_ConsultaMedica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Prescripcion]  WITH CHECK ADD  CONSTRAINT [FK_Prescripcion_ConsultaMedica] FOREIGN KEY([IdConsultaMedica])
REFERENCES [dbo].[ConsultaMedica] ([IdconsultaMedica])
GO
ALTER TABLE [dbo].[Prescripcion] CHECK CONSTRAINT [FK_Prescripcion_ConsultaMedica]
GO
/****** Object:  ForeignKey [FK_Prescripcion_Vedemecun]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Prescripcion]  WITH CHECK ADD  CONSTRAINT [FK_Prescripcion_Vedemecun] FOREIGN KEY([IdVademecun])
REFERENCES [dbo].[Vedemecun] ([IdMedicamento])
GO
ALTER TABLE [dbo].[Prescripcion] CHECK CONSTRAINT [FK_Prescripcion_Vedemecun]
GO
/****** Object:  ForeignKey [FK_PlanEstudios_ConsultaMedica1]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[PlanEstudios]  WITH CHECK ADD  CONSTRAINT [FK_PlanEstudios_ConsultaMedica1] FOREIGN KEY([IdConsulMedica])
REFERENCES [dbo].[ConsultaMedica] ([IdconsultaMedica])
GO
ALTER TABLE [dbo].[PlanEstudios] CHECK CONSTRAINT [FK_PlanEstudios_ConsultaMedica1]
GO
/****** Object:  ForeignKey [FK_PlanEstudios_Nomenclador]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[PlanEstudios]  WITH CHECK ADD  CONSTRAINT [FK_PlanEstudios_Nomenclador] FOREIGN KEY([IdNomenclador])
REFERENCES [dbo].[Nomenclador] ([IdNomenclador])
GO
ALTER TABLE [dbo].[PlanEstudios] CHECK CONSTRAINT [FK_PlanEstudios_Nomenclador]
GO
/****** Object:  ForeignKey [FK_SignosVitales_HistoriaClinica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[SignosVitales]  WITH CHECK ADD  CONSTRAINT [FK_SignosVitales_HistoriaClinica] FOREIGN KEY([historiaId])
REFERENCES [dbo].[HistoriaClinica] ([historiaId])
GO
ALTER TABLE [dbo].[SignosVitales] CHECK CONSTRAINT [FK_SignosVitales_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_SistemaNervioso_HistoriaClinica]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[SistemaNervioso]  WITH CHECK ADD  CONSTRAINT [FK_SistemaNervioso_HistoriaClinica] FOREIGN KEY([historiaId])
REFERENCES [dbo].[HistoriaClinica] ([historiaId])
GO
ALTER TABLE [dbo].[SistemaNervioso] CHECK CONSTRAINT [FK_SistemaNervioso_HistoriaClinica]
GO
/****** Object:  ForeignKey [FK_PlanKinesico_Kinesica1]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[PlanKinesico]  WITH CHECK ADD  CONSTRAINT [FK_PlanKinesico_Kinesica1] FOREIGN KEY([IdKinesica])
REFERENCES [dbo].[Kinesica] ([IdKinesica])
GO
ALTER TABLE [dbo].[PlanKinesico] CHECK CONSTRAINT [FK_PlanKinesico_Kinesica1]
GO
/****** Object:  ForeignKey [FK_PlanKinesico_Nomenclador]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[PlanKinesico]  WITH CHECK ADD  CONSTRAINT [FK_PlanKinesico_Nomenclador] FOREIGN KEY([IdNomenclador])
REFERENCES [dbo].[Nomenclador] ([IdNomenclador])
GO
ALTER TABLE [dbo].[PlanKinesico] CHECK CONSTRAINT [FK_PlanKinesico_Nomenclador]
GO
/****** Object:  ForeignKey [FK_Evolucion_PlanKinesico]    Script Date: 04/26/2012 10:43:01 ******/
ALTER TABLE [dbo].[Evolucion]  WITH CHECK ADD  CONSTRAINT [FK_Evolucion_PlanKinesico] FOREIGN KEY([IdPlan])
REFERENCES [dbo].[PlanKinesico] ([IdPlan])
GO
ALTER TABLE [dbo].[Evolucion] CHECK CONSTRAINT [FK_Evolucion_PlanKinesico]
GO
