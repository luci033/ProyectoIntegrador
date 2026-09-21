using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Compras
{
    public partial class FormRegistrarRecepcion : Form
    {
        private List<object[]> listaProductos; // Variable global

        // Actualizar constructor
        public FormRegistrarRecepcion(string nroOrden, string proveedor, string fechaOrden, List<object[]> detalles)
        {
            InitializeComponent();
            TBNroOrden.Text = nroOrden;
            TBProveedor.Text = proveedor;
            TBFechaOrden.Text = fechaOrden;
            listaProductos = detalles; // Asignar a la variable
        }

        public string FechaSeleccionada { get; private set; }
        public string Observacion { get; private set; }

        private void FormRegistrarRecepcion_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloGrilla(DGDetalleRecepcion);
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BAceptar);
            EstiloUI.AplicarEstiloBoton(BCancelar);
            TBFechaRecepcion.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Llenar grilla dinámicamente
            if (listaProductos != null)
            {
                foreach (var item in listaProductos)
                {
                    // Ajustar índices según las columnas de Recepción: [1] es Código, [2] es Nombre, [5] es Cantidad pedida
                    DGDetalleRecepcion.Rows.Add(item[1], item[2], item[3], item[5], "0");
                }
            }

            // Habilitamos la edición en la grilla
            DGDetalleRecepcion.ReadOnly = false;

            // Bloqueamos todas las columnas por defecto
            foreach (DataGridViewColumn col in DGDetalleRecepcion.Columns)
            {
                col.ReadOnly = true;
            }

            // Desbloqueamos SOLO la columna de "Cantidad Recibida" (asumiendo que es el índice 4)
            DGDetalleRecepcion.Columns[4].ReadOnly = false;
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in DGDetalleRecepcion.Rows)
            {
                string codigo = fila.Cells[0].Value.ToString();
                int cantPedida = Convert.ToInt32(fila.Cells[3].Value ?? 0);
                int cantRecibida = Convert.ToInt32(fila.Cells[4].Value ?? 0);

                // Validación: cantidad recibida no mayor a pedida
                if (cantRecibida > cantPedida)
                {
                    MessageBox.Show($"La cantidad recibida del producto {codigo} no puede ser mayor a la cantidad pedida ({cantPedida}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardamos la cantidad recibida en la lista original (índice 8)
                listaProductos[fila.Index][8] = cantRecibida.ToString();
            }

            FechaSeleccionada = TBFechaRecepcion.Text;
            Observacion = TBObservacion.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TBNroOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LFecha_Click(object sender, EventArgs e)
        {

        }

        private void TBFechaRecepcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBObservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
