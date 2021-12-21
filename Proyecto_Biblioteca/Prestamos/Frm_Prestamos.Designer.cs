
namespace Proyecto_Biblioteca
{
    partial class Frm_Prestamos
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
            this.components = new System.ComponentModel.Container();
            this.lbl_datos_libro = new System.Windows.Forms.Label();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.lbl_nombre_libro = new System.Windows.Forms.Label();
            this.lbl_carrera = new System.Windows.Forms.Label();
            this.lbl_semestre = new System.Windows.Forms.Label();
            this.lbl_estatus_alumno = new System.Windows.Forms.Label();
            this.lbl_apellidos_alumno = new System.Windows.Forms.Label();
            this.lbl_nombre_alumno = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_libro = new System.Windows.Forms.Label();
            this.txt_matricula_alumno = new System.Windows.Forms.TextBox();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.txt_codigo_libro = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.btn_terminar_pedido = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnañadir = new System.Windows.Forms.Button();
            this.txt_cantidad_dias = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.picture_alumno = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel_agragar = new System.Windows.Forms.Panel();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_prestamos = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_alumno)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel_grid.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_datos_libro
            // 
            this.lbl_datos_libro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_datos_libro.AutoSize = true;
            this.lbl_datos_libro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datos_libro.Location = new System.Drawing.Point(491, 37);
            this.lbl_datos_libro.Name = "lbl_datos_libro";
            this.lbl_datos_libro.Size = new System.Drawing.Size(152, 23);
            this.lbl_datos_libro.TabIndex = 42;
            this.lbl_datos_libro.Text = "Datos del libro";
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus.Location = new System.Drawing.Point(643, 135);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(77, 23);
            this.lbl_estatus.TabIndex = 41;
            this.lbl_estatus.Text = "Estatus";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(417, 180);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(167, 23);
            this.lbl_codigo.TabIndex = 40;
            this.lbl_codigo.Text = "Codigo del libro";
            // 
            // lbl_cant
            // 
            this.lbl_cant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant.Location = new System.Drawing.Point(417, 231);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(192, 23);
            this.lbl_cant.TabIndex = 39;
            this.lbl_cant.Text = "Cantidad de libros";
            // 
            // lbl_nombre_libro
            // 
            this.lbl_nombre_libro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombre_libro.AutoSize = true;
            this.lbl_nombre_libro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_libro.Location = new System.Drawing.Point(417, 135);
            this.lbl_nombre_libro.Name = "lbl_nombre_libro";
            this.lbl_nombre_libro.Size = new System.Drawing.Size(141, 23);
            this.lbl_nombre_libro.TabIndex = 37;
            this.lbl_nombre_libro.Text = "Nombre Libro";
            // 
            // lbl_carrera
            // 
            this.lbl_carrera.AutoSize = true;
            this.lbl_carrera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carrera.Location = new System.Drawing.Point(207, 183);
            this.lbl_carrera.Name = "lbl_carrera";
            this.lbl_carrera.Size = new System.Drawing.Size(85, 23);
            this.lbl_carrera.TabIndex = 35;
            this.lbl_carrera.Text = "Carrera";
            // 
            // lbl_semestre
            // 
            this.lbl_semestre.AutoSize = true;
            this.lbl_semestre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semestre.Location = new System.Drawing.Point(207, 135);
            this.lbl_semestre.Name = "lbl_semestre";
            this.lbl_semestre.Size = new System.Drawing.Size(99, 23);
            this.lbl_semestre.TabIndex = 34;
            this.lbl_semestre.Text = "Semestre";
            // 
            // lbl_estatus_alumno
            // 
            this.lbl_estatus_alumno.AutoSize = true;
            this.lbl_estatus_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus_alumno.Location = new System.Drawing.Point(13, 231);
            this.lbl_estatus_alumno.Name = "lbl_estatus_alumno";
            this.lbl_estatus_alumno.Size = new System.Drawing.Size(77, 23);
            this.lbl_estatus_alumno.TabIndex = 33;
            this.lbl_estatus_alumno.Text = "Estatus";
            // 
            // lbl_apellidos_alumno
            // 
            this.lbl_apellidos_alumno.AutoSize = true;
            this.lbl_apellidos_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos_alumno.Location = new System.Drawing.Point(13, 180);
            this.lbl_apellidos_alumno.Name = "lbl_apellidos_alumno";
            this.lbl_apellidos_alumno.Size = new System.Drawing.Size(182, 23);
            this.lbl_apellidos_alumno.TabIndex = 32;
            this.lbl_apellidos_alumno.Text = "Apellidos Alumno";
            // 
            // lbl_nombre_alumno
            // 
            this.lbl_nombre_alumno.AutoSize = true;
            this.lbl_nombre_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_alumno.Location = new System.Drawing.Point(11, 135);
            this.lbl_nombre_alumno.Name = "lbl_nombre_alumno";
            this.lbl_nombre_alumno.Size = new System.Drawing.Size(172, 23);
            this.lbl_nombre_alumno.TabIndex = 31;
            this.lbl_nombre_alumno.Text = "Nombre Alumno";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txt_cantidad_dias);
            this.panel5.Controls.Add(this.btnañadir);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.btn_terminar_pedido);
            this.panel5.Controls.Add(this.lbl_cantidad);
            this.panel5.Controls.Add(this.txt_codigo_libro);
            this.panel5.Controls.Add(this.lbl_alumno);
            this.panel5.Controls.Add(this.txt_matricula_alumno);
            this.panel5.Controls.Add(this.lbl_libro);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 300);
            this.panel5.TabIndex = 12;
            // 
            // lbl_libro
            // 
            this.lbl_libro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_libro.AutoSize = true;
            this.lbl_libro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_libro.Location = new System.Drawing.Point(3, 80);
            this.lbl_libro.Name = "lbl_libro";
            this.lbl_libro.Size = new System.Drawing.Size(167, 23);
            this.lbl_libro.TabIndex = 15;
            this.lbl_libro.Text = "Codigo del libro";
            // 
            // txt_matricula_alumno
            // 
            this.txt_matricula_alumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula_alumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matricula_alumno.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricula_alumno.Location = new System.Drawing.Point(9, 39);
            this.txt_matricula_alumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matricula_alumno.Name = "txt_matricula_alumno";
            this.txt_matricula_alumno.Size = new System.Drawing.Size(237, 21);
            this.txt_matricula_alumno.TabIndex = 1;
            this.txt_matricula_alumno.TextChanged += new System.EventHandler(this.txt_matricula_alumno_TextChanged);
            this.txt_matricula_alumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_matricula_alumno_KeyPress);
            // 
            // lbl_alumno
            // 
            this.lbl_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_alumno.AutoSize = true;
            this.lbl_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alumno.Location = new System.Drawing.Point(3, 4);
            this.lbl_alumno.Name = "lbl_alumno";
            this.lbl_alumno.Size = new System.Drawing.Size(220, 23);
            this.lbl_alumno.TabIndex = 17;
            this.lbl_alumno.Text = "Matricula del alumno";
            // 
            // txt_codigo_libro
            // 
            this.txt_codigo_libro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo_libro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo_libro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_libro.Location = new System.Drawing.Point(9, 114);
            this.txt_codigo_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigo_libro.Name = "txt_codigo_libro";
            this.txt_codigo_libro.Size = new System.Drawing.Size(237, 21);
            this.txt_codigo_libro.TabIndex = 2;
            this.txt_codigo_libro.TextChanged += new System.EventHandler(this.txt_codigo_libro_TextChanged);
            this.txt_codigo_libro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_libro_KeyPress_1);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(3, 158);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(183, 23);
            this.lbl_cantidad.TabIndex = 19;
            this.lbl_cantidad.Text = "Dias de prestamo";
            // 
            // btn_terminar_pedido
            // 
            this.btn_terminar_pedido.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.btn_terminar_pedido.Location = new System.Drawing.Point(120, 231);
            this.btn_terminar_pedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_terminar_pedido.Name = "btn_terminar_pedido";
            this.btn_terminar_pedido.Size = new System.Drawing.Size(109, 44);
            this.btn_terminar_pedido.TabIndex = 5;
            this.btn_terminar_pedido.Text = "Terminar";
            this.btn_terminar_pedido.UseVisualStyleBackColor = true;
            this.btn_terminar_pedido.Click += new System.EventHandler(this.btn_terminar_pedido_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(8, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 1);
            this.panel2.TabIndex = 22;
            // 
            // btnañadir
            // 
            this.btnañadir.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.btnañadir.Location = new System.Drawing.Point(5, 231);
            this.btnañadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(109, 44);
            this.btnañadir.TabIndex = 4;
            this.btnañadir.Text = "Añadir";
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click_1);
            // 
            // txt_cantidad_dias
            // 
            this.txt_cantidad_dias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantidad_dias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad_dias.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_dias.Location = new System.Drawing.Point(8, 188);
            this.txt_cantidad_dias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cantidad_dias.Name = "txt_cantidad_dias";
            this.txt_cantidad_dias.Size = new System.Drawing.Size(237, 21);
            this.txt_cantidad_dias.TabIndex = 3;
            this.txt_cantidad_dias.Text = "1";
            this.txt_cantidad_dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_dias_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(8, 213);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 1);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(5, 142);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 1);
            this.panel3.TabIndex = 20;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Modificar";
            this.dataGridViewImageColumn1.Image = global::Proyecto_Biblioteca.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // picture_alumno
            // 
            this.picture_alumno.Image = global::Proyecto_Biblioteca.Properties.Resources.avatardefault_92824;
            this.picture_alumno.Location = new System.Drawing.Point(15, 10);
            this.picture_alumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_alumno.Name = "picture_alumno";
            this.picture_alumno.Size = new System.Drawing.Size(127, 106);
            this.picture_alumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_alumno.TabIndex = 30;
            this.picture_alumno.TabStop = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Proyecto_Biblioteca.Properties.Resources.eliminar;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 298);
            this.splitter1.TabIndex = 28;
            this.splitter1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lbl_datos_libro);
            this.panel7.Controls.Add(this.lbl_estatus);
            this.panel7.Controls.Add(this.lbl_codigo);
            this.panel7.Controls.Add(this.lbl_cant);
            this.panel7.Controls.Add(this.lbl_nombre_libro);
            this.panel7.Controls.Add(this.lbl_carrera);
            this.panel7.Controls.Add(this.lbl_semestre);
            this.panel7.Controls.Add(this.lbl_estatus_alumno);
            this.panel7.Controls.Add(this.lbl_apellidos_alumno);
            this.panel7.Controls.Add(this.lbl_nombre_alumno);
            this.panel7.Controls.Add(this.picture_alumno);
            this.panel7.Controls.Add(this.splitter1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(269, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(795, 300);
            this.panel7.TabIndex = 14;
            // 
            // panel_agragar
            // 
            this.panel_agragar.Location = new System.Drawing.Point(285, 345);
            this.panel_agragar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_agragar.Name = "panel_agragar";
            this.panel_agragar.Size = new System.Drawing.Size(565, 334);
            this.panel_agragar.TabIndex = 2;
            // 
            // panel_grid
            // 
            this.panel_grid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_grid.Controls.Add(this.panel7);
            this.panel_grid.Controls.Add(this.panel5);
            this.panel_grid.Controls.Add(this.panel_agragar);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_grid.Location = new System.Drawing.Point(0, 0);
            this.panel_grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(1064, 300);
            this.panel_grid.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_prestamos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 300);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1064, 277);
            this.panel4.TabIndex = 2;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Proyecto_Biblioteca.Properties.Resources.eliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Devolucion
            // 
            this.Devolucion.HeaderText = "Devolucion";
            this.Devolucion.MinimumWidth = 6;
            this.Devolucion.Name = "Devolucion";
            this.Devolucion.ReadOnly = true;
            // 
            // Fecha_Salida
            // 
            this.Fecha_Salida.HeaderText = "Fecha de salida";
            this.Fecha_Salida.MinimumWidth = 6;
            this.Fecha_Salida.Name = "Fecha_Salida";
            this.Fecha_Salida.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.MinimumWidth = 6;
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            // 
            // dgv_prestamos
            // 
            this.dgv_prestamos.AllowUserToAddRows = false;
            this.dgv_prestamos.AllowUserToDeleteRows = false;
            this.dgv_prestamos.AllowUserToResizeColumns = false;
            this.dgv_prestamos.AllowUserToResizeRows = false;
            this.dgv_prestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_prestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libro,
            this.Cantidad,
            this.Fecha_Salida,
            this.Devolucion,
            this.Eliminar});
            this.dgv_prestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_prestamos.Location = new System.Drawing.Point(0, 0);
            this.dgv_prestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_prestamos.Name = "dgv_prestamos";
            this.dgv_prestamos.ReadOnly = true;
            this.dgv_prestamos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_prestamos.RowHeadersVisible = false;
            this.dgv_prestamos.RowHeadersWidth = 51;
            this.dgv_prestamos.RowTemplate.Height = 24;
            this.dgv_prestamos.Size = new System.Drawing.Size(1064, 277);
            this.dgv_prestamos.TabIndex = 1;
            this.dgv_prestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prestamos_CellClick_1);
            // 
            // Frm_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 577);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Prestamos";
            this.Opacity = 0.95D;
            this.Text = "Frm_Prestamos";
            this.Load += new System.EventHandler(this.Frm_Prestamos_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_alumno)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel_grid.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_estatus;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label lbl_nombre_libro;
        private System.Windows.Forms.Label lbl_carrera;
        private System.Windows.Forms.Label lbl_semestre;
        private System.Windows.Forms.Label lbl_estatus_alumno;
        private System.Windows.Forms.Label lbl_apellidos_alumno;
        private System.Windows.Forms.Label lbl_nombre_alumno;
        private System.Windows.Forms.PictureBox picture_alumno;
        private System.Windows.Forms.Label lbl_datos_libro;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_cantidad_dias;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_terminar_pedido;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_codigo_libro;
        private System.Windows.Forms.Label lbl_alumno;
        private System.Windows.Forms.TextBox txt_matricula_alumno;
        private System.Windows.Forms.Label lbl_libro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel_agragar;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_prestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devolucion;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}