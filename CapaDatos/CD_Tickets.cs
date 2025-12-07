using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Tickets
    {
        
           
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        public string InsertarTicket(Guid usuarioId, int idPelicula, int idSala, string horario, int asientoId, int metodoPagoId, decimal precioTotal, string productos)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarTicket"; // El SP nuevo
            comando.CommandType = CommandType.StoredProcedure;

            // Parámetros EXACTOS de tu nueva Base de Datos
            comando.Parameters.AddWithValue("@usuarioId", usuarioId);
            comando.Parameters.AddWithValue("@idPelicula", idPelicula);
            comando.Parameters.AddWithValue("@idSala", idSala);
            comando.Parameters.AddWithValue("@horario", horario);
            comando.Parameters.AddWithValue("@asientoId", asientoId);
            comando.Parameters.AddWithValue("@metodoPagoId", metodoPagoId);
            comando.Parameters.AddWithValue("@precioTotal", precioTotal);
            comando.Parameters.AddWithValue("@productosComprados", productos);

            // Ejecutamos y recuperamos el código del ticket
            string codigo = Convert.ToString(comando.ExecuteScalar());

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return codigo;
        }

    

         // En CapaDatos/CD_Tickets.cs

        public DataTable ObtenerHistorial()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTickets"; // Nombre del SP en SQL
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataReader leer = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }

        // En CapaDatos/CD_Tickets.cs

        public DataTable ObtenerAsientos(int idSala)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ObtenerAsientosPorSala";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idSala", idSala);

            SqlDataReader leer = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(leer);

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

    }
}


