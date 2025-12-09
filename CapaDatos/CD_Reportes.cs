using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Reportes
    {
        private CD_Conexion conexion = new CD_Conexion();

        public DataTable ObtenerDatos()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ObtenerReporteGeneral";
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataReader leer = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }
    }
}
