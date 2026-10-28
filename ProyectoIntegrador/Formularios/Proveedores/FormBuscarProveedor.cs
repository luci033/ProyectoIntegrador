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

using CapaEntidades;
using CapaNegocio;

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
        public int IdProveedor { get; private set; }
        public string RazonSocial { get; private set; }
        public string CUIT { get; private set; }
        public string Telefono { get; private set; }
        public string CorreoElectronico { get; private set; }

        private List<Proveedor> listaProveedores;


        private void FormBuscarProveedor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);
            EstiloUI.AplicarEstiloGrilla(DGProveedores);

            /*DGProveedores.Rows.Clear();
            try
            {
                var lista = new CN_Proveedor().ListarProveedores();
                foreach (var prov in lista)
                {
                    int idx = DGProveedores.Rows.Add(prov.RazonSocial, prov.CUIT, prov.Telefono, prov.CorreoElectronico);
                    DGProveedores.Rows[idx].Tag = prov.IdProveedor;
                }
            }*/
            try
            {
                // 1. Guardamos la lista completa en la variable global
                listaProveedores = new CN_Proveedor().ListarProveedores();
                CargarGrilla(listaProveedores);
            }
            catch { }
        }

        // Método auxiliar para pintar la grilla ordenadamente
        private void CargarGrilla(List<Proveedor> lista)
        {
            DGProveedores.Rows.Clear();
            foreach (var prov in lista)
            {
                int idx = DGProveedores.Rows.Add(prov.RazonSocial, prov.CUIT, prov.Telefono, prov.CorreoElectronico);
                DGProveedores.Rows[idx].Tag = prov.IdProveedor;
            }
        } 

        private void DGProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita errores al hacer clic en el encabezado
            {
                DataGridViewRow fila = DGProveedores.Rows[e.RowIndex];

                IdProveedor = fila.Tag != null ? Convert.ToInt32(fila.Tag) : 0;
                RazonSocial = fila.Cells[0].Value?.ToString();
                CUIT = fila.Cells[1].Value?.ToString();
                Telefono = fila.Cells[2].Value?.ToString();
                CorreoElectronico = fila.Cells[3].Value?.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TBBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            if (listaProveedores == null) return;

            string filtro = TBBuscarProveedor.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filtro))
            {
                CargarGrilla(listaProveedores);
            }
            else
            {
                // Filtramos por Razón Social o CUIT usando LINQ
                var listaFiltrada = listaProveedores.Where(p =>
                    (p.RazonSocial != null && p.RazonSocial.ToLower().Contains(filtro)) ||
                    (p.CUIT != null && p.CUIT.ToLower().Contains(filtro))
                ).ToList();

                CargarGrilla(listaFiltrada);
            }
        }
    }
}
