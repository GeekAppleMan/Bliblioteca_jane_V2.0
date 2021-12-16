using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca
{
    public partial class Frm_historial : Form
    {
        Proyecto_Biblioteca.Clases.Cls_Historial obj = new Proyecto_Biblioteca.Clases.Cls_Historial();
        public Frm_historial()
        {
            InitializeComponent();
        }

        private void Frm_historial_Load(object sender, EventArgs e)
        {
           
            obj.buscar(dgv_prestamos, txt_matricula_alumno.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.buscar(dgv_prestamos, txt_matricula_alumno.Text);
        }

        private void txt_matricula_alumno_TextChanged(object sender, EventArgs e)
        {
            obj.buscar(dgv_prestamos, txt_matricula_alumno.Text);
        }
    }
}
