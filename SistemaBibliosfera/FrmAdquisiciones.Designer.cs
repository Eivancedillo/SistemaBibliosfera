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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.BtnVerCategorias = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.BtnVerEditoriales = new System.Windows.Forms.Button();
            this.BtnVerAutores = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpAnioPublicacion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoría";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(12, 71);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(284, 26);
            this.TxtCategoria.TabIndex = 2;
            // 
            // BtnVerCategorias
            // 
            this.BtnVerCategorias.Location = new System.Drawing.Point(313, 69);
            this.BtnVerCategorias.Name = "BtnVerCategorias";
            this.BtnVerCategorias.Size = new System.Drawing.Size(123, 31);
            this.BtnVerCategorias.TabIndex = 3;
            this.BtnVerCategorias.Text = "Ver categorías";
            this.BtnVerCategorias.UseVisualStyleBackColor = true;
            this.BtnVerCategorias.Click += new System.EventHandler(this.BtnVerCategorias_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Titulo";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(16, 177);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(284, 26);
            this.TxtTitulo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Editorial";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Location = new System.Drawing.Point(16, 240);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(284, 26);
            this.TxtEditorial.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Autor";
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(16, 304);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(284, 26);
            this.TxtAutor.TabIndex = 10;
            // 
            // BtnVerEditoriales
            // 
            this.BtnVerEditoriales.Location = new System.Drawing.Point(313, 238);
            this.BtnVerEditoriales.Name = "BtnVerEditoriales";
            this.BtnVerEditoriales.Size = new System.Drawing.Size(123, 31);
            this.BtnVerEditoriales.TabIndex = 11;
            this.BtnVerEditoriales.Text = "Ver editoriales";
            this.BtnVerEditoriales.UseVisualStyleBackColor = true;
            // 
            // BtnVerAutores
            // 
            this.BtnVerAutores.Location = new System.Drawing.Point(313, 304);
            this.BtnVerAutores.Name = "BtnVerAutores";
            this.BtnVerAutores.Size = new System.Drawing.Size(123, 31);
            this.BtnVerAutores.TabIndex = 12;
            this.BtnVerAutores.Text = "Ver autores";
            this.BtnVerAutores.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Año de publicación";
            // 
            // DtpAnioPublicacion
            // 
            this.DtpAnioPublicacion.Location = new System.Drawing.Point(554, 177);
            this.DtpAnioPublicacion.Name = "DtpAnioPublicacion";
            this.DtpAnioPublicacion.Size = new System.Drawing.Size(200, 26);
            this.DtpAnioPublicacion.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(830, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ubicación";
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Location = new System.Drawing.Point(834, 177);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(200, 26);
            this.TxtUbicacion.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "ISBN";
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(554, 261);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(200, 26);
            this.TxtIsbn.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(830, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Código";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(834, 261);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(200, 26);
            this.TxtCodigo.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(550, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(554, 349);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(200, 28);
            this.CmbEstado.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(16, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 70);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(161, 25);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(123, 31);
            this.BtnCancelar.TabIndex = 25;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(20, 25);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(123, 31);
            this.BtnGuardar.TabIndex = 24;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmAdquisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1070, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtIsbn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtUbicacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DtpAnioPublicacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnVerAutores);
            this.Controls.Add(this.BtnVerEditoriales);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtEditorial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnVerCategorias);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdquisiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdquisiciones";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Button BtnVerCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.Button BtnVerEditoriales;
        private System.Windows.Forms.Button BtnVerAutores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpAnioPublicacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}