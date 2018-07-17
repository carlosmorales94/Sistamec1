USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 7/17/2018 8:28:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[NombreCliente] [varchar](100) NOT NULL,
	[Telefono] [int] NULL,
	[Movil] [int] NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Placa] [varchar](10) NOT NULL,
	[Cedula] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
