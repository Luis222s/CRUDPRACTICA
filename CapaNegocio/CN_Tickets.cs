using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Tickets
    {
        private CD_Tickets objetoCD = new CD_Tickets();

        public string RegistrarVenta(Guid usuarioId, int idPelicula, int idSala, string horario, int asientoId, int metodoPagoId, decimal total, string productos)
        {
            return objetoCD.InsertarTicket(usuarioId, idPelicula, idSala, horario, asientoId, metodoPagoId, total, productos);
        }
    

        public DataTable VerHistorialVentas()
        {
            return objetoCD.ObtenerHistorial();
        }

      
        public DataTable TraerAsientos(int idSala)
        {
            return objetoCD.ObtenerAsientos(idSala);
        }

        public void EditarTicket(string codigo, string horario, string precio)
        {
            objetoCD.Editar(codigo, horario, Convert.ToDecimal(precio));
        }

        public void EliminarTicket(string codigo)
        {
            objetoCD.Eliminar(codigo);
        }
        public void EditarTicket(string codigo, string horario, string precio, string idPelicula) // <-- AGREGAR idPelicula
        {
            // Convertimos a entero antes de enviarlo a la capa de datos
            objetoCD.Editar(codigo, horario, Convert.ToDecimal(precio), Convert.ToInt32(idPelicula));
        }
    }

}

