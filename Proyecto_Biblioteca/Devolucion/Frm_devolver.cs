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
            Cls_Historial obj_historial = new Cls_Historial();
            obj_historial.regresar_libro(txt_codigo_libro.Text);
            txt_codigo_libro.Text = "";
        }
    }
}
