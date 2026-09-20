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

            //FormLogin login = new FormLogin();
            //Application.Run(new FormLogin());

<<<<<<< HEAD

            //Application.Run(new FormPrincipalAdministrador());
=======
            Application.Run(new FormPrincipalAdministrador());
>>>>>>> 1aec7f6154e268d9517216fcf3601ac6966c5847
            //Application.Run(new FormPrincipalVendedor());
            //Application.Run(new FormPrincipalLogistica());

            /*
            using (FormLogin login = new FormLogin())
            {
                // si el login fue exitoso, el Login devuelve DialogResult.OK
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // determina que rol accedio y muestra su formulario
                    if (login.RolUsuario == "Vendedor")
                    {
                        Application.Run(new FormPrincipalVendedor());
                    }
                    else if (login.RolUsuario == "Administrador")
                    {
                        Application.Run(new FormPrincipalAdministrador());
                    }
                    else if (login.RolUsuario == "Logistica")
                    {
                        Application.Run(new FormPrincipalLogistica());
                    }
                }
            
            }
            */
        }
    }
}
