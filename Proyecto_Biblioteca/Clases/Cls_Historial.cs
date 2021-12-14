using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Biblioteca.Clases
{
    class Cls_Historial : Cls_Conexion
    {
        public void buscar(DataGridView tabla, string matricula)
        {
            if (matricula == "")
            {
                tabla.Rows.Clear();
                string query = "SELECT tp.id_prestamo, tl.nombre, tp.cantidad, tu.usuario, ta.nombres, tp.fecha_salida, td.fecha_dev FROM tb_prestamo tp INNER JOIN tb_alumno ta ON tp.id_alumno = ta.id_alumno INNER JOIN tb_libro tl ON tp.id_libro = tl.id_libro INNER JOIN tb_usuarios tu ON tp.id_usuario = tu.id_usuario INNER JOIN tb_devolucion td ON tp.id_devolucion = td.id_devolucion";
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
                        tabla.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el libro");
                }

                databaseConnection.Close();
            }
            else
            {
                tabla.Rows.Clear();
                string query = "SELECT tp.id_prestamo, tl.nombre, tp.cantidad, tu.usuario, ta.nombres, tp.fecha_salida, td.fecha_dev FROM tb_prestamo tp INNER JOIN tb_alumno ta ON tp.id_alumno = ta.id_alumno INNER JOIN tb_libro tl ON tp.id_libro = tl.id_libro INNER JOIN tb_usuarios tu ON tp.id_usuario = tu.id_usuario INNER JOIN tb_devolucion td ON tp.id_devolucion = td.id_devolucion WHERE ta.matricula LIKE " + "'%" + matricula + "%'";
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
                        tabla.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el libro");
                }

                databaseConnection.Close();
            }
            
        }
    }
}
