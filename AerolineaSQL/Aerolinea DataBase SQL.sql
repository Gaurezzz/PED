USE master
GO
DROP DATABASE if EXISTS Aerolinea
GO
CREATE DATABASE Aerolinea
GO
USE Aerolinea

CREATE TABLE Clientes(
DUI varchar(10) NOT NULL PRIMARY KEY,
Nombre varchar(150) NOT NULL,
Apellido varchar(150) NOT NULL,
EDAD int NOT NULL)
