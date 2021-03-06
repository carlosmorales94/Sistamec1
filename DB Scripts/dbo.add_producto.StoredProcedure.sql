USE [TallerHernandez]
GO
/****** Object:  StoredProcedure [dbo].[add_producto]    Script Date: 8/6/2018 11:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[add_producto] (@idproducto nvarchar(20),@stock int, @precio int, @descripcion nvarchar(100), @idprovedor int)
as
begin
	if exists(Select * from Proveedores where IdProveedor = @idprovedor)
		begin
			insert into Producto(IdProducto,stock,precio,descripcion,idProveedor)
			values (@idproducto,@stock,@precio,@descripcion,@idprovedor)
		end
	else
		select 'No existe el proveedor' + @idprovedor 
end 
GO
