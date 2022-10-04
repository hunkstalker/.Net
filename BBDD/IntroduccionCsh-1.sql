DROP DATABASE UsuariosDB
CREATE DATABASE UsuariosDB
USE UsuariosDB
GO

CREATE TABLE Usuarios (
	ID INT PRIMARY KEY NOT NULL,
	[user] VARCHAR(MAX) NULL,
	pass VARCHAR(MAX) NULL,
	icon IMAGE NULL,
	[status] VARCHAR(MAX) NULL
)
GO

CREATE PROCEDURE insert_users (@user VARCHAR(MAX), @pass VARCHAR(MAX), @icon IMAGE, @status VARCHAR(MAX))
AS
IF EXISTS (SELECT [user] FROM Usuarios WHERE [user] = @user)
RAISERROR('Usuario ya registrado',16,1)
ELSE
INSERT INTO Usuarios
VALUES(@user, @pass, @icon, @status)
GO

CREATE PROC show_users
AS	
SELECT * FROM Usuarios
GO

CREATE PROCEDURE edit_users (@ID INT, @user AS VARCHAR(MAX), @pass VARCHAR(MAX), @icon IMAGE, @status VARCHAR(MAX))
AS
IF EXISTS (SELECT [user] FROM Usuarios WHERE [user] = @user AND ID <> @ID)
RAISERROR ('Usuario en uso, usa otro nombre de usuario por favor',16,1)
ELSE
UPDATE Usuarios SET [user] = @user, pass = @pass, icon = @icon, [status] = @status WHERE ID = @ID
GO

CREATE PROCEDURE delete_users @ID INT
AS
DELETE FROM Usuarios WHERE ID = @ID
GO

CREATE PROCEDURE search_users @search VARCHAR(50)
AS
SELECT * FROM Usuarios
WHERE [user] + pass LIKE '%' + @search + '%'
GO
