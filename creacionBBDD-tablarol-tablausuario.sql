-- creamos la base de datos
CREATE DATABASE JoyeriaALBADB;
GO

USE JoyeriaALBADB;
GO

-- creamos la tabla roles
CREATE TABLE Roles (
    IdRol INT IDENTITY(1,1), -- identity aumenta de 1 en 1
    NombreRol VARCHAR(50) NOT NULL,
    --restriccion de clave primaria para IdRol
    CONSTRAINT PK_IdRol PRIMARY KEY (IdRol)
);

-- creamos la tabla usuarios
CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1),
    Usuario VARCHAR(50) NOT NULL,
    NombreUsuario VARCHAR(100),
    ApellidoUsuario VARCHAR(100),
    Contrasena VARCHAR(100) NOT NULL,
    IdRol INT NOT NULL,
    Activo BIT DEFAULT 1, -- un booleano (1 = Activo, 0 = Desactivado)
    
    -- restricción de clave primaria
    CONSTRAINT PK_IdUsuario PRIMARY KEY (IdUsuario),
    -- restricción de unicidad para usuario
    CONSTRAINT UQ_Usuario UNIQUE (Usuario),
    -- Esta línea conecta al usuario con la tabla Roles
    CONSTRAINT FK_IdRol FOREIGN KEY (IdRol) REFERENCES Roles(IdRol) 
);

-- insertamos los roles definidos
INSERT INTO Roles (NombreRol) VALUES ('Admin'), ('Vendedor'), ('Logistica');