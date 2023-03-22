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
    internal class Grado
    {

        public int Id { get; set; }
        public string Nombre { get; set; }


        public Grado()
        {
        }

        public List<string> ListarGrados()
        {
            var listaGrados = new List<string>();
            try
            {
                using (var conexion = new ConexionBD().AbrirConexion())
                {
                    var query = "SELECT * FROM Grados";
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var grado = Convert.ToString(reader["nombre"]);
                                listaGrados.Add(grado);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"No se pudo obtener los grados: {ex.Message}");
            }
            return listaGrados;
        }



    }

}
