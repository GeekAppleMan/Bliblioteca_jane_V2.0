﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Biblioteca
{
    class Cls_Alumnos : Cls_Conexion
    {
        public void buscar(DataGridView tabla, string matricula)
        {
            if (matricula == "")
            {
                tabla.Rows.Clear();
                string query = "SELECT * FROM tb_alumno";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tabla.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el alumno");
                }

                databaseConnection.Close();
            }
            else
            {
                tabla.Rows.Clear();
                string query = "SELECT * FROM tb_alumno WHERE matricula = " + "'" + matricula + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tabla.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el alumno");
                }

                databaseConnection.Close();
            }

        }
    }
}
