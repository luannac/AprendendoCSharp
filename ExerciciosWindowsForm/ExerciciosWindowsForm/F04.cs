using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F4
{
    public partial class F04 : Form
    {
        public F04()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int uni, cur;
            string[] codigoU = new string[3];
            string[] codigoC = new string[3];

            //TABELA UNIVERSIDADE
            codigoU[0] = "USP";
            codigoU[1] = "UNICAMP";
            codigoU[2] = "PUCC";

            //TABELA CURSO
            codigoC[0] = "Medicina";
            codigoC[1] = "Engenharia";
            codigoC[2] = "Licenciatura";

            //CONERTENDO O TEXTBOX EM INT.
            uni = Convert.ToInt32(textBox2.Text);
            cur = Convert.ToInt32(textBox1.Text);

            //MOSTRANDO E BUSCANDO O CONTEÚDO NAS MATRIZES
            universidade.Text = codigoU[uni-1];
            curso.Text = codigoC[cur - 1];

        }
    }
}
