USE [JoyeriaALBADB];
GO


INSERT INTO Proveedor (RazonSocial, CUIT, Telefono, CorreoElectronico) VALUES
('Oro Blanco Joyerías SRL', '30714791067', '3794159864', 'oroblanco@joyas.com.ar'),
('Joias Joyas & Piercings', '30717801365', '3794976415', 'joyas@mail.com'),
('Joyerías Verdi S.R.L.', '30714973289', '3794787185', 'verdijoyeria@gmail.com'),
('Aníbal Caruso e Hijos S.R.L.', '30503460609', '3794676767', 'anibalJoyas@mail.com'),
('Cámara Argentina de Joyería, Relojería y Afines', '30678823534', '1192465791', 'camarajoyeria@mail.com.ar');

INSERT INTO Categoria (NombreCategoria) VALUES
('Anillos'),
('Pulseras'),
('Collares');




INSERT INTO [dbo].[Producto] 
    ([NombreProducto], [PrecioVenta], [PrecioCompra], [StockActual], [StockMinimo], [Descripcion], [Estado], [IdGenero], [IdCategoria], [IdProveedor])
VALUES
    -- 1. Anillos (IdCategoria: 1)
    ('Anillo Solitario Circonia', NULL, NULL, 0, 5, 'Anillo de plata 925 con piedra circonia cúbica engarzada en 4 garras.', 1, 1, 1, 1),
    ('Anillo Sello Clásico', NULL, NULL, 0, 4, 'Anillo sello en plata 925 maciza con frente rectangular pulido para grabado.', 1, 2, 1, 3),
    ('Alianza de Compromiso Lisa', NULL, NULL, 0, 10, 'Alianza clásica de oro blanco 18k, terminación pulida brillante, 4mm.', 1, 3, 1, 4),
    ('Anillo Corona Princesa', NULL, NULL, 0, 6, 'Anillo fantasía en plata 925 con micro pavé de circonias transparentes.', 1, 1, 1, 2),
    ('Anillo Giratorio Antiestrés', NULL, NULL, 0, 8, 'Anillo de acero quirúrgico 316L con banda central giratoria texturada.', 1, 3, 1, 5),

    -- 2. Collares (IdCategoria: 3)
    ('Collar Corazón de Cristal', NULL, NULL, 0, 6, 'Cadena de plata 925 de 45 cm con dije colgante corazón facetado.', 1, 1, 3, 1),
    ('Cadena Eslabón Cubano 6mm', NULL, NULL, 0, 5, 'Cadena tipo grumetta / eslabón cubano en acero quirúrgico 316L, 60 cm.', 1, 2, 3, 4),
    ('Collar Gargantilla Perlas Cultivadas', NULL, NULL, 0, 3, 'Gargantilla clásica de perlas cultivadas de río con broche marinero de plata.', 1, 1, 3, 3),
    ('Collar Cadena de Bolitas', NULL, NULL, 0, 10, 'Cadena estilo militar de bolitas en acero inoxidable 50 cm.', 1, 3, 3, 2),
    ('Cadena Figaro 3x1 Oro Blanco', NULL, NULL, 0, 4, 'Cadena Figaro 3x1 en oro blanco 18k, largo 55 cm, cierre mosquetón.', 1, 2, 3, 1),

    -- 3. Pulseras (IdCategoria: 2)
    ('Pulsera Tennis Circonias', NULL, NULL, 0, 5, 'Pulsera Tennis en plata 925 con línea continua de piedras circonia de 3mm.', 1, 1, 2, 3),
    ('Pulsera Esclava Rígida', NULL, NULL, 0, 7, 'Pulsera esclava rígida lisa en acero quirúrgico, terminación satinada.', 1, 3, 2, 5),
    ('Pulsera Cuero Trenzado y Acero', NULL, NULL, 0, 6, 'Brazalete de cuero genuino trenzado color negro con broche magnético de acero.', 1, 2, 2, 4),
    ('Pulsera Charm Dijes de la Suerte', NULL, NULL, 0, 8, 'Pulsera de eslabones en plata 925 compatible con dijes y charms coleccionables.', 1, 1, 2, 2),
    ('Pulsera Cadena Marina Maciza', NULL, NULL, 0, 4, 'Pulsera con eslabones tipo ancla / marina de 8mm en plata 925 maciza.', 1, 2, 2, 1),
    ('Pulsera Hilo Rojo Dije Infinito', NULL, NULL, 0, 12, 'Pulsera de protección con hilo rojo regulable y dije central de infinito en plata 925.', 1, 3, 2, 2);
GO
