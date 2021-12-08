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
                string query = "SELECT * FROM tb_prestamo";
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
                        string id_prestamo = reader.GetString(0);
                        string id_libro = reader.GetString(1);
                        string cantidad = reader.GetString(2);
                        string id_usuario = reader.GetString(3);
                        string id_alumno = reader.GetString(4);
                        string fecha_salida = reader.GetString(5);
                        string id_devolucion = reader.GetString(6);

                        string nombre_libro = buscar_nombre_libro(id_libro);
                        string nombre_usuario = buscar_nombre_apellidos_usuario(id_usuario);
                        string nombre_alumno = buscar_nombre_apellidos_alumno(id_alumno);
                        string fecha_dev = buscar_fecha_devolucion(id_devolucion);

                        tabla.Rows.Add(nombre_libro, cantidad, nombre_usuario, nombre_alumno, fecha_salida, fecha_dev);
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
                string id_alumno = buscar_id_alumno(matricula);
                string query = "SELECT * FROM tb_prestamo WHERE id_alumno = " + "'" + id_alumno + "'";
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
                        string id_prestamo = reader.GetString(0);
                        string id_libro = reader.GetString(1);
                        string cantidad = reader.GetString(2);
                        string id_usuario = reader.GetString(3);
                        string fecha_salida = reader.GetString(5);
                        string id_devolucion = reader.GetString(6);

                        string nombre_libro = buscar_nombre_libro(id_libro);
                        string nombre_usuario = buscar_nombre_apellidos_usuario(id_usuario);
                        string nombre_alumno = buscar_nombre_apellidos_alumno(id_alumno);
                        string fecha_dev = buscar_fecha_devolucion(id_devolucion);

                        tabla.Rows.Add(nombre_libro, cantidad, nombre_usuario, nombre_alumno, fecha_salida, fecha_dev);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el libro");
                }

                databaseConnection.Close();
            }
            
        }
        public string buscar_id_alumno(string matricula_alum)
        {
            string resul = "";
            try
            {
                string query = "SELECT id_alumno FROM tb_alumno WHERE matricula = " + "'" + matricula_alum + "'";
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
                        resul = reader.GetString(0);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro el alumno");
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return resul;
        }
        private string buscar_nombre_libro(string id_libro)
        {
            string resul = "";
            try
            {
                string query = "SELECT nombre FROM tb_libro WHERE id_libro = " + "'" + id_libro + "'";
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
                        resul = reader.GetString(0);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el libro");
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return resul;
        }
        private string buscar_nombre_apellidos_alumno(string id_alumno)
        {
            string resul = "";
            try
            {
                string query = "SELECT nombres,apellidos FROM tb_alumno WHERE id_alumno = " + "'" + id_alumno + "'";
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

                        resul = reader.GetString(0) + " " + reader.GetString(1);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro el alumno");
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return resul;
        }
        private string buscar_nombre_apellidos_usuario(string id_usuario)

        {
            string resul = "";
            try
            {
                string query = "SELECT Nombres,Apellidos FROM tb_usuarios WHERE Id_Usuario = " + "'" + id_usuario + "'";
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

                        resul = (reader.GetString(0) + " " + reader.GetString(1));

                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el usuario");
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return resul;
        }
        private string buscar_fecha_devolucion(string id_dev)
        {
            string resul = "";
            try
            {
                string query = "SELECT * FROM tb_devolucion WHERE id_devolucion = " + "'" + id_dev + "'";
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

                        resul = (reader.GetString(1));

                    }
                }
                else
                {
                    Console.WriteLine("No se encontro la devolucion");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return resul;
        }


    }
}
