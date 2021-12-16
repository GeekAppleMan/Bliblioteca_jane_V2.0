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
    public partial class Frm_usuarios : Form
    {
        Cls_usuarios obj_usuarios = new Cls_usuarios();
        public Frm_usuarios()
        {
            InitializeComponent();
        }

        private void Frm_usuarios_Load(object sender, EventArgs e)
        {
            añadir();
        }

        private void añadir()
        {
            obj_usuarios.buscar(dgv_usuario, txt_usuario.Text);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            añadir();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            añadir();
        }
    }
}
