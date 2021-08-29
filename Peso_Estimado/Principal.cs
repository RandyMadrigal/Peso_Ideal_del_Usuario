using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peso_Estimado
{
    public partial class Principal : Form
    {

        private Form ActiveForm = null;

        public Principal()
        {
            InitializeComponent();

            DiseñoBotones();

            panel1.Visible = false;

        }

        public void DiseñoBotones()
        {
            LogoPicture.Image = Image.FromFile(@"Picture/logo.gif");
            
            btnmenu.Image = Image.FromFile(@"Picture/menu.png");
            
            btncalcular.Image = Image.FromFile(@"Picture/calculadora.png");
            
            btntabla.Image = Image.FromFile(@"Picture/tabla.png");
            
            btnayuda.Image = Image.FromFile(@"Picture/Ayuda.png");

            picturePrincipal.Image = Image.FromFile(@"Picture/gym.gif");
        }
        private void OpcMenu()
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            OpcMenu();
        }

        //Abrir ventana secundaria en el panel principal del reproductor.
        //Para asi mostrar las opciones de Historial y ayuda
        public void openChildForm(Form chilForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Dispose();
            }

            ActiveForm = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            PanelComplemento.Controls.Add(chilForm);
            PanelComplemento.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            openChildForm(new VentanaCalculo());

            OpcMenu();
        }

        private void btntabla_Click(object sender, EventArgs e)
        {
            openChildForm(new VentanaTabla());

            OpcMenu();
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            openChildForm(new VentanaAyuda());

            OpcMenu();
        }

    }
}
