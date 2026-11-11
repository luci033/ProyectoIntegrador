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
-- 2.5 USUARIO VENDEDOR ADICIONAL (vendedor2 - Sofía Vendedora)
-- ==============================================================================
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE Usuario = 'vendedor2')
BEGIN
    INSERT INTO Usuarios (Usuario, NombreUsuario, ApellidoUsuario, Contrasena, Foto_Perfil, DNI, Telefono, Domicilio, IdRol, Activo)
    VALUES ('vendedor2', 'Sofía', 'Vendedora', '1234', 'rutapfp', '35891234', '3794558899', 'Av. 3 de Abril 850', 3, 1);
END
GO

-- ==============================================================================
-- 3. PRODUCTOS / JOYAS (36 JOYAS TOTALES - INCLUYE 8 CON STOCK CRÍTICO)
-- Inserta cada producto si no existe, o actualiza sus precios y stocks si ya existe
-- ==============================================================================
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Anillo Solitario Circonia')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Anillo Solitario Circonia', 26100.00, 18000.00, 15, 5, 'Anillo de plata 925 con piedra circonia cúbica engarzada en 4 garras.', 1, 45, 1, 1, 1);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 18000.00, MargenGanancia = 45, PrecioVenta = 26100.00, StockActual = 15, StockMinimo = 5, Estado = 1 WHERE NombreProducto = 'Anillo Solitario Circonia';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Anillo Sello Clásico')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Anillo Sello Clásico', 35000.00, 25000.00, 12, 4, 'Anillo sello en plata 925 maciza con frente rectangular pulido para grabado.', 1, 40, 2, 1, 3);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 25000.00, MargenGanancia = 40, PrecioVenta = 35000.00, StockActual = 12, StockMinimo = 4, Estado = 1 WHERE NombreProducto = 'Anillo Sello Clásico';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Alianza de Compromiso Lisa')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Alianza de Compromiso Lisa', 128250.00, 95000.00, 8, 3, 'Alianza clásica de oro blanco 18k, terminación pulida brillante, 4mm.', 1, 35, 3, 1, 4);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 95000.00, MargenGanancia = 35, PrecioVenta = 128250.00, StockActual = 8, StockMinimo = 3, Estado = 1 WHERE NombreProducto = 'Alianza de Compromiso Lisa';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Anillo Corona Princesa')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Anillo Corona Princesa', 33000.00, 22000.00, 18, 6, 'Anillo fantasía en plata 925 con micro pavé de circonias transparentes.', 1, 50, 1, 1, 2);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 22000.00, MargenGanancia = 50, PrecioVenta = 33000.00, StockActual = 18, StockMinimo = 6, Estado = 1 WHERE NombreProducto = 'Anillo Corona Princesa';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Anillo Giratorio Antiestrés')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Anillo Giratorio Antiestrés', 18000.00, 12000.00, 25, 8, 'Anillo de acero quirúrgico 316L con banda central giratoria texturada.', 1, 50, 3, 1, 5);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 12000.00, MargenGanancia = 50, PrecioVenta = 18000.00, StockActual = 25, StockMinimo = 8, Estado = 1 WHERE NombreProducto = 'Anillo Giratorio Antiestrés';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Collar Corazón de Cristal')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Collar Corazón de Cristal', 40600.00, 28000.00, 14, 6, 'Cadena de plata 925 de 45 cm con dije colgante corazón facetado.', 1, 45, 1, 3, 1);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 28000.00, MargenGanancia = 45, PrecioVenta = 40600.00, StockActual = 14, StockMinimo = 6, Estado = 1 WHERE NombreProducto = 'Collar Corazón de Cristal';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Cadena Eslabón Cubano 6mm')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Cadena Eslabón Cubano 6mm', 44800.00, 32000.00, 16, 5, 'Cadena tipo grumetta / eslabón cubano en acero quirúrgico 316L, 60 cm.', 1, 40, 2, 3, 4);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 32000.00, MargenGanancia = 40, PrecioVenta = 44800.00, StockActual = 16, StockMinimo = 5, Estado = 1 WHERE NombreProducto = 'Cadena Eslabón Cubano 6mm';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Collar Gargantilla Perlas Cultivadas')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Collar Gargantilla Perlas Cultivadas', 94250.00, 65000.00, 10, 3, 'Gargantilla clásica de perlas cultivadas de río con broche marinero de plata.', 1, 45, 1, 3, 3);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 65000.00, MargenGanancia = 45, PrecioVenta = 94250.00, StockActual = 10, StockMinimo = 3, Estado = 1 WHERE NombreProducto = 'Collar Gargantilla Perlas Cultivadas';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Collar Cadena de Bolitas')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Collar Cadena de Bolitas', 22500.00, 15000.00, 22, 10, 'Cadena estilo militar de bolitas en acero inoxidable 50 cm.', 1, 50, 3, 3, 2);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 15000.00, MargenGanancia = 50, PrecioVenta = 22500.00, StockActual = 22, StockMinimo = 10, Estado = 1 WHERE NombreProducto = 'Collar Cadena de Bolitas';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Cadena Figaro 3x1 Oro Blanco')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Cadena Figaro 3x1 Oro Blanco', 182000.00, 140000.00, 6, 4, 'Cadena Figaro 3x1 en oro blanco 18k, largo 55 cm, cierre mosquetón.', 1, 30, 2, 3, 1);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 140000.00, MargenGanancia = 30, PrecioVenta = 182000.00, StockActual = 6, StockMinimo = 4, Estado = 1 WHERE NombreProducto = 'Cadena Figaro 3x1 Oro Blanco';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Tennis Circonias')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Tennis Circonias', 65250.00, 45000.00, 14, 5, 'Pulsera Tennis en plata 925 con línea continua de piedras circonia de 3mm.', 1, 45, 1, 2, 3);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 45000.00, MargenGanancia = 45, PrecioVenta = 65250.00, StockActual = 14, StockMinimo = 5, Estado = 1 WHERE NombreProducto = 'Pulsera Tennis Circonias';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Esclava Rígida')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Esclava Rígida', 28000.00, 20000.00, 20, 7, 'Pulsera esclava rígida lisa en acero quirúrgico, terminación satinada.', 1, 40, 3, 2, 5);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 20000.00, MargenGanancia = 40, PrecioVenta = 28000.00, StockActual = 20, StockMinimo = 7, Estado = 1 WHERE NombreProducto = 'Pulsera Esclava Rígida';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Cuero Trenzado y Acero')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Cuero Trenzado y Acero', 24000.00, 16000.00, 18, 6, 'Brazalete de cuero genuino trenzado color negro con broche magnético de acero.', 1, 50, 2, 2, 4);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 16000.00, MargenGanancia = 50, PrecioVenta = 24000.00, StockActual = 18, StockMinimo = 6, Estado = 1 WHERE NombreProducto = 'Pulsera Cuero Trenzado y Acero';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Charm Dijes de la Suerte')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Charm Dijes de la Suerte', 55100.00, 38000.00, 12, 8, 'Pulsera de eslabones en plata 925 compatible con dijes y charms coleccionables.', 1, 45, 1, 2, 2);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 38000.00, MargenGanancia = 45, PrecioVenta = 55100.00, StockActual = 12, StockMinimo = 8, Estado = 1 WHERE NombreProducto = 'Pulsera Charm Dijes de la Suerte';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Cadena Marina Maciza')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Cadena Marina Maciza', 70200.00, 52000.00, 9, 4, 'Pulsera con eslabones tipo ancla / marina de 8mm en plata 925 maciza.', 1, 35, 2, 2, 1);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 52000.00, MargenGanancia = 35, PrecioVenta = 70200.00, StockActual = 9, StockMinimo = 4, Estado = 1 WHERE NombreProducto = 'Pulsera Cadena Marina Maciza';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Hilo Rojo Dije Infinito')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Hilo Rojo Dije Infinito', 12800.00, 8000.00, 30, 12, 'Pulsera de protección con hilo rojo regulable y dije central de infinito en plata 925.', 1, 60, 3, 2, 2);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 8000.00, MargenGanancia = 60, PrecioVenta = 12800.00, StockActual = 30, StockMinimo = 12, Estado = 1 WHERE NombreProducto = 'Pulsera Hilo Rojo Dije Infinito';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Anillo Cintillo Medio Sin Fin')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Anillo Cintillo Medio Sin Fin', 49300.00, 34000.00, 2, 6, 'Anillo medio sin fin en plata 925 con baño de rodio y circonias baguettes.', 1, 45, 1, 1, 1);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 34000.00, MargenGanancia = 45, PrecioVenta = 49300.00, StockActual = 2, StockMinimo = 6, Estado = 1 WHERE NombreProducto = 'Anillo Cintillo Medio Sin Fin';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Anillo Chevalier Ónix Negro')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Anillo Chevalier Ónix Negro', 58800.00, 42000.00, 11, 4, 'Anillo masculino de plata 925 con piedra ónix natural engarzada al ras.', 1, 40, 2, 1, 3);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 42000.00, MargenGanancia = 40, PrecioVenta = 58800.00, StockActual = 11, StockMinimo = 4, Estado = 1 WHERE NombreProducto = 'Anillo Chevalier Ónix Negro';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Alianza Bicolor Oro y Plata')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Alianza Bicolor Oro y Plata', 91800.00, 68000.00, 1, 5, 'Alianza de matrimonio combinada en plata 925 y lámina de oro 18k.', 1, 35, 3, 1, 4);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 68000.00, MargenGanancia = 35, PrecioVenta = 91800.00, StockActual = 1, StockMinimo = 5, Estado = 1 WHERE NombreProducto = 'Alianza Bicolor Oro y Plata';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Anillo Roseta Esmeralda Sintética')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Anillo Roseta Esmeralda Sintética', 43500.00, 29000.00, 14, 5, 'Anillo estilo imperial con piedra central verde esmeralda y halo brillante.', 1, 50, 1, 1, 2);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 29000.00, MargenGanancia = 50, PrecioVenta = 43500.00, StockActual = 14, StockMinimo = 5, Estado = 1 WHERE NombreProducto = 'Anillo Roseta Esmeralda Sintética';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Anillo Minimalista Entrelazado')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Anillo Minimalista Entrelazado', 21000.00, 14000.00, 3, 8, 'Anillo doble banda cruzada en acero blanco hipoalergénico.', 1, 50, 1, 1, 5);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 14000.00, MargenGanancia = 50, PrecioVenta = 21000.00, StockActual = 3, StockMinimo = 8, Estado = 1 WHERE NombreProducto = 'Anillo Minimalista Entrelazado';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Anillo Sello Imperial Grabado')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Anillo Sello Imperial Grabado', 43400.00, 31000.00, 9, 4, 'Anillo sello octogonal en plata 925 envejecida con guarda lateral.', 1, 40, 2, 1, 4);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 31000.00, MargenGanancia = 40, PrecioVenta = 43400.00, StockActual = 9, StockMinimo = 4, Estado = 1 WHERE NombreProducto = 'Anillo Sello Imperial Grabado';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Anillo Trenzado Nórdico')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Anillo Trenzado Nórdico', 27550.00, 19000.00, 16, 6, 'Anillo unisex de plata 925 con diseño de espiga trenzada artesanal.', 1, 45, 3, 1, 5);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 19000.00, MargenGanancia = 45, PrecioVenta = 27550.00, StockActual = 16, StockMinimo = 6, Estado = 1 WHERE NombreProducto = 'Anillo Trenzado Nórdico';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Collar Árbol de la Vida Nácar')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Collar Árbol de la Vida Nácar', 52200.00, 36000.00, 2, 5, 'Cadena veneciana de plata 925 con medallón de nácar y árbol calado.', 1, 45, 1, 3, 1);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 36000.00, MargenGanancia = 45, PrecioVenta = 52200.00, StockActual = 2, StockMinimo = 5, Estado = 1 WHERE NombreProducto = 'Collar Árbol de la Vida Nácar';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Cadena Rolo Marinera 50cm')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Cadena Rolo Marinera 50cm', 37800.00, 27000.00, 13, 5, 'Cadena eslabón rolo redondo en plata 925 italiana con cierre cajón.', 1, 40, 3, 3, 3);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 27000.00, MargenGanancia = 40, PrecioVenta = 37800.00, StockActual = 13, StockMinimo = 5, Estado = 1 WHERE NombreProducto = 'Cadena Rolo Marinera 50cm';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Collar Cruz Egipcia Ankh')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Collar Cruz Egipcia Ankh', 31500.00, 21000.00, 15, 6, 'Collar masculino en acero quirúrgico 316L con dije Cruz de la Vida.', 1, 50, 2, 3, 2);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 21000.00, MargenGanancia = 50, PrecioVenta = 31500.00, StockActual = 15, StockMinimo = 6, Estado = 1 WHERE NombreProducto = 'Collar Cruz Egipcia Ankh';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Gargantilla Choker Estrellas')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Gargantilla Choker Estrellas', 36000.00, 24000.00, 4, 6, 'Gargantilla corta de 38 cm en plata 925 con dijes colgantes de estrellas.', 1, 50, 1, 3, 2);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 24000.00, MargenGanancia = 50, PrecioVenta = 36000.00, StockActual = 4, StockMinimo = 6, Estado = 1 WHERE NombreProducto = 'Gargantilla Choker Estrellas';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Cadena Tourbillon Maciza 60cm')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Cadena Tourbillon Maciza 60cm', 78300.00, 58000.00, 8, 3, 'Cadena gruesa tejida tipo tourbillon en plata 925 de alta densidad.', 1, 35, 2, 3, 4);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 58000.00, MargenGanancia = 35, PrecioVenta = 78300.00, StockActual = 8, StockMinimo = 3, Estado = 1 WHERE NombreProducto = 'Cadena Tourbillon Maciza 60cm';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Collar Solitario Gota Zafiro')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Collar Solitario Gota Zafiro', 47850.00, 33000.00, 1, 4, 'Collar delicado en plata 925 con cristal azul zafiro en corte lágrima.', 1, 45, 1, 3, 1);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 33000.00, MargenGanancia = 45, PrecioVenta = 47850.00, StockActual = 1, StockMinimo = 4, Estado = 1 WHERE NombreProducto = 'Collar Solitario Gota Zafiro';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Cadena Singapur Torneada 45cm')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Cadena Singapur Torneada 45cm', 25500.00, 17000.00, 19, 7, 'Cadena tejido Singapur brillante en plata 925, ideal para dijes.', 1, 50, 1, 3, 3);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 17000.00, MargenGanancia = 50, PrecioVenta = 25500.00, StockActual = 19, StockMinimo = 7, Estado = 1 WHERE NombreProducto = 'Cadena Singapur Torneada 45cm';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Rolo con Corazón Candado')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Rolo con Corazón Candado', 59450.00, 41000.00, 3, 7, 'Pulsera clásica en plata 925 con eslabones rolo y broche corazón.', 1, 45, 1, 2, 3);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 41000.00, MargenGanancia = 45, PrecioVenta = 59450.00, StockActual = 3, StockMinimo = 7, Estado = 1 WHERE NombreProducto = 'Pulsera Rolo con Corazón Candado';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Eslabón Cubano Pavé')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Eslabón Cubano Pavé', 67200.00, 48000.00, 10, 4, 'Pulsera masculina tipo Miami Cuban Link con cierre engarzado en microcirconias.', 1, 40, 2, 2, 4);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 48000.00, MargenGanancia = 40, PrecioVenta = 67200.00, StockActual = 10, StockMinimo = 4, Estado = 1 WHERE NombreProducto = 'Pulsera Eslabón Cubano Pavé';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Rigida Cierre Tornillo')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Rigida Cierre Tornillo', 33350.00, 23000.00, 17, 6, 'Brazalete ovalado rígido en acero quirúrgico dorado con detalles grabados.', 1, 45, 1, 2, 5);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 23000.00, MargenGanancia = 45, PrecioVenta = 33350.00, StockActual = 17, StockMinimo = 6, Estado = 1 WHERE NombreProducto = 'Pulsera Rigida Cierre Tornillo';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Perlas de Río y Plata')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Perlas de Río y Plata', 56550.00, 39000.00, 2, 5, 'Pulsera artesanal de perlas cultivadas intercaladas con bolitas de plata 925.', 1, 45, 1, 2, 3);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 39000.00, MargenGanancia = 45, PrecioVenta = 56550.00, StockActual = 2, StockMinimo = 5, Estado = 1 WHERE NombreProducto = 'Pulsera Perlas de Río y Plata';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Acero y Caucho Náutico')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Acero y Caucho Náutico', 22500.00, 15000.00, 21, 8, 'Pulsera deportiva combinada en caucho siliconado negro y placa de acero.', 1, 50, 2, 2, 5);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 15000.00, MargenGanancia = 50, PrecioVenta = 22500.00, StockActual = 21, StockMinimo = 8, Estado = 1 WHERE NombreProducto = 'Pulsera Acero y Caucho Náutico';
END
IF NOT EXISTS (SELECT 1 FROM Producto WHERE NombreProducto = 'Pulsera Denario San Benito Plata')
BEGIN
    INSERT INTO [dbo].[Producto] ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [MargenGanancia], [IdGenero], [IdCategoria], [IdProveedor])
    VALUES ('Pulsera Denario San Benito Plata', 37700.00, 26000.00, 14, 5, 'Pulsera denario en plata 925 con cuentas de 4mm y medalla de San Benito.', 1, 45, 3, 2, 1);
