
namespace Proyecto_Biblioteca
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_jane = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btn_iniciar_sesion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_cerrar = new System.Windows.Forms.PictureBox();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.lbl_jane);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 398);
            this.panel1.TabIndex = 0;
            // 
            // lbl_jane
            // 
            this.lbl_jane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_jane.AutoSize = true;
            this.lbl_jane.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jane.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_jane.Location = new System.Drawing.Point(8, 181);
            this.lbl_jane.Name = "lbl_jane";
            this.lbl_jane.Size = new System.Drawing.Size(203, 28);
            this.lbl_jane.TabIndex = 0;
            this.lbl_jane.Text = "JANE SOFTWARE";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txt_usuario.ForeColor = System.Drawing.Color.Gray;
            this.txt_usuario.Location = new System.Drawing.Point(20, 96);
            this.txt_usuario.Multiline = true;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(500, 30);
            this.txt_usuario.TabIndex = 2;
            this.txt_usuario.Text = "Escribir usuario";
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.Color.Gray;
            this.txt_contraseña.Location = new System.Drawing.Point(20, 174);
            this.txt_contraseña.Multiline = true;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(500, 30);
            this.txt_contraseña.TabIndex = 3;
            this.txt_contraseña.Text = "Escribir contraseña";
            this.txt_contraseña.Enter += new System.EventHandler(this.txt_contraseña_Enter);
            this.txt_contraseña.Leave += new System.EventHandler(this.txt_contraseña_Leave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(145, 320);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(232, 21);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidaste la contraseña?";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(131, 352);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(265, 21);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "¿No tienes usuario? Registrate.";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btn_iniciar_sesion
            // 
            this.btn_iniciar_sesion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_iniciar_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iniciar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar_sesion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_iniciar_sesion.Location = new System.Drawing.Point(20, 239);
            this.btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            this.btn_iniciar_sesion.Size = new System.Drawing.Size(500, 50);
            this.btn_iniciar_sesion.TabIndex = 4;
            this.btn_iniciar_sesion.Text = "Iniciar sesion";
            this.btn_iniciar_sesion.UseVisualStyleBackColor = false;
            this.btn_iniciar_sesion.Click += new System.EventHandler(this.btn_iniciar_sesion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pic_cerrar);
            this.panel2.Controls.Add(this.lbl_inicio);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_iniciar_sesion);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.txt_contraseña);
            this.panel2.Controls.Add(this.txt_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 398);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pic_cerrar
            // 
            this.pic_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_cerrar.Image = global::Proyecto_Biblioteca.Properties.Resources.cerrar;
            this.pic_cerrar.Location = new System.Drawing.Point(495, 3);
            this.pic_cerrar.Name = "pic_cerrar";
            this.pic_cerrar.Size = new System.Drawing.Size(41, 37);
            this.pic_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cerrar.TabIndex = 11;
            this.pic_cerrar.TabStop = false;
            this.pic_cerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicio.Location = new System.Drawing.Point(206, 9);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(129, 23);
            this.lbl_inicio.TabIndex = 0;
            this.lbl_inicio.Text = "Iniciar sesion";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(20, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 1);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(20, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 1);
            this.panel3.TabIndex = 8;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(764, 398);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_jane;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btn_iniciar_sesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.PictureBox pic_cerrar;
    }
}

