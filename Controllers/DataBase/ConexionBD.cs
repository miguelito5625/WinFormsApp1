using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Controllers.DataBase
{
    public class ConexionBD
    {
        private SqlConnection conexion;

        public ConexionBD()
        {
            string cadenaConexion = "Data Source=192.168.1.111;Initial Catalog=colegio;User ID=sa;Password=Mariobross5625.";
            conexion = new SqlConnection(cadenaConexion);
        }
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
