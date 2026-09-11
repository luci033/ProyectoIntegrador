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
        public FormRegistrarRecepcion()
        {
            InitializeComponent();
        }

        public string FechaSeleccionada { get; private set; }
        public string Observacion { get; private set; }

        private void FormRegistrarRecepcion_Load(object sender, EventArgs e)
        {
            // fecha del sistema
            TBFechaRecepcion.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
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
    }
}
