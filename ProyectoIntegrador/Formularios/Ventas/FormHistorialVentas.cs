using ProyectoIntegrador.ModelosSimulados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Ventas
{
    public partial class FHistorialVentas : Form
    {
        private List<VentaHistorica> listaVentasCompleta = new List<VentaHistorica>();
        private List<VentaHistorica> listaVentasActuales = new List<VentaHistorica>();
        private bool inicializando = true;

        public FHistorialVentas()
        {
            InitializeComponent();
        }

        private void FHistorialVentas_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LHistorialVenta);

            EstiloUI.AplicarEstiloCard(cardTotal, 10);
            EstiloUI.AplicarEstiloCard(cardCantidad, 10);
            EstiloUI.AplicarEstiloCard(cardPromedio, 10);

            EstiloUI.AplicarEstiloPanelSeccion(panel1, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panelGrid, 12);

            EstiloUI.AplicarEstiloBoton(BBuscar);
            EstiloUI.AplicarEstiloBotonSecundario(BLimpiar);
            EstiloUI.AplicarEstiloBotonSecundario(BExportar);

            EstiloUI.AplicarEstiloTextBox(TBBuscar);
            EstiloUI.AplicarEstiloTextBox(TBTotalFiltrado);
            EstiloUI.AplicarEstiloGrilla(DataGridHistorialVenta);

            ConfigurarEstilosColumnas();

            // Bloquea el redimensionamiento de las columnas por parte del usuario
            DataGridHistorialVenta.AllowUserToResizeColumns = false;

            // Bloquea el redimensionamiento de las filas por parte del usuario
            DataGridHistorialVenta.AllowUserToResizeRows = false;

            // Bloquea que el usuario pueda arrastrar las columnas para cambiar su orden
            DataGridHistorialVenta.AllowUserToOrderColumns = false;

            // Oculta la columna de cabecera de las filas (el selector vacío que aparece a la izquierda)
            DataGridHistorialVenta.RowHeadersVisible = false;   

            // Configuración de combos de búsqueda
            cmbBuscar.Items.Clear();
            cmbBuscar.Items.Add("Nro. Venta");
            cmbBuscar.Items.Add("Vendedor");
            cmbBuscar.Items.Add("Cliente");
            cmbBuscar.SelectedIndex = 0;

            // Inicializar rango con "Mes Actual"
            cmbPeriodo.SelectedIndex = 0; // "Mes Actual"
            AplicarPresetPeriodo("Mes Actual");

            // Cargar datos estáticos combinados
            CargarDatosDesdeMemoria();

            inicializando = false;
            AplicarFiltros();
            AjustarTarjetasResponsive();
        }

        private void ConfigurarEstilosColumnas()
        {
            if (DataGridHistorialVenta.Columns.Contains("total"))
            {
                DataGridHistorialVenta.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DataGridHistorialVenta.Columns["total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (DataGridHistorialVenta.Columns.Contains("colNroVenta"))
            {
                DataGridHistorialVenta.Columns["colNroVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridHistorialVenta.Columns["colNroVenta"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (DataGridHistorialVenta.Columns.Contains("Fecha"))
            {
                DataGridHistorialVenta.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridHistorialVenta.Columns["Fecha"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (DataGridHistorialVenta.Columns.Contains("colAccion"))
            {
                DataGridHistorialVenta.Columns["colAccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void CargarDatosDesdeMemoria()
        {
            // Sincroniza y trae todas las ventas de EstadisticasSimuladas y FormVentas.HistorialVentas
            listaVentasCompleta = EstadisticasSimuladas.ObtenerHistorialVentas();
        }

        private void AplicarPresetPeriodo(string preset)
        {
            DateTime hoy = DateTime.Today;
            switch (preset)
            {
                case "Hoy":
                    DTPFechaDesde.Value = hoy;
                    DTPFechaHasta.Value = hoy;
                    break;
                case "Últimos 7 días":
                    DTPFechaDesde.Value = hoy.AddDays(-6);
                    DTPFechaHasta.Value = hoy;
                    break;
                case "Mes Actual":
                    DTPFechaDesde.Value = new DateTime(hoy.Year, hoy.Month, 1);
                    DTPFechaHasta.Value = hoy;
                    break;
                case "Todo el Historial":
                    DTPFechaDesde.Value = hoy.AddMonths(-12);
                    DTPFechaHasta.Value = hoy;
                    break;
                case "Personalizado":
                    // No modifica los valores seleccionados manualmente
                    break;
            }
        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicializando) return;

            string preset = cmbPeriodo.SelectedItem?.ToString() ?? "Mes Actual";
            AplicarPresetPeriodo(preset);
            AplicarFiltros();
        }

        private void DTPFecha_ValueChanged(object sender, EventArgs e)
        {
            if (inicializando) return;

            // Si el usuario cambia las fechas manualmente, cambia el preset a Personalizado
            if (cmbPeriodo.SelectedItem?.ToString() != "Personalizado")
            {
                inicializando = true;
                cmbPeriodo.SelectedItem = "Personalizado";
                inicializando = false;
            }

            ValidarFechas(false);
            AplicarFiltros();
        }

        private bool ValidarFechas(bool mostrarAlertaModal)
        {
            if (DTPFechaDesde.Value.Date > DTPFechaHasta.Value.Date)
            {
                errorProvider1.SetError(DTPFechaHasta, "La fecha 'Hasta' no puede ser anterior a la fecha 'Desde'.");
                if (mostrarAlertaModal)
                {
                    MessageBox.Show(
                        "El rango de fechas ingresado es inválido.\nLa fecha final no puede ser anterior a la fecha inicial.",
                        "Rango de Fechas Inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                return false;
            }

            errorProvider1.SetError(DTPFechaHasta, "");
            return true;
        }

        private bool ValidarTextoBusqueda()
        {
            string criterio = cmbBuscar.SelectedItem?.ToString() ?? "Nro. Venta";
            string texto = TBBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(texto) && criterio == "Nro. Venta")
            {
                if (!texto.All(char.IsDigit))
                {
                    errorProvider1.SetError(TBBuscar, "El número de venta solo debe contener dígitos numéricos.");
                    return false;
                }
            }

            errorProvider1.SetError(TBBuscar, "");
            return true;
        }

        private void AplicarFiltros()
        {
            if (!ValidarFechas(false) || !ValidarTextoBusqueda())
            {
                // Si hay error de validación, no se rompe pero se detiene el filtrado
                return;
            }

            DateTime fechaDesde = DTPFechaDesde.Value.Date;
            DateTime fechaHasta = DTPFechaHasta.Value.Date.AddDays(1).AddSeconds(-1);

            IEnumerable<VentaHistorica> query = listaVentasCompleta
                .Where(v => v.Fecha >= fechaDesde && v.Fecha <= fechaHasta);

            string criterio = cmbBuscar.SelectedItem?.ToString() ?? "Nro. Venta";
            string texto = TBBuscar.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(texto))
            {
                if (criterio == "Nro. Venta")
                {
                    query = query.Where(v => v.NroVenta.ToString().Contains(texto));
                }
                else if (criterio == "Vendedor")
                {
                    query = query.Where(v => v.Vendedor != null && v.Vendedor.ToLower().Contains(texto));
                }
                else if (criterio == "Cliente")
                {
                    query = query.Where(v => v.Cliente != null && v.Cliente.ToLower().Contains(texto));
                }
            }

            listaVentasActuales = query.OrderByDescending(v => v.Fecha).ToList();
            ActualizarGrillaYMetricas(listaVentasActuales);
        }

        private void ActualizarGrillaYMetricas(List<VentaHistorica> ventas)
        {
            DataGridHistorialVenta.Rows.Clear();

            decimal totalSuma = 0;
            int cantidad = ventas.Count;

            foreach (var venta in ventas)
            {
                DataGridHistorialVenta.Rows.Add(
                    venta.NroVenta,
                    "Ver Detalle",
                    $"#{venta.NroVenta:D5}",
                    venta.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    venta.Cliente,
                    venta.Vendedor ?? "Vendedor Local",
                    venta.Total.ToString("C2")
                );

                totalSuma += venta.Total;
            }

            decimal ticketPromedio = cantidad > 0 ? (totalSuma / cantidad) : 0;

            // Actualizar tarjetas de métricas
            LValorTotal.Text = totalSuma.ToString("C2");
            LValorCantidad.Text = $"{cantidad} {(cantidad == 1 ? "operación" : "operaciones")}";
            LValorPromedio.Text = ticketPromedio.ToString("C2");

            TBTotalFiltrado.Text = totalSuma.ToString("C2");

            // Control de vista vacía
            bool hayDatos = cantidad > 0;
            DataGridHistorialVenta.Visible = hayDatos;
            LEstadoVacio.Visible = !hayDatos;
        }

        private void dataGridHistorialVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Columna 1 corresponde al botón "Ver Detalle"
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                int nroVenta = Convert.ToInt32(DataGridHistorialVenta.Rows[e.RowIndex].Cells[0].Value);

                // Verificamos si existe en el diccionario estático de comprobantes
                if (FormVentas.HistorialVentas != null && FormVentas.HistorialVentas.ContainsKey(nroVenta))
                {
                    FDetalleVenta modalDetalle = new FDetalleVenta(FormVentas.HistorialVentas[nroVenta]);
                    modalDetalle.ShowDialog();
                }
                else
                {
                    // Respaldo preventivo: si por alguna razón no estuviera en el diccionario,
                    // generamos un comprobante fiel al registro seleccionado para que el usuario siempre vea su detalle
                    var ventaRespaldo = listaVentasCompleta.FirstOrDefault(v => v.NroVenta == nroVenta);
                    if (ventaRespaldo != null)
                    {
                        var datos = new FormVentas.DatosVenta
                        {
                            Nro = ventaRespaldo.NroVenta,
                            Fecha = ventaRespaldo.Fecha.ToString("dd/MM/yyyy HH:mm"),
                            Cliente = ventaRespaldo.Cliente,
                            Iva = "Consumidor Final",
                            MetodoPago = (ventaRespaldo.NroVenta % 2 == 0) ? "Tarjeta de Crédito" : "Efectivo",
                            Total = ventaRespaldo.Total.ToString("C2")
                        };

                        datos.Articulos.Add(new FDetalleVenta.ItemDetalle
                        {
                            Producto = $"Joya ALBA - {ventaRespaldo.CategoriaPrincipal} Colección Fina",
                            Cantidad = Math.Max(1, ventaRespaldo.CantidadArticulos),
                            PrecioUnitario = Math.Round(ventaRespaldo.Total / Math.Max(1, ventaRespaldo.CantidadArticulos), 2)
                        });

                        FormVentas.HistorialVentas[nroVenta] = datos;

                        FDetalleVenta modalDetalle = new FDetalleVenta(datos);
                        modalDetalle.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el comprobante detallado para la venta seleccionada.", "Comprobante no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            if (inicializando) return;
            AplicarFiltros();
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicializando) return;
            ValidarTextoBusqueda();
            AplicarFiltros();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if (!ValidarFechas(true)) return;
            if (!ValidarTextoBusqueda()) return;

            AplicarFiltros();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            inicializando = true;
            TBBuscar.Clear();
            errorProvider1.Clear();
            cmbBuscar.SelectedIndex = 0;
            cmbPeriodo.SelectedIndex = 0;
            AplicarPresetPeriodo("Mes Actual");
            inicializando = false;

            AplicarFiltros();
        }

        private void BExportar_Click(object sender, EventArgs e)
        {
            if (listaVentasActuales == null || listaVentasActuales.Count == 0)
            {
                MessageBox.Show(
                    "No hay ventas para exportar con los filtros actuales.",
                    "Exportación no disponible",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo CSV (*.csv)|*.csv";
                sfd.FileName = $"Historial_Ventas_ALBA_{DateTime.Now:yyyyMMdd_HHmm}.csv";
                sfd.Title = "Guardar Historial de Ventas";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Nro Comprobante;Fecha;Cliente;Vendedor;Total Facturado");

                        foreach (var v in listaVentasActuales)
                        {
                            sb.AppendLine($"#{v.NroVenta:D5};{v.Fecha:dd/MM/yyyy HH:mm};\"{v.Cliente}\";\"{v.Vendedor}\";{v.Total:F2}");
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                        MessageBox.Show(
                            $"Historial exportado exitosamente ({listaVentasActuales.Count} registros).\nGuardado en:\n{sfd.FileName}",
                            "Exportación Exitosa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Ocurrió un error al intentar exportar el archivo:\n" + ex.Message,
                            "Error de Exportación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private void FHistorialVentas_Resize(object sender, EventArgs e)
        {
            AjustarTarjetasResponsive();
        }

        private void AjustarTarjetasResponsive()
        {
            if (panelCards == null || cardTotal == null || cardCantidad == null || cardPromedio == null) return;

            int espacioDisponible = panelCards.ClientSize.Width;
            int margen = 16;
            int anchoCard = Math.Max(180, (espacioDisponible - (margen * 2)) / 3);

            cardTotal.Location = new Point(0, 0);
            cardTotal.Size = new Size(anchoCard, panelCards.ClientSize.Height - 4);

            cardCantidad.Location = new Point(anchoCard + margen, 0);
            cardCantidad.Size = new Size(anchoCard, panelCards.ClientSize.Height - 4);

            cardPromedio.Location = new Point((anchoCard + margen) * 2, 0);
            cardPromedio.Size = new Size(anchoCard, panelCards.ClientSize.Height - 4);
        }

        private void LTotal_Click(object sender, EventArgs e)
        {

        }

        private void TBTotalFiltrado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
