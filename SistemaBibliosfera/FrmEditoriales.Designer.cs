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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditoriales));
			this.label1 = new System.Windows.Forms.Label();
			this.CmbEstado = new System.Windows.Forms.ComboBox();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.DtgDatos = new System.Windows.Forms.DataGridView();
			this.BtnAgregar = new System.Windows.Forms.Button();
			this.BtnBuscar = new System.Windows.Forms.Button();
			this.TxtBuscar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
			this.label1.Location = new System.Drawing.Point(34, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 30);
			this.label1.TabIndex = 41;
			this.label1.Text = "Agregar Editoriales\r\n";
			// 
			// CmbEstado
			// 
			this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbEstado.FormattingEnabled = true;
			this.CmbEstado.Location = new System.Drawing.Point(525, 63);
			this.CmbEstado.Margin = new System.Windows.Forms.Padding(4);
			this.CmbEstado.Name = "CmbEstado";
			this.CmbEstado.Size = new System.Drawing.Size(177, 29);
			this.CmbEstado.TabIndex = 40;
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(102)))));
			this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
			this.BtnGuardar.Location = new System.Drawing.Point(702, 319);
			this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(111, 29);
			this.BtnGuardar.TabIndex = 39;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.UseVisualStyleBackColor = false;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
			// 
			// DtgDatos
			// 
			this.DtgDatos.AllowUserToAddRows = false;
			this.DtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
			this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DtgDatos.Location = new System.Drawing.Point(17, 111);
			this.DtgDatos.Margin = new System.Windows.Forms.Padding(4);
			this.DtgDatos.Name = "DtgDatos";
			this.DtgDatos.RowHeadersWidth = 51;
			this.DtgDatos.Size = new System.Drawing.Size(796, 194);
			this.DtgDatos.TabIndex = 38;
			this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
			this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
			// 
			// BtnAgregar
			// 
			this.BtnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.BackgroundImage")));
			this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnAgregar.Location = new System.Drawing.Point(469, 53);
			this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
			this.BtnAgregar.Name = "BtnAgregar";
			this.BtnAgregar.Size = new System.Drawing.Size(48, 46);
			this.BtnAgregar.TabIndex = 37;
			this.BtnAgregar.UseVisualStyleBackColor = true;
			this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
			// 
			// BtnBuscar
			// 
			this.BtnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.BackgroundImage")));
			this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnBuscar.Location = new System.Drawing.Point(403, 60);
			this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.BtnBuscar.Name = "BtnBuscar";
			this.BtnBuscar.Size = new System.Drawing.Size(47, 33);
			this.BtnBuscar.TabIndex = 36;
			this.BtnBuscar.UseVisualStyleBackColor = true;
			this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
			// 
			// TxtBuscar
			// 
			this.TxtBuscar.Location = new System.Drawing.Point(30, 64);
			this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.TxtBuscar.Name = "TxtBuscar";
			this.TxtBuscar.Size = new System.Drawing.Size(365, 29);
			this.TxtBuscar.TabIndex = 35;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(440, 309);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(10, 42);
			this.label2.TabIndex = 42;
			this.label2.Text = "\r\n\r\n";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(102)))));
			this.pictureBox1.Location = new System.Drawing.Point(18, 54);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(444, 50);
			this.pictureBox1.TabIndex = 43;
			this.pictureBox1.TabStop = false;
			// 
			// FrmEditoriales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(829, 360);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CmbEstado);
			this.Controls.Add(this.BtnGuardar);
			this.Controls.Add(this.DtgDatos);
			this.Controls.Add(this.BtnAgregar);
			this.Controls.Add(this.BtnBuscar);
			this.Controls.Add(this.TxtBuscar);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmEditoriales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmEditoriales";
			((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}