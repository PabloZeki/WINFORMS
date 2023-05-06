namespace Ejemplo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsaludar = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.chkApellido = new System.Windows.Forms.CheckBox();
            this.lblmostrarapellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.chkDni = new System.Windows.Forms.CheckBox();
            this.lblMostrardni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsaludar
            // 
            this.btnsaludar.Location = new System.Drawing.Point(310, 32);
            this.btnsaludar.Name = "btnsaludar";
            this.btnsaludar.Size = new System.Drawing.Size(76, 21);
            this.btnsaludar.TabIndex = 0;
            this.btnsaludar.Text = "Saludar";
            this.btnsaludar.UseVisualStyleBackColor = true;
            this.btnsaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(392, 39);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 13);
            this.lblSaludo.TabIndex = 1;
            this.lblSaludo.Click += new System.EventHandler(this.Form1_Load);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(204, 32);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(154, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(154, 64);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(204, 64);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 5;
            // 
            // chkApellido
            // 
            this.chkApellido.AutoSize = true;
            this.chkApellido.Location = new System.Drawing.Point(311, 66);
            this.chkApellido.Name = "chkApellido";
            this.chkApellido.Size = new System.Drawing.Size(15, 14);
            this.chkApellido.TabIndex = 6;
            this.chkApellido.UseVisualStyleBackColor = true;
            this.chkApellido.CheckedChanged += new System.EventHandler(this.chkApellido_CheckedChanged);
            // 
            // lblmostrarapellido
            // 
            this.lblmostrarapellido.AutoSize = true;
            this.lblmostrarapellido.Location = new System.Drawing.Point(332, 64);
            this.lblmostrarapellido.Name = "lblmostrarapellido";
            this.lblmostrarapellido.Size = new System.Drawing.Size(0, 13);
            this.lblmostrarapellido.TabIndex = 7;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(164, 94);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "Dni";
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(204, 94);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(100, 20);
            this.textDni.TabIndex = 9;
            // 
            // chkDni
            // 
            this.chkDni.AutoSize = true;
            this.chkDni.Location = new System.Drawing.Point(311, 96);
            this.chkDni.Name = "chkDni";
            this.chkDni.Size = new System.Drawing.Size(15, 14);
            this.chkDni.TabIndex = 10;
            this.chkDni.UseVisualStyleBackColor = true;
            this.chkDni.CheckedChanged += new System.EventHandler(this.chkDni_CheckedChanged);
            // 
            // lblMostrardni
            // 
            this.lblMostrardni.AutoSize = true;
            this.lblMostrardni.Location = new System.Drawing.Point(335, 94);
            this.lblMostrardni.Name = "lblMostrardni";
            this.lblMostrardni.Size = new System.Drawing.Size(0, 13);
            this.lblMostrardni.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 311);
            this.Controls.Add(this.lblMostrardni);
            this.Controls.Add(this.chkDni);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblmostrarapellido);
            this.Controls.Add(this.chkApellido);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.btnsaludar);
            this.Name = "Form1";
            this.Text = "PRIMERA APP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsaludar;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.CheckBox chkApellido;
        private System.Windows.Forms.Label lblmostrarapellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.CheckBox chkDni;
        private System.Windows.Forms.Label lblMostrardni;
    }
}

