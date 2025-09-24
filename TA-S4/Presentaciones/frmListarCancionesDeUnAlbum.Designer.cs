namespace TA_S4.Presentaciones
{
    partial class frmListarCancionesDeUnAlbum
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
            this.lboxAlbumes = new System.Windows.Forms.ListBox();
            this.lboxCanciones = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(83, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Álbumes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Canciones";
            // 
            // lboxAlbumes
            // 
            this.lboxAlbumes.FormattingEnabled = true;
            this.lboxAlbumes.Location = new System.Drawing.Point(49, 94);
            this.lboxAlbumes.Name = "lboxAlbumes";
            this.lboxAlbumes.Size = new System.Drawing.Size(120, 95);
            this.lboxAlbumes.TabIndex = 2;
            this.lboxAlbumes.SelectedIndexChanged += new System.EventHandler(this.lboxAlbumes_SelectedIndexChanged);
            // 
            // lboxCanciones
            // 
            this.lboxCanciones.FormattingEnabled = true;
            this.lboxCanciones.Location = new System.Drawing.Point(238, 94);
            this.lboxCanciones.Name = "lboxCanciones";
            this.lboxCanciones.Size = new System.Drawing.Size(120, 95);
            this.lboxCanciones.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(165, 225);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ListarCancionesDeUnAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 274);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lboxCanciones);
            this.Controls.Add(this.lboxAlbumes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListarCancionesDeUnAlbum";
            this.Text = "ListarCancionesDeUnAlbum";
            this.Load += new System.EventHandler(this.ListarCancionesDeUnAlbum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxAlbumes;
        private System.Windows.Forms.ListBox lboxCanciones;
        private System.Windows.Forms.Button btnSalir;
    }
}