using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objetoCD = new CD_Usuarios();

        // Método que llamará tu Formulario Login
        public DataTable ValidarLogin(string usuario, string password)
        {
            return objetoCD.ValidarLogin(usuario, password);
        }
    
        public void RegistrarUsuario(string usuario, string password, string nombre, string correo)
        {
            objetoCD.RegistrarUsuario(usuario, password, nombre, correo);
        }
    }
}