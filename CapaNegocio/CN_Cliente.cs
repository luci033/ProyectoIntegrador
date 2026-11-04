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
    public class CN_Cliente
    {
        // Instancia para comunicarse con la capa de datos de cliente
        private CD_Cliente objCapaDato = new CD_Cliente();

        // Método para registrar un cliente siguiendo el mismo formato
        public bool Registrar(Cliente obj, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de negocio antes de ir a la base de datos
            if (string.IsNullOrWhiteSpace(obj.Nombre))
            {
                mensaje = "El nombre del cliente no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(obj.DNICUIT))
            {
                mensaje = "El DNI o CUIT del cliente es obligatorio.";
                return false;
            }

            // Validación de unicidad de DNI/CUIT en capa de negocio
            if (objCapaDato.ExisteDni(obj.DNICUIT, obj.IdCliente))
            {
                mensaje = "No se pueden registrar dos clientes con el mismo DNI/CUIT.";
                return false;
            }

            // Si pasa las validaciones, le pasa el objeto a la Capa de Datos
            return objCapaDato.RegistrarCliente(obj, out mensaje);
        }

        public DataTable ObtenerCondicionIva()
        {
            CD_Cliente cdCliente = new CD_Cliente();
            return cdCliente.ListarCondicionIva();
        }

        // Método puente para pedir la lista de clientes a la capa de datos
        public DataTable Listar()
        {
            return objCapaDato.ListarClientes();
        }

        public bool ExisteDni(string dnicuit, int idClienteExcluir = 0)
        {
            return objCapaDato.ExisteDni(dnicuit, idClienteExcluir);
        }

        public bool Editar(Cliente obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Nombre))
            {
                mensaje = "El nombre del cliente no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(obj.DNICUIT))
            {
                mensaje = "El DNI o CUIT del cliente es obligatorio.";
                return false;
            }

            // Validación de unicidad de DNI/CUIT en capa de negocio
            if (objCapaDato.ExisteDni(obj.DNICUIT, obj.IdCliente))
            {
                mensaje = "No se pueden registrar dos clientes con el mismo DNI/CUIT.";
                return false;
            }

            return objCapaDato.EditarCliente(obj, out mensaje);
        }
    }
}
