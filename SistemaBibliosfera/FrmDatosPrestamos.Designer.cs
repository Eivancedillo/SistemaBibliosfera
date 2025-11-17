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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosPrestamos));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumControl = new System.Windows.Forms.TextBox();
            this.BtnBuscarNumControl = new System.Windows.Forms.Button();
            this.BtnBuscarEjemplar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num. Control";
            // 
            // TxtNumControl
            // 
            this.TxtNumControl.Location = new System.Drawing.Point(54, 129);
            this.TxtNumControl.Name = "TxtNumControl";
            this.TxtNumControl.Size = new System.Drawing.Size(281, 29);
            this.TxtNumControl.TabIndex = 1;
            // 
            // BtnBuscarNumControl
            // 
            this.BtnBuscarNumControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarNumControl.BackgroundImage")));
            this.BtnBuscarNumControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarNumControl.Location = new System.Drawing.Point(712, 123);
            this.BtnBuscarNumControl.Name = "BtnBuscarNumControl";
            this.BtnBuscarNumControl.Size = new System.Drawing.Size(39, 35);
            this.BtnBuscarNumControl.TabIndex = 4;
            this.BtnBuscarNumControl.UseVisualStyleBackColor = true;
            this.BtnBuscarNumControl.Click += new System.EventHandler(this.BtnBuscarNumControl_Click);
            // 
            // BtnBuscarEjemplar
            // 
            this.BtnBuscarEjemplar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarEjemplar.BackgroundImage")));
            this.BtnBuscarEjemplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscarEjemplar.Location = new System.Drawing.Point(581, 190);
            this.BtnBuscarEjemplar.Name = "BtnBuscarEjemplar";
            this.BtnBuscarEjemplar.Size = new System.Drawing.Size(37, 37);
            this.BtnBuscarEjemplar.TabIndex = 7;
            this.BtnBuscarEjemplar.UseVisualStyleBackColor = true;
            this.BtnBuscarEjemplar.Click += new System.EventHandler(this.BtnBuscarEjemplar_Click);
            // 
            // TxtLibro
            // 
            this.TxtLibro.Location = new System.Drawing.Point(54, 195);
            this.TxtLibro.Name = "TxtLibro";
            this.TxtLibro.Size = new System.Drawing.Size(281, 29);
            this.TxtLibro.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Libro";
            // 
            // DtpFechaDevolucion
            // 
            this.DtpFechaDevolucion.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.DtpFechaDevolucion.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.DtpFechaDevolucion.Location = new System.Drawing.Point(54, 331);
            this.DtpFechaDevolucion.Name = "DtpFechaDevolucion";
            this.DtpFechaDevolucion.Size = new System.Drawing.Size(511, 29);
            this.DtpFechaDevolucion.TabIndex = 8;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(282, 383);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(143, 43);
            this.BtnAceptar.TabIndex = 9;
            this.BtnAceptar.Text = "Guardar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(444, 383);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(143, 43);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtEjemplar
            // 
            this.TxtEjemplar.Location = new System.Drawing.Point(457, 195);
            this.TxtEjemplar.Name = "TxtEjemplar";
            this.TxtEjemplar.Size = new System.Drawing.Size(108, 29);
            this.TxtEjemplar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ejemplar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de devolución prevista";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(457, 129);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(234, 29);
            this.TxtNombre.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(54, 269);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(178, 29);
            this.CmbEstado.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.label7.Location = new System.Drawing.Point(48, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 32);
            this.label7.TabIndex = 32;
            this.label7.Text = "Agregar Préstamo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // FrmDatosPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 464);
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
            this.Controls.Add(this.BtnBuscarEjemplar);
            this.Controls.Add(this.TxtLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscarNumControl);
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
        private System.Windows.Forms.Button BtnBuscarNumControl;
        private System.Windows.Forms.Button BtnBuscarEjemplar;
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
    }
}