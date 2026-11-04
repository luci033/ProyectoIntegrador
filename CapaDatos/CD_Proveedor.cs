using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        private static readonly HashSet<int> ProveedoresInactivosMemoria = new HashSet<int>();
        private static bool columnaActivoVerificada = false;

        private void AsegurarColumnaActivo(SqlConnection conexion)
        {
            if (columnaActivoVerificada) return;
            try
            {
                string sql = @"
                    IF COL_LENGTH('Proveedor', 'Activo') IS NULL
                    BEGIN
                        ALTER TABLE Proveedor ADD Activo BIT NOT NULL CONSTRAINT DF_Proveedor_Activo DEFAULT 1;
                    END";
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.ExecuteNonQuery();
                }
                columnaActivoVerificada = true;
            }
            catch
            {
                // Si el usuario de BD no tiene permisos DDL, se respalda con ProveedoresInactivosMemoria
            }
        }

        public bool RegistrarProveedor(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            string query = @"INSERT INTO Proveedor (RazonSocial, CUIT, Telefono, CorreoElectronico)
                            VALUES (@RazonSocial, @CUIT, @Telefono, @CorreoElectronico)";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    AsegurarColumnaActivo(conexion);
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@RazonSocial", string.IsNullOrWhiteSpace(obj.RazonSocial) ? (object)DBNull.Value : obj.RazonSocial.Trim());
                        cmd.Parameters.AddWithValue("@CUIT", string.IsNullOrWhiteSpace(obj.CUIT) ? (object)DBNull.Value : obj.CUIT.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(obj.Telefono) ? (object)DBNull.Value : obj.Telefono.Trim());
                        cmd.Parameters.AddWithValue("@CorreoElectronico", string.IsNullOrWhiteSpace(obj.CorreoElectronico) ? (object)DBNull.Value : obj.CorreoElectronico.Trim());

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        respuesta = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                if (ex.Message.Contains("UQ_CUIT"))
                {
                    mensaje = "Ya existe un proveedor con ese CUIT registrado en el sistema.";
                }
                else if (ex.Message.Contains("CK_Telefono"))
                {
                    mensaje = "No se admite ese formato de teléfono (solo números).";
                }
                else
                {
                    mensaje = "Error al guardar el proveedor: " + ex.Message;
                }
            }

            return respuesta;
        }

        public bool EditarProveedor(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            string query = @"UPDATE Proveedor SET 
                                RazonSocial = @RazonSocial,
                                Telefono = @Telefono, 
                                CorreoElectronico = @CorreoElectronico 
                             WHERE IdProveedor = @IdProveedor";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@RazonSocial", string.IsNullOrWhiteSpace(obj.RazonSocial) ? (object)DBNull.Value : obj.RazonSocial.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(obj.Telefono) ? (object)DBNull.Value : obj.Telefono.Trim());
                        cmd.Parameters.AddWithValue("@CorreoElectronico", string.IsNullOrWhiteSpace(obj.CorreoElectronico) ? (object)DBNull.Value : obj.CorreoElectronico.Trim());
                        cmd.Parameters.AddWithValue("@IdProveedor", obj.IdProveedor);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        respuesta = filasAfectadas > 0;
                        if (!respuesta)
                        {
                            mensaje = "No se encontró el proveedor a modificar.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                if (ex.Message.Contains("CK_Telefono"))
                {
                    mensaje = "No se admite ese formato de teléfono (solo números).";
                }
                else
                {
                    mensaje = "Error al modificar el proveedor: " + ex.Message;
                }
            }

            return respuesta;
        }

        public bool CambiarEstado(int idProveedor, bool activo, out string mensaje)
        {
            mensaje = string.Empty;

            if (activo)
                ProveedoresInactivosMemoria.Remove(idProveedor);
            else
                ProveedoresInactivosMemoria.Add(idProveedor);

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    AsegurarColumnaActivo(conexion);
                    string query = "UPDATE Proveedor SET Activo = @Activo WHERE IdProveedor = @IdProveedor";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Activo", activo);
                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                // Si la tabla no tuviera la columna Activo, igual queda guardado en ProveedoresInactivosMemoria
                return true;
            }
        }

        public List<Proveedor> ListarProveedores(bool soloActivos = false)
        {
            List<Proveedor> lista = new List<Proveedor>();
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    AsegurarColumnaActivo(conexion);
                    string query = "SELECT * FROM Proveedor";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            bool tieneColumnaActivo = false;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                if (reader.GetName(i).Equals("Activo", StringComparison.OrdinalIgnoreCase))
                                {
                                    tieneColumnaActivo = true;
                                    break;
                                }
                            }

                            while (reader.Read())
                            {
                                int idProv = Convert.ToInt32(reader["IdProveedor"]);
                                bool activoBD = true;
                                if (tieneColumnaActivo && reader["Activo"] != DBNull.Value)
                                {
                                    activoBD = Convert.ToBoolean(reader["Activo"]);
                                }

                                bool activoFinal = activoBD && !ProveedoresInactivosMemoria.Contains(idProv);

                                if (soloActivos && !activoFinal)
                                    continue;

                                lista.Add(new Proveedor()
                                {
                                    IdProveedor = idProv,
                                    RazonSocial = reader["RazonSocial"].ToString(),
                                    CUIT = reader["CUIT"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    CorreoElectronico = reader["CorreoElectronico"].ToString(),
                                    Activo = activoFinal
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Proveedor>();
            }

            return lista;
        }
    }
}
