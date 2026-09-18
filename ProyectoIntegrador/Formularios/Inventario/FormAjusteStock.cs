using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Inventario
{
    public partial class FormAjusteStock : Form
    {
        public FormAjusteStock()
        {
            InitializeComponent();
        }

        private void LCodigoProducto_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAjusteStock_Load(object sender, EventArgs e)
        {
            //TBUsuarioActivo.Text = SesionActual.NombreUsuario; // O tu clase estática de sesión
            CBTipoAjuste.Items.AddRange(new string[] { "Ingreso", "Egreso" });
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TBCodigoProducto.Text, out _))
            {
                MessageBox.Show("El código de producto debe ser numérico.");
                return;
            }

            // Asigná acá TBNombreProducto.Text y TBStockActual.Text buscándolo en tu lista estática
        }

        private void BConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBNombreProducto.Text))
            {
                MessageBox.Show("Debe buscar un producto válido primero.");
                return;
            }

            if (!int.TryParse(TBCantidadAjustar.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad a ajustar debe ser un número mayor a cero.");
                return;
            }

            int stockActual = Convert.ToInt32(TBStockActual.Text);
            string tipoAjuste = CBTipoAjuste.SelectedItem?.ToString();

            // Solo se valida el límite de stock si es una resta (Egreso)
            if (tipoAjuste == "Egreso" && cantidad > stockActual)
            {
                MessageBox.Show("La cantidad a restar no puede ser mayor al stock actual.");
                return;
            }

            if (TBObservaciones.Text.Trim().Length < 5)
            {
                MessageBox.Show("Las observaciones deben contener al menos 5 caracteres.");
                return;
            }

            // Acá sumás o restás la variable 'cantidad' al stock del producto según 'tipoAjuste'
            // y guardás el registro en la lista estática AjusteStock.

            MessageBox.Show("Ajuste registrado con éxito.");
            this.Close();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            TBCodigoProducto.Clear();
            TBNombreProducto.Clear();
            TBStockActual.Clear();
            TBCantidadAjustar.Clear();
            TBObservaciones.Clear();
            CBTipoAjuste.SelectedIndex = -1;
            this.Close();
        }
    }
}
