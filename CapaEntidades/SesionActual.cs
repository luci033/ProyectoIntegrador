using System;

namespace CapaEntidades
{
    public static class SesionActual
    {
        public static int IdUsuario { get; set; } = 1;
        public static string LoginUsuario { get; set; } = "";
        public static string NombreUsuario { get; set; } = "";
        public static string ApellidoUsuario { get; set; } = "";
        public static string NombreCompleto { get; set; } = "";
        public static string Rol { get; set; } = "";
        public static Usuario UsuarioLogueado { get; set; }

        public static void IniciarSesion(Usuario usuario, string rol = "")
        {
            if (usuario == null) return;
            UsuarioLogueado = usuario;
            IdUsuario = usuario.IdUsuario;
            LoginUsuario = usuario.User ?? "";
            NombreUsuario = usuario.NombreUsuario ?? "";
            ApellidoUsuario = usuario.ApellidoUsuario ?? "";

            string completo = $"{usuario.NombreUsuario} {usuario.ApellidoUsuario}".Trim();
            NombreCompleto = !string.IsNullOrWhiteSpace(completo) ? completo : (usuario.User ?? "");
            Rol = !string.IsNullOrWhiteSpace(rol) ? rol : (usuario.ObjRol?.NombreRol ?? "");
        }

        public static void CerrarSesion()
        {
            IdUsuario = 1;
            LoginUsuario = "";
            NombreUsuario = "";
            ApellidoUsuario = "";
            NombreCompleto = "";
            Rol = "";
            UsuarioLogueado = null;
        }
    }
}
