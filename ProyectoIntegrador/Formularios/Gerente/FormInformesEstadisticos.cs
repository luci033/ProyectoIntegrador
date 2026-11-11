using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Gerente
{
    public partial class FormInformesEstadisticos : Form
    {
        private CN_Venta objNegocioVenta = new CN_Venta();

        public FormInformesEstadisticos()
        {
            InitializeComponent();
        }

        private void FormInformesEstadisticos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloPanelSeccion(panelFiltros, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panelGrilla, 12);
            EstiloUI.AplicarEstiloBoton(BGenerar);
            EstiloUI.AplicarEstiloBotonSecundario(BExportar);
            EstiloUI.AplicarEstiloGrilla(DGInforme);

            EstiloUI.AplicarEstiloCard(cardTotal, 10);
            EstiloUI.AplicarEstiloCard(cardUnidades, 10);
            EstiloUI.AplicarEstiloCard(cardPromedio, 10);
            EstiloUI.AplicarEstiloCard(cardLider, 10);

            CBPeriodo.SelectedIndex = 0; // "Mes Actual" por defecto
            GenerarInforme();
        }

        private void CBPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            string seleccion = CBPeriodo.SelectedItem?.ToString() ?? "Mes Actual";

            switch (seleccion)
            {
                case "Hoy":
                    DTPDesde.Value = hoy;
                    DTPHasta.Value = hoy;
                    break;
                case "Últimos 7 días":
                    DTPDesde.Value = hoy.AddDays(-6);
                    DTPHasta.Value = hoy;
                    break;
                case "Mes Actual":
                    DTPDesde.Value = new DateTime(hoy.Year, hoy.Month, 1);
                    DTPHasta.Value = hoy;
                    break;
                case "Personalizado":
                    // El usuario define las fechas manualmente
                    break;
            }

            GenerarInforme();
        }

        private void BGenerar_Click(object sender, EventArgs e)
        {
            GenerarInforme();
        }

        private void GenerarInforme()
        {
            DateTime desde = DTPDesde.Value.Date;
            DateTime hasta = DTPHasta.Value.Date.AddDays(1).AddSeconds(-1);

            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.", "Rango Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable tabla = objNegocioVenta.ListarVentasPorCategoria(desde, hasta);

            DGInforme.Rows.Clear();
            decimal totalFacturacion = 0;
            int totalUnidades = 0;
            string categoriaLider = "-";
            decimal maxRecaudacion = -1;

            foreach (DataRow row in tabla.Rows)
            {
                totalFacturacion += Convert.ToDecimal(row["TotalRecaudado"]);
                totalUnidades += Convert.ToInt32(row["UnidadesVendidas"]);
            }

            foreach (DataRow row in tabla.Rows)
            {
                string categoria = row["Categoria"].ToString();
                int unidades = Convert.ToInt32(row["UnidadesVendidas"]);
                decimal recaudado = Convert.ToDecimal(row["TotalRecaudado"]);

                if (recaudado > maxRecaudacion && recaudado > 0)
                {
                    maxRecaudacion = recaudado;
                    categoriaLider = categoria;
                }

                decimal porcentaje = totalFacturacion > 0 ? (recaudado * 100m / totalFacturacion) : 0;

                DGInforme.Rows.Add(
                    categoria,
                    unidades + " piezas",
                    recaudado.ToString("C0"),
                    porcentaje.ToString("F1") + "%"
                );
            }

            // Actualizar tarjetas de métricas consolidadas
            LTotalValor.Text = totalFacturacion.ToString("C0");
            LUnidadesValor.Text = totalUnidades + " Piezas";

            decimal ticketPromedio = totalUnidades > 0 ? (totalFacturacion / totalUnidades) : 0;
            LPromedioValor.Text = ticketPromedio.ToString("C0");
            LLiderValor.Text = categoriaLider;
        }

        private void BExportar_Click(object sender, EventArgs e)
        {
            if (DGInforme.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en el informe para exportar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo CSV (*.csv)|*.csv|Archivo de Texto (*.txt)|*.txt";
                sfd.FileName = $"Informe_Gestion_ALBA_{DateTime.Now:yyyyMMdd_HHmm}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("INFORME ESTADÍSTICO DE VENTAS - JOYERÍA ALBA");
                        sb.AppendLine($"Período;{DTPDesde.Value:dd/MM/yyyy} al {DTPHasta.Value:dd/MM/yyyy}");
                        sb.AppendLine($"Fecha Emisión;{DateTime.Now:dd/MM/yyyy HH:mm}");
                        sb.AppendLine($"Facturación Total;\"{LTotalValor.Text}\"");
                        sb.AppendLine($"Total Unidades;\"{LUnidadesValor.Text}\"");
                        sb.AppendLine($"Ticket Promedio;\"{LPromedioValor.Text}\"");
                        sb.AppendLine($"Categoría Líder;\"{LLiderValor.Text}\"");
                        sb.AppendLine();
                        sb.AppendLine("Categoría;Unidades Vendidas;Facturación Total;Participación %");

                        foreach (DataGridViewRow row in DGInforme.Rows)
                        {
                            if (row.IsNewRow) continue;
                            string cat = row.Cells[0].Value?.ToString();
                            string uni = row.Cells[1].Value?.ToString();
                            string tot = row.Cells[2].Value?.ToString().Replace("$", "").Trim();
                            string pct = row.Cells[3].Value?.ToString();
                            sb.AppendLine($"\"{cat}\";\"{uni}\";\"{tot}\";\"{pct}\"");
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
                        MessageBox.Show($"Informe exportado con éxito en:\n{sfd.FileName}", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
