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

CREATE TABLE Aristas(
Fila int UNIQUE NOT NULL,
Nombre varchar(50) NOT NULL PRIMARY KEY,
Peso int NOT NULL,
VerticeAntecesor varchar(100) NOT NULL,
VerticeAdyacente varchar(100) NOT NULL
)