using System;
using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Clientes
{
    public partial class FormClientesABM : Form
    {
        public ClienteSimulado ClienteCreado { get; private set; }
        public int IdClienteGenerado { get; private set; }
        public CapaEntidades.Cliente ClienteRegistrado { get; private set; }
        public List<string> DnisExistentes = new List<string>();
        private string dniOriginal = "";
        private string condicionIvaPendiente = null;
        private int idCondicionIvaPendiente = 0;
        private int idClienteActual = 0; // Si es 0, es un alta nueva. Si tiene valor, es una modificación.
        public FormClientesABM()
        {
            InitializeComponent();
        }

        public class ClienteSimulado
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string DNI { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string CondicionIVA { get; set; }
        }

        private void FormClientesABM_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloCard(panelCard, 16);
            if (panelAvatar != null) EstiloUI.AplicarEstiloPanelSeccion(panelAvatar, 12);
            EstiloUI.AplicarEstiloBoton(BRegistrarCliente);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);
            EstiloUI.CentrarControl(panelCard, this);

            CargarCondicionIVA();

            CargarDnisExistentes();

            if (!string.IsNullOrWhiteSpace(condicionIvaPendiente) || idCondicionIvaPendiente > 0)
            {
                SeleccionarCondicionIVA(condicionIvaPendiente, idCondicionIvaPendiente);
            }
            else if (idClienteActual == 0)
            {
                cmbCondicionIVA.SelectedIndex = -1;
            } 

        }

        private void FormClientesABM_Resize(object sender, EventArgs e)
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void CargarDnisExistentes()
        {
            if (DnisExistentes == null)
            {
                DnisExistentes = new List<string>();
            }

            if (DnisExistentes.Count == 0)
            {
                try
                {
                    CN_Cliente negocio = new CN_Cliente();
                    DataTable dt = negocio.Listar();
                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row.Table.Columns.Contains("DNICUIT") && row["DNICUIT"] != DBNull.Value)
                            {
                                string d = row["DNICUIT"].ToString().Trim();
                                if (!string.IsNullOrEmpty(d) && !DnisExistentes.Contains(d))
                                {
                                    DnisExistentes.Add(d);
                                }
                            }
                        }
                    }
                }
                catch { }
            }
        }

        private void BRegistrarCliente_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(TBNombre.Text) || !TBNombre.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            { errorProvider1.SetError(TBNombre, "Inválido"); esValido = false; }

            if (string.IsNullOrWhiteSpace(TBApellido.Text) || !TBApellido.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            { errorProvider1.SetError(TBApellido, "Inválido"); esValido = false; }

            if (string.IsNullOrWhiteSpace(TBDni.Text) || !TBDni.Text.All(char.IsDigit) || TBDni.Text.Length < 7 || TBDni.Text.Length > 11)
            { errorProvider1.SetError(TBDni, "Inválido (entre 7 y 11 dígitos)"); esValido = false; }

            // 2. Validación de Teléfono (solo números)
            if (string.IsNullOrWhiteSpace(TBTelefono.Text) || !TBTelefono.Text.All(char.IsDigit))
            { errorProvider1.SetError(TBTelefono, "Solo números"); esValido = false; }

            if (!string.IsNullOrWhiteSpace(TBCorreo.Text))
            {
                try { new MailAddress(TBCorreo.Text); }
                catch { errorProvider1.SetError(TBCorreo, "Inválido"); esValido = false; }
            }

            if (cmbCondicionIVA.SelectedIndex == -1)
            { errorProvider1.SetError(cmbCondicionIVA, "Seleccione IVA"); esValido = false; }

            if (!esValido)
            {
                MessageBox.Show("Revise los campos en rojo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Aseguramos que los DNIs cargados estén listos para el análisis
            CargarDnisExistentes();

            // Validación de DNI duplicado sobre los clientes cargados
            string dniIngresado = TBDni.Text.Trim();
            if (DnisExistentes != null && DnisExistentes.Any(d => string.Equals(d.Trim(), dniIngresado, StringComparison.OrdinalIgnoreCase)) && !string.Equals(dniIngresado, dniOriginal.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                errorProvider1.SetError(TBDni, "No se pueden registrar dos clientes con el mismo DNI/CUIT.");
                MessageBox.Show("No se pueden registrar dos clientes con el mismo DNI/CUIT.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente NuevoCliente = new Cliente()
            {
                IdCliente = idClienteActual,
                Nombre = TBNombre.Text.Trim(),
                Apellido = TBApellido.Text.Trim(),
                DNICUIT = TBDni.Text.Trim(),
                Telefono = TBTelefono.Text.Trim(),
                CorreoElectronico = TBCorreo.Text.Trim(),
                IdCondicionIva = Convert.ToInt32(cmbCondicionIVA.SelectedValue) //REVISAR QUE GUARDA EL ID
            }; 

            string mensaje = string.Empty;

            // 2. Llamamos a la Capa de Negocio (asegurate de tener tu clase CN_Cliente armada)
            bool resultado = false;
            CN_Cliente negocioCliente = new CN_Cliente();

            // 3. Evaluamos si se guardó con éxito en SQL Server
            if (idClienteActual == 0)
            {
               resultado = negocioCliente.Registrar(NuevoCliente, out mensaje);
            }
            else
            {
                resultado = negocioCliente.Editar(NuevoCliente, out mensaje);
            }

            // aca evaluamos si se guardo e la bd
            if (resultado)
            {
                IdClienteGenerado = NuevoCliente.IdCliente;
                ClienteRegistrado = NuevoCliente;
                ClienteCreado = new ClienteSimulado
                {
                    Nombre = NuevoCliente.Nombre,
                    Apellido = NuevoCliente.Apellido,
                    DNI = NuevoCliente.DNICUIT,
                    CondicionIVA = cmbCondicionIVA.Text
                };

                string mensajeExito = (idClienteActual == 0) ? "¡Cliente registrado con éxito en la base de datos!" : "¡Cliente modificado con éxito!";
                MessageBox.Show(mensajeExito, "Joyería ALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable; // Apaga la validación forzada
            this.Close();
        }

        private void TBNombre_Validating(object sender, CancelEventArgs e)
        {
            string nombre = TBNombre.Text.Trim();

            // verifica si esta vacio
            if (string.IsNullOrWhiteSpace(nombre))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBNombre, "El nombre es obligatorio.");
            }
           
            // verifica que cada carácter sea una letra o un espacio en blanco
            else if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBNombre, "El nombre solo puede contener letras.");
            }
            else
            {
                //si todo esta bien
                e.Cancel = false;
                errorProvider1.SetError(TBNombre, "");
            }
        }

        public void ConfigurarModoEdicion(int IdCliente, string nombre, string apellido, string dni, string telefono, string correo, string condicionIVA, int idCondicionIVA = 0)
        {
            this.Text = "Modificar Cliente";
            LTitulo.Text = "Modificar Cliente";
            BRegistrarCliente.Text = "Modificar";

            idClienteActual = IdCliente; //guardamos el id para usarlo al hacer la modifiacion
            TBNombre.Text = nombre;
            TBApellido.Text = apellido;
            TBDni.Text = dni;
            TBTelefono.Text = telefono;
            TBCorreo.Text = correo;
            SeleccionarCondicionIVA(condicionIVA, idCondicionIVA);
            // Guardamos el DNI original para compararlo luego
            dniOriginal = dni;

            // Permitimos la modificación del DNI/CUIT
            TBDni.ReadOnly = false;
            TBDni.Enabled = true;
            TBDni.BackColor = Color.White;
        }
        

        public void ConfigurarModoDetalle(string nombre, string apellido, string dni, string telefono, string correo, string condicionIVA, int idCondicionIVA = 0)
        {
            this.Text = "Detalle Cliente";
            LTitulo.Text = "Detalle Cliente";

            TBNombre.Text = nombre;
            TBApellido.Text = apellido;
            TBDni.Text = dni;
            TBTelefono.Text = telefono;
            TBCorreo.Text = correo;
            SeleccionarCondicionIVA(condicionIVA, idCondicionIVA);

            // Bloquear controles
            TBNombre.ReadOnly = true;
            TBApellido.ReadOnly = true;
            TBDni.ReadOnly = true;
            TBTelefono.ReadOnly = true;
            TBCorreo.ReadOnly = true;
            cmbCondicionIVA.Enabled = false;

            // Ajustar botones
            BRegistrarCliente.Visible = false;
            BCancelar.Text = "Cerrar";
        }

        private void TBApellido_Validating(object sender, CancelEventArgs e)
        {
            string apellido = TBApellido.Text.Trim();

            if (string.IsNullOrWhiteSpace(apellido))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBApellido, "El apellido es obligatorio.");
            }
            else if (!apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBApellido, "El apellido solo puede contener letras.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TBApellido, "");
            }
        }

        private void TBDni_Validating(object sender, CancelEventArgs e)
        {
            string dni = TBDni.Text.Trim();
            // se verifica que no este vacio, que solo contenga numeros entre 7 y 11 digitos
            if (string.IsNullOrWhiteSpace(dni) || !dni.All(char.IsDigit) || dni.Length < 7 || dni.Length > 11)
            {
                e.Cancel = true;
                errorProvider1.SetError(TBDni, "Ingrese un DNI o CUIT válido (solo números, entre 7 y 11 dígitos).");
                return;
            }

            if (DnisExistentes != null && DnisExistentes.Any(d => string.Equals(d.Trim(), dni, StringComparison.OrdinalIgnoreCase)) && !string.Equals(dni, dniOriginal.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                errorProvider1.SetError(TBDni, "No se pueden registrar dos clientes con el mismo DNI/CUIT.");
                return;
            }

            e.Cancel = false;
            errorProvider1.SetError(TBDni, "");
        }

        private void TBCorreo_Validating(object sender, CancelEventArgs e)
        {
            string email = TBCorreo.Text.Trim();

            //En caso de que el correo sea obligatorio REVISAR
            if (string.IsNullOrWhiteSpace(email))
            {
                e.Cancel = false;
                errorProvider1.SetError(TBCorreo, "");
                return;
            }

            try
            {

                MailAddress m = new MailAddress(email);
                e.Cancel = false;
                errorProvider1.SetError(TBCorreo, "");
            }
            catch (FormatException)
            {
                e.Cancel = true;
                errorProvider1.SetError(TBCorreo, "El formato del correo no es válido (ej: nombre@dominio.com).");
            }
        }

        private void CargarCondicionIVA()
        {
            if (cmbCondicionIVA.DataSource == null)
            {
                try
                {
                    CN_Cliente negocioCliente = new CN_Cliente();
                    DataTable dt = negocioCliente.ObtenerCondicionIva();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        cmbCondicionIVA.DataSource = dt;
                        cmbCondicionIVA.DisplayMember = "CondicionIVA";
                        cmbCondicionIVA.ValueMember = "IdCondicionIva";
                    }
                }
                catch { }
            }
        }

        public void SeleccionarCondicionIVA(string condicion, int idCondicion = 0)
        {
            condicionIvaPendiente = condicion;
            idCondicionIvaPendiente = idCondicion;

            CargarCondicionIVA();

            CargarDnisExistentes();

            // 1. Si tenemos el ID numérico
            if (idCondicion > 0 && cmbCondicionIVA.DataSource != null)
            {
                try
                {
                    cmbCondicionIVA.SelectedValue = idCondicion;
                    if (cmbCondicionIVA.SelectedIndex >= 0) return;
                }
                catch { }
            }

            if (string.IsNullOrWhiteSpace(condicion)) return;
            string condTrim = condicion.Trim();

            // 2. Si el combo está enlazado a un DataTable
            if (cmbCondicionIVA.DataSource is DataTable dt)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string textoFila = dt.Rows[i]["CondicionIVA"]?.ToString()?.Trim() ?? "";
                    if (string.Equals(textoFila, condTrim, StringComparison.OrdinalIgnoreCase))
                    {
                        cmbCondicionIVA.SelectedIndex = i;
                        return;
                    }
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string textoFila = dt.Rows[i]["CondicionIVA"]?.ToString()?.Trim() ?? "";
                    if (textoFila.IndexOf(condTrim, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        condTrim.IndexOf(textoFila, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        cmbCondicionIVA.SelectedIndex = i;
                        return;
                    }
                }
            }

            // 3. Búsqueda en los Items del combo
            for (int i = 0; i < cmbCondicionIVA.Items.Count; i++)
            {
                string textoItem = cmbCondicionIVA.GetItemText(cmbCondicionIVA.Items[i])?.Trim() ?? "";
                if (string.Equals(textoItem, condTrim, StringComparison.OrdinalIgnoreCase))
                {
                    cmbCondicionIVA.SelectedIndex = i;
                    return;
                }
            }

            for (int i = 0; i < cmbCondicionIVA.Items.Count; i++)
            {
                string textoItem = cmbCondicionIVA.GetItemText(cmbCondicionIVA.Items[i])?.Trim() ?? "";
                if (textoItem.IndexOf(condTrim, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    condTrim.IndexOf(textoItem, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    cmbCondicionIVA.SelectedIndex = i;
                    return;
                }
            }

            // 4. Si no se encontró y el combo no tiene items asignados
            try
            {
                if (cmbCondicionIVA.SelectedIndex < 0 && cmbCondicionIVA.DataSource == null)
                {
                    cmbCondicionIVA.Items.Add(condTrim);
                    cmbCondicionIVA.SelectedIndex = cmbCondicionIVA.Items.Count - 1;
                }
                else
                {
                    cmbCondicionIVA.Text = condTrim;
                }
            }
            catch { }
        }

        private void TBTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void LTelefono_Click(object sender, EventArgs e)
        {

        }

        private void LCorreo_Click(object sender, EventArgs e)
        {

        }

        private void TBCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
