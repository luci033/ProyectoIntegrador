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
    public partial class DetalleClientes : Form
    {
        public DetalleClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DetalleClientes_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloGrilla(dataGridDetalleCliente);

        }

        public void CargarDatosCliente(string nombre, string correo, string condicionIva, string dni)
        {
            TBNombre.Text = nombre;
            TBCorreo.Text = correo;
            cmbCondicionIVA.Text = condicionIva;
            TBDni.Text = dni;
        }

        private void BFiltrar_Click(object sender, EventArgs e)
        {
          
            DateTime fechaInicio = DTPDesde.Value.Date;
            DateTime fechaFin = DTPHasta.Value.Date;

            // validamos que el rango de fechas tenga sentido lógico
            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor a la fecha 'Hasta'.", "Filtro inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Cortamos la ejecución para que no intente buscar nada
            }

            // si pasa las validaciones realiza la busqueda
            MessageBox.Show("Fechas correctas. Buscando historial...", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
