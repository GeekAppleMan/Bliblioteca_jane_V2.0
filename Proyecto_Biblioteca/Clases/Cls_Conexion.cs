using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Biblioteca
{
    class Cls_Conexion
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=Jaime;password=123;database=bd_biblioteca;";
        public MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    }
}
