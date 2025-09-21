namespace TA_S4.Presentaciones
{
    partial class frmRegistroAlbum
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
            this.tbCodigoAlbum = new System.Windows.Forms.TextBox();
            this.tbNombreAlbum = new System.Windows.Forms.TextBox();
            this.btnRegistrarAlbum = new System.Windows.Forms.Button();
            this.btnMostrarAlbum = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código del Album:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Album:";
            // 
            // tbCodigoAlbum
            // 
            this.tbCodigoAlbum.Location = new System.Drawing.Point(210, 35);
            this.tbCodigoAlbum.Name = "tbCodigoAlbum";
            this.tbCodigoAlbum.Size = new System.Drawing.Size(132, 22);
            this.tbCodigoAlbum.TabIndex = 2;
            // 
            // tbNombreAlbum
            // 
            this.tbNombreAlbum.Location = new System.Drawing.Point(210, 80);
            this.tbNombreAlbum.Name = "tbNombreAlbum";
            this.tbNombreAlbum.Size = new System.Drawing.Size(132, 22);
            this.tbNombreAlbum.TabIndex = 3;
            // 
            // btnRegistrarAlbum
            // 
            this.btnRegistrarAlbum.Location = new System.Drawing.Point(52, 133);
            this.btnRegistrarAlbum.Name = "btnRegistrarAlbum";
            this.btnRegistrarAlbum.Size = new System.Drawing.Size(86, 26);
            this.btnRegistrarAlbum.TabIndex = 4;
            this.btnRegistrarAlbum.Text = "Registrar";
            this.btnRegistrarAlbum.UseVisualStyleBackColor = true;
            this.btnRegistrarAlbum.Click += new System.EventHandler(this.btnRegistrarAlbum_Click);
            // 
            // btnMostrarAlbum
            // 
            this.btnMostrarAlbum.Location = new System.Drawing.Point(158, 133);
            this.btnMostrarAlbum.Name = "btnMostrarAlbum";
            this.btnMostrarAlbum.Size = new System.Drawing.Size(86, 26);
            this.btnMostrarAlbum.TabIndex = 5;
            this.btnMostrarAlbum.Text = "Mostrar";
            this.btnMostrarAlbum.UseVisualStyleBackColor = true;
            this.btnMostrarAlbum.Click += new System.EventHandler(this.btnMostrarAlbum_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(264, 133);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 26);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRegistroAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 185);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarAlbum);
            this.Controls.Add(this.btnRegistrarAlbum);
            this.Controls.Add(this.tbNombreAlbum);
            this.Controls.Add(this.tbCodigoAlbum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistroAlbum";
            this.Text = "Registro de Album";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigoAlbum;
        private System.Windows.Forms.TextBox tbNombreAlbum;
        private System.Windows.Forms.Button btnRegistrarAlbum;
        private System.Windows.Forms.Button btnMostrarAlbum;
        private System.Windows.Forms.Button btnSalir;
    }
}