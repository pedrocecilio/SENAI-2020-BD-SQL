USE Gufi_Manha;

INSERT INTO TipoUsuario (TituloTipoUsuario)
VALUES	('Administrador'),
		('Comum');
GO

INSERT INTO TipoEvento (TituloTipoEvento)
VALUES	('C#'),
		('React'),
		('SQL');
GO

INSERT INTO Instituicao (CNPJ, NomeFantasia, Endereco)
VALUES	(11111111111111, 'Escola SENAI de Informatica', 'Alameda Barão de Limeira,538');
GO

INSERT INTO Presenca (IdUsuario, IdEvento, Situacao)
VALUES	(2, 2, 'Confirmada'),
		(2, 3, 'Não Confirmada'),
		(3, 1, 'Confirmada');
GO

INSERT INTO Usuario (IdTipoUsuario, Nome, Email, Senha, DataCadastro, Genero)
VALUES	(1, 'Administrador', 'adm@adm.com', 'adm123', '06/02/2020', 'Não Informado'),
		(2, 'Carol', 'carol.@email.com', 'carol123', '06/02/2020', 'Feminino'),
		(2, 'Saulo', 'saulo.@email.com', 'Saulo123', '06/02/2020', 'Masculino');
GO

INSERT INTO Evento (IdTipoEvento, IdInstituicao, NomeEvento, AcessoLivre, DataEvento, Descricao)
VALUES	(1, 1, 'Orientação a objetos', 1, '07/02/2020', 'Conceitos sobre os pilares da progrmação orientada a objetos'),
		(2, 1, 'Ciclo de vida', 0, '08/02/2020', 'Como utilizar os ciclos de vida com a biblioteca ReactUs'),
		(2, 1, 'Introdução SQL', 1, '09/02/2020', 'Comando básicos utilizando SQL Server');
GO

 Select * From TipoUsuario;
 Select * From TipoEvento;
 Select * From Instituicao;
  Select * From Presenca;
 Select * From Usuario;
 Select * From Evento;