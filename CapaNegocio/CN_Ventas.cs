using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Ventas
    {
        private CD_Ventas objetoCD = new CD_Ventas();

        // Registrar (Ya lo tenías)
        public int RegistrarVenta(Guid id, int peli, decimal total, string horario, string codigo)
        {
            return objetoCD.RegistrarCabecera(id, peli, total, horario, codigo);
        }
        public void RegistrarDetalle(int idVenta, string desc, decimal precio, int cant)
        {
            objetoCD.RegistrarDetalle(idVenta, desc, precio, cant);
        }

        // LEER (NUEVO)
        public DataTable ObtenerVentasCabecera()
        {
            return objetoCD.ListarVentasCabecera();
        }

        public DataTable ObtenerVentasDetalle(int idVenta)
        {
            return objetoCD.ListarVentasDetalle(idVenta);
        }

        

        public void EliminarVenta(int idVenta)
        {
            objetoCD.EliminarVenta(idVenta);
        }

        // Puente para Editar Ticket
        public void EditarTicket(string codigo, string horario, string precio, string idPelicula)
        {
            objetoCD.EditarTicket(codigo, horario, Convert.ToDecimal(precio), Convert.ToInt32(idPelicula));
        }

        // Puente para Traer Asientos (Error de Salas.cs)
        public DataTable TraerAsientos(int idSala)
        {
            return objetoCD.ObtenerAsientos(idSala);
        }


        public void EditarVenta(string codigo, string horario, string total, string idPelicula)
        {
            objetoCD.EditarVenta(codigo, horario, Convert.ToDecimal(total), Convert.ToInt32(idPelicula));
        }
    }
}