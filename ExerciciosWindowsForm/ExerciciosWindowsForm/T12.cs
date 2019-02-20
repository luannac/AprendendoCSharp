using System;

using System.Windows.Forms;

namespace T12
{

    public partial class T12 : Form
    {

        int IXmatriz = 0, JXmatriz = 0;
        int[,] matriz = new int[6, 6]; //Matriz ordem 6
        int soma = 0, media, contador = 5; //variaveis media e soma;
        int contI = 0, contJ = 0, cont = 0;
        string text;

        public T12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            raiz();
            somaR.Text += soma.ToString();
            mediaR.Text += media.ToString();
            diagonalS.Text += text;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            raiz();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            AdicionarNumero();

        }

        private void AdicionarNumero()
        {
            if (contJ == 6)
            {
                contI++;
                contJ = 0;
            }
            if (contI == 6)
            {
                return;
            }

            matriz[contI, contJ] = Convert.ToInt32(textBox1.Text);
            contJ++;

            cont++;
            label4.Text = cont.ToString();
        }

        public void raiz()
        {

            foreach (var valor in matriz)
            {
                soma += valor;
            }

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    if (i == j)
                    {
                        diagonalS.Text += ";" + matriz[i, j];
                    }
                }
            }
            media = soma / 36;
        }
    }
}













