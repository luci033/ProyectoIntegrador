using CapaEntidades;
using CapaNegocio;
using CapaDatos;
using ProyectoIntegrador.Formularios.Productos;
using ProyectoIntegrador.ModelosSimulados;
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
        private string usuarioLogueado;
        private int IdProductoSeleccionado = 0;
        private int IdUsuarioLogueado = 1;
        private CN_Producto cnProducto = new CN_Producto();
        private CN_AjusteStock cnAjusteStock = new CN_AjusteStock();
        public FormAjusteStock(string nombreUsuario)
        {
            InitializeComponent();
            usuarioLogueado = nombreUsuario;
        }
        

        private void FormAjusteStock_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloCard(panelCard, 16);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 12);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 12);
            EstiloUI.AplicarEstiloBoton(BBuscarProducto);
            EstiloUI.AplicarEstiloBoton(BConfirmar);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);

            EstiloUI.AplicarEstiloTextBox(TBUsuarioActivo);
            EstiloUI.AplicarEstiloTextBox(TBCodigoProducto);
            EstiloUI.AplicarEstiloTextBox(TBNombreProducto);
            EstiloUI.AplicarEstiloTextBox(TBStockActual);
            EstiloUI.AplicarEstiloTextBox(TBCantidadAjustar);
            EstiloUI.AplicarEstiloTextBox(TBObservaciones);

            TBStockActual.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
            TBStockActual.ForeColor = EstiloUI.ColorBorgoña;

            EstiloUI.CentrarControl(panelCard, this);

            TBUsuarioActivo.Text = usuarioLogueado;
            TBUsuarioActivo.ReadOnly = true;


            TBNombreProducto.ReadOnly = true;
            TBStockActual.ReadOnly = true;

            CBTipoAjuste.Items.Clear();
            CBTipoAjuste.Items.AddRange(new string[] { "Ingreso", "Egreso" });
            CBTipoAjuste.SelectedIndex = 0;

            // Atajo de teclado Enter en caja de código
            TBCodigoProducto.KeyDown += TBCodigoProducto_KeyDown;
        }

        private void TBCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BBuscarProducto_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true; // Evita el pitido de Windows
            }
        }

        private void FormAjusteStock_Resize(object sender, EventArgs e)
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            string codigoIngresado = TBCodigoProducto.Text.Trim();

            // Si el código está vacío, abrimos directamente el selector modal
            if (string.IsNullOrWhiteSpace(codigoIngresado))
            {
                AbrirSelectorProductoModal();
                return;
            }

            //se busca en la BD a traves de la CN
            DataTable dt = cnProducto.Listar();
            DataRow[] filas = dt.Select($"IdProducto = '{codigoIngresado}'"); //REVISAR

            if(filas.Length > 0)
            {
                DataRow row = filas[0];
                IdProductoSeleccionado = Convert.ToInt32(row["IdProducto"]);
                TBCodigoProducto.Text = row["IdProducto"].ToString();
                TBNombreProducto.Text = row["NombreProducto"].ToString();
                TBStockActual.Text = row["StockActual"].ToString();
                TBCantidadAjustar.Focus();
            }
            else
            {
                MessageBox.Show(
                    $"No se encontró ningún producto con el código '{codigoIngresado}'.",
                    "Producto no encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LimpiarCamposProducto();
            }

            /*
            // Buscar en el catálogo estático en memoria
            var producto = StockSimulado.BuscarPorCodigo(codigoIngresado);

            if (producto != null)
            {
                TBCodigoProducto.Text = producto.Codigo;
                TBNombreProducto.Text = producto.Nombre;
                TBStockActual.Text = producto.StockActual.ToString();
                TBCantidadAjustar.Focus();
            }
            else
            {
                DialogResult res = MessageBox.Show(
                    $"No se encontró ningún producto activo con el código '{codigoIngresado}'.\n\n¿Desea abrir el catálogo de búsqueda de productos para seleccionarlo?",
                    "Producto no encontrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (res == DialogResult.Yes)
                {
                    AbrirSelectorProductoModal();
                }
                else
                {
                    TBNombreProducto.Clear();
                    TBStockActual.Clear();
                    TBCodigoProducto.Focus();
                    TBCodigoProducto.SelectAll();
                }
            }
            */
        }

        private void LimpiarCamposProducto()
        {
            IdProductoSeleccionado = 0;
            TBNombreProducto.Clear();
            TBStockActual.Clear();
            TBCodigoProducto.Focus();
            TBCodigoProducto.SelectAll();
        }

        private void AbrirSelectorProductoModal()
        {
            using (FormBuscarProducto formBuscar = new FormBuscarProducto())
            {
                formBuscar.ConfigurarParaVentas(); // Muestra stock y precios

                if (formBuscar.ShowDialog() == DialogResult.OK)
                {
                    TBCodigoProducto.Text = formBuscar.Codigo;
                    TBNombreProducto.Text = formBuscar.Nombre;
                    TBStockActual.Text = formBuscar.Stock.ToString();
                    TBCantidadAjustar.Focus();
                }
            }
        }

        private void BConfirmar_Click(object sender, EventArgs e)
        {

            //Validamos el producto seleccionado
            if (IdProductoSeleccionado <= 0)
            {
                MessageBox.Show("Debe buscar y seleccionar un producto válido antes de registrar el ajuste.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBCodigoProducto.Focus();
                return;
            }

            // Validamos el tipo de ajuste
            if (CBTipoAjuste.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione el tipo de ajuste ('Ingreso' o 'Egreso').", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tipoAjuste = CBTipoAjuste.SelectedItem.ToString();

            // Validamos la cantidad numérica: mayor a 0
            if (!int.TryParse(TBCantidadAjustar.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad a ajustar debe ser un número entero mayor a cero.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBCantidadAjustar.Focus();
                TBCantidadAjustar.SelectAll();
                return;
            }

            // validacion de observaciones mínimas
            string observaciones = TBObservaciones.Text.Trim();
            if (observaciones.Length < 5)
            {
                MessageBox.Show("Debe ingresar un motivo u observación descriptiva de al menos 5 caracteres.", "Observaciones Requeridas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBObservaciones.Focus();
                return;
            }

            // Stock actual en pantalla para validar egresos
            int stockActual = Convert.ToInt32(TBStockActual.Text);

            // Se llama a la Capa de Negocio real para impactar en SQL Server
            bool resultado = cnAjusteStock.RegistrarAjuste(
                IdProductoSeleccionado,
                IdUsuarioLogueado,
                tipoAjuste,
                cantidad,
                observaciones,
                stockActual,
                out string mensajeError
            );

            if (!resultado)
            {
                MessageBox.Show(mensajeError, "Ajuste Rechazado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Ajuste de stock registrado y aplicado en la base de datos con éxito.", "Ajuste Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LCodigoProducto_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }
}
