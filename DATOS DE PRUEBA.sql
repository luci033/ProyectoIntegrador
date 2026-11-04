USE [JoyeriaALBADB];
GO

-- ==============================================================================
-- 1. PROVEEDORES
-- ==============================================================================
IF NOT EXISTS (SELECT 1 FROM Proveedor WHERE CUIT = '30714791067')
BEGIN
    INSERT INTO Proveedor (RazonSocial, CUIT, Telefono, CorreoElectronico) VALUES
    ('Oro Blanco Joyerías SRL', '30714791067', '3794159864', 'oroblanco@joyas.com.ar'),
    ('Joias Joyas & Piercings', '30717801365', '3794976415', 'joyas@mail.com'),
    ('Joyerías Verdi S.R.L.', '30714973289', '3794787185', 'verdijoyeria@gmail.com'),
    ('Aníbal Caruso e Hijos S.R.L.', '30503460609', '3794676767', 'anibalJoyas@mail.com'),
    ('Cámara Argentina de Joyería, Relojería y Afines', '30678823534', '1192465791', 'camarajoyeria@mail.com.ar');
END
GO

-- ==============================================================================
-- 2. CATEGORÍAS
-- ==============================================================================
IF NOT EXISTS (SELECT 1 FROM Categoria WHERE NombreCategoria = 'Anillos')
BEGIN
    INSERT INTO Categoria (NombreCategoria) VALUES
    ('Anillos'),
    ('Pulseras'),
    ('Collares');
END
GO

-- ==============================================================================
-- 3. PRODUCTOS / JOYAS (CON PRECIO DE COMPRA, VENTA, STOCK Y MARGEN DE GANANCIA)
-- ==============================================================================
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Anillo Solitario Circonia')
BEGIN
    INSERT INTO [dbo].[Producto] 
        ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES
        ('Anillo Solitario Circonia', 26100.00, 18000.00, 15, 5, 'Anillo de plata 925 con piedra circonia cúbica engarzada en 4 garras.', 1, 45, 1, 1, 1),
        ('Anillo Sello Clásico', 35000.00, 25000.00, 12, 4, 'Anillo sello en plata 925 maciza con frente rectangular pulido para grabado.', 1, 40, 2, 1, 3),
        ('Alianza de Compromiso Lisa', 128250.00, 95000.00, 8, 3, 'Alianza clásica de oro blanco 18k, terminación pulida brillante, 4mm.', 1, 35, 3, 1, 4),
        ('Anillo Corona Princesa', 33000.00, 22000.00, 18, 6, 'Anillo fantasía en plata 925 con micro pavé de circonias transparentes.', 1, 50, 1, 1, 2),
        ('Anillo Giratorio Antiestrés', 18000.00, 12000.00, 25, 8, 'Anillo de acero quirúrgico 316L con banda central giratoria texturada.', 1, 50, 3, 1, 5),
        ('Collar Corazón de Cristal', 40600.00, 28000.00, 14, 6, 'Cadena de plata 925 de 45 cm con dije colgante corazón facetado.', 1, 45, 1, 3, 1),
        ('Cadena Eslabón Cubano 6mm', 44800.00, 32000.00, 16, 5, 'Cadena tipo grumetta / eslabón cubano en acero quirúrgico 316L, 60 cm.', 1, 40, 2, 3, 4),
        ('Collar Gargantilla Perlas Cultivadas', 94250.00, 65000.00, 10, 3, 'Gargantilla clásica de perlas cultivadas de río con broche marinero de plata.', 1, 45, 1, 3, 3),
        ('Collar Cadena de Bolitas', 22500.00, 15000.00, 22, 10, 'Cadena estilo militar de bolitas en acero inoxidable 50 cm.', 1, 50, 3, 3, 2),
        ('Cadena Figaro 3x1 Oro Blanco', 182000.00, 140000.00, 6, 4, 'Cadena Figaro 3x1 en oro blanco 18k, largo 55 cm, cierre mosquetón.', 1, 30, 2, 3, 1),
        ('Pulsera Tennis Circonias', 65250.00, 45000.00, 14, 5, 'Pulsera Tennis en plata 925 con línea continua de piedras circonia de 3mm.', 1, 45, 1, 2, 3),
        ('Pulsera Esclava Rígida', 28000.00, 20000.00, 20, 7, 'Pulsera esclava rígida lisa en acero quirúrgico, terminación satinada.', 1, 40, 3, 2, 5),
        ('Pulsera Cuero Trenzado y Acero', 24000.00, 16000.00, 18, 6, 'Brazalete de cuero genuino trenzado color negro con broche magnético de acero.', 1, 50, 2, 2, 4),
        ('Pulsera Charm Dijes de la Suerte', 55100.00, 38000.00, 12, 8, 'Pulsera de eslabones en plata 925 compatible con dijes y charms coleccionables.', 1, 45, 1, 2, 2),
        ('Pulsera Cadena Marina Maciza', 70200.00, 52000.00, 9, 4, 'Pulsera con eslabones tipo ancla / marina de 8mm en plata 925 maciza.', 1, 35, 2, 2, 1),
        ('Pulsera Hilo Rojo Dije Infinito', 12800.00, 8000.00, 30, 12, 'Pulsera de protección con hilo rojo regulable y dije central de infinito en plata 925.', 1, 60, 3, 2, 2);
END
ELSE
BEGIN
    -- Actualización de productos ya existentes con sus precios, márgenes y stocks reales
    UPDATE Producto SET PrecioCompra = 18000.00, MargenGanancia = 45, PrecioVenta = 26100.00, StockActual = 15, StockMinimo = 5 WHERE NombreProducto = 'Anillo Solitario Circonia';
    UPDATE Producto SET PrecioCompra = 25000.00, MargenGanancia = 40, PrecioVenta = 35000.00, StockActual = 12, StockMinimo = 4 WHERE NombreProducto = 'Anillo Sello Clásico';
    UPDATE Producto SET PrecioCompra = 95000.00, MargenGanancia = 35, PrecioVenta = 128250.00, StockActual = 8, StockMinimo = 3 WHERE NombreProducto = 'Alianza de Compromiso Lisa';
    UPDATE Producto SET PrecioCompra = 22000.00, MargenGanancia = 50, PrecioVenta = 33000.00, StockActual = 18, StockMinimo = 6 WHERE NombreProducto = 'Anillo Corona Princesa';
    UPDATE Producto SET PrecioCompra = 12000.00, MargenGanancia = 50, PrecioVenta = 18000.00, StockActual = 25, StockMinimo = 8 WHERE NombreProducto = 'Anillo Giratorio Antiestrés';
    UPDATE Producto SET PrecioCompra = 28000.00, MargenGanancia = 45, PrecioVenta = 40600.00, StockActual = 14, StockMinimo = 6 WHERE NombreProducto = 'Collar Corazón de Cristal';
    UPDATE Producto SET PrecioCompra = 32000.00, MargenGanancia = 40, PrecioVenta = 44800.00, StockActual = 16, StockMinimo = 5 WHERE NombreProducto = 'Cadena Eslabón Cubano 6mm';
    UPDATE Producto SET PrecioCompra = 65000.00, MargenGanancia = 45, PrecioVenta = 94250.00, StockActual = 10, StockMinimo = 3 WHERE NombreProducto = 'Collar Gargantilla Perlas Cultivadas';
    UPDATE Producto SET PrecioCompra = 15000.00, MargenGanancia = 50, PrecioVenta = 22500.00, StockActual = 22, StockMinimo = 10 WHERE NombreProducto = 'Collar Cadena de Bolitas';
    UPDATE Producto SET PrecioCompra = 140000.00, MargenGanancia = 30, PrecioVenta = 182000.00, StockActual = 6, StockMinimo = 4 WHERE NombreProducto = 'Cadena Figaro 3x1 Oro Blanco';
    UPDATE Producto SET PrecioCompra = 45000.00, MargenGanancia = 45, PrecioVenta = 65250.00, StockActual = 14, StockMinimo = 5 WHERE NombreProducto = 'Pulsera Tennis Circonias';
    UPDATE Producto SET PrecioCompra = 20000.00, MargenGanancia = 40, PrecioVenta = 28000.00, StockActual = 20, StockMinimo = 7 WHERE NombreProducto = 'Pulsera Esclava Rígida';
    UPDATE Producto SET PrecioCompra = 16000.00, MargenGanancia = 50, PrecioVenta = 24000.00, StockActual = 18, StockMinimo = 6 WHERE NombreProducto = 'Pulsera Cuero Trenzado y Acero';
    UPDATE Producto SET PrecioCompra = 38000.00, MargenGanancia = 45, PrecioVenta = 55100.00, StockActual = 12, StockMinimo = 8 WHERE NombreProducto = 'Pulsera Charm Dijes de la Suerte';
    UPDATE Producto SET PrecioCompra = 52000.00, MargenGanancia = 35, PrecioVenta = 70200.00, StockActual = 9, StockMinimo = 4 WHERE NombreProducto = 'Pulsera Cadena Marina Maciza';
    UPDATE Producto SET PrecioCompra = 8000.00, MargenGanancia = 60, PrecioVenta = 12800.00, StockActual = 30, StockMinimo = 12 WHERE NombreProducto = 'Pulsera Hilo Rojo Dije Infinito';
