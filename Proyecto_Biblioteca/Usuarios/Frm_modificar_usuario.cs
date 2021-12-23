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
            string privilegios = "";
            if (combo_estatus.Text == "Activo")
            {
                estatus = "1";
            }
            else if(combo_estatus.Text == "Inactivo")
            {
                estatus = "2";
            }
            if (combo_privilegios.Text == "Administrador")
            {
                privilegios = "1";
            }
            if (combo_privilegios.Text == "Empleado")
            {
                privilegios = "2";
            }
            obj_usuarios.modificar(txt_matricula.Text,txt_usuario.Text,txt_contraseña.Text,txt_correo.Text,estatus,privilegios);
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_usuario.Focus();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void combo_estatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_privilegios_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
