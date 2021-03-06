USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[DescProducto]    Script Date: 7/24/2018 2:12:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DescProducto](
	[Cantidad] [int] NOT NULL,
	[Precio] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Placa] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DescProducto]  WITH CHECK ADD  CONSTRAINT [FK_DescProducto_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[DescProducto] CHECK CONSTRAINT [FK_DescProducto_Producto]
GO
