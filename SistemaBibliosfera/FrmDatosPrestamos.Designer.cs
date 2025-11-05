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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num. Control";
            // 
            // TxtNumControl
            // 
            this.TxtNumControl.Location = new System.Drawing.Point(144, 22);
            this.TxtNumControl.Name = "TxtNumControl";
            this.TxtNumControl.Size = new System.Drawing.Size(191, 30);
            this.TxtNumControl.TabIndex = 1;
            // 
            // BtnBuscarNumControl
            // 
            this.BtnBuscarNumControl.Location = new System.Drawing.Point(652, 22);
            this.BtnBuscarNumControl.Name = "BtnBuscarNumControl";
            this.BtnBuscarNumControl.Size = new System.Drawing.Size(92, 30);
            this.BtnBuscarNumControl.TabIndex = 4;
            this.BtnBuscarNumControl.Text = "Buscar";
            this.BtnBuscarNumControl.UseVisualStyleBackColor = true;
            this.BtnBuscarNumControl.Click += new System.EventHandler(this.BtnBuscarNumControl_Click);
            // 
            // BtnBuscarEjemplar
            // 
            this.BtnBuscarEjemplar.Location = new System.Drawing.Point(652, 73);
            this.BtnBuscarEjemplar.Name = "BtnBuscarEjemplar";
            this.BtnBuscarEjemplar.Size = new System.Drawing.Size(92, 30);
            this.BtnBuscarEjemplar.TabIndex = 7;
            this.BtnBuscarEjemplar.Text = "Buscar";
            this.BtnBuscarEjemplar.UseVisualStyleBackColor = true;
            this.BtnBuscarEjemplar.Click += new System.EventHandler(this.BtnBuscarEjemplar_Click);
            // 
            // TxtLibro
            // 
            this.TxtLibro.Location = new System.Drawing.Point(82, 73);
            this.TxtLibro.Name = "TxtLibro";
            this.TxtLibro.Size = new System.Drawing.Size(253, 30);
            this.TxtLibro.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Libro";
            // 
            // DtpFechaDevolucion
            // 
            this.DtpFechaDevolucion.Location = new System.Drawing.Point(284, 175);
            this.DtpFechaDevolucion.Name = "DtpFechaDevolucion";
            this.DtpFechaDevolucion.Size = new System.Drawing.Size(460, 30);
            this.DtpFechaDevolucion.TabIndex = 8;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(234, 232);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(129, 66);
            this.BtnAceptar.TabIndex = 9;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(369, 232);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(129, 66);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtEjemplar
            // 
            this.TxtEjemplar.Location = new System.Drawing.Point(435, 73);
            this.TxtEjemplar.Name = "TxtEjemplar";
            this.TxtEjemplar.Size = new System.Drawing.Size(98, 30);
            this.TxtEjemplar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ejemplar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de devolucion prevista";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(435, 22);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(211, 30);
            this.TxtNombre.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(91, 123);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(161, 33);
            this.CmbEstado.TabIndex = 31;
            // 
            // FrmDatosPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(753, 310);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
    }
}