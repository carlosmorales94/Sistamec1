USE [TallerHernandez]
GO
/****** Object:  Table [dbo].[PermisosXUsuario]    Script Date: 8/6/2018 11:22:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermisosXUsuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPermiso] [int] NOT NULL,
	[AccesoPermiso] [bit] NOT NULL,
	[Username] [nvarchar](50) NULL,
 CONSTRAINT [PK_PermisosXUsuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PermisosXUsuario] ADD  CONSTRAINT [DF_PermisosXUsuario_AccesoPermiso]  DEFAULT ((0)) FOR [AccesoPermiso]
GO
ALTER TABLE [dbo].[PermisosXUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PermisosXUsuario_PermisosXUsuario] FOREIGN KEY([IdPermiso])
REFERENCES [dbo].[Permisos] ([IdPermiso])
GO
ALTER TABLE [dbo].[PermisosXUsuario] CHECK CONSTRAINT [FK_PermisosXUsuario_PermisosXUsuario]
GO
ALTER TABLE [dbo].[PermisosXUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PermisosXUsuario_Usuario] FOREIGN KEY([Username])
REFERENCES [dbo].[Usuario] ([Username])
GO
ALTER TABLE [dbo].[PermisosXUsuario] CHECK CONSTRAINT [FK_PermisosXUsuario_Usuario]
GO
