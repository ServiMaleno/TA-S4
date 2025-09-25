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
            this.label1.Location = new System.Drawing.Point(111, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Álbumes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Canciones";
            // 
            // lboxAlbumes
            // 
            this.lboxAlbumes.FormattingEnabled = true;
            this.lboxAlbumes.ItemHeight = 16;
            this.lboxAlbumes.Location = new System.Drawing.Point(65, 116);
            this.lboxAlbumes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lboxAlbumes.Name = "lboxAlbumes";
            this.lboxAlbumes.Size = new System.Drawing.Size(159, 116);
            this.lboxAlbumes.TabIndex = 2;
            this.lboxAlbumes.SelectedIndexChanged += new System.EventHandler(this.lboxAlbumes_SelectedIndexChanged);
            // 
            // lboxCanciones
            // 
            this.lboxCanciones.FormattingEnabled = true;
            this.lboxCanciones.ItemHeight = 16;
            this.lboxCanciones.Location = new System.Drawing.Point(317, 116);
            this.lboxCanciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lboxCanciones.Name = "lboxCanciones";
            this.lboxCanciones.Size = new System.Drawing.Size(159, 116);
            this.lboxCanciones.TabIndex = 3;
            this.lboxCanciones.SelectedIndexChanged += new System.EventHandler(this.lboxCanciones_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(220, 277);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListarCancionesDeUnAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 337);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lboxCanciones);
            this.Controls.Add(this.lboxAlbumes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListarCancionesDeUnAlbum";
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