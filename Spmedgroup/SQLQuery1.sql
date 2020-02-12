CREATE DATABASE SPMedicalGroup

Use SPMedicalGroup;

CREATE TABLE Clinica (
	IdClinica INT PRIMARY KEY IDENTITY,
	NomeClinica Varchar (255),
	CNPJ Varchar (255),
	RazaoSocial Varchar(255),
	Endereço Varchar(255)
);

CREATE TABLE Especialidades(
	IdEspecialidade INT PRIMARY KEY IDENTITY,
	Especializacao Varchar (255)
);

CREATE TABLE Situacao(
	IdSituacao INT PRIMARY KEY IDENTITY,
	TituloSituacao Varchar (255)
);

CREATE TABLE Usuarios(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Nome Varchar (255),
	Administrador Bit default (1),
	Email Varchar (255),
	DataNascimento Date,
	Telefone Varchar (255),
	RG Varchar (255),
	CPF Varchar (255),
	Endereco Varchar (255),
);


/*CREATE TABLE Medicos(
	IdMedico INT PRIMARY KEY IDENTITY,
	CRM Varchar (255),
	Nome Varchar (255),
	Email Varchar (255),
	IdEspecialidade INT FOREIGN KEY REFERENCES Especialidades (IdEspecialidade),
	IdClinica INT FOREIGN KEY REFERENCES Clinica (IdClinica)
);*/
CREATE TABLE dbo.Medicos
	(
	idMedico int NOT NULL,
	crm nchar(10) NOT NULL,
	email nchar(60) NOT NULL,
	nome nchar(100) NOT NULL,
	idEspecialidade int NOT NULL,
	idClinica int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Medicos ADD CONSTRAINT
	PK_Medicos PRIMARY KEY CLUSTERED 
	(
	idMedico
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Medicos ADD CONSTRAINT
	FK_Medicos_Especialidades FOREIGN KEY
	(
	idEspecialidade
	) REFERENCES dbo.Especialidades
	(
	IdEspecialidades
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Medicos ADD CONSTRAINT
	FK_Medicos_Clinica FOREIGN KEY
	(
	idClinica
	) REFERENCES dbo.Clinica
	(
	IdClinica
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

CREATE TABLE Consultas(
	IdConsulta INT PRIMARY KEY IDENTITY,
	DataConsulta DateTime2,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario (IdUsuario),
	IdMedico INT FOREIGN KEY REFERENCES Medicos (IdMedico),
	IdSituacao INT FOREIGN KEY REFERENCES Situacao (IdSituacao)
);

select * from Clinica
select *from Especialidades
select*from Situacao
select*from Usuarios