USE [TallerHernandez]
GO
/****** Object:  StoredProcedure [dbo].[add_desglose_factura]    Script Date: 8/6/2018 11:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[add_desglose_factura] (@numFac int,@idProducto nvarchar(20), @cantidad int, @precio float, @descuento float)
as
begin
	if exists(Select * from Producto where IdProducto = @idProducto)
		begin
			if exists(select * from Factura where NumFac = @numFac)
				begin
					insert into FacturaDesg(NumFac,IdProducto,Cantidad,Precio,Descuento)
					values (@numFac,@idProducto,@cantidad,@precio,@descuento)
				end
			else
				begin
				select 'La Factura no existe' + @numFac
				end
		end
		else
			select 'El Producto no existe' + @idProducto
end
GO
