﻿using System;
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
