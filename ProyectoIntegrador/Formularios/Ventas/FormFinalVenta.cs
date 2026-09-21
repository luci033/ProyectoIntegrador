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
    public partial class FormCobro : Form
    {
        public string MetodoPagoSeleccionado { get; private set; } = "";

        public FormCobro(string nombreCliente, string totalVenta)
        {
            InitializeComponent();
            // se muestra los datos recibidos en las cajas de texto y las bloqueamos
            TBClienteCobro.Text = nombreCliente;
            TBTotalCobro.Text = totalVenta;
            TBClienteCobro.ReadOnly = true;
            TBTotalCobro.ReadOnly = true;
        }


        private void checkedListBoxMP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // se valida que selecciono al menos un metodo de pago
            if (RBEfectivo.Checked) 
            {
                MetodoPagoSeleccionado = "Efectivo";
            }
            else if (RBTarjeta.Checked)
            {
                MetodoPagoSeleccionado = "Tarjeta";
            }
            else if (RBOtro.Checked)
            {
                MetodoPagoSeleccionado = "Otro";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un método de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // si se eligio un metodo, se cierra
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        

        private void FromCobro_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloCard(panelCard, 14);
            EstiloUI.AplicarEstiloBoton(BFinalizarVenta);
            EstiloUI.AplicarEstiloBotonSecundario(BVolver);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);
            EstiloUI.AplicarEstiloTextBox(TBClienteCobro);
            EstiloUI.AplicarEstiloTextBox(TBTotalCobro);
        }

        //cierra el modal sin cancelar la venta
        private void BVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //anula la operacion completa
        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort; //se usa abort para distinguir de volver
            this.Close();
        }


    }
}
