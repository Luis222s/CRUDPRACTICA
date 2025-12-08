using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Ventas
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        // 1. Guardar la CABECERA (El resumen) y devolver el ID generado
        public int RegistrarCabecera(Guid idUsuario, int idPelicula, decimal total, string horario, string codigoTicket)
        {
            int idVentaGenerado = 0;

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RegistrarVentaCompleta";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
            comando.Parameters.AddWithValue("@IdPelicula", idPelicula);
            comando.Parameters.AddWithValue("@Total", total);
            comando.Parameters.AddWithValue("@Horario", horario);
            comando.Parameters.AddWithValue("@CodigoTicket", codigoTicket);

            // ExecuteScalar devuelve el ID de la venta que acabamos de crear
            idVentaGenerado = Convert.ToInt32(comando.ExecuteScalar());

            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return idVentaGenerado;
        }

        // 2. Guardar el DETALLE (Cada boleto o combo)
        public void RegistrarDetalle(int idVenta, string descripcion, decimal precio, int cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarDetalleVenta";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdVenta", idVenta);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Método para listar las cabeceras
        public DataTable ListarVentas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "VerHistorialVentas";
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        // Método para ver el detalle de una venta X
        public DataTable ListarDetalle(int idVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "VerDetalleVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdVenta", idVenta);
            SqlDataReader leer = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }
    }
}

