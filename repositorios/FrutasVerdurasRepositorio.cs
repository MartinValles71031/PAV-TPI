using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandaleFruta.helper;
using System.Data;
using MandaleFruta.Modelos;


namespace MandaleFruta.repositorios
{
    public class FrutasVerdurasRepositorio
    {
        private acceso_BD _BD;

        public FrutasVerdurasRepositorio()
        {
            _BD = new acceso_BD();
        }
        public DataTable obtenerFrutasVerdurasDT()
        {
            string sqltxt = "SELECT * FROM FrutaVerdura";
            return _BD.consulta(sqltxt);

        }
        public DataTable obtenerTipoFrutasVerdurasDT()
        {
            string sqltxt = "SELECT * FROM tipo_FrutaVerdura";
            return _BD.consulta(sqltxt);
        }
        
        public bool Guardar(FrutaVerdura frutaVerdura)
        {
            string sqltxt = $"INSERT [dbo].[FrutaVerdura] ([id_Frutaverdura],[Nombre], [tipo_FrutaVerdura]) " +
                $"VALUES ('{frutaVerdura.id_FrutaVerdura},{frutaVerdura.Nombre},{frutaVerdura.id_Tipo}')";
            return _BD.EjecutarSQL(sqltxt);
        }
    }
}
