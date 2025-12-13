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

        public DataTable ObtenerReporteGeneral()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexion.AbrirConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerReporteGeneral", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader leer = cmd.ExecuteReader();
                tabla.Load(leer);
            }
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
