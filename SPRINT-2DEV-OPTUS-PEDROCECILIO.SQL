CREATE DATABASE OPTUSMANHA

USE OPTUSMANHA

CREATE TABLE TiposUsuario (
IdTipooUsuario Int Primary Key Identity,
Titulo Varchar (200)
);

CREATE TABLE Artista(
IdArtista Int Primary Key Identity,
Nome Varchar (200)
);

CREATE TABLE Estilos(
IdEstilos Int Primary Key Identity,
Nome Varchar (200),
);

CREATE TABLE Usuarios(
IdUsuario Int Primary Key Identity,
Nome Varchar (200),
IdTipoUsuario Int Foreign Key References TiposUsuario (IdTipooUsuario),
);

CREATE TABLE Albuns(
IdAlbum Int Primary Key Identity,
Nome Varchar (200),
DataLancamento Date,
QtdMinutos Int,
Visualizacao Int,
IdArtista Int Foreign Key References Artista (IdArtista),
IdEstilo Int Foreign Key References Estilos (IdEstilos),
);
Select * From Albuns

SELECT * FROM Estilos;
SELECT * FROM Artista;
SELECT * FROM Albuns;
SELECT * FROM TiposUsuario;
SELECT * FROM Usuarios;  

INSERT INTO Estilos (Nome)
VALUES ('Trap'),('Rap'),('Sertanjo'), ('Rock'), ('Pagode');

INSERT INTO Artista (Nome)
VALUES ('Matue'),('Kendrick Lamar'),('U2'), ('Gusttavo Lima'), ('Eminem'), ('Vou Pro Sereno');

INSERT INTO Albuns (Nome, DataLancamento, Visualizacao, QtdMinutos, IdArtista, IdEstilo)
VALUES ('De Alta','01/10/2019', 350000, 244, 1, 1),
	   ('DAMN','23/04/2017',9500000, 360, 2, 1),
	   ('U218 Singles','12/05/2006',8500000, 420, 3, 4),
	   ('O EMBAIXADOR','13/06/2018',3500000, 260, 4, 3),
	   ('Music To Be Murdered By','12/05/2020',8500000, 560, 5, 2),
	   ('A Força do Nosso Som Continua ','12/05/2019',2500000, 520, 6, 5);

Insert Into TiposUsuario

UPDATE Artista
Set Nome = 'Tue'
WHERE IdArtista = 1

UPDATE Albuns
Set Visualizacao = 4500000
WHERE IdArtista = 1;



CREATE VIEW VWalbuns AS
SELECT IdAlbum AS CodigoAlbum,
	Nome,
	DataLancamento,
	QtdMinutos AS Duracao,
	Visualizacao
FROM Albuns 

SELECT * FROM Albuns;
SELECT * FROM VWalbuns;


	   

