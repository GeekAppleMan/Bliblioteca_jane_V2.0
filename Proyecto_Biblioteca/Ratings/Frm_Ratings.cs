using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca.Ratings
{
    public partial class Frm_Ratings : Form
    {
        Cls_libros obj_libros = new Cls_libros();
        public Frm_Ratings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void Frm_Ratings_Load(object sender, EventArgs e)
        {
            buscar();
        }

        private void txt_codigo_libro_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            obj_libros.mas_prestado(dgv_libros, txt_codigo_libro.Text,combo_limite.Text);
        }

        private void txt_codigo_libro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscar();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void combo_limite_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_limite_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
