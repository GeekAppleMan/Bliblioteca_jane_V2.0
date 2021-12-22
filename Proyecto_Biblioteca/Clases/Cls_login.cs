using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto_Biblioteca.Clases
{
    class Cls_login :Cls_Conexion
    {
        public void verificar_usuario_contraseña(string usuario, string contraseña,Form login)
        {
            string query = "SELECT * FROM tb_usuarios WHERE usuario = " + "'" + usuario + "'" + "AND contraseña = " + "'" + contraseña + "'";
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
                        Frm_main.privilegio = Convert.ToInt32(reader.GetString(5));
                        Frm_main.nombre = reader.GetString(2);
                        login.Hide();
                        Frm_main obj_main = new Frm_main();
                        obj_main.Show();
                        Cls_Prestamos.matricula_usu = reader.GetString(1);
                    }
                    else if (reader.GetString(4) == "2")
                    {
                        MessageBox.Show("El usuario esta inactivo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifique el usuario y contraseña");
            }

            databaseConnection.Close();
        }
    }
}
