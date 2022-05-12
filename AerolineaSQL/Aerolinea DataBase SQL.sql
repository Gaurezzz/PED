USE master
GO
DROP DATABASE Aerolinea
GO
CREATE DATABASE Aerolinea
GO
USE Aerolinea

CREATE TABLE Vertices(
Fila int UNIQUE NOT NULL,
Nombre varchar(50) NOT NULL PRIMARY KEY,
posX int NOT NULL,
posY int NOT NULL,
)
GO

CREATE TABLE Aristas(
Fila int UNIQUE NOT NULL,
Nombre varchar(50) NOT NULL PRIMARY KEY,
Peso int NOT NULL,
VerticeAntecesor varchar(100) NOT NULL,
VerticeAdyacente varchar(100) NOT NULL
)
GO

CREATE PROCEDURE EliminarNodos AS
	DROP TABLE Vertices
	DROP TABLE Aristas

	CREATE TABLE Aristas(
	Fila int UNIQUE NOT NULL,
	Nombre varchar(50) NOT NULL PRIMARY KEY,
	Peso int NOT NULL,
	VerticeAntecesor varchar(100) NOT NULL,
	VerticeAdyacente varchar(100) NOT NULL)

	CREATE TABLE Vertices(
	Fila int UNIQUE NOT NULL,
	Nombre varchar(50) NOT NULL PRIMARY KEY,
	posX int NOT NULL,
	posY int NOT NULL,)
GO