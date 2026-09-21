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
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel3, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 12);
            EstiloUI.AplicarEstiloBoton(BAgregarProducto);
            EstiloUI.AplicarEstiloBoton(BBuscarCliente);
            EstiloUI.AplicarEstiloBoton(BCobrar);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);
            EstiloUI.AplicarEstiloTextBox(textBox1);
            EstiloUI.AplicarEstiloTextBox(TBVendedor);
            EstiloUI.AplicarEstiloTextBox(TBFecha);
            EstiloUI.AplicarEstiloTextBox(TBCliente);
            EstiloUI.AplicarEstiloTextBox(TBCondicionIVA);
            EstiloUI.AplicarEstiloTextBox(TBTotal);
            EstiloUI.AplicarEstiloGrilla(dataGridProducto);
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

    
    

