namespace SistemaBibliosfera
{
    partial class FrmPrincipal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnDashboard = new System.Windows.Forms.ToolStripButton();
            this.BtnCatalogo = new System.Windows.Forms.ToolStripButton();
            this.BtnPrestamos = new System.Windows.Forms.ToolStripButton();
            this.BtnAdquisiciones = new System.Windows.Forms.ToolStripButton();
            this.BtnMiembros = new System.Windows.Forms.ToolStripButton();
            this.BtnBibliotecarios = new System.Windows.Forms.ToolStripButton();
            this.BtnAsistencias = new System.Windows.Forms.ToolStripButton();
            this.BtnSalir = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnDashboard,
            this.BtnCatalogo,
            this.BtnPrestamos,
            this.BtnAdquisiciones,
            this.BtnMiembros,
            this.BtnBibliotecarios,
            this.BtnAsistencias,
            this.BtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(177, 590);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.AutoSize = false;
            this.BtnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(175, 64);
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnCatalogo
            // 
            this.BtnCatalogo.AutoSize = false;
            this.BtnCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCatalogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCatalogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCatalogo.Name = "BtnCatalogo";
            this.BtnCatalogo.Size = new System.Drawing.Size(175, 64);
            this.BtnCatalogo.Text = "Catalogo";
            this.BtnCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCatalogo.Click += new System.EventHandler(this.BtnCatalogo_Click);
            // 
            // BtnPrestamos
            // 
            this.BtnPrestamos.AutoSize = false;
            this.BtnPrestamos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPrestamos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrestamos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPrestamos.Name = "BtnPrestamos";
            this.BtnPrestamos.Size = new System.Drawing.Size(175, 64);
            this.BtnPrestamos.Text = "Prestamos";
            this.BtnPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrestamos.Click += new System.EventHandler(this.BtnPrestamos_Click);
            // 
            // BtnAdquisiciones
            // 
            this.BtnAdquisiciones.AutoSize = false;
            this.BtnAdquisiciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAdquisiciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAdquisiciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdquisiciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAdquisiciones.Name = "BtnAdquisiciones";
            this.BtnAdquisiciones.Size = new System.Drawing.Size(175, 64);
            this.BtnAdquisiciones.Text = "Adquisiciones";
            this.BtnAdquisiciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdquisiciones.Click += new System.EventHandler(this.BtnAdquisiciones_Click);
            // 
            // BtnMiembros
            // 
            this.BtnMiembros.AutoSize = false;
            this.BtnMiembros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMiembros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMiembros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMiembros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMiembros.Name = "BtnMiembros";
            this.BtnMiembros.Size = new System.Drawing.Size(175, 64);
            this.BtnMiembros.Text = "Miembros";
            this.BtnMiembros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMiembros.Click += new System.EventHandler(this.BtnMiembros_Click);
            // 
            // BtnBibliotecarios
            // 
            this.BtnBibliotecarios.AutoSize = false;
            this.BtnBibliotecarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBibliotecarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnBibliotecarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBibliotecarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBibliotecarios.Name = "BtnBibliotecarios";
            this.BtnBibliotecarios.Size = new System.Drawing.Size(175, 64);
            this.BtnBibliotecarios.Text = "Bibliotecarios";
            this.BtnBibliotecarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBibliotecarios.Click += new System.EventHandler(this.BtnBibliotecarios_Click);
            // 
            // BtnAsistencias
            // 
            this.BtnAsistencias.AutoSize = false;
            this.BtnAsistencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAsistencias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAsistencias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAsistencias.Name = "BtnAsistencias";
            this.BtnAsistencias.Size = new System.Drawing.Size(175, 64);
            this.BtnAsistencias.Text = "Asistencias";
            this.BtnAsistencias.Click += new System.EventHandler(this.BtnAsistencias_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.AutoSize = false;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(175, 64);
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(80, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dashboard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(80, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cátalogo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(80, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Préstamos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label6.Location = new System.Drawing.Point(80, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adquisiciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label7.Location = new System.Drawing.Point(80, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Miembros";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label8.Location = new System.Drawing.Point(80, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bibliotecarios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label9.Location = new System.Drawing.Point(80, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Asistencia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label10.Location = new System.Drawing.Point(80, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Salir";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(976, 590);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnDashboard;
        private System.Windows.Forms.ToolStripButton BtnCatalogo;
        private System.Windows.Forms.ToolStripButton BtnPrestamos;
        private System.Windows.Forms.ToolStripButton BtnAdquisiciones;
        private System.Windows.Forms.ToolStripButton BtnMiembros;
        private System.Windows.Forms.ToolStripButton BtnBibliotecarios;
        private System.Windows.Forms.ToolStripButton BtnAsistencias;
        private System.Windows.Forms.ToolStripButton BtnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}