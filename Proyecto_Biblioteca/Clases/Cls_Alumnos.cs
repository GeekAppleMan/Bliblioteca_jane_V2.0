using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Biblioteca
{
    class Cls_Alumnos : Cls_Conexion
    {
        public static int index { get; set; }
        public static DataTable tabla_id = new DataTable();
        public void buscar(DataGridView tabla, string matricula)
        {
            string estatus = "";
            if (matricula == "")
            {
                if (tabla_id.Columns.Count == 0)
                {
                    tabla_id.Columns.Add("id_alumno");
                }
                tabla_id.Rows.Clear();
                tabla.Rows.Clear();
                string query = "SELECT * FROM tb_alumno WHERE estatus = '1'";
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
                        if (reader.GetString(5) == "1")
                        {
                            estatus = "Activo";
                        }
                        else if (reader.GetString(5) == "2")
                        {
                            estatus = "Inactivo";
                        }
                        
                        tabla.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), estatus);
                        tabla_id.Rows.Add(reader.GetString(0));
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
                tabla_id.Rows.Clear();
                tabla.Rows.Clear();
                string query = "SELECT * FROM tb_alumno WHERE matricula LIKE " + "'%" + matricula + "%'";
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
                        if (reader.GetString(5) == "1")
                        {
                            estatus = "Activo";
                        }
                        else if (reader.GetString(5) == "2")
                        {
                            estatus = "Inactivo";
                        }

                        tabla.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), estatus);
                        tabla_id.Rows.Add(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el alumno");
                }

                databaseConnection.Close();
            }

        }

        public void leer_ruta(DataTable dt, string matricula)
        {
            try
            {
                string query = "SELECT * FROM tb_alumno WHERE matricula = " + matricula;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                databaseConnection.Open();
                Adapter.SelectCommand = commandDatabase;
                Adapter.Fill(dt);
                databaseConnection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void modificar(string matricula, string nombres, string apellidos,string domicilio, string estatus)
        {
            try
            {
                string query = "UPDATE `tb_alumno` SET  `matricula`= " + "'" + matricula + "'" + ",`nombres`= " + "'" + nombres + "'" + ",`apellidos`= " + "'" + apellidos + "'" + ",`domicilio`= " + "'" + domicilio + "'" + ",`estatus`= " + "'" + estatus + "'" + "WHERE id_alumno = " + "'" + tabla_id.Rows[index]["id_alumno"].ToString() + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se actualizo correctamente");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con sistemas");
            }
        }

        public void eliminar()
        {
            try
            {
                string query = "UPDATE `tb_alumno` SET  `estatus`= " + "'2'" + "WHERE id_alumno = " + "'" + tabla_id.Rows[index]["id_alumno"].ToString() + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se elimino el alumno");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con sistemas");
            }
        }
    }
}
