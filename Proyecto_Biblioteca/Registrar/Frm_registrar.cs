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
    public partial class Frm_registrar : Form
    {
        public Frm_registrar()
        {
            InitializeComponent();
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "Escribir usuario";
                txt_usuario.ForeColor = Color.Gray;
            }
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "Escribir usuario")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.Black;
            }
        }

        private void txt_contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "")
            {
                txt_contraseña.Text = "Escribir contraseña";
                txt_contraseña.ForeColor = Color.Gray;
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "Escribir contraseña")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.Black;
                txt_contraseña.UseSystemPasswordChar = false;
            }
        }

        private void txt_matricula_Leave(object sender, EventArgs e)
        {
            if (txt_matricula.Text == "")
            {
                txt_matricula.Text = "Escribir matricula";
                txt_matricula.ForeColor = Color.Gray;
            }
        }

        private void txt_matricula_Enter(object sender, EventArgs e)
        {
            if (txt_matricula.Text == "Escribir matricula")
            {
                txt_matricula.Text = "";
                txt_matricula.ForeColor = Color.Black;
            }
        }

        private void pic_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_registrar_FormClosed(object sender, FormClosedEventArgs e)
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

        private void registrar()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_matricula.Text) || string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_contraseña.Text) || string.IsNullOrEmpty(txt_correo.Text)|| txt_matricula.Text == "Escribir matricula" || txt_usuario.Text == "Escribir usuario" || txt_contraseña.Text == "Escribir contraseña" || txt_correo.Text == "Escribir correo")
                {
                    MessageBox.Show("Agregue todos los campos");
                }
                else
                {
                    Clases.Cls_registrar obj_registrar = new Clases.Cls_registrar();
                    obj_registrar.registrar_usuario(txt_matricula.Text, txt_usuario.Text, txt_contraseña.Text, txt_correo.Text);
                    this.Close();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            registrar();
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                registrar();
            }
        }

        private void txt_matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
