USE Gufi_Manha

SELECT Nome, Email,Senha,DataCadastro,Genero,TituloTipoUsuario FROM Usuario
INNER JOIN TipoUsuario ON TipoUsuario.IdTipoUsuario = Usuario.IdTipoUsuario;
GO

SELECT CNPJ, NomeFantasia, Endereco FROM Instituicao;
GO

SELECT TituloTipoEvento FROM TipoEvento;
GO

SELECT NomeEvento, TituloTipoEvento, DataEvento, Descricao, AcessoLivre,CNPJ, NomeFantasia, Endereco, TituloTipoEvento FROM Evento
INNER JOIN Instituicao ON Evento.IdInstituicao = Instituicao.IdInstituicao
INNER JOIN TipoEvento ON Evento.IdTipoEvento = TipoEvento.IdTipoEvento;
GO

SELECT NomeEvento, DataEvento, Descricao, AcessoLivre,CNPJ, NomeFantasia, Endereco, TituloTipoEvento FROM Evento
INNER JOIN Instituicao ON Evento.IdInstituicao = Instituicao.IdInstituicao
INNER JOIN TipoEvento ON Evento.IdTipoEvento = TipoEvento.IdTipoEvento 
WHERE AcessoLivre = 1;

SELECT NomeEvento, TituloTipoEvento, DataEvento, Situacao, AcessoLivre, Descricao, CNPJ, NomeFantasia, Endereco, Nome, Email,Senha From Evento
INNER JOIN Presenca ON Presenca.IdEvento = Evento.IdEvento
INNER JOIN Usuario ON Usuario.IdUsuario = Presenca.IdUsuario
INNER JOIN Instituicao ON Evento.IdInstituicao = Instituicao.IdInstituicao
INNER JOIN TipoEvento ON Evento.IdEvento =TipoEvento.IdTipoEvento
WHERE Nome = 'Carol';


SELECT NomeEvento, TituloTipoEvento, DataEvento, Situacao, AcessoLivre, Descricao, CNPJ, NomeFantasia, Endereco, Nome, Email,Senha From Evento
INNER JOIN Presenca ON Presenca.IdEvento = Evento.IdEvento
INNER JOIN Usuario ON Usuario.IdUsuario = Presenca.IdUsuario
INNER JOIN Instituicao ON Evento.IdInstituicao = Instituicao.IdInstituicao
INNER JOIN TipoEvento ON Evento.IdEvento =TipoEvento.IdTipoEvento
WHERE Nome = 'Carol' AND Situacao = 'Confirmada';





Select * From Evento;
Select * From Usuario;
Select * From Presenca;
Select * From Instituicao;
SELECT * FROM TipoEvento;
