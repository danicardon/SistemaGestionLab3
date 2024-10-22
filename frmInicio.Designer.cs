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
            this.menuiNICIO = new System.Windows.Forms.MenuStrip();
            this.crearCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiNICIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuiNICIO
            // 
            this.menuiNICIO.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuiNICIO.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuiNICIO.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuiNICIO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCuentaToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.agendaToolStripMenuItem});
            this.menuiNICIO.Location = new System.Drawing.Point(0, 0);
            this.menuiNICIO.Name = "menuiNICIO";
            this.menuiNICIO.Size = new System.Drawing.Size(800, 38);
            this.menuiNICIO.TabIndex = 1;
            this.menuiNICIO.Text = "menuStrip1";
            // 
            // crearCuentaToolStripMenuItem
            // 
            this.crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            this.crearCuentaToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.crearCuentaToolStripMenuItem.Text = "Crear cuenta";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeVentaToolStripMenuItem,
            this.historialDeVentasToolStripMenuItem,
            this.estadísticasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(104, 34);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registroDeVentaToolStripMenuItem
            // 
            this.registroDeVentaToolStripMenuItem.Name = "registroDeVentaToolStripMenuItem";
            this.registroDeVentaToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.registroDeVentaToolStripMenuItem.Text = "Registro de Venta";
            // 
            // historialDeVentasToolStripMenuItem
            // 
            this.historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            this.historialDeVentasToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.historialDeVentasToolStripMenuItem.Text = "Historial de Ventas";
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(111, 34);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuiNICIO);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.menuiNICIO.ResumeLayout(false);
            this.menuiNICIO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuiNICIO;
        private System.Windows.Forms.ToolStripMenuItem crearCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
    }
}