using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosWindowsForm
{
    public partial class H01 : Form
    {
        public H01()
        {
            InitializeComponent();
        }

        private void bAvaliar_Click(object sender, EventArgs e)
        {
            int iValor = Convert.ToInt32(txtRecebe.Text);
                if (iValor < 0)
                {
                    lResultado.Text = "Este valor é negativo!";
                }
                if (iValor > 0)
                {
                    lResultado.Text = "Este valor é Positivo!";
                }
                if (iValor == 0)
                {
                    lResultado.Text = "Este valor é nulo!";
                }
        }

        private void txtRecebe_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtRecebe_KeyPress(object sender, KeyPressEventArgs e)
        {

            int asc = (int)e.KeyChar;

            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127 && asc!= 193)
            {

                e.Handled = true;
                MessageBox.Show("Este campo apenas aceita numeros!");

            }
        }
    }
}
