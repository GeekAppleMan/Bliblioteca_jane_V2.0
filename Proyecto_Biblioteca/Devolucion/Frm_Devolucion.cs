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
    public partial class Frm_Devoluciones : Form
    {
        Cls_Historial obj_historial = new Cls_Historial();
        public Frm_Devoluciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj_historial.prestamos(dgv_prestamos,txt_matricula_alumno.Text);
        }
    }
}
