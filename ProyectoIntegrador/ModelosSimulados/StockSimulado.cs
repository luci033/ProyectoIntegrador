using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoIntegrador.ModelosSimulados
{
    public class ProductoSimulado
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Genero { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public string Descripcion { get; set; }
        public string Proveedor { get; set; }
        public bool Activo { get; set; } = true;
    }

    public class RegistroAjusteStock
    {
        public int IdAjuste { get; set; }
        public DateTime FechaHora { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string TipoAjuste { get; set; } // "Ingreso" o "Egreso"
        public int Cantidad { get; set; }
        public int StockPrevio { get; set; }
        public int StockNuevo { get; set; }
        public string Operador { get; set; }
        public string Observaciones { get; set; }
    }

    /// <summary>
    /// Repositorio centralizado en memoria que simula la base de datos de productos e inventario.
    /// Mantiene sincronizado el stock entre Ajuste de Stock, Catálogo de Productos y Ventas.
    /// </summary>
    public static class StockSimulado
    {
        private static readonly List<ProductoSimulado> _productos = new List<ProductoSimulado>();
        private static readonly List<RegistroAjusteStock> _historialAjustes = new List<RegistroAjusteStock>();
        private static int _proximoIdAjuste = 1;

        static StockSimulado()
        {
            InicializarDatos();
        }

        private static void InicializarDatos()
        {
            _productos.Clear();
            _productos.Add(new ProductoSimulado { IdProducto = 1, Codigo = "1123456", Nombre = "Collar Rubí", Categoria = "Collares", Genero = "Femenino", PrecioVenta = 155760m, PrecioCompra = 100000m, StockActual = 15, StockMinimo = 5, Descripcion = "Collar de oro blanco con rubí central.", Proveedor = "Proveedor A" });
            _productos.Add(new ProductoSimulado { IdProducto = 2, Codigo = "2234567", Nombre = "Aros Luz de Luna", Categoria = "Aros", Genero = "Femenino", PrecioVenta = 98065m, PrecioCompra = 50000m, StockActual = 20, StockMinimo = 5, Descripcion = "Aros colgantes de plata con diseño de media luna.", Proveedor = "Proveedor B" });
            _productos.Add(new ProductoSimulado { IdProducto = 3, Codigo = "3345678", Nombre = "Anillo Solitario Diamante", Categoria = "Anillos", Genero = "Femenino", PrecioVenta = 320500m, PrecioCompra = 200000m, StockActual = 5, StockMinimo = 1, Descripcion = "Anillo de compromiso en oro blanco.", Proveedor = "Proveedor C" });
            _productos.Add(new ProductoSimulado { IdProducto = 4, Codigo = "4456789", Nombre = "Pulsera Eslabón Oro 18k", Categoria = "Pulseras", Genero = "Unisex", PrecioVenta = 215400m, PrecioCompra = 180000m, StockActual = 10, StockMinimo = 2, Descripcion = "Pulsera de eslabones gruesos.", Proveedor = "Proveedor A" });
            _productos.Add(new ProductoSimulado { IdProducto = 5, Codigo = "5567890", Nombre = "Dije Corazón Zafiro", Categoria = "Dijes", Genero = "Femenino", PrecioVenta = 85200m, PrecioCompra = 60000m, StockActual = 8, StockMinimo = 3, Descripcion = "Dije pequeño en forma de corazón con zafiro.", Proveedor = "Proveedor B" });
            _productos.Add(new ProductoSimulado { IdProducto = 6, Codigo = "6678901", Nombre = "Aros Perla Clásica", Categoria = "Aros", Genero = "Femenino", PrecioVenta = 45600m, PrecioCompra = 25000m, StockActual = 25, StockMinimo = 8, Descripcion = "Aros pasantes con perlas de 8mm.", Proveedor = "Proveedor C" });
            _productos.Add(new ProductoSimulado { IdProducto = 7, Codigo = "7789012", Nombre = "Cadena Plata 925", Categoria = "Cadenas", Genero = "Unisex", PrecioVenta = 25300m, PrecioCompra = 35000m, StockActual = 30, StockMinimo = 10, Descripcion = "Cadena tradicional de 45 cm.", Proveedor = "Proveedor A" });
            _productos.Add(new ProductoSimulado { IdProducto = 8, Codigo = "8890123", Nombre = "Anillo Esmeralda Imperial", Categoria = "Anillos", Genero = "Femenino", PrecioVenta = 275800m, PrecioCompra = 280000m, StockActual = 3, StockMinimo = 1, Descripcion = "Anillo con esmeralda colombiana.", Proveedor = "Proveedor B" });
            _productos.Add(new ProductoSimulado { IdProducto = 9, Codigo = "9901234", Nombre = "Gargantilla Oro Blanco", Categoria = "Collares", Genero = "Femenino", PrecioVenta = 198000m, PrecioCompra = 210000m, StockActual = 12, StockMinimo = 2, Descripcion = "Gargantilla elegante y minimalista.", Proveedor = "Proveedor C" });
            _productos.Add(new ProductoSimulado { IdProducto = 10, Codigo = "1012345", Nombre = "Pulsera Tenis Circones", Categoria = "Pulseras", Genero = "Femenino", PrecioVenta = 112500m, PrecioCompra = 75000m, StockActual = 18, StockMinimo = 3, Descripcion = "Pulsera estilo tenis con brillos.", Proveedor = "Proveedor A" });
            _productos.Add(new ProductoSimulado { IdProducto = 11, Codigo = "1123457", Nombre = "Colgante Árbol de la Vida", Categoria = "Dijes", Genero = "Unisex", PrecioVenta = 34900m, PrecioCompra = 18000m, StockActual = 40, StockMinimo = 5, Descripcion = "Colgante circular en acero quirúrgico.", Proveedor = "Proveedor B" });
            _productos.Add(new ProductoSimulado { IdProducto = 12, Codigo = "1234567", Nombre = "Aros Argolla Oro", Categoria = "Aros", Genero = "Unisex", PrecioVenta = 76400m, PrecioCompra = 70000m, StockActual = 22, StockMinimo = 4, Descripcion = "Aros clásicos tipo argolla mediana.", Proveedor = "Proveedor C" });
            _productos.Add(new ProductoSimulado { IdProducto = 13, Codigo = "1345678", Nombre = "Anillo Sello Oro 18k", Categoria = "Anillos", Genero = "Masculino", PrecioVenta = 185000m, PrecioCompra = 120000m, StockActual = 7, StockMinimo = 2, Descripcion = "Anillo tipo sello liso para caballero.", Proveedor = "Proveedor A" });
            _productos.Add(new ProductoSimulado { IdProducto = 14, Codigo = "1456789", Nombre = "Cadena Espiga Plata", Categoria = "Cadenas", Genero = "Masculino", PrecioVenta = 42000m, PrecioCompra = 45000m, StockActual = 15, StockMinimo = 5, Descripcion = "Cadena plana de eslabón trenzado.", Proveedor = "Proveedor B" });
            _productos.Add(new ProductoSimulado { IdProducto = 15, Codigo = "1567890", Nombre = "Pulsera Cuero y Acero", Categoria = "Pulseras", Genero = "Masculino", PrecioVenta = 28500m, PrecioCompra = 12000m, StockActual = 30, StockMinimo = 10, Descripcion = "Pulsera de cuero negro con cierre magnético.", Proveedor = "Proveedor C" });
            _productos.Add(new ProductoSimulado { IdProducto = 16, Codigo = "1678901", Nombre = "Dije Cruz Acero Quirúrgico", Categoria = "Dijes", Genero = "Masculino", PrecioVenta = 15000m, PrecioCompra = 7000m, StockActual = 40, StockMinimo = 15, Descripcion = "Dije liso antialérgico.", Proveedor = "Proveedor A" });
        }

        public static List<ProductoSimulado> ObtenerTodos()
        {
            return _productos.Where(p => p.Activo).ToList();
        }

        public static List<ProductoSimulado> ObtenerCatalogoCompleto()
        {
            return _productos.ToList();
        }

        public static ProductoSimulado BuscarPorCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo)) return null;
            return _productos.FirstOrDefault(p => p.Codigo.Trim().Equals(codigo.Trim(), StringComparison.OrdinalIgnoreCase) && p.Activo);
        }

        public static ProductoSimulado BuscarCualquieraPorCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo)) return null;
            return _productos.FirstOrDefault(p => p.Codigo.Trim().Equals(codigo.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public static void CambiarEstadoActivo(string codigo, bool activo)
        {
            var p = BuscarCualquieraPorCodigo(codigo);
            if (p != null)
            {
                p.Activo = activo;
            }
        }

        public static void AgregarProducto(ProductoSimulado nuevo)
        {
            if (nuevo != null)
            {
                if (nuevo.IdProducto <= 0)
                {
                    nuevo.IdProducto = _productos.Count > 0 ? _productos.Max(p => p.IdProducto) + 1 : 1;
                }
                _productos.Add(nuevo);
            }
        }

        public static bool AplicarAjuste(string codigo, string tipoAjuste, int cantidad, string operador, string observaciones, out int stockAnterior, out int stockNuevo, out string mensajeError)
        {
            stockAnterior = 0;
            stockNuevo = 0;
            mensajeError = string.Empty;

            var producto = BuscarPorCodigo(codigo);
            if (producto == null)
            {
                mensajeError = "No se encontró el producto especificado en el sistema.";
                return false;
            }

            if (cantidad <= 0)
            {
                mensajeError = "La cantidad a ajustar debe ser mayor a cero.";
                return false;
            }

            stockAnterior = producto.StockActual;

            if (tipoAjuste.Equals("Ingreso", StringComparison.OrdinalIgnoreCase))
            {
                stockNuevo = stockAnterior + cantidad;
            }
            else if (tipoAjuste.Equals("Egreso", StringComparison.OrdinalIgnoreCase))
            {
                if (cantidad > stockAnterior)
                {
                    mensajeError = $"Stock insuficiente. El stock actual es de {stockAnterior} unidades y no es posible egresar {cantidad} unidades.";
                    return false;
                }
                stockNuevo = stockAnterior - cantidad;
            }
            else
            {
                mensajeError = "Tipo de ajuste no válido. Debe ser 'Ingreso' o 'Egreso'.";
                return false;
            }

            // Actualizamos el stock en el catálogo compartido
            producto.StockActual = stockNuevo;

            // Registramos en el historial de auditoría
            _historialAjustes.Add(new RegistroAjusteStock
            {
                IdAjuste = _proximoIdAjuste++,
                FechaHora = DateTime.Now,
                CodigoProducto = producto.Codigo,
                NombreProducto = producto.Nombre,
                TipoAjuste = tipoAjuste,
                Cantidad = cantidad,
                StockPrevio = stockAnterior,
                StockNuevo = stockNuevo,
                Operador = string.IsNullOrWhiteSpace(operador) ? "Operador Logística" : operador,
                Observaciones = observaciones
            });

            return true;
        }

        public static List<RegistroAjusteStock> ObtenerHistorialAjustes()
        {
            return _historialAjustes.OrderByDescending(a => a.FechaHora).ToList();
        }
    }
}
