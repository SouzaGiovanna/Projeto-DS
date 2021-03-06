CREATE DATABASE dbCadVisu
GO
USE dbCadVisu

CREATE TABLE tbClient (
	idClient INT PRIMARY KEY IDENTITY(1, 1)
	, nameClient VARCHAR(100) NOT NULL
	, cpfClient VARCHAR(14) NOT NULL
	, rgClient VARCHAR(12) NOT NULL
	, addressClient VARCHAR(200) NOT NULL
)

CREATE TABLE tbSaller (
	idSaller INT PRIMARY KEY IDENTITY(1, 1)
	, nameSaller VARCHAR(100) NOT NULL
	, cpfSaller VARCHAR(14) NOT NULL
)

CREATE TABLE tbProduct (
	idProduct INT PRIMARY KEY IDENTITY(1, 1)
	, descriptionProduct VARCHAR(100) NOT NULL
	, valueProduct SMALLMONEY NOT NULL
)
