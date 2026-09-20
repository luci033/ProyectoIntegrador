using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        // Instancia para comunicarse con la capa de datos
        private CD_Usuario objCapaDato = new CD_Usuario();

        // Usamos "out string mensaje" para devolver errores al formulario
        public bool Registrar(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(obj.User))
            {
                mensaje = "El nombre de usuario no puede estar vacío.";
                return false; // aca, corta la ejecucion
            }

            if (string.IsNullOrWhiteSpace(obj.Contrasena))
            {
                mensaje = "Debe ingresar una contraseña.";
                return false;
            }

            // Si pasa las validaciones, le pasa el objeto a la Capa de Datos
            return objCapaDato.RegistrarUsuario(obj, out mensaje);
        }

        //puente a la capa de negocio, se validan primero que los campos no esten vacios antes de ir a la BD
        public Usuario Login(string usuario, string contrasena, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación básica de seguridad
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                mensaje = "Debe ingresar el usuario y la contraseña.";
                return null;
            }

            // Si todo está ok, se pasa a la Capa de Datos
            return objCapaDato.Login(usuario, contrasena);
        }

        // Puente para pedirle la lista a la capa de datos
        public List<Usuario> Listar()
        {
            return objCapaDato.Listar();
        }

        public bool CambiarEstado(int idUsuario, int nuevoEstado, out string mensaje)
        {
            return objCapaDato.CambiarEstadoUsuario(idUsuario, nuevoEstado, out mensaje);
        }

        public bool Editar(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;

            // Validamos que no nos mande el usuario vacío
            if (string.IsNullOrWhiteSpace(obj.User))
            {
                mensaje = "El nombre de usuario no puede estar vacío.";
                return false;
            }

            return objCapaDato.EditarUsuario(obj, out mensaje);
        }
    }
}
