--CRIAR BANCO DE DADOS
CREATE DATABASE RoteiroMusical;

USE RoteiroMusical;

-- DDL Linguagem de DEFINICAO de DADOS
CREATE TABLE EstilosMusicais(
	IdEstilo INT PRIMARY KEY IDENTITY,
	Nome	 VARCHAR(200)
);

CREATE TABLE Artistas (
	IdArtista	INT PRIMARY KEY IDENTITY,
	NomeArtista VARCHAR(200),
	IdEstilo INT FOREIGN KEY REFERENCES EstilosMusicais (IdEstilo)
	);

ALTER TABLE EstilosMusicais
ADD Descricao Varchar(200);

--DML LINGUAGEM DE MANIPULAÇÃO DE DADOS

INSERT INTO EstilosMusicais (Nome, Descricao)
Values('PAGODE', 'MUSICA BRASILEIRA'),
	('TRAP', 'MUSICA GRINGA'),
	('AXE', 'MUSICA DO BRASILZÃO');

INSERT INTO Artistas (NomeArtista, IdEstilo)
VALUES	('THIAGUINHO', 1),
		('MATUE', 2);

SELECT * FROM EstilosMusicais;

--UPDATE ALTERAR DADOS DE DENTRO DAS TABELAS

UPDATE EstilosMusicais
SET Nome = 'Sertanejo'
WHERE IdEstilo = 4;

--DELETE DADOS DA TABELA

DELETE FROM EstilosMusicais
WHERE IdEstilo = 5;

DELETE FROM EstilosMusicais
WHERE IdEstilo = 6;

UPDATE EstilosMusicais
SET Nome = 'SERTANEJO'
WHERE IdEstilo = 4;

UPDATE EstilosMusicais
SET Descricao = 'MUSICA RAIZ'
WHERE IdEstilo = 4;


TRUNCATE TABLE LIVROS;


