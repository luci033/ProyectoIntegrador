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
    Telefono VARCHAR(30) NOT NULL,
    Domicilio VARCHAR (255) NOT NULL,

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
INSERT INTO Usuarios (Usuario, NombreUsuario, ApellidoUsuario, Contrasena, Foto_Perfil, DNI, Telefono, Domicilio, IdRol)
VALUES 
('admin', 'Usuario', 'Administrador', '1234', 'rutapfp', '11111111', '3794123456', 'Av. Magallanes 123', 1),
('gerente', 'Usuario', 'Gerente', '1234', 'rutapfp', '22222222', '3794123456', 'Art Factory San Telmo',  2),
('vendedor', 'Usuario', 'Vendedor', '1234', 'rutapfp', '33333333', '3794123456', 'Calle Inundada 123', 3),
('logistica', 'Usuario', 'Logística', '1234', 'rutapfp', '44444444', '3794123456','Peatonal Junin 654', 4);
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

CREATE TABLE Categoria (
IdCategoria INT IDENTITY (1,1),
NombreCategoria VARCHAR(50) NOT NULL,
CONSTRAINT PK_IdCategoria PRIMARY KEY (IdCategoria),
CONSTRAINT UQ_NombreCategoria UNIQUE (NombreCategoria)
);
GO

CREATE TABLE TipoComprobante (
IdTipoComprobante INT IDENTITY (1,1),
TipoComprobante VARCHAR(50) NOT NULL,
CONSTRAINT PK_IdTipoComprobante PRIMARY KEY (IdTipoComprobante),
CONSTRAINT UQ_TipoComprobante UNIQUE (TipoComprobante),
);
GO

INSERT INTO TipoComprobante (TipoComprobante) VALUES
('Factura A'),
('Factura B'),
('Factura C');
GO

CREATE TABLE Producto (
IdProducto INT IDENTITY (1, 1),
NombreProducto VARCHAR(255),
PrecioVenta DECIMAL (10, 2),
PrecioCompra DECIMAL (10, 2),
StockActual INT,
StockMinimo INT, 
Descripcion VARCHAR (255),
Estado BIT NOT NULL DEFAULT 1,
IdGenero INT,
IdCategoria INT,
CONSTRAINT PK_IdProducto PRIMARY KEY (IdProducto),
CONSTRAINT FK_Genero FOREIGN KEY (IdGenero) REFERENCES Genero(IdGenero),
CONSTRAINT FK_Categoria FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria),
CONSTRAINT CH_PrecioCompra CHECK (PrecioCompra > 0),
CONSTRAINT CH_PrecioVenta CHECK (PrecioVenta > 0),
CONSTRAINT CH_StockMinimo CHECK (StockMinimo > 0),
CONSTRAINT CH_StockActual CHECK (StockActual > 0),
);
GO

CREATE TABLE Compra (
IdCompra INT IDENTITY(1,1),
FechaCompra DATETIME NOT NULL,
IdUsuario INT NOT NULL,
IdProveedor INT NOT NULL,
IdEstadoCompra INT NOT NULL,
IdMedioPago INT NOT NULL,
CONSTRAINT PK_Compra PRIMARY KEY (IdCompra),
CONSTRAINT FK_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuarios (IdUsuario),
CONSTRAINT FK_Proveedor FOREIGN KEY (IdProveedor) REFERENCES Proveedor(IdProveedor),
CONSTRAINT FK_EstadoCompra FOREIGN KEY (IdEstadoCompra) REFERENCES EstadoCompra(IdEstadoCompra),
CONSTRAINT FK_MedioPago FOREIGN KEY (IdMedioPago) REFERENCES MedioPago(IdMedioPago)
);
GO

CREATE TABLE DetalleCompra (
    IdDetalleCompra INT IDENTITY(1,1),
    IdCompra INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(12,2) NOT NULL,
    IdProducto INT NOT NULL,
    CONSTRAINT PK_DetalleCompra_Compra PRIMARY KEY (IdDetalleCompra, IdCompra),
    CONSTRAINT FK_Compra FOREIGN KEY (IdCompra) REFERENCES Compra(IdCompra),
    CONSTRAINT FK_Producto FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto)
);
GO

INSERT INTO EstadoCompra (NombreEstadoCompra) VALUES 
('Pendiente'),
('Recibido Conforme'),
('Recibido Disconforme');
GO

