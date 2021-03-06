USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 8/6/2018 11:22:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[IdCita] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [nvarchar](50) NOT NULL,
	[Placa] [nvarchar](10) NULL,
	[Problema] [nvarchar](300) NOT NULL,
	[FechaIngreso] [datetime] NOT NULL,
	[Nota] [nvarchar](200) NOT NULL,
	[Bin] [int] NOT NULL,
	[Km] [int] NOT NULL,
	[RevisionIntervalos] [nvarchar](50) NOT NULL,
	[MantenimientoPrevio] [nvarchar](50) NOT NULL,
	[Danos] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[FechaCita] [datetime] NULL,
	[Marca] [nvarchar](50) NULL,
	[Modelo] [nvarchar](50) NULL,
	[Anno] [int] NULL,
	[Color] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cita] PRIMARY KEY CLUSTERED 
(
	[IdCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Cliente] FOREIGN KEY([Cedula])
REFERENCES [dbo].[Cliente] ([Cedula])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Cliente]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Usuario] FOREIGN KEY([Username])
REFERENCES [dbo].[Usuario] ([Username])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Usuario]
GO
