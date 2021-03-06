USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 8/6/2018 11:22:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[NumFac] [int] NOT NULL,
	[IdCita] [int] NOT NULL,
	[Km] [int] NOT NULL,
	[Total] [float] NOT NULL,
	[Comentario] [nvarchar](80) NULL,
	[IVA] [float] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [time](0) NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[NumFac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [PK_NumFac_Factura] UNIQUE NONCLUSTERED 
(
	[NumFac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Factura] ADD  CONSTRAINT [DF_Factura_Fecha]  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Factura] ADD  CONSTRAINT [DF_Factura_Hora]  DEFAULT (getdate()) FOR [Hora]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Cita] FOREIGN KEY([IdCita])
REFERENCES [dbo].[Cita] ([IdCita])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Cita]
GO
