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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtAnioPublicacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(20, 94);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(571, 30);
            this.TxtIsbn.TabIndex = 42;
            this.TxtIsbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIsbn_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "ISBN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Año de publicación";
            // 
            // BtnVerAutores
            // 
            this.BtnVerAutores.Location = new System.Drawing.Point(468, 304);
            this.BtnVerAutores.Name = "BtnVerAutores";
            this.BtnVerAutores.Size = new System.Drawing.Size(76, 31);
            this.BtnVerAutores.TabIndex = 36;
            this.BtnVerAutores.Text = "Ver";
            this.BtnVerAutores.UseVisualStyleBackColor = true;
            this.BtnVerAutores.Click += new System.EventHandler(this.BtnVerAutores_Click);
            // 
            // BtnVerEditoriales
            // 
            this.BtnVerEditoriales.Location = new System.Drawing.Point(468, 378);
            this.BtnVerEditoriales.Name = "BtnVerEditoriales";
            this.BtnVerEditoriales.Size = new System.Drawing.Size(76, 31);
            this.BtnVerEditoriales.TabIndex = 35;
            this.BtnVerEditoriales.Text = "Ver editoriales";
            this.BtnVerEditoriales.UseVisualStyleBackColor = true;
            this.BtnVerEditoriales.Click += new System.EventHandler(this.BtnVerEditoriales_Click);
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(20, 305);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(413, 30);
            this.TxtAutor.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Autor(es)";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Location = new System.Drawing.Point(20, 379);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(174, 30);
            this.TxtEditorial.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Editorial";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(20, 167);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(413, 30);
            this.TxtTitulo.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Titulo";
            // 
            // BtnVerCategorias
            // 
            this.BtnVerCategorias.Location = new System.Drawing.Point(468, 232);
            this.BtnVerCategorias.Name = "BtnVerCategorias";
            this.BtnVerCategorias.Size = new System.Drawing.Size(76, 31);
            this.BtnVerCategorias.TabIndex = 27;
            this.BtnVerCategorias.Text = "Ver categorías";
            this.BtnVerCategorias.UseVisualStyleBackColor = true;
            this.BtnVerCategorias.Click += new System.EventHandler(this.BtnVerCategorias_Click);
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(20, 233);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(413, 30);
            this.TxtCategoria.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Categoría(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Agregar Libro";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(327, 470);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(123, 31);
            this.BtnGuardar.TabIndex = 24;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(468, 470);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(123, 31);
            this.BtnCancelar.TabIndex = 25;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtAnioPublicacion
            // 
            this.TxtAnioPublicacion.Location = new System.Drawing.Point(21, 455);
            this.TxtAnioPublicacion.Name = "TxtAnioPublicacion";
            this.TxtAnioPublicacion.Size = new System.Drawing.Size(173, 30);
            this.TxtAnioPublicacion.TabIndex = 50;
            // 
            // FrmAdquisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(607, 513);
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
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdquisiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdquisiciones";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtAnioPublicacion;
    }
}