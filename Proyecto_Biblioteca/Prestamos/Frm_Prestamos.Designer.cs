
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnañadir = new System.Windows.Forms.Button();
            this.txt_cantidad_dias = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_codigo_libro = new System.Windows.Forms.TextBox();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.txt_matricula_alumno = new System.Windows.Forms.TextBox();
            this.lbl_libro = new System.Windows.Forms.Label();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_datos_libro = new System.Windows.Forms.Panel();
            this.picture_itn = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_nombre_libro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.panel_datos_alumno = new System.Windows.Forms.Panel();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_prestamos = new System.Windows.Forms.DataGridView();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_terminar_pedido = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_grid.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_datos_libro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_itn)).BeginInit();
            this.panel_datos_alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_alumno)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.txt_cantidad_dias);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.lbl_cantidad);
            this.panel5.Controls.Add(this.txt_codigo_libro);
            this.panel5.Controls.Add(this.lbl_alumno);
            this.panel5.Controls.Add(this.txt_matricula_alumno);
            this.panel5.Controls.Add(this.lbl_libro);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(361, 328);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 243);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(361, 85);
            this.panel6.TabIndex = 60;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_terminar_pedido, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnañadir, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(361, 85);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnañadir
            // 
            this.btnañadir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnañadir.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.btnañadir.Location = new System.Drawing.Point(3, 2);
            this.btnañadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(174, 44);
            this.btnañadir.TabIndex = 6;
            this.btnañadir.Text = "Añadir";
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // txt_cantidad_dias
            // 
            this.txt_cantidad_dias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad_dias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantidad_dias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad_dias.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_dias.Location = new System.Drawing.Point(17, 199);
            this.txt_cantidad_dias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cantidad_dias.Name = "txt_cantidad_dias";
            this.txt_cantidad_dias.Size = new System.Drawing.Size(306, 21);
            this.txt_cantidad_dias.TabIndex = 3;
            this.txt_cantidad_dias.Text = "1";
            this.txt_cantidad_dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_dias_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(17, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 1);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(17, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 1);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(13, 154);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 1);
            this.panel3.TabIndex = 20;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(12, 170);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(183, 23);
            this.lbl_cantidad.TabIndex = 19;
            this.lbl_cantidad.Text = "Dias de prestamo";
            // 
            // txt_codigo_libro
            // 
            this.txt_codigo_libro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_codigo_libro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo_libro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo_libro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_libro.Location = new System.Drawing.Point(19, 126);
            this.txt_codigo_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigo_libro.Name = "txt_codigo_libro";
            this.txt_codigo_libro.Size = new System.Drawing.Size(306, 21);
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
            this.lbl_alumno.Location = new System.Drawing.Point(12, 16);
            this.lbl_alumno.Name = "lbl_alumno";
            this.lbl_alumno.Size = new System.Drawing.Size(220, 23);
            this.lbl_alumno.TabIndex = 17;
            this.lbl_alumno.Text = "Matricula del alumno";
            // 
            // txt_matricula_alumno
            // 
            this.txt_matricula_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_matricula_alumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula_alumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matricula_alumno.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricula_alumno.Location = new System.Drawing.Point(19, 50);
            this.txt_matricula_alumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matricula_alumno.Name = "txt_matricula_alumno";
            this.txt_matricula_alumno.Size = new System.Drawing.Size(306, 21);
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
            this.lbl_libro.Location = new System.Drawing.Point(12, 92);
            this.lbl_libro.Name = "lbl_libro";
            this.lbl_libro.Size = new System.Drawing.Size(167, 23);
            this.lbl_libro.TabIndex = 15;
            this.lbl_libro.Text = "Codigo del libro";
            // 
            // panel_grid
            // 
            this.panel_grid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_grid.Controls.Add(this.tableLayoutPanel1);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_grid.Location = new System.Drawing.Point(0, 0);
            this.panel_grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(1187, 334);
            this.panel_grid.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.03555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.4805F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.48395F));
            this.tableLayoutPanel1.Controls.Add(this.panel_datos_libro, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_datos_alumno, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1187, 334);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_datos_libro
            // 
            this.panel_datos_libro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_datos_libro.Controls.Add(this.picture_itn);
            this.panel_datos_libro.Controls.Add(this.label9);
            this.panel_datos_libro.Controls.Add(this.label8);
            this.panel_datos_libro.Controls.Add(this.lbl_nombre_libro);
            this.panel_datos_libro.Controls.Add(this.label7);
            this.panel_datos_libro.Controls.Add(this.lbl_cant);
            this.panel_datos_libro.Controls.Add(this.label6);
            this.panel_datos_libro.Controls.Add(this.lbl_codigo);
            this.panel_datos_libro.Controls.Add(this.lbl_estatus);
            this.panel_datos_libro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_datos_libro.Location = new System.Drawing.Point(780, 3);
            this.panel_datos_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_datos_libro.Name = "panel_datos_libro";
            this.panel_datos_libro.Size = new System.Drawing.Size(403, 328);
            this.panel_datos_libro.TabIndex = 57;
            // 
            // picture_itn
            // 
            this.picture_itn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture_itn.Image = global::Proyecto_Biblioteca.Properties.Resources.itn1;
            this.picture_itn.Location = new System.Drawing.Point(142, 8);
            this.picture_itn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_itn.Name = "picture_itn";
            this.picture_itn.Size = new System.Drawing.Size(125, 114);
            this.picture_itn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_itn.TabIndex = 31;
            this.picture_itn.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(15, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 62;
            this.label9.Text = "Estatus:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(15, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 61;
            this.label8.Text = "Cantidad:";
            // 
            // lbl_nombre_libro
            // 
            this.lbl_nombre_libro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombre_libro.AutoSize = true;
            this.lbl_nombre_libro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_libro.Location = new System.Drawing.Point(136, 130);
            this.lbl_nombre_libro.Name = "lbl_nombre_libro";
            this.lbl_nombre_libro.Size = new System.Drawing.Size(141, 23);
            this.lbl_nombre_libro.TabIndex = 55;
            this.lbl_nombre_libro.Text = "Nombre Libro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(15, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 60;
            this.label7.Text = "Codigo:";
            // 
            // lbl_cant
            // 
            this.lbl_cant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant.Location = new System.Drawing.Point(136, 207);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(192, 23);
            this.lbl_cant.TabIndex = 56;
            this.lbl_cant.Text = "Cantidad de libros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(15, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 59;
            this.label6.Text = "Nombre:";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(136, 169);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(167, 23);
            this.lbl_codigo.TabIndex = 57;
            this.lbl_codigo.Text = "Codigo del libro";
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus.Location = new System.Drawing.Point(136, 241);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(77, 23);
            this.lbl_estatus.TabIndex = 58;
            this.lbl_estatus.Text = "Estatus";
            // 
            // panel_datos_alumno
            // 
            this.panel_datos_alumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_datos_alumno.Controls.Add(this.picture_alumno);
            this.panel_datos_alumno.Controls.Add(this.lbl_nombre_alumno);
            this.panel_datos_alumno.Controls.Add(this.lbl_apellidos_alumno);
            this.panel_datos_alumno.Controls.Add(this.lbl_semestre);
            this.panel_datos_alumno.Controls.Add(this.label5);
            this.panel_datos_alumno.Controls.Add(this.lbl_carrera);
            this.panel_datos_alumno.Controls.Add(this.lbl_estatus_alumno);
            this.panel_datos_alumno.Controls.Add(this.label1);
            this.panel_datos_alumno.Controls.Add(this.label4);
            this.panel_datos_alumno.Controls.Add(this.label2);
            this.panel_datos_alumno.Controls.Add(this.label3);
            this.panel_datos_alumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_datos_alumno.Location = new System.Drawing.Point(372, 3);
            this.panel_datos_alumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_datos_alumno.Name = "panel_datos_alumno";
            this.panel_datos_alumno.Size = new System.Drawing.Size(401, 328);
            this.panel_datos_alumno.TabIndex = 52;
            // 
            // picture_alumno
            // 
            this.picture_alumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture_alumno.Location = new System.Drawing.Point(137, 8);
            this.picture_alumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_alumno.Name = "picture_alumno";
            this.picture_alumno.Size = new System.Drawing.Size(125, 114);
            this.picture_alumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_alumno.TabIndex = 30;
            this.picture_alumno.TabStop = false;
            // 
            // lbl_nombre_alumno
            // 
            this.lbl_nombre_alumno.AutoSize = true;
            this.lbl_nombre_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_alumno.Location = new System.Drawing.Point(116, 130);
            this.lbl_nombre_alumno.Name = "lbl_nombre_alumno";
            this.lbl_nombre_alumno.Size = new System.Drawing.Size(172, 23);
            this.lbl_nombre_alumno.TabIndex = 50;
            this.lbl_nombre_alumno.Text = "Nombre Alumno";
            // 
            // lbl_apellidos_alumno
            // 
            this.lbl_apellidos_alumno.AutoSize = true;
            this.lbl_apellidos_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos_alumno.Location = new System.Drawing.Point(116, 169);
            this.lbl_apellidos_alumno.Name = "lbl_apellidos_alumno";
            this.lbl_apellidos_alumno.Size = new System.Drawing.Size(182, 23);
            this.lbl_apellidos_alumno.TabIndex = 51;
            this.lbl_apellidos_alumno.Text = "Apellidos Alumno";
            // 
            // lbl_semestre
            // 
            this.lbl_semestre.AutoSize = true;
            this.lbl_semestre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semestre.Location = new System.Drawing.Point(115, 241);
            this.lbl_semestre.Name = "lbl_semestre";
            this.lbl_semestre.Size = new System.Drawing.Size(99, 23);
            this.lbl_semestre.TabIndex = 52;
            this.lbl_semestre.Text = "Semestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(5, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 59;
            this.label5.Text = "Estatus:";
            // 
            // lbl_carrera
            // 
            this.lbl_carrera.AutoSize = true;
            this.lbl_carrera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carrera.Location = new System.Drawing.Point(116, 207);
            this.lbl_carrera.Name = "lbl_carrera";
            this.lbl_carrera.Size = new System.Drawing.Size(85, 23);
            this.lbl_carrera.TabIndex = 53;
            this.lbl_carrera.Text = "Carrera";
            // 
            // lbl_estatus_alumno
            // 
            this.lbl_estatus_alumno.AutoSize = true;
            this.lbl_estatus_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus_alumno.Location = new System.Drawing.Point(116, 279);
            this.lbl_estatus_alumno.Name = "lbl_estatus_alumno";
            this.lbl_estatus_alumno.Size = new System.Drawing.Size(77, 23);
            this.lbl_estatus_alumno.TabIndex = 58;
            this.lbl_estatus_alumno.Text = "Estatus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(5, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(5, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "Semestre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(3, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(5, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Carrera:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_prestamos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 334);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1187, 242);
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
            this.dgv_prestamos.Size = new System.Drawing.Size(1187, 242);
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
            // btn_terminar_pedido
            // 
            this.btn_terminar_pedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_terminar_pedido.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.btn_terminar_pedido.Location = new System.Drawing.Point(183, 2);
            this.btn_terminar_pedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_terminar_pedido.Name = "btn_terminar_pedido";
            this.btn_terminar_pedido.Size = new System.Drawing.Size(175, 44);
            this.btn_terminar_pedido.TabIndex = 8;
            this.btn_terminar_pedido.Text = "Terminar";
            this.btn_terminar_pedido.UseVisualStyleBackColor = true;
            this.btn_terminar_pedido.Click += new System.EventHandler(this.btn_terminar_pedido_Click);
            // 
            // Frm_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 576);
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
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_grid.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_datos_libro.ResumeLayout(false);
            this.panel_datos_libro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_itn)).EndInit();
            this.panel_datos_alumno.ResumeLayout(false);
            this.panel_datos_alumno.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.PictureBox picture_alumno;
        public System.Windows.Forms.Label lbl_alumno;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picture_itn;
        private System.Windows.Forms.Panel panel_datos_libro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_estatus;
        private System.Windows.Forms.Label lbl_nombre_libro;
        private System.Windows.Forms.Panel panel_datos_alumno;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Button btn_terminar_pedido;
    }
}