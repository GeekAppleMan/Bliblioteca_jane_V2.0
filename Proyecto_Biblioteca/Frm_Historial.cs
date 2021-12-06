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
    public partial class Frm_Historial : Form
    {
        Cls_Historial obj_historial = new Cls_Historial();
        public Frm_Historial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj_historial.buscar_id_alumno(txt_matricula_alumno.Text);
            obj_historial.prestamos(dgv_prestamos);
        }
    }
}
