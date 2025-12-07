using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Peliculas
    {
            private CD_Conexion conexion = new CD_Conexion();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarPeliculas";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla = new DataTable(); // <--- AGREGA ESTO AQUÍ PARA LIMPIAR ANTES DE CARGAR
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }


        // Método para buscar UNA película por su ID
        public DataTable ObtenerPorId(int idPelicula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Pelicula WHERE IdPelicula = @id";
            comando.CommandType = CommandType.Text; // Usamos consulta directa por rapidez

            comando.Parameters.AddWithValue("@id", idPelicula);

            leer = comando.ExecuteReader();
            tabla = new DataTable();
            tabla.Load(leer);

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        // Asegúrate de tener declarada SqlConnection conexion;
        public DataTable MostrarTodasPeliculas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT IdPelicula, Titulo FROM Pelicula WHERE Activo = 1";
            comando.CommandType = CommandType.Text;

            SqlDataReader leer = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }

        public byte[] ObtenerImagen(int idPelicula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT Imagen FROM Pelicula WHERE IdPelicula = @id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@id", idPelicula);

            object resultado = comando.ExecuteScalar();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            if (resultado != null && resultado != DBNull.Value)
            {
                return (byte[])resultado;
            }
            return null;
        }

    }
}
