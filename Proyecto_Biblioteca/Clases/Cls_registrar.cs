using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto_Biblioteca.Clases
{
    class Cls_registrar : Cls_Conexion
    {
        public void registrar_usuario(string matricula, string usuario, string contraseña, string correo,Form principal)
        {
            try
            {
                bool verificarmatricula = verificar_matricula(matricula);
                bool verificarusuario = verificar_usuario(usuario);
                bool verificarcorreo = verificar_correo(correo);
               
                if (verificarmatricula == true)
                {
                    MessageBox.Show("No puede usar una matricula ya registrada intente con una nueva");
                }
                if (verificarusuario == true)
                {
                    MessageBox.Show("No se puede usar un usuario ya registrado intente con uno nuevo");
                }
                if (verificarcorreo == true)
                {
                    MessageBox.Show("No puede usar un correo ya registrado intente con uno nuevo");
                }
                else if (verificarmatricula == false && verificarusuario == false && verificarcorreo == false)
                {
                    string query = "INSERT INTO `tb_usuarios`(`id_usuario`, `matricula`, `usuario`, `contraseña`, `correo`, `estatus`, `privilegios`) VALUES ('" + "" + "'," + "'" + matricula + "'," + "'" + usuario + "'," + "'" + contraseña + "'," + "'" + correo + "'," + "'1'" + "," + "'2'" + ")";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Registro completado");
                    principal.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con sistemas");
            }
        }

        public bool verificar_correo(string correo)
        {
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
                    while(reader.Read())
                    {
                        string correo_bd = reader.GetString(4);
                        if (correo_bd == correo)
                        {
                            verificar = true;
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

        public bool verificar_matricula(string matricula)
        {
            bool verificar = false;
            try
            {
                string query = "SELECT * FROM tb_usuarios WHERE matricula = " + "'" + matricula + "'";
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
                        verificar = true;
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

        public bool verificar_usuario(string usuario)
        {
            bool verificar = false;
            try
            {
                string query = "SELECT * FROM tb_usuarios WHERE usuario = " + "'" + usuario + "'";
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
                        verificar = true;
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
    }
}
