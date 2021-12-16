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
    public partial class Frm_Devolucion : Form
    {
        Cls_Historial obj_historial = new Cls_Historial();
        public Frm_Devolucion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prestamos();
        }

        private void prestamos()
        {
            if (string.IsNullOrEmpty(txt_matricula_alumno.Text))
            {
                dgv_prestamos.Rows.Clear();
            }
            else
            {
                obj_historial.prestamos(dgv_prestamos, txt_matricula_alumno.Text);
            }
        }

        private void txt_matricula_alumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                prestamos();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_prestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                Cls_Historial.index = e.RowIndex;
                Proyecto_Biblioteca.Devolucion.Frm_devolver obj_devolver = new Proyecto_Biblioteca.Devolucion.Frm_devolver();
                obj_devolver.ShowDialog();
                obj_historial.prestamos(dgv_prestamos, txt_matricula_alumno.Text);
            }
        }

        private void txt_matricula_alumno_TextChanged(object sender, EventArgs e)
        {
            prestamos();
        }
    }
}
