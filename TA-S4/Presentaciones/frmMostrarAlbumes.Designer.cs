namespace TA_S4.Presentaciones
{
    partial class frmMostrarAlbumes
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
            this.lboxAlbumes = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Albumes";
            // 
            // lboxAlbumes
            // 
            this.lboxAlbumes.FormattingEnabled = true;
            this.lboxAlbumes.ItemHeight = 16;
            this.lboxAlbumes.Location = new System.Drawing.Point(47, 64);
            this.lboxAlbumes.Name = "lboxAlbumes";
            this.lboxAlbumes.Size = new System.Drawing.Size(120, 84);
            this.lboxAlbumes.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(63, 167);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 30);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMostrarAlbumes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(216, 220);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lboxAlbumes);
            this.Controls.Add(this.label1);
            this.Name = "frmMostrarAlbumes";
            this.Text = "Mostrar Albumes";
            this.Load += new System.EventHandler(this.frmMostrarAlbumes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxAlbumes;
        private System.Windows.Forms.Button btnSalir;
    }
}