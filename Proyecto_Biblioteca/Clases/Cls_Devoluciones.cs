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
                    if (tabla_prestamo.Columns.Count == 0)
                    {
                        tabla_prestamo.Columns.Add("id_libro");
                        tabla_prestamo.Columns.Add("id_prestamo");
                        tabla_prestamo.Columns.Add("codigo_libro");
                        tabla_prestamo.Columns.Add("nombre_libro");
                        tabla_prestamo.Columns.Add("cantidad");
                        tabla_prestamo.Columns.Add("nombre_usuario");
                        tabla_prestamo.Columns.Add("nombre_alumno");
                        tabla_prestamo.Columns.Add("fecha_salida");
                        tabla_prestamo.Columns.Add("fecha_dev");
                        tabla_prestamo.Columns.Add("id_devolucion");

                        string id_prestamo = reader.GetString(0);
                        string id_libro = reader.GetString(1);
                        string cantidad = reader.GetString(2);
                        string id_usuario = reader.GetString(3);
                        string fecha_salida = reader.GetString(5);
                        string id_devolucion = reader.GetString(6);

                        string nombre_libro = buscar_nombre_libro(id_libro);
                        string codigo_libro = buscar_codigo_libro(id_libro);
                        string nombre_usuario = buscar_nombre_apellidos_usuario(id_usuario);
                        string nombre_alumno = buscar_nombre_apellidos_alumno(id_alumno);
                        string fecha_dev = buscar_fecha_devolucion(id_devolucion);

                        tabla.Rows.Add(nombre_libro, cantidad, nombre_usuario, nombre_alumno, fecha_salida, fecha_dev);
                        tabla_prestamo.Rows.Add(id_libro,id_prestamo, codigo_libro ,nombre_libro, cantidad, nombre_usuario, nombre_alumno, fecha_salida, fecha_dev,id_devolucion);
                    }
                    else
                    {
                        string id_prestamo = reader.GetString(0);
                        string id_libro = reader.GetString(1);
                        string cantidad = reader.GetString(2);
                        string id_usuario = reader.GetString(3);
                        string fecha_salida = reader.GetString(5);
                        string id_devolucion = reader.GetString(6);

                        string nombre_libro = buscar_nombre_libro(id_libro);
                        string codigo_libro = buscar_codigo_libro(id_libro);
                        string nombre_usuario = buscar_nombre_apellidos_usuario(id_usuario);
                        string nombre_alumno = buscar_nombre_apellidos_alumno(id_alumno);
                        string fecha_dev = buscar_fecha_devolucion(id_devolucion);

                        tabla.Rows.Add(nombre_libro, cantidad, nombre_usuario, nombre_alumno, fecha_salida, fecha_dev);
                        tabla_prestamo.Rows.Add(id_libro,id_prestamo,codigo_libro,nombre_libro, cantidad, nombre_usuario, nombre_alumno, fecha_salida, fecha_dev,id_devolucion);
                    }
                  
                }
            }
            else
            {
                Console.WriteLine("No se encontro el libro");
            }

            databaseConnection.Close();
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
            catch (Exception )
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return resul;
        }
        private string buscar_codigo_libro(string id_libro)
        {
            string resul = "";
            try
            {
                string query = "SELECT codigo_libro FROM tb_libro WHERE id_libro = " + "'" + id_libro + "'";
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
                string query = "SELECT usuario FROM tb_usuarios WHERE Id_Usuario = " + "'" + id_usuario + "'";
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

                        resul = (reader.GetString(0));

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
                string query = "DELETE FROM `tb_devolucion` WHERE id_devolucion = " + "'" + tabla_prestamo.Rows[index]["id_devolucion"]+ "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

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
