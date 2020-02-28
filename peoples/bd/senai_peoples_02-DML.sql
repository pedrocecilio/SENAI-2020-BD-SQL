-- Define o banco de dados que será utilizado
USE Peoples;

-- Insere dois funcionários
INSERT INTO Funcionarios (Nome, Sobrenome) 
VALUES	('Catarina', 'Strada')
		,('Tadeu', 'Vitelli');

INSERT INTO TipoUsuario (TituloTipoUsuario)
VALUES					('Administrador')
						,('Comum');
GO

INSERT INTO Usuario	(IdTipousuario, Nome, Email, Senha)
VALUES				(1,'Administrador','adm@adm.com','123')
					,(2,'Pedro','pedro@email.com','123')
					,(2,'Cecilio','cecilio@email.com','123');
GO
