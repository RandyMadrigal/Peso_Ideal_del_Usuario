using System;
using System.Drawing;
using System.Windows.Forms;


namespace Peso_Estimado
{
    public partial class VentanaCalculo : Form
    {
        Formulas op = new Formulas();

        public VentanaCalculo()
        {
            InitializeComponent();

            DiseñoBotones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                op.PULGADA = (double.Parse(txtAltura.Text));

                txtResultado.Text = op.Promedio(op.PULGADA);

                txtLibras.Text = op.DeterminarPeso(double.Parse(txtAltura.Text)).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("LLENAR CAMPOS");
            }
        }

        public void DiseñoBotones()
        {
            btnCerrar.Image = Image.FromFile(@"Picture/calculadora.png");

            pictureNombre.Image = Image.FromFile(@"Picture/avatar.gif");
            pictureApellido.Image = Image.FromFile(@"Picture/avatar.gif");
            pictureEdad.Image = Image.FromFile(@"Picture/avatar.gif");
            pictureSexo.Image = Image.FromFile(@"Picture/avatar.gif");
        }
    }
}
