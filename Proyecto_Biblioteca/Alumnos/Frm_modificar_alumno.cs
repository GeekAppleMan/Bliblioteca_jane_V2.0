using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca.Alumnos
{
    public partial class Frm_modificar_alumno : Form
    {
        Cls_Alumnos obj_alumno = new Cls_Alumnos();
        public Frm_modificar_alumno()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string estatus = "";
            if (combo_estatus.Text == "Activo")
            {
                estatus = "1";
            }
            else if (combo_estatus.Text == "Inactivo")
            {
                estatus = "2";
            }
            obj_alumno.modificar(txt_matricula.Text, txt_nombres.Text, txt_apellidos.Text, txt_domicilio.Text,estatus);
            this.Close();
        }
    }
}
