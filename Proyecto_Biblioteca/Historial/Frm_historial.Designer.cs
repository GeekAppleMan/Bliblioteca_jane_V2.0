﻿
namespace Proyecto_Biblioteca
{
    partial class Frm_historial
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
            this.dgv_prestamos = new System.Windows.Forms.DataGridView();
            this.txt_matricula_alumno = new System.Windows.Forms.TextBox();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.panel_busqueda = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).BeginInit();
            this.panel_busqueda.SuspendLayout();
            this.SuspendLayout();
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
            this.Usuario,
            this.Alumno,
            this.Fecha_salida,
            this.Devolucion});
            this.dgv_prestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_prestamos.Location = new System.Drawing.Point(0, 50);
            this.dgv_prestamos.Name = "dgv_prestamos";
            this.dgv_prestamos.RowHeadersVisible = false;
            this.dgv_prestamos.RowHeadersWidth = 51;
            this.dgv_prestamos.RowTemplate.Height = 24;
            this.dgv_prestamos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_prestamos.Size = new System.Drawing.Size(800, 400);
            this.dgv_prestamos.TabIndex = 4;
            // 
            // txt_matricula_alumno
            // 
            this.txt_matricula_alumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_matricula_alumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula_alumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matricula_alumno.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricula_alumno.Location = new System.Drawing.Point(355, 16);
            this.txt_matricula_alumno.Name = "txt_matricula_alumno";
            this.txt_matricula_alumno.Size = new System.Drawing.Size(262, 21);
            this.txt_matricula_alumno.TabIndex = 0;
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(114, 14);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(220, 23);
            this.lbl_matricula.TabIndex = 0;
            this.lbl_matricula.Text = "Matricula del alumno";
            // 
            // panel_busqueda
            // 
            this.panel_busqueda.Controls.Add(this.button1);
            this.panel_busqueda.Controls.Add(this.panel2);
            this.panel_busqueda.Controls.Add(this.txt_matricula_alumno);
            this.panel_busqueda.Controls.Add(this.lbl_matricula);
            this.panel_busqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_busqueda.Location = new System.Drawing.Point(0, 0);
            this.panel_busqueda.Name = "panel_busqueda";
            this.panel_busqueda.Size = new System.Drawing.Size(800, 50);
            this.panel_busqueda.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(353, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 1);
            this.panel2.TabIndex = 13;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Devolver";
            this.dataGridViewImageColumn1.Image = global::Proyecto_Biblioteca.Properties.Resources.icons8_devolver_libro_96;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 115;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::Proyecto_Biblioteca.Properties.Resources.folder_saved_search_16890;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(636, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 47);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.MinimumWidth = 6;
            this.Libro.Name = "Libro";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            // 
            // Alumno
            // 
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.MinimumWidth = 6;
            this.Alumno.Name = "Alumno";
            // 
            // Fecha_salida
            // 
            this.Fecha_salida.HeaderText = "Fecha de salida";
            this.Fecha_salida.MinimumWidth = 6;
            this.Fecha_salida.Name = "Fecha_salida";
            // 
            // Devolucion
            // 
            this.Devolucion.HeaderText = "Fecha para devolver";
            this.Devolucion.MinimumWidth = 6;
            this.Devolucion.Name = "Devolucion";
            // 
            // Frm_historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_prestamos);
            this.Controls.Add(this.panel_busqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_historial";
            this.Text = "Frm_historial";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).EndInit();
            this.panel_busqueda.ResumeLayout(false);
            this.panel_busqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_prestamos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_matricula_alumno;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Panel panel_busqueda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devolucion;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}