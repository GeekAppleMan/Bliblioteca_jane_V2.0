using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca.Recuperar_contraseña
{
    public partial class Frm_recuperar_contraseña : Form
    {
        public Frm_recuperar_contraseña()
        {
            InitializeComponent();
        }

        private void pic_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_recuperar_contraseña_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_Login obj_login = new Frm_Login();
            obj_login.Show();
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (txt_correo.Text == "")
            {
                txt_correo.Text = "Escribir correo";
                txt_correo.ForeColor = Color.Gray;
            }
        }

        private void txt_correo_Enter(object sender, EventArgs e)
        {
            if (txt_correo.Text == "Escribir correo")
            {
                txt_correo.Text = "";
                txt_correo.ForeColor = Color.Black;
            }
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
            {
                txt_codigo.Text = "Escribir codigo";
                txt_codigo.ForeColor = Color.Gray;
            }
        }

        private void txt_codigo_Enter(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "Escribir codigo")
            {
                txt_codigo.Text = "";
                txt_codigo.ForeColor = Color.Black;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "")
            {
                txt_contraseña.Text = "Escribir contraseña nueva";
                txt_contraseña.ForeColor = Color.Gray;
            }
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "Escribir contraseña nueva")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.Black;
            }
        }

        private void txt_verificar_contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_verificar_contraseña.Text == "")
            {
                txt_verificar_contraseña.Text = "Verificar contraseña";
                txt_verificar_contraseña.ForeColor = Color.Gray;
            }
        }

        private void txt_verificar_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_verificar_contraseña.Text == "Verificar contraseña")
            {
                txt_verificar_contraseña.Text = "";
                txt_verificar_contraseña.ForeColor = Color.Black;
            }
        }

        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txt_codigo.Focus();
            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txt_contraseña.Focus();
            }
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txt_verificar_contraseña.Focus();
            }
        }

        private void txt_verificar_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                modificar();
            }
        }

        private void modificar()
        {
            
        }
    }
}
