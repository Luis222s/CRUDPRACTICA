using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Reportes
    {
        private CD_Reportes objetoCD = new CD_Reportes();

        public DataTable VerReporte()
        {
            return objetoCD.ObtenerDatos();
        }
    }
}
