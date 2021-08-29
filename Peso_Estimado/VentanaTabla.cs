using System.Drawing;
using System.Windows.Forms;

namespace Peso_Estimado
{
    public partial class VentanaTabla : Form
    {
        public VentanaTabla()
        {
            InitializeComponent();

            DiseñoBotones();
        }

        public void DiseñoBotones()
        {
            tablaspicture.Image = Image.FromFile(@"Picture/pesa.png");

        }

    }
}
