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
    public partial class Frm_Alumnos : Form
    {
        Cls_Alumnos obj_alumnos = new Cls_Alumnos();
        public Frm_Alumnos()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            añadir();
        }

        private void Frm_Alumnos_Load(object sender, EventArgs e)
        {
            añadir();
        }

        private void añadir()
        {
            obj_alumnos.buscar(dgv_alumnos, txt_alumno.Text);
        }

        private void dgv_alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_alumno_TextChanged(object sender, EventArgs e)
        {
            añadir();
        }
    }
}
