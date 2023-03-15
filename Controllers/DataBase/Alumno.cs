using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp1.Controllers.DataBase
{
    internal class Alumno
    {

        private string cadenaDeConexion;

        public Alumno()
        {
            cadenaDeConexion = "Data Source=192.168.1.111;Initial Catalog=colegio;User ID=sa;Password=Mariobross5625.";
        }


        public void AgregarAlumno(string nombres, string apellidos, int edad)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO Alumnos (Nombres, Apellidos, Edad) VALUES (@Nombres, @Apellidos, @Edad)", conexion);
                    comando.Parameters.AddWithValue("@Nombres", nombres);
                    comando.Parameters.AddWithValue("@Apellidos", apellidos);
                    comando.Parameters.AddWithValue("@Edad", edad);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el alumno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}
