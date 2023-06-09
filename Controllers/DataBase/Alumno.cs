﻿using System;
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

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Grado { get; set; }


        public Alumno()
        {
        }

        public string GuardarAlumno(string nombres, string apellidos, int edad)
        {
            string mensaje = "";
            try
            {
                using (var conexion = new ConexionBD().AbrirConexion())
                {
                    var query = "INSERT INTO Alumnos (Nombres, Apellidos, Edad) VALUES (@Nombres, @Apellidos, @Edad)";
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombres", nombres);
                        comando.Parameters.AddWithValue("@Apellidos", apellidos);
                        comando.Parameters.AddWithValue("@Edad", edad);

                        comando.ExecuteNonQuery();
                    }
                }
                mensaje = $"Alumno guardado: Nombres: {nombres}, Apellidos: {apellidos}, Edad: {edad}";
            }
            catch (SqlException ex)
            {
                mensaje = $"Error al guardar el alumno: {ex.Message}";
            }
            return mensaje;
        }


        public List<Alumno> ListarAlumnos(string filtroGrado = "")
        {
            var listaAlumnos = new List<Alumno>();
            try
            {
                using (var conexion = new ConexionBD().AbrirConexion())
                {
                    var query = "SELECT * FROM vista_alumnos_grados";
                    if (!string.IsNullOrEmpty(filtroGrado))
                    {
                        query += " WHERE Grado = @Grado";
                    }
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        if (!string.IsNullOrEmpty(filtroGrado))
                        {
                            comando.Parameters.AddWithValue("@Grado", filtroGrado);
                        }
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var alumno = new Alumno()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Nombres = Convert.ToString(reader["Nombres"]),
                                    Apellidos = Convert.ToString(reader["Apellidos"]),
                                    Edad = Convert.ToInt32(reader["Edad"]),
                                    Grado = Convert.ToString(reader["Grado"])
                                };
                                listaAlumnos.Add(alumno);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"No se pudo obtener los alumnos: {ex.Message}");
            }
            return listaAlumnos;
        }






    }

}
