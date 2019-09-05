using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace MandaleFruta.helper
{
    class acceso_BD
    {
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        string cadena_conexion = "Provider=SQLNCLI11; workstation id=MandaleFruta.mssql.somee.com;packet size=4096;user id=MandaleFruta_SQLLogin_1;pwd=7kl7qr6ggs;data source=MandaleFruta.mssql.somee.com;persist security info=False;initial catalog=MandaleFruta";
        private void conectar()
        {
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;

        }
        private void cerrar()
        {
            conexion.Close();
        }
        public DataTable consulta(string comando)

        {
            conectar();
            cmd.CommandText = comando;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cerrar();
            return tabla;

        }

        public bool EjecutarSQL(string comando)
        {
            conectar();
            cmd.CommandText = comando;
            var filasAfectadas = cmd.ExecuteNonQuery();
            cerrar();
            return filasAfectadas > 0;
        }

    }
}
