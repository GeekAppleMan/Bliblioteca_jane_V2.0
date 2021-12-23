using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto_Biblioteca
{
    class Cls_libros : Cls_Conexion
    {
        public static DataTable tabla_id = new DataTable();
        public static int index {get;set;}

        public void buscar(DataGridView tabla, string codigo_libro)
        {
            string estatus = "";
            if (tabla_id.Columns.Count == 0)
            {
                tabla_id.Columns.Add("Id_libro");
            }
            if (codigo_libro == "")
            {
                tabla_id.Rows.Clear();
                tabla.Rows.Clear();
                string query = "SELECT * FROM tb_libro WHERE estatus = " + "1";
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
                        if (reader.GetString(9) == "1")
                        {
                            estatus = "Activo";
                        }
                        else if(reader.GetString(9) == "2")
                        {
                            estatus = "Inactivo";
                        }
                        tabla.Rows.Add(reader.GetString(1), reader.GetString(3), reader.GetString(2), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), estatus);
                        tabla_id.Rows.Add(reader.GetString(0));
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
                tabla_id.Rows.Clear();
                tabla.Rows.Clear();
                string query = "SELECT * FROM tb_libro WHERE codigo_libro LIKE " + "'%" + codigo_libro + "%'";
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

                        if (reader.GetString(9) == "1")
                        {
                            estatus = "Activo";
                        }
                        else if (reader.GetString(9) == "2")
                        {
                            estatus = "Inactivo";
                        }
                        tabla.Rows.Add(reader.GetString(1), reader.GetString(3), reader.GetString(2), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), estatus);
                        tabla_id.Rows.Add(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el libro");
                }

                databaseConnection.Close();
            }

        }

        public void mas_prestado(DataGridView tabla, string codigo_libro)
        {
            if (codigo_libro == "")
            {
                tabla.Rows.Clear();
                string query = "SELECT * FROM tb_libro ORDER BY prestamos DESC";
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
                        tabla.Rows.Add(reader.GetString(1), reader.GetString(3), reader.GetString(2), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9),reader.GetString(10));
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
                string query = "SELECT * FROM tb_libro WHERE codigo_libro LIKE " + "'%" + codigo_libro + "%'" + "ORDER BY prestamos DESC";
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
                        tabla.Rows.Add(reader.GetString(1), reader.GetString(3), reader.GetString(2), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el libro");
                }

                databaseConnection.Close();
            }

        }

        public void modificar(string codigo, string nombre, string cantidad, string autor, string genero, string pais, string numero, string año, string estatus,Form principal)
        {
            try
            {
                string query = "UPDATE `tb_libro` SET  `codigo_libro`= " + "'" + codigo + "'" + ",`cantidad_libros`= " + "'" + cantidad + "'" + ",`nombre`= " + "'" + nombre + "'" + ",`autor`= " + "'" + autor + "'" + ",`genero`= " + "'" + genero + "'" + ",`pais_autor`= " + "'" + pais + "'" + ",`no_pag`= " + "'" + numero + "'" + ",`año_edicion`= " + "'" + año + "'" + ",`estatus`= " + "'" + estatus + "'" + "WHERE id_libro = " + "'" + tabla_id.Rows[index]["id_libro"].ToString() + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se actualizo correctamente");
                principal.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con sistemas");
            }
        }

        public void eliminar()
        {
            try
            {
                string query = "UPDATE `tb_libro` SET  `estatus`= " + "'2'" + "WHERE id_libro = " + "'" + tabla_id.Rows[index]["id_libro"].ToString() + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se elimino el libro");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con sistemas");
            }
        }

        public void registrar(string codigo, string nombre, string cantidad, string autor, string genero, string pais, string numero, string año, string estatus, Form principal)
        {
            try
            {
                bool verificar = verificar_codigo(codigo);
                if (verificar == true)
                {
                    MessageBox.Show("El libro ya se encuentra registrado");
                }
                else
                {
                    string query = "INSERT INTO `tb_libro`(`id_libro`, `codigo_libro`, `cantidad_libros`, `nombre`, `autor`, `genero`, `pais_autor`, `no_pag`, `año_edicion`, `estatus`, `prestamos`) VALUES (" + "'" + "" + "'" + "," + "'" + codigo + "'," + "'" + cantidad + "'," + "'" + nombre + "'," + "'" + autor + "'," + "'" + genero + "'" + "," + "'" + pais + "'" + "," + "'" + numero + "'" + "," + "'" + año + "'" + "," + "'" + estatus + "'" + "," + "'0'" + ")";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Se registro correctamente");
                    principal.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con sistemas");
            }
        }

        public bool verificar_codigo(string codigo)
        {
            bool verificar = false;
            try
            {
              
                string query = "SELECT * FROM tb_libro WHERE codigo_libro = " + "'" + codigo + "'";
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
                else
                {
                    Console.WriteLine("No se encontro el libro");
                    verificar = false;
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