END
ELSE
BEGIN
    UPDATE Producto SET PrecioCompra = 26000.00, MargenGanancia = 45, PrecioVenta = 37700.00, StockActual = 14, StockMinimo = 5, Estado = 1 WHERE NombreProducto = 'Pulsera Denario San Benito Plata';
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
-- ==============================================================================
SET NOCOUNT ON;

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
    (2, 9, 9, 15000.00, 50, 9),
    (2, 14, 19, 38000.00, 45, 19),
    (3, 11, 16, 45000.00, 45, 16),
    (4, 19, 15, 68000.00, 35, 15),
    (4, 22, 21, 31000.00, 40, 21),
    (5, 33, 6, 23000.00, 45, 6),
    (5, 35, 10, 15000.00, 50, 10),
    (6, 24, 11, 36000.00, 45, 11),
    (7, 27, 20, 24000.00, 50, 20),
    (7, 4, 14, 22000.00, 50, 14),
    (8, 34, 17, 39000.00, 45, 17),
    (8, 2, 13, 25000.00, 40, 13),
    (9, 7, 6, 32000.00, 40, 6),
    (10, 23, 21, 19000.00, 45, 21),
    (10, 33, 21, 23000.00, 45, 21),
    (11, 10, 18, 140000.00, 30, 18),
    (11, 15, 8, 52000.00, 35, 8),
    (12, 20, 21, 29000.00, 50, 21),
    (13, 25, 14, 27000.00, 40, 14),
    (13, 30, 24, 17000.00, 50, 24),
    (14, 32, 11, 48000.00, 40, 8),
    (14, 3, 13, 95000.00, 35, 10),
    (15, 21, 12, 14000.00, 50, 12),
    (16, 36, 5, 26000.00, 45, 5),
    (16, 1, 15, 18000.00, 45, 15),
    (17, 14, 24, 38000.00, 45, 24),
    (17, 16, 8, 8000.00, 60, 8),
    (18, 8, 15, 65000.00, 45, 15),
    (19, 22, 6, 31000.00, 40, 6),
    (19, 28, 18, 58000.00, 35, 18),
    (20, 12, 9, 20000.00, 40, 9),
    (20, 21, 7, 14000.00, 50, 7),
    (21, 17, 22, 34000.00, 45, 22),
    (22, 4, 19, 22000.00, 50, 19),
    (22, 9, 9, 15000.00, 50, 9),
    (23, 31, 16, 41000.00, 45, 16),
    (23, 34, 22, 39000.00, 45, 22),
    (24, 13, 23, 16000.00, 50, 23),
    (25, 5, 10, 12000.00, 50, 10),
    (25, 12, 24, 20000.00, 40, 24),
    (26, 6, 15, 28000.00, 45, 15),
    (26, 10, 23, 140000.00, 30, 23),
    (27, 26, 18, 21000.00, 50, 15),
    (28, 18, 5, 42000.00, 40, 5),
    (28, 25, 19, 27000.00, 40, 19),
    (29, 3, 18, 95000.00, 35, 18),
    (29, 7, 6, 32000.00, 40, 6),
    (30, 35, 5, 15000.00, 50, 5),
    (31, 29, 16, 33000.00, 45, 16),
    (31, 36, 10, 26000.00, 45, 10),
    (32, 16, 13, 8000.00, 60, 13),
    (32, 20, 21, 29000.00, 50, 21),
    (33, 2, 8, 25000.00, 40, 8),
    (34, 28, 23, 58000.00, 35, 23),
    (34, 32, 11, 48000.00, 40, 11),
    (35, 33, 16, 23000.00, 45, 16),
    (35, 35, 20, 15000.00, 50, 20),
    (36, 15, 23, 52000.00, 35, 23),
    (37, 9, 14, 15000.00, 50, 14),
    (37, 14, 24, 38000.00, 45, 24),
    (38, 30, 19, 17000.00, 50, 19),
    (38, 31, 21, 41000.00, 45, 21),
    (39, 19, 20, 68000.00, 35, 17),
    (40, 23, 11, 19000.00, 45, 11),
    (40, 33, 11, 23000.00, 45, 11),
    (41, 1, 10, 18000.00, 45, 10),
    (41, 6, 20, 28000.00, 45, 20),
    (42, 27, 5, 24000.00, 50, 5),
    (43, 11, 16, 45000.00, 45, 16),
    (43, 18, 10, 42000.00, 40, 10),
    (44, 7, 11, 32000.00, 40, 11),
    (44, 13, 23, 16000.00, 50, 23),
    (45, 21, 22, 14000.00, 50, 22),
    (46, 24, 11, 36000.00, 45, 11),
    (46, 29, 21, 33000.00, 45, 21),
    (47, 20, 6, 29000.00, 50, 6),
    (47, 26, 18, 21000.00, 50, 18),
    (48, 34, 17, 39000.00, 45, 17),
    (49, 32, 16, 48000.00, 40, 16),
    (49, 3, 18, 95000.00, 35, 18),
    (50, 12, 19, 20000.00, 40, 19),
    (50, 21, 17, 14000.00, 50, 17),
    (51, 10, 18, 140000.00, 30, 18),
    (52, 14, 9, 38000.00, 45, 6),
    (52, 16, 13, 8000.00, 60, 10),
    (53, 25, 14, 27000.00, 40, 14),
    (53, 30, 24, 17000.00, 50, 24),
    (54, 22, 11, 31000.00, 40, 11),
    (55, 5, 20, 12000.00, 50, 20),
    (55, 12, 14, 20000.00, 40, 14),
    (56, 36, 5, 26000.00, 45, 5),
    (56, 1, 15, 18000.00, 45, 15),
    (57, 4, 24, 22000.00, 50, 24),
    (58, 8, 15, 65000.00, 45, 15),
    (58, 11, 21, 45000.00, 45, 21),
    (59, 13, 8, 16000.00, 50, 8),
    (59, 19, 20, 68000.00, 35, 20),
    (60, 35, 15, 15000.00, 50, 15),
    (61, 17, 22, 34000.00, 45, 22),
    (61, 24, 16, 36000.00, 45, 16),
    (62, 26, 23, 21000.00, 50, 23),
    (62, 27, 5, 24000.00, 50, 5),
    (63, 31, 16, 41000.00, 45, 16),
    (64, 3, 23, 95000.00, 35, 23),
    (64, 7, 11, 32000.00, 40, 11),
    (65, 33, 6, 23000.00, 45, 6),
    (65, 35, 10, 15000.00, 50, 10),
    (66, 6, 15, 28000.00, 45, 15),
    (67, 16, 18, 8000.00, 60, 18),
    (67, 20, 6, 29000.00, 50, 6),
    (68, 18, 5, 42000.00, 40, 2),
    (68, 25, 19, 27000.00, 40, 16),
    (69, 28, 8, 58000.00, 35, 8),
    (70, 23, 21, 19000.00, 45, 21),
    (70, 33, 21, 23000.00, 45, 21),
    (71, 29, 16, 33000.00, 45, 16),
    (71, 36, 10, 26000.00, 45, 10),
    (72, 9, 19, 15000.00, 50, 19),
    (73, 2, 8, 25000.00, 40, 8),
    (73, 8, 20, 65000.00, 45, 20),
    (74, 19, 5, 68000.00, 35, 5),
    (74, 22, 11, 31000.00, 40, 11),
    (75, 21, 12, 14000.00, 50, 9),
    (76, 15, 23, 52000.00, 35, 23),
    (76, 17, 7, 34000.00, 45, 7),
    (77, 27, 10, 24000.00, 50, 10),
    (77, 4, 24, 22000.00, 50, 24),
    (78, 30, 19, 17000.00, 50, 19),
    (79, 7, 16, 32000.00, 40, 16),
    (79, 13, 8, 16000.00, 50, 8),
    (80, 12, 9, 20000.00, 40, 9),
    (80, 21, 7, 14000.00, 50, 7),
    (81, 1, 10, 18000.00, 45, 10),
    (82, 20, 11, 29000.00, 50, 11),
    (82, 26, 23, 21000.00, 50, 23),
    (83, 11, 16, 45000.00, 45, 16),
    (83, 18, 10, 42000.00, 40, 10),
    (84, 32, 21, 48000.00, 40, 21),
    (85, 5, 10, 12000.00, 50, 10),
    (85, 12, 24, 20000.00, 40, 24),
    (86, 24, 11, 36000.00, 45, 11),
    (86, 29, 21, 33000.00, 45, 21),
    (87, 14, 14, 38000.00, 45, 14),
    (88, 34, 17, 39000.00, 45, 14),
    (88, 2, 13, 25000.00, 40, 10),
    (89, 22, 16, 31000.00, 40, 0),
    (89, 28, 8, 58000.00, 35, 0),
    (90, 35, 5, 15000.00, 50, 0),
    (91, 10, 18, 140000.00, 30, 18),
    (91, 15, 8, 52000.00, 35, 8),
    (92, 4, 9, 22000.00, 50, 9),
    (92, 9, 19, 15000.00, 50, 19),
    (93, 25, 14, 27000.00, 40, 0),
    (94, 13, 13, 16000.00, 50, 0),
    (94, 19, 5, 68000.00, 35, 0),
    (95, 33, 16, 23000.00, 45, 0),
    (95, 35, 20, 15000.00, 50, 0),
    (96, 36, 5, 26000.00, 45, 0),
    (97, 26, 8, 21000.00, 50, 0),
    (97, 27, 10, 24000.00, 50, 0),
    (98, 8, 15, 65000.00, 45, 0),
    (98, 11, 21, 45000.00, 45, 0),
    (99, 3, 8, 95000.00, 35, 0),
    (100, 23, 11, 19000.00, 45, 0),
    (100, 33, 11, 23000.00, 45, 0);

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

        INSERT INTO Compra (FechaCompra, IdUsuario, IdProveedor, IdEstadoCompra)
        VALUES (@FCompra, @UEmisor, @Prov, @Estado);
        SET @IdCompraGenerada = SCOPE_IDENTITY();

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
            IF NOT EXISTS (SELECT 1 FROM Producto WHERE IdProducto = @IdProd)
                SELECT TOP 1 @IdProd = IdProducto FROM Producto ORDER BY IdProducto;

            INSERT INTO DetalleCompra (IdCompra, Cantidad, PrecioUnitario, MargenGanancia, IdProducto)
            VALUES (@IdCompraGenerada, @Cant, @PU, @Margen, @IdProd);
            SET @IdDetalleGenerado = SCOPE_IDENTITY();

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
GO

