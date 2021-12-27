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

        private string codigo { get; set; }
        Random random = new Random();
        Clases.Cls_recuperar_contraseña obj_contraseña = new Clases.Cls_recuperar_contraseña();
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
                mandar_correo();
            }
        }

        private void generar_codigo()
        {
            codigo = "";
            for (int i = 0; i < 6; i++)
            {
                codigo += random.Next(0,10).ToString();
            }
        }

        private void mandar_correo()
        {
            generar_codigo();
            System.Net.Mail.MailMessage ObjMensaje = new System.Net.Mail.MailMessage();
            ObjMensaje.To.Add("geekappleman@gmail.com");
            ObjMensaje.Subject = "Codigo para modificar contraseña";
            ObjMensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            ObjMensaje.Bcc.Add("geekappleman@gmail.com");

            ObjMensaje.Body = "El codigo de confirmacion es: " + codigo;
            ObjMensaje.BodyEncoding = System.Text.Encoding.UTF8;
            ObjMensaje.IsBodyHtml = true;
            ObjMensaje.From = new System.Net.Mail.MailAddress(txt_correo.Text);

            System.Net.Mail.SmtpClient Cliente = new System.Net.Mail.SmtpClient();
            Cliente.Credentials = new System.Net.NetworkCredential("geekappleman@gmail.com", "Jaimehbo13");
            Cliente.Port = 587;
            Cliente.EnableSsl = true;

            Cliente.Host = "smtp.gmail.com";

            try
            {
                Cliente.Send(ObjMensaje);
                MessageBox.Show("Se mando el correo");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar");
            }
        }
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool verificar_correo = obj_contraseña.verificar_correo(txt_correo.Text);
            if (verificar_correo == true)
            {
                mandar_correo();
                txt_correo.Enabled = false;
                link_enviar_codigo.Enabled = false;
                txt_codigo.Enabled = true;
                txt_contraseña.Enabled = true;
                txt_verificar_contraseña.Enabled = true;
            }
            else
            {
                txt_correo.Enabled = true;
                link_enviar_codigo.Enabled = true;
                txt_codigo.Enabled = false;
                txt_contraseña.Enabled = false;
                txt_verificar_contraseña.Enabled = false;
                MessageBox.Show("El correo ingresado no esta asociado a ningun usuario");
            }
        }

        private void btn_registrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_codigo.Text) || string.IsNullOrEmpty(txt_contraseña.Text) || string.IsNullOrEmpty(txt_verificar_contraseña.Text) || txt_codigo.Text == "Escribir codigo" || txt_contraseña.Text == "Escribir contraseña nueva" || txt_verificar_contraseña.Text == "Verificar contraseña")
            {
                MessageBox.Show("Ingresa todos los campos");
            }
            else
            {
                if (txt_contraseña.Text == txt_verificar_contraseña.Text)
                {
                   
                    if (txt_codigo.Text == codigo)
                    {
                      obj_contraseña.modificar_contraseña(txt_contraseña.Text, this);
                    }
                    else
                    {
                      MessageBox.Show("Codigo incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique la contraseña tiene que ser igual");
                }
            }
           
        }

    }
}
