namespace SistemaBibliosfera
{
    partial class FrmPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamos));
            this.label1 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAgregarr = new System.Windows.Forms.Button();
            this.BtnBuscarr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(27, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 50);
            this.label1.TabIndex = 31;
            this.label1.Text = "Préstamos";
            // 
            // CmbEstado
            // 
            this.CmbEstado.BackColor = System.Drawing.Color.White;
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(10, 5);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(175, 36);
            this.CmbEstado.TabIndex = 30;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscar.Location = new System.Drawing.Point(236, 61);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(727, 34);
            this.TxtBuscar.TabIndex = 27;
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.DtgDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgDatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDatos.GridColor = System.Drawing.Color.DarkGray;
            this.DtgDatos.Location = new System.Drawing.Point(41, 110);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.Size = new System.Drawing.Size(1026, 285);
            this.DtgDatos.TabIndex = 26;
            this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
            this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.BtnCerrar.Location = new System.Drawing.Point(941, 404);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(126, 42);
            this.BtnCerrar.TabIndex = 32;
            this.BtnCerrar.Text = "Aceptar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(-5, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1106, 20);
            this.label6.TabIndex = 91;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.label11.Location = new System.Drawing.Point(-5, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1106, 10);
            this.label11.TabIndex = 93;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.CmbEstado);
            this.panel1.Location = new System.Drawing.Point(40, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 46);
            this.panel1.TabIndex = 94;
            // 
            // BtnAgregarr
            // 
            this.BtnAgregarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.BtnAgregarr.BackgroundImage = global::SistemaBibliosfera.Properties.Resources.Añadir_60;
            this.BtnAgregarr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarr.FlatAppearance.BorderSize = 0;
            this.BtnAgregarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarr.Location = new System.Drawing.Point(1016, 57);
            this.BtnAgregarr.Name = "BtnAgregarr";
            this.BtnAgregarr.Size = new System.Drawing.Size(42, 43);
            this.BtnAgregarr.TabIndex = 78;
            this.BtnAgregarr.UseVisualStyleBackColor = false;
            this.BtnAgregarr.Click += new System.EventHandler(this.BtnAgregarr_Click);
            // 
            // BtnBuscarr
            // 
            this.BtnBuscarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.BtnBuscarr.BackgroundImage = global::SistemaBibliosfera.Properties.Resources.Busqueda;
            this.BtnBuscarr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarr.FlatAppearance.BorderSize = 0;
            this.BtnBuscarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarr.Location = new System.Drawing.Point(969, 57);
            this.BtnBuscarr.Name = "BtnBuscarr";
            this.BtnBuscarr.Size = new System.Drawing.Size(42, 43);
            this.BtnBuscarr.TabIndex = 77;
            this.BtnBuscarr.UseVisualStyleBackColor = false;
            this.BtnBuscarr.Click += new System.EventHandler(this.BtnBuscarr_Click);
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1101, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnAgregarr);
            this.Controls.Add(this.BtnBuscarr);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPestamos";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregarr;
        private System.Windows.Forms.Button BtnBuscarr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
    }
}