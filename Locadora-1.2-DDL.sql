CREATE DATABASE LOCADORA

USE LOCADORA

CREATE TABLE Empresa (
IdEmpresa Int Primary Key Identity,
Nome Varchar (200),
);

CREATE TABLE Cliente (
IdCliente Int Primary Key Identity,
Nome Varchar (200),
CPF Varchar (200),
);

CREATE TABLE Marca (
IdMarca Int Primary Key Identity,
Nome Varchar (200),
);

CREATE TABLE Modelo (
IdModelo Int Primary Key Identity,
Nome Varchar (200),
IdMarca Int Foreign Key References Marca (IdMarca)
);

CREATE TABLE Veiculo (
IdVeiculo Int Primary Key Identity,
Placa Varchar (200),
IdModelo Int Foreign Key References Modelo (IdModelo),
IdEmpresa Int Foreign Key References Empresa (IdEmpresa),
);

CREATE TABLE Aluguel (
IdAluguel Int Primary Key Identity,
DataInicio Date,
DataFim Date,
IdCliente Int Foreign Key References Cliente (IdCliente),
IdVeiculo Int Foreign Key References Veiculo (IdVeiculo),
);



