namespace SistemaGestionLab
{
    partial class frmCompras
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistorial = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Location = new System.Drawing.Point(0, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegistro,
            this.menuInventario,
            this.menuHistorial,
            this.MenuPagos});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 38);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MenuRegistro
            // 
            this.MenuRegistro.Name = "MenuRegistro";
            this.MenuRegistro.Size = new System.Drawing.Size(132, 34);
            this.MenuRegistro.Text = "REGISTRO ";
            // 
            // menuInventario
            // 
            this.menuInventario.Name = "menuInventario";
            this.menuInventario.Size = new System.Drawing.Size(250, 34);
            this.menuInventario.Text = "GESTION INVENTARIO";
            // 
            // menuHistorial
            // 
            this.menuHistorial.Name = "menuHistorial";
            this.menuHistorial.Size = new System.Drawing.Size(134, 34);
            this.menuHistorial.Text = "HISTORIAL";
            // 
            // MenuPagos
            // 
            this.MenuPagos.Name = "MenuPagos";
            this.MenuPagos.Size = new System.Drawing.Size(95, 34);
            this.MenuPagos.Text = "PAGOS";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MenuRegistro;
        private System.Windows.Forms.ToolStripMenuItem menuInventario;
        private System.Windows.Forms.ToolStripMenuItem menuHistorial;
        private System.Windows.Forms.ToolStripMenuItem MenuPagos;
    }
}