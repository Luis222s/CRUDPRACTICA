using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Usuarios
    {

                public CD_Conexion conexion = new CD_Conexion();
                SqlDataReader leer;
                SqlCommand comando = new SqlCommand();

                // VALIDAR LOGIN: Llama al Store Procedure que creamos en SQL
                public DataTable ValidarLogin(string usuario, string password)
                {
                    comando.Connection = conexion.AbrirConexion();
                    comando.CommandText = "ValidarLogin"; // Nombre exacto del SP en SQL
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@password", password);

                    leer = comando.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(leer);

                    comando.Parameters.Clear();
                    conexion.CerrarConexion();
                    return tabla;
                }
        // Método para REGISTRAR un nuevo usuario en la BD
        public void RegistrarUsuario(string usuario, string password, string nombre, string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RegistrarUsuario"; 
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@rolId", 1); // Por defecto se crea como Cliente (1)

            comando.ExecuteNonQuery(); // Ejecuta sin devolver tabla

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}

