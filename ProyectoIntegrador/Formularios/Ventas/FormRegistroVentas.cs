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
    public partial class FormRegistroVentas : Form
    {
        public FormRegistroVentas()
        {
            InitializeComponent();
        }

        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloGrilla(dataGridProducto);
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BAgregarProducto);
            EstiloUI.AplicarEstiloBoton(BBuscarCliente);
            EstiloUI.AplicarEstiloBoton(BCancelar);
            EstiloUI.AplicarEstiloBoton(BCobrar);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BCobrar_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarTotalGeneral()
        {

        }

        private void AgregarOActualizarProducto(int idProducto, string nombreJoya, decimal precioUnitario, int cantidadAAgregar)
        {

        }

        private void BAgregarProducto_Click(object sender, EventArgs e)
        {
            
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
 }

    
    

