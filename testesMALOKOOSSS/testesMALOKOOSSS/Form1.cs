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



        public int DoStuf(int Number1, int Number2)
        {
           

            int Resultado;

             Resultado = Number1 + Number2;

            return Resultado;


        }



        private void buttonTeste_Click(object sender, EventArgs e)
        {


            DoStuf(int.Parse(textBoxNumber1.Text), int.Parse(textBoxNumber1.Text));

            textBoxTeste.Text = Resultado.ToString;
        }
    }
}