﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testesMALOKOOSSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int DoStuf(int Number1, int Number2)
        {
           
            int  Resultado = Number1 + Number2;
            return Resultado;

        }


        private void buttonTeste_Click(object sender, EventArgs e)
        {

            // Tás a guardar os dados que obtens do DoStuff (um int) num novo int resultado;
            int resultado = DoStuf(int.Parse(textBoxNumber1.Text), int.Parse(textBoxNumber2.Text));

            textBoxTeste.Text = resultado.ToString();
        }


       

        private void buttonAdicionarNomes_Click(object sender, EventArgs e)
        {

            int cont = 1;



            string[] nomes = new string[10];

            nomes[cont] = textBoxNomes.Text;

            textBoxNomes.Text = "";
            cont = cont + 1;

            for (int i = 0; i < cont; i++)
            { 
                 textBoxListaNomes.Text = nomes[i] + Environment.NewLine;
            }
            
        }
    }
}
