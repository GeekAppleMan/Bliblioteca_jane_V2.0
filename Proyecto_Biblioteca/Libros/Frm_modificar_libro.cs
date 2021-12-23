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
    public partial class Frm_modificar_libro : Form
    {
        Cls_libros obj_libros = new Cls_libros();
        public Frm_modificar_libro()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string estatus = "";
            if (combo_estatus.Text == "Activo")
            {
                estatus = "1";
            }
            else if(combo_estatus.Text == "Inactivo")
            {
                estatus = "2";
            }
            if (string.IsNullOrEmpty(txt_codigo_libro.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_cantidad_libros.Text) || string.IsNullOrEmpty(txt_autor.Text) || string.IsNullOrEmpty(txt_genero.Text) || string.IsNullOrEmpty(txt_pais_autor.Text) || string.IsNullOrEmpty(txt_numero_pag.Text) || string.IsNullOrEmpty(txt_año_edicion.Text) || string.IsNullOrEmpty(combo_estatus.Text))
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                obj_libros.modificar(txt_codigo_libro.Text, txt_nombre.Text, txt_cantidad_libros.Text, txt_autor.Text, txt_genero.Text, txt_pais_autor.Text, txt_numero_pag.Text, txt_año_edicion.Text, estatus,this);
            }
        }

        private void txt_codigo_libro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_nombre.Focus();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cantidad_libros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_numero_pag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_año_edicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void combo_estatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
