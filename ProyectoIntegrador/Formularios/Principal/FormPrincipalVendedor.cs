using ProyectoIntegrador.Formularios.Clientes;
using ProyectoIntegrador.Formularios.Devoluciones;
using ProyectoIntegrador.Formularios.Productos;
using ProyectoIntegrador.Formularios.Ventas;
// Agregá los using de las otras carpetas si te los marca en rojo (ej: .Productos, .Clientes, .Inventario)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // Necesario para FirstOrDefault
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Principal
{
    public partial class FormPrincipalVendedor : Form
    {
        public FormPrincipalVendedor()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
        }

        private void CerrarFormulariosHijos()
        {
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }
        }

        // Método genérico para abrir cualquier formulario sin duplicados
        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formAbierto = this.MdiChildren.FirstOrDefault(x => x is T);

            if (formAbierto != null)
            {
                formAbierto.BringToFront();
                return;
            }

            CerrarFormulariosHijos();

            T nuevoForm = new T();
            nuevoForm.MdiParent = this;
            nuevoForm.WindowState = FormWindowState.Maximized;
            nuevoForm.Show();
        }

        private void BProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarProducto>();
        }

        private void BDevoluciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistrarDevolucion>();
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormClientes>();
        }

        private void BVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormOpcionesVenta>();
        }

        // Eventos viejos (podés borrarlos si ya los eliminaste del diseño)
        private void s(object sender, EventArgs e)
        {

        }

        private void listarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}