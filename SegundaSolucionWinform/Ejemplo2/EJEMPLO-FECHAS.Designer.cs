namespace Ejemplo2
{
    partial class EJEMPLO_FECHAS
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
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.prb1 = new System.Windows.Forms.Button();
            this.calfecha = new System.Windows.Forms.MonthCalendar();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpfecha
            // 
            this.dtpfecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpfecha.Location = new System.Drawing.Point(130, 184);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(290, 20);
            this.dtpfecha.TabIndex = 0;
            // 
            // prb1
            // 
            this.prb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prb1.Location = new System.Drawing.Point(496, 176);
            this.prb1.Name = "prb1";
            this.prb1.Size = new System.Drawing.Size(96, 41);
            this.prb1.TabIndex = 1;
            this.prb1.Text = "Prueba 1";
            this.prb1.UseVisualStyleBackColor = true;
            this.prb1.Click += new System.EventHandler(this.prb1_Click);
            // 
            // calfecha
            // 
            this.calfecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calfecha.Location = new System.Drawing.Point(100, 291);
            this.calfecha.Name = "calfecha";
            this.calfecha.TabIndex = 2;
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.Location = new System.Drawing.Point(496, 398);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(96, 47);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Prueba 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(218, 44);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(430, 52);
            this.lbltitulo.TabIndex = 4;
            this.lbltitulo.Text = "EJEMPLO FECHAS";
            // 
            // EJEMPLO_FECHAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 605);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.calfecha);
            this.Controls.Add(this.prb1);
            this.Controls.Add(this.dtpfecha);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(882, 661);
            this.Name = "EJEMPLO_FECHAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EJEMPLO_FECHAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Button prb1;
        private System.Windows.Forms.MonthCalendar calfecha;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbltitulo;
    }
}