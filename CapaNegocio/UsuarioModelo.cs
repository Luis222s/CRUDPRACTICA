using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class UsuarioModelo
    {
        public Guid Id { get; set; }
        public string NombreUsuario { get; set; }
        public string PasswordHash { get; set; }
        public string Nombre { get; set; }
        public string FotoPerfil { get; set; }
        public bool EsInvitado { get; set; }
        public string CorreoOpcional { get; set; }
        public string Rol { get; set; } // Para saber si es Admin o Cliente
    }
}
