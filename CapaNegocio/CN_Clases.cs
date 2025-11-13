using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public abstract class Entrada
    {
        public int Cantidad { get; set; }

        public virtual decimal CalcularPrecio() 
        { 
            return 0; 
        }
    }
    public abstract class Contenido
    {
        public abstract void GenerarBoleto();
    }

    public class Pelicula : Contenido
    {
            public string Titulo { get; set; }
            public string Generos { get; set; }
            public string Duracion { get; set; }
            public string FechaEstreno { get; set; }
            public string Descripcion { get; set; }
            public string CodigoBoleto { get; private set; }

        public override void GenerarBoleto()
        {
            Random rnd = new Random();
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789#@$%&*";
            string codigo = "";

            for (int i = 0; i < 9; i++)
            {
                codigo += caracteres[rnd.Next(caracteres.Length)];
            }

            CodigoBoleto = codigo; 
        }
    }
    public class Documental : Entrada
    {
        public string Tipo { get; set; }

        public override decimal CalcularPrecio()
        {
            decimal precioUnitario = Tipo == "VIP" ? 300m : 125m;
            return precioUnitario * Cantidad;
        }
    }

    public class EntradaGeneral : Entrada 
    {
        public const decimal ENTRADA_NORMAL = 125m;
        public override decimal CalcularPrecio()
        {
            return ENTRADA_NORMAL * Cantidad;
        }
    }
    public class EntradaVip : Entrada
    {
        public const decimal ENTRADA_VIP = 300m;
        public override decimal CalcularPrecio()
        {
            return ENTRADA_VIP * Cantidad;
        }
    }
    public class PreciosCine
    {
        public const decimal COMBO_1 = 300m;
        public const decimal COMBO_2 = 330m;
        public const decimal COMBO_3 = 460m;
        public const decimal COMBO_4 = 1100m;
        public const decimal CARGO_SERVICIO_TAQUILLA = 35m;
        public const decimal CARGO_SERVICIO_SNACK = 35m;
    }
    public class ComboCine
    {
        public int CantidadCombo1 { get; set; }
        public int CantidadCombo2 { get; set; }
        public int CantidadCombo3 { get; set; }
        public int CantidadCombo4 { get; set; }


        public decimal CalcularPrecio()
        {
            decimal total = 0;
            total += CantidadCombo1 * PreciosCine.COMBO_1;
            total += CantidadCombo2 * PreciosCine.COMBO_2;
            total += CantidadCombo3 * PreciosCine.COMBO_3;

            return total;
        }
    }
}
