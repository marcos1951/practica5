using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
          int op = int.Parse(numero1.Text) + int.Parse(numero2.Text);
          resultado.Text = op.ToString();
        
        }


        private void resta_Click(object sender, EventArgs e)
        {
            int op1 = int.Parse(numero1.Text) - int.Parse(numero2.Text);
            resultado.Text = op1.ToString();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            int op2 = int.Parse(numero1.Text) * int.Parse(numero2.Text);
            resultado.Text = op2.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
           int op3 = int.Parse(numero1.Text) / int.Parse(numero2.Text);
           resultado.Text = op3.ToString();

        }

    }
}
