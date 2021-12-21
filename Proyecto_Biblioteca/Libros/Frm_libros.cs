using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca.Libros
{
    public partial class Frm_libros : Form
    {
        Cls_libros obj_libros = new Cls_libros();
        public Frm_libros()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_libros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_libros_Load(object sender, EventArgs e)
        {
            añadir();
        }

        public void añadir()
        {
            obj_libros.buscar(dgv_libros, txt_codigo_libro.Text);
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            añadir();
        }

        private void txt_codigo_libro_TextChanged(object sender, EventArgs e)
        {
            añadir();
        }

        private void txt_codigo_libro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                añadir();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_libros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 9 || e.ColumnIndex == 10) && e.RowIndex == -1)
            {

            }
            else
            {
                if (e.ColumnIndex == 9)
                {
                    Frm_modificar_libro obj_libro = new Frm_modificar_libro();
                    obj_libro.txt_codigo_libro.Text = dgv_libros[0, e.RowIndex].Value.ToString();
                    obj_libro.txt_nombre.Text = dgv_libros[1, e.RowIndex].Value.ToString();
                    obj_libro.txt_cantidad_libros.Text = dgv_libros[2, e.RowIndex].Value.ToString();
                    obj_libro.txt_autor.Text = dgv_libros[3, e.RowIndex].Value.ToString();
                    obj_libro.txt_genero.Text = dgv_libros[4, e.RowIndex].Value.ToString();
                    obj_libro.txt_pais_autor.Text = dgv_libros[5, e.RowIndex].Value.ToString();
                    obj_libro.txt_numero_pag.Text = dgv_libros[6, e.RowIndex].Value.ToString();
                    obj_libro.txt_año_edicion.Text = dgv_libros[7, e.RowIndex].Value.ToString();
                    Cls_libros.index = e.RowIndex;
                    obj_libro.ShowDialog();
                    añadir();
                }
                if (e.ColumnIndex == 10)
                {
                    Cls_libros.index = e.RowIndex;
                    obj_libros.eliminar();
                    añadir();
                }
            }
        }
    }
}
