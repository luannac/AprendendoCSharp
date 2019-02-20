using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor,cont = 0;

            valor = Convert.ToInt32(textBox1.Text);


            for (int i = 2; i <= valor / 2; i++)
            {
                if (valor % i == 0)
                {
                    cont++;
                    break;
                }
            }

            if (cont == 0)
            {
                label3.Text = valor + " É PRIMO";
                label3.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label3.Text = valor + " NÃO É PRIMO";
                label3.ForeColor = System.Drawing.Color.Red;
            }
               
            
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
