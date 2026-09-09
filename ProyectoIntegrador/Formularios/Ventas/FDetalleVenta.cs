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

        public FDetalleVenta(int IdVenta)
        {
            InitializeComponent();

            //se configura la cabecera
            LInfoVenta.Text = $"Detalle del Comprobante N°: {IdVenta}";
                CargarArticulosSimulados(IdVenta);

        }

        private void CargarArticulosSimulados (int IdVenta)
        {
            dataGridDetalle.Rows.Clear();

            // simulamos articulos segun el id seleccionado
            List<ItemDetalle> articulos = new List<ItemDetalle>();

            if (IdVenta == 1001)
            {
                articulos.Add(new ItemDetalle { Producto = "Anillo de Oro 18k", Cantidad = 1, PrecioUnitario = 150000m });
            }
            else if (IdVenta == 1002)
            {
                articulos.Add(new ItemDetalle { Producto = "Aros de Plata 925", Cantidad = 2, PrecioUnitario = 22750.25m });
            }
            else
            {
                articulos.Add(new ItemDetalle { Producto = "Cadena de Oro Blanco", Cantidad = 1, PrecioUnitario = 320000m });
            }

            // poblamos la grilla
            foreach (var item in articulos)
            {
                dataGridDetalle.Rows.Add(
                    item.Producto,
                    item.Cantidad,
                    item.PrecioUnitario.ToString("C2"),
                    item.Subtotal.ToString("C2")
                );
            }
        }

        private void FDetalleVenta_Load(object sender, EventArgs e)
        {

        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
