using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandaleFruta.Modelos
{
    public class FrutaVerdura
    {
        public int id_FrutaVerdura { get; set; }
        public string Nombre { get; set; }
        public int id_Tipo { get; set; }


        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length < 51)
                return true;
            return false;
        }
    }
}