END
GO

-- ==============================================================================
-- 4. CLIENTES DE PRUEBA (15 CLIENTES CON DIVERSAS CONDICIONES DE IVA)
-- ==============================================================================
IF NOT EXISTS (SELECT 1 FROM Cliente WHERE DNICUIT = '38452109')
BEGIN
    INSERT INTO Cliente (Nombre, Apellido, DNICUIT, Telefono, CorreoElectronico, IdCondicionIva) VALUES
    ('Sofía Belén', 'Martínez', '38452109', '3794123456', 'sofia.martinez@gmail.com', 1),
    ('Lucas Gabriel', 'Fernández', '20358941203', '3794567890', 'lucas.fernandez@hotmail.com', 4),
    ('Camila Victoria', 'Gómez', '42105698', '3794223344', 'camila.gomez@gmail.com', 1),
    ('Mateo Alejandro', 'Romero', '20412304561', '3794778899', 'mateo.romero@outlook.com', 3),
    ('Valentina Rocío', 'Benítez', '39784512', '3794334455', 'valen.benitez@yahoo.com.ar', 1),
    ('Joaquín Ignacio', 'Álvarez', '36952147', '3794889900', 'joaquin.alvarez@gmail.com', 1),
    ('Florencia Ayelén', 'Sosa', '27376541234', '3794112233', 'flor.sosa@estudiososa.com.ar', 4),
    ('Martín Eduardo', 'Duarte', '34562189', '3794667788', 'martin.duarte@gmail.com', 2),
    ('Julieta Agustina', 'Acosta', '40123987', '3794556677', 'juli.acosta@gmail.com', 1),
    ('Esteban Daniel', 'Ramírez', '20339874562', '3794445566', 'esteban.ramirez@hotmail.com', 3),
    ('María Sol', 'Villalba', '41852963', '3794990011', 'mariasol.villalba@gmail.com', 1),
    ('Gonzalo Andrés', 'Cáceres', '37410258', '3794771122', 'gonza.caceres@outlook.com', 1),
    ('Luciana Micaela', 'Méndez', '27436521478', '3794883344', 'luciana.mendez@gmail.com', 3),
    ('Rodrigo Javier', 'Silva', '35964123', '3794129876', 'rodrigo.silva@yahoo.com.ar', 1),
    ('Clara Milagros', 'Giménez', '27361245890', '3794345678', 'clara.gimenez@estudiojuridico.com.ar', 4);
END
GO

-- ==============================================================================
-- 5. LOTE DE 100 ÓRDENES DE COMPRA DISTRIBUIDAS A LO LARGO DEL AÑO 2026
-- Incluye Cabeceras (Compra), Detalles (DetalleCompra), Recepciones (Recepcion)
-- y Detalle de Recepción (DetalleRecepcion) con integridad referencial completa.
-- ==============================================================================
SET NOCOUNT ON;

