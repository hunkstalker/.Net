CREATE PROCEDURE EditarPersonal
@id_persona int,
@nombre varchar(max),
@identificacion varchar(max),
@pais varchar(max),
@id_cargo varchar(max),
@sueldoPorHora numeric(18,2)
AS
IF EXISTS (SELECT identificacion FROM Personal WHERE identificacion = @identificacion AND id_persona <> @id_persona)
RAISERROR('ya existe un registro con esta identificación', 16, 1)
ELSE
UPDATE Personal SET nombre = @nombre, identificacion = @identificacion, pais = @pais, id_cargo = @id_cargo, sueldoPorHora = @sueldoPorHora
WHERE id_persona = @id_persona