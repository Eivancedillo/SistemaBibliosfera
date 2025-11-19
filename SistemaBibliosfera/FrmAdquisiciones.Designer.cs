namespace SistemaBibliosfera
{
    partial class FrmAdquisiciones
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
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnVerAutores = new System.Windows.Forms.Button();
            this.BtnVerEditoriales = new System.Windows.Forms.Button();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnVerCategorias = new System.Windows.Forms.Button();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtAnioPublicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnInsertarISBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIsbn.Location = new System.Drawing.Point(473, 113);
            this.TxtIsbn.Multiline = true;
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(182, 30);
            this.TxtIsbn.TabIndex = 42;
            this.TxtIsbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIsbn_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label9.Location = new System.Drawing.Point(469, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 28);
            this.label9.TabIndex = 41;
            this.label9.Text = "ISBN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label7.Location = new System.Drawing.Point(469, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 28);
            this.label7.TabIndex = 37;
            this.label7.Text = "Año de publicación";
            // 
            // BtnVerAutores
            // 
            this.BtnVerAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.BtnVerAutores.FlatAppearance.BorderSize = 0;
            this.BtnVerAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerAutores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerAutores.Location = new System.Drawing.Point(290, 268);
            this.BtnVerAutores.Name = "BtnVerAutores";
            this.BtnVerAutores.Size = new System.Drawing.Size(107, 30);
            this.BtnVerAutores.TabIndex = 36;
            this.BtnVerAutores.Text = "Ver autor(es)";
            this.BtnVerAutores.UseVisualStyleBackColor = false;
            this.BtnVerAutores.Click += new System.EventHandler(this.BtnVerAutores_Click);
            // 
            // BtnVerEditoriales
            // 
            this.BtnVerEditoriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.BtnVerEditoriales.FlatAppearance.BorderSize = 0;
            this.BtnVerEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerEditoriales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerEditoriales.Location = new System.Drawing.Point(289, 351);
            this.BtnVerEditoriales.Name = "BtnVerEditoriales";
            this.BtnVerEditoriales.Size = new System.Drawing.Size(108, 30);
            this.BtnVerEditoriales.TabIndex = 35;
            this.BtnVerEditoriales.Text = "Ver editoriales";
            this.BtnVerEditoriales.UseVisualStyleBackColor = false;
            this.BtnVerEditoriales.Click += new System.EventHandler(this.BtnVerEditoriales_Click);
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(16, 268);
            this.TxtAutor.Multiline = true;
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(268, 30);
            this.TxtAutor.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "Autor(es)";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Location = new System.Drawing.Point(16, 351);
            this.TxtEditorial.Multiline = true;
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(267, 30);
            this.TxtEditorial.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(13, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "Editorial";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(17, 113);
            this.TxtTitulo.Multiline = true;
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(380, 30);
            this.TxtTitulo.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(13, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Titulo";
            // 
            // BtnVerCategorias
            // 
            this.BtnVerCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.BtnVerCategorias.FlatAppearance.BorderSize = 0;
            this.BtnVerCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerCategorias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerCategorias.Location = new System.Drawing.Point(290, 190);
            this.BtnVerCategorias.Name = "BtnVerCategorias";
            this.BtnVerCategorias.Size = new System.Drawing.Size(107, 31);
            this.BtnVerCategorias.TabIndex = 27;
            this.BtnVerCategorias.Text = "Ver categorías";
            this.BtnVerCategorias.UseVisualStyleBackColor = false;
            this.BtnVerCategorias.Click += new System.EventHandler(this.BtnVerCategorias_Click);
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(16, 190);
            this.TxtCategoria.Multiline = true;
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(268, 30);
            this.TxtCategoria.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(13, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Categoría(s)";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(102)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(460, 392);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(111, 49);
            this.BtnGuardar.TabIndex = 24;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(102)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(589, 392);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(111, 49);
            this.BtnCancelar.TabIndex = 25;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtAnioPublicacion
            // 
            this.TxtAnioPublicacion.Location = new System.Drawing.Point(473, 190);
            this.TxtAnioPublicacion.Name = "TxtAnioPublicacion";
            this.TxtAnioPublicacion.Size = new System.Drawing.Size(182, 34);
            this.TxtAnioPublicacion.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 41);
            this.label3.TabIndex = 72;
            this.label3.Text = "Agregar Libro";
            // 
            // BtnInsertarISBN
            // 
            this.BtnInsertarISBN.BackgroundImage = global::SistemaBibliosfera.Properties.Resources.icons8_añadir_60;
            this.BtnInsertarISBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnInsertarISBN.FlatAppearance.BorderSize = 0;
            this.BtnInsertarISBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertarISBN.Location = new System.Drawing.Point(660, 108);
            this.BtnInsertarISBN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnInsertarISBN.Name = "BtnInsertarISBN";
            this.BtnInsertarISBN.Size = new System.Drawing.Size(40, 35);
            this.BtnInsertarISBN.TabIndex = 73;
            this.BtnInsertarISBN.UseVisualStyleBackColor = true;
            this.BtnInsertarISBN.Click += new System.EventHandler(this.BtnInsertarISBN_Click);
            // 
            // FrmAdquisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 453);
            this.Controls.Add(this.BtnInsertarISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAnioPublicacion);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtIsbn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnVerAutores);
            this.Controls.Add(this.BtnVerEditoriales);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtEditorial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnVerCategorias);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdquisiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdquisiciones";
            this.Load += new System.EventHandler(this.FrmAdquisiciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnVerAutores;
        private System.Windows.Forms.Button BtnVerEditoriales;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnVerCategorias;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtAnioPublicacion;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnInsertarISBN;
    }
}