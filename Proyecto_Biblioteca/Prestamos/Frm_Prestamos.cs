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
        public Frm_Prestamos()
        {
            InitializeComponent();
        }
        private void Frm_Prestamos_Load(object sender, EventArgs e)
        {

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
                    combo_cantidad_dias.Text = "";
                    dgv_prestamos.Rows.Clear();
                    obj_prestamos.tabla_pedido.Rows.Clear();
                }
            }
            else if (result == DialogResult.No)
            {
            }
        }
        private void btnañadir_Click(object sender, EventArgs e)
        {
            añadir();
        }
        private void añadir()
        {
            if (string.IsNullOrEmpty(txt_codigo_libro.Text) || string.IsNullOrEmpty(txt_matricula_alumno.Text))
            {
                MessageBox.Show("Completa los datos correctamente");
            }
            else
            {
                obj_prestamos.dias = Convert.ToInt32(combo_cantidad_dias.Text);
                obj_prestamos.completar_tabla(dgv_prestamos,txt_matricula_alumno.Text,txt_codigo_libro.Text);
                txt_codigo_libro.Text = "";
            }
        }
        private void dgv_prestamos_CellClick(object sender, DataGridViewCellEventArgs e)
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
        private void combo_cantidad_dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_codigo_libro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                añadir();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_nombre_alumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_codigo_libro.Focus();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_imagen_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Cls_Alumnos alum = new Cls_Alumnos();
            alum.leer_ruta(dt, txt_matricula_alumno.Text);

            string path = dt.Rows[0][6].ToString();
            var request = WebRequest.Create(path);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                picture_alumno.Image = Bitmap.FromStream(stream);
                System.Drawing.Image img = picture_alumno.Image;
                //img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                picture_alumno.Image = img;
            }

            MessageBox.Show(dt.Rows[0][6].ToString());
        }
    }
}
