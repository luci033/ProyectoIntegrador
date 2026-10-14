using CapaDatos; 
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objCapaDato = new CD_Producto();
        public bool Registrar(Producto obj, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(obj.NombreProducto))
            {
                mensaje = "El nombre del producto no puede estar vacío.";
                return false; // aca, corta la ejecucion
            }

            if (obj.IdCategoria <= 0)
            {
                mensaje = "Debe seleccionar la categoría del producto.";
                return false;
            }

            if (obj.IdGenero <= 0)
            {
                mensaje = "Debe seleccionar el género de la joya.";
                return false;
            }
            
            if (obj.IdProveedor <=0)
            {
                mensaje = "Debe seleccionar un proveedor.";
                return false;
            }

            if (obj.StockMinimo <= 0)
            {
                mensaje = "Debe seleccionar un stock mínimo mayor a cero.";
                return false;
            }

            if (obj.StockActual < 0)
            {
                mensaje = "El stock actual no puede ser menor a  cero.";
                return false;
            }
            if (obj.PrecioCompra.HasValue && obj.PrecioCompra <= 0)
            {
                mensaje = "El precio de compra no puede ser igual a cero.";
                return false;
            }
            if (obj.PrecioVenta.HasValue && obj.PrecioVenta <= 0)
            {
                mensaje = "El precio de venta no puede ser igual a cero";
                return false;
            }


            // Si pasa las validaciones, le pasa el objeto a la Capa de Datos
            return objCapaDato.RegistrarProducto(obj, out mensaje);
        }

        public DataTable Listar()
        {
            return objCapaDato.ListarProductos();
        }

        public bool Editar(Producto obj, out string mensaje)
        {
            mensaje = String.Empty;

            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(obj.NombreProducto))
            {
                mensaje = "El nombre del producto no puede estar vacío.";
                return false; // aca, corta la ejecucion
            }

            if (obj.IdCategoria <= 0)
            {
                mensaje = "Debe seleccionar la categoría del producto.";
                return false;
            }

            if (obj.IdGenero <= 0)
            {
                mensaje = "Debe seleccionar el género de la joya.";
                return false;
            }

            if (obj.IdProveedor <= 0)
            {
                mensaje = "Debe seleccionar un proveedor.";
                return false;
            }

            if (obj.StockMinimo <= 0)
            {
                mensaje = "Debe seleccionar un stock mínimo mayor a cero.";
                return false;
            }

            if (obj.StockActual < 0)
            {
                mensaje = "El stock actual no puede ser menor a  cero.";
                return false;
            }
            if (obj.PrecioCompra.HasValue && obj.PrecioCompra <= 0)
            {
                mensaje = "El precio de compra no puede ser igual a cero.";
                return false;
            }
            if (obj.PrecioVenta.HasValue && obj.PrecioVenta <= 0)
            {
                mensaje = "El precio de venta no puede ser igual a cero";
                return false;
            }


            // Si pasa las validaciones, le pasa el objeto a la Capa de Datos
            return objCapaDato.RegistrarProducto(obj, out mensaje);
        }
    }
}
