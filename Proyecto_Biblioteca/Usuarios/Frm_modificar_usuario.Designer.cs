
namespace Proyecto_Biblioteca.Usuarios
{
    partial class Frm_modificar_usuario
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
            this.combo_estatus = new System.Windows.Forms.ComboBox();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.combo_estatus.Location = new System.Drawing.Point(16, 280);
            this.combo_estatus.Name = "combo_estatus";
            this.combo_estatus.Size = new System.Drawing.Size(335, 29);
            this.combo_estatus.TabIndex = 8;
            this.combo_estatus.Text = "Activo";
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus.Location = new System.Drawing.Point(16, 250);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(77, 23);
            this.lbl_estatus.TabIndex = 66;
            this.lbl_estatus.Text = "Estatus";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.combo_estatus);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lbl_usuario);
            this.groupBox1.Controls.Add(this.lbl_estatus);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txt_contraseña);
            this.groupBox1.Controls.Add(this.lbl_matricula);
            this.groupBox1.Controls.Add(this.txt_matricula);
            this.groupBox1.Controls.Add(this.lbl_contraseña);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 415);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(19, 132);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(330, 21);
            this.txt_usuario.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(16, 157);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 1);
            this.panel1.TabIndex = 67;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(16, 102);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(79, 23);
            this.lbl_usuario.TabIndex = 66;
            this.lbl_usuario.Text = "Usuario";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(16, 314);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 1);
            this.panel5.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(16, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 1);
            this.panel2.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(16, 237);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 1);
            this.panel3.TabIndex = 57;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(19, 212);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(330, 21);
            this.txt_contraseña.TabIndex = 2;
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(16, 27);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(101, 23);
            this.lbl_matricula.TabIndex = 56;
            this.lbl_matricula.Text = "Matricula";
            // 
            // txt_matricula
            // 
            this.txt_matricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matricula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricula.Location = new System.Drawing.Point(19, 62);
            this.txt_matricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(330, 21);
            this.txt_matricula.TabIndex = 0;
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.Location = new System.Drawing.Point(16, 175);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(125, 23);
            this.lbl_contraseña.TabIndex = 55;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.btn_cancelar.Location = new System.Drawing.Point(190, 340);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(171, 44);
            this.btn_cancelar.TabIndex = 69;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.btn_modificar.Location = new System.Drawing.Point(13, 340);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(171, 44);
            this.btn_modificar.TabIndex = 68;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // Frm_modificar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 415);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Frm_modificar_usuario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_estatus;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label lbl_matricula;
        public System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_modificar;
        public System.Windows.Forms.ComboBox combo_estatus;
    }
}