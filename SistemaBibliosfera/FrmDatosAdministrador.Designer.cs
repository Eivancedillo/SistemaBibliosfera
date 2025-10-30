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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.CmbAccesos = new System.Windows.Forms.ComboBox();
            this.RbtnVer = new System.Windows.Forms.RadioButton();
            this.RbtnCrear = new System.Windows.Forms.RadioButton();
            this.RbtnEditar = new System.Windows.Forms.RadioButton();
            this.RbtnEliminar = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.LsbAccesos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Accesos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Permisos";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(366, 405);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(99, 39);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(501, 405);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 39);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(53, 146);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(224, 26);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(354, 146);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(222, 26);
            this.TxtContraseña.TabIndex = 7;
            // 
            // CmbAccesos
            // 
            this.CmbAccesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAccesos.FormattingEnabled = true;
            this.CmbAccesos.Items.AddRange(new object[] {
            "Dashboard",
            "Catalogo",
            "Prestamos",
            "Adquisisiones",
            "Bibliotecarios",
            "Miembros"});
            this.CmbAccesos.Location = new System.Drawing.Point(56, 243);
            this.CmbAccesos.Name = "CmbAccesos";
            this.CmbAccesos.Size = new System.Drawing.Size(221, 28);
            this.CmbAccesos.TabIndex = 8;
            this.CmbAccesos.SelectedIndexChanged += new System.EventHandler(this.CmbAccesos_SelectedIndexChanged);
            // 
            // RbtnVer
            // 
            this.RbtnVer.AutoSize = true;
            this.RbtnVer.Location = new System.Drawing.Point(355, 244);
            this.RbtnVer.Name = "RbtnVer";
            this.RbtnVer.Size = new System.Drawing.Size(52, 24);
            this.RbtnVer.TabIndex = 9;
            this.RbtnVer.TabStop = true;
            this.RbtnVer.Text = "Ver";
            this.RbtnVer.UseVisualStyleBackColor = true;
            // 
            // RbtnCrear
            // 
            this.RbtnCrear.AutoSize = true;
            this.RbtnCrear.Location = new System.Drawing.Point(433, 244);
            this.RbtnCrear.Name = "RbtnCrear";
            this.RbtnCrear.Size = new System.Drawing.Size(66, 24);
            this.RbtnCrear.TabIndex = 10;
            this.RbtnCrear.TabStop = true;
            this.RbtnCrear.Text = "Crear";
            this.RbtnCrear.UseVisualStyleBackColor = true;
            // 
            // RbtnEditar
            // 
            this.RbtnEditar.AutoSize = true;
            this.RbtnEditar.Location = new System.Drawing.Point(525, 244);
            this.RbtnEditar.Name = "RbtnEditar";
            this.RbtnEditar.Size = new System.Drawing.Size(69, 24);
            this.RbtnEditar.TabIndex = 11;
            this.RbtnEditar.TabStop = true;
            this.RbtnEditar.Text = "Editar";
            this.RbtnEditar.UseVisualStyleBackColor = true;
            // 
            // RbtnEliminar
            // 
            this.RbtnEliminar.AutoSize = true;
            this.RbtnEliminar.Location = new System.Drawing.Point(613, 244);
            this.RbtnEliminar.Name = "RbtnEliminar";
            this.RbtnEliminar.Size = new System.Drawing.Size(83, 24);
            this.RbtnEliminar.TabIndex = 12;
            this.RbtnEliminar.TabStop = true;
            this.RbtnEliminar.Text = "Eliminar";
            this.RbtnEliminar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Datos del bibliotecario";
            // 
            // LsbAccesos
            // 
            this.LsbAccesos.FormattingEnabled = true;
            this.LsbAccesos.ItemHeight = 20;
            this.LsbAccesos.Location = new System.Drawing.Point(59, 308);
            this.LsbAccesos.Name = "LsbAccesos";
            this.LsbAccesos.Size = new System.Drawing.Size(217, 224);
            this.LsbAccesos.TabIndex = 14;
            // 
            // FrmDatosAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(745, 563);
            this.Controls.Add(this.LsbAccesos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RbtnEliminar);
            this.Controls.Add(this.RbtnEditar);
            this.Controls.Add(this.RbtnCrear);
            this.Controls.Add(this.RbtnVer);
            this.Controls.Add(this.CmbAccesos);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.ComboBox CmbAccesos;
        private System.Windows.Forms.RadioButton RbtnVer;
        private System.Windows.Forms.RadioButton RbtnCrear;
        private System.Windows.Forms.RadioButton RbtnEditar;
        private System.Windows.Forms.RadioButton RbtnEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LsbAccesos;
    }
}