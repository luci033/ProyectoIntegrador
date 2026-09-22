using ProyectoIntegrador.ModelosSimulados;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Gerente
{
    public partial class FormInformesEstadisticos : Form
    {
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

            var datos = EstadisticasSimuladas.ObtenerInformeCategorias(desde, hasta);

            DGInforme.Rows.Clear();
            decimal totalFacturacion = 0;
            int totalUnidades = 0;
            string categoriaLider = "-";
            decimal maxRecaudacion = -1;

            foreach (var item in datos)
            {
                totalFacturacion += item.TotalRecaudado;
                totalUnidades += item.UnidadesVendidas;

                if (item.TotalRecaudado > maxRecaudacion)
                {
                    maxRecaudacion = item.TotalRecaudado;
                    categoriaLider = item.Categoria;
                }

                DGInforme.Rows.Add(
                    item.Categoria,
                    item.UnidadesVendidas + " piezas",
                    item.TotalRecaudado.ToString("C0"),
                    item.Porcentaje.ToString("F1") + "%"
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
                        sb.AppendLine("INFORME ESTADISTICO DE VENTAS - JOYERIA ALBA");
                        sb.AppendLine($"Periodo,{DTPDesde.Value:dd/MM/yyyy} al {DTPHasta.Value:dd/MM/yyyy}");
                        sb.AppendLine($"Fecha Emision,{DateTime.Now:dd/MM/yyyy HH:mm}");
                        sb.AppendLine($"Facturacion Total,{LTotalValor.Text.Replace(",", "")}");
                        sb.AppendLine($"Total Unidades,{LUnidadesValor.Text}");
                        sb.AppendLine($"Ticket Promedio,{LPromedioValor.Text.Replace(",", "")}");
                        sb.AppendLine($"Categoria Lider,{LLiderValor.Text}");
                        sb.AppendLine();
                        sb.AppendLine("Categoria,Unidades Vendidas,Facturacion Total,Participacion %");

                        foreach (DataGridViewRow row in DGInforme.Rows)
                        {
                            if (row.IsNewRow) continue;
                            string cat = row.Cells[0].Value?.ToString();
                            string uni = row.Cells[1].Value?.ToString();
                            string tot = row.Cells[2].Value?.ToString().Replace(",", "").Replace("$", "").Trim();
                            string pct = row.Cells[3].Value?.ToString();
                            sb.AppendLine($"\"{cat}\",\"{uni}\",\"{tot}\",\"{pct}\"");
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
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
