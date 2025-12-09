using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();

        // Método para traer la lista de combos
        public DataTable MostrarProductos()
        {
            // Usamos un SELECT directo porque es una consulta simple
            SqlCommand comando = new SqlCommand("SELECT * FROM Productos WHERE Disponible = 1 ORDER BY Precio ASC", conexion.AbrirConexion());
            SqlDataReader leer = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }
    }
}
