USE [TallerHernandez]
GO
/****** Object:  StoredProcedure [dbo].[add_factura]    Script Date: 8/6/2018 11:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[add_factura] (@idCita int,@Km int, @comentario nvarchar(50), @Iva float, @Fecha date, @Hora time(0))
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
GO
