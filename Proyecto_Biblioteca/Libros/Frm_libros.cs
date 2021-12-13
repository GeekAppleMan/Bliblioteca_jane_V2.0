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
    }
}
