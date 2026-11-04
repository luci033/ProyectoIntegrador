using CapaEntidades;
using CapaNegocio;
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
        // Modelo para representar un renglón del detalle
        public class ItemDetalle
        {
            public string Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Subtotal => Cantidad * PrecioUnitario;
        }

        // Constructor con persistencia real desde la base de datos
        public FDetalleVenta(int idComprobante)
        {
            InitializeComponent();

            BloquearCampos();

            try
            {
                Comprobante venta = new CN_Venta().ObtenerVentaPorId(idComprobante);
                if (venta != null)
                {
                    LInfoVenta.Text = $"Detalle del Comprobante N°: {venta.IdComprobante:D5}";
                    TBNroVenta.Text = venta.IdComprobante.ToString("D5");
                    textBox5.Text = venta.FechaComprobante.ToString("dd/MM/yyyy HH:mm");
                    textBox3.Text = !string.IsNullOrWhiteSpace(venta.DescripcionMedioPago) ? venta.DescripcionMedioPago : "Contado";
                    TBRazonSocial.Text = venta.NombreCliente;
                    TBCondicionIVA.Text = !string.IsNullOrWhiteSpace(venta.CondicionIvaCliente) ? venta.CondicionIvaCliente : "Consumidor Final";
                    TBCUITDNI.Text = !string.IsNullOrWhiteSpace(venta.DocumentoCliente) ? venta.DocumentoCliente : "-";
                    TBTeléfono.Text = !string.IsNullOrWhiteSpace(venta.TelefonoCliente) ? venta.TelefonoCliente : "-";

                    dataGridDetalle.Rows.Clear();
                    decimal totalGeneral = 0;

                    foreach (var item in venta.Detalles)
                    {
                        dataGridDetalle.Rows.Add(
                            item.IdProducto,
                            item.NombreProducto,
                            item.Cantidad,
                            item.PrecioUnitario.ToString("C2"),
                            item.Subtotal.ToString("C2")
                        );
                        totalGeneral += item.Subtotal;
                    }

                    TBTotal.Text = totalGeneral.ToString("C2");
                }
                else
                {
                    MessageBox.Show("No se encontró el comprobante solicitado en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle del comprobante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Constructor para compatibilidad previa
        public FDetalleVenta(FormVentas.DatosVenta ventaData)
        {
            InitializeComponent();

            BloquearCampos();

            if (ventaData != null)
            {
                LInfoVenta.Text = $"Detalle del Comprobante N°: {ventaData.Nro:D5}";
                TBNroVenta.Text = ventaData.Nro.ToString("D5");
                textBox5.Text = ventaData.Fecha;
                textBox3.Text = ventaData.MetodoPago;
                TBRazonSocial.Text = ventaData.Cliente;
                TBCondicionIVA.Text = ventaData.Iva;

                TBCUITDNI.Text = "-";
                TBTeléfono.Text = "-";

                CargarArticulosDinámicos(ventaData);
            }
        }

        private void BloquearCampos()
        {
            TBNroVenta.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox3.ReadOnly = true;
            TBRazonSocial.ReadOnly = true;
            TBCondicionIVA.ReadOnly = true;
            TBCUITDNI.ReadOnly = true;
            TBTeléfono.ReadOnly = true;
            TBTotal.ReadOnly = true;
        }

        private void CargarArticulosDinámicos(FormVentas.DatosVenta ventaData)
        {
            dataGridDetalle.Rows.Clear();
            decimal totalGeneral = 0;

            foreach (var item in ventaData.Articulos)
            {
                dataGridDetalle.Rows.Add(
                    "",
                    item.Producto,
                    item.Cantidad,
                    item.PrecioUnitario.ToString("C2"),
                    item.Subtotal.ToString("C2")
                );
                totalGeneral += item.Subtotal;
            }

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
            EstiloUI.AplicarEstiloTextBox(TBTotal);
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
