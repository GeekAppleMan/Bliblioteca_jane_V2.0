
namespace Proyecto_Biblioteca.Ratings
{
    partial class Frm_Ratings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_codigo_libro = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.dgv_libros = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_pag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año_edicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libros)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txt_codigo_libro);
            this.panel1.Controls.Add(this.lbl_codigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::Proyecto_Biblioteca.Properties.Resources.folder_saved_search_16890;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(598, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 47);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(315, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 1);
            this.panel3.TabIndex = 17;
            // 
            // txt_codigo_libro
            // 
            this.txt_codigo_libro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo_libro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo_libro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo_libro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_libro.Location = new System.Drawing.Point(317, 18);
            this.txt_codigo_libro.Name = "txt_codigo_libro";
            this.txt_codigo_libro.Size = new System.Drawing.Size(262, 21);
            this.txt_codigo_libro.TabIndex = 14;
            this.txt_codigo_libro.TextChanged += new System.EventHandler(this.txt_codigo_libro_TextChanged);
            this.txt_codigo_libro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_libro_KeyPress);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(127, 17);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(167, 23);
            this.lbl_codigo.TabIndex = 15;
            this.lbl_codigo.Text = "Codigo del libro";
            // 
            // dgv_libros
            // 
            this.dgv_libros.AllowUserToAddRows = false;
            this.dgv_libros.AllowUserToDeleteRows = false;
            this.dgv_libros.AllowUserToResizeColumns = false;
            this.dgv_libros.AllowUserToResizeRows = false;
            this.dgv_libros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_libros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_libros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Autor,
            this.Genero,
            this.Pais_autor,
            this.no_pag,
            this.Año_edicion,
            this.Estatus,
            this.Prestamos});
            this.dgv_libros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_libros.Location = new System.Drawing.Point(0, 0);
            this.dgv_libros.Name = "dgv_libros";
            this.dgv_libros.RowHeadersVisible = false;
            this.dgv_libros.RowHeadersWidth = 51;
            this.dgv_libros.RowTemplate.Height = 24;
            this.dgv_libros.Size = new System.Drawing.Size(800, 400);
            this.dgv_libros.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo del libro";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            // 
            // Pais_autor
            // 
            this.Pais_autor.HeaderText = "Pais del autor";
            this.Pais_autor.MinimumWidth = 6;
            this.Pais_autor.Name = "Pais_autor";
            // 
            // no_pag
            // 
            this.no_pag.HeaderText = "Numero de paginas";
            this.no_pag.MinimumWidth = 6;
            this.no_pag.Name = "no_pag";
            // 
            // Año_edicion
            // 
            this.Año_edicion.HeaderText = "Año de edicion";
            this.Año_edicion.MinimumWidth = 6;
            this.Año_edicion.Name = "Año_edicion";
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.MinimumWidth = 6;
            this.Estatus.Name = "Estatus";
            // 
            // Prestamos
            // 
            this.Prestamos.HeaderText = "Prestamos";
            this.Prestamos.MinimumWidth = 6;
            this.Prestamos.Name = "Prestamos";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Modificar";
            this.dataGridViewImageColumn1.Image = global::Proyecto_Biblioteca.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 72;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Proyecto_Biblioteca.Properties.Resources.eliminar1;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 73;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_libros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 400);
            this.panel2.TabIndex = 3;
            // 
            // Frm_Ratings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Ratings";
            this.Text = "Frm_Ratings";
            this.Load += new System.EventHandler(this.Frm_Ratings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_codigo_libro;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.DataGridView dgv_libros;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_pag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año_edicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamos;
    }
}