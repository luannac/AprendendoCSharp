using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor;
            int valorH = 1;

            valor = Convert.ToInt32(textBox1.Text);

            for(int i = 2; i <= valor; i++)
            {
                valorH += i * i;
            }

            label1.Text = "H = (1 X 1)... ("+valor+" X "+valor+")";
            label3.Text = "Valor do H é : "+valorH.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void KeyPressNumberControler(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;

            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127)
            {

                e.Handled = true;
                MessageBox.Show("Este campo apenas aceita numeros Positivos!");

            }
        }
    }
}
