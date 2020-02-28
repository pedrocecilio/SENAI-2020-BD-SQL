-- Cria o banco de dados
CREATE DATABASE Peoples;

-- Define qual banco de dados será utilizado
USE Peoples;

-- Cria a tabela Funcionarios
CREATE TABLE Funcionarios 
(
	IdFuncionario	INT IDENTITY PRIMARY KEY
	,Nome			VARCHAR(200) NOT NULL
	,Sobrenome		VARCHAR(255)
);
GO

CREATE TABLE TipoUsuario (
	IdTipoUsuario INT PRIMARY KEY IDENTITY
	,TituloTipoUsuario VARCHAR (255) NOT NULL UNIQUE
);
GO

CREATE TABLE Usuario (
	IdUsuario INT PRIMARY KEY IDENTITY
	,Nome VARCHAR (255) NOT NULL
	,Email VARCHAR (255) NOT NULL UNIQUE
	,Senha VARCHAR (255) NOT NULL
	,IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario)
);
GO

-- Adiciona a coluna DataNascimento na tabela Funcionarios
ALTER TABLE Funcionarios
ADD DataNascimento DATE