using System;
using System.Data;
using CapaDatos;
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private CD_Datos objetoCD = new CD_Datos();

        public DataTable MostrarDatos()
        {
            DataTable Tabla = new DataTable();
            Tabla = objetoCD.Mostrar();
            return Tabla;
        }

        public void InsertarProd (string nombre, string email, string telefono, string metodopago, string cedula)
        {
            objetoCD.Insertar(nombre, email, telefono, metodopago, cedula);
        }
        public void EditarProd(string nombre, string email, string telefono, string metodopago, string cedula, string id)
        {
            objetoCD.Editar(nombre, email, telefono, metodopago, cedula, Convert.ToInt32(id));
        }
        public void EliminarProd(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
