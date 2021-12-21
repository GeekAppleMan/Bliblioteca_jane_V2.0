using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto_Biblioteca
{
    class Cls_usuarios : Cls_Conexion
    {
        public static int index { get; set; }
        public static DataTable tabla_id = new DataTable();

        public void buscar(DataGridView tabla, string matricula)
        {
            string estatus = "";
            if (tabla_id.Columns.Count == 0)
            {
                tabla_id.Columns.Add("id_usuario");
            }
            if (matricula == "")
            {
                tabla_id.Rows.Clear();
                tabla.Rows.Clear();
                string query = "SELECT * FROM tb_usuarios WHERE estatus = '1'";
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
                        if (reader.GetString(4) == "1")
                        {
                            estatus = "Activo";
                        }
                        else if(reader.GetString(4) == "2")
                        {
                            estatus = "Inactivo";
                        }
                        tabla.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), estatus);
                        tabla_id.Rows.Add(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el usuario");
                }

                databaseConnection.Close();
            }
            else
            {
                tabla_id.Rows.Clear();
                tabla.Rows.Clear();
                string query = "SELECT * FROM tb_usuarios WHERE matricula LIKE " + "'%" + matricula + "%'";
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
                        if (reader.GetString(4) == "1")
                        {
                            estatus = "Activo";
                        }
                        else if (reader.GetString(4) == "2")
                        {
                            estatus = "Inactivo";
                        }
                        tabla.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), estatus);
                        tabla_id.Rows.Add(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el usuario");
                }

                databaseConnection.Close();
            }

        }

        public void modificar(string matricula, string usuario, string contraseña, string estatus)
        {
            try
            {
                string query = "UPDATE `tb_usuarios` SET  `matricula`= " + "'" + matricula + "'" + ",`usuario`= " + "'" + usuario + "'" + ",`contraseña`= " + "'" + contraseña + "'" + ",`estatus`= " + "'" + estatus + "'" + "WHERE id_usuario = " + "'" + tabla_id.Rows[index]["id_usuario"].ToString() + "'";
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
                string query = "UPDATE `tb_usuarios` SET  `estatus`= " + "'2'" + "WHERE id_usuario = " + "'" + tabla_id.Rows[index]["id_usuario"].ToString() + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se elimino el usuario");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con sistemas");
            }
        }

    }
}
