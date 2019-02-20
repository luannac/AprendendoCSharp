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
    public partial class X11 : Form
    {
        public X11()
        {
            InitializeComponent();
        }

        private void bMedia_Click(object sender, EventArgs e)
        {
            int media = (Convert.ToInt32(txNota1.Text) + Convert.ToInt32(txNota2.Text)
                        + Convert.ToInt32(txNota3.Text) + Convert.ToInt32(txNota4.Text)) / 4;

            rtbResposta.Text = "A média é igual a  :" + media + "\nSituação: ";
            if (media >= 6)
            {
                rtbResposta.Text += "Aprovado";
            }
            else
            {
                rtbResposta.Text += "Reprovado";
            }
        }

        private void txNota1_KeyPress(object sender, KeyPressEventArgs e)
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
