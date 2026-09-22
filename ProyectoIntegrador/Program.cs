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


            //Application.Run(new FormPrincipalAdministrador());
            //Application.Run(new FormPrincipalAdministrador());
            //Application.Run(new FormPrincipalVendedor());
            //Application.Run(new FormPrincipalLogistica());

            
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
                    else if (login.RolUsuario == "Gerente")
                    {
                        Application.Run(new FormPrincipalGerente());
                    }
                }
            
            }
            
        }
    }
}