-- ==============================================================================
-- 6. LOTE INICIAL DE 150 VENTAS DISTRIBUIDAS A LO LARGO DEL AÑO 2026
-- ==============================================================================
SET NOCOUNT ON;

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
    (6, 'Alianza Bicolor Oro y Plata', 1),
    (6, 'Collar Árbol de la Vida Nácar', 1),
    (7, 'Anillo Sello Imperial Grabado', 2),
    (8, 'Cadena Rolo Marinera 50cm', 1),
    (9, 'Cadena Tourbillon Maciza 60cm', 1),
    (9, 'Pulsera Rigida Cierre Tornillo', 1),
    (10, 'Pulsera Rolo con Corazón Candado', 1),
    (10, 'Pulsera Denario San Benito Plata', 1),
    (10, 'Anillo Giratorio Antiestrés', 1),
    (11, 'Pulsera Perlas de Río y Plata', 1),
    (12, 'Anillo Solitario Circonia', 1),
    (12, 'Collar Corazón de Cristal', 1),
    (13, 'Anillo Corona Princesa', 1),
    (14, 'Cadena Eslabón Cubano 6mm', 2),
    (15, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (15, 'Pulsera Cadena Marina Maciza', 1),
    (16, 'Pulsera Cuero Trenzado y Acero', 1),
    (17, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (18, 'Alianza Bicolor Oro y Plata', 1),
    (18, 'Collar Árbol de la Vida Nácar', 1),
    (19, 'Anillo Sello Imperial Grabado', 1),
    (20, 'Cadena Rolo Marinera 50cm', 1),
    (20, 'Cadena Singapur Torneada 45cm', 1),
    (20, 'Pulsera Acero y Caucho Náutico', 1),
    (21, 'Cadena Tourbillon Maciza 60cm', 2),
    (21, 'Pulsera Rigida Cierre Tornillo', 1),
    (22, 'Pulsera Rolo con Corazón Candado', 1),
    (23, 'Pulsera Perlas de Río y Plata', 1),
    (24, 'Anillo Solitario Circonia', 1),
    (24, 'Collar Corazón de Cristal', 1),
    (25, 'Anillo Corona Princesa', 1),
    (26, 'Cadena Eslabón Cubano 6mm', 1),
    (27, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (27, 'Pulsera Cadena Marina Maciza', 1),
    (28, 'Pulsera Cuero Trenzado y Acero', 2),
    (29, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (30, 'Alianza Bicolor Oro y Plata', 1),
    (30, 'Collar Árbol de la Vida Nácar', 1),
    (30, 'Collar Solitario Gota Zafiro', 1),
    (31, 'Anillo Sello Imperial Grabado', 1),
    (32, 'Cadena Rolo Marinera 50cm', 1),
    (33, 'Cadena Tourbillon Maciza 60cm', 1),
    (33, 'Pulsera Rigida Cierre Tornillo', 1),
    (34, 'Pulsera Rolo con Corazón Candado', 1),
    (35, 'Pulsera Perlas de Río y Plata', 2),
    (36, 'Anillo Solitario Circonia', 1),
    (36, 'Collar Corazón de Cristal', 1),
    (37, 'Anillo Corona Princesa', 1),
    (38, 'Cadena Eslabón Cubano 6mm', 1),
    (39, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (39, 'Pulsera Cadena Marina Maciza', 1),
    (40, 'Pulsera Cuero Trenzado y Acero', 1),
    (40, 'Anillo Chevalier Ónix Negro', 1),
    (40, 'Anillo Trenzado Nórdico', 1),
    (41, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (42, 'Alianza Bicolor Oro y Plata', 2),
    (42, 'Collar Árbol de la Vida Nácar', 1),
    (43, 'Anillo Sello Imperial Grabado', 1),
    (44, 'Cadena Rolo Marinera 50cm', 1),
    (45, 'Cadena Tourbillon Maciza 60cm', 1),
    (45, 'Pulsera Rigida Cierre Tornillo', 1),
    (46, 'Pulsera Rolo con Corazón Candado', 1),
    (47, 'Pulsera Perlas de Río y Plata', 1),
    (48, 'Anillo Solitario Circonia', 1),
    (48, 'Collar Corazón de Cristal', 1),
    (49, 'Anillo Corona Princesa', 2),
    (50, 'Cadena Eslabón Cubano 6mm', 1),
    (50, 'Pulsera Esclava Rígida', 1),
    (50, 'Anillo Cintillo Medio Sin Fin', 1),
    (51, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (51, 'Pulsera Cadena Marina Maciza', 1),
    (52, 'Pulsera Cuero Trenzado y Acero', 1),
    (53, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (54, 'Alianza Bicolor Oro y Plata', 1),
    (54, 'Collar Árbol de la Vida Nácar', 1),
    (55, 'Anillo Sello Imperial Grabado', 1),
    (56, 'Cadena Rolo Marinera 50cm', 2),
    (57, 'Cadena Tourbillon Maciza 60cm', 1),
    (57, 'Pulsera Rigida Cierre Tornillo', 1),
    (58, 'Pulsera Rolo con Corazón Candado', 1),
    (59, 'Pulsera Perlas de Río y Plata', 1),
    (60, 'Anillo Solitario Circonia', 1),
    (60, 'Collar Corazón de Cristal', 1),
    (60, 'Pulsera Tennis Circonias', 1),
    (61, 'Anillo Corona Princesa', 1),
    (62, 'Cadena Eslabón Cubano 6mm', 1),
    (63, 'Cadena Figaro 3x1 Oro Blanco', 2),
    (63, 'Pulsera Cadena Marina Maciza', 1),
    (64, 'Pulsera Cuero Trenzado y Acero', 1),
    (65, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (66, 'Alianza Bicolor Oro y Plata', 1),
    (66, 'Collar Árbol de la Vida Nácar', 1),
    (67, 'Anillo Sello Imperial Grabado', 1),
    (68, 'Cadena Rolo Marinera 50cm', 1),
    (69, 'Cadena Tourbillon Maciza 60cm', 1),
    (69, 'Pulsera Rigida Cierre Tornillo', 1),
    (70, 'Pulsera Rolo con Corazón Candado', 2),
    (70, 'Pulsera Denario San Benito Plata', 1),
    (70, 'Anillo Giratorio Antiestrés', 1),
    (71, 'Pulsera Perlas de Río y Plata', 1),
    (72, 'Anillo Solitario Circonia', 1),
    (72, 'Collar Corazón de Cristal', 1),
    (73, 'Anillo Corona Princesa', 1),
    (74, 'Cadena Eslabón Cubano 6mm', 1),
    (75, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (75, 'Pulsera Cadena Marina Maciza', 1),
    (76, 'Pulsera Cuero Trenzado y Acero', 1),
    (77, 'Pulsera Hilo Rojo Dije Infinito', 2),
    (78, 'Alianza Bicolor Oro y Plata', 1),
    (78, 'Collar Árbol de la Vida Nácar', 1),
    (79, 'Anillo Sello Imperial Grabado', 1),
    (80, 'Cadena Rolo Marinera 50cm', 1),
    (80, 'Cadena Singapur Torneada 45cm', 1),
    (80, 'Pulsera Acero y Caucho Náutico', 1),
    (81, 'Cadena Tourbillon Maciza 60cm', 1),
    (81, 'Pulsera Rigida Cierre Tornillo', 1),
    (82, 'Pulsera Rolo con Corazón Candado', 1),
    (83, 'Pulsera Perlas de Río y Plata', 1),
    (84, 'Anillo Solitario Circonia', 2),
    (84, 'Collar Corazón de Cristal', 1),
    (85, 'Anillo Corona Princesa', 1),
    (86, 'Cadena Eslabón Cubano 6mm', 1),
    (87, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (87, 'Pulsera Cadena Marina Maciza', 1),
    (88, 'Pulsera Cuero Trenzado y Acero', 1),
    (89, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (90, 'Alianza Bicolor Oro y Plata', 1),
    (90, 'Collar Árbol de la Vida Nácar', 1),
    (90, 'Collar Solitario Gota Zafiro', 1),
    (91, 'Anillo Sello Imperial Grabado', 2),
    (92, 'Cadena Rolo Marinera 50cm', 1),
    (93, 'Cadena Tourbillon Maciza 60cm', 1),
    (93, 'Pulsera Rigida Cierre Tornillo', 1),
    (94, 'Pulsera Rolo con Corazón Candado', 1),
    (95, 'Pulsera Perlas de Río y Plata', 1),
    (96, 'Anillo Solitario Circonia', 1),
    (96, 'Collar Corazón de Cristal', 1),
    (97, 'Anillo Corona Princesa', 1),
    (98, 'Cadena Eslabón Cubano 6mm', 2),
    (99, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (99, 'Pulsera Cadena Marina Maciza', 1),
    (100, 'Pulsera Cuero Trenzado y Acero', 1),
    (100, 'Anillo Chevalier Ónix Negro', 1),
    (100, 'Anillo Trenzado Nórdico', 1),
    (101, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (102, 'Alianza Bicolor Oro y Plata', 1),
    (102, 'Collar Árbol de la Vida Nácar', 1),
    (103, 'Anillo Sello Imperial Grabado', 1),
    (104, 'Cadena Rolo Marinera 50cm', 1),
    (105, 'Cadena Tourbillon Maciza 60cm', 2),
    (105, 'Pulsera Rigida Cierre Tornillo', 1),
    (106, 'Pulsera Rolo con Corazón Candado', 1),
    (107, 'Pulsera Perlas de Río y Plata', 1),
    (108, 'Anillo Solitario Circonia', 1),
    (108, 'Collar Corazón de Cristal', 1),
    (109, 'Anillo Corona Princesa', 1),
    (110, 'Cadena Eslabón Cubano 6mm', 1),
    (110, 'Pulsera Esclava Rígida', 1),
    (110, 'Anillo Cintillo Medio Sin Fin', 1),
    (111, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (111, 'Pulsera Cadena Marina Maciza', 1),
    (112, 'Pulsera Cuero Trenzado y Acero', 2),
    (113, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (114, 'Alianza Bicolor Oro y Plata', 1),
    (114, 'Collar Árbol de la Vida Nácar', 1),
    (115, 'Anillo Sello Imperial Grabado', 1),
    (116, 'Cadena Rolo Marinera 50cm', 1),
    (117, 'Cadena Tourbillon Maciza 60cm', 1),
    (117, 'Pulsera Rigida Cierre Tornillo', 1),
    (118, 'Pulsera Rolo con Corazón Candado', 1),
    (119, 'Pulsera Perlas de Río y Plata', 2),
    (120, 'Anillo Solitario Circonia', 1),
    (120, 'Collar Corazón de Cristal', 1),
    (120, 'Pulsera Tennis Circonias', 1),
    (121, 'Anillo Corona Princesa', 1),
    (122, 'Cadena Eslabón Cubano 6mm', 1),
    (123, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (123, 'Pulsera Cadena Marina Maciza', 1),
    (124, 'Pulsera Cuero Trenzado y Acero', 1),
    (125, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (126, 'Alianza Bicolor Oro y Plata', 2),
    (126, 'Collar Árbol de la Vida Nácar', 1),
    (127, 'Anillo Sello Imperial Grabado', 1),
    (128, 'Cadena Rolo Marinera 50cm', 1),
    (129, 'Cadena Tourbillon Maciza 60cm', 1),
    (129, 'Pulsera Rigida Cierre Tornillo', 1),
    (130, 'Pulsera Rolo con Corazón Candado', 1),
    (130, 'Pulsera Denario San Benito Plata', 1),
    (130, 'Anillo Giratorio Antiestrés', 1),
    (131, 'Pulsera Perlas de Río y Plata', 1),
    (132, 'Anillo Solitario Circonia', 1),
    (132, 'Collar Corazón de Cristal', 1),
    (133, 'Anillo Corona Princesa', 2),
    (134, 'Cadena Eslabón Cubano 6mm', 1),
    (135, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (135, 'Pulsera Cadena Marina Maciza', 1),
    (136, 'Pulsera Cuero Trenzado y Acero', 1),
    (137, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (138, 'Alianza Bicolor Oro y Plata', 1),
    (138, 'Collar Árbol de la Vida Nácar', 1),
    (139, 'Anillo Sello Imperial Grabado', 1),
    (140, 'Cadena Rolo Marinera 50cm', 2),
    (140, 'Cadena Singapur Torneada 45cm', 1),
    (140, 'Pulsera Acero y Caucho Náutico', 1),
    (141, 'Cadena Tourbillon Maciza 60cm', 1),
    (141, 'Pulsera Rigida Cierre Tornillo', 1),
    (142, 'Pulsera Rolo con Corazón Candado', 1),
    (143, 'Pulsera Perlas de Río y Plata', 1),
    (144, 'Anillo Solitario Circonia', 1),
    (144, 'Collar Corazón de Cristal', 1),
    (145, 'Anillo Corona Princesa', 1),
    (146, 'Cadena Eslabón Cubano 6mm', 1),
    (147, 'Cadena Figaro 3x1 Oro Blanco', 2),
    (147, 'Pulsera Cadena Marina Maciza', 1),
    (148, 'Pulsera Cuero Trenzado y Acero', 1),
    (149, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (150, 'Alianza Bicolor Oro y Plata', 1),
    (150, 'Collar Árbol de la Vida Nácar', 1),
    (150, 'Collar Solitario Gota Zafiro', 1);

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

        IF @IdCondIVA = 4
            SET @TipoComp = 1;
        ELSE
            SET @TipoComp = 2;

        INSERT INTO Comprobante (FechaComprobante, IdMedioPago, IdTipoComprobante, IdCliente, IdUsuario)
        VALUES (@FVenta, @MedioPago, @TipoComp, @IdClienteEncontrado, @UsuarioVendedor);
        SET @IdComprobanteGenerado = SCOPE_IDENTITY();

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

    PRINT '¡Lote inicial de 150 ventas del año 2026 cargado exitosamente!';
END
GO

-- ==============================================================================
-- 7. LOTE DE 70 VENTAS DEL NUEVO VENDEDOR (vendedor2 - Sofía Vendedora) EN 2026
-- ==============================================================================
SET NOCOUNT ON;

DECLARE @IdVendedorNuevo INT = (SELECT TOP 1 IdUsuario FROM Usuarios WHERE Usuario = 'vendedor2');
IF @IdVendedorNuevo IS NULL
    SET @IdVendedorNuevo = 3;

IF (SELECT COUNT(*) FROM Comprobante WHERE IdUsuario = @IdVendedorNuevo) < 10
BEGIN
    IF OBJECT_ID('tempdb..#VentasV2Lote') IS NOT NULL DROP TABLE #VentasV2Lote;
    IF OBJECT_ID('tempdb..#DetallesVentaV2Lote') IS NOT NULL DROP TABLE #DetallesVentaV2Lote;

    CREATE TABLE #VentasV2Lote (
        IdLote INT PRIMARY KEY,
        FechaComprobante DATETIME NOT NULL,
        IdMedioPago INT NOT NULL,
        DNICUITCliente VARCHAR(20) NOT NULL
    );

    CREATE TABLE #DetallesVentaV2Lote (
        IdLote INT NOT NULL,
        NombreProducto VARCHAR(100) NOT NULL,
        Cantidad INT NOT NULL
    );

    INSERT INTO #VentasV2Lote (IdLote, FechaComprobante, IdMedioPago, DNICUITCliente) VALUES
    (1, '2026-01-03 11:17:00', 2, '20358941203'),
    (2, '2026-01-08 12:34:00', 1, '20412304561'),
    (3, '2026-01-13 13:51:00', 2, '36952147'),
    (4, '2026-01-18 14:13:00', 1, '34562189'),
    (5, '2026-01-24 15:30:00', 2, '20339874562'),
    (6, '2026-01-29 16:47:00', 1, '37410258'),
    (7, '2026-02-03 17:09:00', 2, '35964123'),
    (8, '2026-02-07 18:26:00', 3, '38452109'),
    (9, '2026-02-12 19:43:00', 2, '42105698'),
    (10, '2026-02-17 10:05:00', 1, '39784512'),
    (11, '2026-02-22 11:22:00', 2, '27376541234'),
    (12, '2026-02-26 12:39:00', 1, '40123987'),
    (13, '2026-03-03 13:01:00', 2, '41852963'),
    (14, '2026-03-06 14:18:00', 1, '27436521478'),
    (15, '2026-03-11 15:35:00', 2, '27361245890'),
    (16, '2026-03-15 16:52:00', 3, '20358941203'),
    (17, '2026-03-20 17:14:00', 2, '20412304561'),
    (18, '2026-03-24 18:31:00', 1, '36952147'),
    (19, '2026-03-28 19:48:00', 2, '34562189'),
    (20, '2026-04-03 10:10:00', 1, '20339874562'),
    (21, '2026-04-08 11:27:00', 2, '37410258'),
    (22, '2026-04-13 12:44:00', 1, '35964123'),
    (23, '2026-04-17 13:06:00', 2, '38452109'),
    (24, '2026-04-22 14:23:00', 3, '42105698'),
    (25, '2026-04-27 15:40:00', 2, '39784512'),
    (26, '2026-05-03 16:02:00', 1, '27376541234'),
    (27, '2026-05-06 17:19:00', 2, '40123987'),
    (28, '2026-05-11 18:36:00', 1, '41852963'),
    (29, '2026-05-15 19:53:00', 2, '27436521478'),
    (30, '2026-05-21 10:15:00', 1, '27361245890'),
    (31, '2026-05-26 11:32:00', 2, '20358941203'),
    (32, '2026-05-29 12:49:00', 3, '20412304561'),
    (33, '2026-06-02 13:11:00', 2, '36952147'),
    (34, '2026-06-07 14:28:00', 1, '34562189'),
    (35, '2026-06-11 15:45:00', 2, '20339874562'),
    (36, '2026-06-16 16:07:00', 1, '37410258'),
    (37, '2026-06-21 17:24:00', 2, '35964123'),
    (38, '2026-06-26 18:41:00', 1, '38452109'),
    (39, '2026-07-02 19:03:00', 2, '42105698'),
    (40, '2026-07-07 10:20:00', 3, '39784512'),
    (41, '2026-07-12 11:37:00', 2, '27376541234'),
    (42, '2026-07-16 12:54:00', 1, '40123987'),
    (43, '2026-07-21 13:16:00', 2, '41852963'),
    (44, '2026-07-25 14:33:00', 1, '27436521478'),
    (45, '2026-07-30 15:50:00', 2, '27361245890'),
    (46, '2026-08-02 16:12:00', 1, '20358941203'),
    (47, '2026-08-06 17:29:00', 2, '20412304561'),
    (48, '2026-08-11 18:46:00', 3, '36952147'),
    (49, '2026-08-15 19:08:00', 2, '34562189'),
    (50, '2026-08-20 10:25:00', 1, '20339874562'),
    (51, '2026-08-25 11:42:00', 2, '37410258'),
    (52, '2026-08-30 12:04:00', 1, '35964123'),
    (53, '2026-09-02 13:21:00', 2, '38452109'),
    (54, '2026-09-07 14:38:00', 1, '42105698'),
    (55, '2026-09-11 15:00:00', 2, '39784512'),
    (56, '2026-09-16 16:17:00', 3, '27376541234'),
    (57, '2026-09-22 17:34:00', 2, '40123987'),
    (58, '2026-09-27 18:51:00', 1, '41852963'),
    (59, '2026-10-02 19:13:00', 2, '27436521478'),
    (60, '2026-10-06 10:30:00', 1, '27361245890'),
    (61, '2026-10-10 11:47:00', 2, '20358941203'),
    (62, '2026-10-15 12:09:00', 1, '20412304561'),
    (63, '2026-10-20 13:26:00', 2, '36952147'),
    (64, '2026-10-24 14:43:00', 3, '34562189'),
    (65, '2026-10-29 15:05:00', 2, '20339874562'),
    (66, '2026-11-02 16:22:00', 1, '37410258'),
    (67, '2026-11-04 17:39:00', 2, '35964123'),
    (68, '2026-11-06 18:01:00', 1, '38452109'),
    (69, '2026-11-08 19:18:00', 2, '42105698'),
    (70, '2026-11-10 10:35:00', 1, '39784512');

    INSERT INTO #DetallesVentaV2Lote (IdLote, NombreProducto, Cantidad) VALUES
    (1, 'Collar Corazón de Cristal', 1),
    (2, 'Pulsera Tennis Circonias', 1),
    (3, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (3, 'Anillo Trenzado Nórdico', 1),
    (4, 'Anillo Minimalista Entrelazado', 1),
    (5, 'Collar Cruz Egipcia Ankh', 1),
    (6, 'Pulsera Rolo con Corazón Candado', 2),
    (6, 'Anillo Sello Clásico', 1),
    (7, 'Pulsera Denario San Benito Plata', 1),
    (8, 'Anillo Giratorio Antiestrés', 1),
    (9, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (9, 'Anillo Cintillo Medio Sin Fin', 1),
    (9, 'Collar Árbol de la Vida Nácar', 1),
    (10, 'Pulsera Cadena Marina Maciza', 1),
    (11, 'Anillo Roseta Esmeralda Sintética', 1),
    (12, 'Cadena Rolo Marinera 50cm', 2),
    (12, 'Pulsera Eslabón Cubano Pavé', 1),
    (13, 'Cadena Singapur Torneada 45cm', 1),
    (14, 'Pulsera Acero y Caucho Náutico', 1),
    (15, 'Anillo Corona Princesa', 1),
    (15, 'Pulsera Tennis Circonias', 1),
    (16, 'Collar Cadena de Bolitas', 1),
    (17, 'Pulsera Charm Dijes de la Suerte', 1),
    (18, 'Alianza Bicolor Oro y Plata', 2),
    (18, 'Collar Cruz Egipcia Ankh', 1),
    (18, 'Pulsera Rigida Cierre Tornillo', 1),
    (19, 'Collar Árbol de la Vida Nácar', 1),
    (20, 'Collar Solitario Gota Zafiro', 1),
    (21, 'Pulsera Perlas de Río y Plata', 1),
    (21, 'Anillo Giratorio Antiestrés', 1),
    (22, 'Alianza de Compromiso Lisa', 1),
    (23, 'Collar Gargantilla Perlas Cultivadas', 1),
    (24, 'Pulsera Cuero Trenzado y Acero', 2),
    (24, 'Anillo Roseta Esmeralda Sintética', 1),
    (25, 'Anillo Chevalier Ónix Negro', 1),
    (26, 'Anillo Trenzado Nórdico', 1),
    (27, 'Cadena Tourbillon Maciza 60cm', 1),
    (27, 'Pulsera Acero y Caucho Náutico', 1),
    (27, 'Collar Corazón de Cristal', 1),
    (28, 'Pulsera Rigida Cierre Tornillo', 1),
    (29, 'Anillo Sello Clásico', 1),
    (30, 'Cadena Eslabón Cubano 6mm', 2),
    (30, 'Pulsera Charm Dijes de la Suerte', 1),
    (31, 'Pulsera Esclava Rígida', 1),
    (32, 'Anillo Cintillo Medio Sin Fin', 1),
    (33, 'Anillo Sello Imperial Grabado', 1),
    (33, 'Collar Solitario Gota Zafiro', 1),
    (34, 'Gargantilla Choker Estrellas', 1),
    (35, 'Pulsera Eslabón Cubano Pavé', 1),
    (36, 'Anillo Solitario Circonia', 2),
    (36, 'Collar Gargantilla Perlas Cultivadas', 1),
    (36, 'Pulsera Cadena Marina Maciza', 1),
    (37, 'Collar Corazón de Cristal', 1),
    (38, 'Pulsera Tennis Circonias', 1),
    (39, 'Pulsera Hilo Rojo Dije Infinito', 1),
    (39, 'Anillo Trenzado Nórdico', 1),
    (40, 'Anillo Minimalista Entrelazado', 1),
    (41, 'Collar Cruz Egipcia Ankh', 1),
    (42, 'Pulsera Rolo con Corazón Candado', 2),
    (42, 'Anillo Sello Clásico', 1),
    (43, 'Pulsera Denario San Benito Plata', 1),
    (44, 'Anillo Giratorio Antiestrés', 1),
    (45, 'Cadena Figaro 3x1 Oro Blanco', 1),
    (45, 'Anillo Cintillo Medio Sin Fin', 1),
    (45, 'Collar Árbol de la Vida Nácar', 1),
    (46, 'Pulsera Cadena Marina Maciza', 1),
    (47, 'Anillo Roseta Esmeralda Sintética', 1),
    (48, 'Cadena Rolo Marinera 50cm', 2),
    (48, 'Pulsera Eslabón Cubano Pavé', 1),
    (49, 'Cadena Singapur Torneada 45cm', 1),
    (50, 'Pulsera Acero y Caucho Náutico', 1),
    (51, 'Anillo Corona Princesa', 1),
    (51, 'Pulsera Tennis Circonias', 1),
    (52, 'Collar Cadena de Bolitas', 1),
    (53, 'Pulsera Charm Dijes de la Suerte', 1),
    (54, 'Alianza Bicolor Oro y Plata', 2),
    (54, 'Collar Cruz Egipcia Ankh', 1),
    (54, 'Pulsera Rigida Cierre Tornillo', 1),
    (55, 'Collar Árbol de la Vida Nácar', 1),
    (56, 'Collar Solitario Gota Zafiro', 1),
    (57, 'Pulsera Perlas de Río y Plata', 1),
    (57, 'Anillo Giratorio Antiestrés', 1),
    (58, 'Alianza de Compromiso Lisa', 1),
    (59, 'Collar Gargantilla Perlas Cultivadas', 1),
    (60, 'Pulsera Cuero Trenzado y Acero', 2),
    (60, 'Anillo Roseta Esmeralda Sintética', 1),
    (61, 'Anillo Chevalier Ónix Negro', 1),
    (62, 'Anillo Trenzado Nórdico', 1),
    (63, 'Cadena Tourbillon Maciza 60cm', 1),
    (63, 'Pulsera Acero y Caucho Náutico', 1),
    (63, 'Collar Corazón de Cristal', 1),
    (64, 'Pulsera Rigida Cierre Tornillo', 1),
    (65, 'Anillo Sello Clásico', 1),
    (66, 'Cadena Eslabón Cubano 6mm', 2),
    (66, 'Pulsera Charm Dijes de la Suerte', 1),
    (67, 'Pulsera Esclava Rígida', 1),
    (68, 'Anillo Cintillo Medio Sin Fin', 1),
    (69, 'Anillo Sello Imperial Grabado', 1),
    (69, 'Collar Solitario Gota Zafiro', 1),
    (70, 'Gargantilla Choker Estrellas', 1);

    DECLARE @TotalVentasV2 INT = (SELECT COUNT(*) FROM #VentasV2Lote);
    DECLARE @k INT = 1;

    WHILE @k <= @TotalVentasV2
    BEGIN
        DECLARE @FVenta2 DATETIME, @MedioPago2 INT, @DNICliente2 VARCHAR(20);
        DECLARE @IdClienteEncontrado2 INT, @IdCondIVA2 INT, @TipoComp2 INT;
        DECLARE @IdComprobanteGenerado2 INT;

        SELECT 
            @FVenta2 = FechaComprobante,
            @MedioPago2 = IdMedioPago,
            @DNICliente2 = DNICUITCliente
        FROM #VentasV2Lote
        WHERE IdLote = @k;

        SET @IdClienteEncontrado2 = NULL;
        SET @IdCondIVA2 = NULL;

        SELECT TOP 1 
            @IdClienteEncontrado2 = IdCliente, 
            @IdCondIVA2 = IdCondicionIVA 
        FROM Cliente 
        WHERE DNICUIT = @DNICliente2;

        IF @IdClienteEncontrado2 IS NULL
        BEGIN
            SELECT TOP 1 
                @IdClienteEncontrado2 = IdCliente, 
                @IdCondIVA2 = IdCondicionIVA 
            FROM Cliente 
            ORDER BY IdCliente;
        END

        IF @IdCondIVA2 = 4
            SET @TipoComp2 = 1;
        ELSE
            SET @TipoComp2 = 2;

        INSERT INTO Comprobante (FechaComprobante, IdMedioPago, IdTipoComprobante, IdCliente, IdUsuario)
        VALUES (@FVenta2, @MedioPago2, @TipoComp2, @IdClienteEncontrado2, @IdVendedorNuevo);
        SET @IdComprobanteGenerado2 = SCOPE_IDENTITY();

        DECLARE @NomProd2 VARCHAR(100), @CantVendida2 INT;
        DECLARE @IdProdReal2 INT, @PrecioUnitReal2 DECIMAL(10,2);

        DECLARE curDetallesVenta2 CURSOR LOCAL FAST_FORWARD FOR
            SELECT NombreProducto, Cantidad
            FROM #DetallesVentaV2Lote
            WHERE IdLote = @k;

        OPEN curDetallesVenta2;
        FETCH NEXT FROM curDetallesVenta2 INTO @NomProd2, @CantVendida2;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @IdProdReal2 = NULL;
            SET @PrecioUnitReal2 = NULL;

            SELECT TOP 1 
                @IdProdReal2 = IdProducto, 
                @PrecioUnitReal2 = PrecioVenta 
            FROM Producto 
            WHERE NombreProducto = @NomProd2;

            IF @IdProdReal2 IS NULL
            BEGIN
                SELECT TOP 1 
                    @IdProdReal2 = IdProducto, 
                    @PrecioUnitReal2 = PrecioVenta 
                FROM Producto 
                ORDER BY IdProducto;
            END

            INSERT INTO DetalleComprobante (IdComprobante, Cantidad, PrecioUnitario, IdProducto)
            VALUES (@IdComprobanteGenerado2, @CantVendida2, @PrecioUnitReal2, @IdProdReal2);

            FETCH NEXT FROM curDetallesVenta2 INTO @NomProd2, @CantVendida2;
        END

        CLOSE curDetallesVenta2;
        DEALLOCATE curDetallesVenta2;

        SET @k = @k + 1;
    END;

    DROP TABLE #DetallesVentaV2Lote;
    DROP TABLE #VentasV2Lote;

    PRINT '¡Lote de 70 ventas del nuevo vendedor (vendedor2) cargado exitosamente!';
END
GO
