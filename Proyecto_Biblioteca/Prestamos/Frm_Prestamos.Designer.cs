
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_cantidad_dias = new System.Windows.Forms.TextBox();
            this.btnañadir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_terminar_pedido = new System.Windows.Forms.Button();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_codigo_libro = new System.Windows.Forms.TextBox();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.txt_matricula_alumno = new System.Windows.Forms.TextBox();
            this.lbl_libro = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picture_alumno = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_alumno = new System.Windows.Forms.Label();
            this.lbl_apellidos_alumno = new System.Windows.Forms.Label();
            this.lbl_semestre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_carrera = new System.Windows.Forms.Label();
            this.lbl_estatus_alumno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_datos_libro = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_nombre_libro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_prestamos = new System.Windows.Forms.DataGridView();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            this.panel_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_alumno)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
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
            this.panel5.Size = new System.Drawing.Size(269, 333);
            this.panel5.TabIndex = 12;
            // 
            // txt_cantidad_dias
            // 
            this.txt_cantidad_dias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantidad_dias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad_dias.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_dias.Location = new System.Drawing.Point(10, 200);
            this.txt_cantidad_dias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cantidad_dias.Name = "txt_cantidad_dias";
            this.txt_cantidad_dias.Size = new System.Drawing.Size(237, 21);
            this.txt_cantidad_dias.TabIndex = 3;
            this.txt_cantidad_dias.Text = "1";
            this.txt_cantidad_dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_dias_KeyPress);
            // 
            // btnañadir
            // 
            this.btnañadir.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.btnañadir.Location = new System.Drawing.Point(8, 252);
            this.btnañadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(122, 44);
            this.btnañadir.TabIndex = 4;
            this.btnañadir.Text = "Añadir";
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(10, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 1);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 1);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(7, 154);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 1);
            this.panel3.TabIndex = 20;
            // 
            // btn_terminar_pedido
            // 
            this.btn_terminar_pedido.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.btn_terminar_pedido.Location = new System.Drawing.Point(136, 252);
            this.btn_terminar_pedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_terminar_pedido.Name = "btn_terminar_pedido";
            this.btn_terminar_pedido.Size = new System.Drawing.Size(122, 44);
            this.btn_terminar_pedido.TabIndex = 5;
            this.btn_terminar_pedido.Text = "Terminar";
            this.btn_terminar_pedido.UseVisualStyleBackColor = true;
            this.btn_terminar_pedido.Click += new System.EventHandler(this.btn_terminar_pedido_Click_1);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(5, 170);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(183, 23);
            this.lbl_cantidad.TabIndex = 19;
            this.lbl_cantidad.Text = "Dias de prestamo";
            // 
            // txt_codigo_libro
            // 
            this.txt_codigo_libro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo_libro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo_libro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_libro.Location = new System.Drawing.Point(11, 126);
            this.txt_codigo_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigo_libro.Name = "txt_codigo_libro";
            this.txt_codigo_libro.Size = new System.Drawing.Size(237, 21);
            this.txt_codigo_libro.TabIndex = 2;
            this.txt_codigo_libro.TextChanged += new System.EventHandler(this.txt_codigo_libro_TextChanged);
            this.txt_codigo_libro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_libro_KeyPress_1);
            // 
            // lbl_alumno
            // 
            this.lbl_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_alumno.AutoSize = true;
            this.lbl_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alumno.Location = new System.Drawing.Point(5, 16);
            this.lbl_alumno.Name = "lbl_alumno";
            this.lbl_alumno.Size = new System.Drawing.Size(220, 23);
            this.lbl_alumno.TabIndex = 17;
            this.lbl_alumno.Text = "Matricula del alumno";
            // 
            // txt_matricula_alumno
            // 
            this.txt_matricula_alumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula_alumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matricula_alumno.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricula_alumno.Location = new System.Drawing.Point(11, 51);
            this.txt_matricula_alumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matricula_alumno.Name = "txt_matricula_alumno";
            this.txt_matricula_alumno.Size = new System.Drawing.Size(237, 21);
            this.txt_matricula_alumno.TabIndex = 1;
            this.txt_matricula_alumno.TextChanged += new System.EventHandler(this.txt_matricula_alumno_TextChanged);
            this.txt_matricula_alumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_matricula_alumno_KeyPress);
            // 
            // lbl_libro
            // 
            this.lbl_libro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_libro.AutoSize = true;
            this.lbl_libro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_libro.Location = new System.Drawing.Point(5, 92);
            this.lbl_libro.Name = "lbl_libro";
            this.lbl_libro.Size = new System.Drawing.Size(167, 23);
            this.lbl_libro.TabIndex = 15;
            this.lbl_libro.Text = "Codigo del libro";
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
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Proyecto_Biblioteca.Properties.Resources.eliminar;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // panel_grid
            // 
            this.panel_grid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_grid.Controls.Add(this.splitContainer1);
            this.panel_grid.Controls.Add(this.panel5);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_grid.Location = new System.Drawing.Point(0, 0);
            this.panel_grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(961, 333);
            this.panel_grid.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(269, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picture_alumno);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_nombre_alumno);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_apellidos_alumno);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_semestre);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_carrera);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_estatus_alumno);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_datos_libro);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_nombre_libro);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_cant);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_codigo);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_estatus);
            this.splitContainer1.Size = new System.Drawing.Size(692, 333);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 13;
            // 
            // picture_alumno
            // 
            this.picture_alumno.Image = global::Proyecto_Biblioteca.Properties.Resources.avatardefault_92824;
            this.picture_alumno.Location = new System.Drawing.Point(5, 2);
            this.picture_alumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_alumno.Name = "picture_alumno";
            this.picture_alumno.Size = new System.Drawing.Size(151, 135);
            this.picture_alumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_alumno.TabIndex = 30;
            this.picture_alumno.TabStop = false;
            // 
            // lbl_nombre_alumno
            // 
            this.lbl_nombre_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombre_alumno.AutoSize = true;
            this.lbl_nombre_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_alumno.Location = new System.Drawing.Point(123, 143);
            this.lbl_nombre_alumno.Name = "lbl_nombre_alumno";
            this.lbl_nombre_alumno.Size = new System.Drawing.Size(172, 23);
            this.lbl_nombre_alumno.TabIndex = 31;
            this.lbl_nombre_alumno.Text = "Nombre Alumno";
            // 
            // lbl_apellidos_alumno
            // 
            this.lbl_apellidos_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidos_alumno.AutoSize = true;
            this.lbl_apellidos_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos_alumno.Location = new System.Drawing.Point(123, 181);
            this.lbl_apellidos_alumno.Name = "lbl_apellidos_alumno";
            this.lbl_apellidos_alumno.Size = new System.Drawing.Size(182, 23);
            this.lbl_apellidos_alumno.TabIndex = 32;
            this.lbl_apellidos_alumno.Text = "Apellidos Alumno";
            // 
            // lbl_semestre
            // 
            this.lbl_semestre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_semestre.AutoSize = true;
            this.lbl_semestre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semestre.Location = new System.Drawing.Point(122, 253);
            this.lbl_semestre.Name = "lbl_semestre";
            this.lbl_semestre.Size = new System.Drawing.Size(99, 23);
            this.lbl_semestre.TabIndex = 34;
            this.lbl_semestre.Text = "Semestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(12, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "Estatus:";
            // 
            // lbl_carrera
            // 
            this.lbl_carrera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_carrera.AutoSize = true;
            this.lbl_carrera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carrera.Location = new System.Drawing.Point(123, 219);
            this.lbl_carrera.Name = "lbl_carrera";
            this.lbl_carrera.Size = new System.Drawing.Size(85, 23);
            this.lbl_carrera.TabIndex = 35;
            this.lbl_carrera.Text = "Carrera";
            // 
            // lbl_estatus_alumno
            // 
            this.lbl_estatus_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus_alumno.AutoSize = true;
            this.lbl_estatus_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus_alumno.Location = new System.Drawing.Point(123, 291);
            this.lbl_estatus_alumno.Name = "lbl_estatus_alumno";
            this.lbl_estatus_alumno.Size = new System.Drawing.Size(77, 23);
            this.lbl_estatus_alumno.TabIndex = 48;
            this.lbl_estatus_alumno.Text = "Estatus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Semestre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(10, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Carrera:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label10.Location = new System.Drawing.Point(110, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 23);
            this.label10.TabIndex = 54;
            this.label10.Text = "Datos del libro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(31, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 53;
            this.label9.Text = "Estatus:";
            // 
            // lbl_datos_libro
            // 
            this.lbl_datos_libro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_datos_libro.AutoSize = true;
            this.lbl_datos_libro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datos_libro.Location = new System.Drawing.Point(129, -107);
            this.lbl_datos_libro.Name = "lbl_datos_libro";
            this.lbl_datos_libro.Size = new System.Drawing.Size(152, 23);
            this.lbl_datos_libro.TabIndex = 42;
            this.lbl_datos_libro.Text = "Datos del libro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(31, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 52;
            this.label8.Text = "Cantidad:";
            // 
            // lbl_nombre_libro
            // 
            this.lbl_nombre_libro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombre_libro.AutoSize = true;
            this.lbl_nombre_libro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_libro.Location = new System.Drawing.Point(152, 143);
            this.lbl_nombre_libro.Name = "lbl_nombre_libro";
            this.lbl_nombre_libro.Size = new System.Drawing.Size(141, 23);
            this.lbl_nombre_libro.TabIndex = 37;
            this.lbl_nombre_libro.Text = "Nombre Libro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(31, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Codigo:";
            // 
            // lbl_cant
            // 
            this.lbl_cant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant.Location = new System.Drawing.Point(152, 219);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(192, 23);
            this.lbl_cant.TabIndex = 39;
            this.lbl_cant.Text = "Cantidad de libros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(31, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "Nombre:";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(152, 181);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(167, 23);
            this.lbl_codigo.TabIndex = 40;
            this.lbl_codigo.Text = "Codigo del libro";
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus.Location = new System.Drawing.Point(152, 253);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(77, 23);
            this.lbl_estatus.TabIndex = 41;
            this.lbl_estatus.Text = "Estatus";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_prestamos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 333);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(961, 244);
            this.panel4.TabIndex = 2;
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
            this.dgv_prestamos.Size = new System.Drawing.Size(961, 244);
            this.dgv_prestamos.TabIndex = 1;
            this.dgv_prestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prestamos_CellClick_1);
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.MinimumWidth = 6;
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Fecha_Salida
            // 
            this.Fecha_Salida.HeaderText = "Fecha de salida";
            this.Fecha_Salida.MinimumWidth = 6;
            this.Fecha_Salida.Name = "Fecha_Salida";
            this.Fecha_Salida.ReadOnly = true;
            // 
            // Devolucion
            // 
            this.Devolucion.HeaderText = "Devolucion";
            this.Devolucion.MinimumWidth = 6;
            this.Devolucion.Name = "Devolucion";
            this.Devolucion.ReadOnly = true;
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
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Frm_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 577);
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
            this.panel_grid.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_alumno)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_cantidad_dias;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_terminar_pedido;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_codigo_libro;
        private System.Windows.Forms.TextBox txt_matricula_alumno;
        private System.Windows.Forms.Label lbl_libro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_prestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devolucion;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picture_alumno;
        private System.Windows.Forms.Label lbl_nombre_alumno;
        private System.Windows.Forms.Label lbl_apellidos_alumno;
        private System.Windows.Forms.Label lbl_semestre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_carrera;
        private System.Windows.Forms.Label lbl_estatus_alumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_datos_libro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_nombre_libro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_estatus;
        public System.Windows.Forms.Label lbl_alumno;
        private System.Windows.Forms.Timer timer2;
    }
}