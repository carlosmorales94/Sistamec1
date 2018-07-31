USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 7/31/2018 3:19:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[IdCita] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [nvarchar](50) NOT NULL,
	[Placa] [nvarchar](10) NULL,
	[Problema] [nvarchar](300) NOT NULL,
	[FechaIngreso] [datetime] NULL,
	[Nota] [nvarchar](200) NULL,
	[Bin] [int] NOT NULL,
	[Km] [int] NOT NULL,
	[RevisionIntervalos] [nvarchar](50) NULL,
	[MantenimientoPrevio] [nvarchar](50) NULL,
	[Danos] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[FechaCita] [datetime] NOT NULL,
	[Marca] [nvarchar](50) NULL,
	[Modelo] [nvarchar](50) NULL,
	[Anno] [int] NULL,
	[Color] [nvarchar](50) NULL,
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
