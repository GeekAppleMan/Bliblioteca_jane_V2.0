using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca.Libros
{
    public partial class Frm_modificar_libro : Form
    {
        Cls_libros obj_libros = new Cls_libros();
        public Frm_modificar_libro()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string estatus = "";
            if (combo_estatus.Text == "Activo")
            {
                estatus = "1";
            }
            else if(combo_estatus.Text == "Inactivo")
            {
                estatus = "2";
            }
            obj_libros.modificar(txt_codigo_libro.Text, txt_nombre.Text, txt_cantidad_libros.Text, txt_autor.Text, txt_genero.Text, txt_pais_autor.Text, txt_numero_pag.Text, txt_año_edicion.Text,estatus);
        }
    }
}
