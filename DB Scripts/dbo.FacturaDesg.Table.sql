USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[FacturaDesg]    Script Date: 8/6/2018 11:22:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaDesg](
	[Id] [int] NOT NULL,
	[NumFac] [int] NOT NULL,
	[IdProducto] [nvarchar](20) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [float] NOT NULL,
	[Descuento] [float] NOT NULL,
 CONSTRAINT [PK_FacturaDesg] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [PK_id_FacturaDesg]    Script Date: 8/6/2018 11:22:38 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [PK_id_FacturaDesg] ON [dbo].[FacturaDesg]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FacturaDesg]  WITH CHECK ADD  CONSTRAINT [FK_FacturaDesg_Factura] FOREIGN KEY([NumFac])
REFERENCES [dbo].[Factura] ([NumFac])
GO
ALTER TABLE [dbo].[FacturaDesg] CHECK CONSTRAINT [FK_FacturaDesg_Factura]
GO
ALTER TABLE [dbo].[FacturaDesg]  WITH CHECK ADD  CONSTRAINT [FK_FacturaDesg_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[FacturaDesg] CHECK CONSTRAINT [FK_FacturaDesg_Producto]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Desgroce de facturas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturaDesg'
GO
