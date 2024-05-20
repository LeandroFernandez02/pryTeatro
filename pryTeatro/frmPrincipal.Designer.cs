namespace pryTeatro
{
    partial class frmPrincipal
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
            this.mnsReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.mitQuenaken = new System.Windows.Forms.ToolStripMenuItem();
            this.mitOnas = new System.Windows.Forms.ToolStripMenuItem();
            this.mitTobas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsReservas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Reservas";
            // 
            // mnsReservas
            // 
            this.mnsReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitQuenaken,
            this.mitOnas,
            this.mitTobas});
            this.mnsReservas.Name = "mnsReservas";
            this.mnsReservas.Size = new System.Drawing.Size(64, 20);
            this.mnsReservas.Text = "Reservas";
            // 
            // mitQuenaken
            // 
            this.mitQuenaken.Name = "mitQuenaken";
            this.mitQuenaken.Size = new System.Drawing.Size(180, 22);
            this.mitQuenaken.Text = "Quenaken";
            this.mitQuenaken.Click += new System.EventHandler(this.mitQuenaken_Click);
            // 
            // mitOnas
            // 
            this.mitOnas.Name = "mitOnas";
            this.mitOnas.Size = new System.Drawing.Size(180, 22);
            this.mitOnas.Text = "Onas";
            this.mitOnas.Click += new System.EventHandler(this.mitOnas_Click);
            // 
            // mitTobas
            // 
            this.mitTobas.Name = "mitTobas";
            this.mitTobas.Size = new System.Drawing.Size(180, 22);
            this.mitTobas.Text = "Tobas";
            this.mitTobas.Click += new System.EventHandler(this.mitTobas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsReservas;
        private System.Windows.Forms.ToolStripMenuItem mitQuenaken;
        private System.Windows.Forms.ToolStripMenuItem mitOnas;
        private System.Windows.Forms.ToolStripMenuItem mitTobas;
    }
}

