
namespace Proyecto_Biblioteca.Recuperar_contraseña
{
    partial class Frm_recuperar_contraseña
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.pic_cerrar = new System.Windows.Forms.PictureBox();
            this.lbl_registrar = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txt_verificar_contraseña = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_jane = new System.Windows.Forms.Label();
            this.link_enviar_codigo = new System.Windows.Forms.LinkLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.link_enviar_codigo);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.txt_correo);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txt_codigo);
            this.panel2.Controls.Add(this.pic_cerrar);
            this.panel2.Controls.Add(this.lbl_registrar);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_registrar);
            this.panel2.Controls.Add(this.txt_verificar_contraseña);
            this.panel2.Controls.Add(this.txt_contraseña);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 450);
            this.panel2.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(20, 133);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 1);
            this.panel6.TabIndex = 17;
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txt_correo.ForeColor = System.Drawing.Color.Gray;
            this.txt_correo.Location = new System.Drawing.Point(20, 97);
            this.txt_correo.Multiline = true;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(500, 30);
            this.txt_correo.TabIndex = 1;
            this.txt_correo.Text = "Escribir correo";
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_correo_KeyPress);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(20, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 1);
            this.panel5.TabIndex = 13;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txt_codigo.ForeColor = System.Drawing.Color.Gray;
            this.txt_codigo.Location = new System.Drawing.Point(20, 176);
            this.txt_codigo.Multiline = true;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(500, 30);
            this.txt_codigo.TabIndex = 3;
            this.txt_codigo.Text = "Escribir codigo";
            this.txt_codigo.Enter += new System.EventHandler(this.txt_codigo_Enter);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // pic_cerrar
            // 
            this.pic_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_cerrar.Image = global::Proyecto_Biblioteca.Properties.Resources.cerrar;
            this.pic_cerrar.Location = new System.Drawing.Point(496, 3);
            this.pic_cerrar.Name = "pic_cerrar";
            this.pic_cerrar.Size = new System.Drawing.Size(41, 37);
            this.pic_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cerrar.TabIndex = 11;
            this.pic_cerrar.TabStop = false;
            this.pic_cerrar.Click += new System.EventHandler(this.pic_cerrar_Click);
            // 
            // lbl_registrar
            // 
            this.lbl_registrar.AutoSize = true;
            this.lbl_registrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registrar.Location = new System.Drawing.Point(186, 9);
            this.lbl_registrar.Name = "lbl_registrar";
            this.lbl_registrar.Size = new System.Drawing.Size(166, 23);
            this.lbl_registrar.TabIndex = 0;
            this.lbl_registrar.Text = "Registrar usuario";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(20, 332);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 1);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(20, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 1);
            this.panel3.TabIndex = 8;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_registrar.Location = new System.Drawing.Point(20, 345);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(500, 50);
            this.btn_registrar.TabIndex = 0;
            this.btn_registrar.Text = "Modificar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click_1);
            // 
            // txt_verificar_contraseña
            // 
            this.txt_verificar_contraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_verificar_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_verificar_contraseña.Enabled = false;
            this.txt_verificar_contraseña.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_verificar_contraseña.ForeColor = System.Drawing.Color.Gray;
            this.txt_verificar_contraseña.Location = new System.Drawing.Point(20, 296);
            this.txt_verificar_contraseña.Multiline = true;
            this.txt_verificar_contraseña.Name = "txt_verificar_contraseña";
            this.txt_verificar_contraseña.Size = new System.Drawing.Size(500, 30);
            this.txt_verificar_contraseña.TabIndex = 5;
            this.txt_verificar_contraseña.Text = "Verificar contraseña";
            this.txt_verificar_contraseña.Enter += new System.EventHandler(this.txt_verificar_contraseña_Enter);
            this.txt_verificar_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_verificar_contraseña_KeyPress);
            this.txt_verificar_contraseña.Leave += new System.EventHandler(this.txt_verificar_contraseña_Leave);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Enabled = false;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txt_contraseña.ForeColor = System.Drawing.Color.Gray;
            this.txt_contraseña.Location = new System.Drawing.Point(20, 235);
            this.txt_contraseña.Multiline = true;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(500, 30);
            this.txt_contraseña.TabIndex = 4;
            this.txt_contraseña.Text = "Escribir contraseña nueva";
            this.txt_contraseña.Enter += new System.EventHandler(this.txt_contraseña_Enter);
            this.txt_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contraseña_KeyPress);
            this.txt_contraseña.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.lbl_jane);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 450);
            this.panel1.TabIndex = 4;
            // 
            // lbl_jane
            // 
            this.lbl_jane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_jane.AutoSize = true;
            this.lbl_jane.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jane.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_jane.Location = new System.Drawing.Point(8, 204);
            this.lbl_jane.Name = "lbl_jane";
            this.lbl_jane.Size = new System.Drawing.Size(203, 28);
            this.lbl_jane.TabIndex = 0;
            this.lbl_jane.Text = "JANE SOFTWARE";
            // 
            // link_enviar_codigo
            // 
            this.link_enviar_codigo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.link_enviar_codigo.AutoSize = true;
            this.link_enviar_codigo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.link_enviar_codigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.link_enviar_codigo.LinkColor = System.Drawing.Color.Black;
            this.link_enviar_codigo.Location = new System.Drawing.Point(16, 137);
            this.link_enviar_codigo.Name = "link_enviar_codigo";
            this.link_enviar_codigo.Size = new System.Drawing.Size(124, 21);
            this.link_enviar_codigo.TabIndex = 2;
            this.link_enviar_codigo.TabStop = true;
            this.link_enviar_codigo.Text = "Enviar codigo";
            this.link_enviar_codigo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Frm_recuperar_contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_recuperar_contraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_recuperar_contraseña";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_recuperar_contraseña_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.PictureBox pic_cerrar;
        private System.Windows.Forms.Label lbl_registrar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txt_verificar_contraseña;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_jane;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.LinkLabel link_enviar_codigo;
    }
}