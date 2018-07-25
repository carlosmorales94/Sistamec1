USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 7/17/2018 8:28:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Cantidad] [int] NOT NULL,
	[Precio] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[IdProducto] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
