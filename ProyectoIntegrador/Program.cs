using ProyectoIntegrador.Formularios.Principal;
using ProyectoIntegrador.Formularios.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin login = new FormLogin();
            Application.Run(new FormLogin());

            //Application.Run(new FormPrincipalAdministrador());

            /*
            // Si el usuario se loguea correctamente
            if (login.ShowDialog() == DialogResult.OK)
            {

                // Lees la propiedad pública que creaste en el Login
                string rol = login.RolUsuario;

                // Abrís el MDI correspondiente según el rol
                if (rol == "Admin")
                    Application.Run(new FormPrincipalAdministrador());
                else if (rol == "Vendedor")
                    Application.Run(new FormPrincipalVendedor());
                else if (rol == "Logistica")
                    Application.Run(new FormPrincipalLogistica());
            }*/
        }
    }
}
