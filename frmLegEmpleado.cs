using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionLab
{
    public partial class frmLegEmpleado : Form
    {
        public frmLegEmpleado()
        {
            InitializeComponent();
            diseño();
        }
        public void diseño()
        {
            Color colorFondo = ColorTranslator.FromHtml("#181a20");
            Color colorTextBox = ColorTranslator.FromHtml("#E0E0E0");
            Color colorContenedores = ColorTranslator.FromHtml("#FFFF00");


            this.BackColor = colorFondo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) control.BackColor = colorTextBox;

                if (control is TreeView || control is Panel) control.BackColor = colorContenedores;

                if (control is GroupBox)
                {

                    control.BackColor = colorFondo;
                    foreach (Control c in control.Controls)
                    {

                        if (c is TextBox) c.ForeColor = Color.Black;
                    }
                }
                if (control is Button) control.BackColor = colorContenedores;


            }
        }
        private void frmLegEmpleado_Load(object sender, EventArgs e)
        {
            dgvLegEmpl.Font = new Font("Microsoft Sans Serif", 10.08f);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //volver a menu principal
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModLegEmpl frmModLegEmpl = new frmModLegEmpl();  
            frmModLegEmpl.ShowDialog(); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarLegEmpl frm =new frmAgregarLegEmpl();
            frm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
