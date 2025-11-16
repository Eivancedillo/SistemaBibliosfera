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
            this.LblBiblioSfera = new System.Windows.Forms.ToolStripLabel();
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
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(976, 590);
            this.ControlBox = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripLabel LblBiblioSfera;
    }
}