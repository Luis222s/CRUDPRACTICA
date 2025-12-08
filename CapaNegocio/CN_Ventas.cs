using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Ventas
    {
        private CD_Ventas objetoCD = new CD_Ventas();

        public int RegistrarVenta(Guid idUsuario, int idPelicula, decimal total, string horario, string codigoTicket)
        {
            return objetoCD.RegistrarCabecera(idUsuario, idPelicula, total, horario, codigoTicket);
        }

        public void RegistrarDetalle(int idVenta, string descripcion, decimal precio, int cantidad)
        {
            objetoCD.RegistrarDetalle(idVenta, descripcion, precio, cantidad);
        }

        public DataTable ObtenerVentas()
        {
            return objetoCD.ListarVentas();
        }

        public DataTable ObtenerDetalle(int idVenta)
        {
            return objetoCD.ListarDetalle(idVenta);
        }
    }
}
