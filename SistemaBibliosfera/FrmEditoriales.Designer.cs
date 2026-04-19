namespace SistemaBibliosfera
{
    partial class FrmEditoriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditoriales));
            this.label1 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnAgregarr = new System.Windows.Forms.Button();
            this.BtnBuscarr = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 37);
            this.label1.TabIndex = 41;
            this.label1.Text = "Agregar Editoriales\r\n";
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(390, 79);
            this.CmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(160, 36);
            this.CmbEstado.TabIndex = 40;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.BtnGuardar.Location = new System.Drawing.Point(521, 325);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(111, 43);
            this.BtnGuardar.TabIndex = 39;
            this.BtnGuardar.Text = "Aceptar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.DtgDatos.Location = new System.Drawing.Point(17, 123);
            this.DtgDatos.Margin = new System.Windows.Forms.Padding(4);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.Size = new System.Drawing.Size(616, 194);
            this.DtgDatos.TabIndex = 38;
            this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
            this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(17, 81);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(365, 34);
            this.TxtBuscar.TabIndex = 35;
            // 
            // BtnAgregarr
            // 
            this.BtnAgregarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.BtnAgregarr.BackgroundImage = global::SistemaBibliosfera.Properties.Resources.Añadir_60;
            this.BtnAgregarr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarr.FlatAppearance.BorderSize = 0;
            this.BtnAgregarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarr.Location = new System.Drawing.Point(593, 79);
            this.BtnAgregarr.Name = "BtnAgregarr";
            this.BtnAgregarr.Size = new System.Drawing.Size(40, 35);
            this.BtnAgregarr.TabIndex = 79;
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
            this.BtnBuscarr.Location = new System.Drawing.Point(554, 79);
            this.BtnBuscarr.Name = "BtnBuscarr";
            this.BtnBuscarr.Size = new System.Drawing.Size(33, 36);
            this.BtnBuscarr.TabIndex = 78;
            this.BtnBuscarr.UseVisualStyleBackColor = false;
            this.BtnBuscarr.Click += new System.EventHandler(this.BtnBuscarr_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(14, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 28);
            this.label7.TabIndex = 80;
            this.label7.Text = "Nombre de editorial";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(2, 60);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(643, 5);
            this.textBox3.TabIndex = 101;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(102)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(2, 53);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(643, 5);
            this.textBox4.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.panel1.Location = new System.Drawing.Point(-1, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 46);
            this.panel1.TabIndex = 102;
            // 
            // FrmEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(645, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.BtnAgregarr);
            this.Controls.Add(this.BtnBuscarr);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEditoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditoriales";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnAgregarr;
        private System.Windows.Forms.Button BtnBuscarr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
    }
}