
namespace Proyecto_Biblioteca
{
    partial class Frm_main
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
            this.panel_barra_izquierda = new System.Windows.Forms.Panel();
            this.btn_cerrar_sesion = new System.Windows.Forms.Button();
            this.btn_rating = new System.Windows.Forms.Button();
            this.btn_devolucion = new System.Windows.Forms.Button();
            this.btn_historial_prestamos = new System.Windows.Forms.Button();
            this.btnlibros = new System.Windows.Forms.Button();
            this.btnalumnos = new System.Windows.Forms.Button();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.btnprestamos = new System.Windows.Forms.Button();
            this.pic_menu = new System.Windows.Forms.PictureBox();
            this.lbl_jane = new System.Windows.Forms.Label();
            this.panel_barra_titulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pic_fecha = new System.Windows.Forms.PictureBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.pic_hora = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_barra_izquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).BeginInit();
            this.panel_barra_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hora)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_barra_izquierda
            // 
            this.panel_barra_izquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_barra_izquierda.Controls.Add(this.btn_cerrar_sesion);
            this.panel_barra_izquierda.Controls.Add(this.btn_rating);
            this.panel_barra_izquierda.Controls.Add(this.btn_devolucion);
            this.panel_barra_izquierda.Controls.Add(this.btn_historial_prestamos);
            this.panel_barra_izquierda.Controls.Add(this.btnlibros);
            this.panel_barra_izquierda.Controls.Add(this.btnalumnos);
            this.panel_barra_izquierda.Controls.Add(this.btnusuarios);
            this.panel_barra_izquierda.Controls.Add(this.btnprestamos);
            this.panel_barra_izquierda.Controls.Add(this.pic_menu);
            this.panel_barra_izquierda.Controls.Add(this.lbl_jane);
            this.panel_barra_izquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_barra_izquierda.Location = new System.Drawing.Point(0, 0);
            this.panel_barra_izquierda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_barra_izquierda.Name = "panel_barra_izquierda";
            this.panel_barra_izquierda.Size = new System.Drawing.Size(200, 627);
            this.panel_barra_izquierda.TabIndex = 0;
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cerrar_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_sesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cerrar_sesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_sesion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_sesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_cerrar_sesion.Image = global::Proyecto_Biblioteca.Properties.Resources.salida;
            this.btn_cerrar_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(0, 580);
            this.btn_cerrar_sesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(200, 47);
            this.btn_cerrar_sesion.TabIndex = 8;
            this.btn_cerrar_sesion.Text = "      Cerrar sesion";
            this.btn_cerrar_sesion.UseVisualStyleBackColor = false;
            this.btn_cerrar_sesion.Click += new System.EventHandler(this.btn_cerrar_sesion_Click);
            // 
            // btn_rating
            // 
            this.btn_rating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_rating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rating.FlatAppearance.BorderSize = 0;
            this.btn_rating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rating.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rating.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_rating.Image = global::Proyecto_Biblioteca.Properties.Resources.analitica_de_datos__1_;
            this.btn_rating.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rating.Location = new System.Drawing.Point(3, 379);
            this.btn_rating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rating.Name = "btn_rating";
            this.btn_rating.Size = new System.Drawing.Size(192, 47);
            this.btn_rating.TabIndex = 5;
            this.btn_rating.Text = "Ratings";
            this.btn_rating.UseVisualStyleBackColor = false;
            this.btn_rating.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_devolucion
            // 
            this.btn_devolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_devolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_devolucion.FlatAppearance.BorderSize = 0;
            this.btn_devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_devolucion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolucion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_devolucion.Image = global::Proyecto_Biblioteca.Properties.Resources.carpeta;
            this.btn_devolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_devolucion.Location = new System.Drawing.Point(3, 277);
            this.btn_devolucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_devolucion.Name = "btn_devolucion";
            this.btn_devolucion.Size = new System.Drawing.Size(192, 47);
            this.btn_devolucion.TabIndex = 3;
            this.btn_devolucion.Text = "      Devolucion";
            this.btn_devolucion.UseVisualStyleBackColor = false;
            this.btn_devolucion.Click += new System.EventHandler(this.btn_devolucion_Click);
            // 
            // btn_historial_prestamos
            // 
            this.btn_historial_prestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_historial_prestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_historial_prestamos.FlatAppearance.BorderSize = 0;
            this.btn_historial_prestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historial_prestamos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historial_prestamos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_historial_prestamos.Image = global::Proyecto_Biblioteca.Properties.Resources.carpeta;
            this.btn_historial_prestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_historial_prestamos.Location = new System.Drawing.Point(3, 226);
            this.btn_historial_prestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_historial_prestamos.Name = "btn_historial_prestamos";
            this.btn_historial_prestamos.Size = new System.Drawing.Size(192, 47);
            this.btn_historial_prestamos.TabIndex = 2;
            this.btn_historial_prestamos.Text = "  Historial";
            this.btn_historial_prestamos.UseVisualStyleBackColor = false;
            this.btn_historial_prestamos.Click += new System.EventHandler(this.btn_historial_prestamos_Click);
            // 
            // btnlibros
            // 
            this.btnlibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnlibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlibros.FlatAppearance.BorderSize = 0;
            this.btnlibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlibros.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlibros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlibros.Image = global::Proyecto_Biblioteca.Properties.Resources.carpeta;
            this.btnlibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlibros.Location = new System.Drawing.Point(3, 328);
            this.btnlibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlibros.Name = "btnlibros";
            this.btnlibros.Size = new System.Drawing.Size(192, 47);
            this.btnlibros.TabIndex = 4;
            this.btnlibros.Text = "Libros";
            this.btnlibros.UseVisualStyleBackColor = false;
            this.btnlibros.Click += new System.EventHandler(this.btnlibros_Click);
            // 
            // btnalumnos
            // 
            this.btnalumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnalumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalumnos.FlatAppearance.BorderSize = 0;
            this.btnalumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalumnos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalumnos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnalumnos.Image = global::Proyecto_Biblioteca.Properties.Resources.usuario;
            this.btnalumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalumnos.Location = new System.Drawing.Point(3, 481);
            this.btnalumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnalumnos.Name = "btnalumnos";
            this.btnalumnos.Size = new System.Drawing.Size(192, 47);
            this.btnalumnos.TabIndex = 7;
            this.btnalumnos.Text = "Alumnos";
            this.btnalumnos.UseVisualStyleBackColor = false;
            this.btnalumnos.Click += new System.EventHandler(this.btnalumnos_Click);
            // 
            // btnusuarios
            // 
            this.btnusuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnusuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnusuarios.FlatAppearance.BorderSize = 0;
            this.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuarios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnusuarios.Image = global::Proyecto_Biblioteca.Properties.Resources.usuario;
            this.btnusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuarios.Location = new System.Drawing.Point(3, 430);
            this.btnusuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(192, 47);
            this.btnusuarios.TabIndex = 6;
            this.btnusuarios.Text = "Usuarios";
            this.btnusuarios.UseVisualStyleBackColor = false;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // btnprestamos
            // 
            this.btnprestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnprestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprestamos.FlatAppearance.BorderSize = 0;
            this.btnprestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprestamos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprestamos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnprestamos.Image = global::Proyecto_Biblioteca.Properties.Resources.documento__1_;
            this.btnprestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprestamos.Location = new System.Drawing.Point(3, 175);
            this.btnprestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprestamos.Name = "btnprestamos";
            this.btnprestamos.Size = new System.Drawing.Size(192, 47);
            this.btnprestamos.TabIndex = 1;
            this.btnprestamos.Text = "     Prestamos";
            this.btnprestamos.UseVisualStyleBackColor = false;
            this.btnprestamos.Click += new System.EventHandler(this.btnprestamos_Click);
            // 
            // pic_menu
            // 
            this.pic_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_menu.Image = global::Proyecto_Biblioteca.Properties.Resources.menu__7_;
            this.pic_menu.Location = new System.Drawing.Point(5, 12);
            this.pic_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_menu.Name = "pic_menu";
            this.pic_menu.Size = new System.Drawing.Size(51, 50);
            this.pic_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_menu.TabIndex = 1;
            this.pic_menu.TabStop = false;
            this.pic_menu.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl_jane
            // 
            this.lbl_jane.AutoSize = true;
            this.lbl_jane.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jane.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_jane.Location = new System.Drawing.Point(12, 91);
            this.lbl_jane.Name = "lbl_jane";
            this.lbl_jane.Size = new System.Drawing.Size(167, 25);
            this.lbl_jane.TabIndex = 0;
            this.lbl_jane.Text = "Jane Software";
            // 
            // panel_barra_titulo
            // 
            this.panel_barra_titulo.Controls.Add(this.lbltitulo);
            this.panel_barra_titulo.Controls.Add(this.pic_fecha);
            this.panel_barra_titulo.Controls.Add(this.lbl_fecha);
            this.panel_barra_titulo.Controls.Add(this.lbl_hora);
            this.panel_barra_titulo.Controls.Add(this.pic_hora);
            this.panel_barra_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra_titulo.Location = new System.Drawing.Point(200, 0);
            this.panel_barra_titulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_barra_titulo.Name = "panel_barra_titulo";
            this.panel_barra_titulo.Size = new System.Drawing.Size(1260, 50);
            this.panel_barra_titulo.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Black;
            this.lbltitulo.Location = new System.Drawing.Point(595, 14);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(59, 23);
            this.lbltitulo.TabIndex = 18;
            this.lbltitulo.Text = "Inicio";
            // 
            // pic_fecha
            // 
            this.pic_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_fecha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_fecha.Image = global::Proyecto_Biblioteca.Properties.Resources.nota__1_;
            this.pic_fecha.Location = new System.Drawing.Point(1075, 5);
            this.pic_fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_fecha.Name = "pic_fecha";
            this.pic_fecha.Size = new System.Drawing.Size(40, 39);
            this.pic_fecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_fecha.TabIndex = 17;
            this.pic_fecha.TabStop = false;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.Black;
            this.lbl_fecha.Location = new System.Drawing.Point(1119, 15);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(62, 21);
            this.lbl_fecha.TabIndex = 16;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.Black;
            this.lbl_hora.Location = new System.Drawing.Point(57, 15);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(50, 21);
            this.lbl_hora.TabIndex = 15;
            this.lbl_hora.Text = "Hora";
            // 
            // pic_hora
            // 
            this.pic_hora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_hora.Image = global::Proyecto_Biblioteca.Properties.Resources.reloj;
            this.pic_hora.Location = new System.Drawing.Point(13, 6);
            this.pic_hora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_hora.Name = "pic_hora";
            this.pic_hora.Size = new System.Drawing.Size(40, 39);
            this.pic_hora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_hora.TabIndex = 14;
            this.pic_hora.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(200, 50);
            this.panel_contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1260, 577);
            this.panel_contenedor.TabIndex = 1;
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1460, 627);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_barra_titulo);
            this.Controls.Add(this.panel_barra_izquierda);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_main_FormClosed);
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.SizeChanged += new System.EventHandler(this.Frm_main_SizeChanged);
            this.panel_barra_izquierda.ResumeLayout(false);
            this.panel_barra_izquierda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).EndInit();
            this.panel_barra_titulo.ResumeLayout(false);
            this.panel_barra_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barra_izquierda;
        private System.Windows.Forms.Panel panel_barra_titulo;
        private System.Windows.Forms.Label lbl_jane;
        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.Button btnprestamos;
        private System.Windows.Forms.Button btnlibros;
        private System.Windows.Forms.Button btnalumnos;
        private System.Windows.Forms.PictureBox pic_hora;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.PictureBox pic_fecha;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox pic_menu;
        private System.Windows.Forms.Button btn_historial_prestamos;
        private System.Windows.Forms.Button btn_devolucion;
        private System.Windows.Forms.Button btn_rating;
        private System.Windows.Forms.Button btn_cerrar_sesion;
    }
}