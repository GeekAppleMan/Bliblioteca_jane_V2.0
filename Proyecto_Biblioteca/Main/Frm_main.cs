﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }
        private void Frm_main_Load(object sender, EventArgs e)
        {
            abrir_form(new Frm_Inicio());
            panel_barra_izquierda.Width = 150;
            timer1.Start();
            lbl_fecha.Text = DateTime.Now.ToString("d");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("t");
        }

        private void Frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            Frm_Login obj_login = new Frm_Login();
            obj_login.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (panel_barra_izquierda.Width == 150)
            {
                panel_barra_izquierda.Width = 50;
                btninicio.TextAlign = ContentAlignment.MiddleRight;
                btnprestamos.TextAlign = ContentAlignment.MiddleRight;
                btnlibros.TextAlign = ContentAlignment.MiddleRight;
                btnusuarios.TextAlign = ContentAlignment.MiddleRight;
                btnalumnos.TextAlign = ContentAlignment.MiddleRight;
                btn_historial_prestamos.TextAlign = ContentAlignment.MiddleRight;
                btn_devolucion.TextAlign = ContentAlignment.MiddleRight;
                btn_configuracion.TextAlign = ContentAlignment.MiddleRight; 
                lbl_jane.Text = "JS";
                lbl_jane.TextAlign = ContentAlignment.MiddleLeft;
            }
            else
            {
                panel_barra_izquierda.Width = 150;
                btninicio.TextAlign = ContentAlignment.MiddleCenter;
                btnprestamos.TextAlign = ContentAlignment.MiddleCenter;
                btnlibros.TextAlign = ContentAlignment.MiddleCenter;
                btnusuarios.TextAlign = ContentAlignment.MiddleCenter;
                btnalumnos.TextAlign = ContentAlignment.MiddleCenter;
                btn_historial_prestamos.TextAlign = ContentAlignment.MiddleCenter;
                btn_devolucion.TextAlign = ContentAlignment.MiddleCenter;
                btn_configuracion.TextAlign = ContentAlignment.MiddleCenter;
                lbl_jane.Text = "Jane Software";
                lbl_jane.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void abrir_form(object formhijo)
        {
            if (this.panel_contenedor.Controls.Count == 0)
            {
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel_contenedor.Controls.Add(fh);
                this.panel_contenedor.Tag = fh;
                fh.Show();
            }
            else
            {
                this.panel_contenedor.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel_contenedor.Controls.Add(fh);
                this.panel_contenedor.Tag = fh;
                fh.Show();
            }
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_Inicio());
            lbltitulo.Text = "Inicio";
        }

        private void btnprestamos_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_Prestamos());
            lbltitulo.Text = "Prestamos";
        }

        private void btnlibros_Click(object sender, EventArgs e)
        {
            abrir_form(new Proyecto_Biblioteca.Libros.Frm_libros());
            lbltitulo.Text = "Libros";
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_usuarios());
            lbltitulo.Text = "Usuarios";
        }

        private void btnalumnos_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_Alumnos());
            lbltitulo.Text = "Alumnos";
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Ajustes";
        }

        private void btn_historial_prestamos_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_historial());
            lbltitulo.Text = "Historial";
        }

        private void btn_devolucion_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_Devolucion());
            lbltitulo.Text = "Devoluciones";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*DataTable dt = new DataTable();
            Cls_Alumnos alum = new Cls_Alumnos();
            alum.leer_ruta(dt, "2");

            string path = dt.Rows[0][6].ToString();
            var request = WebRequest.Create(path);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pbFoto.Image = Bitmap.FromStream(stream);
                System.Drawing.Image img = pbFoto.Image;
                //img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pbFoto.Image = img;
            }

            MessageBox.Show(dt.Rows[0][6].ToString());*/
        }
    }
}
