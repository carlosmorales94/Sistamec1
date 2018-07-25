USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 7/17/2018 8:28:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[Cedula] [int] NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[ProVeh] [varchar](300) NOT NULL,
	[FechaIngreso] [date] NOT NULL,
	[Placa] [varchar](10) NULL,
	[Estilo] [varchar](50) NULL,
	[Ano] [int] NOT NULL,
	[Nota] [varchar](200) NULL,
	[Bin] [int] NOT NULL,
	[Km] [int] NOT NULL,
	[RevisionIntervalos] [varchar](50) NULL,
	[MantenimientoPrevio] [varchar](50) NULL,
	[DanosVehiculo] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
