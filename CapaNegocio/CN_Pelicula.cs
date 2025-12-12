using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Pelicula
    {
        private CD_Pelicula objetoCD = new CD_Pelicula();
        // MÉTODOS MOSTRAR, OBTENER, BUSCARIMAGEN
        public DataTable MostrarPeliculas() { return objetoCD.Mostrar(); }
        public DataTable ObtenerPelicula(int id) { return objetoCD.ObtenerPorId(id); }
        public DataTable ObtenerListaPeliculas() { return objetoCD.MostrarTodasPeliculas(); }
        public byte[] BuscarImagenPelicula(int idPelicula) { return objetoCD.ObtenerImagen(idPelicula); }

        // --- MÉTODOS CRUD MODIFICADOS: CON IMAGEN ---

        public void InsertarPelicula(string titulo, string genero, string duracion, string clasificacion, DateTime fecha, string sinopsis, byte[] imagen)
        {
            // Llama a la nueva firma de CD_Peliculas
            objetoCD.Insertar(
                titulo,
                genero,
                Convert.ToInt32(duracion),
                clasificacion,
                fecha,
                sinopsis,
                imagen 
            );
        }

        public void EditarPelicula(string id, string titulo, string genero, string duracion, string clasificacion, string sinopsis, byte[] imagen)
        {
            // Llama a la nueva firma de CD_Peliculas
            objetoCD.Editar(
                Convert.ToInt32(id),
                titulo,
                genero,
                Convert.ToInt32(duracion),
                clasificacion,
                sinopsis,
                imagen 
            );
        }

        public void EliminarPelicula(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
