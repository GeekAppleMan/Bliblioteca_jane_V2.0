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
        Proyecto_Biblioteca.Usuarios.Frm_modificar_usuario obj_modificar = new Proyecto_Biblioteca.Usuarios.Frm_modificar_usuario();
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

        private void dgv_usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 4 || e.ColumnIndex == 5) && e.RowIndex == -1)
            {

            }
            else
            {
                if (e.ColumnIndex == 4)
                {
                    
                    obj_modificar.txt_matricula.Text = dgv_usuario[0, e.RowIndex].Value.ToString();
                    obj_modificar.txt_usuario.Text = dgv_usuario[1, e.RowIndex].Value.ToString();
                    obj_modificar.txt_contraseña.Text = dgv_usuario[2, e.RowIndex].Value.ToString();
                    obj_modificar.combo_estatus.Text = dgv_usuario[3, e.RowIndex].Value.ToString();
                    Cls_usuarios.index = e.RowIndex;
                    obj_modificar.ShowDialog();
                    añadir();
                }
                if (e.ColumnIndex == 5)
                {
                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el usuario?", "Confirmar", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Cls_usuarios.index = e.RowIndex;
                        obj_usuarios.eliminar();
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
