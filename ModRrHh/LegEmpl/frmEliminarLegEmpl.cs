﻿using System;
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
    public partial class frmEliminarLegEmpl : Form
    {
        public frmEliminarLegEmpl()
        {
            InitializeComponent();
            diseño();
        }

        private void frmEliminarLegEmpl_Load(object sender, EventArgs e)
        {

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

        private void btnTodo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro que quieres eliminar a [nombre]?",
                                            "Advertencia",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Warning);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}