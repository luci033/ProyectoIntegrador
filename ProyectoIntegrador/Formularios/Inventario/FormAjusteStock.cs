using CapaEntidades;
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
        public FormAjusteStock(string nombreUsuario)
        {
            InitializeComponent();
            usuarioLogueado = nombreUsuario;
        }
        

        private void LCodigoProducto_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            // 1. Validación de producto seleccionado
            if (string.IsNullOrWhiteSpace(TBCodigoProducto.Text) || string.IsNullOrWhiteSpace(TBNombreProducto.Text))
            {
                MessageBox.Show("Debe buscar y seleccionar un producto válido antes de registrar el ajuste.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBCodigoProducto.Focus();
                return;
            }

            // 2. Validación de tipo de ajuste
            if (CBTipoAjuste.SelectedItem == null || string.IsNullOrWhiteSpace(CBTipoAjuste.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, seleccione el tipo de ajuste ('Ingreso' o 'Egreso').", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBTipoAjuste.Focus();
                return;
            }
            string tipoAjuste = CBTipoAjuste.SelectedItem.ToString();

            // 3. Validación de cantidad numérica mayor a 0
            if (!int.TryParse(TBCantidadAjustar.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad a ajustar debe ser un número entero mayor a cero.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBCantidadAjustar.Focus();
                TBCantidadAjustar.SelectAll();
                return;
            }

            // 4. Validación de observaciones mínimas
            string observaciones = TBObservaciones.Text.Trim();
            if (observaciones.Length < 5)
            {
                MessageBox.Show("Debe ingresar un motivo u observación descriptiva de al menos 5 caracteres justificando el ajuste.", "Observaciones Requeridas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBObservaciones.Focus();
                return;
            }

            string codigo = TBCodigoProducto.Text.Trim();
            string operador = string.IsNullOrWhiteSpace(TBUsuarioActivo.Text) ? "Operador Logística" : TBUsuarioActivo.Text.Trim();

            // 5. Aplicación del ajuste en el repositorio en memoria
            bool ok = StockSimulado.AplicarAjuste(codigo, tipoAjuste, cantidad, operador, observaciones, out int stockAnterior, out int stockNuevo, out string mensajeError);

            if (!ok)
            {
                MessageBox.Show(mensajeError, "Ajuste Rechazado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualización visual inmediata en pantalla
            TBStockActual.Text = stockNuevo.ToString();

            string signo = tipoAjuste.Equals("Ingreso", StringComparison.OrdinalIgnoreCase) ? "+" : "-";

            MessageBox.Show(
                /*$"Ajuste de stock registrado exitosamente.\n\n" +
                $"• Joya: {TBNombreProducto.Text} (Cód: {codigo})\n" +
                $"• Operación: {tipoAjuste} ({signo}{cantidad} unidades)\n" +
                $"• Stock Anterior: {stockAnterior} unidades\n" +
                $"• Nuevo Stock Disponible: {stockNuevo} unidades\n" +
                $"• Operador: {operador}\n\n" +
                $"El stock se ha actualizado en todo el sistema."*/
                "Ajuste realizado con éxito.",
                "Ajuste Confirmado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Volver al panel principal cerrando la ventana
            this.Close();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
