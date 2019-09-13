namespace Tarea_3
{
    partial class Principal
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
            this.SuspendLayout();
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaYMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estrellasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiendaToolStripMenuItem,
            this.personaYMascotaToolStripMenuItem,
            this.estrellasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.poligonoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // tiendaToolStripMenuItem
            // 
            this.tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            this.tiendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tiendaToolStripMenuItem.Text = "Tienda";
            this.tiendaToolStripMenuItem.Click += new System.EventHandler(this.TiendaToolStripMenuItem_Click);
            // 
            // personaYMascotaToolStripMenuItem
            // 
            this.personaYMascotaToolStripMenuItem.Name = "personaYMascotaToolStripMenuItem";
            this.personaYMascotaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personaYMascotaToolStripMenuItem.Text = "Persona y Mascota";
            this.personaYMascotaToolStripMenuItem.Click += new System.EventHandler(this.PersonaYMascotaToolStripMenuItem_Click);
            // 
            // estrellasToolStripMenuItem
            // 
            this.estrellasToolStripMenuItem.Name = "estrellasToolStripMenuItem";
            this.estrellasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estrellasToolStripMenuItem.Text = "Estrellas";
            this.estrellasToolStripMenuItem.Click += new System.EventHandler(this.EstrellasToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.InventarioToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.EstudiantesToolStripMenuItem_Click);
            // 
            // poligonoToolStripMenuItem
            // 
            this.poligonoToolStripMenuItem.Name = "poligonoToolStripMenuItem";
            this.poligonoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poligonoToolStripMenuItem.Text = "Poligono";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Tarea III";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaYMascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estrellasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poligonoToolStripMenuItem;

    }
}

