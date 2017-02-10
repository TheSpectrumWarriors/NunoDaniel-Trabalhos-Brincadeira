using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


         


        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {


            float peso;
            float altura;
            float imc;

            peso = float.Parse(textBoxPeso.Text);
            altura = float.Parse(textBoxAltura.Text);


            imc = peso / (altura * altura);

            textBoxIMC.Text = imc.ToString();



        }
    }
}
