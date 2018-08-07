create procedure add_cliente (@cedula nvarchar(50),@nombre nvarchar(50),@apellido nvarchar(50), @telefono int, @correo nvarchar(100), @comentario nvarchar(50))
as
begin try
	insert into Cliente(Cedula,Nombre,Apellido,Movil,Correo,Comentario)
	values (@cedula,@nombre,@apellido,@telefono,@correo,@comentario);
end try
begin catch
	IF @@ERROR = 2627
	-- Revisa si el cliente ya existe y devuelve un campo en una tabla 'dual'   
	Select 'El cliente ya existe'
end catch

create procedure add_factura (@idCita int,@Km int, @comentario nvarchar(50), @Iva float, @Fecha date, @Hora time(0))
as
begin
	declare @total int;
	if exists(Select IdCita from cita where IdCita = @idCita) 
		begin
			select @total = 0; --el total esta en 0 porque se va a modificar despues con un trigger
			insert into factura(IdCita,km,total,Comentario,iva,fecha,hora)
			values (@idCita,@Km,@total,@comentario,@Iva,@Fecha,@Hora);
		end
	else
		select 'La cita no existe' + @idCita;	
end

create procedure add_desglose_factura (@numFac int,@idProducto nvarchar(20), @cantidad int, @precio float, @descuento float)
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

create procedure add_producto (@idproducto nvarchar(20),@stock int, @precio int, @descripcion nvarchar(100), @idprovedor int)
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

create procedure add_mecanico (@nombre nvarchar(50),@apellido nvarchar(50))
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

create procedure add_tarea (@idCita int, @idMecanico int, @descripcion nvarchar(50),@fechaInicio date, @fechaFinal date,@status char(10))
as
begin
	if exists(select * from cita where IdCita = @idCita)
		begin
		if exists(select * from mecanico where idMecanico = @idMecanico)
			begin
				insert into tareas(idCita,IdMecanico,Descripcion,FechaInicio,FechaFinal,Status)
				values (@idCita,@idMecanico,@descripcion,@fechaInicio,@fechaFinal,@status)
			end
		else
			begin
				select 'El mecanico'+@idMecanico+' no existe'
			end
		end
	else
		begin
			select 'La cita no existe'
		end
end

create trigger TRG_stock1 on FacturaDesg --trigger para ir eliminando los productos del stock segun se van vendiendo
after insert, update
as
begin
	declare @oldstock int
	declare @oldcant int
	declare @newcant int
	select @oldstock = stock from Producto where IdProducto = (select IdProducto from inserted)
	select @oldcant = Cantidad from deleted
	select @newcant = Cantidad from inserted

	if (@oldcant > @newcant)
	begin
		update Producto
		set Stock = (@oldstock+(@oldcant-@newcant))
		where IdProducto = (select idproducto from inserted);
	end
	else if (@oldcant < @newcant)
	begin
		update Producto
		set Stock = (@oldstock+(@oldcant-@newcant))
		where IdProducto = (select idproducto from inserted);
	end
	else
		update Producto
		set Stock = (@oldstock-@newcant)
		where IdProducto = (select idproducto from inserted);
end