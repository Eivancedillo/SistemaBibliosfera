namespace SistemaBibliosfera
{
    partial class FrmDatosAdministrador
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
            this.BtnEditar = new System.Windows.Forms.Button();
            this.CbActivar = new System.Windows.Forms.CheckBox();
            this.CbEditar = new System.Windows.Forms.CheckBox();
            this.CbCrear = new System.Windows.Forms.CheckBox();
            this.CbVer = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbAccesos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(408, 132);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(92, 33);
            this.BtnEditar.TabIndex = 65;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // CbActivar
            // 
            this.CbActivar.AutoSize = true;
            this.CbActivar.Enabled = false;
            this.CbActivar.Location = new System.Drawing.Point(368, 189);
            this.CbActivar.Name = "CbActivar";
            this.CbActivar.Size = new System.Drawing.Size(192, 29);
            this.CbActivar.TabIndex = 64;
            this.CbActivar.Text = "Activar/Desactivar";
            this.CbActivar.UseVisualStyleBackColor = true;
            this.CbActivar.CheckedChanged += new System.EventHandler(this.CbActivar_CheckedChanged);
            // 
            // CbEditar
            // 
            this.CbEditar.AutoSize = true;
            this.CbEditar.Enabled = false;
            this.CbEditar.Location = new System.Drawing.Point(278, 189);
            this.CbEditar.Name = "CbEditar";
            this.CbEditar.Size = new System.Drawing.Size(84, 29);
            this.CbEditar.TabIndex = 63;
            this.CbEditar.Text = "Editar";
            this.CbEditar.UseVisualStyleBackColor = true;
            this.CbEditar.CheckedChanged += new System.EventHandler(this.CbEditar_CheckedChanged);
            // 
            // CbCrear
            // 
            this.CbCrear.AutoSize = true;
            this.CbCrear.Enabled = false;
            this.CbCrear.Location = new System.Drawing.Point(189, 189);
            this.CbCrear.Name = "CbCrear";
            this.CbCrear.Size = new System.Drawing.Size(83, 29);
            this.CbCrear.TabIndex = 62;
            this.CbCrear.Text = "Crear";
            this.CbCrear.UseVisualStyleBackColor = true;
            this.CbCrear.CheckedChanged += new System.EventHandler(this.CbCrear_CheckedChanged);
            // 
            // CbVer
            // 
            this.CbVer.AutoSize = true;
            this.CbVer.Enabled = false;
            this.CbVer.Location = new System.Drawing.Point(118, 189);
            this.CbVer.Name = "CbVer";
            this.CbVer.Size = new System.Drawing.Size(65, 29);
            this.CbVer.TabIndex = 61;
            this.CbVer.Text = "Ver";
            this.CbVer.UseVisualStyleBackColor = true;
            this.CbVer.CheckedChanged += new System.EventHandler(this.CbVer_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Permisos";
            // 
            // CmbAccesos
            // 
            this.CmbAccesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAccesos.Enabled = false;
            this.CmbAccesos.FormattingEnabled = true;
            this.CmbAccesos.Location = new System.Drawing.Point(118, 133);
            this.CmbAccesos.Name = "CmbAccesos";
            this.CmbAccesos.Size = new System.Drawing.Size(199, 33);
            this.CmbAccesos.TabIndex = 59;
            this.CmbAccesos.SelectedIndexChanged += new System.EventHandler(this.CmbAccesos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Accesos";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(288, 244);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(166, 49);
            this.BtnCancelar.TabIndex = 57;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(82, 244);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(166, 49);
            this.BtnGuardar.TabIndex = 56;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(132, 80);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(441, 30);
            this.TxtContraseña.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Contraseña";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(132, 26);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(441, 30);
            this.TxtNombre.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nombre";
            // 
            // FrmDatosAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(585, 303);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.CbActivar);
            this.Controls.Add(this.CbEditar);
            this.Controls.Add(this.CbCrear);
            this.Controls.Add(this.CbVer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbAccesos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDatosAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatosAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.CheckBox CbActivar;
        private System.Windows.Forms.CheckBox CbEditar;
        private System.Windows.Forms.CheckBox CbCrear;
        private System.Windows.Forms.CheckBox CbVer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbAccesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
    }
}