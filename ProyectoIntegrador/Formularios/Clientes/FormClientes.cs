using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Clientes
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            // instanciamos el formulario de ABM
            FormClientesABM formNuevoCliente = new FormClientesABM();

            // se de forma modal (bloquea el fondo hasta que se termine de registrar o cancelar)
            formNuevoCliente.ShowDialog();
        }
    }
}
