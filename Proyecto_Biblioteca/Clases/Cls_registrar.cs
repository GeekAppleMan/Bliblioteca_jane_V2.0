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
        public void registrar_usuario(string matricula, string usuario, string contraseña, string correo)
        {
            try
            {
                string query = "INSERT INTO `tb_usuarios`(`id_usuario`, `matricula`, `usuario`, `contraseña`, `correo`, `estatus`, `privilegios`) VALUES ('" + "" + "'," + "'" + matricula + "'," + "'" + usuario + "'," + "'" + contraseña + "'," + "'" + correo + "'," + "'1'" + "," + "'2'" + ")";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Registro completado");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con sistemas");
            }
        }
    }
}
