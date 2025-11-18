namespace SistemaBibliosfera
{
    partial class FrmDatosPrestamos
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
            this.TxtNumControl = new System.Windows.Forms.TextBox();
            this.TxtLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtEjemplar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBuscarrNumControl = new System.Windows.Forms.Button();
            this.BtnBuscarrLibro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num. Control";
            // 
            // TxtNumControl
            // 
            this.TxtNumControl.Location = new System.Drawing.Point(18, 102);
            this.TxtNumControl.Name = "TxtNumControl";
            this.TxtNumControl.Size = new System.Drawing.Size(281, 34);
            this.TxtNumControl.TabIndex = 1;
            // 
            // TxtLibro
            // 
            this.TxtLibro.Location = new System.Drawing.Point(18, 170);
            this.TxtLibro.Name = "TxtLibro";
            this.TxtLibro.Size = new System.Drawing.Size(281, 34);
            this.TxtLibro.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(14, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Libro";
            // 
            // DtpFechaDevolucion
            // 
            this.DtpFechaDevolucion.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.DtpFechaDevolucion.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.DtpFechaDevolucion.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.DtpFechaDevolucion.Location = new System.Drawing.Point(18, 321);
            this.DtpFechaDevolucion.Name = "DtpFechaDevolucion";
            this.DtpFechaDevolucion.Size = new System.Drawing.Size(511, 34);
            this.DtpFechaDevolucion.TabIndex = 8;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(102)))));
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.BtnAceptar.Location = new System.Drawing.Point(327, 382);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(143, 43);
            this.BtnAceptar.TabIndex = 9;
            this.BtnAceptar.Text = "Guardar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(102)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.BtnCancelar.Location = new System.Drawing.Point(489, 382);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(143, 43);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtEjemplar
            // 
            this.TxtEjemplar.Location = new System.Drawing.Point(359, 170);
            this.TxtEjemplar.Name = "TxtEjemplar";
            this.TxtEjemplar.Size = new System.Drawing.Size(108, 34);
            this.TxtEjemplar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(355, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ejemplar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(14, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de devolución prevista";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(359, 102);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(234, 34);
            this.TxtNombre.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(355, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label6.Location = new System.Drawing.Point(14, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(18, 238);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(178, 36);
            this.CmbEstado.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 41);
            this.label7.TabIndex = 32;
            this.label7.Text = "Agregar Préstamo";
            // 
            // BtnBuscarrNumControl
            // 
            this.BtnBuscarrNumControl.BackgroundImage = global::SistemaBibliosfera.Properties.Resources.icons8_buscar_60;
            this.BtnBuscarrNumControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarrNumControl.FlatAppearance.BorderSize = 0;
            this.BtnBuscarrNumControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarrNumControl.Location = new System.Drawing.Point(599, 100);
            this.BtnBuscarrNumControl.Name = "BtnBuscarrNumControl";
            this.BtnBuscarrNumControl.Size = new System.Drawing.Size(33, 36);
            this.BtnBuscarrNumControl.TabIndex = 45;
            this.BtnBuscarrNumControl.UseVisualStyleBackColor = true;
            this.BtnBuscarrNumControl.Click += new System.EventHandler(this.BtnBuscarrNumControl_Click);
            // 
            // BtnBuscarrLibro
            // 
            this.BtnBuscarrLibro.BackgroundImage = global::SistemaBibliosfera.Properties.Resources.icons8_buscar_60;
            this.BtnBuscarrLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarrLibro.FlatAppearance.BorderSize = 0;
            this.BtnBuscarrLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarrLibro.Location = new System.Drawing.Point(473, 170);
            this.BtnBuscarrLibro.Name = "BtnBuscarrLibro";
            this.BtnBuscarrLibro.Size = new System.Drawing.Size(33, 36);
            this.BtnBuscarrLibro.TabIndex = 46;
            this.BtnBuscarrLibro.UseVisualStyleBackColor = true;
            this.BtnBuscarrLibro.Click += new System.EventHandler(this.BtnBuscarrLibro_Click);
            // 
            // FrmDatosPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(645, 437);
            this.Controls.Add(this.BtnBuscarrLibro);
            this.Controls.Add(this.BtnBuscarrNumControl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtEjemplar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.DtpFechaDevolucion);
            this.Controls.Add(this.TxtLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumControl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDatosPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatosPrestamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumControl;
        private System.Windows.Forms.TextBox TxtLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaDevolucion;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtEjemplar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBuscarrNumControl;
        private System.Windows.Forms.Button BtnBuscarrLibro;
    }
}