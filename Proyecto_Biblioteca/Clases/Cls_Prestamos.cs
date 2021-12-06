using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_Biblioteca
{
    class Cls_Prestamos : Cls_Conexion
    {
        public DataTable tabla_pedido = new DataTable();
        public string codigo { get; set; }
        public static string matricula_usu { get; set; }
        public string matricula_alum { get; set; }
        public int dias { get; set; }
        public bool estatus { get; set; } 
        public bool alumno { get; set; }
        public void completar_tabla(DataGridView grid)
        {
            try
            {
                if (tabla_pedido.Columns.Count > 0)
                {
                    verificar_estatus();
                    verificar_alumno();
                    if (estatus == true && alumno == true)
                    {
                        DateTime fecha_dev = Convert.ToDateTime(DateTime.Now.ToString("d"));
                        DateTime fecha_Dev = fecha_dev.AddDays(dias);
                        string nombre_libro = buscar_nombre();
                        int cantidad = 1;
                        string id_libro = buscar_id_libro();
                        string id_usuario = buscar_id_usuario();
                        string id_alumno = buscar_id_alumno();
                        string fecha_salida = DateTime.Now.Date.ToString("d");
                        string id_devolucion = "";
                        bool id_dev = false;
                        if (tabla_pedido.Rows.Count == 0)
                        {
                            id_devolucion = Convert.ToString(buscar_id_dev());
                        }
                        else
                        {
                            for (int i = 0; i < tabla_pedido.Rows.Count; i++)
                            {
                                if (tabla_pedido.Rows[i]["Id_libro"].ToString() == id_libro)
                                {
                                    id_devolucion = tabla_pedido.Rows[i]["Id_devolucion"].ToString();
                                    id_dev = true;
                                }
                            }

                            if (id_dev != true)
                            {
                                id_devolucion = Convert.ToString(Convert.ToInt32(tabla_pedido.Rows[tabla_pedido.Rows.Count - 1]["Id_devolucion"].ToString()) + 1);
                            }

                        }
                        bool verificar = false;
                        for (int i = 0; i < tabla_pedido.Rows.Count; i++)
                        {
                            if (tabla_pedido.Rows[i]["Id_libro"].ToString() == id_libro)
                            {
                                int resul = cantidad_libro(tabla_pedido.Rows[i]["Id_libro"].ToString());
                                if (resul == Convert.ToInt32(tabla_pedido.Rows[i]["Cantidad"].ToString()))
                                {
                                    MessageBox.Show("Has agregado todos los libros disponibles");
                                }
                                else
                                {
                                    DialogResult result = MessageBox.Show("Seguro que desea añadir el mismo libro?", "Confirmar", MessageBoxButtons.YesNo);
                                    if (result == DialogResult.Yes)
                                    {
                                        //agregar +1 a la cantidad
                                        tabla_pedido.Rows[i]["Cantidad"] = Convert.ToInt32(Convert.ToInt32(tabla_pedido.Rows[i]["Cantidad"].ToString()) + 1);
                                        grid[1, i].Value = Convert.ToInt32(tabla_pedido.Rows[i]["Cantidad"].ToString());
                                    }
                                    else if (result == DialogResult.No)
                                    {
                                    }
                                    else if (result == DialogResult.Cancel)
                                    {
                                    }
                                }
                                verificar = true;
                            }
                        }
                        if (verificar == true)
                        {

                        }
                        else
                        {
                            tabla_pedido.Rows.Add(id_libro, cantidad, id_usuario, id_alumno, fecha_salida, id_devolucion);
                            grid.Rows.Add(nombre_libro, cantidad, DateTime.Now.Date.ToString("d"), fecha_Dev.ToString("d"));
                        }
                    }
                    else
                    {
                        if (estatus == false)
                        {
                            MessageBox.Show("No hay libros disponibles o el codigo ingresado es incorrecto");
                        }
                        else if (alumno == false)
                        {
                            MessageBox.Show("No se encontro al alumno verifique la matricula");
                        }
                    }

                }
                else
                {
                    verificar_estatus();
                    verificar_alumno();
                    if (estatus == true && alumno == true)
                    {
                        tabla_pedido.Columns.Add("Id_libro");
                        tabla_pedido.Columns.Add("Cantidad");
                        tabla_pedido.Columns.Add("Id_usuario");
                        tabla_pedido.Columns.Add("Id_Alumno");
                        tabla_pedido.Columns.Add("Fecha_salida");
                        tabla_pedido.Columns.Add("Id_devolucion");
                        DateTime fecha_dev = Convert.ToDateTime(DateTime.Now.ToString("d"));
                        DateTime fecha_Dev = fecha_dev.AddDays(dias);
                        string nombre_libro = buscar_nombre();
                        string id_libro = buscar_id_libro();
                        string id_usuario = buscar_id_usuario();
                        int cantidad = 1;
                        string id_alumno = buscar_id_alumno();
                        string fecha_salida = DateTime.Now.Date.ToString("d");
                        string id_devolucion = Convert.ToString(buscar_id_dev());
                        tabla_pedido.Rows.Add(id_libro, cantidad, id_usuario, id_alumno, fecha_salida, id_devolucion);
                        grid.Rows.Add(nombre_libro, cantidad, DateTime.Now.Date.ToString("d"), fecha_Dev.ToString("d"));
                    }
                    else
                    {
                        if (estatus == false)
                        {
                            MessageBox.Show("No hay libros disponibles o el codigo ingresado es incorrecto");
                        }
                        else if (alumno == false)
                        {
                            MessageBox.Show("No se encontro al alumno verifique la matricula");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con el equipo de sistemas");
            }
            
        }
        private string buscar_id_libro()
        {
            string id_libro = "";
            string query = "SELECT Id_libro FROM tb_libro WHERE Codigo_Libro = " + "'" + codigo + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       id_libro = reader.GetString(0);
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
            return id_libro;
        }
        private string buscar_id_usuario()
        {
            string id_usuario = "";
            string query = "SELECT Id_usuario FROM tb_usuarios WHERE Matricula = " + "'" + matricula_usu + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        id_usuario = reader.GetString(0);

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
            return id_usuario;
        }
        private string buscar_id_alumno()
        {
            string id_alumno = "";
            string query = "SELECT Id_Alumno FROM tb_alumno WHERE Matricula = " + "'" + matricula_alum + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        id_alumno = reader.GetString(0);
                        alumno = true;
                        
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro el alumno");
                    alumno = false;
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return id_alumno;
        }
        private void registrar_fecha_devolucion()
        {
            try
            {
                DateTime fecha_max = Convert.ToDateTime(DateTime.Now.ToString("d"));
                DateTime fecha_Max = fecha_max.AddDays(dias + 2);
                DateTime fecha_dev = Convert.ToDateTime(DateTime.Now.ToString("d"));
                DateTime fecha_Dev = fecha_dev.AddDays(dias);
                for (int i = 0; i < tabla_pedido.Rows.Count; i++)
                {
                    string query = "INSERT INTO tb_devolucion (`Id_devolucion`, `Fecha_max_dev`, `Fecha_dev`) VALUES " + "(" + "'" + tabla_pedido.Rows[i]["Id_devolucion"] + "'" + "," + "'" + fecha_Max.ToString("d") + "'" + "," + "'" + fecha_Dev.ToString("d") + "'" + ")";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();
                    commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
           
        }
        private int buscar_id_dev()
        {
            int id = 0;
            try
            {
                string query = "select * from tb_devolucion order by Id_devolucion desc limit 1";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    id = Convert.ToInt32(reader.GetString(0));
                    databaseConnection.Close();
                    id = id + 1;
                }
                else
                {
                    id = 1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return id;
        }
        private void verificar_estatus()
        {
            try
            {
                string query = "SELECT Estatus FROM tb_libro WHERE Codigo_Libro = " + "'" + codigo + "'";
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
                        if (reader.GetString(0) == "1")
                        {
                            estatus = true;
                        }
                        else
                        {
                            estatus = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el estatus");
                    estatus = false;
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
        }
        private void verificar_alumno()
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
                        alumno = true;
                    }
                }
                else
                {
                    alumno = false;
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
           
        }
        public void registrar_pedido()
        {
            try
            {
                registrar_fecha_devolucion();
                for (int i = 0; i < tabla_pedido.Rows.Count; i++)
                {
                    int resul = 0;
                    string query = "INSERT INTO tb_prestamo (`Id_libro`, `Cantidad`, `Id_usuario`, `Id_Alumno`, `Fecha_salida`, `Id_devolucion`) VALUES " + "(" + "'" + tabla_pedido.Rows[i]["Id_libro"].ToString() + "'" + "," + "'" + tabla_pedido.Rows[i]["Cantidad"].ToString() + "'" + "," + "'" + tabla_pedido.Rows[i]["Id_usuario"].ToString() + "'" + "," + "'" + tabla_pedido.Rows[i]["Id_Alumno"].ToString() + "'" + "," + "'" + tabla_pedido.Rows[i]["Fecha_salida"].ToString() + "'" + "," + "'" + tabla_pedido.Rows[i]["Id_devolucion"].ToString() + "'" + ")";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    resul = cambiar_cantidad_libro(tabla_pedido.Rows[i]["Id_libro"].ToString(), Convert.ToInt32(tabla_pedido.Rows[i]["Cantidad"].ToString()));
                    if (resul == 0)
                    {
                        cambiar_estatus(tabla_pedido.Rows[i]["Id_libro"].ToString());
                    }
                }
                MessageBox.Show("Pedido registrado correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            
        }
        private void cambiar_estatus(string id_libro)
        {
            try
            {
                string query = "UPDATE `tb_libro` SET Estatus= " + "'" + "2" + "'" + " WHERE Id_libro = " + "'" + id_libro + "'" + " AND Cantidad_libros = 0";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
        }
        private int cambiar_cantidad_libro(string id_libro,int cantidad)
        {
            int resul = buscar_cantidad_libro(id_libro) - cantidad;
            try
            {
                string query = "UPDATE `tb_libro` SET Cantidad_libros= " + "'" + resul + "'" + " WHERE Id_libro = " + "'" + id_libro + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }

            return resul;
        }
        private int buscar_cantidad_libro(string id_libro)
        {
            int cantidad = 0;
           
            try
            {
                string query = "SELECT Cantidad_libros FROM tb_libro WHERE Id_libro = " + "'" + id_libro + "'";
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
                        cantidad = Convert.ToInt32(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro la cantidad");
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return cantidad;
        }
        private int cantidad_libro(string id_libro)
        {
            int cantidad = 0;
            try
            {
                string query = "SELECT Cantidad_libros FROM tb_libro WHERE Id_libro = " + "'" + id_libro + "'";
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
                        cantidad = Convert.ToInt32(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro la cantidad");
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return cantidad;
        }
        private string buscar_nombre()
        {
            string Nombre_libro = "";
            try
            {
                string query = "SELECT Nombre FROM tb_libro WHERE Codigo_Libro = " + "'" + codigo + "'";
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
                        Nombre_libro = reader.GetString(0);
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
            return Nombre_libro;
        }

        //public void eliminar(int celda)
        //{
        //    try
        //    {
        //        string query = "DELETE FROM `tb_devolucion` WHERE Id_devolucion = " + tabla_pedido.Rows[celda]["Id_devolucion"];
        //        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        //        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        //        commandDatabase.CommandTimeout = 60;
        //        MySqlDataReader reader;
        //        databaseConnection.Open();
        //        reader = commandDatabase.ExecuteReader();
        //        databaseConnection.Close();
        //        tabla_pedido.Rows.RemoveAt(celda);
        //        MessageBox.Show("Se elimino correctamente");
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Ocurrio un error al eliminar");
        //    }
            
        //}
       
    }
}
