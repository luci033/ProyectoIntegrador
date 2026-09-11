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
    public partial class FormVerDetalle : Form
    {
        public FormVerDetalle(string nro, string prov, string fecha, string recep, string obs, string total)
        {
            InitializeComponent();

            TBNroOrden.Text = nro;
            TBProveedor.Text = prov;
            TBFechaEmision.Text = fecha;
            TBFechaRecepcion.Text = recep;
            TBObservacion.Text = obs;
            TBTotalGeneral.Text = total;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormVerDetalle_Load(object sender, EventArgs e)
        { 
            DGDetalleOrden.Rows.Add(1 ,"1123456", "Collar Rubí", "Collares", "Femenino", 2, "$ 155.760,00", "$ 311.520,00");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DGDetalleOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
