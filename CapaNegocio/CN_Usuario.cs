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
        public void Registrar(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(obj.User))
            {
                mensaje = "El nombre de usuario no puede estar vacío.";
                return; // Corta la ejecución acá
            }

            if (string.IsNullOrWhiteSpace(obj.Contrasena))
            {
                mensaje = "Debe ingresar una contraseña.";
                return;
            }

            // Si pasa las validaciones, le pasa el objeto a la Capa de Datos
            objCapaDato.Registrar(obj);
        }
    }
}