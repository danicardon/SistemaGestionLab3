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
    public partial class frmRegistrarse : Form
    {
        private bool dibujando = false;  // Para saber si el usuario está dibujando
        private Point puntoAnterior;     // Para almacenar el último punto del mouse
        private Bitmap firmaBitmap;      // Para almacenar la imagen de la firma
        public frmRegistrarse()
        {
            InitializeComponent();
            diseño();

            // Crear el panel donde el usuario podrá dibujar la firma
            panelFirma = new Panel();
            panelFirma.Size = new Size(220, 131);
            panelFirma.Location = new Point(154, 180);
            panelFirma.BackColor = Color.White;
            panelFirma.BorderStyle = BorderStyle.FixedSingle;

            // Añadir el panel al formulario
            this.Controls.Add(panelFirma);

            // Inicializar el bitmap donde se dibujará la firma
            firmaBitmap = new Bitmap(panelFirma.Width, panelFirma.Height);

            // Asociar los eventos del mouse al panel
            panelFirma.MouseDown += new MouseEventHandler(panelfirm_MouseDown);
            panelFirma.MouseMove += new MouseEventHandler(panelfirm_MouseMove);
            panelFirma.MouseUp += new MouseEventHandler(panelfirm_MouseUp);
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

        private void lblIni_Click(object sender, EventArgs e)
        {
            frmLogin frmLog = new frmLogin();
            this.Hide();
            frmLog.ShowDialog();
            Close();
        }

        //Evento para empezar a dibujar
        private void panelfirm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dibujando = true;
                puntoAnterior = e.Location;  // Guardar la posición del mouse
            }
        }

        //Evento para dibujar mientras el mouse se mueve
        private void panelfirm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando)
            {
                using (Graphics g = Graphics.FromImage(firmaBitmap))
                {
                    g.DrawLine(Pens.Black, puntoAnterior, e.Location);  // Dibujar una línea
                }
                puntoAnterior = e.Location;  // Actualizar el último punto del mouse
                panelFirma.Invalidate();     // Forzar el repintado del panel
            }
        }

        //Evento para dejar de dibujar
        private void panelfirm_MouseUp(object sender, MouseEventArgs e)
        {
            dibujando = false;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Firma";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                // Guardar el bitmap en el archivo seleccionado
                firmaBitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Firma guardada exitosamente.");
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = panelFirma.CreateGraphics())
            {
                g.DrawImage(firmaBitmap, Point.Empty);
            }
        }
    }
}
