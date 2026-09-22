using ProyectoIntegrador.Formularios.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoIntegrador.ModelosSimulados
{
    public class VentaHistorica
    {
        public int NroVenta { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string CategoriaPrincipal { get; set; }
        public decimal Total { get; set; }
        public int CantidadArticulos { get; set; }
        public string Vendedor { get; set; }
    }

    public class MetricaCategoria
    {
        public string Categoria { get; set; }
        public int UnidadesVendidas { get; set; }
        public decimal TotalRecaudado { get; set; }
        public double Porcentaje { get; set; }
    }

    public static class EstadisticasSimuladas
    {
        private static readonly List<VentaHistorica> _ventasHistoricas = new List<VentaHistorica>();

        static EstadisticasSimuladas()
        {
            InicializarDatos();
        }

        private static void InicializarDatos()
        {
            _ventasHistoricas.Clear();
            DateTime hoy = DateTime.Today;

            // Ventas de hoy
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1045, Cliente = "Mariana López", Fecha = hoy.AddHours(9).AddMinutes(30), CategoriaPrincipal = "Collares", Total = 310000m, CantidadArticulos = 2, Vendedor = "Sofía Ruiz" });
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1046, Cliente = "Carlos Benítez", Fecha = hoy.AddHours(11).AddMinutes(15), CategoriaPrincipal = "Anillos", Total = 320500m, CantidadArticulos = 1, Vendedor = "Lucas Díaz" });
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1047, Cliente = "Valeria Morales", Fecha = hoy.AddHours(13).AddMinutes(45), CategoriaPrincipal = "Pulseras", Total = 215400m, CantidadArticulos = 1, Vendedor = "Sofía Ruiz" });
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1048, Cliente = "Esteban Ponce", Fecha = hoy.AddHours(15).AddMinutes(20), CategoriaPrincipal = "Aros", Total = 143665m, CantidadArticulos = 2, Vendedor = "Lucas Díaz" });
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1049, Cliente = "Gabriela Ramos", Fecha = hoy.AddHours(17).AddMinutes(10), CategoriaPrincipal = "Dijes", Total = 170400m, CantidadArticulos = 2, Vendedor = "Sofía Ruiz" });

            // Ventas de los últimos días (Evolución de recaudación)
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1040, Cliente = "Martín Giménez", Fecha = hoy.AddDays(-1).AddHours(10), CategoriaPrincipal = "Anillos", Total = 551000m, CantidadArticulos = 2, Vendedor = "Sofía Ruiz" });
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1041, Cliente = "Claudia Ortiz", Fecha = hoy.AddDays(-1).AddHours(14), CategoriaPrincipal = "Collares", Total = 396000m, CantidadArticulos = 2, Vendedor = "Lucas Díaz" });
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1042, Cliente = "Rodrigo Varela", Fecha = hoy.AddDays(-1).AddHours(18), CategoriaPrincipal = "Cadenas", Total = 67300m, CantidadArticulos = 2, Vendedor = "Lucas Díaz" });

            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1035, Cliente = "Ana Navarro", Fecha = hoy.AddDays(-2).AddHours(11), CategoriaPrincipal = "Aros", Total = 241000m, CantidadArticulos = 3, Vendedor = "Sofía Ruiz" });
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1036, Cliente = "Federico Silva", Fecha = hoy.AddDays(-2).AddHours(16), CategoriaPrincipal = "Pulseras", Total = 430800m, CantidadArticulos = 2, Vendedor = "Sofía Ruiz" });

            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1030, Cliente = "Lucía Pereyra", Fecha = hoy.AddDays(-3).AddHours(12), CategoriaPrincipal = "Collares", Total = 665000m, CantidadArticulos = 3, Vendedor = "Lucas Díaz" });
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1031, Cliente = "Daniela Flores", Fecha = hoy.AddDays(-3).AddHours(17), CategoriaPrincipal = "Dijes", Total = 120100m, CantidadArticulos = 2, Vendedor = "Sofía Ruiz" });

            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1025, Cliente = "Pablo Medina", Fecha = hoy.AddDays(-4).AddHours(10), CategoriaPrincipal = "Anillos", Total = 780000m, CantidadArticulos = 3, Vendedor = "Lucas Díaz" });
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1026, Cliente = "Silvina Vega", Fecha = hoy.AddDays(-4).AddHours(15), CategoriaPrincipal = "Cadenas", Total = 84000m, CantidadArticulos = 2, Vendedor = "Sofía Ruiz" });

            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1020, Cliente = "Alejandro Castro", Fecha = hoy.AddDays(-5).AddHours(11), CategoriaPrincipal = "Pulseras", Total = 512000m, CantidadArticulos = 3, Vendedor = "Sofía Ruiz" });
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1021, Cliente = "Camila Romero", Fecha = hoy.AddDays(-5).AddHours(16), CategoriaPrincipal = "Aros", Total = 312000m, CantidadArticulos = 3, Vendedor = "Lucas Díaz" });

            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1015, Cliente = "Gustavo Gómez", Fecha = hoy.AddDays(-6).AddHours(12), CategoriaPrincipal = "Collares", Total = 495000m, CantidadArticulos = 2, Vendedor = "Lucas Díaz" });
            _ventasHistoricas.Add(new VentaHistorica { NroVenta = 1016, Cliente = "Beatriz Herrera", Fecha = hoy.AddDays(-6).AddHours(18), CategoriaPrincipal = "Anillos", Total = 641000m, CantidadArticulos = 2, Vendedor = "Sofía Ruiz" });

            // Ventas adicionales dentro del mes para total mensual
            for (int i = 7; i <= 25; i++)
            {
                _ventasHistoricas.Add(new VentaHistorica
                {
                    NroVenta = 1000 - i,
                    Cliente = "Cliente Frecuente " + i,
                    Fecha = hoy.AddDays(-i).AddHours(14),
                    CategoriaPrincipal = (i % 2 == 0) ? "Collares" : (i % 3 == 0 ? "Anillos" : "Aros"),
                    Total = 420000m + (i * 12500m),
                    CantidadArticulos = 2,
                    Vendedor = (i % 2 == 0) ? "Sofía Ruiz" : "Lucas Díaz"
                });
            }

            SincronizarConFormVentas();
        }

        public static void SincronizarConFormVentas()
        {
            if (FormVentas.HistorialVentas == null)
            {
                FormVentas.HistorialVentas = new Dictionary<int, FormVentas.DatosVenta>();
            }

            foreach (var v in _ventasHistoricas)
            {
                if (!FormVentas.HistorialVentas.ContainsKey(v.NroVenta))
                {
                    var datos = new FormVentas.DatosVenta
                    {
                        Nro = v.NroVenta,
                        Fecha = v.Fecha.ToString("dd/MM/yyyy HH:mm"),
                        Cliente = v.Cliente,
                        Iva = "Consumidor Final",
                        MetodoPago = (v.NroVenta % 3 == 0) ? "Tarjeta de Débito" : (v.NroVenta % 2 == 0 ? "Tarjeta de Crédito" : "Efectivo"),
                        Total = v.Total.ToString("C2")
                    };

                    decimal precioUnit = Math.Round(v.Total / Math.Max(1, v.CantidadArticulos), 2);
                    string nombreArticulo = $"Joya ALBA - {v.CategoriaPrincipal} Colección Elegance";
                    datos.Articulos.Add(new FDetalleVenta.ItemDetalle
                    {
                        Producto = nombreArticulo,
                        Cantidad = Math.Max(1, v.CantidadArticulos),
                        PrecioUnitario = precioUnit
                    });

                    FormVentas.HistorialVentas.Add(v.NroVenta, datos);
                }
            }
        }

        public static List<VentaHistorica> ObtenerHistorialVentas()
        {
            SincronizarConFormVentas();
            return ObtenerTodasLasVentasCombinadas().OrderByDescending(v => v.Fecha).ToList();
        }

        private static List<VentaHistorica> ObtenerTodasLasVentasCombinadas()
        {
            var resultado = new List<VentaHistorica>(_ventasHistoricas);

            // Incorporamos en tiempo real cualquier venta registrada en FormVentas.HistorialVentas
            if (FormVentas.HistorialVentas != null && FormVentas.HistorialVentas.Count > 0)
            {
                foreach (var kvp in FormVentas.HistorialVentas)
                {
                    var v = kvp.Value;
                    if (!resultado.Any(x => x.NroVenta == v.Nro))
                    {
                        DateTime fechaParsed;
                        if (!DateTime.TryParse(v.Fecha, out fechaParsed))
                            fechaParsed = DateTime.Today;

                        decimal totalParsed;
                        string limpio = v.Total.Replace("$", "").Trim();
                        if (!decimal.TryParse(limpio, out totalParsed))
                            totalParsed = 150000m;

                        string cat = "Joyería General";
                        if (v.Articulos != null && v.Articulos.Count > 0)
                        {
                            var art = v.Articulos[0];
                            var prod = StockSimulado.BuscarPorCodigo(art.Producto) ?? StockSimulado.ObtenerCatalogoCompleto().FirstOrDefault(p => p.Nombre == art.Producto);
                            if (prod != null) cat = prod.Categoria;
                        }

                        resultado.Add(new VentaHistorica
                        {
                            NroVenta = v.Nro,
                            Cliente = v.Cliente,
                            Fecha = fechaParsed,
                            CategoriaPrincipal = cat,
                            Total = totalParsed,
                            CantidadArticulos = v.Articulos != null ? v.Articulos.Sum(a => a.Cantidad) : 1,
                            Vendedor = "Vendedor Local"
                        });
                    }
                }
            }

            return resultado;
        }

        public static void ObtenerVentasDelDia(out decimal montoTotal, out int cantidadOperaciones)
        {
            DateTime hoy = DateTime.Today;
            var ventasHoy = ObtenerTodasLasVentasCombinadas()
                .Where(v => v.Fecha.Date == hoy)
                .ToList();

            montoTotal = ventasHoy.Sum(v => v.Total);
            cantidadOperaciones = ventasHoy.Count;
        }

        public static void ObtenerRecaudacionMensual(out decimal montoTotal, out int cantidadOperaciones)
        {
            DateTime hoy = DateTime.Today;
            var ventasMes = ObtenerTodasLasVentasCombinadas()
                .Where(v => v.Fecha.Month == hoy.Month && v.Fecha.Year == hoy.Year)
                .ToList();

            montoTotal = ventasMes.Sum(v => v.Total);
            cantidadOperaciones = ventasMes.Count;
        }

        public static void ObtenerAlertasStock(out int cantidadCriticos)
        {
            var catalogo = StockSimulado.ObtenerCatalogoCompleto();
            cantidadCriticos = catalogo.Count(p => p.StockActual <= p.StockMinimo);
        }

        public static List<ProductoSimulado> ObtenerProductosCriticos()
        {
            return StockSimulado.ObtenerCatalogoCompleto()
                .Where(p => p.StockActual <= p.StockMinimo)
                .OrderBy(p => p.StockActual)
                .ToList();
        }

        public static List<VentaHistorica> ObtenerUltimasVentas(int top = 5)
        {
            return ObtenerTodasLasVentasCombinadas()
                .OrderByDescending(v => v.Fecha)
                .Take(top)
                .ToList();
        }

        public static Dictionary<string, decimal> ObtenerEvolucionRecaudacion(int dias = 7)
        {
            var dic = new Dictionary<string, decimal>();
            DateTime hoy = DateTime.Today;
            var ventas = ObtenerTodasLasVentasCombinadas();

            for (int i = dias - 1; i >= 0; i--)
            {
                DateTime fechaDia = hoy.AddDays(-i);
                string clave = fechaDia.ToString("dd/MM");
                decimal totalDia = ventas
                    .Where(v => v.Fecha.Date == fechaDia.Date)
                    .Sum(v => v.Total);

                dic[clave] = totalDia;
            }

            return dic;
        }

        public static Dictionary<string, decimal> ObtenerVentasPorCategoria()
        {
            var ventas = ObtenerTodasLasVentasCombinadas();
            var dic = new Dictionary<string, decimal>();

            var categorias = new[] { "Collares", "Anillos", "Aros", "Pulseras", "Dijes", "Cadenas" };
            foreach (var cat in categorias)
            {
                decimal total = ventas
                    .Where(v => v.CategoriaPrincipal.Equals(cat, StringComparison.OrdinalIgnoreCase))
                    .Sum(v => v.Total);

                if (total == 0) total = 50000m; // Monto base para gráfico visible
                dic[cat] = total;
            }

            return dic;
        }

        public static List<MetricaCategoria> ObtenerInformeCategorias(DateTime desde, DateTime hasta)
        {
            var ventas = ObtenerTodasLasVentasCombinadas()
                .Where(v => v.Fecha.Date >= desde.Date && v.Fecha.Date <= hasta.Date)
                .ToList();

            decimal totalGeneral = ventas.Sum(v => v.Total);
            if (totalGeneral == 0) totalGeneral = 1;

            var lista = new List<MetricaCategoria>();
            var agrupado = ventas.GroupBy(v => v.CategoriaPrincipal);

            foreach (var g in agrupado)
            {
                decimal subtotal = g.Sum(x => x.Total);
                lista.Add(new MetricaCategoria
                {
                    Categoria = g.Key,
                    UnidadesVendidas = g.Sum(x => x.CantidadArticulos),
                    TotalRecaudado = subtotal,
                    Porcentaje = Math.Round((double)(subtotal / totalGeneral) * 100.0, 1)
                });
            }

            return lista.OrderByDescending(x => x.TotalRecaudado).ToList();
        }
    }
}
