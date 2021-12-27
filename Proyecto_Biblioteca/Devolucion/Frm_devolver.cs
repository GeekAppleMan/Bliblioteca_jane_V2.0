using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca.Devolucion
{
    public partial class Frm_devolver : Form
    {
        Cls_Historial obj_historial = new Cls_Historial();
        public Frm_devolver()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            regresar();
        }

        private void regresar()
        {
            obj_historial.regresar_libro(txt_codigo_libro.Text,this);
            txt_codigo_libro.Text = "";
        }

        private void txt_codigo_libro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                regresar();
            }
        }
    }
}
