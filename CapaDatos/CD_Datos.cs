using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Datos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader Leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDatos";
            comando.CommandType = CommandType.StoredProcedure;
            Leer = comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
        public void Insertar(string nombre, string email, string telefono, string metodopago, string cedula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarDatos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@metodopago", metodopago);
            comando.Parameters.AddWithValue("@cedula", cedula);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Editar(string nombre, string email, string telefono, string metodopago, string cedula, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarDatos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@metodopago", metodopago);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDatos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpro", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
