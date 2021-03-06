USE [TallerHernandez]
GO
/****** Object:  StoredProcedure [dbo].[add_mecanico]    Script Date: 8/6/2018 11:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[add_mecanico] (@nombre nvarchar(50),@apellido nvarchar(50))
as
begin try
	insert into Mecanico(Nombre,Apellido)
	values(@nombre,@apellido)
end try
begin catch
	IF @@ERROR = 2627
	-- Revisa si el mecanico ya existe y devuelve un campo en una tabla 'dual'   
	Select 'El mecanico ya existe'
end catch
GO
