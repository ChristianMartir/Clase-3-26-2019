using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        Operacion ingreso;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtBoxA.Text);
            ingreso.V2 = double.Parse(txtBoxB.Text);
            txtBoxResultado.Text = ingreso.Suma().ToString();
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {

            ingreso = new Operacion();
            ingreso.R1 = double.Parse(txtBoxA.Text);
            ingreso.R2 = double.Parse(txtBoxB.Text);
            txtBoxResultado.Text = ingreso.Resta().ToString();

        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.M1 = double.Parse(txtBoxA.Text);
            ingreso.M2 = double.Parse(txtBoxB.Text);
            txtBoxResultado.Text = ingreso.Mult().ToString();


        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.D1 = double.Parse(txtBoxA.Text);
            ingreso.D2 = double.Parse(txtBoxB.Text);
            txtBoxResultado.Text = ingreso.Div().ToString();
        }
    }
}
