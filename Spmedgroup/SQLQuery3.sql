USE SPMedicalGroup
GO

INSERT INTO [dbo].[Usuario]
           ([Nome]
           ,[Administrador]
           ,[Email]
           ,[DataNascimento]
           ,[Telefone]
           ,[RG]
           ,[CPF]
           ,[Endereco])
     VALUES
			--Já cadastrada('Ligia', 0, 'ligia@gmail.com', '13/10/1983', '11-34567654', '43522543-5', '94839859000', 'Rua Estado de Israel 240, São Paulo, Estado de São Paulo, 04022-000'),
			('Alexandre', 0, 'alexandre@gmail.com', '23/7/2001', '11 98765-6543', '32654345-7', '73556944057', 'Av. Paulista, 1578 - Bela Vista, São Paulo - SP, 01310-200'),
			('Fernando', 0, 'fernando@gmail.com', '10/10/1978', '11 97208-4453', '54636525-3', '16839338002', 'Av. Ibirapuera - Indianópolis, 2927, São Paulo - SP, 04029-200'),
			('Henrique', 0, 'henrique@gmail.com', '13/10/1985', '11 3456-6543', '54366362-5', '14332654765', 'R. Vitória, 120 - Vila Sao Jorge, Barueri - SP, 06402-030'),
			('João', 0, 'joao@hotmail.com', '27/8/1975','11 7656-6377', 't32544444-1', '91305348010', 'R. Ver. Geraldo de Camargo, 66 - Santa Luzia, Ribeirão Pires - SP, 09405-380'),
			('Bruno', 0, 'bruno@gmail.com', '21/3/1972', '11 95436-8769', '54566266-7', '79799299004', 'Alameda dos Arapanés, 945 - Indianópolis, São Paulo - SP, 04524-001')
		-- Necessário excluir essa cliente	('Mariana', 0, 'mariana@outlook.com', '5/3/2018', '54566266-8', '13771913039', 'R Sao Antonio, 232 - Vila Universal, Barueri - SP, 06407-140')
GO


