using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca
{
    public partial class Frm_Login : Form
    {
        Cls_Prestamos obj_prestamos = new Cls_Prestamos();
        public Frm_Login()
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

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_registrar obj_registrar = new Frm_registrar();
            obj_registrar.Show();
            this.Hide();
        }

        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_contraseña.Text) || txt_usuario.Text == "Escribir usuario" || txt_contraseña.Text == "Escribir contraseña")
            {
                MessageBox.Show("Ingresa todos los datos");
            }
            else
            {
                Clases.Cls_login obj_login = new Clases.Cls_login();
                obj_login.verificar_usuario_contraseña(txt_usuario.Text, txt_contraseña.Text, this);
            }
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscar();
            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
