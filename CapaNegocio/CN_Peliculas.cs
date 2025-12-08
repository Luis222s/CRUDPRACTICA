using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Peliculas
    {
        private CD_Peliculas objetoCD = new CD_Peliculas();
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
                imagen // ARRAY DE BYTES
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
                imagen // ARRAY DE BYTES
            );
        }

        public void EliminarPelicula(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}