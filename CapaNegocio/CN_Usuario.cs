using System;
using CapaDatos;
using CapaEntidades;

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
                return false; // Corta la ejecución acá
            }

            if (string.IsNullOrWhiteSpace(obj.Contrasena))
            {
                mensaje = "Debe ingresar una contraseña.";
                return false;
            }

            // Si pasa las validaciones, le pasa el objeto a la Capa de Datos
            return objCapaDato.RegistrarUsuario(obj, out mensaje);
        }
    }

    public Usuario Login(string usuario, string contrasena, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación básica de seguridad
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                mensaje = "Debe ingresar el usuario y la contraseña.";
                return null;
            }

            // Si todo está ok, le pasa la pelota a la Capa de Datos
            return objCapaDato.Login(usuario, contrasena);
        }
    }