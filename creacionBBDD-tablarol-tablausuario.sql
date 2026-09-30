-- creamos la base de datos
CREATE DATABASE JoyeriaALBADB;
GO

USE JoyeriaALBADB;
GO

-- creamos la tabla roles
CREATE TABLE Roles (
    IdRol INT IDENTITY(1,1), -- identity aumenta de 1 en 1
    NombreRol VARCHAR(50) NOT NULL,
    -- restriccion de clave primaria para IdRol
    CONSTRAINT PK_IdRol PRIMARY KEY (IdRol)
);
GO

-- creamos la tabla usuarios (el campo DNI se unificó en la creación)
CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1),
    Usuario VARCHAR(50) NOT NULL,
    NombreUsuario VARCHAR(100),
    ApellidoUsuario VARCHAR(100),
    Contrasena VARCHAR(100) NOT NULL,
    Foto_Perfil VARCHAR(255),
    DNI VARCHAR(10) NOT NULL, 
    IdRol INT NOT NULL,
    Activo BIT DEFAULT 1, -- un booleano (1 = Activo, 0 = Desactivado)
    
    -- restricciones
    CONSTRAINT PK_IdUsuario PRIMARY KEY (IdUsuario),
    CONSTRAINT UQ_Usuario UNIQUE (Usuario),
    CONSTRAINT UQ_Usuario_DNI UNIQUE (DNI),
    CONSTRAINT FK_IdRol FOREIGN KEY (IdRol) REFERENCES Roles(IdRol) 
);
GO

-- insertamos los roles definidos
INSERT INTO Roles (NombreRol) 
VALUES 
('Administrador'), 
('Gerente'), 
('Vendedor'), 
('Logística');
GO

-- insertamos los usuarios genéricos para cada rol
-- El IdRol corresponde al orden de inserción: 1=Admin, 2=Gerente, 3=Vendedor, 4=Logística
INSERT INTO Usuarios (Usuario, NombreUsuario, ApellidoUsuario, Contrasena, DNI, IdRol)
VALUES 
('admin', 'Usuario', 'Administrador', '1234', '11111111', 1),
('gerente', 'Usuario', 'Gerente', '1234', '22222222', 2),
('vendedor', 'Usuario', 'Vendedor', '1234', '33333333', 3),
('logistica', 'Usuario', 'Logística', '1234', '44444444', 4);
GO

-- creamos la tabla genero
CREATE TABLE Genero (
    IdGenero INT IDENTITY(1,1), -- identity aumenta de 1 en 1
    NombreGenero VARCHAR(50) NOT NULL,
    -- restriccion de clave primaria para 
    CONSTRAINT PK_IdGenero PRIMARY KEY (IdGenero)
);
GO

INSERT INTO Genero (NombreGenero) VALUES 
('Femenino'),
('Masculino'),
('Unisex');
GO


CREATE TABLE CondicionIVA (
IdCondicionIVA INT IDENTITY (1,1),
CondicionIVA VARCHAR(50) NOT NULL, 
CONSTRAINT PK_IdCondicionIVA PRIMARY KEY (IdCondicionIVA)
);
GO

INSERT INTO CondicionIVA (CondicionIVA) VALUES
('Consumidor Final'),
('IVA Exento'),
('Monotributista'),
('Responsable Inscripto');
GO

CREATE TABLE MedioPago (
IdMedioPago INT IDENTITY (1,1),
NombreMedioPago VARCHAR(50) NOT NULL, 
CONSTRAINT PK_IdMedioPago PRIMARY KEY (IdMedioPago)
);

INSERT INTO MedioPago (NombreMedioPago) VALUES
('Contado'),
('Tarjeta'),
('Otro');
GO

CREATE TABLE Proveedor (
IdProveedor INT IDENTITY (1,1),
RazonSocial VARCHAR (125) NOT NULL,
CUIT VARCHAR(11) NOT NULL,
Telefono VARCHAR(25) NOT NULL,
CorreoElectronico VARCHAR(255), 
CONSTRAINT PK_IdProveedor PRIMARY KEY (IdProveedor),
CONSTRAINT UQ_CUIT UNIQUE (CUIT),
CONSTRAINT CK_Telefono CHECK (Telefono NOT LIKE '%[^0-9]%')
);
GO

CREATE TABLE EstadoCompra (
IdEstadoCompra INT IDENTITY (1,1), 
NombreEstadoCompra VARCHAR(50) NOT NULL,
CONSTRAINT PK_IdEstadoCompra PRIMARY KEY (IdEstadoCompra)
);
GO








