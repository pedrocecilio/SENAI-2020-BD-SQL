Use LOCADORA

INSERT INTO Empresa (Nome)
VALUES	('Localiza'),
		('Unidas');

INSERT INTO Cliente (Nome,CPF)
VALUES	('Fernando', '23324442444'),
		('Helena', '32434554333');

INSERT INTO Marca (Nome)
VALUES	('Ford'),
		('GM'),
		('Fiat');

INSERT INTO Modelo (Nome,IdMarca)
VALUES	('Ford', '1'),
		('GM', '2'),
		('Fiat', '3');


INSERT INTO Veiculo (IdModelo, Placa, IdEmpresa)
VALUES	(1,'HEL1805',1),
		(2,'FER1010',1),
		(3,'POR1978',2),
		(1,'LEM9876',2);

INSERT INTO Aluguel (IdCliente, IdVeiculo, DataInicio, DataFim)
VALUES	(1, 1,'19-01-2019', '20-01-2019' ),
		(1, 2, '20/01/2019', '21/01/2019'),
		(2, 3, '21/01/2019', '21/01/2019'),
		(2,2, '22/01/2019', '22/01/2019');



