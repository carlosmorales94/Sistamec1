USE [TallerHernandez]
GO
/****** Object:  StoredProcedure [dbo].[add_cliente]    Script Date: 8/6/2018 11:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[add_cliente] (@cedula nvarchar(50),@nombre nvarchar(50),@apellido nvarchar(50), @telefono int, @correo nvarchar(100), @comentario nvarchar(50))
as
begin try
	insert into Cliente(Cedula,Nombre,Apellido,Movil,Correo,Comentario)
	values (@cedula,@nombre,@apellido,@telefono,@correo,@comentario);
end try
begin catch
	IF @@ERROR = 2627
-- check constraint violation   
	Select 'El cliente ya existe'
end catch
GO
