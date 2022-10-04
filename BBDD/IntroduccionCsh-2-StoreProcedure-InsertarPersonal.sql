CREATE PROCEDURE InsertarPersonal
@Nombre varchar(max),
@identificacion varchar(max),
@pais varchar(max),
@id_cargo int,
@sueldoPorHora numeric(18, 2)
AS
DECLARE @estado varchar(max)
DECLARE @codigo varchar(max)
DECLARE @id_persona int

SET @estado = 'ACTIVO'
SET @codigo = '-'

IF EXISTS (SELECT identificacion FROM Personal WHERE identificacion = @identificacion)
RAISERROR('Ya existe un registro con esta identificación',16,1)
ELSE
INSERT INTO Personal VALUES(@Nombre, @identificacion, @pais, @id_cargo, @sueldoPorHora, @estado, @codigo)
SELECT @id_persona = SCOPE_IDENTITY()
UPDATE Personal SET codigo = @id_persona