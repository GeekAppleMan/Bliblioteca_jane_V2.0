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
        public static string matricula_usu { get; set; }
        int cantidad_tblibro { get; set; }
        public int dias { get; set; }

        string ahora = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");

        public void completar_tabla(DataGridView grid, string matricula,string codigo)
        {
            bool alumno = false;
            bool estatus = false;
            bool error = false;
            int id_dev = 0;
            try
            {
                string query = "SELECT ta.id_alumno, ta.nombres, ta.apellidos, (SELECT tl.id_libro FROM tb_libro tl  WHERE tl.codigo_libro = " + "'" + codigo + "'" + ") AS 'Id_libro', (SELECT tl.nombre FROM tb_libro tl  WHERE tl.codigo_libro = " + "'" +  codigo + "'" + ") AS 'nombre_libro', (SELECT tl.codigo_libro FROM tb_libro tl  WHERE tl.codigo_libro = " + "'" + codigo + "'" + ") AS 'Codigo', (SELECT tl.cantidad_libros FROM tb_libro tl  WHERE tl.codigo_libro = " + "'" + codigo + "'" + ") AS 'Cantidad', (SELECT tl.estatus FROM tb_libro tl  WHERE tl.codigo_libro = " + "'" + codigo + "'" + ") AS 'Estatus', (SELECT tu.id_usuario FROM tb_usuarios tu WHERE tu.matricula = " + "'" + matricula + "'" + ") AS 'Id_usuario', (SELECT td.id_devolucion FROM tb_devolucion td ORDER BY id_devolucion DESC LIMIT 1) AS 'Id_devolucion' FROM tb_alumno ta WHERE ta.matricula = " + "'" + matricula + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();

                try
                {
                    if (reader.GetString(0) != "")
                    {
                        alumno = true;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontro al alumno verifique la matricula, debe estar completa");
                    error = true;
                    throw;
                }

                try
                {
                    if (reader.GetString(7) == "1")
                    {
                        estatus = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No hay libros disponibles o el codigo ingresado es incorrecto");
                    error = true;
                    throw;
                }

                try
                {
                    id_dev = Convert.ToInt32(reader.GetString(9)) + 1;  
                }
                catch (Exception)
                {
                    id_dev = 1;
                }

                if (tabla_pedido.Columns.Count > 0)
                {
                    cantidad_tblibro = Convert.ToInt32(reader.GetString(6));
                    if (estatus == true && alumno == true)
                    {
                        DateTime fecha_max_dev = Convert.ToDateTime(DateTime.Now.ToString("d"));
                        DateTime fecha_Max_Dev = fecha_max_dev.AddDays((dias + 3));
                        DateTime fecha_dev = Convert.ToDateTime(DateTime.Now.ToString("d"));
                        DateTime fecha_Dev = fecha_dev.AddDays(dias);
                        bool verificar = false;
                        for (int i = 0; i < tabla_pedido.Rows.Count; i++)
                        {
                            if (tabla_pedido.Rows[i]["Id_libro"].ToString() == reader.GetString(3))
                            {
                                int resul = Convert.ToInt32(reader.GetString(6).ToString());
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
                            for (int i = 0; i < tabla_pedido.Rows.Count; i++)
                            {
                                if (Convert.ToInt32(tabla_pedido.Rows[i]["Id_devolucion"]) == id_dev)
                                {
                                    id_dev = id_dev + 1;
                                }
                            }
                            grid.Rows.Add(reader.GetString(4), 1, ahora, fecha_Dev.ToString("d"));
                            tabla_pedido.Rows.Add(reader.GetString(3), 1, reader.GetString(8), reader.GetString(0), ahora, id_dev, fecha_Max_Dev.ToString("d"), fecha_Dev.ToString("d"));
                        }
                      
                    }
                    else
                    {
                        if (alumno == true && estatus == false)
                        {
                            MessageBox.Show("Libro no encontrado o no hay disponibles");
                        }
                    }
                    
                }
                else
                {
                    if (estatus == true && alumno == true)
                    {
                        cantidad_tblibro = Convert.ToInt32(reader.GetString(6));
                        tabla_pedido.Columns.Add("Id_libro");
                        tabla_pedido.Columns.Add("Cantidad");
                        tabla_pedido.Columns.Add("Id_usuario");
                        tabla_pedido.Columns.Add("Id_alumno");
                        tabla_pedido.Columns.Add("Fecha_salida");
                        tabla_pedido.Columns.Add("Id_devolucion");
                        tabla_pedido.Columns.Add("Fecha_max_dev");
                        tabla_pedido.Columns.Add("Fecha_dev");
                        DateTime fecha_max_dev = Convert.ToDateTime(DateTime.Now.ToString("d"));
                        DateTime fecha_Max_Dev = fecha_max_dev.AddDays((dias + 3));
                        DateTime fecha_dev = Convert.ToDateTime(DateTime.Now.ToString("d"));
                        DateTime fecha_Dev = fecha_dev.AddDays(dias);


                        grid.Rows.Add(reader.GetString(4),1, ahora, fecha_Dev.ToString("d"));
                        tabla_pedido.Rows.Add(reader.GetString(3), 1, reader.GetString(8), reader.GetString(0), ahora, id_dev, fecha_Max_Dev.ToString("d"), fecha_Dev.ToString("d"));
                    }
                    else
                    {
                        if (alumno == true && estatus == false)
                        {
                            MessageBox.Show("Libro no encontrado o no hay disponibles");
                        }
                    }
                }
                
                databaseConnection.Close();
   
            }
            catch (Exception ex)
            {
                if(error == false)
                {
                    MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas" + ex.Message);
                }
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
                    string query = "INSERT INTO tb_prestamo (`id_libro`, `cantidad`, `id_usuario`, `id_alumno`, `fecha_salida`, `id_devolucion`) VALUES " + "(" + "'" + tabla_pedido.Rows[i]["Id_libro"].ToString() + "'" + "," + "'" + tabla_pedido.Rows[i]["Cantidad"].ToString() + "'" + "," + "'" + tabla_pedido.Rows[i]["Id_usuario"].ToString() + "'" + "," + "'" + tabla_pedido.Rows[i]["Id_Alumno"].ToString() + "'" + "," + "'" + tabla_pedido.Rows[i]["Fecha_salida"].ToString() + "'" + "," + "'" + tabla_pedido.Rows[i]["Id_devolucion"].ToString() + "'" + ")";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    resul = cambiar_cantidad_libro(tabla_pedido.Rows[i]["Id_libro"].ToString(), Convert.ToInt32(tabla_pedido.Rows[i]["Cantidad"].ToString()));
                    cambiar_prestamos(tabla_pedido.Rows[i]["Id_libro"].ToString());
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
        private void registrar_fecha_devolucion()
        {
            try
            {
                DateTime fecha_max = Convert.ToDateTime(DateTime.Now.ToString("d"));
                DateTime fecha_Max = fecha_max.AddDays(dias + 3);
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
        private void cambiar_estatus(string id_libro)
        {
            try
            {
                string query = "UPDATE `tb_libro` SET estatus= " + "'" + "2" + "'" + " WHERE id_libro = " + "'" + id_libro + "'" + " AND cantidad_libros = 0";
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
        private int cambiar_cantidad_libro(string id_libro, int cantidad)
        {
            int resul = (cantidad_tblibro - cantidad);
            try
            {
                string query = "UPDATE `tb_libro` SET cantidad_libros= " + "'" + resul + "'" + " WHERE id_libro = " + "'" + id_libro + "'";
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
        private void cambiar_prestamos(string id_libro)
        {
            int result = 0;
            try
            {
                string query = "SELECT prestamos FROM tb_libro WHERE id_libro =  " + "'" + id_libro + "'";
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
                        result = Convert.ToInt32(reader.GetString(0));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            
            try
            {
                result = result + 1;
                string query = "UPDATE `tb_libro` SET prestamos= " + "'" + result + "'" + " WHERE id_libro = " + "'" + id_libro + "'";
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
        public void buscar_datos_alumno(string matricula,Label Nombre, Label Apellidos,Label Estatus, Label Semestre, Label Carrera, ref string imagen)
        {
            try
            {
                if (matricula == "")
                {
                    Nombre.Text = "";
                    Apellidos.Text = "";
                    Estatus.Text = "";
                    imagen = "";
                    Semestre.Text = "";
                    Carrera.Text = "";
                }
                else
                {
                    string query = "SELECT * FROM tb_alumno WHERE matricula LIKE " + "'%" + matricula + "%'";
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
                            Nombre.Text = reader.GetString(2);
                            Apellidos.Text = reader.GetString(3);
                            Estatus.Text = reader.GetString(5);
                            imagen = reader.GetString(6);
                            Semestre.Text = reader.GetString(7);
                            Carrera.Text = reader.GetString(8);
                            if (Estatus.Text == "1")
                            {
                                Estatus.Text = "Activo";
                            }
                            else
                            {
                                Estatus.Text = "Inactivo";
                            }
                        }
                    }
                }
  
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
        }
        public void buscar_datos_libro(string codigo, Label libro, Label codigo_libro, Label cantidad, Label estatus)
        {
            if (codigo == "")
            {
                libro.Text = "";
                codigo_libro.Text = "";
                cantidad.Text = "";
                estatus.Text = "";
            }
            else
            {
                try
                {
                    string query = "SELECT * FROM tb_libro WHERE codigo_libro LIKE " + "'%" + codigo + "%'";
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
                            libro.Text = reader.GetString(3);
                            codigo_libro.Text = reader.GetString(1);
                            cantidad.Text = reader.GetString(2);
                            estatus.Text = reader.GetString(9);

                            if (estatus.Text == "1")
                            {
                                estatus.Text = "Disponible";
                            }
                            else
                            {
                                estatus.Text = "No disponible";
                            }
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
                }
            }
           
        }
    }
}
