USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 7/17/2018 8:28:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Ingreso] [int] NOT NULL,
	[Factura] [int] NULL,
	[Inventario] [int] NULL,
	[Citas] [int] NULL,
	[Configuracion] [int] NULL,
	[Reportes] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
