using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Pelicula
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
            tabla = new DataTable();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable ObtenerPorId(int idPelicula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Pelicula WHERE IdPelicula = @id";
            comando.CommandType = CommandType.Text;

            comando.Parameters.AddWithValue("@id", idPelicula);

            leer = comando.ExecuteReader();
            tabla = new DataTable();
            tabla.Load(leer);

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

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
        // Método para Insertar (Con Imagen)
        public void Insertar(string titulo, string genero, int duracion, string clasificacion, DateTime fecha, string sinopsis, byte[] imagen)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarPelicula";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@duracion", duracion);
            comando.Parameters.AddWithValue("@clasificacion", clasificacion);
            comando.Parameters.AddWithValue("@fechaEstreno", fecha);
            comando.Parameters.AddWithValue("@sinopsis", sinopsis);
            comando.Parameters.AddWithValue("@imagen", imagen ?? (object)DBNull.Value); // Manejo seguro de NULL

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Método para Editar (Con Imagen)
        public void Editar(int id, string titulo, string genero, int duracion, string clasificacion, string sinopsis, byte[] imagen)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPelicula";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idPelicula", id);
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@duracion", duracion);
            comando.Parameters.AddWithValue("@clasificacion", clasificacion);
            comando.Parameters.AddWithValue("@sinopsis", sinopsis);
            comando.Parameters.AddWithValue("@imagen", imagen ?? (object)DBNull.Value); // Manejo seguro de NULL en sql

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Método para Eliminar 
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarPelicula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idPelicula", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}

