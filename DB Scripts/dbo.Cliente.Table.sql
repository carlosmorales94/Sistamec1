USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 8/6/2018 11:22:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Telefono] [int] NULL,
	[Movil] [int] NOT NULL,
	[Correo] [nvarchar](100) NOT NULL,
	[Comentario] [nvarchar](50) NULL,
	[Cedula] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