CREATE TABLE Recepcion (
IdRecepcion INT IDENTITY (1,1),
FechaRecepcion DATETIME NOT NULL,
IdCompra INT NOT NULL,
IdUsuario INT NOT NULL, 
CONSTRAINT PK_IdRecepcion PRIMARY KEY (IdRecepcion),
CONSTRAINT FK_CompraRecepcion FOREIGN KEY (IdCompra) REFERENCES Compra(IdCompra),
CONSTRAINT FK_Usuarios FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario),
);
GO

CREATE TABLE DetalleRecepcion (
IdDetalleRepecion INT IDENTITY (1,1),
CantidadRecibida INT NOT NULL,
IdRecepcion INT NOT NULL,
IdDetalleCompra INT NOT NULL,
IdCompra INT NOT NULL,
CONSTRAINT PK_IdDetalleRecepcion PRIMARY KEY (IdDetalleRepecion),
CONSTRAINT FK_Recepcion FOREIGN KEY (IdRecepcion) REFERENCES Recepcion(IdRecepcion),
CONSTRAINT FK_DetalleCompra FOREIGN KEY (IdDetalleCompra, IdCompra) REFERENCES DetalleCompra(IdDetalleCompra, IdCompra)
);
GO

CREATE TABLE Cliente (
IdCliente INT IDENTITY (1,1),
Nombre VARCHAR (50),
Apellido VARCHAR(50),
DNICUIT VARCHAR(11) NOT NULL,
Telefono VARCHAR(30) NOT NULL,
CorreoElectronico VARCHAR (255),
IdCondicionIva INT NOT NULL,
CONSTRAINT PK_IdCliente PRIMARY KEY (IdCliente),
CONSTRAINT UQ_DNICUIT UNIQUE (DNICUIT),
CONSTRAINT FK_CondicionIVA FOREIGN KEY (IdCondicionIVA) REFERENCES CondicionIVA(IdCondicionIVA),
CONSTRAINT CK_DNICUIT_Numerico CHECK (DNICUIT NOT LIKE '%[^0-9]%' AND LEN(DNICUIT) <= 11),
CONSTRAINT CK_ClienteTelefono CHECK (Telefono NOT LIKE '%[^0-9]%'),
);
GO 

CREATE TABLE Comprobante (
IdComprobante INT IDENTITY (1,1),
FechaComprobante DATETIME NOT NULL,
IdMedioPago INT NOT NULL,
IdTipoComprobante INT NOT NULL,
IdCliente INT NOT NULL,
IdUsuario INT NOT NULL, 
CONSTRAINT PK_IdComprobante PRIMARY KEY (IdComprobante),
CONSTRAINT FK_ComprobanteMedioPago FOREIGN KEY (IdMedioPago) REFERENCES MedioPago(IdMedioPago),
CONSTRAINT FK_ComprobanteTipoComprobante FOREIGN KEY (IdTipoComprobante) REFERENCES TipoComprobante(IdTipoComprobante),
CONSTRAINT FK_ComprobanteCliente FOREIGN KEY (IdCliente) REFERENCES Cliente (IdCliente),
CONSTRAINT FK_ComprobanteUsuario FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario),
);
GO

CREATE TABLE DetalleComprobante (
IdDetalleComprobante INT IDENTITY(1,1),
IdComprobante INT NOT NULL,
Cantidad INT NOT NULL,
PrecioUnitario DECIMAL(10,2) NOT NULL,
IdProducto INT NOT NULL,
CONSTRAINT PK_DetalleComprobanteIdComprobante PRIMARY KEY (IdDetalleComprobante, IdComprobante),
CONSTRAINT CK_DetalleComprobanteCantidad CHECK (Cantidad > 0),
CONSTRAINT CK_DetalleComprobantePrecio CHECK (PrecioUnitario >= 0),
CONSTRAINT FK_DetalleComprobanteComprobante FOREIGN KEY (IdComprobante) REFERENCES Comprobante(IdComprobante),
CONSTRAINT FK_DetalleComprobanteProducto FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto) 
);
GO

CREATE TABLE AjusteStock (
IdAjuste INT IDENTITY(1,1),
FechaAjuste DATETIME NOT NULL DEFAULT GETDATE(),
TipoAjuste VARCHAR(30) NOT NULL,
CantidadAjuste INT NOT NULL,
Observacion VARCHAR(250) NULL,
IdUsuario INT NOT NULL,
IdProducto INT NOT NULL,
CONSTRAINT PK_AjusteStock PRIMARY KEY (IdAjuste),
CONSTRAINT CK_AjusteStockCantidad CHECK (CantidadAjuste <> 0),
CONSTRAINT FK_AjusteStockUsuario FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario),
CONSTRAINT FK_AjusteStockProducto FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto) 
);
GO
