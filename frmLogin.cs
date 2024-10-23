using Need4Sprint.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionLab
{
    public partial class frmLogin : Form
    {
        public frmLogin()
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


        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FrmCrearCta
            frmRegistrarse frmregis = new frmRegistrarse();

            // Ocultar el formulario frmLogin
            this.Hide();

            // Mostrar el formulario FrmCrearCta de manera modal
            frmregis.ShowDialog();

            Close();
        }

        private void lblRecContraseña_Click(object sender, EventArgs e)
        {
            frmRecuContra frmRecuperar = new frmRecuContra();
            this.Hide();
            frmRecuperar.ShowDialog();
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtContra.Text;

            if (!string.IsNullOrEmpty(user) || !string.IsNullOrEmpty(pass))
            {
                ConexionBD bd = new ConexionBD(user, pass);

                if (bd.ValidarUsuario(user, pass))
                {
                    MessageBox.Show("Sesion Iniciada");
                }
                else
                {
                    MessageBox.Show("Corrobore los datos ingresados");
                }
            }

        }
        
    }
}
