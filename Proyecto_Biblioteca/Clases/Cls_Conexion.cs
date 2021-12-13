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
        
        //public static string connectionString = "datasource=127.0.0.1;port=3306;username=127.0.0.1;password=;database=bd_biblioteca;";
        public static string connectionString = "datasource=127.0.0.1;port=8080;username=noan;password=luna;database=db_biblioteca;";
        public MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    }
}
