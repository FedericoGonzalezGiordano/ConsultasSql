using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ReporteConsultaSQL
{
    public class Helper
    {
        private SqlConnection conexion;
        private string cadenaConexion;

        public Helper()
        {
            cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=HOTEL_DBB;Integrated Security=True";
            conexion = new SqlConnection(cadenaConexion);

        }

        public DataTable Consultar(string nombreSp)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSp;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
    }
}
