USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[Tareas]    Script Date: 8/6/2018 11:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tareas](
	[Idtask] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[IdMecanico] [int] NULL,
	[idCita] [int] NULL,
	[FechaInicio] [date] NULL,
	[FechaFinal] [date] NULL,
	[Status] [char](10) NULL,
 CONSTRAINT [PK_Tareas_1] PRIMARY KEY CLUSTERED 
(
	[Idtask] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tareas] ADD  CONSTRAINT [DF_Tareas_Status]  DEFAULT ('a') FOR [Status]
GO
ALTER TABLE [dbo].[Tareas]  WITH CHECK ADD  CONSTRAINT [FK_Tareas_Cita] FOREIGN KEY([idCita])
REFERENCES [dbo].[Cita] ([IdCita])
GO
ALTER TABLE [dbo].[Tareas] CHECK CONSTRAINT [FK_Tareas_Cita]
GO
ALTER TABLE [dbo].[Tareas]  WITH CHECK ADD  CONSTRAINT [FK_Tareas_Mecanico] FOREIGN KEY([IdMecanico])
REFERENCES [dbo].[Mecanico] ([idMecanico])
GO
ALTER TABLE [dbo].[Tareas] CHECK CONSTRAINT [FK_Tareas_Mecanico]
GO
