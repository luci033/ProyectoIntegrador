using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        // En C# una propiedad no puede llamarse igual que su clase. 
        // Cambiamos "Usuario" por "NombreCuenta" para el mapeo.
        public required string User { get; set; }

        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public required string Contrasena { get; set; }
        public int IdRol { get; set; }
        public bool Activo { get; set; }

        // agregar el campo foto perfil

        // Propiedad de navegación (Trae el objeto Rol completo por si necesitas su nombre)
        public Rol ObjRol { get; set; }
    }
}
