namespace TA_S4
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCanciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarLasCancionesDeUnÁlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerElÁlbumConMásCancionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarLosAlbumesDondeSeEncuentraUnaCanciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerElNombreDeLaCanciónConMayorYMenorDuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeAlbumToolStripMenuItem,
            this.registroDeCanciónToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroDeAlbumToolStripMenuItem
            // 
            this.registroDeAlbumToolStripMenuItem.Name = "registroDeAlbumToolStripMenuItem";
            this.registroDeAlbumToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.registroDeAlbumToolStripMenuItem.Text = "Registro de Album";
            this.registroDeAlbumToolStripMenuItem.Click += new System.EventHandler(this.registroDeAlbumToolStripMenuItem_Click);
            // 
            // registroDeCanciónToolStripMenuItem
            // 
            this.registroDeCanciónToolStripMenuItem.Name = "registroDeCanciónToolStripMenuItem";
            this.registroDeCanciónToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.registroDeCanciónToolStripMenuItem.Text = "Registro de Canción";
            this.registroDeCanciónToolStripMenuItem.Click += new System.EventHandler(this.registroDeCanciónToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarLasCancionesDeUnÁlbumToolStripMenuItem,
            this.obtenerElÁlbumConMásCancionesToolStripMenuItem,
            this.listarLosAlbumesDondeSeEncuentraUnaCanciónToolStripMenuItem,
            this.obtenerElNombreDeLaCanciónConMayorYMenorDuraciónToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listarLasCancionesDeUnÁlbumToolStripMenuItem
            // 
            this.listarLasCancionesDeUnÁlbumToolStripMenuItem.Name = "listarLasCancionesDeUnÁlbumToolStripMenuItem";
            this.listarLasCancionesDeUnÁlbumToolStripMenuItem.Size = new System.Drawing.Size(504, 26);
            this.listarLasCancionesDeUnÁlbumToolStripMenuItem.Text = "Listar las canciones de un álbum";
            this.listarLasCancionesDeUnÁlbumToolStripMenuItem.Click += new System.EventHandler(this.listarLasCancionesDeUnÁlbumToolStripMenuItem_Click);
            // 
            // obtenerElÁlbumConMásCancionesToolStripMenuItem
            // 
            this.obtenerElÁlbumConMásCancionesToolStripMenuItem.Name = "obtenerElÁlbumConMásCancionesToolStripMenuItem";
            this.obtenerElÁlbumConMásCancionesToolStripMenuItem.Size = new System.Drawing.Size(504, 26);
            this.obtenerElÁlbumConMásCancionesToolStripMenuItem.Text = "Obtener el álbum con más canciones";
            this.obtenerElÁlbumConMásCancionesToolStripMenuItem.Click += new System.EventHandler(this.obtenerElÁlbumConMásCancionesToolStripMenuItem_Click);
            // 
            // listarLosAlbumesDondeSeEncuentraUnaCanciónToolStripMenuItem
            // 
            this.listarLosAlbumesDondeSeEncuentraUnaCanciónToolStripMenuItem.Name = "listarLosAlbumesDondeSeEncuentraUnaCanciónToolStripMenuItem";
            this.listarLosAlbumesDondeSeEncuentraUnaCanciónToolStripMenuItem.Size = new System.Drawing.Size(504, 26);
            this.listarLosAlbumesDondeSeEncuentraUnaCanciónToolStripMenuItem.Text = "Listar los albumes donde se encuentra una canción";
            // 
            // obtenerElNombreDeLaCanciónConMayorYMenorDuraciónToolStripMenuItem
            // 
            this.obtenerElNombreDeLaCanciónConMayorYMenorDuraciónToolStripMenuItem.Name = "obtenerElNombreDeLaCanciónConMayorYMenorDuraciónToolStripMenuItem";
            this.obtenerElNombreDeLaCanciónConMayorYMenorDuraciónToolStripMenuItem.Size = new System.Drawing.Size(504, 26);
            this.obtenerElNombreDeLaCanciónConMayorYMenorDuraciónToolStripMenuItem.Text = "Obtener el nombre de la canción con mayor y menor duración";
            this.obtenerElNombreDeLaCanciónConMayorYMenorDuraciónToolStripMenuItem.Click += new System.EventHandler(this.obtenerElNombreDeLaCanciónConMayorYMenorDuraciónToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menú Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCanciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarLasCancionesDeUnÁlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerElÁlbumConMásCancionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarLosAlbumesDondeSeEncuentraUnaCanciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerElNombreDeLaCanciónConMayorYMenorDuraciónToolStripMenuItem;
    }
}

