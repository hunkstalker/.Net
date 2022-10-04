CREATE PROCEDURE mostrarPersonal
@desde int,
@hasta int
AS
SET NOCOUNT ON;
SELECT id_persona, nombre, identificacion, sueldoPorHora, Cargo.cargo, Personal.id_Cargo, estado, codigo,
ROW_NUMBER() OVER(ORDER BY id_persona) 'Número de filas'
FROM Personal
INNER JOIN Cargo ON Cargo.id_cargo = Personal.id_cargo