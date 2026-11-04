using CapaEntidades;
using CapaNegocio;
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
    public partial class FormCompras : Form
    {
        private string nombreUsuarioLogueado;
        private int idUsuarioLogueado = 1;

        public FormCompras(string nombreUsuario)
        {
            InitializeComponent();
            nombreUsuarioLogueado = !string.IsNullOrWhiteSpace(nombreUsuario) ? nombreUsuario : SesionActual.LoginUsuario;
            if (SesionActual.IdUsuario > 0 && !string.IsNullOrWhiteSpace(SesionActual.LoginUsuario) &&
                (string.Equals(nombreUsuarioLogueado, SesionActual.LoginUsuario, StringComparison.OrdinalIgnoreCase) ||
                 string.Equals(nombreUsuarioLogueado, SesionActual.NombreCompleto, StringComparison.OrdinalIgnoreCase)))
            {
                idUsuarioLogueado = SesionActual.IdUsuario;
            }
            else
            {
                try
                {
                    var u = new CN_Usuario().Listar().FirstOrDefault(x =>
                        (x.User != null && x.User.Equals(nombreUsuarioLogueado, StringComparison.OrdinalIgnoreCase)) ||
                        ($"{x.NombreUsuario} {x.ApellidoUsuario}".Trim().Equals(nombreUsuarioLogueado, StringComparison.OrdinalIgnoreCase)) ||
                        (x.NombreUsuario != null && x.NombreUsuario.Equals(nombreUsuarioLogueado, StringComparison.OrdinalIgnoreCase))
                    );
                    if (u != null)
                    {
                        idUsuarioLogueado = u.IdUsuario;
                    }
                    else
                    {
                        idUsuarioLogueado = SesionActual.IdUsuario > 0 ? SesionActual.IdUsuario : 1;
                    }
                }
                catch
                {
                    idUsuarioLogueado = SesionActual.IdUsuario > 0 ? SesionActual.IdUsuario : 1;
                }
            }
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloGrilla(DGCompras);
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BAgregarOrden);

            CargarCompras();
        }

        private void CargarCompras()
        {
            DGCompras.Rows.Clear();
            try
            {
                CN_Compra negocio = new CN_Compra();
                DataTable dt = negocio.Listar();

                foreach (DataRow row in dt.Rows)
                {
                    int idCompra = Convert.ToInt32(row["IdCompra"]);
                    DateTime fechaCompra = Convert.ToDateTime(row["FechaCompra"]);
                    string fechaStr = fechaCompra.ToString("dd/MM/yyyy");
                    string proveedor = row["Proveedor"] != DBNull.Value ? row["Proveedor"].ToString() : "";
                    int idEstado = Convert.ToInt32(row["IdEstadoCompra"]);
                    string nombreEstado = row["Estado"] != DBNull.Value ? row["Estado"].ToString() : "";

                    string textoRecepcion;
                    if (idEstado == 1) // Pendiente
                    {
                        textoRecepcion = "Registrar Recepción";
                    }
                    else
                    {
                        if (row["FechaRecepcion"] != DBNull.Value)
                        {
                            textoRecepcion = Convert.ToDateTime(row["FechaRecepcion"]).ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            textoRecepcion = nombreEstado;
                        }
                    }

                    string observacion = row["Observacion"] != DBNull.Value ? row["Observacion"].ToString() : "";
                    decimal total = row["Total"] != DBNull.Value ? Convert.ToDecimal(row["Total"]) : 0.00m;
                    string totalStr = total.ToString("C2");

                    string usuarioEmisor = (row.Table.Columns.Contains("UsuarioEmisor") && row["UsuarioEmisor"] != DBNull.Value) ? row["UsuarioEmisor"].ToString() : "";
                    string usuarioReceptor = (row.Table.Columns.Contains("UsuarioReceptor") && row["UsuarioReceptor"] != DBNull.Value) ? row["UsuarioReceptor"].ToString() : "Pendiente";

                    int idx = DGCompras.Rows.Add(idCompra, fechaStr, proveedor, textoRecepcion, observacion, totalStr, "Ver...");
                    DGCompras.Rows[idx].Tag = new Tuple<int, string, string>(idCompra, usuarioEmisor, usuarioReceptor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las órdenes de compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BAgregarOrden_Click(object sender, EventArgs e)
        {
            using (FormOrdenCompra formNueva = new FormOrdenCompra(nombreUsuarioLogueado, idUsuarioLogueado))
            {
                if (formNueva.ShowDialog() == DialogResult.OK)
                {
                    CargarCompras();
                }
            }
        }

        private void DGProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = DGCompras.Rows[e.RowIndex];
            int idCompra = 0;
            string usuarioEmisor = "";
            string usuarioReceptor = "";

            if (fila.Tag is Tuple<int, string, string> tagInfo)
            {
                idCompra = tagInfo.Item1;
                usuarioEmisor = tagInfo.Item2;
                usuarioReceptor = tagInfo.Item3;
            }
            else if (fila.Tag != null && int.TryParse(fila.Tag.ToString(), out int idTag))
            {
                idCompra = idTag;
            }
            else if (fila.Cells[0].Value != null && int.TryParse(fila.Cells[0].Value.ToString(), out int idCell))
            {
                idCompra = idCell;
            }

            if (idCompra <= 0) return;

            string nro = idCompra.ToString();
            string fecha = fila.Cells[1].Value?.ToString();
            string prov = fila.Cells[2].Value?.ToString();
            string recepVal = fila.Cells[3].Value?.ToString();
            string obs = fila.Cells[4].Value?.ToString();
            string total = fila.Cells[5].Value?.ToString();

            // Columna 3: Recepción de mercadería
            if (e.ColumnIndex == 3 && recepVal == "Registrar Recepción")
            {
                using (FormRegistrarRecepcion formRecepcion = new FormRegistrarRecepcion(idCompra, nro, prov, fecha, nombreUsuarioLogueado, idUsuarioLogueado))
                {
                    if (formRecepcion.ShowDialog() == DialogResult.OK)
                    {
                        CargarCompras();
                    }
                }
            }
            // Columna 6: Ver Detalle
            else if (e.ColumnIndex == 6)
            {
                using (FormVerDetalle formDetalle = new FormVerDetalle(idCompra, nro, prov, fecha, recepVal, obs, total, usuarioEmisor, usuarioReceptor))
                {
                    formDetalle.ShowDialog();
                }
            }
        }

        private void LProveedores_Click(object sender, EventArgs e) { }
        private void BRegistrarCompra_Click(object sender, EventArgs e) { }
    }
}