-- Solo insertar si aún no se han cargado las compras de prueba
IF (SELECT COUNT(*) FROM Compra) < 50
BEGIN
    IF OBJECT_ID('tempdb..#ComprasLote') IS NOT NULL DROP TABLE #ComprasLote;
    IF OBJECT_ID('tempdb..#DetallesLote') IS NOT NULL DROP TABLE #DetallesLote;

    CREATE TABLE #ComprasLote (
        IdLote INT PRIMARY KEY,
        FechaCompra DATETIME NOT NULL,
        IdUsuarioEmisor INT NOT NULL,
        IdProveedor INT NOT NULL,
        IdEstadoCompra INT NOT NULL,
        FechaRecepcion DATETIME NULL,
        IdUsuarioReceptor INT NULL,
        ObservacionRecepcion VARCHAR(255) NULL
    );

    CREATE TABLE #DetallesLote (
        IdLote INT NOT NULL,
        IdProducto INT NOT NULL,
        Cantidad INT NOT NULL,
        PrecioUnitario DECIMAL(12,2) NOT NULL,
        MargenGanancia INT NULL,
        CantidadRecibida INT NOT NULL
    );

    INSERT INTO #ComprasLote (IdLote, FechaCompra, IdUsuarioEmisor, IdProveedor, IdEstadoCompra, FechaRecepcion, IdUsuarioReceptor, ObservacionRecepcion) VALUES
    (1, '2026-01-03 11:21:00', 4, 1, 2, '2026-01-05 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (2, '2026-01-06 14:42:00', 4, 2, 2, '2026-01-08 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (3, '2026-01-10 09:10:00', 4, 3, 2, '2026-01-12 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (4, '2026-01-14 13:38:00', 4, 4, 2, '2026-01-16 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (5, '2026-01-17 16:59:00', 4, 5, 2, '2026-01-19 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (6, '2026-01-21 11:27:00', 1, 1, 2, '2026-01-23 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (7, '2026-01-24 14:48:00', 4, 2, 2, '2026-01-26 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (8, '2026-01-28 09:16:00', 4, 3, 2, '2026-01-28 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (9, '2026-01-30 11:30:00', 4, 4, 2, '2026-01-28 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (10, '2026-02-02 10:14:00', 4, 5, 2, '2026-02-04 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (11, '2026-02-05 13:35:00', 4, 1, 2, '2026-02-07 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (12, '2026-02-08 16:56:00', 1, 2, 2, '2026-02-10 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (13, '2026-02-12 11:24:00', 4, 3, 2, '2026-02-14 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (14, '2026-02-16 15:52:00', 4, 4, 3, '2026-02-18 15:30:00', 1, 'Recepción con faltante de mercadería. Proveedor notificado para regularización.'),
    (15, '2026-02-19 09:13:00', 4, 5, 2, '2026-02-21 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (16, '2026-02-23 13:41:00', 4, 1, 2, '2026-02-25 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (17, '2026-02-25 15:55:00', 4, 2, 2, '2026-02-27 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (18, '2026-02-27 08:09:00', 1, 3, 2, '2026-02-28 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (19, '2026-03-03 11:21:00', 4, 4, 2, '2026-03-05 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (20, '2026-03-06 14:42:00', 4, 5, 2, '2026-03-08 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (21, '2026-03-10 09:10:00', 4, 1, 2, '2026-03-12 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (22, '2026-03-13 12:31:00', 4, 2, 2, '2026-03-15 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (23, '2026-03-17 16:59:00', 4, 3, 2, '2026-03-19 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (24, '2026-03-20 10:20:00', 1, 4, 2, '2026-03-22 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (25, '2026-03-24 14:48:00', 4, 5, 2, '2026-03-26 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (26, '2026-03-27 08:09:00', 4, 1, 2, '2026-03-28 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (27, '2026-03-30 11:30:00', 4, 2, 3, '2026-03-28 15:30:00', 4, 'Recepción con faltante de mercadería. Proveedor notificado para regularización.'),
    (28, '2026-04-02 10:14:00', 4, 3, 2, '2026-04-04 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (29, '2026-04-06 14:42:00', 4, 4, 2, '2026-04-08 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (30, '2026-04-09 08:03:00', 1, 5, 2, '2026-04-11 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (31, '2026-04-13 12:31:00', 4, 1, 2, '2026-04-15 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (32, '2026-04-16 15:52:00', 4, 2, 2, '2026-04-18 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (33, '2026-04-20 10:20:00', 4, 3, 2, '2026-04-22 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (34, '2026-04-23 13:41:00', 4, 4, 2, '2026-04-25 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (35, '2026-04-27 08:09:00', 4, 5, 2, '2026-04-28 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (36, '2026-04-29 10:23:00', 1, 1, 2, '2026-04-28 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (37, '2026-05-04 12:28:00', 4, 2, 2, '2026-05-06 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (38, '2026-05-07 15:49:00', 4, 3, 2, '2026-05-09 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (39, '2026-05-11 10:17:00', 4, 4, 3, '2026-05-13 15:30:00', 4, 'Recepción con faltante de mercadería. Proveedor notificado para regularización.'),
    (40, '2026-05-14 13:38:00', 4, 5, 2, '2026-05-16 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (41, '2026-05-18 08:06:00', 4, 1, 2, '2026-05-20 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (42, '2026-05-21 11:27:00', 1, 2, 2, '2026-05-23 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (43, '2026-05-25 15:55:00', 4, 3, 2, '2026-05-27 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (44, '2026-05-28 09:16:00', 4, 4, 2, '2026-05-28 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (45, '2026-05-30 11:30:00', 4, 5, 2, '2026-05-28 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (46, '2026-06-02 10:14:00', 4, 1, 2, '2026-06-04 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (47, '2026-06-05 13:35:00', 4, 2, 2, '2026-06-07 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (48, '2026-06-09 08:03:00', 1, 3, 2, '2026-06-11 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (49, '2026-06-12 11:24:00', 4, 4, 2, '2026-06-14 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (50, '2026-06-16 15:52:00', 4, 5, 2, '2026-06-18 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (51, '2026-06-19 09:13:00', 4, 1, 2, '2026-06-21 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (52, '2026-06-23 13:41:00', 4, 2, 3, '2026-06-25 15:30:00', 1, 'Recepción con faltante de mercadería. Proveedor notificado para regularización.'),
    (53, '2026-06-26 16:02:00', 4, 3, 2, '2026-06-28 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (54, '2026-06-29 10:23:00', 1, 4, 2, '2026-06-28 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (55, '2026-07-03 11:21:00', 4, 5, 2, '2026-07-05 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (56, '2026-07-07 15:49:00', 4, 1, 2, '2026-07-09 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (57, '2026-07-10 09:10:00', 4, 2, 2, '2026-07-12 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (58, '2026-07-14 13:38:00', 4, 3, 2, '2026-07-16 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (59, '2026-07-17 16:59:00', 4, 4, 2, '2026-07-19 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (60, '2026-07-21 11:27:00', 1, 5, 2, '2026-07-23 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (61, '2026-07-24 14:48:00', 4, 1, 2, '2026-07-26 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (62, '2026-07-28 09:16:00', 4, 2, 2, '2026-07-28 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (63, '2026-07-31 12:37:00', 4, 3, 2, '2026-07-28 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (64, '2026-08-04 12:28:00', 4, 4, 2, '2026-08-06 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (65, '2026-08-07 15:49:00', 4, 5, 2, '2026-08-09 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (66, '2026-08-11 10:17:00', 1, 1, 2, '2026-08-13 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (67, '2026-08-14 13:38:00', 4, 2, 2, '2026-08-16 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (68, '2026-08-18 08:06:00', 4, 3, 3, '2026-08-20 15:30:00', 1, 'Recepción con faltante de mercadería. Proveedor notificado para regularización.'),
    (69, '2026-08-21 11:27:00', 4, 4, 2, '2026-08-23 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (70, '2026-08-25 15:55:00', 4, 5, 2, '2026-08-27 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (71, '2026-08-28 09:16:00', 4, 1, 2, '2026-08-28 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (72, '2026-08-31 12:37:00', 1, 2, 2, '2026-08-28 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (73, '2026-09-02 10:14:00', 4, 3, 2, '2026-09-04 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (74, '2026-09-05 13:35:00', 4, 4, 2, '2026-09-07 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (75, '2026-09-09 08:03:00', 4, 5, 3, '2026-09-11 15:30:00', 4, 'Recepción con faltante de mercadería. Proveedor notificado para regularización.'),
    (76, '2026-09-12 11:24:00', 4, 1, 2, '2026-09-14 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (77, '2026-09-16 15:52:00', 4, 2, 2, '2026-09-18 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (78, '2026-09-19 09:13:00', 1, 3, 2, '2026-09-21 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (79, '2026-09-23 13:41:00', 4, 4, 2, '2026-09-25 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (80, '2026-09-26 16:02:00', 4, 5, 2, '2026-09-28 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (81, '2026-09-29 10:23:00', 4, 1, 2, '2026-09-28 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (82, '2026-10-02 10:14:00', 4, 2, 2, '2026-10-04 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (83, '2026-10-05 13:35:00', 4, 3, 2, '2026-10-07 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (84, '2026-10-08 16:56:00', 1, 4, 2, '2026-10-10 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (85, '2026-10-12 11:24:00', 4, 5, 2, '2026-10-14 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (86, '2026-10-15 14:45:00', 4, 1, 2, '2026-10-17 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (87, '2026-10-19 09:13:00', 4, 2, 2, '2026-10-21 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (88, '2026-10-22 12:34:00', 4, 3, 3, '2026-10-24 15:30:00', 1, 'Recepción con faltante de mercadería. Proveedor notificado para regularización.'),
    (89, '2026-10-26 16:02:00', 4, 4, 1, NULL, NULL, NULL),
    (90, '2026-10-28 09:16:00', 1, 5, 1, NULL, NULL, NULL),
    (91, '2026-10-30 11:30:00', 4, 1, 2, '2026-10-28 14:00:00', 4, 'Recepción completa y conforme en depósito.'),
    (92, '2026-11-02 10:14:00', 4, 2, 2, '2026-11-04 14:00:00', 1, 'Recepción completa y conforme en depósito.'),
    (93, '2026-11-05 13:35:00', 4, 3, 1, NULL, NULL, NULL),
    (94, '2026-11-08 16:56:00', 4, 4, 1, NULL, NULL, NULL),
    (95, '2026-11-11 10:17:00', 4, 5, 1, NULL, NULL, NULL),
    (96, '2026-11-15 14:45:00', 1, 1, 1, NULL, NULL, NULL),
    (97, '2026-11-18 08:06:00', 4, 2, 1, NULL, NULL, NULL),
    (98, '2026-11-21 11:27:00', 4, 3, 1, NULL, NULL, NULL),
    (99, '2026-11-24 14:48:00', 4, 4, 1, NULL, NULL, NULL),
    (100, '2026-11-28 09:16:00', 4, 5, 1, NULL, NULL, NULL);

    INSERT INTO #DetallesLote (IdLote, IdProducto, Cantidad, PrecioUnitario, MargenGanancia, CantidadRecibida) VALUES
    (1, 1, 10, 18000.00, 45, 10),
    (1, 6, 20, 28000.00, 45, 20),
    (2, 16, 23, 8000.00, 60, 23),
    (2, 14, 19, 38000.00, 45, 19),
    (3, 2, 18, 25000.00, 40, 18),
    (4, 13, 23, 16000.00, 50, 23),
    (4, 7, 11, 32000.00, 40, 11),
    (5, 5, 10, 12000.00, 50, 10),
    (5, 12, 24, 20000.00, 40, 24),
    (6, 15, 13, 52000.00, 35, 13),
    (7, 4, 14, 22000.00, 50, 14),
    (7, 9, 24, 15000.00, 50, 24),
    (8, 11, 11, 45000.00, 45, 11),
    (8, 8, 5, 65000.00, 45, 5),
    (9, 3, 18, 95000.00, 35, 18),
    (10, 12, 19, 20000.00, 40, 19),
    (10, 5, 5, 12000.00, 50, 5),
    (11, 1, 20, 18000.00, 45, 20),
    (11, 6, 10, 28000.00, 45, 10),
    (12, 16, 13, 8000.00, 60, 13),
    (13, 2, 8, 25000.00, 40, 8),
    (13, 8, 20, 65000.00, 45, 20),
    (14, 13, 13, 16000.00, 50, 10),
    (14, 7, 21, 32000.00, 40, 18),
    (15, 5, 20, 12000.00, 50, 20),
    (16, 15, 23, 52000.00, 35, 23),
    (16, 10, 13, 140000.00, 30, 13),
    (17, 4, 24, 22000.00, 50, 24),
    (17, 9, 14, 15000.00, 50, 14),
    (18, 11, 21, 45000.00, 45, 21),
    (19, 3, 8, 95000.00, 35, 8),
    (19, 7, 16, 32000.00, 40, 16),
    (20, 12, 9, 20000.00, 40, 9),
    (20, 5, 15, 12000.00, 50, 15),
    (21, 1, 10, 18000.00, 45, 10),
    (22, 16, 23, 8000.00, 60, 23),
    (22, 14, 19, 38000.00, 45, 19),
    (23, 2, 18, 25000.00, 40, 18),
    (23, 8, 10, 65000.00, 45, 10),
    (24, 13, 23, 16000.00, 50, 23),
    (25, 5, 10, 12000.00, 50, 10),
    (25, 12, 24, 20000.00, 40, 24),
    (26, 15, 13, 52000.00, 35, 13),
    (26, 10, 23, 140000.00, 30, 23),
    (27, 4, 14, 22000.00, 50, 11),
    (28, 11, 11, 45000.00, 45, 11),
    (28, 8, 5, 65000.00, 45, 5),
    (29, 3, 18, 95000.00, 35, 18),
    (29, 7, 6, 32000.00, 40, 6),
    (30, 12, 19, 20000.00, 40, 19),
    (31, 1, 20, 18000.00, 45, 20),
    (31, 6, 10, 28000.00, 45, 10),
    (32, 16, 13, 8000.00, 60, 13),
    (32, 14, 9, 38000.00, 45, 9),
    (33, 2, 8, 25000.00, 40, 8),
    (34, 13, 13, 16000.00, 50, 13),
    (34, 7, 21, 32000.00, 40, 21),
    (35, 5, 20, 12000.00, 50, 20),
    (35, 12, 14, 20000.00, 40, 14),
    (36, 15, 23, 52000.00, 35, 23),
    (37, 4, 24, 22000.00, 50, 24),
    (37, 9, 14, 15000.00, 50, 14),
    (38, 11, 21, 45000.00, 45, 21),
    (38, 8, 15, 65000.00, 45, 15),
    (39, 3, 8, 95000.00, 35, 5),
    (40, 12, 9, 20000.00, 40, 9),
    (40, 5, 15, 12000.00, 50, 15),
    (41, 1, 10, 18000.00, 45, 10),
    (41, 6, 20, 28000.00, 45, 20),
    (42, 16, 23, 8000.00, 60, 23),
    (43, 2, 18, 25000.00, 40, 18),
    (43, 8, 10, 65000.00, 45, 10),
    (44, 13, 23, 16000.00, 50, 23),
    (44, 7, 11, 32000.00, 40, 11),
    (45, 5, 10, 12000.00, 50, 10),
    (46, 15, 13, 52000.00, 35, 13),
    (46, 10, 23, 140000.00, 30, 23),
    (47, 4, 14, 22000.00, 50, 14),
    (47, 9, 24, 15000.00, 50, 24),
    (48, 11, 11, 45000.00, 45, 11),
    (49, 3, 18, 95000.00, 35, 18),
    (49, 7, 6, 32000.00, 40, 6),
    (50, 12, 19, 20000.00, 40, 19),
    (50, 5, 5, 12000.00, 50, 5),
    (51, 1, 20, 18000.00, 45, 20),
    (52, 16, 13, 8000.00, 60, 10),
    (52, 14, 9, 38000.00, 45, 6),
    (53, 2, 8, 25000.00, 40, 8),
    (53, 8, 20, 65000.00, 45, 20),
    (54, 13, 13, 16000.00, 50, 13),
    (55, 5, 20, 12000.00, 50, 20),
    (55, 12, 14, 20000.00, 40, 14),
    (56, 15, 23, 52000.00, 35, 23),
    (56, 10, 13, 140000.00, 30, 13),
    (57, 4, 24, 22000.00, 50, 24),
    (58, 11, 21, 45000.00, 45, 21),
    (58, 8, 15, 65000.00, 45, 15),
    (59, 3, 8, 95000.00, 35, 8),
    (59, 7, 16, 32000.00, 40, 16),
    (60, 12, 9, 20000.00, 40, 9),
    (61, 1, 10, 18000.00, 45, 10),
    (61, 6, 20, 28000.00, 45, 20),
    (62, 16, 23, 8000.00, 60, 23),
    (62, 14, 19, 38000.00, 45, 19),
    (63, 2, 18, 25000.00, 40, 18),
    (64, 13, 23, 16000.00, 50, 23),
    (64, 7, 11, 32000.00, 40, 11),
    (65, 5, 10, 12000.00, 50, 10),
    (65, 12, 24, 20000.00, 40, 24),
    (66, 15, 13, 52000.00, 35, 13),
    (67, 4, 14, 22000.00, 50, 14),
    (67, 9, 24, 15000.00, 50, 24),
    (68, 11, 11, 45000.00, 45, 8),
    (68, 8, 5, 65000.00, 45, 2),
    (69, 3, 18, 95000.00, 35, 18),
    (70, 12, 19, 20000.00, 40, 19),
    (70, 5, 5, 12000.00, 50, 5),
    (71, 1, 20, 18000.00, 45, 20),
    (71, 6, 10, 28000.00, 45, 10),
    (72, 16, 13, 8000.00, 60, 13),
    (73, 2, 8, 25000.00, 40, 8),
    (73, 8, 20, 65000.00, 45, 20),
    (74, 13, 13, 16000.00, 50, 13),
    (74, 7, 21, 32000.00, 40, 21),
    (75, 5, 20, 12000.00, 50, 17),
    (76, 15, 23, 52000.00, 35, 23),
    (76, 10, 13, 140000.00, 30, 13),
    (77, 4, 24, 22000.00, 50, 24),
    (77, 9, 14, 15000.00, 50, 14),
    (78, 11, 21, 45000.00, 45, 21),
    (79, 3, 8, 95000.00, 35, 8),
    (79, 7, 16, 32000.00, 40, 16),
    (80, 12, 9, 20000.00, 40, 9),
    (80, 5, 15, 12000.00, 50, 15),
    (81, 1, 10, 18000.00, 45, 10),
    (82, 16, 23, 8000.00, 60, 23),
    (82, 14, 19, 38000.00, 45, 19),
    (83, 2, 18, 25000.00, 40, 18),
    (83, 8, 10, 65000.00, 45, 10),
    (84, 13, 23, 16000.00, 50, 23),
    (85, 5, 10, 12000.00, 50, 10),
    (85, 12, 24, 20000.00, 40, 24),
    (86, 15, 13, 52000.00, 35, 13),
    (86, 10, 23, 140000.00, 30, 23),
    (87, 4, 14, 22000.00, 50, 14),
    (88, 11, 11, 45000.00, 45, 8),
    (88, 8, 5, 65000.00, 45, 2),
    (89, 3, 18, 95000.00, 35, 0),
    (89, 7, 6, 32000.00, 40, 0),
    (90, 12, 19, 20000.00, 40, 0),
    (91, 1, 20, 18000.00, 45, 20),
    (91, 6, 10, 28000.00, 45, 10),
    (92, 16, 13, 8000.00, 60, 13),
    (92, 14, 9, 38000.00, 45, 9),
    (93, 2, 8, 25000.00, 40, 0),
    (94, 13, 13, 16000.00, 50, 0),
    (94, 7, 21, 32000.00, 40, 0),
    (95, 5, 20, 12000.00, 50, 0),
    (95, 12, 14, 20000.00, 40, 0),
    (96, 15, 23, 52000.00, 35, 0),
    (97, 4, 24, 22000.00, 50, 0),
    (97, 9, 14, 15000.00, 50, 0),
    (98, 11, 21, 45000.00, 45, 0),
    (98, 8, 15, 65000.00, 45, 0),
    (99, 3, 8, 95000.00, 35, 0),
    (100, 12, 9, 20000.00, 40, 0),
    (100, 5, 15, 12000.00, 50, 0);

    DECLARE @TotalCompras INT = (SELECT COUNT(*) FROM #ComprasLote);
    DECLARE @i INT = 1;

    WHILE @i <= @TotalCompras
    BEGIN
        DECLARE @FCompra DATETIME, @UEmisor INT, @Prov INT, @Estado INT;
        DECLARE @FRecep DATETIME, @URecep INT, @Obs VARCHAR(255);
        DECLARE @IdCompraGenerada INT, @IdRecepcionGenerada INT;

        SELECT 
            @FCompra = FechaCompra,
            @UEmisor = IdUsuarioEmisor,
            @Prov = IdProveedor,
            @Estado = IdEstadoCompra,
            @FRecep = FechaRecepcion,
            @URecep = IdUsuarioReceptor,
            @Obs = ObservacionRecepcion
        FROM #ComprasLote
        WHERE IdLote = @i;

        -- 1. Insertar Orden de Compra
        INSERT INTO Compra (FechaCompra, IdUsuario, IdProveedor, IdEstadoCompra)
        VALUES (@FCompra, @UEmisor, @Prov, @Estado);
        SET @IdCompraGenerada = SCOPE_IDENTITY();

        -- 2. Insertar Recepción si corresponde (Estados 2 = Conforme, 3 = Disconforme)
        IF @Estado IN (2, 3) AND @FRecep IS NOT NULL
        BEGIN
            INSERT INTO Recepcion (FechaRecepcion, IdCompra, IdUsuario, Observacion)
            VALUES (@FRecep, @IdCompraGenerada, @URecep, @Obs);
            SET @IdRecepcionGenerada = SCOPE_IDENTITY();
        END
        ELSE
        BEGIN
            SET @IdRecepcionGenerada = NULL;
        END

        -- 3. Insertar Detalles de la Compra y Detalle de Recepción con IDs exactos
        DECLARE @IdProd INT, @Cant INT, @PU DECIMAL(12,2), @Margen INT, @CantRec INT;
        DECLARE @IdDetalleGenerado INT;

        DECLARE curDetalles CURSOR LOCAL FAST_FORWARD FOR
            SELECT IdProducto, Cantidad, PrecioUnitario, MargenGanancia, CantidadRecibida
            FROM #DetallesLote
            WHERE IdLote = @i;

        OPEN curDetalles;
        FETCH NEXT FROM curDetalles INTO @IdProd, @Cant, @PU, @Margen, @CantRec;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Insertar DetalleCompra
            INSERT INTO DetalleCompra (IdCompra, Cantidad, PrecioUnitario, MargenGanancia, IdProducto)
            VALUES (@IdCompraGenerada, @Cant, @PU, @Margen, @IdProd);
            SET @IdDetalleGenerado = SCOPE_IDENTITY();

            -- Insertar DetalleRecepcion si la compra fue recibida
            IF @IdRecepcionGenerada IS NOT NULL AND @CantRec > 0
            BEGIN
                INSERT INTO DetalleRecepcion (CantidadRecibida, IdRecepcion, IdDetalleCompra, IdCompra)
                VALUES (@CantRec, @IdRecepcionGenerada, @IdDetalleGenerado, @IdCompraGenerada);
            END

            FETCH NEXT FROM curDetalles INTO @IdProd, @Cant, @PU, @Margen, @CantRec;
        END

        CLOSE curDetalles;
        DEALLOCATE curDetalles;

        SET @i = @i + 1;
    END;

    DROP TABLE #DetallesLote;
    DROP TABLE #ComprasLote;

    PRINT '¡Lote de 100 compras del año 2026 cargado exitosamente!';
END
ELSE
BEGIN
    PRINT 'El lote de compras ya se encuentra cargado previamente en la base de datos.';
END
GO

-- ==============================================================================
-- 6. LOTE DE 150 VENTAS DISTRIBUIDAS A LO LARGO DEL AÑO 2026
-- Incluye Cabeceras (Comprobante) y Detalles (DetalleComprobante)
-- con integridad referencial completa y vinculación a clientes, usuarios y medios de pago.
-- ==============================================================================
SET NOCOUNT ON;

-- Solo insertar si aún no se han cargado las ventas de prueba
IF (SELECT COUNT(*) FROM Comprobante) < 50
BEGIN
    IF OBJECT_ID('tempdb..#VentasLote') IS NOT NULL DROP TABLE #VentasLote;
    IF OBJECT_ID('tempdb..#DetallesVentaLote') IS NOT NULL DROP TABLE #DetallesVentaLote;

    CREATE TABLE #VentasLote (
        IdLote INT PRIMARY KEY,
        FechaComprobante DATETIME NOT NULL,
        IdMedioPago INT NOT NULL,
        DNICUITCliente VARCHAR(20) NOT NULL,
        IdUsuario INT NOT NULL
    );

    CREATE TABLE #DetallesVentaLote (
        IdLote INT NOT NULL,
        NombreProducto VARCHAR(100) NOT NULL,
        Cantidad INT NOT NULL
    );

    INSERT INTO #VentasLote (IdLote, FechaComprobante, IdMedioPago, DNICUITCliente, IdUsuario) VALUES
    (1, '2026-01-02 10:13:00', 1, '38452109', 3),
    (2, '2026-01-04 11:26:00', 2, '20358941203', 3),
    (3, '2026-01-07 12:39:00', 1, '42105698', 3),
    (4, '2026-01-09 13:52:00', 2, '20412304561', 3),
    (5, '2026-01-12 14:10:00', 1, '39784512', 1),
    (6, '2026-01-14 15:23:00', 2, '36952147', 3),
    (7, '2026-01-16 16:36:00', 1, '27376541234', 2),
    (8, '2026-01-19 17:49:00', 2, '34562189', 3),
    (9, '2026-01-21 18:07:00', 1, '40123987', 3),
    (10, '2026-01-23 19:20:00', 3, '20339874562', 1),
    (11, '2026-01-26 09:33:00', 1, '41852963', 3),
    (12, '2026-01-28 10:46:00', 2, '37410258', 3),
    (13, '2026-01-29 11:04:00', 1, '27436521478', 3),
    (14, '2026-01-31 12:17:00', 2, '35964123', 2),
    (15, '2026-02-02 13:30:00', 1, '27361245890', 1),
    (16, '2026-02-04 14:43:00', 2, '38452109', 3),
    (17, '2026-02-06 15:01:00', 1, '20358941203', 3),
    (18, '2026-02-09 16:14:00', 2, '42105698', 3),
    (19, '2026-02-11 17:27:00', 1, '20412304561', 3),
    (20, '2026-02-13 18:40:00', 3, '39784512', 1),
    (21, '2026-02-16 19:53:00', 1, '36952147', 2),
    (22, '2026-02-18 09:11:00', 2, '27376541234', 3),
    (23, '2026-02-20 10:24:00', 1, '34562189', 3),
    (24, '2026-02-23 11:37:00', 2, '40123987', 3),
    (25, '2026-02-25 12:50:00', 1, '20339874562', 1),
    (26, '2026-02-27 13:08:00', 2, '41852963', 3),
    (27, '2026-02-28 14:21:00', 1, '37410258', 3),
    (28, '2026-03-02 15:34:00', 2, '27436521478', 2),
    (29, '2026-03-04 16:47:00', 1, '35964123', 3),
    (30, '2026-03-07 17:05:00', 3, '27361245890', 1),
    (31, '2026-03-09 18:18:00', 1, '38452109', 3),
    (32, '2026-03-12 19:31:00', 2, '20358941203', 3),
    (33, '2026-03-14 09:44:00', 1, '42105698', 3),
    (34, '2026-03-16 10:02:00', 2, '20412304561', 3),
    (35, '2026-03-18 11:15:00', 1, '39784512', 1),
    (36, '2026-03-21 12:28:00', 2, '36952147', 3),
    (37, '2026-03-23 13:41:00', 1, '27376541234', 3),
    (38, '2026-03-25 14:54:00', 2, '34562189', 3),
    (39, '2026-03-27 15:12:00', 1, '40123987', 3),
    (40, '2026-03-29 16:25:00', 3, '20339874562', 1),
    (41, '2026-03-31 17:38:00', 1, '41852963', 3),
    (42, '2026-04-02 18:51:00', 2, '37410258', 2),
    (43, '2026-04-04 19:09:00', 1, '27436521478', 3),
    (44, '2026-04-07 09:22:00', 2, '35964123', 3),
    (45, '2026-04-09 10:35:00', 1, '27361245890', 1),
    (46, '2026-04-11 11:48:00', 2, '38452109', 3),
    (47, '2026-04-14 12:06:00', 1, '20358941203', 3),
    (48, '2026-04-16 13:19:00', 2, '42105698', 3),
    (49, '2026-04-18 14:32:00', 1, '20412304561', 2),
    (50, '2026-04-21 15:45:00', 3, '39784512', 1),
    (51, '2026-04-23 16:03:00', 1, '36952147', 3),
    (52, '2026-04-25 17:16:00', 2, '27376541234', 3),
    (53, '2026-04-27 18:29:00', 1, '34562189', 3),
    (54, '2026-04-28 19:42:00', 2, '40123987', 3),
    (55, '2026-04-30 09:00:00', 1, '20339874562', 1),
    (56, '2026-05-02 10:13:00', 2, '41852963', 2),
    (57, '2026-05-05 11:26:00', 1, '37410258', 3),
    (58, '2026-05-07 12:39:00', 2, '27436521478', 3),
    (59, '2026-05-09 13:52:00', 1, '35964123', 3),
    (60, '2026-05-12 14:10:00', 3, '27361245890', 1),
    (61, '2026-05-14 15:23:00', 1, '38452109', 3),
    (62, '2026-05-16 16:36:00', 2, '20358941203', 3),
    (63, '2026-05-18 17:49:00', 1, '42105698', 2),
    (64, '2026-05-20 18:07:00', 2, '20412304561', 3),
    (65, '2026-05-22 19:20:00', 1, '39784512', 1),
    (66, '2026-05-25 09:33:00', 2, '36952147', 3),
    (67, '2026-05-27 10:46:00', 1, '27376541234', 3),
    (68, '2026-05-29 11:04:00', 2, '34562189', 3),
    (69, '2026-05-30 12:17:00', 1, '40123987', 3),
    (70, '2026-06-01 13:30:00', 3, '20339874562', 1),
    (71, '2026-06-03 14:43:00', 1, '41852963', 3),
    (72, '2026-06-06 15:01:00', 2, '37410258', 3),
    (73, '2026-06-08 16:14:00', 1, '27436521478', 3),
    (74, '2026-06-10 17:27:00', 2, '35964123', 3),
    (75, '2026-06-12 18:40:00', 1, '27361245890', 1),
    (76, '2026-06-15 19:53:00', 2, '38452109', 3),
    (77, '2026-06-17 09:11:00', 1, '20358941203', 2),
    (78, '2026-06-19 10:24:00', 2, '42105698', 3),
    (79, '2026-06-22 11:37:00', 1, '20412304561', 3),
    (80, '2026-06-24 12:50:00', 3, '39784512', 1),
    (81, '2026-06-26 13:08:00', 1, '36952147', 3),
    (82, '2026-06-27 14:21:00', 2, '27376541234', 3),
    (83, '2026-06-29 15:34:00', 1, '34562189', 3),
    (84, '2026-07-01 16:47:00', 2, '40123987', 2),
    (85, '2026-07-03 17:05:00', 1, '20339874562', 1),
    (86, '2026-07-06 18:18:00', 2, '41852963', 3),
    (87, '2026-07-08 19:31:00', 1, '37410258', 3),
    (88, '2026-07-11 09:44:00', 2, '27436521478', 3),
    (89, '2026-07-13 10:02:00', 1, '35964123', 3),
    (90, '2026-07-15 11:15:00', 3, '27361245890', 1),
    (91, '2026-07-17 12:28:00', 1, '38452109', 2),
    (92, '2026-07-20 13:41:00', 2, '20358941203', 3),
    (93, '2026-07-22 14:54:00', 1, '42105698', 3),
    (94, '2026-07-24 15:12:00', 2, '20412304561', 3),
    (95, '2026-07-27 16:25:00', 1, '39784512', 1),
    (96, '2026-07-29 17:38:00', 2, '36952147', 3),
    (97, '2026-07-31 18:51:00', 1, '27376541234', 3),
    (98, '2026-08-03 19:09:00', 2, '34562189', 2),
    (99, '2026-08-05 09:22:00', 1, '40123987', 3),
    (100, '2026-08-07 10:35:00', 3, '20339874562', 1),
    (101, '2026-08-10 11:48:00', 1, '41852963', 3),
    (102, '2026-08-12 12:06:00', 2, '37410258', 3),
    (103, '2026-08-14 13:19:00', 1, '27436521478', 3),
    (104, '2026-08-17 14:32:00', 2, '35964123', 3),
    (105, '2026-08-19 15:45:00', 1, '27361245890', 1),
    (106, '2026-08-21 16:03:00', 2, '38452109', 3),
    (107, '2026-08-24 17:16:00', 1, '20358941203', 3),
    (108, '2026-08-26 18:29:00', 2, '42105698', 3),
    (109, '2026-08-28 19:42:00', 1, '20412304561', 3),
    (110, '2026-08-29 09:00:00', 3, '39784512', 1),
    (111, '2026-08-31 10:13:00', 1, '36952147', 3),
    (112, '2026-09-01 11:26:00', 2, '27376541234', 2),
    (113, '2026-09-03 12:39:00', 1, '34562189', 3),
    (114, '2026-09-05 13:52:00', 2, '40123987', 3),
    (115, '2026-09-08 14:10:00', 1, '20339874562', 1),
    (116, '2026-09-10 15:23:00', 2, '41852963', 3),
    (117, '2026-09-12 16:36:00', 1, '37410258', 3),
    (118, '2026-09-15 17:49:00', 2, '27436521478', 3),
    (119, '2026-09-17 18:07:00', 1, '35964123', 2),
    (120, '2026-09-19 19:20:00', 3, '27361245890', 1),
    (121, '2026-09-21 09:33:00', 1, '38452109', 3),
    (122, '2026-09-23 10:46:00', 2, '20358941203', 3),
    (123, '2026-09-25 11:04:00', 1, '42105698', 3),
    (124, '2026-09-28 12:17:00', 2, '20412304561', 3),
    (125, '2026-09-30 13:30:00', 1, '39784512', 1),
    (126, '2026-10-01 14:43:00', 2, '36952147', 2),
    (127, '2026-10-03 15:01:00', 1, '27376541234', 3),
    (128, '2026-10-05 16:14:00', 2, '34562189', 3),
    (129, '2026-10-07 17:27:00', 1, '40123987', 3),
    (130, '2026-10-09 18:40:00', 3, '20339874562', 1),
    (131, '2026-10-12 19:53:00', 1, '41852963', 3),
    (132, '2026-10-14 09:11:00', 2, '37410258', 3),
    (133, '2026-10-16 10:24:00', 1, '27436521478', 2),
    (134, '2026-10-19 11:37:00', 2, '35964123', 3),
    (135, '2026-10-21 12:50:00', 1, '27361245890', 1),
    (136, '2026-10-23 13:08:00', 2, '38452109', 3),
    (137, '2026-10-26 14:21:00', 1, '20358941203', 3),
    (138, '2026-10-28 15:34:00', 2, '42105698', 3),
    (139, '2026-10-30 16:47:00', 1, '20412304561', 3),
    (140, '2026-11-01 17:05:00', 3, '39784512', 1),
    (141, '2026-11-01 18:18:00', 1, '36952147', 3),
    (142, '2026-11-02 19:31:00', 2, '27376541234', 3),
    (143, '2026-11-02 09:44:00', 1, '34562189', 3),
    (144, '2026-11-02 10:02:00', 2, '40123987', 3),
    (145, '2026-11-03 11:15:00', 1, '20339874562', 1),
    (146, '2026-11-03 12:28:00', 2, '41852963', 3),
    (147, '2026-11-03 13:41:00', 1, '37410258', 2),
    (148, '2026-11-04 14:54:00', 2, '27436521478', 3),
    (149, '2026-11-04 15:12:00', 1, '35964123', 3),
    (150, '2026-11-04 16:25:00', 3, '27361245890', 1);

    INSERT INTO #DetallesVentaLote (IdLote, NombreProducto, Cantidad) VALUES
    (1, 'Anillo Corona Princesa', 1),
    (2, 'Cadena Eslabón Cubano 6mm', 1),
    (3, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (3, 'Pulsera Cadena Marina Maciza', 1),
    (4, 'Pulsera Cuero Trenzado y Acero', 1),
    (5, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (6, 'Alianza de Compromiso Lisa', 1),
    (6, 'Collar Gargantilla Perlas Cultivadas', 1),
    (7, 'Collar Corazón de Cristal', 2),
    (8, 'Collar Cadena de Bolitas', 1),
    (9, 'Pulsera Esclava Rígida', 1),
    (9, 'Anillo Solitario Circonia', 1),
    (10, 'Pulsera Cadena Marina Maciza', 1),
    (10, 'Anillo Corona Princesa', 1),
    (10, 'Collar Cadena de Bolitas', 1),
    (11, 'Anillo Sello Clásico', 1),
    (12, 'Anillo Giratorio Antiestrés', 1),
    (12, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (13, 'Collar Gargantilla Perlas Cultivadas', 1),
    (14, 'Pulsera Tennis Circonias', 2),
    (15, 'Pulsera Charm Dijes de la Suerte', 1),
    (15, 'Alianza de Compromiso Lisa', 1),
    (16, 'Anillo Solitario Circonia', 1),
    (17, 'Anillo Corona Princesa', 1),
    (18, 'Cadena Eslabón Cubano 6mm', 1),
    (18, 'Pulsera Esclava Rígida', 1),
    (19, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (20, 'Pulsera Cuero Trenzado y Acero', 1),
    (20, 'Anillo Sello Clásico', 1),
    (20, 'Cadena Eslabón Cubano 6mm', 1),
    (21, 'Pulsera Hilo Rojo Dije Infinito', 2),
    (21, 'Anillo Giratorio Antiestrés', 1),
    (22, 'Alianza de Compromiso Lisa', 1),
    (23, 'Collar Corazón de Cristal', 1),
    (24, 'Collar Cadena de Bolitas', 1),
    (24, 'Pulsera Charm Dijes de la Suerte', 1),
    (25, 'Pulsera Esclava Rígida', 1),
    (26, 'Pulsera Cadena Marina Maciza', 1),
    (27, 'Anillo Sello Clásico', 1),
    (27, 'Cadena Eslabón Cubano 6mm', 1),
    (28, 'Anillo Giratorio Antiestrés', 2),
    (29, 'Collar Gargantilla Perlas Cultivadas', 1),
    (30, 'Pulsera Tennis Circonias', 1),
    (30, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (30, 'Anillo Giratorio Antiestrés', 1),
    (31, 'Pulsera Charm Dijes de la Suerte', 1),
    (32, 'Anillo Solitario Circonia', 1),
    (33, 'Anillo Corona Princesa', 1),
    (33, 'Collar Cadena de Bolitas', 1),
    (34, 'Cadena Eslabón Cubano 6mm', 1),
    (35, 'Cadena Figaro 3x1 Oro Blanco', 2),
    (36, 'Pulsera Cuero Trenzado y Acero', 1),
    (36, 'Anillo Sello Clásico', 1),
    (37, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (38, 'Alianza de Compromiso Lisa', 1),
    (39, 'Collar Corazón de Cristal', 1),
    (39, 'Pulsera Tennis Circonias', 1),
    (40, 'Collar Cadena de Bolitas', 1),
    (40, 'Pulsera Charm Dijes de la Suerte', 1),
    (40, 'Alianza de Compromiso Lisa', 1),
    (41, 'Pulsera Esclava Rígida', 1),
    (42, 'Pulsera Cadena Marina Maciza', 2),
    (42, 'Anillo Corona Princesa', 1),
    (43, 'Anillo Sello Clásico', 1),
    (44, 'Anillo Giratorio Antiestrés', 1),
    (45, 'Collar Gargantilla Perlas Cultivadas', 1),
    (45, 'Pulsera Cuero Trenzado y Acero', 1),
    (46, 'Pulsera Tennis Circonias', 1),
    (47, 'Pulsera Charm Dijes de la Suerte', 1),
    (48, 'Anillo Solitario Circonia', 1),
    (48, 'Collar Corazón de Cristal', 1),
    (49, 'Anillo Corona Princesa', 2),
    (50, 'Cadena Eslabón Cubano 6mm', 1),
    (50, 'Pulsera Esclava Rígida', 1),
    (50, 'Anillo Solitario Circonia', 1),
    (51, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (51, 'Pulsera Cadena Marina Maciza', 1),
    (52, 'Pulsera Cuero Trenzado y Acero', 1),
    (53, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (54, 'Alianza de Compromiso Lisa', 1),
    (54, 'Collar Gargantilla Perlas Cultivadas', 1),
    (55, 'Collar Corazón de Cristal', 1),
    (56, 'Collar Cadena de Bolitas', 2),
    (57, 'Pulsera Esclava Rígida', 1),
    (57, 'Anillo Solitario Circonia', 1),
    (58, 'Pulsera Cadena Marina Maciza', 1),
    (59, 'Anillo Sello Clásico', 1),
    (60, 'Anillo Giratorio Antiestrés', 1),
    (60, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (60, 'Pulsera Cadena Marina Maciza', 1),
    (61, 'Collar Gargantilla Perlas Cultivadas', 1),
    (62, 'Pulsera Tennis Circonias', 1),
    (63, 'Pulsera Charm Dijes de la Suerte', 2),
    (63, 'Alianza de Compromiso Lisa', 1),
    (64, 'Anillo Solitario Circonia', 1),
    (65, 'Anillo Corona Princesa', 1),
    (66, 'Cadena Eslabón Cubano 6mm', 1),
    (66, 'Pulsera Esclava Rígida', 1),
    (67, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (68, 'Pulsera Cuero Trenzado y Acero', 1),
    (69, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (69, 'Anillo Giratorio Antiestrés', 1),
    (70, 'Alianza de Compromiso Lisa', 2),
    (70, 'Collar Gargantilla Perlas Cultivadas', 1),
    (70, 'Pulsera Cuero Trenzado y Acero', 1),
    (71, 'Collar Corazón de Cristal', 1),
    (72, 'Collar Cadena de Bolitas', 1),
    (72, 'Pulsera Charm Dijes de la Suerte', 1),
    (73, 'Pulsera Esclava Rígida', 1),
    (74, 'Pulsera Cadena Marina Maciza', 1),
    (75, 'Anillo Sello Clásico', 1),
    (75, 'Cadena Eslabón Cubano 6mm', 1),
    (76, 'Anillo Giratorio Antiestrés', 1),
    (77, 'Collar Gargantilla Perlas Cultivadas', 2),
    (78, 'Pulsera Tennis Circonias', 1),
    (78, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (79, 'Pulsera Charm Dijes de la Suerte', 1),
    (80, 'Anillo Solitario Circonia', 1),
    (80, 'Collar Corazón de Cristal', 1),
    (80, 'Pulsera Tennis Circonias', 1),
    (81, 'Anillo Corona Princesa', 1),
    (81, 'Collar Cadena de Bolitas', 1),
    (82, 'Cadena Eslabón Cubano 6mm', 1),
    (83, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (84, 'Pulsera Cuero Trenzado y Acero', 2),
    (84, 'Anillo Sello Clásico', 1),
    (85, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (86, 'Alianza de Compromiso Lisa', 1),
    (87, 'Collar Corazón de Cristal', 1),
    (87, 'Pulsera Tennis Circonias', 1),
    (88, 'Collar Cadena de Bolitas', 1),
    (89, 'Pulsera Esclava Rígida', 1),
    (90, 'Pulsera Cadena Marina Maciza', 1),
    (90, 'Anillo Corona Princesa', 1),
    (90, 'Collar Cadena de Bolitas', 1),
    (91, 'Anillo Sello Clásico', 2),
    (92, 'Anillo Giratorio Antiestrés', 1),
    (93, 'Collar Gargantilla Perlas Cultivadas', 1),
    (93, 'Pulsera Cuero Trenzado y Acero', 1),
    (94, 'Pulsera Tennis Circonias', 1),
    (95, 'Pulsera Charm Dijes de la Suerte', 1),
    (96, 'Anillo Solitario Circonia', 1),
    (96, 'Collar Corazón de Cristal', 1),
    (97, 'Anillo Corona Princesa', 1),
    (98, 'Cadena Eslabón Cubano 6mm', 2),
    (99, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (99, 'Pulsera Cadena Marina Maciza', 1),
    (100, 'Pulsera Cuero Trenzado y Acero', 1),
    (100, 'Anillo Sello Clásico', 1),
    (100, 'Cadena Eslabón Cubano 6mm', 1),
    (101, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (102, 'Alianza de Compromiso Lisa', 1),
    (102, 'Collar Gargantilla Perlas Cultivadas', 1),
    (103, 'Collar Corazón de Cristal', 1),
    (104, 'Collar Cadena de Bolitas', 1),
    (105, 'Pulsera Esclava Rígida', 2),
    (105, 'Anillo Solitario Circonia', 1),
    (106, 'Pulsera Cadena Marina Maciza', 1),
    (107, 'Anillo Sello Clásico', 1),
    (108, 'Anillo Giratorio Antiestrés', 1),
    (108, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (109, 'Collar Gargantilla Perlas Cultivadas', 1),
    (110, 'Pulsera Tennis Circonias', 1),
    (110, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (110, 'Anillo Giratorio Antiestrés', 1),
    (111, 'Pulsera Charm Dijes de la Suerte', 1),
    (111, 'Alianza de Compromiso Lisa', 1),
    (112, 'Anillo Solitario Circonia', 2),
    (113, 'Anillo Corona Princesa', 1),
    (114, 'Cadena Eslabón Cubano 6mm', 1),
    (114, 'Pulsera Esclava Rígida', 1),
    (115, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (116, 'Pulsera Cuero Trenzado y Acero', 1),
    (117, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (117, 'Anillo Giratorio Antiestrés', 1),
    (118, 'Alianza de Compromiso Lisa', 1),
    (119, 'Collar Corazón de Cristal', 2),
    (120, 'Collar Cadena de Bolitas', 1),
    (120, 'Pulsera Charm Dijes de la Suerte', 1),
    (120, 'Alianza de Compromiso Lisa', 1),
    (121, 'Pulsera Esclava Rígida', 1),
    (122, 'Pulsera Cadena Marina Maciza', 1),
    (123, 'Anillo Sello Clásico', 1),
    (123, 'Cadena Eslabón Cubano 6mm', 1),
    (124, 'Anillo Giratorio Antiestrés', 1),
    (125, 'Collar Gargantilla Perlas Cultivadas', 1),
    (126, 'Pulsera Tennis Circonias', 2),
    (126, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (127, 'Pulsera Charm Dijes de la Suerte', 1),
    (128, 'Anillo Solitario Circonia', 1),
    (129, 'Anillo Corona Princesa', 1),
    (129, 'Collar Cadena de Bolitas', 1),
    (130, 'Cadena Eslabón Cubano 6mm', 1),
    (130, 'Pulsera Esclava Rígida', 1),
    (130, 'Anillo Solitario Circonia', 1),
    (131, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (132, 'Pulsera Cuero Trenzado y Acero', 1),
    (132, 'Anillo Sello Clásico', 1),
    (133, 'Pulsera Hilo Rojo Dije Infinito', 2),
    (134, 'Alianza de Compromiso Lisa', 1),
    (135, 'Collar Corazón de Cristal', 1),
    (135, 'Pulsera Tennis Circonias', 1),
    (136, 'Collar Cadena de Bolitas', 1),
    (137, 'Pulsera Esclava Rígida', 1),
    (138, 'Pulsera Cadena Marina Maciza', 1),
    (138, 'Anillo Corona Princesa', 1),
    (139, 'Anillo Sello Clásico', 1),
    (140, 'Anillo Giratorio Antiestrés', 2),
    (140, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (140, 'Pulsera Cadena Marina Maciza', 1),
    (141, 'Collar Gargantilla Perlas Cultivadas', 1),
    (141, 'Pulsera Cuero Trenzado y Acero', 1),
    (142, 'Pulsera Tennis Circonias', 1),
    (143, 'Pulsera Charm Dijes de la Suerte', 1),
    (144, 'Anillo Solitario Circonia', 1),
    (144, 'Collar Corazón de Cristal', 1),
    (145, 'Anillo Corona Princesa', 1),
    (146, 'Cadena Eslabón Cubano 6mm', 1),
    (147, 'Cadena Figaro 3x1 Oro Blanco', 2),
    (147, 'Pulsera Cadena Marina Maciza', 1),
    (148, 'Pulsera Cuero Trenzado y Acero', 1),
    (149, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (150, 'Alianza de Compromiso Lisa', 1),
    (150, 'Collar Gargantilla Perlas Cultivadas', 1),
    (150, 'Pulsera Cuero Trenzado y Acero', 1);

    DECLARE @TotalVentas INT = (SELECT COUNT(*) FROM #VentasLote);
    DECLARE @j INT = 1;

    WHILE @j <= @TotalVentas
    BEGIN
        DECLARE @FVenta DATETIME, @MedioPago INT, @DNICliente VARCHAR(20), @UsuarioVendedor INT;
        DECLARE @IdClienteEncontrado INT, @IdCondIVA INT, @TipoComp INT;
        DECLARE @IdComprobanteGenerado INT;

        SELECT 
            @FVenta = FechaComprobante,
            @MedioPago = IdMedioPago,
            @DNICliente = DNICUITCliente,
            @UsuarioVendedor = IdUsuario
        FROM #VentasLote
        WHERE IdLote = @j;

        -- 1. Buscar cliente por DNI/CUIT o fallback al primero
        SET @IdClienteEncontrado = NULL;
        SET @IdCondIVA = NULL;

        SELECT TOP 1 
            @IdClienteEncontrado = IdCliente, 
            @IdCondIVA = IdCondicionIVA 
        FROM Cliente 
        WHERE DNICUIT = @DNICliente;

        IF @IdClienteEncontrado IS NULL
        BEGIN
            SELECT TOP 1 
                @IdClienteEncontrado = IdCliente, 
                @IdCondIVA = IdCondicionIVA 
            FROM Cliente 
            ORDER BY IdCliente;
        END

        -- 2. Determinar Tipo de Comprobante según Condición de IVA (4 = Responsable Inscripto -> Factura A, sino Factura B)
        IF @IdCondIVA = 4
            SET @TipoComp = 1; -- Factura A
        ELSE
            SET @TipoComp = 2; -- Factura B

        -- 3. Insertar Cabecera de Comprobante
        INSERT INTO Comprobante (FechaComprobante, IdMedioPago, IdTipoComprobante, IdCliente, IdUsuario)
        VALUES (@FVenta, @MedioPago, @TipoComp, @IdClienteEncontrado, @UsuarioVendedor);
        SET @IdComprobanteGenerado = SCOPE_IDENTITY();

        -- 4. Insertar Detalles del Comprobante
        DECLARE @NomProd VARCHAR(100), @CantVendida INT;
        DECLARE @IdProdReal INT, @PrecioUnitReal DECIMAL(10,2);

        DECLARE curDetallesVenta CURSOR LOCAL FAST_FORWARD FOR
            SELECT NombreProducto, Cantidad
            FROM #DetallesVentaLote
            WHERE IdLote = @j;

        OPEN curDetallesVenta;
        FETCH NEXT FROM curDetallesVenta INTO @NomProd, @CantVendida;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @IdProdReal = NULL;
            SET @PrecioUnitReal = NULL;

            SELECT TOP 1 
                @IdProdReal = IdProducto, 
                @PrecioUnitReal = PrecioVenta 
            FROM Producto 
            WHERE NombreProducto = @NomProd;

            -- Fallback si el nombre cambió
            IF @IdProdReal IS NULL
            BEGIN
                SELECT TOP 1 
                    @IdProdReal = IdProducto, 
                    @PrecioUnitReal = PrecioVenta 
                FROM Producto 
                ORDER BY IdProducto;
            END

            INSERT INTO DetalleComprobante (IdComprobante, Cantidad, PrecioUnitario, IdProducto)
            VALUES (@IdComprobanteGenerado, @CantVendida, @PrecioUnitReal, @IdProdReal);

            FETCH NEXT FROM curDetallesVenta INTO @NomProd, @CantVendida;
        END

        CLOSE curDetallesVenta;
        DEALLOCATE curDetallesVenta;

        SET @j = @j + 1;
    END;

    DROP TABLE #DetallesVentaLote;
    DROP TABLE #VentasLote;

    PRINT '¡Lote de 150 ventas del año 2026 cargado exitosamente!';
END
ELSE
BEGIN
    PRINT 'El lote de ventas ya se encuentra cargado previamente en la base de datos.';
END
GO
