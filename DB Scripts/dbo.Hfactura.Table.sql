USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[Hfactura]    Script Date: 7/17/2018 8:28:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hfactura](
	[NumFac] [int] NOT NULL,
	[Cedula] [int] NOT NULL,
	[NombreCliente] [varchar](100) NOT NULL,
	[Telefono] [int] NULL,
	[Correo] [varchar](100) NOT NULL,
	[Placa] [varchar](10) NOT NULL,
	[Km] [int] NOT NULL,
	[Total] [int] NOT NULL,
	[Nota] [varchar](80) NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Valor] [int] NOT NULL,
	[Descripcion1] [varchar](200) NOT NULL,
	[Cantidad1] [int] NOT NULL,
	[Valor1] [int] NOT NULL,
	[Descripcion2] [varchar](200) NOT NULL,
	[Cantidad2] [int] NOT NULL,
	[Valor2] [int] NOT NULL,
	[Descripcion3] [varchar](200) NOT NULL,
	[Cantidad3] [int] NOT NULL,
	[Valor3] [int] NOT NULL,
	[Descripcion4] [varchar](200) NOT NULL,
	[Cantidad4] [int] NOT NULL,
	[Valor4] [int] NOT NULL,
	[Descripcion5] [varchar](200) NOT NULL,
	[Cantidad5] [int] NOT NULL,
	[Valor5] [int] NOT NULL,
	[Descripcion6] [varchar](200) NOT NULL,
	[Cantidad6] [int] NOT NULL,
	[Valor6] [int] NOT NULL,
	[Descripcion7] [varchar](200) NOT NULL,
	[Cantidad7] [int] NOT NULL,
	[Valor7] [int] NOT NULL,
	[Descripcion8] [varchar](200) NOT NULL,
	[Cantidad8] [int] NOT NULL,
	[Valor8] [int] NOT NULL,
	[Descripcion9] [varchar](200) NOT NULL,
	[Cantidad9] [int] NOT NULL,
	[Valor9] [int] NOT NULL
) ON [PRIMARY]
GO
