using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Compras
{
    public partial class FormBuscarProveedor : Form
    {
        public FormBuscarProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Propiedades públicas para enviar los datos
        public string RazonSocial { get; private set; }
        public string CUIT { get; private set; }
        public string Telefono { get; private set; }
        public string Correo{ get; private set; }


        private void FormBuscarProveedor_Load(object sender, EventArgs e)
        {
            //datos de prueba
            DGProveedores.Rows.Add("Joyas del Sur S.A.", "30556667778", "3794223344", "ventas@joyasdelsur.com");
            DGProveedores.Rows.Add("Insumos Metálicos", "33445558889", "3794556677", "contacto@insumosmetalicos.com");
            DGProveedores.Rows.Add("Platería El Rey", "30998887776", "3794889900", "info@plateriaelrey.com");
            DGProveedores.Rows.Add("Gemas y Cristales SRL", "30123456789", "3794123456", "pedidos@gemasycristales.com.ar");
            DGProveedores.Rows.Add("Distribuidora Oro Fino", "33987654321", "3794654321", "ventas@orofino.com");
        }

        private void DGProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita errores al hacer clic en el encabezado
            {
                DataGridViewRow fila = DGProveedores.Rows[e.RowIndex];

                RazonSocial = fila.Cells[0].Value?.ToString();
                CUIT = fila.Cells[1].Value?.ToString();
                Telefono = fila.Cells[2].Value?.ToString();
                Correo = fila.Cells[3].Value?.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void DGProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
