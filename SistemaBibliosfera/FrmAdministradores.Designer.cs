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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministradores));
			this.BtnBuscar = new System.Windows.Forms.Button();
			this.BtnAgregar = new System.Windows.Forms.Button();
			this.DtgDatos = new System.Windows.Forms.DataGridView();
			this.TxtUsuario = new System.Windows.Forms.TextBox();
			this.CmbEstado = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BtnGuardar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnBuscar
			// 
			this.BtnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.BackgroundImage")));
			this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnBuscar.Location = new System.Drawing.Point(403, 60);
			this.BtnBuscar.Name = "BtnBuscar";
			this.BtnBuscar.Size = new System.Drawing.Size(47, 33);
			this.BtnBuscar.TabIndex = 1;
			this.BtnBuscar.UseVisualStyleBackColor = true;
			this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
			// 
			// BtnAgregar
			// 
			this.BtnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.BackgroundImage")));
			this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnAgregar.Location = new System.Drawing.Point(469, 53);
			this.BtnAgregar.Name = "BtnAgregar";
			this.BtnAgregar.Size = new System.Drawing.Size(48, 46);
			this.BtnAgregar.TabIndex = 2;
			this.BtnAgregar.UseVisualStyleBackColor = true;
			this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
			// 
			// DtgDatos
			// 
			this.DtgDatos.AllowUserToAddRows = false;
			this.DtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
			this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DtgDatos.Location = new System.Drawing.Point(17, 111);
			this.DtgDatos.Name = "DtgDatos";
			this.DtgDatos.RowHeadersWidth = 51;
			this.DtgDatos.Size = new System.Drawing.Size(796, 194);
			this.DtgDatos.TabIndex = 3;
			this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
			this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
			// 
			// TxtUsuario
			// 
			this.TxtUsuario.Location = new System.Drawing.Point(30, 64);
			this.TxtUsuario.Multiline = true;
			this.TxtUsuario.Name = "TxtUsuario";
			this.TxtUsuario.Size = new System.Drawing.Size(365, 29);
			this.TxtUsuario.TabIndex = 4;
			// 
			// CmbEstado
			// 
			this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbEstado.FormattingEnabled = true;
			this.CmbEstado.Location = new System.Drawing.Point(525, 63);
			this.CmbEstado.Name = "CmbEstado";
			this.CmbEstado.Size = new System.Drawing.Size(160, 28);
			this.CmbEstado.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
			this.label3.Location = new System.Drawing.Point(34, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 30);
			this.label3.TabIndex = 43;
			this.label3.Text = "Buscar Bibliotecarios";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(102)))));
			this.pictureBox1.Location = new System.Drawing.Point(18, 54);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(444, 50);
			this.pictureBox1.TabIndex = 46;
			this.pictureBox1.TabStop = false;
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(102)))));
			this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
			this.BtnGuardar.Location = new System.Drawing.Point(702, 319);
			this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(111, 29);
			this.BtnGuardar.TabIndex = 47;
			this.BtnGuardar.Text = "Aceptar";
			this.BtnGuardar.UseVisualStyleBackColor = false;
			// 
			// FrmAdministradores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(829, 360);
			this.Controls.Add(this.BtnGuardar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CmbEstado);
			this.Controls.Add(this.TxtUsuario);
			this.Controls.Add(this.DtgDatos);
			this.Controls.Add(this.BtnAgregar);
			this.Controls.Add(this.BtnBuscar);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmAdministradores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAdministradores";
			((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BtnGuardar;
	}
}