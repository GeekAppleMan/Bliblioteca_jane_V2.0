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
    public partial class Frm_Alumnos : Form
    {
        Cls_Alumnos obj_alumnos = new Cls_Alumnos();
        Alumnos.Frm_modificar_alumno obj_modificar = new Alumnos.Frm_modificar_alumno();
        public Frm_Alumnos()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            añadir();
        }

        private void Frm_Alumnos_Load(object sender, EventArgs e)
        {
            añadir();
        }

        private void añadir()
        {
            obj_alumnos.buscar(dgv_alumnos, txt_alumno.Text);
        }

        private void txt_alumno_TextChanged(object sender, EventArgs e)
        {
            añadir();
        }

        private void dgv_alumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 5 || e.ColumnIndex == 6) && e.RowIndex == -1)
            {

            }
            else
            {
                if (e.ColumnIndex == 5)
                {

                    obj_modificar.txt_matricula.Text = dgv_alumnos[0, e.RowIndex].Value.ToString();
                    obj_modificar.txt_nombres.Text = dgv_alumnos[1, e.RowIndex].Value.ToString();
                    obj_modificar.txt_apellidos.Text = dgv_alumnos[2, e.RowIndex].Value.ToString();
                    obj_modificar.txt_domicilio.Text = dgv_alumnos[3, e.RowIndex].Value.ToString();
                    obj_modificar.combo_estatus.Text = dgv_alumnos[4, e.RowIndex].Value.ToString();
                    Cls_Alumnos.index = e.RowIndex;
                    obj_modificar.ShowDialog();
                    añadir();
                }
                if (e.ColumnIndex == 6)
                {
                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el alumno?", "Confirmar", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Cls_Alumnos.index = e.RowIndex;
                        obj_alumnos.eliminar();
                        añadir();
                    }
                    else if (result == DialogResult.No)
                    {
                    }
                    else if (result == DialogResult.Cancel)
                    {
                    }
                }
            }
        }
    }
}
