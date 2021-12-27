using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto_Biblioteca.Clases
{
    class Cls_recuperar_contraseña : Cls_Conexion
    {
        private static int id_usuario { get; set; }
        public bool verificar_correo(string correo)
        {
            id_usuario = 0;
            bool verificar = false;
            try
            {
                string query = "SELECT * FROM tb_usuarios";
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
                        string correo_bd = reader.GetString(4);
                        if (correo_bd == correo)
                        {
                            verificar = true;
                            id_usuario = Convert.ToInt32(reader.GetString(0));
                        }
                    }
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con sistemas");
            }

            return verificar;
        }

        public void modificar_contraseña(string contraseña, Form principal)
        {
            try
            {
                string query = "UPDATE `tb_usuarios` SET `contraseña`= " + "'" + contraseña + "'" + "WHERE id_usuario = " + "'" + id_usuario + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Contraseña modificada");
                principal.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con sistemas");
            }
        }
    }
}
