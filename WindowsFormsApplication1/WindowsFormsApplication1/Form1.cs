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


            if (imc<= 18.5 )
            {

                textBoxIMC.ForeColor = Color.Red;
                textBoxIMC.Text = imc.ToString() + Environment.NewLine + "Peso Abaixo"+Environment.NewLine +"Come RAPAZ!";


            }
            else if (imc >= 25)
            {

                textBoxIMC.ForeColor = Color.Red;
                textBoxIMC.Text = imc.ToString() + Environment.NewLine + "Peso Acima" + Environment.NewLine + "Não comas RAPAZ!";


            }
            else
            {

                textBoxIMC.ForeColor = Color.Green;
                textBoxIMC.Text = imc.ToString() + Environment.NewLine + "Peso Ideal" + Environment.NewLine + "Bem jogado RAPAZ!";


            }

        }
    }
}
