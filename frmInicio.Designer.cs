namespace SistemaGestionLab
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuiNICIO = new System.Windows.Forms.MenuStrip();
            this.regComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiNICIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuiNICIO
            // 
            this.menuiNICIO.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuiNICIO.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuiNICIO.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuiNICIO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regComprasToolStripMenuItem,
            this.gestInventarioToolStripMenuItem,
            this.controlPagoToolStripMenuItem});
            this.menuiNICIO.Location = new System.Drawing.Point(0, 0);
            this.menuiNICIO.Name = "menuiNICIO";
            this.menuiNICIO.Size = new System.Drawing.Size(800, 41);
            this.menuiNICIO.TabIndex = 1;
            this.menuiNICIO.Text = "menuStrip1";
            // 
            // regComprasToolStripMenuItem
            // 
            this.regComprasToolStripMenuItem.Name = "regComprasToolStripMenuItem";
            this.regComprasToolStripMenuItem.Size = new System.Drawing.Size(196, 37);
            this.regComprasToolStripMenuItem.Text = "reg.Compras";
            // 
            // gestInventarioToolStripMenuItem
            // 
            this.gestInventarioToolStripMenuItem.Name = "gestInventarioToolStripMenuItem";
            this.gestInventarioToolStripMenuItem.Size = new System.Drawing.Size(221, 37);
            this.gestInventarioToolStripMenuItem.Text = "GestInventario";
            // 
            // controlPagoToolStripMenuItem
            // 
            this.controlPagoToolStripMenuItem.Name = "controlPagoToolStripMenuItem";
            this.controlPagoToolStripMenuItem.Size = new System.Drawing.Size(189, 37);
            this.controlPagoToolStripMenuItem.Text = "ControlPago";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuiNICIO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.menuiNICIO.ResumeLayout(false);
            this.menuiNICIO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuiNICIO;
        private System.Windows.Forms.ToolStripMenuItem regComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlPagoToolStripMenuItem;
    }
}