
namespace Proyecto_Biblioteca.Libros
{
    partial class Frm_modificar_libro
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
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_cantidad_libros = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigo_libro = new System.Windows.Forms.TextBox();
            this.lbl_cantidad_libro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_estatus = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_año_edicion = new System.Windows.Forms.TextBox();
            this.lbl_año_edicion = new System.Windows.Forms.Label();
            this.lbl_numero_pag = new System.Windows.Forms.Label();
            this.txt_numero_pag = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_pais_autor = new System.Windows.Forms.TextBox();
            this.lbl_pais_autor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.btnmodificar.Location = new System.Drawing.Point(14, 339);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(171, 44);
            this.btnmodificar.TabIndex = 9;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.btn_cancelar.Location = new System.Drawing.Point(195, 339);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(171, 44);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.lbl_genero);
            this.groupBox1.Controls.Add(this.txt_genero);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.txt_autor);
            this.groupBox1.Controls.Add(this.lbl_autor);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txt_cantidad_libros);
            this.groupBox1.Controls.Add(this.lbl_codigo);
            this.groupBox1.Controls.Add(this.txt_codigo_libro);
            this.groupBox1.Controls.Add(this.lbl_cantidad_libro);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 415);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del libro";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(11, 123);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(325, 21);
            this.txt_nombre.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(11, 148);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 1);
            this.panel1.TabIndex = 67;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(6, 93);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(90, 23);
            this.lbl_nombre.TabIndex = 66;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_genero
            // 
            this.lbl_genero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.Location = new System.Drawing.Point(8, 317);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(84, 23);
            this.lbl_genero.TabIndex = 64;
            this.lbl_genero.Text = "Genero";
            // 
            // txt_genero
            // 
            this.txt_genero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_genero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_genero.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_genero.Location = new System.Drawing.Point(11, 351);
            this.txt_genero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(325, 21);
            this.txt_genero.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(11, 376);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 1);
            this.panel4.TabIndex = 63;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(8, 305);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 1);
            this.panel5.TabIndex = 62;
            // 
            // txt_autor
            // 
            this.txt_autor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_autor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_autor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_autor.Location = new System.Drawing.Point(12, 277);
            this.txt_autor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(325, 21);
            this.txt_autor.TabIndex = 3;
            // 
            // lbl_autor
            // 
            this.lbl_autor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_autor.Location = new System.Drawing.Point(6, 243);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(63, 23);
            this.lbl_autor.TabIndex = 61;
            this.lbl_autor.Text = "Autor";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(11, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 1);
            this.panel2.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(8, 228);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 1);
            this.panel3.TabIndex = 57;
            // 
            // txt_cantidad_libros
            // 
            this.txt_cantidad_libros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantidad_libros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad_libros.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_libros.Location = new System.Drawing.Point(12, 200);
            this.txt_cantidad_libros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cantidad_libros.Name = "txt_cantidad_libros";
            this.txt_cantidad_libros.Size = new System.Drawing.Size(325, 21);
            this.txt_cantidad_libros.TabIndex = 2;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(6, 18);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(167, 23);
            this.lbl_codigo.TabIndex = 56;
            this.lbl_codigo.Text = "Codigo del libro";
            // 
            // txt_codigo_libro
            // 
            this.txt_codigo_libro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo_libro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo_libro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_libro.Location = new System.Drawing.Point(12, 53);
            this.txt_codigo_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigo_libro.Name = "txt_codigo_libro";
            this.txt_codigo_libro.Size = new System.Drawing.Size(325, 21);
            this.txt_codigo_libro.TabIndex = 0;
            // 
            // lbl_cantidad_libro
            // 
            this.lbl_cantidad_libro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cantidad_libro.AutoSize = true;
            this.lbl_cantidad_libro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_libro.Location = new System.Drawing.Point(6, 166);
            this.lbl_cantidad_libro.Name = "lbl_cantidad_libro";
            this.lbl_cantidad_libro.Size = new System.Drawing.Size(192, 23);
            this.lbl_cantidad_libro.TabIndex = 55;
            this.lbl_cantidad_libro.Text = "Cantidad de libros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_estatus);
            this.groupBox2.Controls.Add(this.btn_cancelar);
            this.groupBox2.Controls.Add(this.btnmodificar);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.lbl_estatus);
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.txt_año_edicion);
            this.groupBox2.Controls.Add(this.lbl_año_edicion);
            this.groupBox2.Controls.Add(this.lbl_numero_pag);
            this.groupBox2.Controls.Add(this.txt_numero_pag);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.txt_pais_autor);
            this.groupBox2.Controls.Add(this.lbl_pais_autor);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(376, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 415);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            // 
            // combo_estatus
            // 
            this.combo_estatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_estatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_estatus.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.combo_estatus.FormattingEnabled = true;
            this.combo_estatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.combo_estatus.Location = new System.Drawing.Point(9, 283);
            this.combo_estatus.Name = "combo_estatus";
            this.combo_estatus.Size = new System.Drawing.Size(335, 29);
            this.combo_estatus.TabIndex = 8;
            this.combo_estatus.Text = "Activo";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(9, 317);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(333, 1);
            this.panel8.TabIndex = 67;
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus.Location = new System.Drawing.Point(7, 255);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(77, 23);
            this.lbl_estatus.TabIndex = 66;
            this.lbl_estatus.Text = "Estatus";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(10, 233);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(333, 1);
            this.panel9.TabIndex = 65;
            // 
            // txt_año_edicion
            // 
            this.txt_año_edicion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_año_edicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_año_edicion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_año_edicion.Location = new System.Drawing.Point(14, 205);
            this.txt_año_edicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_año_edicion.Name = "txt_año_edicion";
            this.txt_año_edicion.Size = new System.Drawing.Size(325, 21);
            this.txt_año_edicion.TabIndex = 7;
            // 
            // lbl_año_edicion
            // 
            this.lbl_año_edicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_año_edicion.AutoSize = true;
            this.lbl_año_edicion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_año_edicion.Location = new System.Drawing.Point(8, 171);
            this.lbl_año_edicion.Name = "lbl_año_edicion";
            this.lbl_año_edicion.Size = new System.Drawing.Size(160, 23);
            this.lbl_año_edicion.TabIndex = 64;
            this.lbl_año_edicion.Text = "Año de edicion";
            // 
            // lbl_numero_pag
            // 
            this.lbl_numero_pag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_numero_pag.AutoSize = true;
            this.lbl_numero_pag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_pag.Location = new System.Drawing.Point(8, 92);
            this.lbl_numero_pag.Name = "lbl_numero_pag";
            this.lbl_numero_pag.Size = new System.Drawing.Size(205, 23);
            this.lbl_numero_pag.TabIndex = 62;
            this.lbl_numero_pag.Text = "Numero de paginas";
            // 
            // txt_numero_pag
            // 
            this.txt_numero_pag.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_numero_pag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numero_pag.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_pag.Location = new System.Drawing.Point(11, 126);
            this.txt_numero_pag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_numero_pag.Name = "txt_numero_pag";
            this.txt_numero_pag.Size = new System.Drawing.Size(325, 21);
            this.txt_numero_pag.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(11, 151);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(333, 1);
            this.panel6.TabIndex = 61;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(8, 80);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(333, 1);
            this.panel7.TabIndex = 60;
            // 
            // txt_pais_autor
            // 
            this.txt_pais_autor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pais_autor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pais_autor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pais_autor.Location = new System.Drawing.Point(12, 52);
            this.txt_pais_autor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pais_autor.Name = "txt_pais_autor";
            this.txt_pais_autor.Size = new System.Drawing.Size(325, 21);
            this.txt_pais_autor.TabIndex = 5;
            // 
            // lbl_pais_autor
            // 
            this.lbl_pais_autor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pais_autor.AutoSize = true;
            this.lbl_pais_autor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pais_autor.Location = new System.Drawing.Point(6, 18);
            this.lbl_pais_autor.Name = "lbl_pais_autor";
            this.lbl_pais_autor.Size = new System.Drawing.Size(143, 23);
            this.lbl_pais_autor.TabIndex = 59;
            this.lbl_pais_autor.Text = "Pais del autor";
            // 
            // Frm_modificar_libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(754, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Frm_modificar_libro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_genero;
        public System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txt_cantidad_libros;
        private System.Windows.Forms.Label lbl_codigo;
        public System.Windows.Forms.TextBox txt_codigo_libro;
        private System.Windows.Forms.Label lbl_cantidad_libro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_estatus;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.TextBox txt_año_edicion;
        private System.Windows.Forms.Label lbl_año_edicion;
        private System.Windows.Forms.Label lbl_numero_pag;
        public System.Windows.Forms.TextBox txt_numero_pag;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox txt_pais_autor;
        private System.Windows.Forms.Label lbl_pais_autor;
        public System.Windows.Forms.ComboBox combo_estatus;
    }
}