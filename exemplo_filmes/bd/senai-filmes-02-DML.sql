USE Filmes_manha;

INSERT INTO Generos	(Nome)
VALUES				('A��o')
					,('Drama');
					
INSERT INTO Filmes	(Titulo, IdGenero)
VALUES				('A vida � bela', 2)
					,('Rambo', 1);


UPDATE Generos
SET Nome = 'Suspense'
WHERE IdGenero = 1 

SELECT * FROM Generos
SELECT * FROM Filmes

DELETE FROM Generos 
WHERE IdGenero = 2 ;