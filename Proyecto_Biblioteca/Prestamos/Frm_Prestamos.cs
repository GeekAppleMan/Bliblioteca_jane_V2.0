using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca
{
    public partial class Frm_Prestamos : Form
    {
        Cls_Prestamos obj_prestamos = new Cls_Prestamos();
        int cont = 0;
        public static bool tamaño { get; set; }

        public Frm_Prestamos()
        {
            InitializeComponent();
        }
        private void Frm_Prestamos_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_nombre_alumno.Text = "";
            lbl_apellidos_alumno.Text = "";
            lbl_carrera.Text = "";
            lbl_semestre.Text = "";
            lbl_estatus_alumno.Text = "";
            lbl_nombre_libro.Text = "";
            lbl_codigo.Text = "";
            lbl_cant.Text = "";
            lbl_estatus.Text = "";
        }
        
        private void añadir()
        {
            if (string.IsNullOrEmpty(txt_codigo_libro.Text) || string.IsNullOrEmpty(txt_matricula_alumno.Text) || string.IsNullOrEmpty(txt_cantidad_dias.Text))
            {
                MessageBox.Show("Completa los datos correctamente");
            }
            else
            {
                try
                {
                    obj_prestamos.dias = Convert.ToInt32(txt_cantidad_dias.Text);
                    obj_prestamos.completar_tabla(dgv_prestamos, txt_matricula_alumno.Text, txt_codigo_libro.Text);
                    txt_codigo_libro.Text = "";
                }
                catch (Exception)
                {

                }
             
            }
        }
        private void btnañadir_Click(object sender, EventArgs e)
        {
            añadir();
        }

        private void btn_terminar_pedido_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea registrar el pedido?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dgv_prestamos.Rows.Count == 0)
                {
                    MessageBox.Show("No se han agregado libros");
                }
                else
                {
                    obj_prestamos.registrar_pedido();
                    txt_codigo_libro.Text = "";
                    txt_matricula_alumno.Text = "";
                    txt_cantidad_dias.Text = "";
                    dgv_prestamos.Rows.Clear();
                    obj_prestamos.tabla_pedido.Rows.Clear();
                }
            }
            else if (result == DialogResult.No)
            {
            }
        }
        private void buscar_alumno()
        {
            string imagen = "";
            obj_prestamos.buscar_datos_alumno(txt_matricula_alumno.Text,lbl_nombre_alumno,lbl_apellidos_alumno,lbl_estatus_alumno,lbl_semestre,lbl_carrera,ref imagen);
            string path = imagen;
            if (imagen == "")
            {
                picture_alumno.Image = null;
            }
            else
            {
                try
                {
                    var request = WebRequest.Create(path);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        picture_alumno.Image = Bitmap.FromStream(stream);
                        System.Drawing.Image img = picture_alumno.Image;
                        //img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        picture_alumno.Image = img;
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        private void buscar_libro()
        {
            obj_prestamos.buscar_datos_libro(txt_codigo_libro.Text, lbl_nombre_libro, lbl_codigo, lbl_cant, lbl_estatus);
        }


        private void dgv_prestamos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (dgv_prestamos.Rows.Count == 0)
                {

                }
                else
                {
                    obj_prestamos.tabla_pedido.Rows.RemoveAt(e.RowIndex);
                    dgv_prestamos.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void txt_matricula_alumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_codigo_libro.Focus();
                buscar_alumno();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_codigo_libro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscar_libro();
                añadir();

            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_matricula_alumno_TextChanged(object sender, EventArgs e)
        {
            buscar_alumno();
        }

        private void txt_codigo_libro_TextChanged(object sender, EventArgs e)
        {
            buscar_libro();
        }

        private void txt_cantidad_dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tamaño == true)
            {
                lbl_nombre_alumno.Font = new Font("Century Gothic", 12.0F, FontStyle.Regular); 
            }
            else if (tamaño == false)
            {
                lbl_nombre_alumno.Font = new Font("Century Gothic", 12.0F, FontStyle.Regular);
            }
        }

    }
}
