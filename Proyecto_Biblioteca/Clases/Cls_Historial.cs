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
        public int id_alumno { get; set; }
        public int id_libro { get; set; }
        public int id_usuario { get; set; }
        public int id_dev { get; set; }
        private int count { get; set; }
      
        public void prestamos(DataGridView tabla)
        {
            string nombre_libro = buscar_libro();
            List<int> cantidad = buscar_cantidad();
            List<string> nombre_apellidos_usuario = buscar_nombre_apellidos_usuario();
            string nombre_apellidos_alumno = buscar_nombre_apellidos_alumno();
            List<string> fecha_salida = buscar_fecha_salida();
            List<string> fecha_devolucion = buscar_fecha_devolucion();
            for (int i = 0; i < count; i++)
            {
                tabla.Rows.Add(nombre_libro, cantidad[i], nombre_apellidos_usuario[i], nombre_apellidos_alumno, fecha_salida[i], fecha_devolucion[i]);
            }
           
        }
        private void buscar_id_libro()
        {

            try
            {

                string query = "SELECT Id_libro FROM tb_prestamo WHERE Id_Alumno = " + "'" + id_alumno + "'";
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
                        id_libro = Convert.ToInt32(reader.GetString(0));
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
        }
        private void buscar_id_usuario()
        {
         

            try
            {
                string query = "SELECT Id_usuario FROM tb_prestamo WHERE Id_Alumno = " + "'" + id_alumno + "'";
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

                        id_usuario = Convert.ToInt32(reader.GetString(0));
                        count++;
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
        }
        private void buscar_id_dev()
        {
            try
            {
                string query = "SELECT Id_devolucion FROM tb_prestamo WHERE Id_Alumno = " + "'" + id_alumno + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        id_dev = Convert.ToInt32(reader.GetString(0));

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
        }
        public void buscar_id_alumno(string matricula_alum)
        {
            try
            {
                string query = "SELECT Id_Alumno FROM tb_alumno WHERE Matricula = " + "'" + matricula_alum + "'";
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
                        id_alumno = Convert.ToInt32(reader.GetString(0));
                    }
                    buscar_id_libro();
                    buscar_id_usuario();
                    buscar_id_dev();
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
        }
        private string buscar_libro()
        {
            string resul = "";
            try
            {
                string query = "SELECT Nombre FROM tb_libro WHERE Id_libro = " + "'" + id_libro + "'";
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
                    MessageBox.Show("No se encontro el libro");
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return resul;
        }
        private string buscar_nombre_apellidos_alumno()
        {
            string resul = "";
            try
            {
                string query = "SELECT Nombres,Apellidos FROM tb_alumno WHERE Id_Alumno = " + "'" + id_alumno + "'";
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
        private List<string> buscar_nombre_apellidos_usuario()

        {
            List<string> resul = new List<string>();
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

                        resul.Add(reader.GetString(0) + " " + reader.GetString(1));

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
        private List<string> buscar_fecha_devolucion()
        {
            List<string> resul = new List<string>();
            try
            {
                string query = "SELECT * FROM tb_devolucion WHERE Id_devolucion = " + "'" + id_dev + "'";
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

                        resul.Add(reader.GetString(1));

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
        private List<int> buscar_cantidad()
        {
            List<int> result = new List<int>();
            try
            {
                string query = "SELECT * FROM tb_prestamo WHERE Id_Alumno = " + "'" + id_alumno + "'";
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
                        result.Add(Convert.ToInt32(reader.GetString(2)));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro la cantidad");
                }

                databaseConnection.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return result;
        }
        private List<string> buscar_fecha_salida()
        {
            List<string> result = new List<string>();
            try
            {
                string query = "SELECT * FROM tb_prestamo WHERE Id_Alumno = " + "'" + id_alumno + "'";
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
                        result.Add(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro la fecha de salida");
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return result;
        }

    }
}
