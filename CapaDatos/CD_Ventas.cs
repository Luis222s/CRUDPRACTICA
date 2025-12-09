using System;
using System.Data;
using Microsoft.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Ventas
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        // 1. Registrar Cabecera (Ya lo tienes, se queda igual)
        public int RegistrarCabecera(Guid idUsuario, int idPelicula, decimal total, string horario, string codigoTicket)
        {
            // ... (Tu código de registrar cabecera que ya funcionaba) ...
            // Si necesitas que te lo reescriba completo dímelo, pero asumo que ya lo tienes.
            int idVentaGenerado = 0;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RegistrarVentaCompleta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
            comando.Parameters.AddWithValue("@IdPelicula", idPelicula);
            comando.Parameters.AddWithValue("@Total", total);
            comando.Parameters.AddWithValue("@Horario", horario);
            comando.Parameters.AddWithValue("@CodigoTicket", codigoTicket);
            idVentaGenerado = Convert.ToInt32(comando.ExecuteScalar());
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return idVentaGenerado;
        }

        // 2. Registrar Detalle (Ya lo tienes)
        public void RegistrarDetalle(int idVenta, string descripcion, decimal precio, int cantidad)
        {
            // ... (Tu código de registrar detalle) ...
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

        // 3. LEER CABECERAS (Para dgvVentas)
        public DataTable ListarVentasCabecera()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "VerHistorialCompleto"; // Nombre de tu SP nuevo
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataReader leer = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }

        // 4. LEER DETALLES (Para dgvDetalle)
        public DataTable ListarVentasDetalle(int idVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "VerDetalleDeVenta"; // Nombre de tu SP nuevo
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdVenta", idVenta);

            SqlDataReader leer = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(leer);

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        // Eliminar
        public void EliminarVenta(int idVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarVentaCompleta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdVenta", idVenta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Método para Editar el Ticket (Cabecera)
        public void EditarTicket(string codigo, string horario, decimal precio, int idPelicula)
        {
            comando.Connection = conexion.AbrirConexion();
            // Usamos el SP de editar cabecera que creamos antes
            comando.CommandText = "EditarVentaCabecera";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@CodigoTicket", codigo);
            comando.Parameters.AddWithValue("@NuevoHorario", horario);
            comando.Parameters.AddWithValue("@NuevoTotal", precio);
            comando.Parameters.AddWithValue("@NuevoIdPelicula", idPelicula);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Método para Traer Asientos (Lo necesitas para el error de Salas)
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
        public void EditarVenta(string codigo, string horario, decimal total, int idPelicula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarVentaCabecera";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@CodigoTicket", codigo);
            comando.Parameters.AddWithValue("@NuevoHorario", horario);
            comando.Parameters.AddWithValue("@NuevoTotal", total);
            comando.Parameters.AddWithValue("@NuevoIdPelicula", idPelicula);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}