using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Ventas
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBDni_Validating(object sender, CancelEventArgs e)
        {
            string texto = TBDni.Text.Trim();

            //verifica si esta vacio
            if (String.IsNullOrEmpty(texto))
            {
                errorProvider1.SetError(TBDni, "EL DNI es obligatorio. ");
                return;
            }

            //alinea el error
            errorProvider1.SetIconAlignment(TBDni, ErrorIconAlignment.MiddleRight);
            //verifica si tiene numeros y si los dijistos estan entre 7 u 8
            if (texto.Length < 7 || texto.Length > 8 || !long.TryParse(texto, out _))
            {
                errorProvider1.SetError(TBDni, "El DNI debe contener solo numeros (7 u 8 dijitos). ");
                return;
            }

            //Si se paso correctamente las instancias anteriores se borra cualquier error previo
            errorProvider1.SetError(TBDni, "");
        }

        private void TBCliente_Validating(object sender, CancelEventArgs e)
        {
            string texto = TBCliente.Text.Trim();

            //verifica si esta vacio
            if (String.IsNullOrEmpty(texto))
            {
                errorProvider1.SetIconAlignment(TBCliente, ErrorIconAlignment.MiddleRight);
                errorProvider1.SetError(TBCliente, "Debe ingresar el nombre del cliente.");
                return;
            }


            //Si se paso correctamente las instancias anteriores se borra cualquier error previo
            errorProvider1.SetError(TBCliente, "");
        }

        private void TBTelefono_Validating(object sender, CancelEventArgs e)
        {
            string texto = TBTelefono.Text.Trim();

            // si esta vacio no hace nada
            if (string.IsNullOrEmpty(texto))
            {
                errorProvider1.SetError(TBTelefono, "");
                return;
            }

            //Si opcional, solo se valida en caso de que se rellene el campo
            if (!string.IsNullOrEmpty(texto) && !long.TryParse(texto, out _))
            {
                errorProvider1.SetIconAlignment(TBTelefono, ErrorIconAlignment.MiddleRight);
                errorProvider1.SetError(TBTelefono, "El teléfono debe contener únicamente números. ");
                return;
            }
            else
            {
                errorProvider1.SetError(TBTelefono, "");
            }
        }

        private void BCobrar_Click(object sender, EventArgs e)
        {
            //dispara la validacion de todos los controles del formulario
            if (!this.ValidateChildren())
            {
                return;
            }

            //revismaos si quedó algun carte de error activo
            if(!string.IsNullOrEmpty(errorProvider1.GetError(TBCliente)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBDni)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBTelefono)))
            {
                MessageBox.Show("Revise los campos marcados con error.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //revisamos que haya productos cargado en la tabla
            int totalProductos = dataGridProducto.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);
            if (totalProductos == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto antes de cobrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ActualizarTotalGeneral()
        {
            decimal totalVenta = 0;

            //recorremos cada renglon cargado en la tabla
            foreach (DataGridViewRow fila in dataGridProducto.Rows)
            {
                // se ignora la fila vacia de inserciin al final de la grilla
                if (fila.IsNewRow) continue;

                // Leemos el valor de la columna de subtotal y lo sumamos
                if (fila.Cells[4].Value != null && decimal.TryParse(fila.Cells[4].Value.ToString(), out decimal subtotal))
                {
                    totalVenta += subtotal;
                }
            }

            // Mostramos el total formateado como moneda en el TextBox
            TBTotal.Text = totalVenta.ToString("C2");
        }

        private void AgregarOActualizarProducto(int idProducto, string nombreJoya, decimal precioUnitario, int cantidadAAgregar)
        {
            DataGridViewRow filaEncontrada = null;

            // Busca si el producto ya esta en la grilla
            foreach (DataGridViewRow fila in dataGridProducto.Rows)
            {
                if (fila.IsNewRow) continue;

                // si compara el ID del producto
                if (Convert.ToInt32(fila.Cells[0].Value) == idProducto)
                {
                    filaEncontrada = fila;
                    break;
                }

                // Alternativa: Si comparan por texto ignorando mayúsculas/minúsculas
                string nombreEnTabla = fila.Cells[1].Value?.ToString() ?? "";
                if (string.Equals(nombreEnTabla.Trim(), nombreJoya.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    filaEncontrada = fila;
                    break;
                }
            }

            //si el porducto ya estaba en la grilla, se suma la cantidad
            if (filaEncontrada != null)
            {
                int cantidadActual = Convert.ToInt32(filaEncontrada.Cells[3].Value);
                int nuevaCantidad = cantidadActual + cantidadAAgregar;

                //actualiza la celda de cantidad
                filaEncontrada.Cells[3].Value = nuevaCantidad;

                // recalcula el subtotal de ese renglon
                filaEncontrada.Cells[4].Value = nuevaCantidad * precioUnitario;
            }
            // en caso de que sea un producto nuevo, se agrega el renglon
            else
            {
                decimal subtotal = cantidadAAgregar * precioUnitario;
                dataGridProducto.Rows.Add(idProducto, nombreJoya, precioUnitario, cantidadAAgregar, subtotal);
            }

            // actualiza el total general al final de la pantalla
            ActualizarTotalGeneral();
        }

        private void BAgregarProducto_Click(object sender, EventArgs e)
        {
            // prueba para ver como se cargan y suman:
            // (dpeues se reemplaza estos valores fijos por la seleccioen desde la BD)
            AgregarOActualizarProducto(1, "Anillo de Oro 18k", 150000m, 1);
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            // se verifica  si hay algun dato escrito o productos en la grilla antes de preguntar
            bool hayDatos = !string.IsNullOrEmpty(TBCliente.Text) ||
                            !string.IsNullOrEmpty(TBTelefono.Text) ||
                            !string.IsNullOrEmpty(TBDni.Text) ||
                            dataGridProducto.Rows.Cast<DataGridViewRow>().Any(r => !r.IsNewRow);

            if (hayDatos)
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de que desea cancelar la venta actual? Se perderán todos los datos cargados.",
                    "Confirmar cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                {
                    return; // en caso de que se eliga la opcion no, no pasa nada
                }
            }

            // en caso de que se confirme (o no habia nada cargado), se limpia la pantalla
            LimpiarFormularioVenta();
        }

        // Método auxiliar reutilizable para restablecer todo a cero
        private void LimpiarFormularioVenta()
        {
            // se limpia cajas de texto
            TBCliente.Clear();
            TBTelefono.Clear();
            TBDni.Clear();
            TBTotal.Text = "$ 0,00";

            // se limpia las filas de productos cargados
            dataGridProducto.Rows.Clear();

            // se borra cualquier iccono de advertencia activo del ErrorProvider
            errorProvider1.SetError(TBCliente, "");
            errorProvider1.SetError(TBTelefono, "");
            errorProvider1.SetError(TBDni, "");

            // devuelve el cursor al primer campo para una nueva venta
            TBCliente.Focus();
        }
    }
 }

    
    

