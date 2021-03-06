USE [TallerHernandez]
GO
/****** Object:  StoredProcedure [dbo].[add_tarea]    Script Date: 8/6/2018 11:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[add_tarea] (@idCita int, @idMecanico int, @descripcion nvarchar(50),@fechaInicio date, @fechaFinal date,@status char(10))
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
GO
