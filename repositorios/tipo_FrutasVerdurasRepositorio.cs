using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandaleFruta.helper;
using MandaleFruta.Modelos;
using System.Data;

namespace MandaleFruta.repositorios
{
    public class tipo_FrutasVerdurasRepositorio
    {
        private acceso_BD _BD;

        public tipo_FrutasVerdurasRepositorio()
        {
            _BD = new acceso_BD();
        }
        public DataTable obtenerFrutasVerdurasDT()
        {
            string sqltxt = "SELECT * FROM nombre";
            return _BD.consulta(sqltxt);

        }
        public DataTable obtenerTipoFrutasVerdurasDT()
        {
            string sqltxt = "SELECT * FROM tipo_FrutaVerdura";
            return _BD.consulta(sqltxt);
        }

        public bool Guardar(FrutaVerdura frutaVerdura)
        {
            string sqltxt = $"INSERT [dbo].[FrutaVerdura] ([id_Frutaverdura],[nombre],[id_tipo]) " +
                $"VALUES ('{frutaVerdura.id_FrutaVerdura},{frutaVerdura.Nombre},{frutaVerdura.id_Tipo}')";
            return _BD.EjecutarSQL(sqltxt);

        }
    }
}
