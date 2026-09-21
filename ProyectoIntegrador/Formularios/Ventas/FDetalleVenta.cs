using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Ventas
{
    public partial class FDetalleVenta : Form
    {
        //modelo para representar un renglos del detalle
        public class ItemDetalle
        {
            public string Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Subtotal => Cantidad * PrecioUnitario;
        }

        // Reemplazá tu constructor y tu método de carga por estos dos:
        public FDetalleVenta(FormVentas.DatosVenta ventaData)
        {
            InitializeComponent();

            LInfoVenta.Text = $"Detalle del Comprobante N°: {ventaData.Nro}";
            TBNroVenta.Text = ventaData.Nro.ToString("D5");
            textBox5.Text = ventaData.Fecha;
            textBox3.Text = ventaData.MetodoPago;
            TBRazonSocial.Text = ventaData.Cliente;
            TBCondicionIVA.Text = ventaData.Iva;

            // CUIT y Teléfono quedan fijos temporales ya que no los estamos trayendo del buscador
            TBCUITDNI.Text = "20-11222333-3";
            TBTeléfono.Text = "3794111111";

            CargarArticulosDinámicos(ventaData);
        }

        private void CargarArticulosDinámicos(FormVentas.DatosVenta ventaData)
        {
            dataGridDetalle.Rows.Clear();
            decimal totalGeneral = 0;

            foreach (var item in ventaData.Articulos)
            {
                dataGridDetalle.Rows.Add(
                    "", // Espacio vacío para la columna oculta ID
                    item.Producto,
                    item.Cantidad,
                    item.PrecioUnitario.ToString("C2"),
                    item.Subtotal.ToString("C2")
                );
                totalGeneral += item.Subtotal;
            }

            // Asumiendo que tenés un textbox llamado TBTotal en tu diseño
            TBTotal.Text = totalGeneral.ToString("C2"); 
        }

        private void FDetalleVenta_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 10);
            EstiloUI.AplicarEstiloCard(panelCard, 12);
            EstiloUI.AplicarEstiloBoton(BCerrar);
            EstiloUI.AplicarEstiloGrilla(dataGridDetalle);

            EstiloUI.AplicarEstiloTextBox(TBNroVenta);
            EstiloUI.AplicarEstiloTextBox(textBox5);
            EstiloUI.AplicarEstiloTextBox(TBCUITDNI);
            EstiloUI.AplicarEstiloTextBox(TBRazonSocial);
            EstiloUI.AplicarEstiloTextBox(TBCondicionIVA);
            EstiloUI.AplicarEstiloTextBox(TBTeléfono);
            EstiloUI.AplicarEstiloTextBox(textBox3);
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
