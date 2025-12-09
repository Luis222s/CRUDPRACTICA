using Microsoft.Data.SqlClient; // Usamos esta (la moderna)
using System.Data;           // Para ConnectionState
using System;                // Para excepciones

namespace CapaDatos
{
    public class CD_Conexion
    {
        // 1. Declaración de la cadena de conexión
        private string connectionString = "Data Source=.;Initial Catalog=PracticaCrud;Integrated Security=True;TrustServerCertificate=True";

        // 2. Declaración de la variable de conexión
        private SqlConnection Conexion;

        // Constructor: Inicializa la variable de conexión
        public CD_Conexion()
        {
            this.Conexion = new SqlConnection(connectionString);
        }

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