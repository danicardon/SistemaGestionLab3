namespace SistemaGestionLab
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursosHumanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionInventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaOtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legajoEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.recursosHumanosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(906, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeVentasToolStripMenuItem,
            this.historialDeVentasToolStripMenuItem,
            this.estadisticasDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeComprasToolStripMenuItem,
            this.gestionInventariosToolStripMenuItem,
            this.controlDePagosToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaProveedoresToolStripMenuItem,
            this.preciosProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaClientesToolStripMenuItem,
            this.agendaOtrosToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // recursosHumanosToolStripMenuItem
            // 
            this.recursosHumanosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionPersonalToolStripMenuItem,
            this.legajoEmpleadosToolStripMenuItem});
            this.recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            this.recursosHumanosToolStripMenuItem.Size = new System.Drawing.Size(212, 29);
            this.recursosHumanosToolStripMenuItem.Text = "Recursos Humanos";
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.registroDeVentasToolStripMenuItem.Text = "Registro de ventas";
            // 
            // historialDeVentasToolStripMenuItem
            // 
            this.historialDeVentasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            this.historialDeVentasToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.historialDeVentasToolStripMenuItem.Text = "Historial de ventas";
            // 
            // estadisticasDeVentasToolStripMenuItem
            // 
            this.estadisticasDeVentasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadisticasDeVentasToolStripMenuItem.Name = "estadisticasDeVentasToolStripMenuItem";
            this.estadisticasDeVentasToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.estadisticasDeVentasToolStripMenuItem.Text = "Estadisticas de ventas";
            // 
            // registroDeComprasToolStripMenuItem
            // 
            this.registroDeComprasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroDeComprasToolStripMenuItem.Name = "registroDeComprasToolStripMenuItem";
            this.registroDeComprasToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.registroDeComprasToolStripMenuItem.Text = "Registro de compras";
            // 
            // gestionInventariosToolStripMenuItem
            // 
            this.gestionInventariosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionInventariosToolStripMenuItem.Name = "gestionInventariosToolStripMenuItem";
            this.gestionInventariosToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.gestionInventariosToolStripMenuItem.Text = "Gestion inventarios";
            // 
            // controlDePagosToolStripMenuItem
            // 
            this.controlDePagosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlDePagosToolStripMenuItem.Name = "controlDePagosToolStripMenuItem";
            this.controlDePagosToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.controlDePagosToolStripMenuItem.Text = "Control de pagos";
            // 
            // agendaProveedoresToolStripMenuItem
            // 
            this.agendaProveedoresToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendaProveedoresToolStripMenuItem.Name = "agendaProveedoresToolStripMenuItem";
            this.agendaProveedoresToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.agendaProveedoresToolStripMenuItem.Text = "Agenda proveedores";
            // 
            // preciosProveedoresToolStripMenuItem
            // 
            this.preciosProveedoresToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciosProveedoresToolStripMenuItem.Name = "preciosProveedoresToolStripMenuItem";
            this.preciosProveedoresToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.preciosProveedoresToolStripMenuItem.Text = "Precios proveedores";
            // 
            // agendaClientesToolStripMenuItem
            // 
            this.agendaClientesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendaClientesToolStripMenuItem.Name = "agendaClientesToolStripMenuItem";
            this.agendaClientesToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.agendaClientesToolStripMenuItem.Text = "Agenda clientes";
            // 
            // agendaOtrosToolStripMenuItem
            // 
            this.agendaOtrosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendaOtrosToolStripMenuItem.Name = "agendaOtrosToolStripMenuItem";
            this.agendaOtrosToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.agendaOtrosToolStripMenuItem.Text = "Agenda otros";
            // 
            // gestionPersonalToolStripMenuItem
            // 
            this.gestionPersonalToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionPersonalToolStripMenuItem.Name = "gestionPersonalToolStripMenuItem";
            this.gestionPersonalToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.gestionPersonalToolStripMenuItem.Text = "Gestion personal";
            // 
            // legajoEmpleadosToolStripMenuItem
            // 
            this.legajoEmpleadosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legajoEmpleadosToolStripMenuItem.Name = "legajoEmpleadosToolStripMenuItem";
            this.legajoEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.legajoEmpleadosToolStripMenuItem.Text = "Legajo empleados";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 847);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionInventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preciosProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaOtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legajoEmpleadosToolStripMenuItem;
    }
}