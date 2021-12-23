using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace Proyecto_Biblioteca
{
    class Cls_Historial : Cls_Conexion
    {
        public static DataTable tabla_prestamo = new DataTable();
        public static int index { get; set; }
        public void prestamos(DataGridView tabla, string matricula)
        {
            tabla.Rows.Clear();
            string query = "SELECT tl.nombre, tp.cantidad, tu.usuario, ta.nombres, tp.fecha_salida, td.fecha_dev,tl.id_libro,tp.id_prestamo,tl.codigo_libro,td.id_devolucion FROM tb_prestamo tp INNER JOIN tb_alumno ta ON tp.id_alumno = ta.id_alumno INNER JOIN tb_libro tl ON tp.id_libro = tl.id_libro INNER JOIN tb_usuarios tu ON tp.id_usuario = tu.id_usuario INNER JOIN tb_devolucion td ON tp.id_devolucion = td.id_devolucion WHERE ta.matricula LIKE " + "'%" + matricula + "%'";
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
                    if (tabla_prestamo.Columns.Count == 0)
                    {
                        tabla_prestamo.Columns.Add("id_libro");
                        tabla_prestamo.Columns.Add("id_prestamo");
                        tabla_prestamo.Columns.Add("codigo_libro");
                        tabla_prestamo.Columns.Add("cantidad");
                        tabla_prestamo.Columns.Add("id_devolucion");

                        tabla.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                        tabla_prestamo.Rows.Add(reader.GetString(6),reader.GetString(7),reader.GetString(8),reader.GetString(1),reader.GetString(9));
                    }
                    else
                    {
                        tabla.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                        tabla_prestamo.Rows.Add(reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(1), reader.GetString(9));
                    }
                  
                }
            }
            else
            {
                Console.WriteLine("No se encontro el libro");
            }

            databaseConnection.Close();
        }
        public void regresar_libro(string codigo_libro)
        {
            //NOTA FALTA CAMBIAR EL ESTATUS SI EN CASO DE QUE LA CANTIDAD SEA 0
            if (Convert.ToInt32(tabla_prestamo.Rows[index]["cantidad"]) > 1 && tabla_prestamo.Rows[index]["codigo_libro"].ToString() == codigo_libro)
            {
                tabla_prestamo.Rows[index]["cantidad"] = Convert.ToInt32(tabla_prestamo.Rows[index]["cantidad"]) - 1;

                //actualizar prestamo
                string query = "UPDATE tb_prestamo SET cantidad = " + "'" + tabla_prestamo.Rows[index]["cantidad"].ToString() + "'" + "WHERE id_prestamo = " + "'" + tabla_prestamo.Rows[index]["id_prestamo"] + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                databaseConnection.Close();
                query = "SELECT cantidad FROM tb_prestamo WHERE id_prestamo = " + "'" + tabla_prestamo.Rows[index]["id_prestamo"] + "'";
                databaseConnection = new MySqlConnection(connectionString);
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                MessageBox.Show("Falta regresar " + reader.GetString(0) + " libros");

                databaseConnection.Close();

                query = "SELECT cantidad_libros FROM tb_libro WHERE id_libro = " + "'" + tabla_prestamo.Rows[index]["id_libro"] + "'";
                databaseConnection = new MySqlConnection(connectionString);
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                int cantidad = Convert.ToInt32(reader.GetString(0));

                databaseConnection.Close();

                //añadir libro a biblioteca
                query = "UPDATE tb_libro SET cantidad_libros = " + "'" + (cantidad + 1) + "'" + "WHERE id_libro = " + "'" + tabla_prestamo.Rows[index]["id_libro"] + "'";
                databaseConnection = new MySqlConnection(connectionString);
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();

                databaseConnection.Close();
            }
            else
            {
                //eliminar prestamo
                string query = "DELETE FROM `tb_devolucion` WHERE id_devolucion = " + "'" + tabla_prestamo.Rows[index]["id_devolucion"] + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                databaseConnection.Close();
                tabla_prestamo.Rows.RemoveAt(index);

                query = "SELECT cantidad_libros FROM tb_libro WHERE id_libro = " + "'" + tabla_prestamo.Rows[index]["id_libro"] + "'";
                databaseConnection = new MySqlConnection(connectionString);
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                int cantidad = Convert.ToInt32(reader.GetString(0));

                databaseConnection.Close(); 

                //añadir libro a biblioteca
                query = "UPDATE tb_libro SET cantidad_libros = " + "'" +  (cantidad + 1) + "'" + "WHERE id_libro = " + "'" + tabla_prestamo.Rows[index]["id_libro"] + "'";
                databaseConnection = new MySqlConnection(connectionString);
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();

                databaseConnection.Close();

                MessageBox.Show("Se regreso el libro a la biblioteca");
            }
        }
    }
}
