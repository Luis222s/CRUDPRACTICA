using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Peliculas
    {
        private CD_Peliculas objetoCD = new CD_Peliculas();

        public DataTable MostrarPeliculas()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
    
        // Nuevo método para obtener una película por su ID
        public DataTable ObtenerPelicula(int id)

        {
            return objetoCD.ObtenerPorId(id);
        }

        public DataTable ObtenerListaPeliculas()
        {
            return objetoCD.MostrarTodasPeliculas();
        }

        public byte[] BuscarImagenPelicula(int idPelicula)
        {
            CD_Peliculas objCD = new CD_Peliculas();
            return objCD.ObtenerImagen(idPelicula);
        }
    }
}



