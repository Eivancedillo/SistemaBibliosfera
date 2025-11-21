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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.LblBiblioSfera = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnBibliosfera = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDashboard = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCatalogo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnPrestamos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAdquisiciones = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnBibliotecarios = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnMiembros = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAsistencia = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblBiblioSfera
            // 
            this.LblBiblioSfera.AutoSize = false;
            this.LblBiblioSfera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LblBiblioSfera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBiblioSfera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LblBiblioSfera.Name = "LblBiblioSfera";
            this.LblBiblioSfera.Size = new System.Drawing.Size(175, 60);
            this.LblBiblioSfera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnBibliosfera,
            this.toolStripSeparator1,
            this.BtnDashboard,
            this.toolStripSeparator2,
            this.BtnCatalogo,
            this.toolStripSeparator5,
            this.BtnPrestamos,
            this.toolStripSeparator3,
            this.BtnAdquisiciones,
            this.toolStripSeparator4,
            this.BtnBibliotecarios,
            this.toolStripSeparator6,
            this.BtnMiembros,
            this.toolStripSeparator7,
            this.BtnAsistencia,
            this.toolStripSeparator8,
            this.BtnSalir,
            this.toolStripSeparator9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(200, 590);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnBibliosfera
            // 
            this.BtnBibliosfera.AutoSize = false;
            this.BtnBibliosfera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnBibliosfera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBibliosfera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.BtnBibliosfera.Name = "BtnBibliosfera";
            this.BtnBibliosfera.Size = new System.Drawing.Size(200, 60);
            this.BtnBibliosfera.Text = "BiblioSfera";
            this.BtnBibliosfera.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.AutoSize = false;
            this.BtnDashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.BtnDashboard.Image = global::SistemaBibliosfera.Properties.Resources.Clipboard;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(200, 40);
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            this.BtnDashboard.MouseEnter += new System.EventHandler(this.BtnDashboard_MouseEnter);
            this.BtnDashboard.MouseLeave += new System.EventHandler(this.BtnDashboard_MouseLeave);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // BtnCatalogo
            // 
            this.BtnCatalogo.AutoSize = false;
            this.BtnCatalogo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.BtnCatalogo.Image = global::SistemaBibliosfera.Properties.Resources.icons8_cashbook_48;
            this.BtnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCatalogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCatalogo.Name = "BtnCatalogo";
            this.BtnCatalogo.Size = new System.Drawing.Size(200, 40);
            this.BtnCatalogo.Text = "Catálogo";
            this.BtnCatalogo.Click += new System.EventHandler(this.BtnCatalogo_Click);
            this.BtnCatalogo.MouseEnter += new System.EventHandler(this.BtnCatalogo_MouseEnter);
            this.BtnCatalogo.MouseLeave += new System.EventHandler(this.BtnCatalogo_MouseLeave);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(198, 6);
            // 
            // BtnPrestamos
            // 
            this.BtnPrestamos.AutoSize = false;
            this.BtnPrestamos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrestamos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.BtnPrestamos.Image = global::SistemaBibliosfera.Properties.Resources.icons8_libros_64_21;
            this.BtnPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrestamos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPrestamos.Name = "BtnPrestamos";
            this.BtnPrestamos.Size = new System.Drawing.Size(200, 40);
            this.BtnPrestamos.Text = "Préstamos";
            this.BtnPrestamos.Click += new System.EventHandler(this.BtnPrestamos_Click);
            this.BtnPrestamos.MouseEnter += new System.EventHandler(this.BtnPrestamos_MouseEnter);
            this.BtnPrestamos.MouseLeave += new System.EventHandler(this.BtnPrestamos_MouseLeave);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // BtnAdquisiciones
            // 
            this.BtnAdquisiciones.AutoSize = false;
            this.BtnAdquisiciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdquisiciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.BtnAdquisiciones.Image = global::SistemaBibliosfera.Properties.Resources.icons8_libro_de_cuentos_641;
            this.BtnAdquisiciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdquisiciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAdquisiciones.Name = "BtnAdquisiciones";
            this.BtnAdquisiciones.Size = new System.Drawing.Size(200, 40);
            this.BtnAdquisiciones.Text = "Adquisiciones";
            this.BtnAdquisiciones.Click += new System.EventHandler(this.BtnAdquisiciones_Click);
            this.BtnAdquisiciones.MouseEnter += new System.EventHandler(this.BtnAdquisiciones_MouseEnter);
            this.BtnAdquisiciones.MouseLeave += new System.EventHandler(this.BtnAdquisiciones_MouseLeave);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(198, 6);
            // 
            // BtnBibliotecarios
            // 
            this.BtnBibliotecarios.AutoSize = false;
            this.BtnBibliotecarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBibliotecarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.BtnBibliotecarios.Image = global::SistemaBibliosfera.Properties.Resources.icons8_llamada_de_conferencia_60_1;
            this.BtnBibliotecarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBibliotecarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBibliotecarios.Name = "BtnBibliotecarios";
            this.BtnBibliotecarios.Size = new System.Drawing.Size(200, 40);
            this.BtnBibliotecarios.Text = "Miembros";
            this.BtnBibliotecarios.Click += new System.EventHandler(this.BtnBibliotecarios_Click);
            this.BtnBibliotecarios.MouseEnter += new System.EventHandler(this.BtnBibliotecarios_MouseEnter);
            this.BtnBibliotecarios.MouseLeave += new System.EventHandler(this.BtnBibliotecarios_MouseLeave);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(198, 6);
            // 
            // BtnMiembros
            // 
            this.BtnMiembros.AutoSize = false;
            this.BtnMiembros.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMiembros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.BtnMiembros.Image = global::SistemaBibliosfera.Properties.Resources.icons8_administrador_64_1;
            this.BtnMiembros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMiembros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMiembros.Name = "BtnMiembros";
            this.BtnMiembros.Size = new System.Drawing.Size(200, 40);
            this.BtnMiembros.Text = "Bibliotecarios";
            this.BtnMiembros.Click += new System.EventHandler(this.BtnMiembros_Click);
            this.BtnMiembros.MouseEnter += new System.EventHandler(this.BtnMiembros_MouseEnter);
            this.BtnMiembros.MouseLeave += new System.EventHandler(this.BtnMiembros_MouseLeave);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(198, 6);
            // 
            // BtnAsistencia
            // 
            this.BtnAsistencia.AutoSize = false;
            this.BtnAsistencia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.BtnAsistencia.Image = global::SistemaBibliosfera.Properties.Resources.icons8_asistencia_100_1;
            this.BtnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAsistencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAsistencia.Name = "BtnAsistencia";
            this.BtnAsistencia.Size = new System.Drawing.Size(200, 40);
            this.BtnAsistencia.Text = "Asistencia";
            this.BtnAsistencia.Click += new System.EventHandler(this.BtnAsistencia_Click);
            this.BtnAsistencia.MouseEnter += new System.EventHandler(this.BtnAsistencia_MouseEnter);
            this.BtnAsistencia.MouseLeave += new System.EventHandler(this.BtnAsistencia_MouseLeave);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(198, 6);
            // 
            // BtnSalir
            // 
            this.BtnSalir.AutoSize = false;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.BtnSalir.Image = global::SistemaBibliosfera.Properties.Resources.icons8_eliminar_30;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(200, 40);
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.BtnSalir.MouseEnter += new System.EventHandler(this.BtnSalir_MouseEnter);
            this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(198, 6);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(976, 590);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripLabel LblBiblioSfera;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCatalogo;
        private System.Windows.Forms.ToolStripButton BtnPrestamos;
        private System.Windows.Forms.ToolStripButton BtnAdquisiciones;
        private System.Windows.Forms.ToolStripButton BtnMiembros;
        private System.Windows.Forms.ToolStripButton BtnBibliotecarios;
        private System.Windows.Forms.ToolStripButton BtnAsistencia;
        private System.Windows.Forms.ToolStripButton BtnSalir;
        private System.Windows.Forms.ToolStripLabel BtnBibliosfera;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnDashboard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    }
}