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
    public class Usuario
    {
        private acceso_BD _BD;

        public Usuario()
        {
            _BD = new acceso_BD();
        }
        public DataTable obtenerEmpleadoDT()
        {
            string sqltxt = "SELECT * FROM nombre";
            return _BD.consulta(sqltxt);

        }
    
        public bool Guardar(Empleado empleado)
        {
            string sqltxt = $"INSERT [dbo].[Empleado] ([legajo],[nombre],[apellido],[nro_Doc],[fecha_alta],[fecha_baja]) " +
                $"VALUES ('{empleado.legajo},{empleado.nombre},{empleado.apellido},{empleado.nro_Doc},{empleado.fecha_alta},{empleado.fecha_baja}')";
            return _BD.EjecutarSQL(sqltxt);

        }
    }
}
