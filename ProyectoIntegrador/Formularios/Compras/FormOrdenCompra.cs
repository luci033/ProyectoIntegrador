using ProyectoIntegrador.Formularios.Productos;
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
    public partial class FormOrdenCompra : Form
    {
        public FormOrdenCompra()
        {
            InitializeComponent();
        }

        private void FormOrdenCompra_Load(object sender, EventArgs e)
        {
            // cargo fecha del sistema
            TBFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            DGDetalleOrden.ReadOnly = false;

            /*foreach (DataGridViewColumn col in DGDetalleOrden.Columns)
            {
                // solo se permite editar la columna de cantidad
                if (col.Index != 5)
                {
                    col.ReadOnly = true;
                }
            } */
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BRegistrarCompra_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            // Asumiendo que tenés un formulario llamado FormBuscarProveedor
            using (FormBuscarProveedor formBuscar = new FormBuscarProveedor())
            {
                if (formBuscar.ShowDialog() == DialogResult.OK)
                {
                    TBRazonSocial.Text = formBuscar.RazonSocial;
                    TBCUIT.Text = formBuscar.CUIT;
                    TBContacto.Text = formBuscar.Telefono; // Puede ser el teléfono o correo
                    TBCorreo.Text = formBuscar.Correo;
                }
            }
        }

        private void BAgregarProducto_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TBRazonSocial.Text))
            {
                MessageBox.Show("Primero debés seleccionar un proveedor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (FormBuscarProducto formProducto = new FormBuscarProducto())
            {
                if (formProducto.ShowDialog() == DialogResult.OK)
                {
                    int cantidad = 1; // Cantidad por defecto
                    decimal subtotal = formProducto.CostoCompra * cantidad;

                    // Orden de las columnas: IdProducto, Codigo, Nombre, Cantidad, CostoCompra, Subtotal
                    DGDetalleOrden.Rows.Add(
                        formProducto.IdProducto,
                        formProducto.Codigo,
                        formProducto.Nombre,
                        formProducto.Categoria,
                        formProducto.Genero,
                        cantidad,
                        formProducto.CostoCompra,
                        subtotal
                    );

                    CalcularTotal(); // Llama a la función que suma todo
                }
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in DGDetalleOrden.Rows)
            {
                // El índice 5 corresponde a la columna "Subtotal" en el Add de arriba
                if (fila.Cells[7].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells[7].Value);
                }
            }

            // TBTotal es tu TextBox o Label del final. "C2" le da formato de moneda ($).
            TBTotal.Text = total.ToString("C2");
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Propiedades para enviar al formulario principal
        public string Proveedor => TBRazonSocial.Text;
        public string Fecha => TBFecha.Text;
        public string Total => TBTotal.Text;

        private void BGenerarOrden_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Proveedor) || DGDetalleOrden.Rows.Count == 0)
            {
                MessageBox.Show("Faltan datos o productos.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DGDetalleOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGDetalleOrden_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DGDetalleOrden.IsCurrentCellDirty)
            {
                DGDetalleOrden.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DGDetalleOrden_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
    
            int colCantidad = 5;
            int colCosto = 6;
            int colSubtotal = 7;

            // Si se modificó una fila válida y la columna tocada es "Cantidad"
            if (e.RowIndex >= 0 && e.ColumnIndex == colCantidad)
            {
                DataGridViewRow fila = DGDetalleOrden.Rows[e.RowIndex];

                // Convertimos a decimal para poder multiplicar
                decimal cantidad = Convert.ToDecimal(fila.Cells[colCantidad].Value ?? 0);
                decimal costo = Convert.ToDecimal(fila.Cells[colCosto].Value ?? 0);

                // Actualizamos el subtotal de esa fila
                fila.Cells[colSubtotal].Value = cantidad * costo;

                // Llamamos a la función que ya habías creado antes para sumar la columna de subtotales
                CalcularTotal();
            }
        }
    }
}
