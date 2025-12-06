using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Data;

namespace CapaDatos
{
    public class CD_Conexion
    {

        private SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=PracticaCrud;Integrated Security=True;TrustServerCertificate=True");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}