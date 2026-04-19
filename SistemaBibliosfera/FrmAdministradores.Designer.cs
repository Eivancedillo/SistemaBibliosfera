namespace SistemaBibliosfera
{
    partial class FrmAdministradores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministradores));
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.DtgDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgDatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDatos.GridColor = System.Drawing.Color.DarkGray;
            this.DtgDatos.Location = new System.Drawing.Point(18, 162);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.Size = new System.Drawing.Size(616, 194);
            this.DtgDatos.TabIndex = 3;
            this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
            this.DtgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellContentClick);
            this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TxtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.TxtUsuario.Location = new System.Drawing.Point(18, 112);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(365, 33);
            this.TxtUsuario.TabIndex = 4;
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(389, 110);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(160, 36);
            this.CmbEstado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(97, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 37);
            this.label3.TabIndex = 43;
            this.label3.Text = "Buscar Bibliotecarios";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.BtnGuardar.Location = new System.Drawing.Point(523, 363);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(111, 47);
            this.BtnGuardar.TabIndex = 47;
            this.BtnGuardar.Text = "Aceptar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(99, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 28);
            this.label7.TabIndex = 73;
            this.label7.Text = "Nombre de usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(18, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 65);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.BtnAgregar.BackgroundImage = global::SistemaBibliosfera.Properties.Resources.Añadir_60;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(594, 109);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(40, 35);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.BtnBuscar.BackgroundImage = global::SistemaBibliosfera.Properties.Resources.Busqueda;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(555, 109);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(33, 36);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(7, 87);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(643, 5);
            this.textBox2.TabIndex = 99;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(7, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(643, 5);
            this.textBox1.TabIndex = 98;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.panel1.Location = new System.Drawing.Point(7, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 46);
            this.panel1.TabIndex = 100;
            // 
            // FrmAdministradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(657, 423);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdministradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministradores";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.ComboBox CmbEstado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}