using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca.Usuarios
{
    public partial class Frm_modificar_usuario : Form
    {
        Cls_usuarios obj_usuarios = new Cls_usuarios();
        public Frm_modificar_usuario()
        {
            InitializeComponent();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string estatus = "";
            if (combo_estatus.Text == "Activo")
            {
                estatus = "1";
            }
            else if(combo_estatus.Text == "Inactivo")
            {
                estatus = "2";
            }
            obj_usuarios.modificar(txt_matricula.Text,txt_usuario.Text,txt_contraseña.Text,estatus);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
