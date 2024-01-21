namespace Parcial2LUG
{
    partial class FRHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresABMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taTeTiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piedraPapelTijeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDesempeñoYUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.juegosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jugadoresABMToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // jugadoresABMToolStripMenuItem
            // 
            this.jugadoresABMToolStripMenuItem.Name = "jugadoresABMToolStripMenuItem";
            this.jugadoresABMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jugadoresABMToolStripMenuItem.Text = "JugadoresABM";
            this.jugadoresABMToolStripMenuItem.Click += new System.EventHandler(this.jugadoresABMToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // juegosToolStripMenuItem
            // 
            this.juegosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taTeTiToolStripMenuItem,
            this.piedraPapelTijeraToolStripMenuItem});
            this.juegosToolStripMenuItem.Name = "juegosToolStripMenuItem";
            this.juegosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.juegosToolStripMenuItem.Text = "Juegos";
            // 
            // taTeTiToolStripMenuItem
            // 
            this.taTeTiToolStripMenuItem.Name = "taTeTiToolStripMenuItem";
            this.taTeTiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taTeTiToolStripMenuItem.Text = "TaTeTi";
            this.taTeTiToolStripMenuItem.Click += new System.EventHandler(this.taTeTiToolStripMenuItem_Click);
            // 
            // piedraPapelTijeraToolStripMenuItem
            // 
            this.piedraPapelTijeraToolStripMenuItem.Name = "piedraPapelTijeraToolStripMenuItem";
            this.piedraPapelTijeraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.piedraPapelTijeraToolStripMenuItem.Text = "Piedra Papel Tijera";
            this.piedraPapelTijeraToolStripMenuItem.Click += new System.EventHandler(this.piedraPapelTijeraToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDesempeñoYUsoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDesempeñoYUsoToolStripMenuItem
            // 
            this.reportesDesempeñoYUsoToolStripMenuItem.Name = "reportesDesempeñoYUsoToolStripMenuItem";
            this.reportesDesempeñoYUsoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.reportesDesempeñoYUsoToolStripMenuItem.Text = "Reportes Desempeño y Uso";
            this.reportesDesempeñoYUsoToolStripMenuItem.Click += new System.EventHandler(this.reportesDesempeñoYUsoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FRHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRHome";
            this.Text = "FRHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresABMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taTeTiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piedraPapelTijeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDesempeñoYUsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}